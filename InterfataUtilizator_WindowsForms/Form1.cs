using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class Form1 : Form
    {
        IStocareDate adminAnime = StocareFactory.GetAdministratorStocare();
        ArrayList genurileBifate = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anime anime1 = new Anime();

            if (radioButton1.Checked)
                anime1.TipulAnime = TypeAnime.TV;
            if (radioButton2.Checked)
                anime1.TipulAnime = TypeAnime.OVA;
            if (radioButton3.Checked)
                anime1.TipulAnime = TypeAnime.MOVIE;
            if (radioButton4.Checked)
                anime1.TipulAnime = TypeAnime.SPECIAL;
            if (radioButton5.Checked)
                anime1.TipulAnime = TypeAnime.ONA;
            if (radioButton6.Checked)
                anime1.OngoingAnime = Status.Airing;
            if (radioButton7.Checked)
                anime1.OngoingAnime = Status.Completed;

            anime1.GenAnime = new ArrayList();
            anime1.GenAnime.AddRange(genurileBifate);

           // lblAfisare.Text = "Am adaugat " + anime1.ConvertToStringAfisare();
            adminAnime.AddAnime(anime1);
        }
    }
}
