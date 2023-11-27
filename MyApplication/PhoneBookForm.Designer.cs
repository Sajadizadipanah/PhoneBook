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
            monthCalendar = new MonthCalendar();
            timer1 = new System.Windows.Forms.Timer(components);
            administratorLabels = new Dtat.Windows.Forms.Label();
            label1 = new Dtat.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)phoneBookDataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchContactButton
            // 
            searchContactButton.Location = new Point(12, 476);
            searchContactButton.Name = "searchContactButton";
            searchContactButton.Size = new Size(75, 23);
            searchContactButton.TabIndex = 0;
            searchContactButton.Text = "&Search Contact";
            searchContactButton.UseVisualStyleBackColor = true;
            searchContactButton.Click += searchContactButton_Click;
            // 
            // newContactButton
            // 
            newContactButton.Location = new Point(93, 476);
            newContactButton.Name = "newContactButton";
            newContactButton.Size = new Size(75, 23);
            newContactButton.TabIndex = 1;
            newContactButton.Text = "&New Contact";
            newContactButton.UseVisualStyleBackColor = true;
            newContactButton.Click += newContactButton_Click;
            // 
            // timePicker
            // 
            timePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(413, 12);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(101, 23);
            timePicker.TabIndex = 5;
            timePicker.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.Location = new Point(720, 476);
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
            phoneBookDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            phoneBookDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            phoneBookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phoneBookDataGridView.Location = new Point(12, 12);
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
            phoneBookDataGridView.Size = new Size(389, 458);
            phoneBookDataGridView.TabIndex = 7;
            phoneBookDataGridView.CellDoubleClick += phoneBookDataGridView_CellDoubleClick;
            // 
            // monthCalendar
            // 
            monthCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            monthCalendar.FirstDayOfWeek = Day.Saturday;
            monthCalendar.Location = new Point(407, 47);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.ShowWeekNumbers = true;
            monthCalendar.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // administratorLabels
            // 
            administratorLabels.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            administratorLabels.AutoSize = true;
            administratorLabels.Location = new Point(662, 8);
            administratorLabels.Name = "administratorLabels";
            administratorLabels.Size = new Size(75, 15);
            administratorLabels.TabIndex = 10;
            administratorLabels.Text = "@Izadipanah";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(656, 23);
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
            ClientSize = new Size(807, 511);
            Controls.Add(label1);
            Controls.Add(administratorLabels);
            Controls.Add(monthCalendar);
            Controls.Add(phoneBookDataGridView);
            Controls.Add(searchContactButton);
            Controls.Add(newContactButton);
            Controls.Add(exitButton);
            Controls.Add(timePicker);
            MaximumSize = new Size(1200, 550);
            MinimumSize = new Size(823, 550);
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
        public MonthCalendar monthCalendar;
        public System.Windows.Forms.Timer timer1;
        private Dtat.Windows.Forms.Label administratorLabels;
        private Dtat.Windows.Forms.Label label1;
    }
}