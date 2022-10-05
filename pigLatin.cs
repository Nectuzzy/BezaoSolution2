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
        int arrLength = wordArray.Length;

        for(int i = 0; i < arrLength;)
        {
            string word = wordArray[i];
            if (arrLength == 1)
            {
                pigLatin = word.Substring(1) + word.Substring(0,1) + "ay";
                i++;
            }
            else if(arrLength > 1)
            {
                pigLatin += word.Substring(1) + word.Substring(0,1) + "ay ";
                i++;
            }
        }


        
        string [] pigLatinArr = pigLatin.Split(' ');
        int pigLength = pigLatinArr.Length;
        
        for(int x = 0; x < pigLatinArr.Length;)
        {
            string pigWord = pigLatinArr[x];
            if (pigLength == 1)
            {
                engTranslation = pigWord[pigLength -3] + pigWord.Substring(0,pigLength -3 );
                x++;
            }
            else if(pigLength > 1)
            {
                engTranslation += pigWord[pigLength -2] + pigWord.Substring(0,pigLength -2) + " ";
                x++;
            }
        }       
    Console.WriteLine($"{pigLatin}");
    Console.WriteLine($"{engTranslation}");  
    
    }
}