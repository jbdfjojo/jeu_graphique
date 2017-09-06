using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jeu_graphique
{
   

    public partial class FormFenettre2 : Form
    {
        // on cree une variable vide pour stocker FormFenettre1
        FormFenettre1 Fenetre1;
        private bool j1_paralisie = false;
        private bool j2_paralisie = false;

        public FormFenettre2(FormFenettre1 Fenetre)
        {
            InitializeComponent();

            // on stock FormFenettre1 dans notre variable
            this.Fenetre1 = Fenetre;
        }

        private void reinitialiser_Click(object sender, EventArgs e)
        {
            // on affiche la FormFenettre1
            this.Fenetre1.Show();

            // on cache FormFenettre2
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            
            // on ferme FormFenettre2
            this.Close();
            // on ferme FormFenettre1
            this.Fenetre1.Close();

        }

        private void FormFenettre2_Load(object sender, EventArgs e)
        {
            // on retire les control
            ControlBox = false;
             this.value_nom_joueur.Text = this.Fenetre1.Value_joueur();
             this.value_nom_adversaire.Text = this.Fenetre1.Value_adversaire();

            Random randNum = new Random();

            if (randNum.Next(2) == 1)
            {
                groupBox_joueur_1.Visible = false;
                groupBox_joueur_2.Visible = true;
            }
            else
            {
                groupBox_joueur_1.Visible = true;
                groupBox_joueur_2.Visible = false;
            }
        }


        // attaque joueur 1
        private void j1_attaque_puissance_5_Click(object sender, EventArgs e)
        {
            attaque_j2(25, 30);
            change_tour();
        }

        private void j1_attaque_puissance_3_Click(object sender, EventArgs e)
        {
            attaque_j2(15, 10);
            change_tour();
        }
        private void j1_attaque_puissance_1_Click(object sender, EventArgs e)
        {
            attaque_j2(10, 5);
            change_tour();
        }


        // attaque joueur 2
        private void j2_attaque_puissance_5_Click(object sender, EventArgs e)
        {
            attaque_j1(25, 30);
            change_tour();
        }

        private void j2_attaque_puissance_3_Click(object sender, EventArgs e)
        {
            attaque_j1(15, 10);
            change_tour();
        }

        private void j2_attaque_puissance_1_Click(object sender, EventArgs e)
        {
            attaque_j1(10, 5);
            change_tour();
        }


        // fonction pour attaquer
        private void attaque_j2(int value_attaque, int value_mana)
        {
            int attaque = int.Parse(j2_value_vie.Text);
            int mana = int.Parse(j1_value_mana.Text);

            // si le mana est superieur a zero
            if (mana > 1 && mana >= value_mana)
            {
                // la vie
                attaque -= value_attaque;

                if (attaque < 1)
                {
                    attaque = 0;
                }

                j2_value_vie.Text = attaque.ToString();

                // le mana
                mana -= value_mana;

                if (mana < 1)
                {
                    mana = 0;
                }

                j1_value_mana.Text = mana.ToString();
            }
        }

        private void attaque_j1(int value_attaque, int value_mana)
        {
            int attaque = int.Parse(j1_value_vie.Text);
            int mana = int.Parse(j2_value_mana.Text);

            // si le mana est superieur a zero
            if (mana > 1 && mana >= value_mana )
            {
                // la vie
                attaque -= value_attaque;

                if (attaque < 1)
                {
                    attaque = 0;
                }

                j1_value_vie.Text = attaque.ToString();

                // le mana
                mana -= value_mana;

                if (mana < 1)
                {
                    mana = 0;
                }

                j2_value_mana.Text = mana.ToString();
            }
        }

        // boost soin joueur 1
        private void j1_soin_grade_5_Click(object sender, EventArgs e)
        {
            boost_soin_j1(25,30);
            change_tour();
        }

        private void j1_soin_grade_3_Click(object sender, EventArgs e)
        {
            boost_soin_j1(15, 10);
            change_tour();
        }

        private void j1_soin_grade_1_Click(object sender, EventArgs e)
        {
            boost_soin_j1(10,5);
            change_tour();
        }

        // boost soin joueur 2
        private void j2_soin_grade_5_Click(object sender, EventArgs e)
        {
            boost_soin_j2(25, 30);
            change_tour();
        }

        private void j2_soin_grade_3_Click(object sender, EventArgs e)
        {
            boost_soin_j2(15, 10);
            change_tour();
        }

        private void j2_soin_grade_1_Click(object sender, EventArgs e)
        {
            boost_soin_j2(10, 5);
            change_tour();
        }

        // function pour boost soin 
        private void boost_soin_j1(int value_soin, int value_mana)
        {
            int vie = int.Parse(j1_value_vie.Text);
            int mana = int.Parse(j1_value_mana.Text);

            // si le mana est superieur a zero
            if (mana > 1 && mana >= value_mana)
            {
                // la vie
                vie += value_soin;

                if (vie > 101)
                {
                    vie = 100;
                }

                j1_value_vie.Text = vie.ToString();

                // le mana
                mana -= value_mana;

                if (mana < 1)
                {
                    mana = 0;
                }

                j1_value_mana.Text = mana.ToString();
            }
        }

        private void boost_soin_j2(int value_soin, int value_mana)
        {
            int vie = int.Parse(j2_value_vie.Text);
            int mana = int.Parse(j2_value_mana.Text);

            // si le mana est superieur a zero
            if (mana > 1 && mana >= value_mana)
            {
                // la vie
                vie += value_soin;

                if (vie > 101)
                {
                    vie = 100;
                }

                j2_value_vie.Text = vie.ToString();

                // le mana
                mana -= value_mana;

                if (mana < 1)
                {
                    mana = 0;
                }

                j2_value_mana.Text = mana.ToString();
            }
        }


        // paralisie joueur 1
        private void j1_paralysie_Click(object sender, EventArgs e)
        {
            j2_paralisie = true;
            change_tour();
        }

        // praralisie joueur 2
        private void j2_paralysie_Click(object sender, EventArgs e)
        {
            j1_paralisie = true;
            change_tour();
        }

        // boost de mana joueur 1  

        private void j1_boost_mana_Click(object sender, EventArgs e)
        {
            int mana = int.Parse(j1_value_mana.Text);

            // le mana
            mana += 20;

            if (mana > 101)
            {
                mana = 100;
            }

            j1_value_mana.Text = mana.ToString();

            change_tour();

        }

        // boost de mana joueur 2
        private void j2_boost_mana_Click(object sender, EventArgs e)
        {
            int mana = int.Parse(j2_value_mana.Text);

            // le mana
            mana += 20;

            if (mana > 101)
            {
                mana = 100;
            }

            j2_value_mana.Text = mana.ToString();

            change_tour();
        }

        // abondon joueur 1
        private void j1_abandonner_Click(object sender, EventArgs e)
        {
            FormFenettre3 FormFenettre3 = new FormFenettre3(" joueur 1 a abandonner", this, this.Fenetre1);

            FormFenettre3.Show();
            this.Hide();
        }

        // abandon joueur 2
        private void j2_abandonner_Click(object sender, EventArgs e)
        {
            FormFenettre3 FormFenettre3 = new FormFenettre3(" joueur 2 a abandonner", this, this.Fenetre1);

            FormFenettre3.Show();
            this.Hide();
        }

        // changement de tour

        public void change_tour()
        {
            if (j1_paralisie)
            {
                j1_paralisie = false;
            }
            else if (j2_paralisie)
            {
                j2_paralisie = false;
            }
            else
            {
                if(groupBox_joueur_1.Visible == true)
                {
                    groupBox_joueur_1.Visible = false;
                    groupBox_joueur_2.Visible = true;
                }
                else
                {
                    groupBox_joueur_1.Visible = true;
                    groupBox_joueur_2.Visible = false;
                }
            }

            int tour = int.Parse(value_tour.Text);

            tour += 1;

            value_tour.Text = tour.ToString();

            if (int.Parse(j2_value_vie.Text) < 1)
            {
                FormFenettre3 FormFenettre3 = new FormFenettre3(" joueur 1 a gagner", this, this.Fenetre1);

                FormFenettre3.Show();
                this.Hide();
            }

            if (int.Parse(j1_value_vie.Text) < 1)
            {
                FormFenettre3 FormFenettre3 = new FormFenettre3("joueur 2 a gagner", this, this.Fenetre1);

                FormFenettre3.Show();
                this.Hide();
            }

        }

        private void value_nom_joueur_Click(object sender, EventArgs e)
        {

        }
    }
}
