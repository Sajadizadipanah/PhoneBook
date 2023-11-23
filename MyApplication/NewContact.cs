using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infrastructure;


namespace MyApplication;

public partial class NewContact : System.Windows.Forms.Form
{

    DatabaseContext? databaseContext = null;
    private PhoneBookForm _phoneBookForm;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public NewContact(PhoneBookForm form) : base()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        _phoneBookForm = form;
        InitializeComponent();
        this.BringToFront();
        this.UpdateZOrder();
    }





    private void resetButton_Click(object sender, EventArgs e)
    {
        ResetForm();
    }
    public void ResetForm()
    {
        nameTextBox.Text = string.Empty;
        familyTextBox.Text = string.Empty;
        administrativePositionTextBox.Text = string.Empty;
        officePhoneTextBox.Text = string.Empty;
        mobilePhone1TextBox.Text = string.Empty;
        mobilePhone2TextBox.Text = string.Empty;
        testOrganizationComboBox.Text = string.Empty;
        nameTextBox.Focus();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {

        if (Infrastructure.Utility.CurrentContact is not null)
        {
            if (this.editButton.Visible == false)
            {
                _phoneBookForm.InformationFormLoad(this);
            }
            else
            {
                this.Dispose();
                Utility.CurrentContact = null;
                Close();
            }
        }
        else
        {
            this.Dispose();
            Close();
        }


    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        nameTextBox.Text =
            Infrastructure.Utility
            .FixText(text: nameTextBox.Text);

        familyTextBox.Text =
            Infrastructure.Utility
            .FixText(text: familyTextBox.Text);

        administrativePositionTextBox.Text =
            Infrastructure.Utility
            .FixText(text: administrativePositionTextBox.Text);

        officePhoneTextBox.Text =
            Infrastructure.Utility
            .FixText(text: officePhoneTextBox.Text);

        mobilePhone1TextBox.Text =
            Infrastructure.Utility
            .FixText(text: mobilePhone1TextBox.Text);

        mobilePhone2TextBox.Text =
            Infrastructure.Utility
            .FixText(text: mobilePhone2TextBox.Text);

        var newContact = new Domain.Contact();

        newContact.Name = nameTextBox.Text;

        newContact.LastName = familyTextBox.Text;

        newContact.Position = administrativePositionTextBox.Text;

        newContact.OfficePhone = officePhoneTextBox.Text;

        newContact.MobilePhone1 = mobilePhone1TextBox.Text;

        newContact.MobilePhone2 = mobilePhone2TextBox.Text;

        newContact.Organization = testOrganizationComboBox.Text;



        if (nameTextBox.Text == string.Empty
           || familyTextBox.Text == string.Empty
           || administrativePositionTextBox.Text == string.Empty
           || testOrganizationComboBox.Text == string.Empty
           )
        {
            var errorMessage =
                "لطفا نام ، نام خانوادگی ، قسمت و سمت را تکمیل کنید";

            System.Windows.Forms.MessageBox.Show(text: errorMessage);

            nameTextBox.Focus();

            return;
        }



        Persistence.DatabaseContext? databaseContext = null;

        try
        {
            databaseContext = new();
            databaseContext.Add(entity: newContact);
            databaseContext.SaveChanges();
            MessageBox.Show(text: "مخاطب اضافه گردید");
            this.Dispose();
            ResetForm();
            _phoneBookForm.RefreshContactDataGrid();

            Close();

        }
        catch (System.Exception ex)
        {
            System.Windows.Forms.MessageBox
                .Show(text: $"Error: {ex.Message}");
        }
        finally
        {
            databaseContext?.Dispose();
            databaseContext = null;
        }

    }


    private void deleteContactButton_Click(object sender, EventArgs e)
    {
        var dialogResult = MessageBox.Show(
      defaultButton: MessageBoxDefaultButton.Button2,
      text: "آیا از حذف مخاطب اطمینان دارید؟",
      buttons: MessageBoxButtons.YesNo,
      caption: "حذف مخاطب",
      icon: MessageBoxIcon.Question
      );
        if (dialogResult == DialogResult.Yes)
        {
            try
            {
                databaseContext = new();
                var foundedContact = databaseContext.Contacts.Where(c => c.Id == Utility.CurrentContact.Id).FirstOrDefault();
                databaseContext.Remove(foundedContact);
                databaseContext.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
            finally
            {
                databaseContext?.Dispose();
            }
            if (_phoneBookForm is not null)
            {
                _phoneBookForm.RefreshContactDataGrid();
            }

            this.Dispose();
            Close();
        }
    }

    private void editButton_Click(object sender, EventArgs e)
    {
        EditForm();
    }

    public void EditForm()
    {

        saveEditButton.Visible = true;
        resetButton.Visible = false;
        saveButton.Visible = false;
        deleteContactButton.Visible = true;
        nameTextBox.Enabled = true;
        familyTextBox.Enabled = true;
        administrativePositionTextBox.Enabled = true;
        officePhoneTextBox.Enabled = true;
        mobilePhone1TextBox.Enabled = true;
        mobilePhone2TextBox.Enabled = true;
        editButton.Visible = false;
        testOrganizationComboBox.Enabled = true;
        this.Text = "Edit Contact";
    }
    private void saveEditButton_Click(object sender, EventArgs e)
    {
        Persistence.DatabaseContext? databaseContext = null;
        try
        {
            databaseContext = new Persistence.DatabaseContext();
            var foundedContact = databaseContext.Contacts.Where(c => c.Id == Utility.CurrentContact.Id).FirstOrDefault();
            if (foundedContact == null)
            {
                Close();
                return;
            }
            if (nameTextBox.Text == string.Empty
               || familyTextBox.Text == string.Empty
               || administrativePositionTextBox.Text == string.Empty
                || testOrganizationComboBox.Text == string.Empty)
            {
                var errorMessage =
                    "لطفا نام ، نام خانوادگی ، قسمت و سمت را تکمیل کنید";
                MessageBox.Show(text: errorMessage);

                nameTextBox.Focus();

                return;
            }


            nameTextBox.Text = Infrastructure.Utility
                .FixText(text: nameTextBox.Text);

            familyTextBox.Text = Infrastructure.Utility
                .FixText(text: familyTextBox.Text);

            administrativePositionTextBox.Text = Infrastructure.Utility
                .FixText(text: administrativePositionTextBox.Text);

            officePhoneTextBox.Text = Infrastructure.Utility
                .FixText(text: officePhoneTextBox.Text);

            mobilePhone1TextBox.Text = Infrastructure.Utility
                .FixText(text: mobilePhone1TextBox.Text);

            foundedContact.Name = nameTextBox.Text;

            foundedContact.LastName = familyTextBox.Text;

            foundedContact.Position = administrativePositionTextBox.Text;

            foundedContact.OfficePhone = officePhoneTextBox.Text;

            foundedContact.MobilePhone1 = mobilePhone1TextBox.Text;

            foundedContact.MobilePhone2 = mobilePhone2TextBox.Text;

            foundedContact.Organization = testOrganizationComboBox.Text;



            databaseContext =
               new Persistence.DatabaseContext();
            databaseContext.Update(entity: foundedContact);
            databaseContext.SaveChanges();

            MessageBox.Show(text: "تغییرات با موفقیت اعمال شد");
            _phoneBookForm.RefreshContactDataGrid();
            this.Dispose();
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
        }
        finally
        {

            databaseContext?.Dispose();
            databaseContext = null;
        }
    }

    public void memberTestOrganizationComboBob()
    {
        testOrganizationComboBox.Items.AddRange(new object[] { " مدیر", "معاون", "رییس دفتر", "مشاور", "حسابدار", "منشی ", "سرایدار ", });

    }
    private void NewContact_Load(object sender, EventArgs e)
    {
    }


}
