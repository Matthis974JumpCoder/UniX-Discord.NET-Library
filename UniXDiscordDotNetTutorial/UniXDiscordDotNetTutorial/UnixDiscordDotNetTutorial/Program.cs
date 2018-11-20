using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// We need to setup the using for our library
using UniXDiscordDotNetLibrary;

namespace UnixDiscordDotNetTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // We create a the special UniXDiscordLibrary client
            UniXDiscordClient client = new UniXDiscordClient();

            // We use our new created client to setup the prefix, the token and here we go ! We're connected ! (Make sure everything is ok on discord.gg in the developpers portal)
            client.Login("!", "Token_Here");

            // FACULTATIVE FUNCTIONS:



            // You can setup a unban message in a specefic channel, this will look's like : @John#1234 got unbanned! 
            client.UnBannedUserMessage(true, "got unbanned!" , "CHANNELID");

            //You can setup a ban message in a specefic channel, this will look's like : @John#1234 got banned!
            client.BanUserMessage(true, "got banned!", "CHANNELID");

            //You can setup a UserJoin message in a specefic channel, this will look's like : @John#1234 is here to beat our ass
            client.UserJoinMessage(true, " is here to beat our ass", "CHANNELID");

            // You can setup a UserLeft message in a specefir channel, this will look's like : @John1234 oh no why did you just left the server :(
            client.UserLeftMessage(true, " oh no why did you just left the server :( ", "CHANNELID");

            //AppBuilder is used to setup your console application title ! 
            client.AppBuilder("MyBotV1");


            //Prevent closing application after execution of the code (without, the app will close instantly)
            Console.ReadKey();
        }
    }
}
