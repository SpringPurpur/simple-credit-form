namespace ProiectPAW
{
    partial class FormCredit
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
            labelAmmount = new Label();
            labelTermMonths = new Label();
            labelInterestRate = new Label();
            labelStartDate = new Label();
            textBoxAmmount = new TextBox();
            textBoxTermMonths = new TextBox();
            textBoxInterestRate = new TextBox();
            listBoxAllCredits = new ListBox();
            buttonDeleteCredit = new Button();
            buttonAddCredit = new Button();
            buttonGenerateCreditReport = new Button();
            dateTimeStartDate = new DateTimePicker();
            labelTitle = new Label();
            labelClientName = new Label();
            SuspendLayout();
            // 
            // labelAmmount
            // 
            labelAmmount.AutoSize = true;
            labelAmmount.Location = new Point(38, 69);
            labelAmmount.Name = "labelAmmount";
            labelAmmount.Size = new Size(91, 20);
            labelAmmount.TabIndex = 0;
            labelAmmount.Text = "&Suma (RON)";
            // 
            // labelTermMonths
            // 
            labelTermMonths.AutoSize = true;
            labelTermMonths.Location = new Point(38, 131);
            labelTermMonths.Name = "labelTermMonths";
            labelTermMonths.Size = new Size(92, 20);
            labelTermMonths.TabIndex = 2;
            labelTermMonths.Text = "&Durata (luni)";
            // 
            // labelInterestRate
            // 
            labelInterestRate.AutoSize = true;
            labelInterestRate.Location = new Point(38, 200);
            labelInterestRate.Name = "labelInterestRate";
            labelInterestRate.Size = new Size(71, 20);
            labelInterestRate.TabIndex = 4;
            labelInterestRate.Text = "&Dobanda";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(38, 267);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(120, 20);
            labelStartDate.TabIndex = 6;
            labelStartDate.Text = "&Data contractarii";
            // 
            // textBoxAmmount
            // 
            textBoxAmmount.Location = new Point(238, 69);
            textBoxAmmount.Name = "textBoxAmmount";
            textBoxAmmount.Size = new Size(125, 27);
            textBoxAmmount.TabIndex = 1;
            textBoxAmmount.KeyPress += textBoxAmmount_KeyPress;
            // 
            // textBoxTermMonths
            // 
            textBoxTermMonths.Location = new Point(238, 131);
            textBoxTermMonths.Name = "textBoxTermMonths";
            textBoxTermMonths.Size = new Size(125, 27);
            textBoxTermMonths.TabIndex = 3;
            textBoxTermMonths.KeyPress += textBoxTermMonths_KeyPress;
            // 
            // textBoxInterestRate
            // 
            textBoxInterestRate.Location = new Point(238, 193);
            textBoxInterestRate.Name = "textBoxInterestRate";
            textBoxInterestRate.Size = new Size(125, 27);
            textBoxInterestRate.TabIndex = 5;
            textBoxInterestRate.KeyPress += textBoxInterestRate_KeyPress;
            // 
            // listBoxAllCredits
            // 
            listBoxAllCredits.FormattingEnabled = true;
            listBoxAllCredits.Location = new Point(478, 45);
            listBoxAllCredits.Name = "listBoxAllCredits";
            listBoxAllCredits.Size = new Size(274, 284);
            listBoxAllCredits.TabIndex = 10;
            // 
            // buttonDeleteCredit
            // 
            buttonDeleteCredit.Location = new Point(622, 335);
            buttonDeleteCredit.Name = "buttonDeleteCredit";
            buttonDeleteCredit.Size = new Size(117, 29);
            buttonDeleteCredit.TabIndex = 10;
            buttonDeleteCredit.Text = "Sterge credit";
            buttonDeleteCredit.UseVisualStyleBackColor = true;
            buttonDeleteCredit.Click += buttonDeleteCredit_Click;
            // 
            // buttonAddCredit
            // 
            buttonAddCredit.Location = new Point(38, 335);
            buttonAddCredit.Name = "buttonAddCredit";
            buttonAddCredit.Size = new Size(117, 29);
            buttonAddCredit.TabIndex = 8;
            buttonAddCredit.Text = "Adauga credit";
            buttonAddCredit.UseVisualStyleBackColor = true;
            buttonAddCredit.Click += buttonAddCredit_Click;
            // 
            // buttonGenerateCreditReport
            // 
            buttonGenerateCreditReport.Location = new Point(478, 335);
            buttonGenerateCreditReport.Name = "buttonGenerateCreditReport";
            buttonGenerateCreditReport.Size = new Size(138, 29);
            buttonGenerateCreditReport.TabIndex = 9;
            buttonGenerateCreditReport.Text = "Genereaza raport";
            buttonGenerateCreditReport.UseVisualStyleBackColor = true;
            buttonGenerateCreditReport.Click += buttonGenerateCreditReport_Click;
            // 
            // dateTimeStartDate
            // 
            dateTimeStartDate.Location = new Point(183, 262);
            dateTimeStartDate.Name = "dateTimeStartDate";
            dateTimeStartDate.Size = new Size(250, 27);
            dateTimeStartDate.TabIndex = 7;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(80, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(235, 38);
            labelTitle.TabIndex = 13;
            labelTitle.Text = "Formular credite";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelClientName
            // 
            labelClientName.AutoSize = true;
            labelClientName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelClientName.Location = new Point(572, 9);
            labelClientName.Name = "labelClientName";
            labelClientName.Size = new Size(90, 23);
            labelClientName.TabIndex = 14;
            labelClientName.Text = "Loading...";
            labelClientName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormCredit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelClientName);
            Controls.Add(labelTitle);
            Controls.Add(dateTimeStartDate);
            Controls.Add(buttonGenerateCreditReport);
            Controls.Add(buttonAddCredit);
            Controls.Add(buttonDeleteCredit);
            Controls.Add(listBoxAllCredits);
            Controls.Add(textBoxInterestRate);
            Controls.Add(textBoxTermMonths);
            Controls.Add(textBoxAmmount);
            Controls.Add(labelStartDate);
            Controls.Add(labelInterestRate);
            Controls.Add(labelTermMonths);
            Controls.Add(labelAmmount);
            Name = "FormCredit";
            Text = "FormCredit";
            FormClosing += FormCredit_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAmmount;
        private Label labelTermMonths;
        private Label labelInterestRate;
        private Label labelStartDate;
        private TextBox textBoxAmmount;
        private TextBox textBoxTermMonths;
        private TextBox textBoxInterestRate;
        private ListBox listBoxAllCredits;
        private Button buttonDeleteCredit;
        private Button buttonAddCredit;
        private Button buttonGenerateCreditReport;
        private DateTimePicker dateTimeStartDate;
        private Label labelTitle;
        private Label labelClientName;
    }
}