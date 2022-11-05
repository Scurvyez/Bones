using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HarmonyLib;
using RimWorld;
using Verse;

namespace Bones
{
    [HarmonyPatch(typeof(HealthUtility), "GetGeneralDestroyedPartLabel")]
    public static class Bones_GetGeneralDestroyedPartLabel_Postfix
    {
        [HarmonyPostfix]
        public static void GetHediffDefFromDamage(BodyPartRecord part, bool fresh, bool solid, ref string __result)
        {
            // unused atm
        }
    }
}
