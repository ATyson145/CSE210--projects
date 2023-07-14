using System;
using System.Collections.Generic;

namespace Develop03 {

    public class Reference {
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int _endVerse;

        public Reference(string reference) {
            ParseReference(reference);
        }
        public void ParseReference(string reference) {
            string[] parts = reference.Split("-");
            _book = parts[0];
            _chapter = int.Parse(parts[1]);
            _startVerse = int.Parse(parts[2]);
            _endVerse = int.Parse(parts[3]);
        }
        public override string ToString()
        {
            if (_startVerse == _endVerse)
            {
                return $"{_book} {_chapter}:{_startVerse}";
            }
            else
            {
                return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
            }
        }
    }
}