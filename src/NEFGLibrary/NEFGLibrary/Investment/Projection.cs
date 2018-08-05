using System;

namespace NEFGLibrary
{
    public class Projection : IProjection
    {
        public DateTime ProjectInceptionDate { get; set; }
        public int ProjectionTerm { get; set; }
        public DateTime ProjectionMaturityDate { get; set; }
    }

}
