using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace _2_IHM
{
 

    public partial class v : Form
    {
     private C_BASE La_Base;
        

        public v()
        {
            InitializeComponent();

            La_Base = new C_BASE();

            La_Base.Chargement();

 
          Materiaux.DataSource = La_Base.Les_Materiels;
            Materiaux.DisplayMember = "Identifiant";

        }

        private void List_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_MATERIEL Materiel_Selectionne = Materiaux.SelectedItem as C_MATERIEL;

            TextBox_ID.Text = Materiel_Selectionne.Identifiant.ToString();
            TextBox_Type.Text = Materiel_Selectionne.Type;
            TextBox_Modele.Text = Materiel_Selectionne.Modele;
            textBox_Hauteur.Text = Materiel_Selectionne.Hauteur.ToString();
            Textbox_Largeur.Text = Materiel_Selectionne.Largeur.ToString();



        }

        private void BoutonSauv_Click(object sender, EventArgs e)
        {
            La_Base.Sauvegardement();
            BoutonSauv.Enabled = false;
        }

        private void MAJ_Click(object sender, EventArgs e)
        {
            C_MATERIEL User_Materiel= Materiaux.SelectedItem as C_MATERIEL;

            if (User_Materiel != null)
            {
                User_Materiel.Type = TextBox_Type.Text;
                User_Materiel.Modele = TextBox_Modele.Text;
                User_Materiel.Hauteur = Convert.ToInt32(textBox_Hauteur.Text);
                User_Materiel.Largeur = Convert.ToInt32(Textbox_Largeur.Text);

            }

            BoutonSauv.Enabled = true;
            Acces_Ecriture.Checked = false;

            TextBox_Modele.ReadOnly = true;
            textBox_Hauteur.ReadOnly = true;
            Textbox_Largeur.ReadOnly = true;

        }

        private void C_CADRE_Load(object sender, EventArgs e)
        {

        }

        private void BoutonAjouter_Click(object sender, EventArgs e)
        {
            C_MATERIEL Nouveau_Materiel = new C_MATERIEL();
            int compteur = 3;
            Nouveau_Materiel.Identifiant = compteur + 1 ;
            Nouveau_Materiel.Type = TextBox_TypeCrea.Text;
            Nouveau_Materiel.Modele = TextBox_ModeleCrea.Text;
            Nouveau_Materiel.Hauteur = Convert.ToInt32(TextBox_HauteurCrea.Text);
            Nouveau_Materiel.Largeur = Convert.ToInt32(TextBox_LargeurCrea.Text);

            La_Base.Les_Materiels.Add(Nouveau_Materiel);

            BoutonSauv.Enabled = true;


        }

        private void SupprimerBouton_Click(object sender, EventArgs e)
        {
            C_MATERIEL Supprimer_Materiel = Materiaux.SelectedItem as C_MATERIEL;

            La_Base.Les_Materiels.Remove(Supprimer_Materiel);
            BoutonSauv.Enabled = true;

        }

        private void BoutonAjouter_Enter(object sender, EventArgs e)
        {
           
        }

        private void Acces_Ecriture_Click(object sender, EventArgs e)
        {
            TextBox_Modele.ReadOnly = false;
            textBox_Hauteur.ReadOnly = false;
            Textbox_Largeur.ReadOnly = false;
        }

        private void Acces_Ecriture_EnabledChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
