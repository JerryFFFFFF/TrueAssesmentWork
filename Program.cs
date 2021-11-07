using System;
using System.Collections.Generic;

namespace TrueAsseTask
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> StudentsName = new List<string>() { "Amy Murry", "Ari Nikau", "Ben Mckay", "Claire McNaughton", "Harry Hamiton", "Liz Morrissey", "Rawiri Henry", "Sam Chen", "Taika Smith", "Tui Kahn" };
            List<int> StudentsGrade = new List<int>() { 8, 28, 17, 44, 109, 59, 78, 14, 97, 121 };
            string responce = "";



            //List of the StudentsName and StudentGrade 
            while (responce != "Q")
            {
                Console.WriteLine("\r");
                Console.WriteLine("Please enter");
                Console.WriteLine("\r");
                Console.WriteLine("Press A to enter a new stduent data to the system");
                Console.WriteLine("\r");
                Console.WriteLine("Press B to delete" + " a student data from the system");
                Console.WriteLine("\r");
                Console.WriteLine("Press C to list the student who got the Certificate from the Dean");
                Console.WriteLine("\r");
                Console.WriteLine("Press D to list the student who got the Green Spirit badge");
                Console.WriteLine("\r");
                Console.WriteLine("Press E to list the students who got the Blue Spirit badge");
                Console.WriteLine("\r");
                Console.WriteLine("Press F to list the students who got the Gold Spirit badge");
                Console.WriteLine("\r");
                Console.WriteLine("Press L to list all the students");
                Console.WriteLine("\r");
                Console.WriteLine("Press S to search the student you want");


                responce = Console.ReadLine();
                string name;
                Console.Clear();

                // 25 – Certificate from the Dean, 50 – Green Spirit badge, 100 – Blue Spirit badge, 150 – Gold Spirit badge

                if (responce == "A" || responce == "a")

                    //convenient for the users
                    try
                    {
                        Console.WriteLine("Please enter the name of the student");
                        name = Console.ReadLine();
                        Console.WriteLine("Please enter the Grade of this student");
                        int Grades = Convert.ToInt32(Console.ReadLine());
                        //Responces = name + Grade
                        StudentsName.Add(name);
                        StudentsGrade.Add(Grades);
                        Console.WriteLine("The students you want to add is" + "\n" + name + "\n" + Grades);
                        Console.Clear();
                        //working well
                    }
                    catch
                    {
                        Console.WriteLine("Ah oh it seems there's a mistake Σ( ° o °|||)\n");
                    }

                    finally
                    {
                        Console.WriteLine("Sorry please enter the data again\n");
                        Console.WriteLine("Please enter the name of the student");
                        name = Console.ReadLine();
                        Console.WriteLine("Please enter the Grade of this student");
                        int Grades = Convert.ToInt32(Console.ReadLine());
                        //Responces = name + Grade
                        StudentsName.Add(name);
                        StudentsGrade.Add(Grades);
                        Console.WriteLine("The students you want to add is" + "\n" + name + "\n" + Grades);
                        //working well
                    }



                else if (responce == "B" || responce == "b")

                {
                    Console.WriteLine("Which student would you like to delete?");
                    name = Console.ReadLine();
                    //Store the index value that name is in the list
                    int indexOfName = StudentsName.IndexOf(name);

                    //responce
                    StudentsName.RemoveAt(indexOfName);
                    StudentsGrade.RemoveAt(indexOfName);
                }


                else if (responce == "C" || responce == "c")

                {
                    Console.WriteLine("Those are the students who got Certificate from Dean:");
                    Console.WriteLine("\r\n");

                    for (int i = 0; i < StudentsName.Count; i++)
                    {
                        if (StudentsGrade[i] >= 25)
                        {
                            Console.WriteLine(StudentsName[i] + " " + StudentsGrade[i]);

                        }

                    }
                }



                else if (responce == "D" || responce == "d")

                {
                    Console.WriteLine("Those are the students who got green spirit badge:");
                    Console.WriteLine("\r\n");

                    for (int i = 0; i < StudentsName.Count; i++)
                    {
                        if (StudentsGrade[i] >= 50)
                        {
                            Console.WriteLine(StudentsName[i] + " " + StudentsGrade[i]);

                        }

                    }
                }

                else if (responce == "E" || responce == "e")
                {
                    Console.WriteLine("Those are the students who got Blue Spirit Badge");
                    Console.WriteLine("\r");

                    for (int i = 0; i < StudentsName.Count; i++)
                    {
                        if (StudentsGrade[i] >= 100)
                        {
                            Console.WriteLine(StudentsName[i] + "" + StudentsGrade[i]);
                        }
                    }
                }

                else if (responce == "F" || responce == "f")
                {
                    Console.WriteLine("Those are the students who got Gold spirit badge");
                    Console.WriteLine("\r");

                    for (int i = 0; i < StudentsName.Count; i++)
                    {
                        if (StudentsGrade[i] >= 150)
                        {
                            Console.WriteLine(StudentsName[i] + "" + StudentsGrade[i]);
                        }
                    }
                }

                else if (responce == "S" || responce == "s")
                {
                    Console.WriteLine("Enter the name of the student you want to search");
                    Console.WriteLine("\r");


                }


                else if (responce == "L" || responce == "l")
                {
                    for (int i = 0; i < StudentsName.Count; i++)
                    {
                        Console.WriteLine(StudentsName[i] + " " + StudentsGrade[i]);
                    }

                }
            }
            Console.WriteLine("Happy day");
        }
    }

}