using System;
using System.Collections.Generic;
using System.Linq;

namespace JL_Intership_Day22_03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Press 1 for TASK_1");
                Console.WriteLine("Press 2 for TASK_2");
                var mainChoice = int.Parse(Console.ReadLine());
                switch (mainChoice)
                {

                    case 1:
                        var studentsList = new List<Menu.Student>();
                        while (true)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Menu.DisplayMenu();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nEnter your choice");
                            Console.ForegroundColor = ConsoleColor.White;
                            var userInput = int.Parse(Console.ReadLine());
                            switch (userInput)
                            {
                                case 1:
                                    var student = Menu.AddStudent();
                                    studentsList.Add(student);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter ID of the student");
                                    var index = int.Parse(Console.ReadLine());
                                    studentsList.RemoveAt(index - 1);
                                    break;
                                case 3:
                                    Console.WriteLine("Enter ID of the student");
                                    var indexStd = int.Parse(Console.ReadLine());
                                    var updatedStudent = Menu.UpdateStudent();
                                    studentsList.RemoveAt(indexStd - 1);
                                    studentsList.Insert(indexStd - 1, updatedStudent);
                                    break;
                                case 4:
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    foreach (var stud in studentsList)
                                    {
                                        Console.WriteLine(
                                            "\nID->       {0} \nName-> {1} \nQuizOne-> {2} \nQuizTwo-> {3} \nSex->   {4} \nMidScore {5} \nFinalScore {6} \nTotalScore {7} ",
                                            stud.Id, stud.Name, stud.QuizOne, stud.QuizTwo, stud.Sex, stud.MidTermScore,
                                            stud.FinalScore, stud.TotalScore);
                                    }
                                    break;
                                case 5:
                                    var averagePoint = studentsList.Average(x => x.FinalScore);
                                    Console.WriteLine("\n Average {0}", averagePoint);
                                    break;
                                case 6:
                                    var maxScore = studentsList.Max(g => g.TotalScore);
                                    var nameMaxScore = studentsList.Find(x => Math.Abs(x.TotalScore - maxScore) < 0.0001);
                                    Console.WriteLine(nameMaxScore.Name);
                                    break;
                                case 7:
                                    var minScore = studentsList.Min(x => x.TotalScore);
                                    var nameMinScore = studentsList.Find(x => Math.Abs(x.TotalScore - minScore) < 0.0001);
                                    Console.WriteLine(nameMinScore.Name);
                                    break;
                                case 8:
                                    Console.WriteLine("Enter ID of the student");
                                    var indexStudent = int.Parse(Console.ReadLine());
                                    var studentName = studentsList.Find(x => x.Id == indexStudent);
                                    Console.WriteLine(studentName.Name);
                                    break;

                                case 9:
                                    Console.WriteLine("Insert 1 for ASC Sort or 2 for DESC");
                                    var choice = int.Parse(Console.ReadLine());
                                    if (choice == 1)
                                    {
                                        studentsList = studentsList.OrderBy(x => x.MidTermScore).ToList();
                                        goto case 4;
                                    }
                                    studentsList = studentsList.OrderByDescending(y => y.MidTermScore).ToList();
                                    goto case 4;
                                    break;
                                default:
                                    Console.WriteLine("Wrong input");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        
                    case 2:
                        var workerList = new List<Worker>();
                        while (true)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Worker.ShowMenuWorker();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nEnter your choice");
                            Console.ForegroundColor = ConsoleColor.White;
                            var userInput1 = int.Parse(Console.ReadLine());

                            switch (userInput1)
                            {
                                case 1:
                                    var worker = Worker.InsertWorker();
                                    workerList.Add(worker);
                                    break;
                                case 2:
                                    workerList = workerList.OrderByDescending(x => x.AverageSalary()).ToList();
                                    foreach (var worker1 in workerList)
                                    {
                                        Console.WriteLine(
                                            "\nID->       {0} \nName-> {1} \nAverageSalary-> {2}",
                                            worker1.Id, worker1.Name, worker1.AverageSalary());
                                    }
                                    break;
                                case 3:
                                    var firstFiveList = workerList.Take(5);
                                    foreach (var worker2 in firstFiveList)
                                    {
                                        Console.WriteLine(
                                            "\nID->       {0} \nName-> {1} \nAverageSalary-> {2}",
                                            worker2.Id, worker2.Name, worker2.AverageSalary());
                                    }
                                    break;
                                case 4:
                                    var lastThreeList = workerList.Skip(Math.Max(0, workerList.Count() - 3));
                                    foreach (var worker3 in lastThreeList)
                                    {
                                        Console.WriteLine("\nID->   {0}", worker3.Id);
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Wrong Input");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                }
            }
        }
    }
}