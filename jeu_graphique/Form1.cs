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
    public partial class FormFenettre1 : Form
    {

        public FormFenettre1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // on cree une nouvelle intance de Form2 et on envoie l'instance de FormFenettre1 dans FormFenettre2
            FormFenettre2 fenettre2 = new FormFenettre2(this);

            // on affiche Form2
            fenettre2.Show();

            // on cache Form1
            this.Hide();

        }

        private void FormFenettre1_Load(object sender, EventArgs e)
        {
            // on retire les control de la fennetre
            ControlBox = false;


        }

        private void close_Click(object sender, EventArgs e)
        {
            // on ferme la fenettre
            this.Close();

        }

        public string Value_joueur()

        { return Value_nom_joueur.Text; }

        public string Value_adversaire()

        { return Value_nom_adversaire.Text; }

    }
}
