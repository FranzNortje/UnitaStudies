﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NEFGLibrary.CompanyData.Interfaces
{
    public interface IAuditableEntity
    {
        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}
