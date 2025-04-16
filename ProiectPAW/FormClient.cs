using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace ProiectPAW
{
    public partial class FormClient : Form
    {
        private Dictionary<TextBox, string> fieldsToValidate;
        public FormClient()
        {
            InitializeComponent();

            //validating fields - contains error messages for each text box
            fieldsToValidate = new Dictionary<TextBox, string>()
            {
                { textBoxLastName, "Campul \"Nume\" nu poate fi gol" },
                { textBoxFirstName, "Campul \"Prenume complet\" nu poate fi gol" },
                { textBoxCNP, "Campul \"CNP\" nu poate fi gol"},
                { textBoxEmail, "Campul \"Email\" nu poate fi gol" },
                { textBoxPhoneNumber, "Campul \"Numar de telefon\" nu poate fi gol" }
            };
        }
        //routine to check if clientData folder exists. If not, the user will be notified and it will be created
        private void FormClient_Shown(object sender, EventArgs e)
        {
            string clientDirectoryPath = $@"clientData\clients\";
            string? clientDirectory = Path.GetDirectoryName(clientDirectoryPath);
            if (clientDirectory != null)
            {
                if (!Directory.Exists(clientDirectory))
                {
                    MessageBox.Show("Nu s-au putut prelua datele despre clienti. Directorul nu exista", "Atentie");
                    Directory.CreateDirectory(clientDirectory);
                }
                else if (!Directory.EnumerateFileSystemEntries(clientDirectory).Any())
                {
                    MessageBox.Show("Nu s-au putut prelua datele despre clienti. Nu exista fisiere", "Atentie");
                }
                else
                {
                    foreach (string clientFile in Directory.GetFiles(clientDirectory))
                    {
                        FileStream fs = new FileStream(clientFile, FileMode.Open, FileAccess.Read);
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                        BinaryFormatter bf = new BinaryFormatter();
                        listBoxAllClients.Items.Add((Client)bf.Deserialize(fs));
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                        fs.Close();
                    }
                }
            }
        }
        //text field validations
        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //buttons
        //client registering action
        private void buttonRegisterClient_Click(object sender, EventArgs e)
        {
            foreach (var tx in fieldsToValidate)
            {
                if (string.IsNullOrWhiteSpace(tx.Key.Text))
                {
                    MessageBox.Show(tx.Value, "Eroare");
                    return;
                }
            }
            //CNP ensures uniqueness if files - no data overwriting
            if (textBoxCNP.Text.Length != 13)
            {
                MessageBox.Show("CNP este format din 13 cifre", "Eroare");
                textBoxCNP.Clear();
                return;
            }
            else
            {
                foreach (Client c in listBoxAllClients.Items.Cast<Client>())
                {
                    if (c.CNP == textBoxCNP.Text)
                    {
                        MessageBox.Show("Exista deja un client cu acest CNP", "Eraore");
                        textBoxCNP.Clear();
                        return;
                    }
                }
            }
            //regex format for email checking
            if (!Regex.IsMatch(textBoxEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Formatul nu corespunde unei adrese de mail valide", "Eroare");
                textBoxEmail.Clear();
                return;
            }

            if (textBoxPhoneNumber.Text.Length != 10)
            {
                MessageBox.Show("Numarul de telefon RO contine 10 cifre", "Eroare");
                textBoxPhoneNumber.Clear();
                return;
            }

            Client client = new Client(textBoxLastName.Text, textBoxFirstName.Text, textBoxCNP.Text, textBoxEmail.Text, textBoxPhoneNumber.Text, 300);

            listBoxAllClients.Items.Add(client);
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (listBoxAllClients.SelectedItem != null)
            {
                listBoxAllClients.Items.Remove(listBoxAllClients.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selectati un client din lista pentru a putea sterge", "Eroare");
            }
        }

        private void buttonCreditForm_Click(object sender, EventArgs e)
        {
            if (listBoxAllClients.SelectedItem != null)
            {
                FormCredit formCredit = new FormCredit((Client)listBoxAllClients.SelectedItem);
                formCredit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selectati un client pentru a intra in meniul de credite");
            }

        }

        private void buttonShowClientInfo_Click(object sender, EventArgs e)
        {
            if (listBoxAllClients.SelectedItem != null)
            {
                MessageBox.Show(((Client)listBoxAllClients.SelectedItem).FullInfo());
            }
            else
            {
                MessageBox.Show("Selectati un client pentru a vedea detaliile");
            }
        }
        //context menu
        //explicitly save data while the form is active
        private void toolStripMenuItemExportClientsList_Click(object sender, EventArgs e)
        {
            string clientDirectoryPath = $@"clientData\clients\";
            string? clientDirectory = Path.GetDirectoryName(clientDirectoryPath);
            if (!Directory.Exists(clientDirectory) && clientDirectory != null)
            {
                Directory.CreateDirectory(clientDirectory);
            }
            foreach (Client client in listBoxAllClients.Items.Cast<Client>())
            {
                string pathToClientFile = $@"clientData\clients\{client.CNP}info.bin";

#pragma warning disable SYSLIB0011 // Type or member is obsolete
                FileStream fsClient = new FileStream(pathToClientFile, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fsClient, client);
                fsClient.Close();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
            }
            MessageBox.Show("Actiunea s-a realizat cu succes", "Mesaj");
        }
        //option for clearing the list and emptying the folder
        private void ToolStripMenuItemEmptyClientList_Click(object sender, EventArgs e)
        {
            string clientDirectoryPath = $@"clientData\clients\";
            string? clientDirectory = Path.GetDirectoryName(clientDirectoryPath);
            if (clientDirectory != null)
            {
                if (!Directory.Exists(clientDirectory))
                {
                    MessageBox.Show("Nu exista director pentru date clienti", "Eroare");
                    return;
                }
                else
                {
                    foreach (string clientFilePath in Directory.GetFiles(clientDirectory))
                    {
                        File.Delete(clientFilePath);
                    }
                    listBoxAllClients.Items.Clear();
                    MessageBox.Show("Actiunea s-a realizat cu succes", "Mesaj");
                }
            }
        }
        //end routine
        //routine for saving data after closing
        private void FormClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            string clientDirectoryPath = $@"clientData\clients\";
            string? clientDirectory = Path.GetDirectoryName(clientDirectoryPath);
            if (!Directory.Exists(clientDirectory) && clientDirectory != null)
            {
                Directory.CreateDirectory(clientDirectory);
            }
            foreach (Client client in listBoxAllClients.Items.Cast<Client>())
            {
                string pathToClientFile = $@"clientData\clients\{client.CNP}info.bin";

#pragma warning disable SYSLIB0011 // Type or member is obsolete
                FileStream fsClient = new FileStream(pathToClientFile, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fsClient, client);
                fsClient.Close();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
            }
        }
    }
}
