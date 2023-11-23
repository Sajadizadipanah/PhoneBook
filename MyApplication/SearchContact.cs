using Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace MyApplication;

public partial class SearchContact : System.Windows.Forms.Form
{
    public static SearchContact? ActiveInstance { get; private set; }
    private List<Contact> contacts;
    private PhoneBookForm _phoneBookForm;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public SearchContact(PhoneBookForm phoneBookForm) : base()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    {
        _phoneBookForm = phoneBookForm;
        InitializeComponent();
        ActiveInstance = this;
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        this.Dispose();
        Close();
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
        Search();
    }

    private void Search()
    {
        Persistence.DatabaseContext? databaseContext = null;

        try
        {
            databaseContext =
                new DatabaseContext();

            searchByFamilyTextBox.Text =
                 Infrastructure.Utility
                 .FixText(text: searchByFamilyTextBox.Text);

            List<Contact> contacts;

            if (searchByFamilyTextBox.Text == string.Empty)
            {
                contacts = databaseContext.Contacts.ToList();
            }
            else
            {

                contacts =
                    databaseContext.Contacts
                    .Where(current => current.Name != null && current.LastName != null && current.Position != null &&
                        current.LastName.ToLower().Contains(searchByFamilyTextBox.Text.ToLower()) ||
                        current.Name.ToLower().Contains(searchByFamilyTextBox.Text.ToLower()) ||
                        current.Position.ToLower().Contains(searchByFamilyTextBox.Text.ToLower()))
                    .ToList()
                    ;
            }

            searchDataGridView.DataSource = contacts;

            searchByFamilyTextBox.SelectAll();
            searchByFamilyTextBox.Focus();
        }
        catch (System.Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(text: ex.Message);

            searchByFamilyTextBox.Focus();
        }
        finally
        {
            databaseContext?.Dispose();
            databaseContext = null;
        }
    }

    private void SearchContact_Load(object sender, EventArgs e)
    {
        RefreshContactDataGrid();
    }
    public async void RefreshContactDataGrid()
    {
        Persistence.DatabaseContext? databaseContext = null;
        databaseContext = new Persistence.DatabaseContext();
        contacts = await databaseContext.Contacts.ToListAsync();
        searchDataGridView.DataSource = contacts;
        _phoneBookForm.RefreshContactDataGrid();
    }

    public NewContact? MyInformationFormInSearchContact { get; set; }
    private void searchDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            Infrastructure.Utility.CurrentContact =
                searchDataGridView.Rows[e.RowIndex].DataBoundItem as Contact;

            if (MyInformationFormInSearchContact == null || MyInformationFormInSearchContact.IsDisposed)
            {
                MyInformationFormInSearchContact = new NewContact(_phoneBookForm)
                {

                };
                MyInformationFormInSearchContact.saveButton.Visible = false;
                MyInformationFormInSearchContact.saveEditButton.Visible = false;
                MyInformationFormInSearchContact.resetButton.Visible = false;
                MyInformationFormInSearchContact.deleteContactButton.Visible = false;
                MyInformationFormInSearchContact.nameTextBox.Enabled = false;
                MyInformationFormInSearchContact.familyTextBox.Enabled = false;
                MyInformationFormInSearchContact.administrativePositionTextBox.Enabled = false;
                MyInformationFormInSearchContact.officePhoneTextBox.Enabled = false;
                MyInformationFormInSearchContact.mobilePhone1TextBox.Enabled = false;
                MyInformationFormInSearchContact.mobilePhone2TextBox.Enabled = false;
                MyInformationFormInSearchContact.testOrganizationComboBox.Enabled = false;

                MyInformationFormInSearchContact.nameTextBox.Text = Infrastructure.Utility.CurrentContact.Name;
                MyInformationFormInSearchContact.familyTextBox.Text = Infrastructure.Utility.CurrentContact.LastName;
                MyInformationFormInSearchContact.administrativePositionTextBox.Text = Infrastructure.Utility.CurrentContact.Position;
                MyInformationFormInSearchContact.officePhoneTextBox.Text = Infrastructure.Utility.CurrentContact.OfficePhone;
                MyInformationFormInSearchContact.mobilePhone1TextBox.Text = Infrastructure.Utility.CurrentContact.MobilePhone1;
                MyInformationFormInSearchContact.mobilePhone2TextBox.Text = Infrastructure.Utility.CurrentContact.MobilePhone2;
                MyInformationFormInSearchContact.testOrganizationComboBox.Text = Infrastructure.Utility.CurrentContact.Organization;
            }
            MyInformationFormInSearchContact.ShowDialog();

        }
    }
}

