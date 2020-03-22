using Business.Logic.Errorhandler;
using Business.Logic.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Logic.NewFolder
{
    public class BusinessAction : BusinessActionErrors, IBusinessAction<string, string>
    {
        public bool HasErrors => HasError;

        public string Action(string input)
        {
           
            return input;
            
        }

        List<ValidationResult> IBusinessAction<string, string>.Errors()
        {
            return Errors; 
        }
    }
}
