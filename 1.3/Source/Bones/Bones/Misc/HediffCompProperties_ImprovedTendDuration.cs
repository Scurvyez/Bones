using Verse;

namespace Bones
{
    public class HediffCompProperties_ImprovedTendDuration : HediffCompProperties_TendDuration
    {
        //Constructor used the same as TendDuration, which reset the type??? IDK. Bottom line, this is why the overriden CompStateIcon was never actually called! - ZWolf
        public HediffCompProperties_ImprovedTendDuration() => this.compClass = typeof(HediffComp_ImprovedTendDuration);
    }
}
