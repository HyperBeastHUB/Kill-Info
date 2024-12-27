using System;
using Exiled.API.Features;
using Exiled.Loader;
using player = Exiled.Events.Handlers.Player;

namespace Kill_Info
{
    public class Init : Plugin<Config>
    {
        public static Init Instance;
        public override string Author => "Hyperbeast";
        public override string Name => $"KillInfo by{Author}";
        public override Version RequiredExiledVersion => new Version(9, 1, 0);
        public override void OnEnabled()
        {
            Instance = this;
            Log.Info($"{Name} has been successfully enabled!");
            player.Died += EventHandlers.Died.Informations;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            Log.Info($"{Name} has not been enabled!");
            player.Died -= EventHandlers.Died.Informations;
            base.OnDisabled();
        }
    }
}
