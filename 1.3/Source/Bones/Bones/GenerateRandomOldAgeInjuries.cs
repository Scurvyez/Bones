using Verse;
using RimWorld;
using System.Collections.Generic;

namespace Bones
{
    public static class GenerateRandomOldAgeInjuries
    {
        public static void GenerateOldAgeInjuries(Pawn pawn, bool tryNotToKillPawn)
        {
            if (!pawn.kindDef.allowOldAgeInjuries)
                return;
        }
    }
}
