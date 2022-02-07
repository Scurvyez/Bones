using UnityEngine;
using Verse;

namespace Bones
{
    public class Hediff_Fracture : Hediff_Injury
    {
        private static readonly Color PermanentInjuryColor = new(0.72f, 0.72f, 0.72f);
        public override Color LabelColor => this.IsPermanent() ? PermanentInjuryColor : Color.Lerp(Color.cyan, Color.magenta, ColorSeverity());

        public float ColorSeverity()
        {
            float eff = PawnCapacityUtility.CalculatePartEfficiency(pawn.health.hediffSet, Part);
            float effPer = ((eff) / 1) * 100;

            if (effPer <= 100 && effPer >= 91)
                return 0.955f;
            else if (effPer <= 90 && effPer >= 81)
                return 0.855f;
            else if (effPer <= 80 && effPer >= 71)
                return 0.755f;
            else if (effPer <= 70 && effPer >= 61)
                return 0.655f;
            else if (effPer <= 60 && effPer >= 51)
                return 0.555f;
            else if (effPer <= 50 && effPer >= 41)
                return 0.455f;
            else if (effPer <= 40 && effPer >= 31)
                return 0.355f;
            else if (effPer <= 30 && effPer >= 21)
                return 0.255f;
            else if (effPer <= 20 && effPer >= 11)
                return 0.155f;
            else
                return 0.055f;
        }
    }
}
