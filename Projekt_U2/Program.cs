using System;
using System.Collections.Generic;

namespace Projekt_U2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private void LoadDataFromFile(string path, string fileName)
        {
            //TODO: Obsługa ładownia pliku ze wskazanego przez uźytkownika miejsca
        }

        private void CreateDecisionTreeAndSeparateClass(List<string> dataList, List<string> criteriaList)
        {
            //TODO: Tworzenie drzewa decyzyjnego oraz sepraracja wg. klas
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
        public string Title { get; set; }
        public string Author { get; set; }
        public double Duration { get; set; }
        public string MusicGenre { get; set; }
    }
}
