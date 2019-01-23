using System;

namespace TD_console
{
    public class TD2
    {
        // Faites vos tests dans cette méthode
        public TD2()
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
            Writer("Alphabet_aZ", "none", "aBcDeFgHiJkLmNoPqRsTuVwXyZ", Alphabet_aZ());
            Writer("Position_az", "Je sUiS uN StrinG, S", "6", Position_az("Je sUiS uN StrinG", 'S').ToString());
            Writer("Replace_az", "Je sUiS uN StrinG, i", "Je sUS uN StrnG", Replace_az("Je sUiS uN StrinG", 'i'));
            Writer("River_max_sequence", "42, 100", "42 ; 48 ; 60 ; 66 ; 78 ; 93 ; 105.", River_max_sequence(42, 100));
            Writer("Conway_next", "1211", "111221", Conway_next("1211"));
            Writer("Conway_is_sequence", "1132121", "False", Conway_is_sequence("1132121").ToString());
            Writer("Conway_n_sequence", "7", "\n1\n11\n21\n1211\n111221\n312211\n13112221", "\n" + Conway_n_sequence(7));
            Writer("Conway_delimiter", "3, 5", "\n21\n1211\n111221", "\n" + Conway_delimiter(3, 5));
            Writer("Pyramide", "3", "\n  /*\\\n /***\\\n/*****\\", "\n" + Pyramide(3));
        }

        public static string Alphabet_aZ()
        {
            string alphabet = "";
            // Ne rien modifier au dessus de ce commentaire

            char c = 'a';
            byte i = 0;
            char add = 'a';
            while ((add != 'Z') && (c != 'Z'))
            {
                //Console.WriteLine(i + " 1: " + (add != 'Z'));
                //Console.WriteLine(i + " 2: " + (c != 'Z'));
                //Console.WriteLine(i + " 3: " + ((add != 'Z') && (c != 'Z')));
                if (i % 2 == 0)
                {
                    //Console.WriteLine("c: "+c);
                    alphabet += c;
                }
                else
                {
                    add = Convert.ToChar(c.ToString().ToUpper());
                    //Console.WriteLine("add: "+add);
                    alphabet += add;
                }
                c++;
                i++;
                //Console.WriteLine(i);

            }

            // Ne rien modifier au dessous de ce commentaire
            return alphabet;
        }

        public static int Position_az(string sentence, char search)
        {
            int position = 0;
            // Ne rien modifier au dessus de ce commentaire
            position = sentence.IndexOf(search);
            //Console.WriteLine("sentence :" + sentence);
            // Ne rien modifier au dessous de ce commentaire
            return position;
        }

        public static string Replace_az(string sentence, char search)
        {
            string newSentence = "";
            // Ne rien modifier au dessus de ce commentaire
            foreach (char c in sentence){

                if( c == search)
                {
                    //Console.WriteLine("c: " + c);
                int i = Position_az(sentence, search);
                    //Console.WriteLine("i: " + i);
                    //Console.WriteLine(sentence[i]);
                sentence = sentence.Remove(i,1);
                   
                }
                newSentence = sentence;
            }

            // Ne rien modifier au dessous de ce commentaire
            return newSentence;
        }

        public static string River_max_sequence(long river, long max)
        {
            string sequence = "";
            // Ne rien modifier au dessus de ce commentaire
            long newRiver = river;
            sequence = newRiver + " ; ";

            while (newRiver < max)
            {
                newRiver = TD1.River_next(newRiver);
                if( newRiver < max)
                {
                    sequence += newRiver + " ; ";
                }
                else
                {
                    sequence += newRiver + ".";

                }

            }
            // Ne rien modifier au dessous de ce commentaire
            return sequence;
        }

        public static string Conway_next(string start) // 1211
        {
            string conway = "";
            // Ne rien modifier au dessus de ce commentaire
            int indexMax = start.Length - 1;
            for(int i=0; i <= indexMax; i++) 
            {
                Console.WriteLine("c: " + start[i]);
               //Console.WriteLine("indexMax: " + indexMax);

                byte count = 1;
                if(i < indexMax)
                {
                    //Console.WriteLine("if: "+i);

                    int j = i;
                    while(j < indexMax)
                    {
                        Console.WriteLine("count: " + count);
                        //Console.WriteLine(start[j] + " " + start[j+1] + " "+ (start[j] == start[j + 1]));
                        if (start[j] == start[j + 1])
                        {
                            count++;
                            Console.WriteLine("countN: " + count);
                        }
                        j++;
                    }
                    Console.WriteLine(count + "" + start[i]);
                    conway += count + "" + start[i];
                                      
                }
                  else 
                {
                    //Console.WriteLine("else: " + i);
                }
            
            }
            // Ne rien modifier au dessous de ce commentaire
            return conway;
        }

        public static bool Conway_is_sequence(string conway)
        {
            bool isSequence = true;
            // Ne rien modifier au dessus de ce commentaire
            string x = "1";
            while (long.Parse(x) < long.Parse(conway))
            {
               x = Conway_next(x);
               
            }
            if (long.Parse(x) < long.Parse(conway) )
            {

                isSequence = false;
            }
            // Ne rien modifier au dessous de ce commentaire
            return isSequence;
        }

        public static string Conway_n_sequence(int n)
        {
            string sequences = "";
            // Ne rien modifier au dessus de ce commentaire

           
    
            // Ne rien modifier au dessous de ce commentaire
            return sequences;
        }

        public static string Conway_delimiter(int min, int max)
        {
            string sequences = "";
            // Ne rien modifier au dessus de ce commentaire


            {

            }
            // Ne rien modifier au dessous de ce commentaire
            return sequences;
        }

        public static string Pyramide(int height)
        {
            string pyramide = "";
            // Ne rien modifier au dessus de ce commentaire

            // Ne rien modifier au dessous de ce commentaire
            return pyramide;
        }
    }
}
