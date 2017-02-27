using System;
using System.Collections.Generic;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        // TODO: gebruik je entity data model om users data
        // te lezen en te controleren of
        // - de gebruikersnaam bestaat in de database
        // - het paswoord voor de gebruiker klopt
        // Toon de respectievelijk berichtvensters indien
        // de opgegeven gebruiker of het paswoord foutief werden ingegeven.
        // Wanneer de gebruiker kan inloggen creëer je
        // een User property voor dit Window 
        // om de ingelogde gebruiker bij te houden
        // en open je het MainWindow 
        private BoekenDBEntities boekenDB;
        private Users user;

        public LoginWindow()
        {
            InitializeComponent();
            boekenDB = new BoekenDBEntities();
            user = new Users();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = gebruikernaamTextBox.Text;
            string password = paswoordPasswordBox.Password;
            try
            {
                user = (from Users in boekenDB.Users
                        where Users.UserName == username
                        select Users).First();
            }catch(Exception ex)
            {
                MessageBox.Show(username+" is geen geldige username!");
            }
            
            if (user.Password == password)
            {
                MainWindow mW = new MainWindow(user);
                mW.Show();
            }
            else
            {
                MessageBox.Show("Je passwoord is ongeldig!");
            }
        }
    }
}
