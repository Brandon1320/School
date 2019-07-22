using MySql.Data.MySqlClient;

namespace ScholarSystem.Logic.Repository
{
    public abstract class Data<T>
    {
        protected MySqlConnection sqlConnection;

        protected Data() { }

        public abstract void Save(T item);
        public abstract T Retrieve(int id);
        public abstract T[] Retrieve();
        public abstract T[] Retrieve(params T[] items);
    }
}
