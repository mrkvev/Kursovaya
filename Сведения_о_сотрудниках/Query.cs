using System;
using System.Data;
using System.Data.OleDb;

namespace Сведения_о_сотрудниках
{
    class Query
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Query(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }
        public void UpDate(int ID, string surname, string gender, DateTime date_of_birth, string department_name, string position, DateTime enrollment_date, decimal salary)
        {
            connection.Open();
            string s = @"UPDATE TBL_EMPLOYEE SET [Фамилия] = '" + surname + "', [Пол] = '" + gender + "', [Дата рождения] = " +
                " '" + date_of_birth.ToShortDateString() + "', [Название отдела] = '" + department_name + "', [Должность] = '" + position + "', [Дата поступления на работу] = '" + enrollment_date.ToShortDateString() + "', [Оклад] = " + salary + " WHERE [ID сотрудника] = " + ID;
            command = new OleDbCommand(s, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void UpDate(int ID, decimal salary)
        {
            connection.Open();
            string s = @"UPDATE TBL_EMPLOYEE SET [Оклад] = " + salary + " WHERE [ID сотрудника] = " + ID;
            command = new OleDbCommand(s, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable UpdateEmployee()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM TBL_EMPLOYEE", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }

        public void Add(int ID, string surname, string gender, DateTime date_of_birth, string department_name, string position, DateTime enrollment_date, decimal salary)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO TBL_EMPLOYEE VALUES (" + ID + ", '" + surname + "', '" + gender + "'," +
                " '" + date_of_birth.ToShortDateString() + "', '" + department_name + "', '" + position + "', " +
                "'" + enrollment_date.ToShortDateString() + "', " + salary + ")", connection);
            command.Parameters.AddWithValue("ID сотрудника", ID);
            command.Parameters.AddWithValue("Фамилия", surname);
            command.Parameters.AddWithValue("Пол", gender);
            command.Parameters.AddWithValue("Дата рождения", date_of_birth.ToShortDateString());
            command.Parameters.AddWithValue("Название отдела", department_name);
            command.Parameters.AddWithValue("Должность", position);
            command.Parameters.AddWithValue("Дата поступления на работу", enrollment_date.ToShortDateString());
            command.Parameters.AddWithValue("Оклад", salary);
            command.ExecuteNonQuery();
            connection.Close();      

        }

        public void Delete(int ID)
        {
            connection.Open();
            string s = "DELETE FROM TBL_EMPLOYEE WHERE [ID сотрудника] = " + ID;
            command = new OleDbCommand(s, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        
    }
}
