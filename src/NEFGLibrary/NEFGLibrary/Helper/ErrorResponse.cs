using System;
using System.Collections.Generic;
using System.Text;

namespace NEFGLibrary
{
    public class ErrorResponse
    {
        public string ErrorReason { get; set; }
        public ErrorCode ErrorCode { get; set; }

        public static ErrorResponse GetError(ErrorCode errorCode)
        {
            var newErrorResponse = new ErrorResponse()
            {
                ErrorCode = errorCode,
                ErrorReason = ErrorReasons.Get(errorCode)
            };
            return newErrorResponse;
        }

        public static ErrorResponse GetError(ErrorCode errorCode,params object[] parameters)
        {
            var newErrorResponse = new ErrorResponse()
            {
                ErrorCode = errorCode,
                ErrorReason = string.Format(ErrorReasons.Get(errorCode), parameters)
            };
            return newErrorResponse;
        }
    }

    public enum ErrorCode
    {
        AmountHastoBeMore = 1000,
        AdviserNotQualified = 1001,
        AdviserEmail = 1002,
        AdviserNotDefined = 1003
    }

    public class ErrorReasons
    {
        public const string AmountHasToBeMore = "{0} amount has to more than {1}";
        public const string AdviserNotQualified = "Adviser not qualified correctly.";
        public const string AdviserEmail = "Adviser email address not defined";
        public const string AdviserNotDefined = "Adviser name not defined";

        public static string Get(ErrorCode errorCode)
        {
            switch (errorCode)
            {
                case ErrorCode.AmountHastoBeMore:
                    return AmountHasToBeMore;
                case ErrorCode.AdviserNotQualified:
                    return AdviserNotQualified;
                case ErrorCode.AdviserEmail:
                    return AdviserEmail;
                case ErrorCode.AdviserNotDefined:
                    return AdviserNotDefined;
                default:
                    return "";
            }
        }
    }
}

