using Verse;
using RimWorld;
using UnityEngine;
using System;

namespace Bones
{
    [StaticConstructorOnStartup]
    public class HediffComp_ImprovedTendDuration : HediffComp_TendDuration
    {
        private static readonly Color UntendedColor = new ColorInt(116, 101, 72).ToColor;
        private static readonly Texture2D StableFractureIcon = ContentFinder<Texture2D>.Get("UI/Icons/Medical/StableFracture");
        private static readonly Texture2D ObliqueFractureIcon = ContentFinder<Texture2D>.Get("UI/Icons/Medical/ObliqueFracture");
        private static readonly Texture2D ComminutedFractureIcon = ContentFinder<Texture2D>.Get("UI/Icons/Medical/ComminutedFracture");
        private static readonly Texture2D CompoundFractureIcon = ContentFinder<Texture2D>.Get("UI/Icons/Medical/CompoundFracture");
        private static readonly Texture2D TransverseFractureIcon = ContentFinder<Texture2D>.Get("UI/Icons/Medical/TransverseFracture");
        private static readonly Texture2D TendedIcon_Need_General = ContentFinder<Texture2D>.Get("UI/Icons/Medical/TendedNeed");
        private static readonly Texture2D TendedIcon_Well_General = ContentFinder<Texture2D>.Get("UI/Icons/Medical/TendedWell");
        private static readonly Texture2D TendedIcon_Well_Injury = ContentFinder<Texture2D>.Get("UI/Icons/Medical/BandageWell");

        public override TextureAndColor CompStateIcon
        {
            get
            {
                if (parent is Hediff_Injury)
                {
                    if (IsTended && !parent.IsPermanent())
                    {
                        Color color = Color.Lerp(UntendedColor, Color.white, Mathf.Clamp01(tendQuality));
                        return new TextureAndColor(TendedIcon_Well_Injury, color);
                    }

                    else if (parent is Hediff_StableFracture)
                        {
                        return StableFractureIcon;
                        }
                    else if (parent is Hediff_ObliqueFracture)
                    {
                        return ObliqueFractureIcon;
                    }
                    else if (parent is Hediff_ComminutedFracture)
                    {
                        return ComminutedFractureIcon;
                    }
                    else if (parent is Hediff_CompoundFracture)
                    {
                        return CompoundFractureIcon;
                    }
                    else if (parent is Hediff_TransverseFracture)
                    {
                        return TransverseFractureIcon;
                    }
                }

                else if (!(parent is Hediff_MissingPart) && !parent.FullyImmune())
                {
                    if (!IsTended)
                        return TendedIcon_Need_General;
                    Color color = Color.Lerp(UntendedColor, Color.white, Mathf.Clamp01(tendQuality));
                    return new TextureAndColor(TendedIcon_Well_General, color);
                }
                return TextureAndColor.None;
            }
        }
    }
}
