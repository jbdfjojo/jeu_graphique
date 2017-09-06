namespace jeu_graphique
{
    partial class FormFenettre1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.titre_jeu = new System.Windows.Forms.Label();
            this.label_nom_joueur = new System.Windows.Forms.Label();
            this.label_nom_adversaire = new System.Windows.Forms.Label();
            this.Value_nom_joueur = new System.Windows.Forms.TextBox();
            this.Value_nom_adversaire = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titre_jeu
            // 
            this.titre_jeu.AutoSize = true;
            this.titre_jeu.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre_jeu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.titre_jeu.Location = new System.Drawing.Point(352, 9);
            this.titre_jeu.Name = "titre_jeu";
            this.titre_jeu.Size = new System.Drawing.Size(139, 57);
            this.titre_jeu.TabIndex = 0;
            this.titre_jeu.Text = "jeu rpg";
            // 
            // label_nom_joueur
            // 
            this.label_nom_joueur.AutoSize = true;
            this.label_nom_joueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom_joueur.Location = new System.Drawing.Point(154, 183);
            this.label_nom_joueur.Name = "label_nom_joueur";
            this.label_nom_joueur.Size = new System.Drawing.Size(195, 24);
            this.label_nom_joueur.TabIndex = 1;
            this.label_nom_joueur.Text = "votre nom de joueur : ";
            // 
            // label_nom_adversaire
            // 
            this.label_nom_adversaire.AutoSize = true;
            this.label_nom_adversaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom_adversaire.Location = new System.Drawing.Point(96, 242);
            this.label_nom_adversaire.Name = "label_nom_adversaire";
            this.label_nom_adversaire.Size = new System.Drawing.Size(253, 24);
            this.label_nom_adversaire.TabIndex = 2;
            this.label_nom_adversaire.Text = "le nom de votre adversaire  : ";
            // 
            // Value_nom_joueur
            // 
            this.Value_nom_joueur.AccessibleName = "";
            this.Value_nom_joueur.Location = new System.Drawing.Point(400, 186);
            this.Value_nom_joueur.Name = "Value_nom_joueur";
            this.Value_nom_joueur.Size = new System.Drawing.Size(261, 20);
            this.Value_nom_joueur.TabIndex = 3;
            // 
            // Value_nom_adversaire
            // 
            this.Value_nom_adversaire.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Value_nom_adversaire.Location = new System.Drawing.Point(400, 247);
            this.Value_nom_adversaire.Name = "Value_nom_adversaire";
            this.Value_nom_adversaire.Size = new System.Drawing.Size(261, 20);
            this.Value_nom_adversaire.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(316, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "debuter le jeu !!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(12, 434);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(103, 39);
            this.close.TabIndex = 6;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // FormFenettre1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 485);
            this.Controls.Add(this.close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Value_nom_adversaire);
            this.Controls.Add(this.Value_nom_joueur);
            this.Controls.Add(this.label_nom_adversaire);
            this.Controls.Add(this.label_nom_joueur);
            this.Controls.Add(this.titre_jeu);
            this.Name = "FormFenettre1";
            this.Text = "jeu rpg";
            this.Load += new System.EventHandler(this.FormFenettre1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre_jeu;
        private System.Windows.Forms.Label label_nom_joueur;
        private System.Windows.Forms.Label label_nom_adversaire;
        private System.Windows.Forms.TextBox Value_nom_joueur;
        private System.Windows.Forms.TextBox Value_nom_adversaire;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button close;
    }
}

