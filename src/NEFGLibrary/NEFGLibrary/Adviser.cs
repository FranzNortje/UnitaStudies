using NEFGLibrary.Investment.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NEFGLibrary
{
    public class Adviser : IValidator
    {
        public int AdviserId { get; set; }
        public string AdviserName { get; set; }
        public string Email { get; set; }
        public FSP FinancialServiceProvider { get; set; }

        public decimal InitialFinancialAdviserFee { get; set; }
        public decimal AnnualFinancialAdviserFee { get; set; }

        public IEnumerable<ErrorResponse> CheckValidation()
        {
            var Errors = new List<ErrorResponse>();
            if (AdviserId == 0) {
                Errors.Add(ErrorResponse.GetError(ErrorCode.AdviserNotQualified));
            }
            if (string.IsNullOrEmpty(Email))
            {
                Errors.Add(ErrorResponse.GetError(ErrorCode.AdviserEmail));
            }
            if (string.IsNullOrEmpty(AdviserName))
            {
                Errors.Add(ErrorResponse.GetError(ErrorCode.AdviserNotDefined));
            }
           
            return Errors;
        }
    }

    public class FSP
    {
        //Financial Service Provider
        public int FSPId { get; set; }
        public string ProviderName{ get; set; }
        public string OfficeNumber { get; set; }
        
    }
}
