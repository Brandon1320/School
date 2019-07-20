using MySql.Data.MySqlClient;
using ScholarSystem.Logic.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScholarSystem.Logic.Repository
{
    public class SubjectRepository : Data<Subject>
    {
        private SubjectRepository() : base() { }

        public override Subject Retrieve(int id) => throw new NotImplementedException();
        public override Subject[] Retrieve() => throw new NotImplementedException();
        public override Subject[] Retrieve(params Subject[] items) => throw new NotImplementedException();
        public override void Save(Subject item) => throw new NotImplementedException();
    }
}
