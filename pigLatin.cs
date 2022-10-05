using System;

public class pigLatinTranslator
{
    /*
English is translated to Pig Latin by taking the first letter of every word, 
moving it to the end of the word and adding ‘ay’. “The quick brown fox” becomes 
“Hetay uickqay rownbay oxfay”.
*/
    public static void Main(string[] args)
    {
        Console.WriteLine("Type in a sentence to convert from English to pigLatin and back:");
        string userInput = Console.ReadLine ();
        string [] wordArray = userInput.Split(' ');
        string pigLatin = "";
        string engTranslation = "";


        for(int i= 0; i< wordArray.Length; i++)
        {
            string word = wordArray[i];
            if (i == (wordArray.Length -1))
            {
                pigLatin += word.Substring(1) + word[0] + "ay.";
            }
            else
            {
                pigLatin += word.Substring(1) + word[0] + "ay ";
            }
        }

        string [] pigLatinArr = pigLatin.Split(' ');
        for(int i= 0; i < pigLatinArr.Length; i++)
        {
            string word = pigLatinArr[i];
            if (i == (pigLatinArr.Length -1))
            {
                newEnglish += word[word.Length -4] + word.Substring(0,word.Length -4 )  + ".";
            }
            else
            {
                newEnglish += word[word.Length -3] + word.Substring(0,word.Length -3) + " ";
            }
        }       
    Console.WriteLine($"{pigLatin}");
    Console.WriteLine($"{newEnglish}");  
    
    }
}