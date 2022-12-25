using Verse;

namespace Bones
{
    [StaticConstructorOnStartup]
    public static class BonesMain
    {
        static BonesMain()
        {
            Log.Message("<color=white>[</color>" + "<color=#4494E3FF>Steve</color>" + "<color=white>]</color>" + 
                "<color=white>[</color>" + "<color=#4494E3FF>Bones</color>" + "<color=white>]</color>" +
                "<color=#4494E3FF>Try not to break them all! Or... do...</color>");
        }
    }
}
