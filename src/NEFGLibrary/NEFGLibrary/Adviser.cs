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
                Errors.Add( new ErrorResponse() { ErrorReason = "Adviser not qualified correctly" });
            }
            if (string.IsNullOrEmpty(Email))
            {
                Errors.Add(new ErrorResponse() { ErrorReason = "Adviser email address not defined" });
            }
            if (string.IsNullOrEmpty(AdviserName))
            {
                Errors.Add(new ErrorResponse() { ErrorReason = "Adviser name not defined" });
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
