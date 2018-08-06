using System;
using System.Collections.Generic;
using NEFGLibrary.Helper;
using NEFGLibrary.Investment.Interfaces;

namespace NEFGLibrary
{
  public class Investor : IValidator
  {
    public Title Title { get; set; }
    public string Initials { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public List<ErrorResponse> CheckValidation()
    {
      var errors = new List<ErrorResponse>();
      if (Title == Title.Unknown) errors.Add(ErrorResponse.GetError(ErrorCode.TitleNotQualified));
      if (string.IsNullOrEmpty(Initials)) errors.Add(ErrorResponse.GetError(ErrorCode.InitialsNotDefined));
      if (string.IsNullOrEmpty(LastName)) errors.Add(ErrorResponse.GetError(ErrorCode.LastnameNotBlank));
      //TODO : Date Of Birth Validation

      return errors;
    }
  }

  public enum Title
  {
    Unknown = 0,
    Mr,
    Mrs,
    Ms,
    Dr,
    Prof
  }
}