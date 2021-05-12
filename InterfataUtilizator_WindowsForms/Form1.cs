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
        List<string> genurileBifate = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Adaugare - anime
        {
            

            Anime anime1 = new Anime(txtNume.Text,txtSezoane.Text,txtEpisoade.Text, txtRecenzie.Text);

            TypeAnime? typeAnime = GetTypeAnime();
            if(typeAnime.HasValue)
            {
                anime1.TipulAnime = typeAnime.Value;
            }
            Status? status = GetStatus();
            if(status.HasValue)
            {
                anime1.OngoingAnime = status.Value;
            }

            anime1.GenAnime = new List<string>();
            anime1.GenAnime.AddRange(genurileBifate);

            richTextBox1.Text = "Animeul:  " + anime1.ConvertToStringAfisare() + "A fost adaugat";
            adminAnime.AddAnime(anime1);

            ResetareControale();
        }

        private TypeAnime? GetTypeAnime()
        {
            if (radioButton1.Checked)
                return TypeAnime.TV;
            if (radioButton2.Checked)
                return TypeAnime.OVA;
            if (radioButton3.Checked)
                return TypeAnime.MOVIE;
            if (radioButton4.Checked)
                return TypeAnime.SPECIAL;
            if (radioButton5.Checked)
                return TypeAnime.ONA;
            return null;
        }

        private Status? GetStatus()
        {
            if (radioButton6.Checked)
                return Status.AIRING;
            if (radioButton7.Checked)
                return Status.COMPLETED;

            return null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)  //Checkboxuri - Genuri
        {
            CheckBox checkBoxControl = sender as CheckBox;
            string genBifat = checkBoxControl.Text;
            if (checkBoxControl.Checked == true)
                genurileBifate.Add(genBifat);
            else
                genurileBifate.Remove(genBifat);
        }

        private void button2_Click(object sender, EventArgs e) //Afisare
        {
            richTextBox1.Clear();
            foreach (Anime a in adminAnime.GetAnimeuri())
            {
                richTextBox1.AppendText(a.ConvertToStringAfisare());
                richTextBox1.AppendText(Environment.NewLine);
            }
        }

        private void ResetareControale()
        {
            txtNume.Text = txtSezoane.Text = txtEpisoade.Text = txtRecenzie.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            genurileBifate.Clear();
            richTextBox1.Text = string.Empty;
        }
    }
}
