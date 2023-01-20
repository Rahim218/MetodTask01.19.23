using System;

namespace MetodTask01._19._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Verilmiş string dəyərindəki ilk sözü tap
            Console.Write("Yazi daxil edin : ");
            string sentence = Console.ReadLine();
            var result = FirsLetter(sentence);
            Console.WriteLine($"Yazinin ilk sozu : {result}");
            #endregion

            #region Verilmiş string dəyərindəki sözlərin sayını tap
            Console.Write("Yazi daxil edin :  ");
            string sentence1 = Console.ReadLine();
            var result2 = CountLetter(sentence1);
            Console.WriteLine($"Yazidaki sozlerin sayi : {result2}");
            #endregion

            #region  Verilmiş ədədlər siyahısından içində yalnız müsbət ədədlər qalan yeni bir array düzəld
            int[] mixNumbers = { -54, 12, 75, -78, 10, -2, -89, 45, -12 };
            var result3 = PositiveNumbers(mixNumbers);
            Console.WriteLine("Musbet ededler : ");
            foreach (var number in result3)
            {
                Console.WriteLine(number);
            }
            #endregion

            #region Verilmis yazida reqem olub olmadigini tapan proqram
            Console.Write("Yazi daxil edin : ");
            string sentence3= Console.ReadLine();
            var result4 = HasNumber(sentence3);
            if (result4)
            {
                Console.WriteLine("Yazida reqem var");
            }
            else
            {
                Console.WriteLine("Yazida reqem yoxdur");
            }

            #endregion
            Console.WriteLine("------------------------------");

            #region Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran program
            string[] names = { "Meesi10", "CR7", "Neymar", "Sneijder", "Icardi9" };
            var result5 = WantedNumberInString(names);
            Console.WriteLine($"{result5} yazida reqem var");
            #endregion

            #region Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran program
            Console.WriteLine("Yazi daxil edin : ");
            string sentence6 = Console.ReadLine();
            var result6 = NoSpaceFirstLetterIndex(sentence6);
            Console.WriteLine($"Yazida ilk boslugu olmayan index : {result6}");

            #endregion

            #region Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran program
            Console.WriteLine("Yazi daxil edin : ");
            string sentence7 = Console.ReadLine();
            Console.WriteLine(WithoutSpaceInLeftWord(sentence7));
            #endregion

            #region  Verilmis yazi arrayinda verilmis sozun olub olmamasini yoxlayan program
            string[] words = { "Rehim", "Amil", "Azer", "Ferid", "Mamed" };
            Console.WriteLine("Axtarmaq istediyiniz yazini daxil edin : ");
            string word = Console.ReadLine();
            Console.WriteLine(FindStr(words, word));
            #endregion

            #region Verilmis reqemler listinde verilmis reqemin olub olmamasini yoxlayan
            int[] numbers1 = { 45, 78, -25, 14, -63, 52, -23 };
            Console.WriteLine("Axtarmaq istediyiniz reqemi daxil edin: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNumber(numbers1, number1));
            #endregion
            Console.WriteLine("---------------------------------------");

            #region Verilmis reqemler listindeki reqemlerin verilmis reqemler llistinde olub olmamasini yoxlayan
            int[] nums = { 45, 12, 85, 785, 45, 78, 10, -85 };
            int[] num = { 12, 45, -10 };
            Console.WriteLine(HasNumbers(nums,num));
            #endregion
            Console.WriteLine("-----------------------------------");

            #region Verilmis charin reqem olub olmadigini yoxlayan
            Console.WriteLine(HasChar('7'));
            #endregion

            #region Verilmis yazinin icinde verilmis charin hansi indexde oldugunu gosderen program
            Console.WriteLine(IndexNumber("Rehim" , 'm'));
            #endregion

            #region Verilmis yazida verilmis indekse qeder olan yazini yazdiran program
            Console.WriteLine(HalfWord("World" , 2));
            #endregion
        }

        // Verilmiş string dəyərindəki ilk sözü tapan metod (ilk söz ilk boşluğa qədərki ifadədir)
        static string FirsLetter(string word)
        {
            string newStr = "";
            for (int i = 0; i < word.Length; i++)
            {

                if (word[i] != ' ')
                {
                    newStr += word[i];
                }
                else
                {
                    break;
                }


            }
            return newStr;
        }

        // Verilmiş string dəyərindəki sözlərin sayını tapan metod 
        static int CountLetter(string sentence)
        {
            int count = 1;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        // Verilmiş ədədlər siyahısından içində yalnız müsbət ədədlər qalan yeni bir array düzəldən metod
        static int[] PositiveNumbers(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count++;
                }
            }
            int[] positiveArr = new int[count];
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveArr[counter] = arr[i];
                    counter++;
                }
            }
            return positiveArr;

        }

        // Verilmis yazida reqem olub olmadigini tapan metod
        static bool HasNumber(string str)
        {
           
            for (int i = 0; i < str.Length; i++)
            {
                if (HasChar(str[i]))
                {
                    return true;
                }

            }
            return false;

        }

        // Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
        static int WantedNumberInString(string[] str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (HasNumber(str[i]))
                {
                    count++;
                }
            }
            return count;
        }

        // Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod.
        static int NoSpaceFirstLetterIndex(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    return i;
                    break;
                }
            }
            return -1;

        }

        //Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
        static string WithoutSpaceInLeftWord(string str)
        {
            int count = 0;
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
                if (i >= count)
                {
                    newStr += str[i];
                }
            }
            return newStr;



        }

        // verilmis yaz arrayinda verilmis sozun olub olmamasini yoxlayan metod
        static bool FindStr(string[] str, string word)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (word == str[i])
                {
                    return true;
                }
            }
            return false;
        }

        //Verilmis reqemler listinde verilmis reqemin olub olmamasini yoxlayan metod
        static bool FindNumber(int[] arr, int wantedNumber)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == wantedNumber)
                {
                    return true;
                }
            }
            return false;
        }

        // Verilmis reqemler listindeki reqemlerin verilmis reqemler llistinde olub olmamasini yoxlayan metod 
        static bool HasNumbers(int[] arr, int[] arr2)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                if (FindNumber(arr2, arr[i]))
                {
                    return true;
                }

            }
            return false;
        }

        // Verilmis charin reqem olub olmadigini yoxlayan metod 
        static bool HasChar(char ch)
        {
            char[] cr = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            for (int i = 0; i < cr.Length; i++)
            {
                if (ch == cr[i])
                {
                    return true;
                }
            }
            return false;



        }

        // Verilmis yazinin icinde verilmis charin hansi indexde oldugunu gosderen metod
        static int IndexNumber(string str, char cr)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == cr)
                {
                    return i;
                }
            }
            return -1;
        }

        // Verilmis yazida verilmis indekse qeder olan yazini yazdiran metod
        static string HalfWord(string word, int number)
        {
            string str = "";
            for (int i = 0; i < number; i++)
            {
                str += word[i];
            }
            return str;

        }
    }
}