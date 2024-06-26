﻿using Verse;
using RimWorld;

namespace Bones
{
    [DefOf]
    public static class Bones_HediffDefOf
    {
        public static HediffDef SZ_Stable_Fracture;
        public static HediffDef SZ_Compound_Fracture;
        public static HediffDef SZ_Transverse_Fracture;
        public static HediffDef SZ_Oblique_Fracture;
        public static HediffDef SZ_Comminuted_Fracture;
        public static HediffDef SZ_Greenstick_Fracture;
        public static HediffDef SZ_Spiral_Fracture;
        
        static Bones_HediffDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(Bones_HediffDefOf));
        }
    }
}
