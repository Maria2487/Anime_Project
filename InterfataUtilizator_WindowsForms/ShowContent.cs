using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAccesDate;
using Anime_Project;
namespace InterfataUtilizator_WindowsForms
{
    public partial class ShowContent : Form
    {
        string infoForm;
        IStocareDate adminAnime;
        public ShowContent()
        {
            InitializeComponent();
        }

        public ShowContent(string ceva)
        {
            InitializeComponent();
            infoForm = ceva;
            adminAnime = StocareFactory.GetAdministratorStocare();
        }

        private void ShowContent_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            comboBoxAfisare.Text = string.Empty;
            this.Close();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxAfisare.Text = "Lista anime";
            string[] detalii = infoForm.Split('\n');
            foreach (var cev in detalii)
            {
                Anime a = new Anime(cev);
                comboBoxAfisare.Items.Add(a.ConvertToStringAfisare());
            }

        }
    }
}
