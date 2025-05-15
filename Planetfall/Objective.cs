using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Planetfall
{
    class Objective
    {

        public string Name { get; set; }
        public string Details { get; set; }
        public Func<GameData, bool> Condition { get; set; }
        public bool Completed(GameData data) => Condition != null && Condition(data);

       
    }
}
