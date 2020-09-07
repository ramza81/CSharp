using System.Collections.Generic;

namespace TodoApp.Models
{
    public interface ITodoRepositoryInMemory
    {
        void Add(Todo model);
        List<Todo> GetAll();
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