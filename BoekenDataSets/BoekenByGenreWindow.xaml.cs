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

namespace BoekenAuteursDataSets
{
    /// <summary>
    /// Interaction logic for BoekenByGenre.xaml
    /// </summary>
    public partial class BoekenByGenreWindow : Window
    {
        // TODO: Declareer hier de nodige variabelen 
        private BoekenAuteursDataSets.BoekenDBDataSet boekenDBDataSet;

        private BoekenAuteursDataSets.BoekenDBDataSetTableAdapters.BooksTableAdapter boekenDBDataSetBooksTableAdapter;
        private System.Windows.Data.CollectionViewSource booksViewSource;

        private BoekenAuteursDataSets.BoekenDBDataSetTableAdapters.GenreTableAdapter boekenDBDataSetGenreTableAdapter;
        private System.Windows.Data.CollectionViewSource genreViewSource;
        public BoekenByGenreWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //TODO: Voeg hier je code toe om dmv je dataset je Genres data te laden

            boekenDBDataSet = ((BoekenAuteursDataSets.BoekenDBDataSet)(this.FindResource("boekenDBDataSet")));

            boekenDBDataSetBooksTableAdapter = new BoekenAuteursDataSets.BoekenDBDataSetTableAdapters.BooksTableAdapter();
            booksViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("booksViewSource")));
            booksViewSource.View.MoveCurrentToFirst();

            boekenDBDataSetGenreTableAdapter = new BoekenAuteursDataSets.BoekenDBDataSetTableAdapters.GenreTableAdapter();
            boekenDBDataSetGenreTableAdapter.Fill(boekenDBDataSet.Genre);
            genreViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("genreViewSource")));
            genreViewSource.View.MoveCurrentToFirst();

            genreComboBox.ItemsSource = genreViewSource.View;
            genreComboBox.DisplayMemberPath = "Genre";
        }

        private void genreComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //TODO: Voeg hier de code toe om de boeken van een specifiek genre te laden dmv van het DataSet' 

            int genreIndex = genreComboBox.SelectedIndex;
            string genre = boekenDBDataSet.Genre[genreIndex].Genre;
            boekenDBDataSetBooksTableAdapter.FillByGenre(boekenDBDataSet.Books, genre);

            //int festId = festDataSet.Festivals[naamComboBox.SelectedIndex].FestivalId;
            //festDataSetBezoekersTableAdapter.FillByFestival(festDataSet.Bezoekers, festId);
        }

    }
}
