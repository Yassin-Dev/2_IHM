
namespace _2_IHM
{
    partial class v
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
            this.Materiaux = new System.Windows.Forms.ListBox();
            this.TextBox_ID = new System.Windows.Forms.TextBox();
            this.TextBox_Type = new System.Windows.Forms.TextBox();
            this.TextBox_Modele = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BoutonAjouter = new System.Windows.Forms.Button();
            this.MAJ = new System.Windows.Forms.Button();
            this.BoutonSauv = new System.Windows.Forms.Button();
            this.textBox_Hauteur = new System.Windows.Forms.TextBox();
            this.Textbox_Largeur = new System.Windows.Forms.TextBox();
            this.SupprimerBouton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Creaton = new System.Windows.Forms.GroupBox();
            this.TextBox_LargeurCrea = new System.Windows.Forms.TextBox();
            this.TextBox_HauteurCrea = new System.Windows.Forms.TextBox();
            this.TextBox_IDcreation = new System.Windows.Forms.TextBox();
            this.TextBox_ModeleCrea = new System.Windows.Forms.TextBox();
            this.TextBox_TypeCrea = new System.Windows.Forms.TextBox();
            this.Acces_Ecriture = new System.Windows.Forms.RadioButton();
            this.ID = new System.Windows.Forms.Label();
            this.TypeMat = new System.Windows.Forms.Label();
            this.Modele = new System.Windows.Forms.Label();
            this.HauteurMat = new System.Windows.Forms.Label();
            this.LargeurMat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Creaton.SuspendLayout();
            this.SuspendLayout();
            // 
            // Materiaux
            // 
            this.Materiaux.BackColor = System.Drawing.Color.Maroon;
            this.Materiaux.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Materiaux.FormattingEnabled = true;
            this.Materiaux.ItemHeight = 37;
            this.Materiaux.Location = new System.Drawing.Point(110, 35);
            this.Materiaux.Name = "Materiaux";
            this.Materiaux.Size = new System.Drawing.Size(355, 485);
            this.Materiaux.TabIndex = 0;
            this.Materiaux.SelectedIndexChanged += new System.EventHandler(this.List_User_SelectedIndexChanged);
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.BackColor = System.Drawing.Color.Maroon;
            this.TextBox_ID.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_ID.Location = new System.Drawing.Point(22, 42);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.ReadOnly = true;
            this.TextBox_ID.Size = new System.Drawing.Size(203, 43);
            this.TextBox_ID.TabIndex = 1;
            // 
            // TextBox_Type
            // 
            this.TextBox_Type.BackColor = System.Drawing.Color.Maroon;
            this.TextBox_Type.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_Type.Location = new System.Drawing.Point(22, 108);
            this.TextBox_Type.Name = "TextBox_Type";
            this.TextBox_Type.ReadOnly = true;
            this.TextBox_Type.Size = new System.Drawing.Size(203, 43);
            this.TextBox_Type.TabIndex = 2;
            // 
            // TextBox_Modele
            // 
            this.TextBox_Modele.BackColor = System.Drawing.Color.Maroon;
            this.TextBox_Modele.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_Modele.Location = new System.Drawing.Point(22, 171);
            this.TextBox_Modele.Name = "TextBox_Modele";
            this.TextBox_Modele.ReadOnly = true;
            this.TextBox_Modele.Size = new System.Drawing.Size(203, 43);
            this.TextBox_Modele.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.Textbox_Largeur);
            this.groupBox1.Controls.Add(this.textBox_Hauteur);
            this.groupBox1.Controls.Add(this.TextBox_ID);
            this.groupBox1.Controls.Add(this.TextBox_Modele);
            this.groupBox1.Controls.Add(this.TextBox_Type);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(640, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 375);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lecture";
            // 
            // BoutonAjouter
            // 
            this.BoutonAjouter.BackColor = System.Drawing.Color.Black;
            this.BoutonAjouter.ForeColor = System.Drawing.Color.White;
            this.BoutonAjouter.Location = new System.Drawing.Point(1044, 471);
            this.BoutonAjouter.Name = "BoutonAjouter";
            this.BoutonAjouter.Size = new System.Drawing.Size(203, 49);
            this.BoutonAjouter.TabIndex = 6;
            this.BoutonAjouter.Text = "Ajouter";
            this.BoutonAjouter.UseVisualStyleBackColor = false;
            this.BoutonAjouter.Click += new System.EventHandler(this.BoutonAjouter_Click);
            this.BoutonAjouter.Enter += new System.EventHandler(this.BoutonAjouter_Enter);
            // 
            // MAJ
            // 
            this.MAJ.BackColor = System.Drawing.Color.DodgerBlue;
            this.MAJ.Location = new System.Drawing.Point(662, 493);
            this.MAJ.Name = "MAJ";
            this.MAJ.Size = new System.Drawing.Size(203, 49);
            this.MAJ.TabIndex = 5;
            this.MAJ.Text = "Modifier";
            this.MAJ.UseVisualStyleBackColor = false;
            this.MAJ.Click += new System.EventHandler(this.MAJ_Click);
            // 
            // BoutonSauv
            // 
            this.BoutonSauv.BackColor = System.Drawing.Color.Black;
            this.BoutonSauv.Enabled = false;
            this.BoutonSauv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BoutonSauv.Location = new System.Drawing.Point(110, 526);
            this.BoutonSauv.Name = "BoutonSauv";
            this.BoutonSauv.Size = new System.Drawing.Size(179, 49);
            this.BoutonSauv.TabIndex = 4;
            this.BoutonSauv.Text = "Sauvegarder";
            this.BoutonSauv.UseVisualStyleBackColor = false;
            this.BoutonSauv.Click += new System.EventHandler(this.BoutonSauv_Click);
            // 
            // textBox_Hauteur
            // 
            this.textBox_Hauteur.BackColor = System.Drawing.Color.Maroon;
            this.textBox_Hauteur.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_Hauteur.Location = new System.Drawing.Point(22, 236);
            this.textBox_Hauteur.Name = "textBox_Hauteur";
            this.textBox_Hauteur.ReadOnly = true;
            this.textBox_Hauteur.Size = new System.Drawing.Size(203, 43);
            this.textBox_Hauteur.TabIndex = 4;
            // 
            // Textbox_Largeur
            // 
            this.Textbox_Largeur.BackColor = System.Drawing.Color.Maroon;
            this.Textbox_Largeur.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Textbox_Largeur.Location = new System.Drawing.Point(22, 303);
            this.Textbox_Largeur.Name = "Textbox_Largeur";
            this.Textbox_Largeur.ReadOnly = true;
            this.Textbox_Largeur.Size = new System.Drawing.Size(203, 43);
            this.Textbox_Largeur.TabIndex = 5;
            // 
            // SupprimerBouton
            // 
            this.SupprimerBouton.BackColor = System.Drawing.Color.Maroon;
            this.SupprimerBouton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SupprimerBouton.Location = new System.Drawing.Point(295, 526);
            this.SupprimerBouton.Name = "SupprimerBouton";
            this.SupprimerBouton.Size = new System.Drawing.Size(170, 49);
            this.SupprimerBouton.TabIndex = 7;
            this.SupprimerBouton.Text = "Supprimer";
            this.SupprimerBouton.UseVisualStyleBackColor = false;
            this.SupprimerBouton.Click += new System.EventHandler(this.SupprimerBouton_Click);
            // 
            // Creaton
            // 
            this.Creaton.BackColor = System.Drawing.SystemColors.ControlText;
            this.Creaton.Controls.Add(this.TextBox_LargeurCrea);
            this.Creaton.Controls.Add(this.TextBox_HauteurCrea);
            this.Creaton.Controls.Add(this.TextBox_IDcreation);
            this.Creaton.Controls.Add(this.TextBox_ModeleCrea);
            this.Creaton.Controls.Add(this.TextBox_TypeCrea);
            this.Creaton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Creaton.Location = new System.Drawing.Point(1022, 55);
            this.Creaton.Name = "Creaton";
            this.Creaton.Size = new System.Drawing.Size(241, 375);
            this.Creaton.TabIndex = 8;
            this.Creaton.TabStop = false;
            this.Creaton.Text = "Création";
            this.Creaton.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TextBox_LargeurCrea
            // 
            this.TextBox_LargeurCrea.BackColor = System.Drawing.Color.Maroon;
            this.TextBox_LargeurCrea.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_LargeurCrea.Location = new System.Drawing.Point(22, 303);
            this.TextBox_LargeurCrea.Name = "TextBox_LargeurCrea";
            this.TextBox_LargeurCrea.Size = new System.Drawing.Size(203, 43);
            this.TextBox_LargeurCrea.TabIndex = 5;
            // 
            // TextBox_HauteurCrea
            // 
            this.TextBox_HauteurCrea.BackColor = System.Drawing.Color.Maroon;
            this.TextBox_HauteurCrea.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_HauteurCrea.Location = new System.Drawing.Point(22, 236);
            this.TextBox_HauteurCrea.Name = "TextBox_HauteurCrea";
            this.TextBox_HauteurCrea.Size = new System.Drawing.Size(203, 43);
            this.TextBox_HauteurCrea.TabIndex = 4;
            // 
            // TextBox_IDcreation
            // 
            this.TextBox_IDcreation.BackColor = System.Drawing.Color.Maroon;
            this.TextBox_IDcreation.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_IDcreation.Location = new System.Drawing.Point(22, 42);
            this.TextBox_IDcreation.Name = "TextBox_IDcreation";
            this.TextBox_IDcreation.Size = new System.Drawing.Size(203, 43);
            this.TextBox_IDcreation.TabIndex = 1;
            // 
            // TextBox_ModeleCrea
            // 
            this.TextBox_ModeleCrea.BackColor = System.Drawing.Color.Maroon;
            this.TextBox_ModeleCrea.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_ModeleCrea.Location = new System.Drawing.Point(22, 171);
            this.TextBox_ModeleCrea.Name = "TextBox_ModeleCrea";
            this.TextBox_ModeleCrea.Size = new System.Drawing.Size(203, 43);
            this.TextBox_ModeleCrea.TabIndex = 3;
            // 
            // TextBox_TypeCrea
            // 
            this.TextBox_TypeCrea.BackColor = System.Drawing.Color.Maroon;
            this.TextBox_TypeCrea.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TextBox_TypeCrea.Location = new System.Drawing.Point(22, 108);
            this.TextBox_TypeCrea.Name = "TextBox_TypeCrea";
            this.TextBox_TypeCrea.Size = new System.Drawing.Size(203, 43);
            this.TextBox_TypeCrea.TabIndex = 2;
            // 
            // Acces_Ecriture
            // 
            this.Acces_Ecriture.AutoSize = true;
            this.Acces_Ecriture.BackColor = System.Drawing.SystemColors.Control;
            this.Acces_Ecriture.Location = new System.Drawing.Point(662, 436);
            this.Acces_Ecriture.Name = "Acces_Ecriture";
            this.Acces_Ecriture.Size = new System.Drawing.Size(212, 42);
            this.Acces_Ecriture.TabIndex = 9;
            this.Acces_Ecriture.Text = "Accès écriture";
            this.Acces_Ecriture.UseVisualStyleBackColor = false;
            this.Acces_Ecriture.EnabledChanged += new System.EventHandler(this.Acces_Ecriture_EnabledChanged);
            this.Acces_Ecriture.Click += new System.EventHandler(this.Acces_Ecriture_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(576, 97);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(58, 38);
            this.ID.TabIndex = 10;
            this.ID.Text = "ID :";
            this.ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // TypeMat
            // 
            this.TypeMat.AutoSize = true;
            this.TypeMat.Location = new System.Drawing.Point(545, 163);
            this.TypeMat.Name = "TypeMat";
            this.TypeMat.Size = new System.Drawing.Size(89, 38);
            this.TypeMat.TabIndex = 11;
            this.TypeMat.Text = "Type :";
            // 
            // Modele
            // 
            this.Modele.AutoSize = true;
            this.Modele.Location = new System.Drawing.Point(509, 226);
            this.Modele.Name = "Modele";
            this.Modele.Size = new System.Drawing.Size(125, 38);
            this.Modele.TabIndex = 12;
            this.Modele.Text = "Modèle :";
            // 
            // HauteurMat
            // 
            this.HauteurMat.AutoSize = true;
            this.HauteurMat.Location = new System.Drawing.Point(495, 291);
            this.HauteurMat.Name = "HauteurMat";
            this.HauteurMat.Size = new System.Drawing.Size(139, 38);
            this.HauteurMat.TabIndex = 13;
            this.HauteurMat.Text = "Hauteur : ";
            // 
            // LargeurMat
            // 
            this.LargeurMat.AutoSize = true;
            this.LargeurMat.Location = new System.Drawing.Point(495, 358);
            this.LargeurMat.Name = "LargeurMat";
            this.LargeurMat.Size = new System.Drawing.Size(125, 38);
            this.LargeurMat.TabIndex = 14;
            this.LargeurMat.Text = "Largeur :";
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1376, 641);
            this.Controls.Add(this.LargeurMat);
            this.Controls.Add(this.HauteurMat);
            this.Controls.Add(this.Modele);
            this.Controls.Add(this.TypeMat);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Acces_Ecriture);
            this.Controls.Add(this.Creaton);
            this.Controls.Add(this.BoutonAjouter);
            this.Controls.Add(this.SupprimerBouton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Materiaux);
            this.Controls.Add(this.BoutonSauv);
            this.Controls.Add(this.MAJ);
            this.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "v";
            this.Text = "IHM_USER";
            this.Load += new System.EventHandler(this.C_CADRE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Creaton.ResumeLayout(false);
            this.Creaton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Materiaux;
        private System.Windows.Forms.TextBox TextBox_ID;
        private System.Windows.Forms.TextBox TextBox_Type;
        private System.Windows.Forms.TextBox TextBox_Modele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BoutonSauv;
        private System.Windows.Forms.Button MAJ;
        private System.Windows.Forms.Button BoutonAjouter;
        private System.Windows.Forms.TextBox Textbox_Largeur;
        private System.Windows.Forms.TextBox textBox_Hauteur;
        private System.Windows.Forms.Button SupprimerBouton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox Creaton;
        private System.Windows.Forms.TextBox TextBox_LargeurCrea;
        private System.Windows.Forms.TextBox TextBox_HauteurCrea;
        private System.Windows.Forms.TextBox TextBox_IDcreation;
        private System.Windows.Forms.TextBox TextBox_ModeleCrea;
        private System.Windows.Forms.TextBox TextBox_TypeCrea;
        private System.Windows.Forms.RadioButton Acces_Ecriture;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label TypeMat;
        private System.Windows.Forms.Label Modele;
        private System.Windows.Forms.Label HauteurMat;
        private System.Windows.Forms.Label LargeurMat;
    }
}

