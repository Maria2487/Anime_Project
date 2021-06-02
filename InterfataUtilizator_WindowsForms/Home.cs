using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anime_Project;
using NivelAccesDate;
using System.IO;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Home : Form
    {
        
        public string TextArea { get; set; }
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void buttonCautare_Click(object sender, EventArgs e)
        {
            using (CautareForm Form = new CautareForm())
            {
                this.Hide();
                Form.ShowDialog();
                this.Show();
            }

        }

        private void buttonModificare_Click(object sender, EventArgs e)
        {
            using (ModificareForm Form = new ModificareForm())
            {
                this.Hide();
                Form.ShowDialog();
                this.Show();
            }

        }

        private void buttonStergere_Click(object sender, EventArgs e)
        {
            using (StergereForm Form = new StergereForm())
            {
                this.Hide();
                Form.ShowDialog();
                this.Show();
            }
        }

        private void buttonIncarcareFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            bool ok = false;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "d:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    TextArea = reader.ReadToEnd();
                    ok = true;
                    reader.Close();

                }
            }
            if(ok == true)
                using (FisierForm Form = new FisierForm(TextArea))
                {
                    this.Hide();
                    Form.ShowDialog();
                    this.Show();
                }
            else
            {
                MessageBox.Show("Eroare la incarcarea fisierului");
            }
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Cotofrec Maria-Elena\n    Grupa: 3123A");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            using (AfisareForm Form = new AfisareForm())
            {
                this.Hide();
                Form.ShowDialog();
                this.Show();
            }
        }

        private void buttonAdaugare_Click(object sender, EventArgs e)
        {
            using (AdaugareForm Form = new AdaugareForm())
            {
                this.Hide();
                Form.ShowDialog();
                this.Show();
            }
        }
    }
}
