using BlazorAppTodo.AppContext;
using BlazorAppTodo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppTodo.GateWay
{
    public class PersonGateWay
    {
        AppDbContext db = new AppDbContext();
        public bool addPerson(Person person)
        {
           
                db.Persons.Add(person);
            return db.SaveChanges() > 0;
        }

        public Person getById(int id)
        {
            return db.Persons.FirstOrDefault(x => x.Id == id);
        }
        public bool updatePerson(Person person)
        {
            if (person.Id==0)
            {
                db.Persons.Update(person);
            }
           
            return db.SaveChanges() > 0;
        }
        public List<Person> getPerson()
        {
            return db.Persons.ToList();
        }
    }
}
