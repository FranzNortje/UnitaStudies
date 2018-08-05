using System;

namespace NEFGLibrary
{
    public interface IProjection
    {
        DateTime ProjectInceptionDate { get; set; }
        int ProjectionTerm { get; set; }
        DateTime ProjectionMaturityDate { get; set; }
    }

}
