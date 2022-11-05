using HarmonyLib;
using Verse;
using System.Collections.Generic;

namespace Bones
{
    [HarmonyPatch(typeof(HealthUtility), "GetHediffDefFromDamage")]
    public static class Bones_GetHediffDefFromDamage_Postfix
    {
        [HarmonyPostfix]
        public static void GetHediffDefFromDamage(DamageDef dam, Pawn pawn, BodyPartRecord part, ref HediffDef __result)
        {
            var injuryList = new List<HediffDef> { 
                HediffDef.Named("SZ_Stable_Fracture"), 
                HediffDef.Named("SZ_Compound_Fracture"), 
                HediffDef.Named("SZ_Transverse_Fracture"), 
                HediffDef.Named("SZ_Oblique_Fracture"), 
                HediffDef.Named("SZ_Comminuted_Fracture") };

            if ((__result == HediffDef.Named("Crack")) && 
                (part.def.IsSolid(part, pawn.health.hediffSet.hediffs) && 
                (dam.hediffSolid != null)) &&
                (!pawn.RaceProps.FleshType.defName.Contains("Mechanoid")) &&
                (!part.body.defName.Contains("Body")) && 
                (!part.body.defName.Contains("SZ_Body")) &&
                (!part.def.label.Contains("body")))
            {
                __result = injuryList.RandomElement();
            }
        }
    }
}
