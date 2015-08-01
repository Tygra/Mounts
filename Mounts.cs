using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;
using TShockAPI.DB;

namespace Mounts
{
    [ApiVersion(1, 20)]
    public class Mounts : TerrariaPlugin
    {

        public override string Name
        {
            get
            {
                return "Mounts";
            }
        }

        public override string Author
        {
            get
            {
                return "Hiarni";
            }
        }

        public override string Description
        {
            get
            {
                return "Mounts";
            }
        }

        public override Version Version
        {
            get
            {
                return new Version(1, 0, 0, 0);
            }
        }

        public Mounts(Main game)
            : base(game)
        {
            base.Order = 1;
        }

        public override void Initialize()
        {
            ServerApi.Hooks.GameInitialize.Register(this, OnInitialize);
        }

        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                ServerApi.Hooks.GameInitialize.Deregister(this, OnInitialize);
            }
            base.Dispose(Disposing);
        }

        private void OnInitialize(EventArgs args)
        {
            Commands.ChatCommands.Add(new Command("mounts.rudolph", MRUDOLPH, "rudolph"));
            Commands.ChatCommands.Add(new Command("mounts.bunny", MBUNNY, "bunny"));
            Commands.ChatCommands.Add(new Command("mounts.pigron", MPIGRON, "pigron"));
            Commands.ChatCommands.Add(new Command("mounts.slime", MSLIME, "slime"));
            Commands.ChatCommands.Add(new Command("mounts.turtle", MTURTLE, "turtle"));
            Commands.ChatCommands.Add(new Command("mounts.bee", MBEE, "bee"));
            Commands.ChatCommands.Add(new Command("mounts.minecart", MMC, "minecart"));
            Commands.ChatCommands.Add(new Command("mounts.ufo", MUFO, "ufo"));
            Commands.ChatCommands.Add(new Command("mounts.drill", MDRILL, "drill"));
            Commands.ChatCommands.Add(new Command("mounts.scutlix", MSCUTLIX, "scutlix"));
            Commands.ChatCommands.Add(new Command("mounts.unicorn", MUNICORN, "unicorn"));
            Commands.ChatCommands.Add(new Command("mounts.fishron", MFISHRON, "fishron"));
        }


        private void MRUDOLPH(CommandArgs args)
        {
            TSPlayer ply = args.Player;
            args.Player.SetBuff(90);
                args.Player.SendInfoMessage("You summoned a rideable Reindeer!");
            }

        private void MBUNNY(CommandArgs args)
        {
            TSPlayer ply = args.Player;
            args.Player.SetBuff(128);
            args.Player.SendInfoMessage("You summoned a rideable Bunny!");
        }

        private void MPIGRON(CommandArgs args)
        {
            TSPlayer ply = args.Player;
            args.Player.SetBuff(129);
            args.Player.SendInfoMessage("You summoned a rideable Pig! Oink Oink!");
        }

        private void MSLIME(CommandArgs args)
        {
            TSPlayer ply = args.Player;
            args.Player.SetBuff(130);
            args.Player.SendInfoMessage("You summoned a rideable Slime! How slippy!");
        }
        private void MTURTLE(CommandArgs args)
        {
            TSPlayer ply = args.Player;
            args.Player.SetBuff(131);
            args.Player.SendInfoMessage("You summoned a rideable Turtle! Come on... move on!");
        }
        private void MBEE(CommandArgs args)
        {
            TSPlayer ply = args.Player;
            args.Player.SetBuff(132);
            args.Player.SendInfoMessage("You summoned a rideable Bee! Weeee!");
        }
        private void MMC(CommandArgs args)
        {
            TSPlayer ply = args.Player;
            args.Player.SetBuff(166);
            args.Player.SendInfoMessage("You summoned a Mechanical Cart!");
        }
        private void MUFO(CommandArgs args)
        {
            TSPlayer ply = args.Player;
            args.Player.SetBuff(141);
            args.Player.SendInfoMessage("You summoned a flying UFO! Eeeeeeeeeteeee phone home!");
        }
        private void MDRILL(CommandArgs args)
        {
            TSPlayer ply = args.Player;
            args.Player.SetBuff(142);
            args.Player.SendInfoMessage("You summoned a rideable Drill! What the heck?!");
        }
        private void MSCUTLIX(CommandArgs args)
        {
            TSPlayer ply = args.Player;
            args.Player.SetBuff(143);
            args.Player.SendInfoMessage("You summoned a rideable Scutlix creature!");
        }
        private void MUNICORN(CommandArgs args)
        {
            TSPlayer ply = args.Player;
            args.Player.SetBuff(162);
            args.Player.SendInfoMessage("You summoned a rideable Unicorn! Don't cut the horn!");
        }
        private void MFISHRON(CommandArgs args)
        {
            TSPlayer ply = args.Player;
            args.Player.SetBuff(168);
            args.Player.SendInfoMessage("You summoned a rideable Fishron beast! Caaaarefully!");
        }
    }
    }