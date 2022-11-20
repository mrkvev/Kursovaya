using System;

namespace Сведения_о_сотрудниках
{
    public class Employee
    {
        public int _ID;
        public string _surname;
        public string _gender;
        public string _department_name;
        public DateTime _date_of_birth;
        public DateTime _enrollment_date;
        public string _position;
        public decimal _salary;

        public Employee(int ID, string surname, string gender, DateTime date_of_birth,
            string department_name, string position, DateTime enrollment_date, decimal salary)
        {
            _ID = ID;
            _surname = surname;
            _gender = gender;
            _department_name = department_name;
            _date_of_birth = date_of_birth;
            _enrollment_date = enrollment_date;
            _position = position;
            _salary = salary;
        }
    }
}
