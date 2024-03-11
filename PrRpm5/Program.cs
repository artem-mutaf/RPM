using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrRpm5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            
                // Пример использования классов:

                // Создаем объекты студентов
                Student student1 = new Student("John", "101");
                Student student2 = new Student("Alice", "102");

                // Создаем общежитие
                Dorm dorm = new Dorm();

                // Заселяем студентов в общежитие
                dorm.CheckStudentIn(student1);
                dorm.CheckStudentIn(student2);

                // Регистрируем оплату за проживание
                student1.RegisterPayment();
                student2.RegisterPayment();

                // Меняем комнату студента
                student1.ChangeRoom("103");

                // Выселяем студента
                dorm.CheckStudentOut(student2);
            Console.ReadKey();
        }
    }
}
