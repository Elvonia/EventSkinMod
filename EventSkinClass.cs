using Il2Cpp;
using HarmonyLib;
using MelonLoader;
using System.Collections.ObjectModel;

namespace EventSkinMod
{
    public class EventSkinClass : MelonMod
    {
        [HarmonyPatch(typeof(SkinManager), "CheckIfSkinUnlocked")]
        static class SkinPatch
        {
            public static bool Prefix(SkinNameID skin, ref bool __result)
            {
                if (skin == SkinNameID.HALLOWEEN_SCARECROW || skin == SkinNameID.VAMPIRE_GIRL)
                {
                    __result = true;
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }
        [HarmonyPatch(typeof(SkinManager), "CheckIfCosmeticUnlocked")]
        static class CosmeticPatch
        {
            public static bool Prefix(CosmeticNameID cosmeticNameID, ref bool __result)
            {
                if (cosmeticNameID == CosmeticNameID.DEER_MASK || cosmeticNameID == CosmeticNameID.SNOWMAN_MASK || cosmeticNameID == CosmeticNameID.ELF_BUDDY || cosmeticNameID == CosmeticNameID.CHRISTMAS_HAT)
                {
                    __result = true;
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
