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
        IStocareDate adminAnime;
        List<string> genurileBifate = new List<string>();
        public Form1()
        {
            InitializeComponent();
            adminAnime = StocareFactory.GetAdministratorStocare();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Adaugare - anime
        {

            if (DateValide() == false)
            {
                return;
            }
                
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

            ListaAnime.Text = "Animeul:  " + anime1.ConvertToStringAfisare() + "A fost adaugat";
            adminAnime.AddAnime(anime1);

            ResetareControale();
        }

        private TypeAnime? GetTypeAnime()
        {
            if (radioButtonTV.Checked)
                return TypeAnime.TV;
            if (radioButtonOVA.Checked)
                return TypeAnime.OVA;
            if (radioButtonmMOVIE.Checked)
                return TypeAnime.MOVIE;
            if (radioButtonSPECIAL.Checked)
                return TypeAnime.SPECIAL;
            if (radioButtonONA.Checked)
                return TypeAnime.ONA;
            return null;
        }

        private Status? GetStatus()
        {
            if (radioButtonAiring.Checked)
                return Status.AIRING;
            if (radioButtonCompleted.Checked)
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
            ListaAnime.Items.Clear();
            ListaAnime.Items.Add("Lista Animeuri");
            foreach (Anime a in adminAnime.GetAnimeuri())
            {
                ListaAnime.Items.Add(a.ConvertToStringAfisare());
            }
        }

        private void show()
        {
            ListaAnime.Items.Clear();
            ListaAnime.Items.Add("Lista Animeuri");
            foreach (Anime a in adminAnime.GetAnimeuri())
            {
                ListaAnime.Items.Add(a.ConvertToStringAfisare());
            }
        }

        private void ResetareControale()
        {
            txtNume.Text = txtSezoane.Text = txtEpisoade.Text = txtRecenzie.Text = string.Empty;
            radioButtonTV.Checked = false;
            radioButtonOVA.Checked = false;
            radioButtonmMOVIE.Checked = false;
            radioButtonSPECIAL.Checked = false;
            radioButtonONA.Checked = false;
            radioButtonAiring.Checked = false;
            radioButtonCompleted.Checked = false;
            checkBoxAction.Checked = false;
            checkBoxComedy.Checked = false;
            checkBoxMecha.Checked = false;
            checkBoxShounenAi.Checked = false;
            checkBoxAdventure.Checked = false;
            checkBoxComedy.Checked = false;
            checkBoxDemons.Checked = false;
            checkBoxDrama.Checked = false;
            checkBoxEcchi.Checked = false;
            checkBoxFantasy.Checked = false;
            checkBoxGame.Checked = false;
            checkBoxHarem.Checked = false;
            checkBoxHistorical.Checked = false;
            checkBoxHorror.Checked = false;
            checkBoxJosei.Checked = false;
            checkBoxMagic.Checked = false;
            checkBoxMartial.Checked = false;
            checkBoxMilitary.Checked = false;
            checkBoxMusic.Checked = false;
            checkBoxMystery.Checked = false;
            checkBoxPsyhological.Checked = false;
            checkBoxRomance.Checked = false;
            checkBoxSamurai.Checked = false;
            checkBoxSeinen.Checked = false;
            checkBoxShojo.Checked = false;
            checkBoxShojoai.Checked = false;
            checkBoxShounen.Checked = false;
            checkBoxSliceoflife.Checked = false;
            checkBoxSports.Checked = false;
            checkBoxSupernatural.Checked = false;
            checkBoxThriller.Checked = false;
            checkBoxYaoi.Checked = false;
            checkBoxYuri.Checked = false;
            //lblSezoane.ForeColor = Color.Black;
            //lblEpisoade.ForeColor = Color.Black;
            //lblRecenzie.ForeColor = Color.Black;
            //groupBoxGenuri.ForeColor = Color.Black;
            genurileBifate.Clear();
            ListaAnime.Text = string.Empty;
        }

        private bool DateValide()
        {
            if (genurileBifate.Count == 0)
            {
                groupBoxGenuri.ForeColor = Color.Red;
                return false;
            }
            else
                groupBoxGenuri.ForeColor = Color.Black;
            int input,ok = 1;
            if (int.TryParse(txtSezoane.Text, out input))
            {
                if (input <= 0)
                {
                    lblSezoane.ForeColor = Color.Red;
                    txtSezoane.Clear();
                    ok = 0;
                    return false;
                }
                    
            }
            else
            {
                lblSezoane.ForeColor = Color.Red;
                txtSezoane.Clear();
                ok = 0;
                return false;
            }
            if(ok == 1)
                lblSezoane.ForeColor = Color.Black;

            ok = 1;
            if (int.TryParse(txtEpisoade.Text, out input))
            {
                if (input <= 0)
                {
                    lblEpisoade.ForeColor = Color.Red;
                    txtEpisoade.Clear();
                    ok = 0;
                    return false;
                }
                if (input > 0)
                {
                    if (int.TryParse(txtSezoane.Text, out input))
                    {
                        if (input <= 0)
                        {
                            lblSezoane.ForeColor = Color.Red;
                            txtSezoane.Clear();
                            ok = 0;
                            return false;
                        }

                    }
                    else
                    {
                        lblSezoane.ForeColor = Color.Red;
                        txtSezoane.Clear();
                        ok = 0;
                        return false;
                    }
                }

            }
            else
            {
                lblEpisoade.ForeColor = Color.Red;
                txtEpisoade.Clear();
                ok = 0;
                return false;
            }
            if (ok == 1)
                lblEpisoade.ForeColor = Color.Black;

            ok = 1;
            if (int.TryParse(txtRecenzie.Text, out input))
            {
                if (input < 0)
                {
                    lblRecenzie.ForeColor = Color.Red;
                    txtRecenzie.Clear();
                    ok = 0;
                    return false;
                }

            }
            else
            {
                lblRecenzie.ForeColor = Color.Red;
                txtRecenzie.Clear();
                ok = 0;
                return false;
            }
            if (ok == 1)
                lblRecenzie.ForeColor = Color.Black;
          
            return true;

        }

        private void buttonModificare_Click(object sender, EventArgs e)
        {
            Anime a = adminAnime.GetAnime(ListaAnime.SelectedIndex);

            a.NumeAnime = txtNume.Text;
            a.NotaAnime = Convert.ToDouble(txtRecenzie.Text);
            a.SezoaneAnime = Convert.ToInt32(txtSezoane.Text);
            a.EpisoadeAnime = Convert.ToInt32(txtEpisoade.Text);
            adminAnime.RewriteAnime(a);

            lblMesaj.Text = "Animeul a fost modificat.";

            show();
            ResetareControale();
        }

        private void ListaAnime_SelectedIndexChanged(object sender, EventArgs e)
        {
            Anime a = adminAnime.GetAnime(ListaAnime.SelectedIndex);
            txtNume.Text = a.NumeAnime;
            txtSezoane.Text = a.SezoaneAnime.ToString();
            txtEpisoade.Text = a.EpisoadeAnime.ToString();
            txtRecenzie.Text = a.NotaAnime.ToString();
        }
    }
}
