using System.Collections.Generic;
using System.Linq;
using Verse;
using RimWorld;

namespace Bones
{
    public class ThoughtWorker_MissingLegBone : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn pawn)
        {
            IEnumerable<BodyPartRecord> partsWithTag = pawn.RaceProps.body.GetPartsWithTag(Bones_BodyPartTagDefOf.SZ_LegBone_Tag);
            if (!partsWithTag.Any<BodyPartRecord>())
                return ThoughtState.Inactive;
            foreach (BodyPartRecord part in partsWithTag)
            {
                if (!pawn.health.hediffSet.PartOrAnyAncestorHasDirectlyAddedParts(part) && pawn.health.hediffSet.PartIsMissing(part))
                    return (ThoughtState)true;
            }
            return ThoughtState.Inactive;
        }
    }
}
