using System;
using System.Linq;

namespace Dublin_CSharp_9_Exos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Accueil :\n"
                                + "1) Exercise 1 : Q1()\n"
                                + "2) Exercise 2 : Q2()\n"
                                + "3) Exercise 3 : Q3()\n"
                                + "4) Exercise 4 : Q4()\n"
                                + "5) Exercise 5 : Q5()\n"
                                + "6) Exercise 6 : Q6()\n"
                                + "7) Exercise 7 : Q7()\n"
                                + "8) Exercise 8 : Q8()\n"
                                + "9) Exercise 9 : Q9()\n"

                                + "\n"
                                + "Choose a Exercise");
            string exo = Console.ReadLine();
            switch (exo)
            {
                case "1":
                    Q1();
                    break;
                case "2":
                    Q2();
                    break;
                case "3":
                    Q3();
                    break;
                case "4":
                    Q4();
                    break;
                case "5":
                    Q5();
                    break;
                case "6":
                    Q6();
                    break;
                case "7":
                    Q7();
                    break;
                case "8":
                    Q8();
                    break;
                case "9":
                    Q9();
                    break;
            }

            Console.Read();
        }

        #region Q1
        static void Q1() //Inverser 1er et Dernier charactère d'un mot
        {
            Console.WriteLine("Choose un mot");
            string mot = Console.ReadLine();
            char stock = mot[mot.Length - 1];
            string result = stock + mot.Substring(1, mot.Length - 2) + mot[0];
            Console.WriteLine(result);
        }
        #endregion
        #region Q2
        static bool Q2() // Vérifier qu'une suite de chiffre existe dans la suite
        {
            bool result = false;
            Console.WriteLine("Size of the array ?"); //array = tableau 
            int firstarray = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Size of the sequence ?");
            int firstsequence = Convert.ToInt32(Console.ReadLine());

            if (firstsequence > firstarray || firstarray == 0 || firstsequence == 0) result = false;
            else
            {
                int[] array = new int[firstarray];
                int[] sequence = new int[firstsequence];
                int cmpt = 0;
                Console.WriteLine("\nEnter some values");
                for (int i = 0; i < firstarray; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("");
                for (int i = 0; i < firstarray; i++)
                {
                    Console.Write(array[i] + " ");
                }

                Console.WriteLine("\nEnter some values");
                for (int i = 0; i < firstsequence; i++)
                {
                    sequence[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("");
                for (int i = 0; i < firstsequence; i++)
                {
                    Console.Write(sequence[i] + " ");
                }

                for (int i = 0; i < firstarray - firstsequence; i++)
                {
                    for (int j = 0; j < firstsequence; j++)
                    {
                        if (array[i + j] == sequence[j])
                        {
                            result = true;
                            cmpt++;
                        }
                        else
                        {
                            result = false;
                            cmpt = 0;
                        }
                        if (cmpt != firstsequence && result == true) result = false;

                    }
                }
            }
            Console.WriteLine(result);
            return result;
        }
        #endregion
        #region ASCII_Q3
        static int Ascii_Q3(char chrtr)
        {
            int result = 0;
            result = Convert.ToInt32(chrtr);
            return result;
        }
        #endregion
        #region Q3

        static char[] Q3()
        {
            Console.WriteLine("What is the size of the array ? ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            char[] array = new char[sizeArray];


            Console.WriteLine("What are the values of your array ? ");
            for (int i = 0; i < sizeArray; i++)
            {
                array[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("");
            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write(array[i] + " ");
            }
            char stck;
            for (int j = 0; j < sizeArray; j++)
            {
                for (int i = 0; i < sizeArray - 1 - j; i++)
                {
                    if (Ascii_Q3(array[i]) < Ascii_Q3(array[i + 1]))
                    {
                        stck = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = stck;
                    }
                }

            }
            Console.WriteLine("");
            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
            return array;
        }
        #endregion
        #region Q4
        static string Q4()
        {
            Console.WriteLine("Give your string");
            string word = Console.ReadLine();
            string result = Convert.ToString(word[0]);
            int cmpt = 1;
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i + 1] == word[i])
                {
                    cmpt++;
                }
                else
                {
                    result += Convert.ToString(cmpt);
                    cmpt = 1;
                    result += Convert.ToString(word[i + 1]);
                }

            }
            result += Convert.ToString(cmpt);
            Console.WriteLine(result);
            return result;
        }
        #endregion
        #region Q5
        static void Q5()
        {
            for (int i = 0; i < 1000; i++)
            {
                int sum = 0;
                string stck = Convert.ToString(i);
                for (int j = 0; j < stck.Length; j++)
                {
                    sum += (int)Math.Pow(Convert.ToInt32(stck[j]) - 48, 3);
                }
                if (sum == i)
                {
                    Console.WriteLine(i + " is an Armstrong number");
                }
            }
        }
        #endregion
        #region Q6
        static void Q6()
        {
            Console.WriteLine("Choose the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            char[] array = new char[size];
            Console.WriteLine("Enter values");
            for (int l = 0; l < size; l++)
            {
                array[l] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("");

            for (int l = 0; l < size; l++)
            {
                Console.Write(array[l]);
            }
            string control = Convert.ToString(array[0]);
            int total;
            bool present = false;

            total = array.Count(c => c == array[0]);
            Console.WriteLine("There are {0} times {1} in the array", total, array[0]);

            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < control.Length; j++)
                {
                    if (array[i] == control[j]) present = true;
                }
                if (present) i++;
                else
                {
                    total = array.Count(c => c == array[i]);
                    Console.WriteLine("There are {0} times {1} in the array", total, array[i]);
                    control += array[i];
                }
                present = false;
            }
            Console.WriteLine("");
        }
        #endregion
        #region Q7
        static void Q7()
        {
            Console.WriteLine("What is your number ?");
            int number = Convert.ToInt32(Console.ReadLine());
            int total = 1;
            for (int i = number; i >= 1; i--)
            {
                total *= i;
            }
            Console.WriteLine(total);
        }

        #endregion
        #region Q8
        static void Q8()
        {
            Console.WriteLine("Choose a sentence");
            string sentence = Console.ReadLine();
            int total;
            total = sentence.Count(c => c.Equals(' '));
            Console.WriteLine("There are {0} blanks in the sentence", total);
        }
        #endregion
        #region Q9
        static void Q9()
        {
            Person[] array = new Person[3];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Choose a name");
                array[i] = new Person(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString());
            }
        }
        #endregion
    }
}
