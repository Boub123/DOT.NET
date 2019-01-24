using System;
using System.Collections.Generic;
/*
using System.Collections.Generic.ICollection<T>;
using System.Collections.Generic.IEnumerable<T>;
using System.Collections.Generic.IList<T>;
using System.Collections.Generic.IReadOnlyCollection<T>;
using System.Collections.Generic.IReadOnlyList<T>;
using System.Collections.IList;
*/


namespace TD_console
{
    public class TD4
    {
        // Faites vos tests dans cette méthode
        public TD4()
        {

        }

        // Ne pas modifier cette méthode
        public static void Writer(string methode, string param, string attendu, string resultat)
        {
            Console.WriteLine("Test " + methode + "(" + param + ");\n"
                              + "Résultat attendu : \"" + attendu + "\";\n"
                              + "Résultat : \"" + resultat + "\";\n"
                              + "Test : " + (string.Equals(attendu, resultat) ? "ok" : "echec") + "\n\n");
        }

        // Ne pas modifier cette méthode
        public static void Test()
        {
            Writer("River_unique", "100", "1 ; 3 ; 5 ; 7 ; 9 ; 20 ; 31 ; 42 ; 53 ; 64 ; 75 ; 86 ; 97.", River_unique(100));
            Writer("Encode_RL", "abcdefghijk", "ghijbcadefk", Encode_RL("abcdefghijk"));
            Writer("Decode_RL", "ghijbcadefk", "abcdefghijk", Decode_RL("ghijbcadefk"));
            Writer("Fibonacci_is_sequence", "9", "False", Fibonacci_is_sequence(9).ToString());
            Writer("Fibonacci_previous", "8", "5", Fibonacci_previous(8).ToString());
            Writer("Fibonacci_next", "8", "13", Fibonacci_next(8).ToString());
            Writer("Fibonacci_max_sequence", "20", "0 ; 1 ; 1 ; 2 ; 3 ; 5 ; 8 ; 13 ; 21.", Fibonacci_max_sequence(20));
            Writer("Fibonacci_n_sequence", "5", "0 ; 1 ; 1 ; 2 ; 3.", Fibonacci_n_sequence(5));
            Writer("Fibonacci_delimiter", "3, 6", "1 ; 2 ; 3 ; 5.", Fibonacci_delimiter(3, 6));
            Writer("Conway_previous", "111221", "1211", Conway_previous("111221"));
            Writer("Syracuse_is_sequence", "34, 18", "False", Syracuse_is_sequence(34, 18).ToString());
            Writer("Syracuse_previous", "22", "7 ; 44.", Syracuse_previous(22));
            Writer("Syracuse_next", "42", "21", Syracuse_next(42).ToString());
            Writer("Syracuse_sequence", "20", "20 ; 10 ; 5 ; 16 ; 8 ; 4 ; 2 ; 1.", Syracuse_sequence(20));
            Writer("Syracuse_n_sequence", "14, 5", "14 ; 7 ; 22 ; 11 ; 34.", Syracuse_n_sequence(14, 5));
            Writer("Syracuse_delimiter", "14, 3, 6", "22 ; 11 ; 34 ; 17.", Syracuse_delimiter(14, 3, 6));
            Writer("Morse_to_morse", "a", ". _", Morse_to_morse('a'));
            Writer("Morse_to_char", ". _", "a", Morse_to_char(". _").ToString());
            Writer("Morse_encode", "Hello World !", ". . . .   .   . _ . .   . _ . .   _ _ _ / . _ _   _ _ _   . _ .   . _ . .   _ . . / _ _ _ .", Morse_encode("Hello World !"));
            Writer("Morse_decode", ". . . .   .   . _ . .   . _ . .   _ _ _ / . _ _   _ _ _   . _ .   . _ . .   _ . . / _ _ _ .", "Hello World !", Morse_decode(". . . .   .   . _ . .   . _ . .   _ _ _ / . _ _   _ _ _   . _ .   . _ . .   _ . . / _ _ _ ."));
        }

        public static string River_unique(long max)
        {
            string sequences = "";
            // Ne rien modifier au dessus de ce commentaire

            string  river100 = TD2.River_max_sequence(1, 100);
            Console.WriteLine(river100);
            // Ne rien modifier au dessous de ce commentaire
            return sequences;
        }

        public static string Encode_RL(string sentence)
        {
            string newSentence = "";
            // Ne rien modifier au dessus de ce commentaire

            int maxIndex = sentence.Length - 1;
            int length = 0;

            for (int startIndex = 0; startIndex <= maxIndex; startIndex++)
            {

                //Console.WriteLine("startIndex = " + startIndex);
                //Console.WriteLine("length = " + length);
                //Console.WriteLine("maxIndex = " + maxIndex);

                if (startIndex + length - 1 < maxIndex)
                {
                    if (length % 2 == 0)
                    {
                        newSentence = sentence.Substring(startIndex, length) + newSentence;
                    }
                    else
                    {
                        newSentence += sentence.Substring(startIndex, length);
                    }
                }
                else
                {
                   int newLength = maxIndex - startIndex + 1;
                    //Console.WriteLine("newLength " + newLength);

                    //Console.WriteLine(sentence.Substring(startIndex, newLength));
                    if (length % 2 == 0)
                    {
                        newSentence = sentence.Substring(startIndex, newLength) + newSentence;
                    }
                    else
                    {
                        newSentence += sentence.Substring(startIndex, newLength);
                    }
                }

                startIndex += length - 1;
                length++;
            }


            // Ne rien modifier au dessous de ce commentaire
            return newSentence;
        }

