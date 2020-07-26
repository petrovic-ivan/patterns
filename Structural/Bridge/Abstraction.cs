using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Bridge
{
    internal class Abstraction : IAbstraction
    {
        private readonly IEnumerable<IBridge> _bridge;

        public Abstraction(IEnumerable<IBridge> bridge)
        {
            _bridge = bridge;
        }

        public void Operation(string operationType)
        {
            var implementtion = _bridge.Single(i => string.Equals(i.OperationType, "boat", StringComparison.CurrentCultureIgnoreCase));
            implementtion.Operation();
        }
    }
}