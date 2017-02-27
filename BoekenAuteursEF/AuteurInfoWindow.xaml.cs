using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BoekenAuteursEF
{
    /// <summary>
    /// Interaction logic for AuteurInfoWindow.xaml
    /// </summary>
    public partial class AuteurInfoWindow : Window
    {
        private BoekenDBEntities boekenDB;
        private Authors auteur;
        private Users user;
        // TODO: zorg dat de gevraagde gevraagde gegevens (opgave)
        // in het AuteurInfoWindow worden getoond.
        // Zorg ook dat de foto van de auteur correct wordt getoond.

        public AuteurInfoWindow(Authors auteur, Users user)
        {
            // TODO: laat bij deze constructor de auteur
            // binnenkomen waarvan de info moet getoond worden.
            InitializeComponent();
            boekenDB = new BoekenDBEntities();
            this.auteur = auteur;
            this.user = user;
            this.DataContext = auteur;
            string auteurImgURL = "/Afbeeldingen/Auteurs/" + auteur.FirstName + "_" + auteur.LastName.Replace(" ", "_") + ".jpg";
            auteurImage.Source = new BitmapImage(new Uri(auteurImgURL, UriKind.Relative));
        }

        private void FavorietenButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Gebruik je entity data model om 
            // de voorkeur van de ingelogde voor deze auteur 
            // in je database op te slaan.
            // Indien dit correct in je database werd opgeslaan
            // toon je het bericht 'Favoriet succesvol toegevoegd'
            // en sluit je het venster.

            Preferences preference = new Preferences();
            preference.AuthorID = auteur.AuthorID;
            preference.UserID = user.UserID;
            preference.PreferenceData = DateTime.Now;
            boekenDB.Preferences.Add(preference);
            boekenDB.SaveChanges();
            MessageBox.Show("Favoriet succesvol toegevoegd");
            this.Close();
        }
    }
}
