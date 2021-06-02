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
    public partial class StergereForm : Form
    {
        IStocareDate adminAnime;
        public StergereForm()
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
            ListaAnime.Items.Add("Lista Animeuri");
            List<Anime> verif = new List<Anime>();
            verif = adminAnime.GetAnimeuri();
            if (verif.Count == 0)
            {
                ListaAnime.Items.Clear();
                ListaAnime.Items.Add("Nu exista animeuri in lista");
            }
            foreach (Anime a in adminAnime.GetAnimeuri())
            {
                ListaAnime.Items.Add(a.ConvertToStringAfisare());
            }
        }

        private void buttonStergere_Click(object sender, EventArgs e)
        {

            if (ListaAnime.SelectedIndex == 0 || ListaAnime.SelectedIndex == -1)
            {
                return;
            }
            
            Anime a = adminAnime.GetAnime(ListaAnime.SelectedIndex);
            if(adminAnime.DeleteAnime(a) == false)
            {
                label2.Visible = true;
                label2.ForeColor = Color.DeepSkyBlue;
                label2.Text = "Nici un anime nu a fost sters";
            }
            else
            {
                label2.Visible = true;
                label2.ForeColor = Color.DeepSkyBlue;
                label2.Text = "Animeul selectat a fost sters";
            }

            show();
            
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            Environment.Exit(1);
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (ListaAnime.SelectedIndex == 0)
                return;
            ListaAnime.Items.Clear();
            ListaAnime.Items.Add("Introduceti numele animeului cautat in caseta `Nume`:");

            Anime a = adminAnime.GetAnime(txtNume1.Text);
            if (a == null)
            {
                ListaAnime.Items.Clear();
                ListaAnime.Items.Add("Animeul nu a fost gasit.");

            }
            else
            {
                ListaAnime.Items.Clear();
                ListaAnime.Items.Add("Animeul a fost gasit");
                ListaAnime.Items.Add(a.ConvertToStringAfisare());
            }
        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            show();
        }
    }
}
