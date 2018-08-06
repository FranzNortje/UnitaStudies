using System.Collections.Generic;
using NEFGLibrary.Helper;

namespace NEFGLibrary.Investment.Interfaces
{
  public interface IValidator
  {
    List<ErrorResponse> CheckValidation();
  }
}