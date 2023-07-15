using System;
using System.Collections.Generic;

namespace Foundation1 {
    public class Comment {
        public string _commenter {get; set;}
        public string _text {get; set;}

        public Comment (string commenter, string text) {
            _commenter = commenter;
            _text = text;
        }
    }
}