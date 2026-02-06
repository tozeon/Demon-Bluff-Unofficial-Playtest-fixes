using HarmonyLib;
using Il2Cpp;

using MelonLoader;


[assembly: MelonInfo(typeof(Demon_Bluff_Unofficial_Demo_Patch.Core), "Demon Bluff tozeon's Unofficial Demo Patch", "0.1.0", "tulxoro", null)]
[assembly: MelonGame("UmiArt", "Demon Bluff")]

namespace Demon_Bluff_Unofficial_Demo_Patch
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized.");
            
            // Apply the harmony patch
            var harmony = new HarmonyLib.Harmony("tozeon.Demon.Bluff.Patch");
            harmony.PatchAll();

            GameEvents.OnGameplayStateChange += new Action(OnGameplayStateChange);
        }

        private static void OnGameplayStateChange() {
             var currentState = Gameplay.GameplayState;
            MelonLogger.Msg($"Gameplay State Changed to: {currentState}");
        }
    }

    [HarmonyPatch(typeof(Health), "Damage")]
    public static class HealthDamagePatch
    {

        [HarmonyPostfix]
        public static void DamagePostfix(Health __instance, int value)
        {

            if (PlayerController.PlayerInfo != null && __instance == PlayerController.PlayerInfo.health)
            {;
                
                if (__instance.value.GetValue() <= 0)
                {
                    var winConditions = UnityEngine.Object.FindObjectOfType<WinConditions>();

                    if (winConditions != null){
                        winConditions.LoseNormal();
                    }
    
                    Gameplay.ChangeGameplayState(EGameplayState.Summary);
                }
            }
        }
    }



}