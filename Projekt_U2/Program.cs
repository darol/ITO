using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Linq;

namespace Projekt_U2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list  = LoadDataFromFile();
            CreateDecisionTreeAndSeparateClass(list);

        }

        private static List<MusicTrackCriteria> LoadDataFromFile()
        {
            //TODO: Obsługa ładownia pliku ze wskazanego przez uźytkownika miejsca
            var dataList = new List<MusicTrackCriteria>();
            dataList.Add(new MusicTrackCriteria("Release", "Perle Jam", 9.04, "Rock", 1991));
            dataList.Add(new MusicTrackCriteria("Étude Op. 10, No. 1", "Chopin", 2.02, "Classic", 1833));

            return dataList;
        }

        private static void CreateDecisionTreeAndSeparateClass(List<MusicTrackCriteria> dataList)
        {
            //TODO: Tworzenie drzewa decyzyjnego oraz sepraracja wg. klas
            var criteria = new MusicTrackCriteria();
            var criteriaList = new List<KeyValuePair<int,string>>();
            var choosenCriteria = new List<KeyValuePair<int, string>>();

            int i = 1;

            Console.WriteLine("List kryteriów do wyboru: ");
            foreach (var item in criteria.GetType().GetProperties())
            {
                Console.WriteLine(i.ToString(),item.Name);
                criteriaList.Add(new KeyValuePair<int,string>(i++, item.Name));
            }

            Console.WriteLine();
            Console.WriteLine("Wybierz trzy kryteria wpisując numer wyświetlony przy nazwie kryterium.");

            do
            {
                ConsoleKeyInfo info = Console.ReadKey();
                int choosenKey = 0;
                if (!int.TryParse(info.KeyChar.ToString(), out choosenKey))
                {
                    Console.WriteLine("Wybrana wartość nie jest numerem! Spóbuj ponownie.");
                }
                else 
                {
                    if (!choosenCriteria.Any(k => k.Key == choosenKey))
                    {
                        choosenCriteria.Add(criteriaList.FirstOrDefault(k => k.Key == choosenKey));
                        Console.WriteLine();
                    }
                    else 
                    {
                        Console.WriteLine();
                        Console.WriteLine("Kryterium " + choosenCriteria.FirstOrDefault(k => k.Key == choosenKey).Value + " zostało już wybrane! Spóbuj ponownie.");
                    }
                }

            }
            while (choosenCriteria.Count < 3);
        }

        private void DrawDecisionTree()
        {
            //TODO: Rysowanie drzewa dycyzyjnego w konsoli. Do ustalaenia parametry przekazywane do metody
        }

        private void PresentResult()
        {
            //TODO: Prezentacja wyników dla okreśnoych kryterów oraz porównanie ich. Do ustalenia pareametry przekazywane do metody
        }
    }

    public class MusicTrackCriteria
    {
        public MusicTrackCriteria()
        {
            
        }

        public MusicTrackCriteria(string title, string author, double duration, string musicGenre, int publicationDate)
        {
            Title = title;
            Author = author;
            Duration = duration;
            MusicGenre = musicGenre;
            PublicationDate = publicationDate;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public double Duration { get; set; }
        public string MusicGenre { get; set; }
        public int PublicationDate { get; set; }
    }
}
