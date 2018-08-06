using System;
using System.Collections.Generic;
using NEFGLibrary.Helper;
using NEFGLibrary.Investment.Interfaces;

namespace NEFGLibrary.Investment
{
  public class Projection : IProjection
  {
    public DateTime ProjectInceptionDate { get; set; }
    public int ProjectionTerm { get; set; }
    public DateTime ProjectionMaturityDate { get; set; }

    public List<ErrorResponse> CheckValidation()
    {
      return new List<ErrorResponse>();
    }
  }
}