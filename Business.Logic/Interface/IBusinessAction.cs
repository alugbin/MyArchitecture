using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Logic.Interface
{
  

    public interface IBusinessAction<TInput, TOutput>
    {
        TOutput Action(TInput input);
        List<ValidationResult> Errors();
        bool HasErrors { get; }


    }

    public interface IBusinessAction<TOutput>
    {
        TOutput Action();
    }
}
