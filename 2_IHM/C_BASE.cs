using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

using System.ComponentModel;
namespace _2_IHM
{
    class C_BASE
    {

        public BindingList<C_MATERIEL> Les_Materiels = new BindingList<C_MATERIEL>();
    

        public void Incremente()
        {
            int compteur;

            for (int i = 0; i < Les_Materiels.Count; i++)
            {
                compteur = Les_Materiels[i].Identifiant;
            }

        }

        public void Sauvegardement()
        {

            string Sauvegarde = JsonSerializer.Serialize<BindingList<C_MATERIEL>>(Les_Materiels);

            System.IO.File.WriteAllText("./materiel.json", Sauvegarde);
            
        }

        public void Chargement()
        {
            string donnees_serialiser;

            donnees_serialiser = System.IO.File.ReadAllText("./materiel.json");
            if (File.Exists("./materiel.json") == true)
            {
                donnees_serialiser = System.IO.File.ReadAllText("./materiel.json");

                Les_Materiels = JsonSerializer.Deserialize<BindingList<C_MATERIEL>>(donnees_serialiser);
            }


        }

        public C_MATERIEL Get_Materiel_Type(string P_Type)
        {
            C_MATERIEL Materiel_Trouve = null;

            foreach (C_MATERIEL Un_Materiel in Les_Materiels)
            {
                if (Un_Materiel.Type == P_Type)
                {
                    Materiel_Trouve = Un_Materiel;
                    break;
                }
            }



            return Materiel_Trouve;
        }

       
    }
}

