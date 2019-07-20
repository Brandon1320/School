using ScholarSystem.Logic.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScholarSystem.Logic.Repository
{
    public class ProfessorRepository : Data<Professor>
    {
        public ProfessorRepository() : base() { }

        public override void Save(Professor item) => throw new NotImplementedException();
        public override Professor Retrieve(int id) => throw new NotImplementedException();
        public override Professor[] Retrieve() => throw new NotImplementedException();
        public override Professor[] Retrieve(params Professor[] items) => throw new NotImplementedException();
    }
}
