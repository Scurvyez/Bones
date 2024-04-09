using HarmonyLib;
using Verse;
using System.Collections.Generic;

namespace Bones
{
    [HarmonyPatch(typeof(HealthUtility), "GetHediffDefFromDamage")]
    public static class Bones_GetHediffDefFromDamage_Patch
    {
        [HarmonyPostfix]
        public static void GetHediffDefFromDamage(DamageDef dam, Pawn pawn, BodyPartRecord part, ref HediffDef __result)
        {
            var injuryTypeList = new List<HediffDef>
            {
                Bones_HediffDefOf.SZ_Stable_Fracture,
                Bones_HediffDefOf.SZ_Compound_Fracture,
                Bones_HediffDefOf.SZ_Transverse_Fracture,
                Bones_HediffDefOf.SZ_Oblique_Fracture,
                Bones_HediffDefOf.SZ_Comminuted_Fracture,
                Bones_HediffDefOf.SZ_Greenstick_Fracture,
                Bones_HediffDefOf.SZ_Spiral_Fracture
            };

            if ((__result == HediffDef.Named("Crack")) && 
                (part.def.IsSolid(part, pawn.health.hediffSet.hediffs) && 
                (dam.hediffSolid != null)) &&
                (!pawn.RaceProps.FleshType.defName.Contains("Mechanoid")) &&
                (!part.body.defName.Contains("Body")) && 
                (!part.body.defName.Contains("SZ_Body")) &&
                (!part.def.label.Contains("body")))
            {
                __result = injuryTypeList.RandomElement();
            }
        }
    }
}
