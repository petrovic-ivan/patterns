using System;

namespace Facade
{
    public class SubsystemB : ISubsystemB
    {
        public string OperationB()
        {
            return "Executing operation B...";
        }
    }
}