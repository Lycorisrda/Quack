using System.Diagnostics;
using System.Threading;
using ff14bot;
using ff14bot.Helpers;
using ff14bot.Managers;
using Newtonsoft.Json;
using System;
using System.IO;
using Quack.Settings;
using System.Configuration;
using Quack;
using ff14bot.AClasses;
using System.Windows.Media;

namespace Quack_
{
    public class Quack : BotPlugin
    {
        #region Necessary Stuff
        public override string Author { get { return "Lycorisrda"; } }
        public override Version Version { get { return new Version(1, 0, 0); } }

        public override void OnInitialize()
        {
            settings.Enabled = false;
        }
        public override void OnShutdown()
        {

        }
        public override void OnEnabled()
        {
            settings.Enabled = false;
        }
        public override void OnDisabled()
        {
        }
        public override string Name
        {
            get { return "Quack! 定时传送停止RB"; }
        }
        public override bool WantButton
        {
            get { return true; }
        }
        public override string ButtonText
        {
            get { return "设置"; }
        }


        public override void OnButtonPress()
        {
            if (_form == null || _form.IsDisposed || _form.Disposing)
                _form = new frmMain();

            _form.ShowDialog();    
        }
        #endregion

        #region Variables
        public static QuackSettings settings = QuackSettings.Instance;
        private frmMain _form;

        #endregion

        public override void OnPulse()
        {
            if (settings.Enabled)
            {
                if (DateTime.Now >= settings.TimeEnd)
                {
                    TreeRoot.Stop("已运行至设定停止时间，停止RB");

                    if (GatheringManager.WindowOpen)
                    {
                        Logging.Write("Colors.AliceBlue, [Quack!] 采集中，等待采集结束.");

                        // await Coroutine.Wait(10000, () => !GatheringManager.WindowOpen);

                        Thread.Sleep(5000);
                        return;
                    }

                    if (Core.Player.InCombat)
                    {
                        Logging.Write("Colors.AliceBlue, [Quack!] 战斗中，等待战斗结束.");

                        //await Coroutine.Wait(Timeout.Infinite, () => !Core.Player.InCombat);

                        Thread.Sleep(5000);
                        return;
                    }

                    if (!Core.Player.InCombat)
                    {
                        if (settings.Teleport)
                        {
                            Logging.Write(Colors.AliceBlue, "[Quack!] 传送至 {0}", (settings.TeleportLocation).ToString());
                            WorldManager.TeleportById(AetheryDic._aetheryList[settings.TeleportLocation]);

                            // await Coroutine.Wait(10000, () => WorldManager.ZoneId == AetheryDic._zoneList[settings.TeleportLocation]);

                            Thread.Sleep(5000);
                        }
                    }

                    if (settings.Logout)
                    {

                        Logging.Write(Colors.AliceBlue, "[Quack!] 关闭游戏进程.");

                        Process[] ffxiv = Process.GetProcessesByName("ffxiv");

                        foreach (Process p in ffxiv)
                            p.Kill();
                    }
                }
            }
        }
    } 
}

#region Settings
namespace Quack.Settings
{
    public class QuackSettings : JsonSettings
    {
        [JsonIgnore]
        private static QuackSettings _instance;
        public static QuackSettings Instance { get { return _instance ?? (_instance = new QuackSettings("QuackSettings")); } }
        public QuackSettings(string filename) : base(Path.Combine(CharacterSettingsDirectory, "Quack.json")) { }

        [Setting]
        public bool Enabled { get; set; }

        #region Time Settings
        [Setting]
        public int HoursElapsed { get; set; }
        [Setting]
        public int MinutesElapsed { get; set; }
        [Setting]
        public DateTime TimeEnd { get; set; }
        [Setting]
        public DateTime TimeStart { get; set; }
        #endregion

        #region Action Settings
        [Setting]
        public bool Teleport { get; set; }
        [Setting]
        public string TeleportLocation { get; set; }
        [Setting]
        public bool Logout { get; set; }
        #endregion
    }
}
#endregion

