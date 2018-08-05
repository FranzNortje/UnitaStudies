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
        AdviserNotDefined = 1003,
        TitleNotQualified = 1004,
        InitialsNotDefined = 1005,
        LastnameNotBlank = 1006,
        RequiresProductId = 1007,
        RequiresProductName = 1008,
        RequiresQuotationCode = 1009
    }

    public class ErrorReasons
    {
        public const string AmountHasToBeMore = "{0} amount has to more than {1}";
        public const string AdviserNotQualified = "Adviser not qualified correctly.";
        public const string AdviserEmail = "Adviser email address not defined";
        public const string AdviserNotDefined = "Adviser name not defined";
        public const string TitleNotQualified = "Investor title not qualified correctly";
        public const string InitialsNotDefined = "Investor initials not defined";
        public const string LastnameNotBlank = "Investor lastname not defined";
        public const string RequiresProductId = "Requires Product ID";
        public const string RequiresProductName = "Requires Product name";
        public const string RequiresQuotationCode = "Requires Product Quotation Code";

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
                case ErrorCode.TitleNotQualified:
                    return TitleNotQualified;
                case ErrorCode.InitialsNotDefined:
                    return InitialsNotDefined;
                case ErrorCode.LastnameNotBlank:
                    return LastnameNotBlank;
                case ErrorCode.RequiresProductId:
                    return RequiresProductId;
                case ErrorCode.RequiresProductName:
                    return RequiresProductName;
                case ErrorCode.RequiresQuotationCode:
                    return RequiresQuotationCode;
                default:
                    return "";
            }
        }
    }
}

