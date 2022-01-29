using Verse;
using UnityEngine;

namespace Bones
{
    public class Hediff_Fracture : Hediff_Injury
    {
        private static readonly Color PermanentInjuryColor = new(0.72f, 0.72f, 0.72f);
        public override Color LabelColor => this.IsPermanent() ? PermanentInjuryColor : Color.Lerp(Color.red, Color.green, ColorSeverity());

        public float ColorSeverity()
        {
            float efficiency = PawnCapacityUtility.CalculatePartEfficiency(pawn.health.hediffSet, Part);

            if ((efficiency <= (100 / efficiency) * 100) && (efficiency >= (76 / efficiency) * 100))
            {
                return 0.88f;
            }
            else if ((efficiency <= (75 / efficiency) * 100) && (efficiency >= (51 / efficiency) * 100))
            {
                return 0.63f;
            }
            else if ((efficiency <= (50 / efficiency) * 100) && (efficiency >= (26 / efficiency) * 100))
            {
                return 0.38f;
            }
            else
            {
                return 0.13f;
            }
        }
    }
}
