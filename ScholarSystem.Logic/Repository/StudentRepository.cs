using MySql.Data.MySqlClient;
using ScholarSystem.Logic.Entity;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace ScholarSystem.Logic.Repository
{
    public class StudentRepository : Data<Student>
    {
        private StudentRepository() : base()
        {
            sqlConnection = new MySqlConnection("SqlConnection");
        }

        public override Student Retrieve(int id)
        {
            Student student = null;
            MySqlCommand sqlCommand = new MySqlCommand("SqlQuery");
            MySqlDataReader sqlDataReader;

            try
            {
                sqlConnection.Open();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.AddWithValue("param", param);
                sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    student = new Student(id,
                        sqlDataReader["firstName"].ToString(),
                        sqlDataReader["lastName"].ToString(),
                        (DateTime)sqlDataReader["birthdate"]);
                }
                sqlDataReader.Close();

                return student;
            }
            catch { throw; }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open ||
                    sqlConnection.State == ConnectionState.Broken)
                    sqlConnection.Close();
            }
        }

        public override Student[] Retrieve() => throw new NotImplementedException();
        public override Student[] Retrieve(params Student[] items) => throw new NotImplementedException();
        public override void Save(Student item) => throw new NotImplementedException();
    }
}
