using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6_assignment_template.Interfaces
{
    public interface IRoom
    {
        string Name { get; }
        string Description { get; }
        void Enter();
    }

}
