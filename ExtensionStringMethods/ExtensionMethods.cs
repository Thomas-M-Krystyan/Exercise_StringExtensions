using System.Text;

namespace ExtensionStringMethods
{
    internal static class ExtensionMethods
    {
        // "Przykład Zdania Tekstowego"
        internal static string CapitalizeFirstLetters(this string message)
        {
            string[] splittedMessage = message.Split(' ');

            StringBuilder result = new StringBuilder();

            foreach (string word in splittedMessage)
            {
                string firstLetter = word[0].ToString().ToUpper();
                string otherLetters = word.Substring(1, word.Length - 1);

                result.Append(firstLetter + otherLetters + " ");
            }
            result.Remove(result.Length - 1, 1);  // Remove unnecessary whitespace after the last word

            return result.ToString();
        }


        // "PrZyKłAd zDaNiA TeKsToWeGo"
        internal static string CamelcaseEveryChar(this string message)
        {
            StringBuilder result = new StringBuilder();

            int counter = 0;
            foreach (char character in message)
            {
                result.Append(counter % 2 == 0 ? character.ToString().ToUpper() : character.ToString().ToLower());
                counter ++;
            }

            return result.ToString();
        }


        // "PrZyKłAd ZdAnIa TeKsToWeGo"
        internal static string CamelcaseEveryLetter(this string message)
        {
            string[] splittedMessage = message.Split(' ');

            StringBuilder result = new StringBuilder();
            
            foreach (string word in splittedMessage)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(i % 2 == 0 ? word[i].ToString().ToUpper() : word[i].ToString().ToLower());
                }
                result.Append(" ");
            }
            result.Remove(result.Length - 1, 1);  // Remove unnecessary whitespace after the last word

            return result.ToString();
        }
    }
}
