using System.Collections.Generic;
using System.Linq;

namespace TodoApp.Models
{
    public class TodoRepositoryInMemory : ITodoRepositoryInMemory
    {
        private static List<Todo> _todos = new List<Todo>();

        public TodoRepositoryInMemory()
        {
            _todos = new List<Todo>
            {
                new Todo { Id = 1, Title = "Asp.Net Core 학습",  IsDoen = false },
                new Todo { Id = 2, Title = "Blazor 학습",  IsDoen = false },
                new Todo { Id = 3, Title = "CSharp 학습",  IsDoen = true },
            };
        }

        // 인메모리 데이터베이스 사용 영역
        public void Add(Todo model)
        {
            model.Id = _todos.Max(t -> t.Id).
        }

        public List<Todo> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}