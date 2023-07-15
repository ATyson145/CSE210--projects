using System;
using System.Collections.Generic;

namespace Foundation1 {
    class Program
    {
        static void Main(string[] args)
        {
            var videos = new List<Video> {
            new Video("How to cook a burger", "Chef Fresh", 120),
            new Video("WWII in 3 minutes", "Historian Tomato", 180),
            new Video("Squirrel life", "Random Lays Bag", 90)
            };

            videos[0]._comments.Add(new Comment("FazeRacks", "That burger looks great!"));
            videos[0]._comments.Add(new Comment("Ewok145", "I can make them better than that."));
            videos[1]._comments.Add(new Comment("CrazedFan", "Actually the Nazis were powered by aliens..."));
            videos[2]._comments.Add(new Comment("Aman212", "Look at that squirrel go!"));
            videos[2]._comments.Add(new Comment("Womert", "If only I had a yard like that..."));
            videos[2]._comments.Add(new Comment("Painnogain", "First"));

            foreach (var video in videos) {
                Console.WriteLine("Title: " + video._title);
                Console.WriteLine("Author: " + video._author);
                Console.WriteLine("Length: " + video._length + " seconds");
                Console.WriteLine("Number of Comments: " + video.GetCommentCount());
                Console.WriteLine("Comments:");

                foreach (var comment in video._comments) {
                    Console.WriteLine($"- {comment._commenter} : {comment._text}");
                }
                Console.WriteLine();
            }
            return;
        }  
    }
}