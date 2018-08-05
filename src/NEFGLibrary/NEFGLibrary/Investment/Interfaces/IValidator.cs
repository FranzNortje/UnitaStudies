using System;
using System.Collections.Generic;
using System.Text;

namespace NEFGLibrary.Investment.Interfaces
{
    public interface IValidator
    {
        IEnumerable<ErrorResponse> CheckValidation();
    }
}
