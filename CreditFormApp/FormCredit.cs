using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProiectPAW
{
    public partial class FormCredit : Form
    {
        //form attributes - selected client for storing in his credits list after closing the form
        public Client SelectedClient;
        private Dictionary<TextBox, string> fieldsToValidate;

        //credit form constructor
        public FormCredit(Client passedClient)
        {
            SelectedClient = passedClient;
            InitializeComponent();

            labelClientName.Text = SelectedClient.LastName + " " + SelectedClient.FirstName;

            fieldsToValidate = new Dictionary<TextBox, string>()
            {
                { textBoxAmmount, "Campul \"Suma\" nu poate fi gol" },
                { textBoxTermMonths, "Campul \"Durata\" nu poate fi gol" },
                { textBoxInterestRate, "Campul \"Dobanda\" nu poate fi gol" }
            };

            foreach (Credit c in SelectedClient.Credits)
            {
                listBoxAllCredits.Items.Add(c);
            }
            SelectedClient.Credits.Clear();
        }
        //text and date field validators
        private void textBoxAmmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxTermMonths_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        //list box related buttons
        private void buttonAddCredit_Click(object sender, EventArgs e)
        {
            foreach (var tx in fieldsToValidate)
            {
                if (string.IsNullOrWhiteSpace(tx.Key.Text))
                {
                    MessageBox.Show(tx.Value, "Eroare");
                    return;
                }
            }

            if (dateTimeStartDate.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Data curenta nu poate fi dupa data sistemului", "Eroare");
                return;
            }

            double ammount;
            bool tryConversion = Double.TryParse(textBoxAmmount.Text, out ammount);

            if (!tryConversion)
            {
                MessageBox.Show("Suma trebuie sa fie o cifra valida", "Eroare");
                textBoxAmmount.Clear();
                return;
            }

            double ir;
            tryConversion = Double.TryParse(textBoxInterestRate.Text, out ir);
            if (tryConversion)
            {
                if (ir < 0 || ir > 100)
                {
                    MessageBox.Show("Dobanda trebuie sa fie intre 0% si 100%", "Eroare");
                    textBoxInterestRate.Clear();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Dobanda trebuie sa fie un numar valid", "Eroare");
                return;
            }

            Credit credit = new Credit(Convert.ToDouble(textBoxAmmount.Text), Convert.ToInt32(textBoxTermMonths.Text), Convert.ToDouble(textBoxInterestRate.Text), dateTimeStartDate.Value);
            listBoxAllCredits.Items.Add(credit);
        }

        private void buttonDeleteCredit_Click(object sender, EventArgs e)
        {
            if (listBoxAllCredits.SelectedItem != null)
            {
                listBoxAllCredits.Items.Remove(listBoxAllCredits.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selectati un credit din lista pentru a putea sterge", "Eroare");
            }
        }

        private void buttonGenerateCreditReport_Click(object sender, EventArgs e)
        {
            string reportsDirectory = $@"clientData\reports\";
            if (reportsDirectory != null)
            {
                if (!Directory.Exists(reportsDirectory))
                {
                    Directory.CreateDirectory(reportsDirectory);
                }
            }

            string filePath = reportsDirectory + SelectedClient.CNP + "report.xml";
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(List<Credit>));
            xs.Serialize(fs, listBoxAllCredits.Items.Cast<Credit>().ToList<Credit>());
            fs.Close();

            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }
        //end routines - delete any reports
        private void FormCredit_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(Credit c in listBoxAllCredits.Items.Cast<Credit>())
            {
                SelectedClient.Credits.Add(c);
            }
            string reportsDirectoryPath = $@"clientData\reports\";
            string? reportsDirectory = Path.GetDirectoryName(reportsDirectoryPath);
            
            if(reportsDirectory != null)
            {
                foreach (string filePath in Directory.GetFiles(reportsDirectory))
                {
                    File.Delete(filePath);
                }
            }
        }
    }
}
