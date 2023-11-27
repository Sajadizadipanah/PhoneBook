namespace MyApplication
{
    partial class NewContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saveButton = new Dtat.Windows.Forms.Button();
            resetButton = new Dtat.Windows.Forms.Button();
            cancelButton = new Dtat.Windows.Forms.Button();
            mobilePhone1TextBox = new Dtat.Windows.Forms.TextBox();
            officePhoneTextBox = new Dtat.Windows.Forms.TextBox();
            administrativePositionTextBox = new Dtat.Windows.Forms.TextBox();
            familyTextBox = new Dtat.Windows.Forms.TextBox();
            nameTextBox = new Dtat.Windows.Forms.TextBox();
            nameLabel = new Dtat.Windows.Forms.Label();
            familyLabel = new Dtat.Windows.Forms.Label();
            administrativePositionLabel = new Dtat.Windows.Forms.Label();
            officePhoneLabel = new Dtat.Windows.Forms.Label();
            mobilePhone1Label = new Dtat.Windows.Forms.Label();
            editButton = new Dtat.Windows.Forms.Button();
            saveEditButton = new Dtat.Windows.Forms.Button();
            deleteContactButton = new Dtat.Windows.Forms.Button();
            mobilePhone2Label = new Dtat.Windows.Forms.Label();
            mobilePhone2TextBox = new Dtat.Windows.Forms.TextBox();
            organizationLabel = new Dtat.Windows.Forms.Label();
            testOrganizationComboBox = new ComboBox();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(118, 214);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 12;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(199, 214);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 14;
            resetButton.Text = "&Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(280, 214);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 17;
            cancelButton.Text = "&Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // mobilePhone1TextBox
            // 
            mobilePhone1TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mobilePhone1TextBox.Location = new Point(99, 151);
            mobilePhone1TextBox.Name = "mobilePhone1TextBox";
            mobilePhone1TextBox.PlaceholderText = "09121234567";
            mobilePhone1TextBox.Size = new Size(256, 23);
            mobilePhone1TextBox.TabIndex = 11;
            // 
            // officePhoneTextBox
            // 
            officePhoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            officePhoneTextBox.Location = new Point(99, 122);
            officePhoneTextBox.Name = "officePhoneTextBox";
            officePhoneTextBox.PlaceholderText = "12345";
            officePhoneTextBox.Size = new Size(256, 23);
            officePhoneTextBox.TabIndex = 9;
            // 
            // administrativePositionTextBox
            // 
            administrativePositionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            administrativePositionTextBox.Location = new Point(99, 93);
            administrativePositionTextBox.Name = "administrativePositionTextBox";
            administrativePositionTextBox.RightToLeft = RightToLeft.Yes;
            administrativePositionTextBox.Size = new Size(256, 23);
            administrativePositionTextBox.TabIndex = 7;
            // 
            // familyTextBox
            // 
            familyTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            familyTextBox.Location = new Point(99, 35);
            familyTextBox.Name = "familyTextBox";
            familyTextBox.RightToLeft = RightToLeft.Yes;
            familyTextBox.Size = new Size(256, 23);
            familyTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(99, 6);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.RightToLeft = RightToLeft.Yes;
            nameTextBox.Size = new Size(256, 23);
            nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "&Name";
            // 
            // familyLabel
            // 
            familyLabel.AutoSize = true;
            familyLabel.Location = new Point(3, 38);
            familyLabel.Name = "familyLabel";
            familyLabel.Size = new Size(42, 15);
            familyLabel.TabIndex = 2;
            familyLabel.Text = "&Family";
            // 
            // administrativePositionLabel
            // 
            administrativePositionLabel.AutoSize = true;
            administrativePositionLabel.Location = new Point(3, 96);
            administrativePositionLabel.Name = "administrativePositionLabel";
            administrativePositionLabel.Size = new Size(50, 15);
            administrativePositionLabel.TabIndex = 6;
            administrativePositionLabel.Text = "&Position";
            // 
            // officePhoneLabel
            // 
            officePhoneLabel.AutoSize = true;
            officePhoneLabel.Location = new Point(3, 125);
            officePhoneLabel.Name = "officePhoneLabel";
            officePhoneLabel.Size = new Size(76, 15);
            officePhoneLabel.TabIndex = 8;
            officePhoneLabel.Text = "&Office Phone";
            // 
            // mobilePhone1Label
            // 
            mobilePhone1Label.AutoSize = true;
            mobilePhone1Label.Location = new Point(3, 154);
            mobilePhone1Label.Name = "mobilePhone1Label";
            mobilePhone1Label.Size = new Size(90, 15);
            mobilePhone1Label.TabIndex = 10;
            mobilePhone1Label.Text = "&Mobile Phone 1";
            // 
            // editButton
            // 
            editButton.Location = new Point(199, 214);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 16;
            editButton.Text = "&Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // saveEditButton
            // 
            saveEditButton.Location = new Point(118, 214);
            saveEditButton.Name = "saveEditButton";
            saveEditButton.Size = new Size(75, 23);
            saveEditButton.TabIndex = 13;
            saveEditButton.Text = "&Save Edit";
            saveEditButton.UseVisualStyleBackColor = true;
            saveEditButton.Click += saveEditButton_Click;
            // 
            // deleteContactButton
            // 
            deleteContactButton.Location = new Point(199, 214);
            deleteContactButton.Name = "deleteContactButton";
            deleteContactButton.Size = new Size(75, 23);
            deleteContactButton.TabIndex = 15;
            deleteContactButton.Text = "&Delete";
            deleteContactButton.UseVisualStyleBackColor = true;
            deleteContactButton.Click += deleteContactButton_Click;
            // 
            // mobilePhone2Label
            // 
            mobilePhone2Label.AutoSize = true;
            mobilePhone2Label.Location = new Point(3, 183);
            mobilePhone2Label.Name = "mobilePhone2Label";
            mobilePhone2Label.Size = new Size(90, 15);
            mobilePhone2Label.TabIndex = 12;
            mobilePhone2Label.Text = "&Mobile Phone 2";
            // 
            // mobilePhone2TextBox
            // 
            mobilePhone2TextBox.Location = new Point(99, 180);
            mobilePhone2TextBox.MaxLength = 50;
            mobilePhone2TextBox.Name = "mobilePhone2TextBox";
            mobilePhone2TextBox.PlaceholderText = "09121234567";
            mobilePhone2TextBox.Size = new Size(256, 23);
            mobilePhone2TextBox.TabIndex = 13;
            // 
            // organizationLabel
            // 
            organizationLabel.AutoSize = true;
            organizationLabel.Location = new Point(3, 67);
            organizationLabel.Name = "organizationLabel";
            organizationLabel.Size = new Size(75, 15);
            organizationLabel.TabIndex = 4;
            organizationLabel.Text = "Or&ganization";
            // 
            // testOrganizationComboBox
            // 
            testOrganizationComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            testOrganizationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            testOrganizationComboBox.FormattingEnabled = true;
            testOrganizationComboBox.Location = new Point(99, 64);
            testOrganizationComboBox.Name = "testOrganizationComboBox";
            testOrganizationComboBox.RightToLeft = RightToLeft.Yes;
            testOrganizationComboBox.Size = new Size(256, 23);
            testOrganizationComboBox.Sorted = true;
            testOrganizationComboBox.TabIndex = 5;
            memberTestOrganizationComboBob();
            // 
            // NewContact
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 249);
            ControlBox = false;
            Controls.Add(testOrganizationComboBox);
            Controls.Add(organizationLabel);
            Controls.Add(mobilePhone2TextBox);
            Controls.Add(mobilePhone2Label);
            Controls.Add(deleteContactButton);
            Controls.Add(saveEditButton);
            Controls.Add(editButton);
            Controls.Add(mobilePhone1Label);
            Controls.Add(officePhoneLabel);
            Controls.Add(administrativePositionLabel);
            Controls.Add(familyLabel);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(familyTextBox);
            Controls.Add(administrativePositionTextBox);
            Controls.Add(officePhoneTextBox);
            Controls.Add(mobilePhone1TextBox);
            Controls.Add(cancelButton);
            Controls.Add(resetButton);
            Controls.Add(saveButton);
            MaximumSize = new Size(377, 288);
            MinimumSize = new Size(377, 288);
            Name = "NewContact";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Contact";
            Load += NewContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Dtat.Windows.Forms.Button saveButton;
        public Dtat.Windows.Forms.Button resetButton;
        public Dtat.Windows.Forms.Button cancelButton;
        public Dtat.Windows.Forms.TextBox mobilePhone1TextBox;
        public Dtat.Windows.Forms.TextBox officePhoneTextBox;
        public Dtat.Windows.Forms.TextBox administrativePositionTextBox;
        public Dtat.Windows.Forms.TextBox familyTextBox;
        public Dtat.Windows.Forms.Label nameLabel;
        public Dtat.Windows.Forms.Label familyLabel;
        public Dtat.Windows.Forms.Label administrativePositionLabel;
        public Dtat.Windows.Forms.Label officePhoneLabel;
        public Dtat.Windows.Forms.Label mobilePhone1Label;
        public Dtat.Windows.Forms.TextBox nameTextBox;
        public Dtat.Windows.Forms.Button editButton;
        public Dtat.Windows.Forms.Button saveEditButton;
        public Dtat.Windows.Forms.Button deleteContactButton;
        public Dtat.Windows.Forms.Label mobilePhone2Label;
        public Dtat.Windows.Forms.TextBox mobilePhone2TextBox;
        public Dtat.Windows.Forms.Label organizationLabel;
        public ComboBox testOrganizationComboBox;
    }
}