using NEFGLibrary.Investment.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NEFGLibrary
{
    public class Investor : IValidator
    {
        public title Title { get; set; }
        public string Initials { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public IEnumerable<ErrorResponse> CheckValidation()
        {
            var Errors = new List<ErrorResponse>();
            if (Title == null)
            {
                Errors.Add(new ErrorResponse() { ErrorReason = "Investor title not qualified correctly" });
            } 
            if (string.IsNullOrEmpty(Initials))
            {
                Errors.Add(new ErrorResponse() { ErrorReason = "Investor initials not defined" });
            }
            if (string.IsNullOrEmpty(LastName))
            {
                Errors.Add(new ErrorResponse() { ErrorReason = "Investor lastname not defined" });
            }
            //TODO : Date Of Birth Validation

            return Errors;
        }

    }

    public enum title
    {
        Unknown = 0,
        Mr,
        Mrs,
        Ms,
        Dr,
        Prof
        
    }




}
