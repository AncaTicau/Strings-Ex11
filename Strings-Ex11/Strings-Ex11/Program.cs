using System;

namespace Strings_Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            string motivation = CleanUpString("Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks.@Hate ^me^ %now% and %thank% me &later.");
            Console.WriteLine(motivation);
        }

        /*You will get a text from where you will need to clean the text because it contains a lot of strange characters that don’t belong there(  <, > &+ @%$)
         * 
        ('^', '<', '>', '&', '+', '@', '%', '$')

        Input:
        ^Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks.@Hate ^me^ %now% and %thank% me &later.
            Output:
        Hi there I’m telling you, you need to do your homeworks.Hate me now and thank me later.*/


        public static string CleanUpString(string input)
        {
           string result = input.Replace("^", string.Empty);
            result = result.Replace(">", string.Empty);
            result = result.Replace("<", string.Empty);
            result = result.Replace("&", string.Empty);
            result = result.Replace("+", string.Empty);
            result = result.Replace("@", string.Empty);
            result = result.Replace("%", string.Empty);
            result = result.Replace("$", string.Empty);

            return result;
        }

    }
}
