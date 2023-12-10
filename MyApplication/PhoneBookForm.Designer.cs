namespace MyApplication
{
    partial class PhoneBookForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            searchContactButton = new Dtat.Windows.Forms.Button();
            newContactButton = new Dtat.Windows.Forms.Button();
            timePicker = new DateTimePicker();
            exitButton = new Dtat.Windows.Forms.Button();
            phoneBookDataGridView = new Dtat.Windows.Forms.DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            administratorLabels = new Dtat.Windows.Forms.Label();
            label1 = new Dtat.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)phoneBookDataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchContactButton
            // 
            searchContactButton.Anchor = AnchorStyles.None;
            searchContactButton.Location = new Point(2, 10);
            searchContactButton.Name = "searchContactButton";
            searchContactButton.Size = new Size(75, 23);
            searchContactButton.TabIndex = 0;
            searchContactButton.Text = "&Search Contact";
            searchContactButton.UseVisualStyleBackColor = true;
            searchContactButton.Click += searchContactButton_Click;
            // 
            // newContactButton
            // 
            newContactButton.Anchor = AnchorStyles.None;
            newContactButton.Location = new Point(83, 10);
            newContactButton.Name = "newContactButton";
            newContactButton.Size = new Size(75, 23);
            newContactButton.TabIndex = 1;
            newContactButton.Text = "&New Contact";
            newContactButton.UseVisualStyleBackColor = true;
            newContactButton.Click += newContactButton_Click;
            // 
            // timePicker
            // 
            timePicker.Anchor = AnchorStyles.None;
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(251, 10);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(154, 23);
            timePicker.TabIndex = 5;
            timePicker.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.None;
            exitButton.FlatStyle = FlatStyle.Popup;
            exitButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Location = new Point(330, 382);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // phoneBookDataGridView
            // 
            phoneBookDataGridView.AllowUserToAddRows = false;
            phoneBookDataGridView.AllowUserToDeleteRows = false;
            phoneBookDataGridView.AllowUserToResizeRows = false;
            phoneBookDataGridView.Anchor = AnchorStyles.None;
            phoneBookDataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            phoneBookDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            phoneBookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phoneBookDataGridView.Location = new Point(2, 42);
            phoneBookDataGridView.MultiSelect = false;
            phoneBookDataGridView.Name = "phoneBookDataGridView";
            phoneBookDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            phoneBookDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            phoneBookDataGridView.RowHeadersVisible = false;
            phoneBookDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            phoneBookDataGridView.RowTemplate.Height = 25;
            phoneBookDataGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            phoneBookDataGridView.Size = new Size(403, 334);
            phoneBookDataGridView.TabIndex = 7;
            phoneBookDataGridView.CellDoubleClick += phoneBookDataGridView_CellDoubleClick;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // administratorLabels
            // 
            administratorLabels.Anchor = AnchorStyles.None;
            administratorLabels.AutoSize = true;
            administratorLabels.Location = new Point(2, 379);
            administratorLabels.Name = "administratorLabels";
            administratorLabels.Size = new Size(75, 15);
            administratorLabels.TabIndex = 10;
            administratorLabels.Text = "@Izadipanah";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(2, 394);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 11;
            label1.Text = "Sajad10375@gmail.com";
            // 
            // PhoneBookForm
            // 
            AcceptButton = searchContactButton;
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = exitButton;
            ClientSize = new Size(414, 411);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(administratorLabels);
            Controls.Add(phoneBookDataGridView);
            Controls.Add(searchContactButton);
            Controls.Add(newContactButton);
            Controls.Add(exitButton);
            Controls.Add(timePicker);
            MaximumSize = new Size(430, 450);
            MinimumSize = new Size(430, 450);
            Name = "PhoneBookForm";
            Text = "Phone Book";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)phoneBookDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Dtat.Windows.Forms.Button searchContactButton;
        public Dtat.Windows.Forms.Button newContactButton;
        public DateTimePicker timePicker;
        public Dtat.Windows.Forms.Button exitButton;
        public Dtat.Windows.Forms.DataGridView phoneBookDataGridView;
        public System.Windows.Forms.Timer timer1;
        private Dtat.Windows.Forms.Label administratorLabels;
        private Dtat.Windows.Forms.Label label1;
    }
}