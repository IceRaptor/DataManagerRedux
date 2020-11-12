using System.Collections.Generic;
using UnityEngine;

namespace DataManagerRedux
{

   

    public class ModConfig
    {
        public bool Debug = false;
        public bool Trace = false;

        public void LogConfig()
        {
            Mod.Log.Info?.Write("=== MOD CONFIG BEGIN ===");
            Mod.Log.Info?.Write($"  DEBUG: {this.Debug} Trace: {this.Trace}");
            Mod.Log.Info?.Write("=== MOD CONFIG END ===");
        }

        public void Init()
        {
        }
    }
}

