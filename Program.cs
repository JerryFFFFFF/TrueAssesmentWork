using System;
using System.Collections.Generic;

namespace TrueAsseTask
{
    class Program
    {
        static void Main(string[] args)

        {
            const int PadName = 15, Padcomm = 5;
            //now only for make distance between names and grades

            List<string> StudentsName = new List<string>() { "Amy Murry", "Ari Nikau", "Ben Mckay", "Claire McNaughton", "Harry Hamiton", "Liz Morrissey", "Rawiri Henry", "Sam Chen", "Taika Smith", "Tui Kahn" };
            //This list is useing for store and change the student's name, the position is using number in order for example"0,1,2,3,4..." to link with the Grade list
            List<int> StudentsGrade = new List<int>() { 8, 28, 17, 44, 109, 59, 78, 14, 97, 121 };
            //Link with name list
            string response = "";
            int ChangeGrade;


            //List of the StudentsName and StudentGrade 
            while (response != "q")
            {
                Menu();

                response = Console.ReadLine().ToLower();
                //ToLower helped the capital letter into lower word and that makes me do not need to write "response= CAPITAL" everytime
                string name;
                string Grade;
                bool pass = false;
                Console.Clear();
                // 25 – Certificate from the Dean, 50 – Green Spirit badge, 100 – Blue Spirit badge, 150 – Gold Spirit badge


                //adding students
                if (response == "a")
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
                else if (response == "b")
                {
                    Console.Clear();
                    {
                        while (pass != true)
                                //convenient for the users
                            try
                                // For handle the break from the error of the code

                            {
                                   
                                    Console.WriteLine("Which student would you like to remove from the list?");
                                    studentlist(StudentsName, StudentsGrade);
                                //using the second method to show the list.
                                    name = Console.ReadLine();
                                    //store the index value that name is in the list
                                    int indexOFName = StudentsName.IndexOf(name);
                                    StudentsName.RemoveAt(indexOFName);
                                    StudentsGrade.RemoveAt(indexOFName);
                                //help to remove the student
                                    Console.WriteLine("The student has been deleted successfully (∩_∩)");
                                    Console.ReadKey();
                                    pass = true;
                                
                            }
                          catch
                               //Link with the try and give callback to the error that user made 
                            {
                               Console.WriteLine("Ah oh it seems there's a mistake Σ( ° o °|||)\n");
                               Console.WriteLine("TIPS:You can check the list before you remove the student\n");
                            }
                    }
                }

                // 25 – Certificate from the Dean, 50 – Green Spirit badge, 100 – Blue Spirit badge, 150 – Gold Spirit badge

                //From c start using the method for the certificate
                else if (response == "c")
                //List the Certificate from dean
               
                {
                    Console.Clear();
                    badge(StudentsName, StudentsGrade, 25, "Certificate from the Dean");
                    Console.ReadLine();
                }

               
                else if (response == "d")
                //List the Green Spirit badge
                //methodn no.1
                {
                    Console.Clear();
                    badge(StudentsName, StudentsGrade, 50, "Green Badge");
                    Console.ReadLine();
                   
                }
             
                
                else if (response == "e")
                //List the blue Spirit badge
                //methodn no.1
                {
                    Console.Clear();
                    badge(StudentsName, StudentsGrade,100,"Blue Badge");
                    Console.ReadLine();
                     
                }
                
                
                else if (response == "f")
                //List the Gold Spirit badge
                //methodn no.1
                {
                    Console.Clear();
                    badge(StudentsName, StudentsGrade, 150, "Gold Badge");
                    Console.ReadLine();

                }

                else if (response == "l")
                //List all the student in the list
                //methodn no.2
                {
                    Console.Clear();
                    studentlist(StudentsName, StudentsGrade);
                    Console.ReadLine();

                }
                //
                
                //Search the excact Student user want
                else if (response == "s")
                    //For the users to search the grade of those students who is in the list
                {
                    try
                    {

                        int index;
                        Console.WriteLine("Enter the name of the student you want to search(Be careful with the capital!)");
                        Console.WriteLine("\r");
                        response = Console.ReadLine();
                        index = StudentsName.IndexOf(response);
                        Console.WriteLine($"This student's Grade is:{StudentsGrade[index]}");
                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("Oh sorry The student does not exist (>_<)");

                    }
                }
               
                

                if (response == "r")
                    //For update the grade of those students who already in the list.
                {
                    while(pass!=true)
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Which student's grade would you like to change?\n");
                            studentlist(StudentsName, StudentsGrade);  
                            response = Console.ReadLine();
                            int index = StudentsName.IndexOf(response);
                           ////////////////////////////////////////////
                            StudentsName.Add(response);
                            StudentsName.RemoveAt(index);
                            StudentsGrade.RemoveAt(index);
                           //for update the student's grade: remove first than enter the new one
                            Console.WriteLine("What is the new grade for this student?\n");
                            ChangeGrade = Convert.ToInt32(Console.ReadLine());
                            StudentsGrade.Add(ChangeGrade);
                            Console.WriteLine("The Grade of the student has been changed succefully!");
                            Console.ReadLine();
                            pass = true;
                        }
                        catch
                        {
                            Console.WriteLine("Ah oh it seems there's a mistake o(TヘTo)\n");
                        }
                    
                }

            }
            Console.WriteLine("Have a Happy day"); 
        }
        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------");
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





        //Method No.1"Badge"
        static void badge(List<string> StudentName, List<int> Studentscommn, int standard, string award)
            //First methos: The static void is calling with the code in for loop and makes it working.
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
           
            
            //Method No.2"List"
            static void studentlist(List<string> NameStudent,List<int>GradeStudent)
            {
               
                for (int i = 0; i < NameStudent.Count; i++)
                {
                     Console.WriteLine(NameStudent[i]+" " + GradeStudent[i]);
                }
              
            //Methods for using the list out the name of students

            }
        

    }

}
//Every single option has been trying to use the best compounds 


                