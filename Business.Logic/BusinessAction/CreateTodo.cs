using Business.Logic.Dto;
using Business.Logic.Errorhandler;
using Business.Logic.Interface;
using DataAccess.BusinessDataAccess;
using DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Logic.BusinessAction
{
    public class CreateTodo : BusinessActionErrors, IBusinessAction<CreateTodoDto, bool>
    {
        private readonly TodoDataProvider todoDataProvider;

        public CreateTodo(TodoDataProvider _todoDataProvider)
        {
            todoDataProvider = _todoDataProvider;
        }

        public bool HasErrors => throw new NotImplementedException();

        public bool Action(CreateTodoDto input)
        {
            if (input == null)
            {
                AddError("Invalid Todo");
                return false;
            }

            return todoDataProvider.AddTodo(new TodoDto { CreatedAt = input.CreatedAt, CompletedAt = input.CompletedAt, Title = input.Title }) ? true : false ;

        }

        List<ValidationResult> IBusinessAction<CreateTodoDto, bool>.Errors()
        {
            return Errors;
        }
    }
}
