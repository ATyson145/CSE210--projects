using System;
using System.IO;

namespace Develop02
{
    ///<summary>
    ///The responsibility of an Entry is to store a prompt, response and date.
    ///</summary>

    public class Entry
    {
        public string _prompt {get; set;}
        public string _response {get; set;}
        public string _date {get; set;}
        public Entry(string prompt, string response, string date) {

            _prompt = prompt;
            _response = response;
            _date = date;

        }
        public override string ToString(){

            return $"\n{_date}: | Prompt: {_prompt} | Response: {_response}\n";

        }
    }
}