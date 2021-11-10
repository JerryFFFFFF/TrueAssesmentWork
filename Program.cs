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
            int ChangeGrade;


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

                    {
                        //convenient for the users
                        try
                       // For handle the break from the error of the code
                        {
                            Console.WriteLine("Which student would you like to remove from the list?");
                            for (int i = 0; i < StudentsName.Count; i++)
                            {
                                Console.WriteLine(StudentsName[i].PadRight(PadName) + " " + StudentsGrade[i]);
                            }
                            name = Console.ReadLine();
                            //store the index value that name is in the list
                            int indexOFName = StudentsName.IndexOf(name);
                            StudentsName.RemoveAt(indexOFName);
                            StudentsGrade.RemoveAt(indexOFName);
                            Console.WriteLine("The student has been deleted successfully (●’ω`●)");
                            Console.ReadKey();
                            pass = true;


                        }
                        catch
                        //Link with the try and give callback to the error that user made 
                        {
                            Console.WriteLine("Ah oh it seems there's a mistake Σ( ° o °|||)\n");
                            Console.WriteLine("TIPS:You can check the list before you remove the student");


                        }
                    }
                }

                // 25 – Certificate from the Dean, 50 – Green Spirit badge, 100 – Blue Spirit badge, 150 – Gold Spirit badge

                //From c start using the method for the certificate
                else if (responce == "c")
                //List the Certificate from dean
               
                {
                    Console.Clear();
                    badge(StudentsName, StudentsGrade, 25, "Certificate from the Dean");
                    Console.ReadLine();
                }

               
                else if (responce == "d")
                //List the Green Spirit badge
                {
                    Console.Clear();
                    badge(StudentsName, StudentsGrade, 50, "Green Badge");
                    Console.ReadLine();
                   
                }
             
                
                else if (responce == "e")
                //List the blue Spirit badge
                {
                    Console.Clear();
                    badge(StudentsName, StudentsGrade,100,"Blue Badge");
                    Console.WriteLine("\n");  
                }
                
                
                else if (responce == "f")
                //List the Gold Spirit badge
                {
                    Console.Clear();
                    badge(StudentsName, StudentsGrade, 150, "Gold Badge");
                    Console.WriteLine("\n");
                }

                
                else if (responce == "l")
                //List all the student in the list
                {
                    for (int i = 0; i < StudentsName.Count; i++)
                    {
                        Console.WriteLine(StudentsName[i].PadRight(PadName) + " " + StudentsGrade[i]);
                    }

                }
                //Search the excact Student user want


                else if (responce == "s")
                    //For the users to search the grade of those students who is in the list
                {
                    try
                    {
                        int index;
                        Console.WriteLine("Enter the name of the student you want to search");
                        Console.WriteLine("\r");
                        responce = Console.ReadLine();
                        index = StudentsName.IndexOf(responce);
                        Console.WriteLine($"This student's Grade is:{StudentsGrade[index]}");
                    }
                    catch
                    {
                        Console.WriteLine("Oh sorry The student does not exist (>_<)");

                    }
                }

                if (responce == "r")
                    //For update the grade of those students who already in the list.
                {
               
                    
                      
                        try
                        {
                            for (int i = 0; i < StudentsName.Count; i++)
                            {
                                Console.WriteLine(StudentsName[i] + " " + StudentsGrade[i]+"\n");

                            }
                            Console.WriteLine("Which student's grade would you like to change?\n");
                            responce = Console.ReadLine();
                            int index = StudentsName.IndexOf(responce);
                           ////////////////////////////////////////////
                            StudentsName.Add(responce);
                            StudentsName.RemoveAt(index);
                            StudentsGrade.RemoveAt(index);
                            Console.WriteLine("What is the new grade for this student?\n");
                            ChangeGrade = Convert.ToInt32(Console.ReadLine());
                            StudentsGrade.Add(ChangeGrade);
                            

                        }
                        catch
                        {
                            Console.WriteLine("Ah oh it seems there's a mistake o(TヘTo)\n");
                            
                            
                        }
                    
                }
            }
            Console.WriteLine("Happy day"); 
        }
        private static void Menu()
        {
            Console.Clear();
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
            Console.WriteLine("\r");
            Console.WriteLine("Press R to renew one of the student's grade");
            Console.WriteLine("--------------------------------------------------------------");
        }


        static void badge(List<string> StudentName, List<int> Studentscommn, int standard, string award)
        {
            Console.WriteLine($"Those are the students who got {award} :\n");
            for (int i = 0; i < Studentscommn.Count; i++)
            {
                if (Studentscommn[i] >= standard)
                {
                    Console.WriteLine(Studentscommn[i] + " " + StudentName[i]);
                }
            }
            //method link with the else if options(spirit badges)

        }

    }

}

