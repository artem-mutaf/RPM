using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrRpm5
{
    class Dorm
    {
        private List<Student> students; // Приватное поле для хранения списка студентов

        // Конструктор класса Dormitory для инициализации объекта
        public Dorm()
        {
            students = new List<Student>(); // Создание нового списка студентов
        }

        // Метод для заселения студента в общежитие
        public void CheckStudentIn(Student student)
        {
            students.Add(student); // Добавление студента в список
        }

        // Метод для выселения студента из общежития
        public void CheckStudentOut(Student student)
        {
            if (students.Contains(student)) // Проверка, содержится ли студент в списке
            {
                students.Remove(student); // Удаление студента из списка
                student.EvictStudent(); // Выселение студента
            }
            else
            {
                Console.WriteLine("Student not found in the dormitory."); // Вывод сообщения об ошибке
            }
        }
    }
}
