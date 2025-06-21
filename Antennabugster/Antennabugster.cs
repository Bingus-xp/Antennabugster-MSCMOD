using MSCLoader;
using UnityEngine;

namespace Antennabugster
{
    public class Antennabugster : Mod
    {
        public override string ID => "Antennabugster"; // Your (unique) mod ID 
        public override string Name => "Antenna"; // Your mod name
        public override string Author => "Bugster & BingusNTS"; // Name of the Author (your name)
        public override string Version => "1.0.0"; // Version
        public override string Description => ""; // Short description of your mod
        GameObject anten;
        public override void ModSetup()
        {
            SetupFunction(Setup.OnLoad, Mod_OnLoad);
            SetupFunction(Setup.PostLoad, Mod_PostLoad);
            SetupFunction(Setup.Update, Mod_Update);
            SetupFunction(Setup.ModSettings, Mod_Settings);
        }

        private void Mod_Settings()
        {
            // All settings should be created here. 
            // DO NOT put anything that isn't settings or keybinds in here!
        }

        private void Mod_OnLoad()
        {
            GameObject satsuma = GameObject.Find("SATSUMA(557kg, 248)");
            AssetBundle ab = LoadAssets.LoadBundle(this, "antenna.unity3d");
            GameObject go = ab.LoadAsset<GameObject>("default.prefab");
            anten = GameObject.Instantiate(go);
            ab.Unload(false);
            anten.transform.parent = satsuma.transform;

            anten.transform.localPosition = new Vector3(0.02078565f, 0.2829144f, 0.006097147f);
            anten.transform.localEulerAngles = new Vector3(0.2263746f, 178.1609f, 359.5478f);

            // dont forget to implement embedded resources (they dont work for fucks sack)








           
            // anten.transform.localScale = new Vector3(1f, 1f, 1f); keeping it off for now
            // Called once, when mod is loading after game is fully loaded        
        }
        private void Mod_PostLoad()
        {
            // Called once, after all mods finished OnLoad
        }
        private void Mod_Update()
        {
            // Update is called once per frame
        }
    }
}
