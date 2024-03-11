using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrRpm5
{
    class Student
    {
        // Свойства для имени студента, номера комнаты и статуса оплаты
        public string Name { get; set; } // Имя студента
        public string RoomNumber { get; set; } // Номер комнаты
        public string PaymentStatus { get; set; } // Статус оплаты

        // Конструктор класса Student для инициализации объекта
        public Student(string name, string roomNumber, string paymentStatus = "Not Paid")
        {
            Name = name; // Инициализация имени
            RoomNumber = roomNumber; // Инициализация номера комнаты
            PaymentStatus = paymentStatus; // Инициализация статуса оплаты
        }

        // Метод для регистрации оплаты за проживание
        public void RegisterPayment()
        {
            PaymentStatus = "Paid"; // Установка статуса оплаты "Paid"
        }

        // Метод для изменения комнаты студента
        public void ChangeRoom(string newRoomNumber)
        {
            RoomNumber = newRoomNumber; // Изменение номера комнаты
        }

        // Метод для выселения студента
        public void EvictStudent()
        {
            RoomNumber = null; // Установка номера комнаты в null
            PaymentStatus = "Not Paid"; // Установка статуса оплаты "Not Paid"
        }

        // Метод для применения взысканий
        public void ApplyPenalty(string penaltyDescription)
        {
            // Здесь можно реализовать логику наложения взысканий или предупреждений
        }




    }
}
