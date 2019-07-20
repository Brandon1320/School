using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using ScholarSystem.Logic.Entity;

namespace ScholarSystem.Logic.Repository
{
    public class StudentRepository : Data<Student>
    {
        private StudentRepository() : base() { }

        public override Student Retrieve(int id) => throw new NotImplementedException();
        public override Student[] Retrieve() => throw new NotImplementedException();
        public override Student[] Retrieve(params Student[] items) => throw new NotImplementedException();
        public override void Save(Student item) => throw new NotImplementedException();
    }
}
