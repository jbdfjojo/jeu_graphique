namespace jeu_graphique
{
    partial class FormFenettre3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.value_joueur = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // value_joueur
            // 
            this.value_joueur.AutoSize = true;
            this.value_joueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_joueur.Location = new System.Drawing.Point(79, 24);
            this.value_joueur.Name = "value_joueur";
            this.value_joueur.Size = new System.Drawing.Size(72, 25);
            this.value_joueur.TabIndex = 0;
            this.value_joueur.Text = "joueur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "recommencer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormFenettre3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 110);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.value_joueur);
            this.Name = "FormFenettre3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormFenettre3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label value_joueur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}