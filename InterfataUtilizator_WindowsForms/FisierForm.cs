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
        public string TextArea { get; set; }
        public FisierForm(string ceva)
        {
            InitializeComponent();
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
            if (animeuri.Count == 0)
            {
                label2.Visible = true;
                label2.ForeColor = Color.DeepSkyBlue;
                label2.Text = "Fisiernul este gol";
            }
            else
            {
                label2.Visible = true;
                label2.ForeColor = Color.DeepSkyBlue;
                label2.Text = "Fisierul a fost afisat";
            }

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
    }
}
