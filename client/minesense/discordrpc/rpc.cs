using System;
using DiscordRPC;
namespace WindowsFormsApp1
{
    public class RPC
    {
        

        public static DiscordRpcClient client;
        public static Timestamps rpctimestamp { get; set; }
        public static RichPresence presence;
        public static void InitializeRPC()  //we start the rich presence here
        {
            string discord = "[DISCORD] ";            

            Console.WriteLine(discord + "Beginning RPC Initialization...");
            client = new DiscordRpcClient("1053332674510586056");
            client.Initialize();
            Button[] button = { new Button() { Label = "Discord", Url = "https://discord.gg/VupGTvkhd8" } };
            Console.WriteLine(discord + "Initialization complete. You should now have a Rich Presence.");           


            presence = new RichPresence() //presence details
            {
                Details = "Waiting for Minecraft...",
                State = "Waiting for state...",
                Timestamps = rpctimestamp,
                Buttons = button,

                
                Assets = new Assets() //assets
                {
                    
                    LargeImageKey = "large",
                    LargeImageText = "minesense beta",
                    SmallImageKey = "large",
                    SmallImageText = "b1.2"
                }
                
        };
            
        }
        public static void SetState(string state, bool watching = false)
        {
            if (watching)
                state = "Looking at " + state;           
            presence.State = state;
            client.SetPresence(presence);
        }
    }
}
