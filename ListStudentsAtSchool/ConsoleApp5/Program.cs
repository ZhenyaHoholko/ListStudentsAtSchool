using program;
using System;
using System.Collections.Generic;

namespace program
{

    class Program
    {
        static bool Answer()
        {
            string userAnswer = Console.ReadLine().ToLower();
            if (userAnswer == "yes" || userAnswer == "да" || userAnswer == "da")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Здравстуйте! Введите имя школы:");
            string schoolName = Console.ReadLine();
            School school = new School(schoolName);
            Console.WriteLine($"Школа {school.Name} успешно создана!");

            while (true)
            {
                Console.WriteLine($"Хотите посмотреть список всех учеников школы {school.Name}? Введите да или нет!");
                if (Answer())
                {
                    school.PrintStudents();
                }
                Console.WriteLine($"Хотите добавить нового студента в школу {school.Name}?");
                if(Answer())
                {
                    Console.WriteLine("Введите имя студента.");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Введите фамилию студента.");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Введите возраст студента.");
                    int age;
                    while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
                    {
                        Console.WriteLine("Введите корректное число для возраста.");
                    }

                    Student student = new Student(firstName, lastName, age);
                    school.AddNewStudent(student);
                }
                Console.WriteLine("Хотите удалить студента из списка? Введите да или нет!");
                if (Answer())
                {
                    while (true)
                    {
                        Console.WriteLine("Введите номер студента, которго хотите удалить из списка.");
                        string removeNumberStudent = Console.ReadLine();
                        if (int.TryParse(removeNumberStudent, out int number) && (number != 0 && number <= school.Students.Count))
                        {
                            var studentToRemove = school.Students[number - 1].FirstName;
                            school.RemoveStudent(number);
                            Console.WriteLine($"Студент {studentToRemove} удалён из списка студентов школы {school.Name}.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Введите корректный номер студента.");
                        }
                    }
                }

            }
        }
    }
}
