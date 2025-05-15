using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourTree
{
    public class ParTask : Task
    {
        private int _number;

        public ParTask(int number)
        {
            _number = number;
        }

        public override bool Execute()
        {
            return _number % 2 == 0;
        }
    }
}
