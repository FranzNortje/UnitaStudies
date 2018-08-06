using System.Collections.Generic;
using NEFGLibrary.Helper;
using NEFGLibrary.Investment.Interfaces;

namespace NEFGLibrary
{
  public class Product : IValidator
  {
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string ProductQuotationCode { get; set; }

    public List<ProductArtifact> ProductArtifacts { get; set; }
    public List<QuoteInfo> ProductList { get; set; }

    public List<ErrorResponse> CheckValidation()
    {
      var errors = new List<ErrorResponse>();
      if (ProductId == 0) errors.Add(ErrorResponse.GetError(ErrorCode.RequiresProductId));
      if (string.IsNullOrEmpty(ProductName)) errors.Add(ErrorResponse.GetError(ErrorCode.RequiresProductName));
      if (string.IsNullOrEmpty(ProductQuotationCode))
        errors.Add(ErrorResponse.GetError(ErrorCode.RequiresQuotationCode));
      return errors;
    }
  }
}