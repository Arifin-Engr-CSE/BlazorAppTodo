using BlazorAppTodo.AppContext;
using BlazorAppTodo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppTodo.GateWay
{
    public class TodoGateWay
    {
        AppDbContext db = new AppDbContext();
        public bool addTodo(Todo todo)
        {

            db.Todos.Add(todo);
            return db.SaveChanges() > 0;
        }

        public Todo getById(int id)
        {
            return db.Todos.FirstOrDefault(x => x.Id == id);
        }
        public bool updateTodo(Todo todo)
        {
            if (todo.Id == 0)
            {
                db.Todos.Update(todo);
            }

            return db.SaveChanges() > 0;
        }
        public List<Todo> getAll()
        {
            return db.Todos.ToList();
        }
    }
}
