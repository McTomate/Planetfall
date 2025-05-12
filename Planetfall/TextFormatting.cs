using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Planetfall
{
    //Formatting with help from GPT


    public static class TextFormatting
    {

        public static void FormattedText(List<(string Text, ConsoleColor? Color)> parts, int maxLength)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            var wordsWithColor = new List<(string Word, ConsoleColor? Color)>();

            // Step 1: Converting all words with their color into a list
            foreach (var part in parts)
            {
                var words = part.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    wordsWithColor.Add((word, part.Color));
                }
            }

            // Step 2: Print words line by line
            string currentLine = "";
            ConsoleColor? currentColor = null;

            foreach (var (word, color) in wordsWithColor)
            {
                // Calculate if the word fits in the current line
                if ((currentLine + word).Length + 1 > maxLength)
                {
                    Console.WriteLine(); // Wordwrap
                    currentLine = "";
                }

                // Set color only if it has changed
                if (color != currentColor)
                {
                    Console.ForegroundColor = color ?? defaultColor;
                    currentColor = color;
                }

                Console.Write(word + " ");
                currentLine += word + " ";
            }

            Console.WriteLine(); // End last line
            Console.ForegroundColor = defaultColor; // Reset color
        }
        public static void FormattedText(string text, int maxLength, ConsoleColor? color = null)
        {
            var parts = new List<(string Text, ConsoleColor? Color)>
    {
        (text, color)
    };

            FormattedText(parts, maxLength);
        }



    }

}
