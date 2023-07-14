using System;

namespace Learning04 {
    public class MathAssignment : Assignment {
        private string _textbook = "";
        private string _problems = "";

        public MathAssignment(string studentName, string topic, string textbook, string problems) : base(studentName, topic) {
                _textbook = textbook;
                _problems = problems;
            }

        public string GetTextbook() {
            return _textbook;
        }

        public string GetProblems() {
            return _problems;
        }

        public string GetHomeworkList() {
            return $"{_textbook}, {_problems}";
        }
    }
}