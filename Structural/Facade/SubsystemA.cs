using System;

namespace Facade
{
    public class SubsystemA : ISubsystemA
    {
        public string OperationA()
        {
            return "Executing operation A...";
        }
    }
}