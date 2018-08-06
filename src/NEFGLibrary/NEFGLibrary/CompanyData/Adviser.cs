using System.Collections.Generic;
using NEFGLibrary.Helper;
using NEFGLibrary.Investment.Interfaces;

namespace NEFGLibrary
{
  public class Adviser : IValidator
  {
    public int AdviserId { get; set; }
    public string AdviserName { get; set; }
    public string Email { get; set; }
    public Fsp FinancialServiceProvider { get; set; }

    public decimal InitialFinancialAdviserFee { get; set; }
    public decimal AnnualFinancialAdviserFee { get; set; }

    public List<ErrorResponse> CheckValidation()
    {
      var errors = new List<ErrorResponse>();
      if (AdviserId == 0) errors.Add(ErrorResponse.GetError(ErrorCode.AdviserNotQualified));
      if (string.IsNullOrEmpty(Email)) errors.Add(ErrorResponse.GetError(ErrorCode.AdviserEmail));
      if (string.IsNullOrEmpty(AdviserName)) errors.Add(ErrorResponse.GetError(ErrorCode.AdviserNotDefined));

      return errors;
    }
  }
}