        public static string Decode_RL(string sentence)
        {
            string newSentence = "";
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return newSentence;
        }


        public static List<int> ArrayFibonacci_max_sequence(long max)
        {
           
            List<int> sequence = new List<int>();
            sequence.Add(0);
            sequence.Add(1);
            // sequence = [0,1];
            
             // Ne rien modifier au dessus de ce commentaire
             int i = 1;
             int push = 0;
             while(push <= max)
             {
                 push = sequence[i - 1] + sequence[i];
                 sequence.Add(push);
                 i++;
             }

            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }

        public static bool equal(long a, long b)
        {
            Console.WriteLine("a: "+a+" b: "+b);
            bool x = (a == b);
            Console.WriteLine("x: "+x);
            return x;
        }



        public static bool Fibonacci_is_sequence(long sequence)
        {
            bool isSequence = true;
            // Ne rien modifier au dessus de ce commentaire
            List<int> arrayFibonaci = ArrayFibonacci_max_sequence(sequence);
            
            if (arrayFibonaci.Find(e => e == sequence) == sequence) isSequence = true;
            else isSequence = false;

            // Console.WriteLine("test: " + arrayFibonaci.Find(e => equal(e, sequence)));

            /* foreach (int e in arrayFibonaci)
             {
                 if (e != sequence)
                 {
                     isSequence = false;
                 }
                 else
                 {
                     isSequence = true;
                     break;
                 }
                 Console.WriteLine("e: " + e + " sequence: " + sequence + "test: " + (e == sequence));
             }
             */


            // Ne rien modifier au dessous de ce commentaire
            return isSequence;
        }


            public static long Fibonacci_previous(long n)
        {
            long fibonacci = 0;
            // Ne rien modifier au dessus de ce commentaire
            List<int> arrayFibonaci = ArrayFibonacci_max_sequence(n);

            int i = arrayFibonaci.FindIndex(e => e == n);
            fibonacci = arrayFibonaci[i - 1];

            //Console.WriteLine(arrayFibonaci[i-1]);

            // Ne rien modifier au dessous de ce commentaire
            return fibonacci;
        }

        public static long Fibonacci_next(long n)
        {
            long fibonacci = 0;
            // Ne rien modifier au dessus de ce commentaire
            List<int> arrayFibonaci = ArrayFibonacci_max_sequence(n);

            int i = arrayFibonaci.FindIndex(e => e == n);
            fibonacci = arrayFibonaci[i + 1];
            // Ne rien modifier au dessous de ce commentaire
            return fibonacci;
        }

        public static string Fibonacci_max_sequence(long max)
        {
            string sequence = "";
            // Ne rien modifier au dessus de ce commentaire
            List<int> arrayFibonaci = ArrayFibonacci_max_sequence(max);
            //Console.WriteLine("length: " + arrayFibonaci.Count);
            int i = 0;
            foreach (int e in arrayFibonaci)
            {
                //Console.WriteLine("i: " + i);
                if (i == 0) sequence += e + " ;";
                else if (i == arrayFibonaci.Count-1) sequence +=" " + e + ".";
                else sequence += " " + e + " ;";

                i++;
                
            }
            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }

        public static string Fibonacci_n_sequence(int n)
        {
            string sequence = "";
            // Ne rien modifier au dessus de ce commentaire
            int prev = 0;
            int push = 0;
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("i: "+i);
                if (i == 0)
                {

                    sequence += push + " ;";
                    temp = prev;
                    prev = push;  
                    push += 1;
                }
                else if (i < n-1)
                {
                    //Console.WriteLine("prev: " + prev + " push: " + push);                  
                    sequence += " " + push + " ;";
                    temp = prev;
                    prev = push;
                    push += temp;
                }

                else
                {
                    sequence += " " + push + ".";
                }  
            }
            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }

        public static string Fibonacci_delimiter(int min, int max)
        {
            string sequence = "";
            // Ne rien modifier au dessus de ce commentaire
            List<int> arrayFibonaci = ArrayFibonacci_max_sequence(max);
            //arrayFibonaci.ForEach(Console.WriteLine);
            int i = 1;
            foreach (int e in arrayFibonaci)
            {
                //Console.WriteLine(" min: " + min + " i: "+ i + " max : " + max +" "+ (min <= i && i <= max) + " e: " + e);

                if (min <= i  && i <= max)
                {
                    if (i == min) sequence += e + " ;";
                    else if (i == arrayFibonaci.Count - 1) sequence += " " + e + ".";
                    else sequence += " " + e + " ;";
                }

                i++;
            }
            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }

        public static string Conway_previous(string start)
        {
            string conway = "";
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return conway;
        }

        public static bool Syracuse_is_sequence(long syracuse, long sequence)
        {
            bool isSequence = true;
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return isSequence;
        }

        public static string Syracuse_previous(long n)
        {
            string syracuses = "";
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return syracuses;
        }

        public static long Syracuse_next(long n)
        {
            long syracuse = 0;
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return syracuse;
        }

        public static string Syracuse_sequence(long syracuse)
        {
            string sequence = "";
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }

        public static string Syracuse_n_sequence(long syracuse, int n)
        {
            string sequence = "";
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }

        public static string Syracuse_delimiter(long syracuse, int min, int max)
        {
            string sequence = "";
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }

        public static string Morse_to_morse(char c)
        {
            string morse = "";
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return morse;
        }

        public static char Morse_to_char(string morse)
        {
            char c = '\0';
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return c;
        }

        public static string Morse_encode(string sentence)
        {
            string newSentence = "";
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return newSentence;
        }

        public static string Morse_decode(string sentence)
        {
            string newSentence = "";
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return newSentence;
        }
    }
}
