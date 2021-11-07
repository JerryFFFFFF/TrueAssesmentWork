using System;
using System.Collections.Generic;

namespace TrueAsseTask
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PadName = 20, Padcomm = 5;

            List<string> StudentsName = new List<string>() { "Amy Murry", "Ari Nikau", "Ben Mckay", "Claire McNaughton", "Harry Hamiton", "Liz Morrissey", "Rawiri Henry", "Sam Chen", "Taika Smith", "Tui Kahn" };
            List<int> StudentsGrade = new List<int>() { 8, 28, 17, 44, 109, 59, 78, 14, 97, 121 };
            string responce = "";

            //List of the StudentsName and StudentGrade 
            while (responce != "Q")
            {
                Menu();

                responce = Console.ReadLine().ToLower();
                string name;
                string Grade;
                bool pass = false;
                Console.Clear();

                // 25 – Certificate from the Dean, 50 – Green Spirit badge, 100 – Blue Spirit badge, 150 – Gold Spirit badge


                //adding students
                if (responce == "a")
                {

                    //while loop it helps try catch the error and can run mutiple times autometicily to help the user correct their mistakes and get the data to the list correctly.                  

                    while (pass != true)
                    {
                        //convenient for the users
                        try
                        {
                            Console.WriteLine("Please enter the name of the student");
                            name = Console.ReadLine();

                            Console.WriteLine("Please enter the Grade of this student");
                            int Grades = Convert.ToInt32(Console.ReadLine());



                            //Responces = name + Grade

                            Console.WriteLine($"The students you want to add is {name.PadRight(5)} {Grades}");
                            //PadRight is using for user can see 
                            StudentsName.Add(name);
                            StudentsGrade.Add(Grades);
                            Console.ReadKey();

                            pass = true;
                            Console.Clear();

                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("Ah oh it seems there's a mistake Σ( ° o °|||)\n");
                        }
                    }
                }


                //remove students from the list
                else if (responce == "b")
                {
                    while(pass!=true)
                    {
                        //convenient for the users
                        try
                        {
                            Console.WriteLine("Which student would you like to remove from the list?");
                            name = Console.ReadLine();
                            //store the index value that name is in the list
                            int indexOFName = StudentsName.IndexOf(name);
                            StudentsName.RemoveAt(indexOFName);
                            StudentsGrade.RemoveAt(indexOFName);
                            Console.WriteLine("The student has been deleted successfully (●’ω`●)");
                            pass = true;

                        }
                        catch
                        {
                            Console.WriteLine("Ah oh it seems there's a mistake Σ( ° o °|||)\n");
                        }
                    }
                }


                //List the Certificate from dean
                else if (responce == "c")

                {
                    Console.WriteLine($"Those are the students who got Certificate from Dean:");
                   

                    for (int i = 0; i < StudentsName.Count; i++)
                    {
                        if (StudentsGrade[i] >= 25)
                        {
                            Console.WriteLine(StudentsName[i] + " " + StudentsGrade[i]);

                        }

                    }
                }


                //List the Green Spirit badge
                else if (responce == "d")

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
                //List the blue Spirit badge
                else if (responce == "e")
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
                //List the Gold Spirit badge
                else if (responce == "f")
                {
                    Console.WriteLine("Those are the students who got Gold spirit badge");


                    for (int i = 0; i < StudentsName.Count; i++)
                    {
                        if (StudentsGrade[i] >= 150)
                        {
                            Console.WriteLine(StudentsName[i] + "" + StudentsGrade[i]);
                        }
                    }
                }
                //List all the student in the list
                else if (responce == "l")
                {
                    for (int i = 0; i < StudentsName.Count; i++)
                    {
                        Console.WriteLine(StudentsName[i].PadRight(PadName) + " " + StudentsGrade[i]);
                    }

                }
                //Search the excact Student user want
                else if (responce == "s")
                {
                    int index;
                    Console.WriteLine("Enter the name of the student you want to search");
                    Console.WriteLine("\r");

                    responce = Console.ReadLine();
                    index = StudentsName.IndexOf(responce);
                    Console.WriteLine($"This student's Grade is:{StudentsGrade[index]}");


                }
            }
            Console.WriteLine("Happy day"); 
        }

        private static void Menu()
        {
            Console.WriteLine("-------------------------------------------------------------");
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
            Console.WriteLine("--------------------------------------------------------------");
        }
    }

}
