using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinForms3RestApiApp.Views
{
    public partial class GamePage : ContentPage
    {
        const int NB_MAGIQUE_MIN = 1;
        const int NB_MAGIQUE_MAX = 50000;
        int nombreMagique = 0;
        static int tryCount;

        public GamePage()
        {
            InitializeComponent();
            nombreMagique = new Random().Next(NB_MAGIQUE_MIN, NB_MAGIQUE_MAX);
            minMaxLabel.Text = "Entre" + " " + NB_MAGIQUE_MIN + " " + " et " + NB_MAGIQUE_MAX;

        }


        private void ButtonDeviner(object sender, EventArgs e)
        {
            int nombreUtilisateur = Int32.Parse(numberEntry.Text);

            if ((nombreUtilisateur < NB_MAGIQUE_MIN) || (nombreUtilisateur > NB_MAGIQUE_MAX))
            {
                DisplayAlert("Attention", "Vous devez entrer un nombre entre " + " " + NB_MAGIQUE_MIN + " " + " et " + NB_MAGIQUE_MAX + " ", "ok");
            }
            else
            {


                if (nombreMagique > nombreUtilisateur)
                {
                    tryCount++;
                    if (tryCount == 20 || tryCount > 20)
                    {
                        DisplayAlert("Oops", "le nombre d'essaie est atteint ", " Veuillez redemarrer l'application et recommencer", "ok");
                    }
                    else
                    {


                        DisplayAlert("Oops", "le nombre magique est superieur à " + nombreUtilisateur + " " + "Nombre d'essaie: " + tryCount, "ok");
                        return;
                    }
                }
                if (nombreMagique < nombreUtilisateur)
                {
                    tryCount++;
                    if (tryCount == 20 || tryCount > 20)
                    {

                        DisplayAlert("Oops", "le nombre d'essaie est atteint ", " Veuillez redemarrer l'application et recommencer", "ok");

                    }
                    else
                    {

                        DisplayAlert("Oops", "le nombre magique est inferieur à " + nombreUtilisateur + " " + "Nombre d'essaie: " + tryCount, "ok");
                        return;
                    }
                }
                if (nombreMagique == nombreUtilisateur)
                {
                    tryCount++;
                    DisplayAlert("Gagné", "le nombre magique est  : " + nombreMagique + " Vous l'avez trouvez en " + " " + tryCount + " essaies", "ok");
                    return;
                }
            }
        }
    }
}