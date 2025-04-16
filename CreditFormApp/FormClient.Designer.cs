namespace ProiectPAW
{
    partial class FormClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelLastName = new Label();
            labelFirstName = new Label();
            labelCNP = new Label();
            labelEmail = new Label();
            labelPhoneNumber = new Label();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxCNP = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhoneNumber = new TextBox();
            buttonRegisterClient = new Button();
            buttonCreditForm = new Button();
            listBoxAllClients = new ListBox();
            contextMenuStripLocalFileHandling = new ContextMenuStrip(components);
            ToolStripMenuItemExportClientsList = new ToolStripMenuItem();
            ToolStripMenuItemEmptyClientList = new ToolStripMenuItem();
            buttonDeleteClient = new Button();
            buttonShowClientInfo = new Button();
            labelTitle = new Label();
            contextMenuStripLocalFileHandling.SuspendLayout();
            SuspendLayout();
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(12, 59);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(49, 20);
            labelLastName.TabIndex = 0;
            labelLastName.Text = "&Nume";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(12, 113);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(67, 20);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "&Prenume";
            // 
            // labelCNP
            // 
            labelCNP.AutoSize = true;
            labelCNP.Location = new Point(12, 165);
            labelCNP.Name = "labelCNP";
            labelCNP.Size = new Size(37, 20);
            labelCNP.TabIndex = 4;
            labelCNP.Text = "&CNP";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 223);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "&Email";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(12, 282);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(160, 20);
            labelPhoneNumber.TabIndex = 8;
            labelPhoneNumber.Text = "&Numar de telefon (RO)";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(179, 59);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(159, 27);
            textBoxLastName.TabIndex = 1;
            textBoxLastName.KeyPress += textBoxLastName_KeyPress;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(179, 113);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(228, 27);
            textBoxFirstName.TabIndex = 3;
            textBoxFirstName.KeyPress += textBoxFirstName_KeyPress;
            // 
            // textBoxCNP
            // 
            textBoxCNP.Location = new Point(179, 165);
            textBoxCNP.MaxLength = 13;
            textBoxCNP.Name = "textBoxCNP";
            textBoxCNP.Size = new Size(159, 27);
            textBoxCNP.TabIndex = 5;
            textBoxCNP.KeyPress += textBoxCNP_KeyPress;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(179, 223);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(159, 27);
            textBoxEmail.TabIndex = 7;
            textBoxEmail.KeyPress += textBoxEmail_KeyPress;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(179, 279);
            textBoxPhoneNumber.MaxLength = 10;
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(159, 27);
            textBoxPhoneNumber.TabIndex = 9;
            textBoxPhoneNumber.KeyPress += textBoxPhoneNumber_KeyPress;
            // 
            // buttonRegisterClient
            // 
            buttonRegisterClient.Location = new Point(95, 329);
            buttonRegisterClient.Name = "buttonRegisterClient";
            buttonRegisterClient.Size = new Size(159, 29);
            buttonRegisterClient.TabIndex = 10;
            buttonRegisterClient.Text = "Inregistreaza client";
            buttonRegisterClient.UseVisualStyleBackColor = true;
            buttonRegisterClient.Click += buttonRegisterClient_Click;
            // 
            // buttonShowClientInfo
            // 
            buttonShowClientInfo.Location = new Point(419, 329);
            buttonShowClientInfo.Name = "buttonShowClientInfo";
            buttonShowClientInfo.Size = new Size(136, 29);
            buttonShowClientInfo.TabIndex = 11;
            buttonShowClientInfo.Text = "Afiseaza datele";
            buttonShowClientInfo.UseVisualStyleBackColor = true;
            buttonShowClientInfo.Click += buttonShowClientInfo_Click;
            // 
            // buttonDeleteClient
            // 
            buttonDeleteClient.Location = new Point(616, 329);
            buttonDeleteClient.Name = "buttonDeleteClient";
            buttonDeleteClient.Size = new Size(144, 29);
            buttonDeleteClient.TabIndex = 12;
            buttonDeleteClient.Text = "Sterge client";
            buttonDeleteClient.UseVisualStyleBackColor = true;
            buttonDeleteClient.Click += buttonDeleteClient_Click;
            // 
            // buttonCreditForm
            // 
            buttonCreditForm.Location = new Point(616, 394);
            buttonCreditForm.Name = "buttonCreditForm";
            buttonCreditForm.Size = new Size(144, 29);
            buttonCreditForm.TabIndex = 13;
            buttonCreditForm.Text = "Credite";
            buttonCreditForm.UseVisualStyleBackColor = true;
            buttonCreditForm.Click += buttonCreditForm_Click;
            // 
            // listBoxAllClients
            // 
            listBoxAllClients.ContextMenuStrip = contextMenuStripLocalFileHandling;
            listBoxAllClients.FormattingEnabled = true;
            listBoxAllClients.Location = new Point(419, 59);
            listBoxAllClients.Name = "listBoxAllClients";
            listBoxAllClients.Size = new Size(341, 264);
            listBoxAllClients.Sorted = true;
            listBoxAllClients.TabIndex = 14;
            // 
            // contextMenuStripLocalFileHandling
            // 
            contextMenuStripLocalFileHandling.ImageScalingSize = new Size(20, 20);
            contextMenuStripLocalFileHandling.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemExportClientsList, ToolStripMenuItemEmptyClientList });
            contextMenuStripLocalFileHandling.Name = "contextMenuStrip1";
            contextMenuStripLocalFileHandling.Size = new Size(205, 52);
            // 
            // ToolStripMenuItemExportClientsList
            // 
            ToolStripMenuItemExportClientsList.Name = "ToolStripMenuItemExportClientsList";
            ToolStripMenuItemExportClientsList.Size = new Size(204, 24);
            ToolStripMenuItemExportClientsList.Text = "Exporta lista clienti";
            ToolStripMenuItemExportClientsList.Click += toolStripMenuItemExportClientsList_Click;
            // 
            // ToolStripMenuItemEmptyClientList
            // 
            ToolStripMenuItemEmptyClientList.Name = "ToolStripMenuItemEmptyClientList";
            ToolStripMenuItemEmptyClientList.Size = new Size(204, 24);
            ToolStripMenuItemEmptyClientList.Text = "Goleste lista clienti";
            ToolStripMenuItemEmptyClientList.Click += ToolStripMenuItemEmptyClientList_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(275, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(225, 38);
            labelTitle.TabIndex = 15;
            labelTitle.Text = "Formular clienti";
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 450);
            Controls.Add(labelTitle);
            Controls.Add(buttonShowClientInfo);
            Controls.Add(buttonDeleteClient);
            Controls.Add(listBoxAllClients);
            Controls.Add(buttonCreditForm);
            Controls.Add(buttonRegisterClient);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxCNP);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelEmail);
            Controls.Add(labelCNP);
            Controls.Add(labelFirstName);
            Controls.Add(labelLastName);
            Name = "FormClient";
            Text = "Form1";
            FormClosing += FormClient_FormClosing;
            Shown += FormClient_Shown;
            contextMenuStripLocalFileHandling.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelLastName;
        private Label labelFirstName;
        private Label labelCNP;
        private Label labelEmail;
        private Label labelPhoneNumber;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TextBox textBoxCNP;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNumber;
        private Button buttonRegisterClient;
        private Button buttonCreditForm;
        private ListBox listBoxAllClients;
        private Button buttonDeleteClient;
        private Button buttonShowClientInfo;
        private ContextMenuStrip contextMenuStripLocalFileHandling;
        private ToolStripMenuItem ToolStripMenuItemExportClientsList;
        private ToolStripMenuItem ToolStripMenuItemEmptyClientList;
        private Label labelTitle;
    }
}
