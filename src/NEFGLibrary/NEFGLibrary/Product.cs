using NEFGLibrary.Investment.Interfaces;
using System;
using System.Collections.Generic;

namespace NEFGLibrary
{
    public class Product : IValidator
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductQuotationCode { get; set; }

        public List<ProductArtifact> ProductArtifacts { get; set; }                
        public List<QuoteInfo> ProductList { get; set; }

        public IEnumerable<ErrorResponse> CheckValidation()
        {
            var errors = new List<ErrorResponse>();
            if (ProductId == 0)
            {
                errors.Add(new ErrorResponse() { ErrorReason = "Requires Product ID" });                
            }
            if (string.IsNullOrEmpty(ProductName))
            {
                errors.Add(new ErrorResponse() { ErrorReason = "Requires Product name" });
            }
            if (string.IsNullOrEmpty(ProductQuotationCode))
            {
                errors.Add(new ErrorResponse() { ErrorReason = "Requires Product Quotation Code" });
            }
            return errors;
        }
    }

    public class ProductArtifact
    {
        public ProductArtifactType ArtifactType { get; set; }
        public string ArtifactPath { get;set;}
        public string FileName { get; set; }
        public bool Enabled { get; set; }
        public int Version { get; set; }
        public DateTime CreationDate { get; set; }
    }

    //Types : Brochure, ProductPDf, quote info...
    public class ProductArtifactType
    {
        public int ArtifactType { get; set; }
        public string ArtifactDescription { get; set; }
    }

    public class QuoteInfo
    {
        public int QuoteInfoId { get; set; }
        public string QuoteString { get; set; }

    }

    
}
