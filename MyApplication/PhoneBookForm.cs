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

public partial class PhoneBookForm : Infrastructure.BaseForm
{
    public static PhoneBookForm? ActiveInstance { get; private set; }
    private System.Threading.Timer _timer;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public PhoneBookForm() : base()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        InitializeComponent();
        ActiveInstance = this;
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private List<Contact> Contacts;

    private void MainForm_Load(object sender, EventArgs e)
    {
        RefreshContactDataGrid();
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        timer1.Interval = (1 * 1000);
        timer1.Tick += new EventHandler(timer1_Tick);
        timer1.Start();


    }

    public async void RefreshContactDataGrid()
    {
        Persistence.DatabaseContext? databaseContext = null;
        databaseContext = new Persistence.DatabaseContext();
        Contacts = await databaseContext.Contacts.ToListAsync();
        phoneBookDataGridView.DataSource = Contacts;
    }

    private SearchContact? MysearchContact { get; set; }

    private void searchContactButton_Click(object sender, EventArgs e)
    {
        if (MysearchContact == null || MysearchContact.IsDisposed)
        {
            MysearchContact = new SearchContact(this)
            {

            };
        }

        MysearchContact.ShowDialog();

    }

    private NewContact? MynewContact { get; set; }

    private void newContactButton_Click(object sender, EventArgs e)
    {
        if (MynewContact == null || MynewContact.IsDisposed)
        {
            MynewContact = new NewContact(this)
            {

            };
            NewContactForm();
        }
        MynewContact.ShowDialog();
    }

    public void NewContactForm()
    {
        MynewContact.deleteContactButton.Visible = false;
        MynewContact.saveEditButton.Visible = false;
        MynewContact.editButton.Visible = false;
        MynewContact.saveButton.Visible = true;
        MynewContact.Text = "New Contact";
    }
    public NewContact? MyInformationFormInPhoneBook { get; set; }

    private void phoneBookDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            Infrastructure.Utility.CurrentContact =
                phoneBookDataGridView.Rows[e.RowIndex].DataBoundItem as Contact;

            if (MyInformationFormInPhoneBook == null || MyInformationFormInPhoneBook.IsDisposed)
            {
                MyInformationFormInPhoneBook = new NewContact(this)
                {
                };
                InformationFormLoad(MyInformationFormInPhoneBook);
            }
            MyInformationFormInPhoneBook.ShowDialog();

        }
    }

    public void InformationFormLoad(NewContact informationForm)
    {
        informationForm.saveButton.Visible = false;
        informationForm.saveEditButton.Visible = false;
        informationForm.resetButton.Visible = false;
        informationForm.deleteContactButton.Visible = false;
        informationForm.nameTextBox.Enabled = false;
        informationForm.familyTextBox.Enabled = false;
        informationForm.administrativePositionTextBox.Enabled = false;
        informationForm.officePhoneTextBox.Enabled = false;
        informationForm.mobilePhone1TextBox.Enabled = false;
        informationForm.mobilePhone2TextBox.Enabled = false;
        informationForm.editButton.Visible = true;
        informationForm.testOrganizationComboBox.Enabled = false;
        informationForm.nameTextBox.Text = Infrastructure.Utility.CurrentContact.Name;
        informationForm.familyTextBox.Text = Infrastructure.Utility.CurrentContact.LastName;
        informationForm.administrativePositionTextBox.Text = Infrastructure.Utility.CurrentContact.Position;
        informationForm.officePhoneTextBox.Text = Infrastructure.Utility.CurrentContact.OfficePhone;
        informationForm.mobilePhone1TextBox.Text = Infrastructure.Utility.CurrentContact.MobilePhone1;
        informationForm.mobilePhone2TextBox.Text = Infrastructure.Utility.CurrentContact.MobilePhone2;
        informationForm.testOrganizationComboBox.Text = Infrastructure.Utility.CurrentContact.Organization;
        informationForm.Text = "Contact Information";
    }
    
    private void timer1_Tick(object sender, EventArgs e)
    {
        timePicker.Value = DateTime.Now;
        timePicker.Enabled = true;
        timePicker.Update();
        timePicker.Refresh();
    }

}
