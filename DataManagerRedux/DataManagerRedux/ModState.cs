
using BattleTech;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DataManagerRedux
{
    public static class ModState
    {


        public static void Reset()
        {
            // Reinitialize state
            Mod.Log.Info?.Write("CLEARING ALL MOD STATE DATA");

        }
    }

}


