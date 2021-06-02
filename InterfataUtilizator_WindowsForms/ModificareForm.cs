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
    public partial class ModificareForm : Form
    {
        private const int LIMITA = 0;
        private const int LIMITASUP = 10;
        IStocareDate adminAnime;
        List<string> genurileBifate = new List<string>();
        public ModificareForm()
        {
            InitializeComponent();
            adminAnime = StocareFactory.GetAdministratorStocare();
            show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

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
        private void ResetareControale()
        {
            txtNume1.Text = txtSezoane.Text = txtEpisoade.Text = txtRecenzie.Text = string.Empty;
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

            genurileBifate.Clear();
            ListaAnime.Text = string.Empty;
        }
        private bool DateValide()
        {
            int input;
            double input2;
            bool esteValid = true;
            if(ListaAnime.SelectedIndex == 0)
            {
                return false;
            }
            TypeAnime? typeAnime = GetTypeAnime();
            if (typeAnime.HasValue == false)
            {
                groupBoxType.ForeColor = Color.Red;
                esteValid = false;
            }
            else
            {
                groupBoxType.ForeColor = Color.Black;
            }
            Status? status = GetStatus();
            if (status.HasValue == false)
            {
                groupBoxStatus.ForeColor = Color.Red;
                esteValid = false;
            }
            else
            {
                groupBoxStatus.ForeColor = Color.Black;
            }
            if (txtNume1.Text == string.Empty)
            {
                lblNume1.ForeColor = Color.Red;
                esteValid = false;
            }
            else
            {
                lblNume1.ForeColor = Color.Black;
            }
            if (genurileBifate.Count == LIMITA)
            {
                groupBoxGenuri.ForeColor = Color.Red;
                esteValid = false;
            }
            else
                groupBoxGenuri.ForeColor = Color.Black;

            if (int.TryParse(txtSezoane.Text, out input))
            {
                if (input <= LIMITA)
                {
                    lblSezoane.ForeColor = Color.Red;
                    txtSezoane.Clear();
                    esteValid = false;
                }
                else
                {
                    lblSezoane.ForeColor = Color.Black;
                }

            }
            else
            {
                lblSezoane.ForeColor = Color.Red;
                txtSezoane.Clear();
                esteValid = false;
            }


            if (int.TryParse(txtEpisoade.Text, out input))
            {
                if (input <= LIMITA)
                {
                    lblEpisoade.ForeColor = Color.Red;
                    txtEpisoade.Clear();
                    esteValid = false;

                }
                else
                {
                    lblEpisoade.ForeColor = Color.Black;
                }
                if (input > LIMITA)
                {
                    int input3;
                    int.TryParse(txtSezoane.Text, out input3);
                    if (input3 <= LIMITA)
                    {
                        lblEpisoade.ForeColor = Color.Red;
                        esteValid = false;
                    }
                    else
                    {
                        lblEpisoade.ForeColor = Color.Black;
                    }

                }

            }
            else
            {
                lblEpisoade.ForeColor = Color.Red;
                txtEpisoade.Clear();
                esteValid = false;
            }

            if (Double.TryParse(txtRecenzie.Text, out input2))
            {
                if (input2 < LIMITA || input2 > LIMITASUP)
                {
                    lblRecenzie.ForeColor = Color.Red;
                    txtRecenzie.Clear();
                    esteValid = false;
                }
                else
                {
                    lblRecenzie.ForeColor = Color.Black;
                }

            }
            else
            {
                lblRecenzie.ForeColor = Color.Red;
                txtRecenzie.Clear();
                esteValid = false;
            }
            if (esteValid == true)
            {
                lblSezoane.ForeColor = Color.Black;
                lblEpisoade.ForeColor = Color.Black;
                groupBoxGenuri.ForeColor = Color.Black;
                lblRecenzie.ForeColor = Color.Black;
                lblNume1.ForeColor = Color.Black;
                groupBoxStatus.ForeColor = Color.Black;
                groupBoxType.ForeColor = Color.Black;
                return true;
            }
            else
            {
                return false;
            }


        }
        private void ListaAnime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetareControale();
            Anime a = adminAnime.GetAnime(ListaAnime.SelectedIndex);
            txtNume1.Text = a.NumeAnime;
            txtSezoane.Text = a.SezoaneAnime.ToString();
            txtEpisoade.Text = a.EpisoadeAnime.ToString();
            txtRecenzie.Text = a.NotaAnime.ToString();

            foreach (Control c in groupBoxStatus.Controls)
            {
                if (c.GetType() == typeof(RadioButton))
                {
                    if (a.OngoingAnime.ToString() == c.Text)
                    {
                        ((RadioButton)c).Checked = true;
                    }
                }

            }

            foreach (Control c in groupBoxType.Controls)
            {
                if (c.GetType() == typeof(RadioButton))
                {
                    if (a.TipulAnime.ToString() == c.Text)
                    {
                        ((RadioButton)c).Checked = true;
                    }
                }
            }

            foreach (Control c in groupBoxGenuri.Controls)
            {
                if (c.GetType() == typeof(CheckBox))
                {
                    foreach (var gen in a.GenAnime)
                        if (((CheckBox)c).Text == gen)
                            ((CheckBox)c).Checked = true;
                }
            }

        }

        private void buttonModificare_Click(object sender, EventArgs e)
        {
            if (ListaAnime.SelectedIndex == -1)
            {
                return;
            }
            Anime a = adminAnime.GetAnime(ListaAnime.SelectedIndex);

            if (DateValide() == false)
            {
                label2.Visible = true;
                label2.ForeColor = Color.DeepSkyBlue;
                label2.Text = "Animeul nu a putut fi modificat";
                return;
            }

            a.NumeAnime = txtNume1.Text;

            a.NotaAnime = Convert.ToDouble(txtRecenzie.Text);
            a.SezoaneAnime = Convert.ToInt32(txtSezoane.Text);
            a.EpisoadeAnime = Convert.ToInt32(txtEpisoade.Text);

            TypeAnime? typeAnime = GetTypeAnime();
            if (typeAnime.HasValue)
            {
                a.TipulAnime = typeAnime.Value;
            }
            Status? status = GetStatus();
            if (status.HasValue)
            {
                a.OngoingAnime = status.Value;
            }

            a.GenAnime = new List<string>();
            a.GenAnime.AddRange(genurileBifate);
            if (adminAnime.RewriteAnime(a) == false)
            {
                label2.Visible = true;
                label2.ForeColor = Color.DeepSkyBlue;
                label2.Text = "Animeul nu a putut fi modificat";
            }
            else
            {
                label2.Visible = true;
                label2.ForeColor = Color.DeepSkyBlue;
                label2.Text = "Animeul selectat a fost modificat";
            }

            show();
            ResetareControale();
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

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            ResetareControale();
            show();
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
    }
}
