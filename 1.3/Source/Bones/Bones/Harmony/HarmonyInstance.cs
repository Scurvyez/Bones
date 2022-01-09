using HarmonyLib;
using System.Reflection;
using Verse;

namespace Bones
{
    [StaticConstructorOnStartup]
    public class Main
    {
        static Main()
        {
            var harmony = new Harmony("com.bones");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
