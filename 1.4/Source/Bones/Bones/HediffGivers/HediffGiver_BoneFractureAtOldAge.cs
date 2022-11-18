using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RimWorld;
using RimWorld.Planet;
using Verse;

namespace Bones
{
    public class HediffGiver_BoneFractureAtOldAge : HediffGiver_RandomAgeCurved
	{
		public float mtbDays;

		public override void OnIntervalPassed(Pawn pawn, Hediff cause)
		{
			float num = mtbDays;
			float num2 = ChanceFactor(pawn);
			if (num2 != 0f && Rand.MTBEventOccurs(num / num2, 60000f, 60f) && TryApply(pawn))
			{
				SendLetter(pawn, cause);
			}
		}
    }
}
