using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            char[] tempString = input.ToArray();
            string bazarded = "";
            for (int i = 0; i < input.Length; i = i + 2)
            {
                bazarded += tempString[i];
            }
            for (int i = 1; i < input.Length; i = i + 2)
            {
                bazarded += tempString[i];
            }
            return bazarded;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null)
            {
                return true;
            }
            else if (input.Count(Char.IsWhiteSpace) == input.Length)
            {
                return true;
            }
            return false;
        }

        public static string MixString(string a, string b)
        {
            if (a == null || b == null || a.Length == 0 || b.Length == 0)
            {
                throw new ArgumentException();
            }

            for (int i = a.Length; i < b.Length; i++)
            {
                a += " ";
            }
            for (int i = b.Length; i < a.Length; i++)
            {
                b += " ";
            }

            char[] A = a.ToArray();
            char[] B = b.ToArray();
            string mixedString = "";

            for (int i = 0; i < A.Length && i < B.Length; i++)
            {
                if (!Char.IsWhiteSpace(A[i]))
                {
                    mixedString += (char)A[i];
                }
                if (!Char.IsWhiteSpace(B[i]))
                {
                    mixedString += (char)B[i];
                }
                Console.WriteLine(mixedString);
            }
            return mixedString;
        }

        public static string Reverse(string a)
        {
            char[] tempString = a.ToArray();
            string reversed = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                reversed += tempString[i];
            }
            return reversed;
        }

        public static string ToCesarCode(string input, int offset)
        {
            throw new NotImplementedException();
        }

        public static string ToLowerCase(string a)
        {
            char[] tempString = a.ToArray();
            string newA = "";
            for (int i = 0; i < tempString.Length; i++)
            {
                Console.WriteLine((int)tempString[i]);
                if (tempString[i] >= 65 && tempString[i] <= 90 || tempString[i] >= 192 && tempString[i] <= 207 || tempString[i] >= 209 && tempString[i] <= 221)
                {
                    newA += (char)(tempString[i] + 32);
                }
                else
                {
                    newA += (char)(tempString[i]);
                }
            }
            return newA;
        }

        public static string UnBazardString(string input)
        {
            //get each half of the string for easier processing
            string firstHalf = input.Substring(0, input.Length/2);
            string SecondHalf = input.Substring(input.Length/2, input.Length/2);

            //make sure both lengths are equal (impair lenght case)
            for (int i = firstHalf.Length; i < SecondHalf.Length; i++)
            {
                firstHalf += " ";
            }
            for (int i = SecondHalf.Length; i < firstHalf.Length; i++)
            {
                SecondHalf += " ";
            }

            char[] tempString = firstHalf.ToArray();
            char[] tempStringBis = SecondHalf.ToArray();
            string unbazarded = "";

            for(int i = 0; i < tempString.Length; i++)
            {
                unbazarded += tempString[i];
                unbazarded += tempStringBis[i];
            }
            return unbazarded;
        }

        public static string Voyelles(string a)
        {
            string result = "";

            Char[] Voyelle = new Char[] { 'A', 'I', 'U', 'E', 'O', 'Y', 'a', 'i', 'u', 'e', 'o', 'y' };
            foreach (char c in a)
            {
                if (Char.IsLetter(c))
                {
                    if (Voyelle.Contains(c) && !result.Contains(c))
                    {
                        result += c;
                    }
                }
            }
            return ToLowerCase(result);
        }
    }
}
