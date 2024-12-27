using System;
using System.ComponentModel;
using Kill_Info.EventHandlers;
using Exiled.API.Interfaces;

namespace Kill_Info
{
    public class Config : IConfig
    {
        [Description("Plugin displays information to the player about target you killed.")]
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = true;
        [Description("Time that the message will be visible. Default is 5.")]
        public ushort Time { get; set; } = 5;
        [Description("Color of the displayed text. Default is green.")]
        public string Color { get; set; } = "Green";
    }
}
