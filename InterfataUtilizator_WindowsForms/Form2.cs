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
namespace InterfataUtilizator_WindowsForms
{

    public partial class Form2 : Form
    {
        IStocareDate adminAnime;
        public Form2()
        {
            InitializeComponent();
            adminAnime = StocareFactory.GetAdministratorStocare();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Close();
        }
    }
}
