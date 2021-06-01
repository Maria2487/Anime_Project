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
    public partial class AfisareForm : Form
    {
        private const int LIMITA = 0;
        private const int LIMITASUP = 10;
        IStocareDate adminAnime;
        List<string> genurileBifate = new List<string>();
        public string TextArea { get; set; }
        public AfisareForm()
        {
            InitializeComponent();
            adminAnime = StocareFactory.GetAdministratorStocare();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            ListaAnime.Items.Clear();
            ListaAnime.Items.Add("Lista Animeuri");
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
    }
}
