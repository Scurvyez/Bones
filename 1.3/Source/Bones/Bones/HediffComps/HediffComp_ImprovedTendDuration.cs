using Verse;
using RimWorld;
using UnityEngine;

namespace Bones
{
    [StaticConstructorOnStartup]
    public class HediffComp_ImprovedTendDuration : HediffComp_TendDuration
    {
        private static readonly Color UntendedColor = new ColorInt(116, 101, 72).ToColor;
        private static readonly Texture2D BrokenBoneIcon = ContentFinder<Texture2D>.Get("UI/Icons/Medical/BrokenBone");
        private static readonly Texture2D TendedIcon_Need_General = ContentFinder<Texture2D>.Get("UI/Icons/Medical/TendedNeed");
        private static readonly Texture2D TendedIcon_Well_General = ContentFinder<Texture2D>.Get("UI/Icons/Medical/TendedWell");
        private static readonly Texture2D TendedIcon_Well_Injury = ContentFinder<Texture2D>.Get("UI/Icons/Medical/BandageWell");

        public override TextureAndColor CompStateIcon
        {
            get
            {
                if (this.parent is Hediff_Injury)
                {
                    if (this.IsTended && !this.parent.IsPermanent())
                    {
                        Color color = Color.Lerp(UntendedColor, Color.white, Mathf.Clamp01(this.tendQuality));
                        return new TextureAndColor(TendedIcon_Well_Injury, color);
                    }

                    else if ((this.parent is Hediff_StableFracture ||
                            this.parent is Hediff_ObliqueFracture ||
                            this.parent is Hediff_ComminutedFracture ||
                            this.parent is Hediff_CompoundFracture ||
                            this.parent is Hediff_TransverseFracture) && !this.IsTended)
                    {
                        return BrokenBoneIcon;
                    }
                }

                else if (!(this.parent is Hediff_MissingPart) && !this.parent.FullyImmune())
                {
                    if (!this.IsTended)
                        return TendedIcon_Need_General;
                    Color color = Color.Lerp(UntendedColor, Color.white, Mathf.Clamp01(this.tendQuality));
                    return new TextureAndColor(TendedIcon_Well_General, color);
                }
                return TextureAndColor.None;
            }
        }
    }
}
