using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab32LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {10, 2330, 112233, 10, 949, 3764, 2942 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            //Output For Nums Methods
            NumsItem1(nums);
            Console.WriteLine("");

            NumsItem2(nums);
            Console.WriteLine("");

            NumsItem3(nums);
            Console.WriteLine("");

            NumsItem4(nums);
            Console.WriteLine("");

            NumsItem5(nums);
            Console.WriteLine("");

            NumsItem6(nums);
            Console.WriteLine("");

            //Output for Student Methods
            StudentItem1(students);
            Console.WriteLine("");

            StudentItem2(students);
            Console.WriteLine("");

            StudentItem3(students);
            Console.WriteLine("");

            StudentItem4(students);
            Console.WriteLine("");

            StudentItem5(students);
            Console.WriteLine("");

            StudentItem6(students);
            Console.WriteLine("");

            StudentItem7(students);
            Console.WriteLine("");

        }

        //Nums Methods for Solutions to Each Item
        public static void NumsItem1(int[] nums)
        {
            var min = nums.Min();
            Console.WriteLine($"In the numbers array, the MINIMUM value is: {min}");
        }
        public static void NumsItem2(int[] nums)
        {
            var max = nums.Max();
            Console.WriteLine($"In the numbers array, the MAXIMUM value is: {max}");
        }
        public static void NumsItem3(int[] nums)
        {
            var max = nums.Where(x => x < 10000).Max();
            Console.WriteLine($"In the numbers array, the MAXIMUM value less than 10000 is: {max}");

        }
        public static void NumsItem4(int[] nums)
        {
            Console.WriteLine("In the numbers array, all of the values between 10 and 100 are: ");
            var vals = nums.Where(X => 
                            X > 10 
                            && X < 100);
            foreach(int num in vals)
            {
                Console.Write(num);
            }
        }
        public static void NumsItem5(int[] nums)
        {
            Console.WriteLine("In the numbers array, all of the values between 100000 and 999999 are: ");
            var vals = nums.Where(X =>
                X >= 100000
                && X <= 999999);
            foreach (int num in vals)
            {
                Console.WriteLine(num);
            }

        }
        public static void NumsItem6(int[] nums)
        {
            var allNums = nums.Count();
            var evens = nums.Count(x => x % 2 == 0);
            Console.WriteLine($"In the numbers array, there is a total count of {allNums} numbers and {evens} of them are even numbers.");
        }
        
        //Student Methods for Solutions to Each Item
        public static void StudentItem1(List<Student> students)
        {
            var canLegallyDrink = students.Where(x => x.Age >= 21);
            Console.WriteLine("In the students List, the names of students of age 21 or older are:");
            foreach(Student student in canLegallyDrink)
            {
                Console.WriteLine(student.Name);
            }
        }
        public static void StudentItem2(List<Student> students)
        {
            var oldestStudent = from student in students 
                                orderby student.Age descending 
                                select student;
            var output = oldestStudent.First().Name;
            Console.WriteLine($"In the students List, the name of the OLDEST student is: {output}");
        }

        public static void StudentItem3(List<Student> students)
        {
            var youngestStudent = from student in students 
                                  orderby student.Age 
                                  select student;
            var output = youngestStudent.First().Name;
            Console.WriteLine($"In the students List, the name of the YOUNGEST student is: {output}");
        }

        public static void StudentItem4(List<Student> students)
        {
            var oldestStudent = from student in students 
                                where student.Age < 25 
                                orderby student.Age descending 
                                select student;
            var output = oldestStudent.First().Name;
            Console.WriteLine($"In the students List, the oldest student under the age of 25 is: {output}");
        }

        public static void StudentItem5(List<Student> students)
        {
            var over21AndEven = from student in students
                                where student.Age > 21
                                && student.Age % 2 == 0
                                select student;
            Console.WriteLine($"In the students List, the students over 21 with even ages are:");
            foreach(Student s in over21AndEven)
            {
                Console.WriteLine(s.Name);
            }
        }

        public static void StudentItem6(List<Student> students)
        {
            var teenagers = from student in students
                                where student.Age <= 19
                                && student.Age >= 13
                                select student;
            Console.WriteLine($"In the students List, the teenage students are:");
            foreach(Student student in teenagers)
            {
                Console.WriteLine(student.Name);
            }
        }

        public static void StudentItem7(List<Student> students)
        {
            var namesStartingWithVowels = students.Where(x => "AEIOU".Contains(x.Name.Substring(0, 1)));
            Console.WriteLine($"In the students List, the students who have a name that begins with a vowel are: ");
            foreach(Student student in namesStartingWithVowels)
            {
                Console.WriteLine(student.Name);
            }
        }

    }
}
