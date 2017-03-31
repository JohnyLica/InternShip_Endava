using System;

namespace JL_Intership_Day22_03
{
    public class Menu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Statistical Analysis");
            Console.WriteLine();
            Console.WriteLine("1. Add student records");
            Console.WriteLine("2. Delete student records");
            Console.WriteLine("3. Update student records");
            Console.WriteLine("4. View all student records");
            Console.WriteLine("5. Calculate an average of a selected student`s scores");
            Console.WriteLine("6. Show student who gets the max total score");
            Console.WriteLine("7. Show student who gets the min total score");
            Console.WriteLine("8. Find student by ID");
            Console.WriteLine("9. Sort records ASC/DESC by scores");
        }

        public static Student AddStudent()
        {
            Console.WriteLine("Enter ID");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Sex");
            var sex = Console.ReadLine();
            Console.WriteLine("Enter Quiz One Score");
            var quizOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quiz Two Score");
            var quizTwo = int.Parse(Console.ReadLine());

            var student = new Student
            {
                Id = id,
                Name = name,
                Sex = sex,
                QuizOne = quizOne,
                QuizTwo = quizTwo
            };
            return student;
        }

        public static Student UpdateStudent()
        {
            Console.WriteLine("Enter new ID");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new Name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter new Sex");
            var sex = Console.ReadLine();
            Console.WriteLine("Enter new QuizOne Score");
            var quizOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new QuizTwo Score");
            var quizTwo = int.Parse(Console.ReadLine());

            var student = new Student
            {
                Id = id,
                Name = name,
                Sex = sex,
                QuizOne = quizOne,
                QuizTwo = quizTwo
            };
            return student;
        }

        public struct Student
        {
            private double _finalScore;
            private double _midTermScore;
            private double _totalScore;
            public int Id;
            public string Name;
            public int QuizOne;
            public int QuizTwo;
            public string Sex;

            public double MidTermScore
            {
                get { return _midTermScore = (QuizOne + QuizTwo)/2; }
            }

            public double FinalScore
            {
                get { return _finalScore = 0.5*QuizOne + 0.5*QuizTwo; }
            }

            public double TotalScore
            {
                get { return _totalScore = FinalScore + MidTermScore; }
            }
        }
    }
}