using UnityEngine;
using Verse;

namespace Bones
{
    public class Hediff_Fracture : Hediff_Injury
    {
        public float Efficiency { get; set; }
        private static readonly Color PermanentInjuryColor = new(0.72f, 0.72f, 0.72f);
        public override Color LabelColor => this.IsPermanent() ? PermanentInjuryColor : Color.Lerp(Color.red, Color.white, ColorSeverity());

        /// <summary>
        /// Sets the current text color in a pawns' Health Card depending on severity of the fracture.
        /// </summary>
        public float ColorSeverity()
        {
            float eff = PawnCapacityUtility.CalculatePartEfficiency(pawn.health.hediffSet, Part);
            // Calculated as a fraction.
            float effPer = ((eff) / 1) * 100;

            Efficiency = effPer switch
            {
                _ when effPer <= 100 && effPer >= 91 => 0.995f,
                _ when effPer <= 90 && effPer >= 81 => 0.855f,
                _ when effPer <= 80 && effPer >= 71 => 0.755f,
                _ when effPer <= 70 && effPer >= 61 => 0.655f,
                _ when effPer <= 60 && effPer >= 51 => 0.555f,
                _ when effPer <= 50 && effPer >= 41 => 0.455f,
                _ when effPer <= 40 && effPer >= 31 => 0.355f,
                _ when effPer <= 30 && effPer >= 21 => 0.255f,
                _ when effPer <= 20 && effPer >= 11 => 0.155f,
                _ => 0.055f
            } ;
            return Efficiency;
        }
    }
}
