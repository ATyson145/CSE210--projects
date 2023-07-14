using System;
using System.Collections.Generic;




namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            string reference = "2 Nephi-31-19-20";
            string text = @"And now, my beloved brethren, after ye have gotten
into this strait and narrow path, I would ask if all is done? Behold, I say unto you,
Nay; for ye have not come thus far save it were by the word of Christ with unshaken faith in him,
relying wholly upon the merits of him who is mighty to save. Wherefore, ye must press forward with
a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men.
Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end,
behold, thus saith the Father: Ye shall have eternal life.";

            var memorize = new Scripture(reference, text);
            memorize.DisplayScripture();

            while (true) {
                string input = Console.ReadLine();

                if (memorize.AllWordsHidden) {

                    Console.WriteLine("All words are hidden. Press enter to exit.");
                    Console.ReadLine();
                    break;
                }
                
                if (input.ToLower() == "quit") {
                    break;
                }

                memorize.HideWords();
            }
        }
    }
}
