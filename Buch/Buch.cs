using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buch
{
    class Buch
    {
        // Variablen Daten
        private string Title;
        private string Author;
        private int ISBN;
        private string Genre;
        private string Verlag;
        private int Erscheinungsjahr;
        private string Kommentar;

        public Buch()
        {
            // Konstruktor mit nichts
            Title = "";
            Author = "";
            ISBN = 0;
            Genre = "";
            Verlag = "";
            Erscheinungsjahr = 0;
            Kommentar = "";
        }
        // Konstruktor mit Titel und Author nur
        public Buch(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = 0;
            Genre = "";
            Verlag = "";
            Erscheinungsjahr = 0;
            Kommentar = "";
        }
        // Konstruktor mit Titel, Author, ISBN nummer und Erscheinungsjahr
        public Buch(string title, string author, int isbn, int erscheinungsjahr)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Genre = "";
            Verlag = "";
            Erscheinungsjahr = erscheinungsjahr;
            Kommentar = "";
        }
        // Konstruktor mit alles
        public Buch(string title, string author, int isbn, string genre, string verlag, int erscheinungsjahr, string kommentar)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Genre = genre;
            Verlag = verlag;
            Erscheinungsjahr = erscheinungsjahr;
            Kommentar = kommentar;
        }
        
        
        // get und set für Titel
        public string get_Title() 
        { 
            return Title;
        }
        public void set_Title(string title) { Title = title; } 

        // get und set für Author
        public string get_Author() 
        { 
            return Author;
        }
        public void set_Author(string author) {  Author = author; }

        // get und set für ISBN
        public int get_ISBN() 
        { 
            return ISBN;
        }
        public void set_ISBN(int isbn) { ISBN = isbn; }

        // get und set für Genre
        public string get_Genre() 
        { 
            return Genre;
        }
        public void set_Genre(string genre) { Genre = genre; }

        // get und set für Verlags
        public string get_Verlag() 
        { 
            return Genre;
        }
        public void set_Verlag(string verlag) { Verlag = verlag; }

        // get und set für Erscheinungsjahr
        public int get_Erscheinungsjahr() 
        { 
            return Erscheinungsjahr;
        }
        public void set_Erscheinungsjahr(int erscheinungsjahr) { Erscheinungsjahr = erscheinungsjahr; }

        // get und set für Kommentar
        public string get_Kommentar() 
        { 
            return Kommentar; 
        }
        public void set_Kommentar(string kommentar) { Kommentar = kommentar; }
    }
    class Start
    {
        static void Main(string[] args)
        {
            // neues Objekt
            Buch buch = new Buch();

            // Variablen angeben
            buch.set_Title("American Psycho");
            buch.set_Author("Bret Easton Ellis");
            buch.set_Genre("Thriller");
            buch.set_Erscheinungsjahr(1991);
            buch.set_Kommentar("\nAmerican Psycho ist eine düstere, bittere Satire über die Oberflächlichkeit und Gewalt in der New Yorker Finanzwelt der 1980er Jahre");

            // '\n' newline macht es untereinander , und ' verwenden 
            Console.WriteLine(buch.get_Author() + '\n');
            Console.WriteLine(buch.get_Title() + '\n');
            Console.WriteLine(buch.get_Genre() + '\n');
            Console.WriteLine(buch.get_Erscheinungsjahr() + '\n');
            Console.WriteLine(buch.get_Kommentar());


            // Pause machen damit nicht automatisch schließt
            Console.ReadKey();
        }
    }
}