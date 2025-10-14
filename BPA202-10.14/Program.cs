////Stringin Trim methodunu custom yazin, bize verilen deyerdeki evveldeki ve sondaki bosluqlari silin


//string word = "----Salam   Hamiya-----";
//char trimChar = '-';

//Console.WriteLine(word.Trim('-'));



////for (int i = 0; i < word.Length; i++)
////{
////    if (word[i]!=' ')
////        Console.Write(word[i]);
////}

//int startIndex = 0;//4
//int endIndex = word.Length - 1;//12

//for (int i = 0; i < word.Length; i++)
//{
//    if (word[i] != trimChar)
//    {
//        startIndex = i;
//        break;
//    }
//}


//for (int i = word.Length - 1; i >= startIndex; i--)
//{
//    if (word[i] != trimChar)
//    {
//        endIndex = i;
//        break;
//    }
//}

//string newWord = "";
//for (int i = startIndex; i <= endIndex; i++)
//{
//    newWord += word[i];
//}


//Console.WriteLine(newWord);



//Stringin split methodunu custom yazin, bize bir string verilir ve bu stringi hansi simvola
//gore bolmeliyem o verilir yekunda mene array qayidir mes: “Hello World !” ⇒‘ ’⇒[”Hello”,”World”,”!”]


//string sentence = "   Salam21312#!#@!#@ World !";
//char splitChar = ' ';
//string[] words = [];

//string firstWord = "";
//int firstIndex = 0;
//int lastIndex = 0;

//for (int i = 0; i < sentence.Length; i++)
//{
//    if (sentence[i] != splitChar)
//    {
//        firstIndex = i;
//        break;
//    }
//}

//for (int i = firstIndex; i < sentence.Length; i++)
//{
//    if (sentence[i] == splitChar)
//    {
//        lastIndex = i - 1;
//        break;
//    }
//}

//for (int i = firstIndex; i <= lastIndex; i++)
//{
//    firstWord += sentence[i];
//}

//Array.Resize(ref words, words.Length + 1);
//words[^1] = firstWord;

//Console.WriteLine(words[0]);



string sentence = "   Salam21312#!#@!#@ World !     213321321  213  ";
char splitChar = ' ';
string[] words = [];
int firstIndex = 0;
int lastIndex = 0;

while (lastIndex<sentence.Length)
{
    string word = "";

    for (int i = firstIndex; i < sentence.Length; i++)
    {
        if (sentence[i] != splitChar)
        {
            firstIndex = i;
            break;
        }
    }

    for (int i = firstIndex; i < sentence.Length; i++)
    {
        if (sentence[i] == splitChar)
        {
            lastIndex = i - 1;
            break;
        }
        else if (sentence.Length - 1 == i)
        {
            lastIndex = i;
            break;
        }
    }

    for (int i = firstIndex; i <= lastIndex; i++)
    {
        word += sentence[i];
    }

        if (word.Length > 0)
        {
            Array.Resize(ref words, words.Length + 1);
            words[^1] = word;
        }
        else
        {
            break;
        }
  
  
    firstIndex = lastIndex + 1;
}


Console.WriteLine(words.Length);
