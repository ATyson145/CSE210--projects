using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    ///<summary>
    ///The responsibilty of a Journal is to hold entries.
    ///</summary>
    public class Journal
    {
        public List<Entry> entries;
        public Journal()
        {
            entries = new List<Entry>();
        }
        public void StoreEntry(string prompt, string response, string date)
        {
            Entry newEntry = new Entry(prompt, response, date);
            entries.Add(newEntry);
            Console.WriteLine("\nNew entry added!\n");
        }
        public void DisplayEntries() {
            foreach (Entry entry in entries) {

                Console.WriteLine(entry);

            }
        }
        public void SaveJournal(string filename) {
            using (StreamWriter outputfile = new StreamWriter(filename, true)) {

                foreach (Entry entry in entries) {

                    outputfile.WriteLine($"\n{entry._prompt} | {entry._response} | {entry._date}");

                }
                entries.Clear();
            }
        }
        public void LoadJournal(string filename) {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines) {
                string[] parts = line.Split(" | ");

                if (parts.Length == 3) {
                    string prompt = parts[0];
                    string response = parts[1];
                    string date = parts[2];

                    Entry entry = new Entry(prompt, response, date);
                    entries.Add(entry);
                }
            }
        }
    }
}