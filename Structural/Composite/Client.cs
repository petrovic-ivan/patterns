using System;
using System.Collections.Generic;

namespace Structural.Comp
{
    public static class Client
    {
        public static void Run()
        {
            var leaf1 = new Component<string>("leaf1");
            var leaf2 = new Component<string>("leaf2");
            var leaf3 = new Component<string>("leaf3");
            var group1 = new Composite<string>("group1");
            group1.Add(leaf1);
            group1.Add(leaf2);
            group1.Add(leaf3);

            var leaf4 = new Component<string>("leaf4");
            var leaf5 = new Component<string>("leaf5");
            var group2 = new Composite<string>("group2");
            group2.Add(leaf4);
            group2.Add(leaf5);
            group2.Add(group1);

            var leaf6 = new Component<string>("leaf6");
            var leaf7 = new Component<string>("leaf7");
            var group3 = new Composite<string>("group3");
            group3.Add(leaf6);
            group3.Add(leaf7);
            group3.Add(group2);

            ((IIterator)group3).DisplayAll();
        }
    }
}