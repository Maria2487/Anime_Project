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
    public partial class FisierForm : Form
    {
        private const int LIMITA = 0;
        private const int LIMITASUP = 10;
        IStocareDate adminAnime;
        List<string> genurileBifate = new List<string>();
        public string TextArea { get; set; }
        public FisierForm(string ceva)
        {
            InitializeComponent();
            adminAnime = StocareFactory.GetAdministratorStocare();
            TextArea = ceva;
        }

        private void buttonIncarcareFile_Click(object sender, EventArgs e)
        {
            dataGridAnime.DataSource = null;
            string[] detalii = TextArea.Split('\n');
            List<Anime> animeuri = new List<Anime>();

            for (int i = 0; i < detalii.Length - 1; i++)
            {
                detalii[i] = detalii[i].Remove(detalii[i].IndexOf('\r'));
                Anime a = new Anime(detalii[i]);
                animeuri.Add(a);
            }
            dataGridAnime.DataSource = animeuri;
           
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
