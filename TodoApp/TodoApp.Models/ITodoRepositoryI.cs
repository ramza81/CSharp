using System.Collections.Generic;

namespace TodoApp.Models
{
    public interface ITodoRepository
    {
        void Add(Todo model);
        List<Todo> GetAll();

        Todo GetById(int Id);
    }

    // public class TodoRepositorySqlServer : ITodoRepository
    // {
    //     public void Add(Todo model)
    //     {

    //     }

    //     public List<Todo> GetAll()
    //     {
            
    //     }
    // }

}