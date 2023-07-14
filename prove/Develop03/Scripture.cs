using System;
using System.Collections.Generic;
using System.Linq;

namespace Develop03 {

    public class Scripture {
        private List<Word> words;
        private Random random;

        private Reference newReference;
        public bool AllWordsHidden => words.All(w => w._isHidden);

        public Scripture(string reference, string text) {
            newReference = new Reference(reference);
            InitializeWords(text);
            random = new Random();
        }

        private void InitializeWords(string text) {
            string[] parts = text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            words = new List<Word>();

            foreach (string part in parts) {
                Word word = new Word(part);
                words.Add(word);
            }
        }

        public void HideWords () {
            int hiddenCount = words.Count(w => w._isHidden);
            if (hiddenCount == words.Count) {
                Console.WriteLine("All words are hidden. Hit enter to exit. ");
            }
            foreach (var word in GetRandomWords()) {
                word._isHidden = true;
            }
            
            DisplayScripture();

            }

        private IEnumerable<Word> GetRandomWords() {
            var hiddenWords = words.Where(w => !w._isHidden).ToList();
            int wordsToHide = Math.Min(3, hiddenWords.Count);
            var randomHiddenWords = new List<Word>();

            for (int i = 0; i < wordsToHide; i++) {
                int randomIndex = random.Next(hiddenWords.Count);
                randomHiddenWords.Add(hiddenWords[randomIndex]);
                hiddenWords.RemoveAt(randomIndex);
        }

            return randomHiddenWords;
        }

        public void DisplayScripture() {
            Console.Clear();
            Console.WriteLine(newReference.ToString());

            const int maxLineLength = 80; // Adjust the line length as needed
            int currentLineLength = 0;


            foreach (var word in words) {
                string output = word._isHidden ? new string('_', word._text.Length) : word._text;

                if (currentLineLength + output.Length > maxLineLength) {

                    Console.WriteLine();
                    currentLineLength = 0;

                }

                Console.Write($"{output} ");
                currentLineLength += output.Length + 1;
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to exit.");
        }
    }
}
