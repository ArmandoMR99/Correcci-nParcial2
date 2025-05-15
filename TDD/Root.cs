using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourTree
{
    public class Root : Node
    {
        private Node _child;

        public void SetChild(Node child)
        {
            if (_child != null)
                throw new InvalidOperationException("Root solo puede tener un hijo.");
            if (child is Root)
                throw new InvalidOperationException("Root no puede tener otro Root como hijo.");
            _child = child;
        }

        public override bool Execute()
        {
            return _child?.Execute() ?? false;
        }
    }
}
