using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Math_Game
{   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Math Game! You will be asked 20 random math questions and given a final score at the end. Try to get all of the questions right!\n\nWould you like to proceed? [Y/N]: ");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                questionGen();
            }
            else
            {
                Console.WriteLine("Maybe another time then...");
            }
            Console.ReadLine();
        }

        public static void questionGen()
        {
            string filename = "Output.txt";
            StreamWriter writer = new StreamWriter(filename);

            Random numgen = new Random();

            int count = 0;
            int num = 0;
            

            string correct = "Congratulation! You got it right!\n";
            string wrong = "Incorrect! Please try again...\n";

            while (num < 20)
            {
                int c = numgen.Next(1, 5);      

                    if (1 <= c && c <= 4)
                    {


                        int a = numgen.Next(1, 100);
                        int b = numgen.Next(1, 100);


                        if (c == 1)
                        {
                            Console.Write($"What is {a} + {b}?: ");
                            writer.WriteLine($"What is {a} + {b}?: ");

                            int input2 = Convert.ToInt32(Console.ReadLine());
                            writer.WriteLine(input2);

                            if (input2 == (a + b))
                            {
                                Console.WriteLine(correct);
                                writer.WriteLine(correct);
                                ++count;
                            }
                            else
                            {
                                Console.WriteLine(wrong);
                                writer.WriteLine(wrong);
                            }
                        }
                        else if (c == 2)
                        {
                            Console.Write($"What is {a} x {b}?: ");
                            writer.WriteLine($"What is {a} x {b}?: ");

                            int input2 = Convert.ToInt32(Console.ReadLine());
                            writer.WriteLine(input2);

                            if (input2 == (a * b))
                            {
                                Console.WriteLine(correct);
                                writer.WriteLine(correct);
                                ++count;
                            }
                            else
                            {
                                Console.WriteLine(wrong);
                                writer.WriteLine(wrong);
                            }
                        }
                        else if (c == 3)
                        {
                            Console.Write($"What is {a} - {b}?: ");
                            writer.WriteLine($"What is {a} - {b}?: ");

                            int input2 = Convert.ToInt32(Console.ReadLine());
                            writer.WriteLine(input2);

                            if (input2 == (a - b))
                            {
                                Console.WriteLine(correct);
                                writer.WriteLine(correct);
                                ++count;
                            }
                            else
                            {
                                Console.WriteLine(wrong);
                                writer.WriteLine(wrong);
                            }
                        }
                        else if (c == 4)
                        {
                            Console.Write($"What is {a} / {b}?: ");
                            writer.WriteLine($"What is {a} / {b}?: ");

                            double input2 = Convert.ToDouble(Console.ReadLine());
                            writer.WriteLine(input2);

                            if (input2 == (Convert.ToDouble(a) / Convert.ToDouble(b)))
                            {
                                Console.WriteLine(correct);
                                writer.WriteLine(correct);
                                ++count;
                            }
                            else
                            {
                                Console.WriteLine(wrong);
                                writer.WriteLine(wrong);
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("The number you have entered is not between 1 and 4\n");
                        writer.WriteLine("The number you have entered is not between 1 and 4\n");
                    }
                
                
                ++num;

            }
            Console.WriteLine($"\nYou answered {count} questions correctly out of {num} total questions.");
            writer.WriteLine($"\nYou answered {count} questions correctly out of {num} total questions.");

            writer.Close();
        }


        
    }
}
