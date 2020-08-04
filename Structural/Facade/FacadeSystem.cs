using System;

namespace Facade
{
    public class FacadeSystem : IFacade
    {
        private readonly ISubsystemA _subsystemA;
        private readonly ISubsystemB _subsystemB;

        public FacadeSystem(ISubsystemA subsystemA, ISubsystemB subsystemB)
        {
            _subsystemA = subsystemA;
            _subsystemB = subsystemB;
        }

        public string ExecuteOperations()
        {
            var text = Environment.NewLine + "Operations started: " + Environment.NewLine;
            text += _subsystemA.OperationA() + Environment.NewLine;
            text += _subsystemB.OperationB() + Environment.NewLine;
            text += "Operation ended." + Environment.NewLine;
            return text;
        }
    }
}