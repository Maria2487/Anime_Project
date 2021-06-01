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
    public partial class CautareForm : Form
    {
        private const int LIMITA = 0;
        private const int LIMITASUP = 10;
        IStocareDate adminAnime;
        List<string> genurileBifate = new List<string>();
        public string TextArea { get; set; }
        public CautareForm()
        {
            InitializeComponent();
            adminAnime = StocareFactory.GetAdministratorStocare();
            show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void show()
        {
            ListaAnime.Items.Clear();
            ListaAnime.Items.Add("Lista Animeuri:");
            foreach (Anime a in adminAnime.GetAnimeuri())
            {
                ListaAnime.Items.Add(a.ConvertToStringAfisare());
            }
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            dataGridAnime.DataSource = null;
            dataGridAnime.DataSource = adminAnime.GetAnimeuri();
            lblMesaj.Text = "Introduceti numele animeului cautat:";
            lblMesaj.ForeColor = Color.Black;
            Anime a = adminAnime.GetAnime(txtNume2.Text);
            if (a == null)
            {
                dataGridAnime.DataSource = null;
                lblMesaj.Text = "Animeul nu a fost gasit. Introduceti altul?";
                lblMesaj.ForeColor = Color.Red;
            }
            else
            {
                dataGridAnime.DataSource = null;
                lblMesaj.Text = "Animeul a fost gasit. Introduceti altul?";
                lblMesaj.ForeColor = Color.Green;
                dataGridAnime.DataSource = adminAnime.GetAnimeL(txtNume2.Text);
            }

            txtNume2.Text = String.Empty;
        }
    }
}
