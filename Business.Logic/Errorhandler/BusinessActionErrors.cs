using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Business.Logic.Errorhandler
{
    public abstract class BusinessActionErrors
    {
        private readonly List<ValidationResult> _errors;

        public List<ValidationResult> Errors { get; }

        public bool HasError => _errors.Any();

        public void AddError(string errorMessage) => _errors.Add(new ValidationResult(errorMessage));

    }
}
