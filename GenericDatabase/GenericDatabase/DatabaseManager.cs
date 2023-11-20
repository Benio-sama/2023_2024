using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDatabase
{
    internal class DatabaseManager<T>
    {
        private Dictionary<int, T> database = new Dictionary<int, T>();

        public Dictionary<int, T> Database { get => database; set => database = value; }

        public void AddRecord(T adat)
        {
            int id = GetRecordId(adat);
            if (!database.ContainsKey(id))
            {
                database.Add(id, adat);
                //Console.WriteLine(database[id]);
                Console.WriteLine("hozzaadva");
            }
            else
            {
                Console.WriteLine("adat ezzel az idvel mar letezik");
            }
        }
        public void RemoveRecord(int id)
        {
            if (database.ContainsKey(id))
            {
                database.Remove(id);
                Console.WriteLine("torolve");
            }
            else
            {
                Console.WriteLine("nincs ilyen adat az adatbazisban");
            }

        }
        public void GetRecord(int id)
        {
            if (database.ContainsKey(id))
            {
                Console.WriteLine(database[id]);
            }
            else
            {
                Console.WriteLine("nincs ilyen adat");
            }
        }
        public void PrintDatabase()
        {
            foreach (var item in database)
            {
                Console.WriteLine(GetRecordDetails(item));
            }
        }
        protected int GetRecordId(T adat)
        {
            var property = adat.GetType().GetProperty("Id");
            if (property != null)
            {
                return (int)property.GetValue(adat);
            }
            else
            {
                throw new InvalidOperationException("az adatnak kell lennie 'Id' propertyenek");
            }
        }
        protected string GetRecordDetails(KeyValuePair<int, T> adat)
        {
            return adat.ToString();
        }
    }
}
