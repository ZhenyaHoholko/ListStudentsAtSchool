namespace program
{
    public class School
    {
        public string Name;
        public List<Student> Students;
        public School( string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void PrintStudents()
        {
            if (Students.Count == 0) 
            { 
                Console.WriteLine($"В школе {Name} пока нет студентов"); 
            }
            else {
                Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, 5}", "Поз.", "Имя", "Фамилия", "Возраст");
                for (int i = 0; i < Students.Count; i++)
                {
                    Console.WriteLine("{0,-10} {1, -10} {2, -10} {3, 5}", i+1, Students[i].FirstName, Students[i].LastName, Students[i].Age);
                }
            }
        }

        public void AddNewStudent(Student student)
        {
            Students.Add(student);
            Console.WriteLine($"Студент {student.FirstName} успешно добавлен в школу {Name}.");
        }

        public void RemoveStudent(int removeNumberStudent)
        {
            Students.RemoveAt(removeNumberStudent-1);
        }
    }
}
