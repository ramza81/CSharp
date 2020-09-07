using System;
using TodoApp.Models;
using System.Collections.Generic;

namespace TodoApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITodoRepository _repository = new TodoRepositoryInMemory();

            List<Todo> todos = new List<Todo>();
            todos = _repository.GetAll();

            // 기본 데이터 출력
            foreach (var t in todos)
            {
                System.Console.WriteLine($"GetAll: {t.Id} - {t.Title} ({t.IsDone})");
            }

             // 데이터 입력
            Todo todo = new Todo { Title = "Database 학습", IsDone = true };
            _repository.Add(todo);

            // 다시 로드
            todos = _repository.GetAll();

            // 추가 데이터 출력
            foreach (var t in todos)
            {
                System.Console.WriteLine($"GetAll: {t.Id} - {t.Title}({t.IsDone})");
            }

            // 특정 데이터 출력
            todo = _repository.GetById(3);
             System.Console.WriteLine($"GetById: {todo.Id} - {todo.Title}({todo.IsDone})");

        }
    }
}
