using System;
using Exiled.Events.EventArgs.Player;

namespace Kill_Info.EventHandlers
{
    public class Died
    {
        public static void Informations(DiedEventArgs ev)
        {
            string Name = ev.Player.DisplayNickname.ToString();
            string Role = ev.TargetOldRole.ToString();
            ev.Attacker.Broadcast(Init.Instance.Config.Time, $"<b><color={Init.Instance.Config.Color}>You killed </color></b><b><color=white>{Name}</color></b><b><color={Init.Instance.Config.Color}> that was playing </color></b><b><color=white>{Role}.</color></b>");

        }
    }
}
