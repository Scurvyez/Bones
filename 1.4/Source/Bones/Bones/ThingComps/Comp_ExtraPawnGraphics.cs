using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RimWorld;
using Verse;
using Verse.AI;
using UnityEngine;

namespace Bones
{
    public class Comp_ExtraPawnGraphics : ThingComp
    {
        /*
        public CompProperties_ExtraPawnGraphics Props => (CompProperties_ExtraPawnGraphics)props;
        private readonly HediffDef CommFrac = Bones_HediffDefOf.SZ_Comminuted_Fracture;
        private readonly HediffDef CompFrac = Bones_HediffDefOf.SZ_Compound_Fracture;
        private readonly HediffDef ObliFrac = Bones_HediffDefOf.SZ_Oblique_Fracture;
        private readonly HediffDef StabFrac = Bones_HediffDefOf.SZ_Stable_Fracture;
        private readonly HediffDef TranFrac = Bones_HediffDefOf.SZ_Transverse_Fracture;

        /// <summary>
        /// Checks to see if an animal is attacking, sleeping, eating, or moving over certain terrain types.
        /// If any of these conditions are met additional graphics are applied. :)
        /// </summary>
        public override void PostDraw()
        {
            base.PostDraw();

            if (parent is Pawn parentPawn)
            {
                Rot4 rotation = parent.Rotation;
                Vector3 drawPos = parent.DrawPos;

                if (Props.graphicsFracture != null)
                {
                    if (((parentPawn.health.hediffSet.HasHediff(CommFrac) && CommFrac.tendable) ||
                        (parentPawn.health.hediffSet.HasHediff(CompFrac) && CompFrac.tendable) ||
                        (parentPawn.health.hediffSet.HasHediff(ObliFrac) && ObliFrac.tendable) ||
                        (parentPawn.health.hediffSet.HasHediff(StabFrac) && StabFrac.tendable) ||
                        (parentPawn.health.hediffSet.HasHediff(TranFrac) && TranFrac.tendable)))
                    {
                        for (int i = 0; i < Props.graphicsFracture.Count; i++)
                        {
                            Props.graphicsFracture[i].Graphic.Draw(
                                (
                                drawPos + Props.graphicsFracture[i].drawOffset),
                                rotation,
                                parent
                                );
                        }
                    }
                }
            }
        }
        */
    }
}
