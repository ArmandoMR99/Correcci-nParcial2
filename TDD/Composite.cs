using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourTree
{
    public abstract class Composite : Node
    {
        protected List<Node> children = new List<Node>();

        public void AddChild(Node node)
        {
            if (node is Root)
                throw new InvalidOperationException("Composite no puede tener Root como hijo.");
            children.Add(node);
        }
    }
}
