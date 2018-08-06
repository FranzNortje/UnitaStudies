using System;

namespace NEFGLibrary.Investment.Interfaces
{
  public interface IProjection : IValidator
  {
    DateTime ProjectInceptionDate { get; set; }
    int ProjectionTerm { get; set; }
    DateTime ProjectionMaturityDate { get; set; }
  }
}