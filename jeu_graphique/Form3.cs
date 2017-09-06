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
    public partial class FormFenettre3 : Form
    {
        FormFenettre2 fenettre2;
        FormFenettre1 fenettre1;

        public FormFenettre3( String joueur , FormFenettre2 fenettre2, FormFenettre1 fenettre1)
        {
            InitializeComponent();

            this.value_joueur.Text = joueur;
            this.fenettre2 = fenettre2;
            this.fenettre1 = fenettre1;
        }

        private void FormFenettre3_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.fenettre2.Close();
            this.fenettre1.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.fenettre1.Show();
            this.Hide();
        }
    }
}
