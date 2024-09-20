using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionaries_LandonBarnett
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Makes the dictionary of top games
            Dictionary<int, string> topGames = new Dictionary<int, string>();
            topGames.Add(1, "Tiny Tina's Wonderlands");
            topGames.Add(2, "CS:GO");
            topGames.Add(3, "Halo 3");
            topGames.Add(4, "Elden Ring");
            topGames.Add(5, "Sonic Adventures 2");
            topGames.Add(6, "Kirby Airride");
            topGames.Add(7, "Donkey Kong 64");
            topGames.Add(8, "Runescape");
            topGames.Add(9, "GTA: San Andreas");
            topGames.Add(10, "Valorant");

            ///prints key value pairs from top games
            foreach (KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            ///prints that key 1(Tiny Tina's Wonderland) is my fav game
            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}!");
            }

            /// result is empty
            string result = "";

            ///trys to get the 11 value
            topGames.TryGetValue(11, out result);

            /// if result is not null or empty prints result, otherwise prints no game
            if (!string.IsNullOrEmpty(result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no game in the eleventh position.");
            }

            /// if top games contains 5 then it will change top games[5] to be rocket league
            if (topGames.ContainsKey(5))
            {
                topGames[5] = "Rocket League";
            }

            /// prints rocket league/topgames[5]
            Console.WriteLine(topGames[5]);

            ///creates hashtable with topGames values
            Hashtable hashTable = new Hashtable(topGames);

            ///sets favGame as the hashtable/dictionary value 1
            string favGame = (string)hashTable[1];

            /// prints favGame/tiny Tina
            Console.WriteLine($"Favorite Game: {favGame}");

            /// new hashtable with capitals
            Hashtable capitals = new Hashtable() {
                { "Oklahoma", "Oklahoma City" },
                { "New York", "Albany" },
                { "Texas", "Austin" },
                { "Ohio", "Columbus" }
            };

            ///prints all key value pairs in capitals
            foreach (DictionaryEntry kvp in capitals)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            /// clears capitals
            capitals.Clear();
        }
    }
}