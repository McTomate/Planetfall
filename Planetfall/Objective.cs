using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Planetfall
{
    class Objective
    {

        public string Name { get; set; }
        public string Details { get; set; }        
        [JsonIgnore] public Func<GameData, bool> Condition { get; set; }
        public bool Completed(GameData data) => Condition != null && Condition(data);


    }
}
