using DataAccess.Dtos;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.BusinessDataAccess.Interface
{
    public interface ITodoDataProvider
    {
        List<TodoDto> GetAllTodoItemsByDuration(DateTime from);
        bool AddTodo(TodoDto todo);
    } 
}
