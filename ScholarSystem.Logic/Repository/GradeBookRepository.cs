using MySql.Data.MySqlClient;
using ScholarSystem.Logic.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScholarSystem.Logic.Repository
{
    public class GradeBookRepository : Data<GradeBook>
    {
        private GradeBookRepository() { }

        public override GradeBook Retrieve(int id) => throw new NotImplementedException();
        public override GradeBook[] Retrieve() => throw new NotImplementedException();
        public override GradeBook[] Retrieve(params GradeBook[] items) => throw new NotImplementedException();
        public override void Save(GradeBook item) => throw new NotImplementedException();
    }
}
