using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BoekenAuteursData
{
    public class Book
    {
        // TODO: Vul hier je Book business class aan
        public event PropertyChangedEventHandler PropertyChanged;

        private string iSBN;
        private string titel;
        private int authorID;
        private int pages;
        private string genre;
        private string content;
        private string auteur;

        public Book() { }

        public string ISBN
        {
            get
            {
                return iSBN;
            }
            set
            {
                iSBN = value;
                OnPropertyChanged();
            }
        }

        public string Titel
        {
            get
            {
                return titel;
            }
            set
            {
                titel = value;
                OnPropertyChanged();
            }
        }

        public int AuthorID
        {
            get
            {
                return authorID;
            }
            set
            {
                authorID = value;
                OnPropertyChanged();
            }
        }

        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = value;
                OnPropertyChanged();
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
                OnPropertyChanged();
            }
        }

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                OnPropertyChanged();
            }
        }

        public string Auteur
        {
            get
            {
                return auteur;
            }
            set
            {
                auteur = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
