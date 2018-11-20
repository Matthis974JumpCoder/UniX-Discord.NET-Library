using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniXDiscordDotNetLibrary;

namespace UnixDiscordDotNetTutorial.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("test")]
        public async Task Testasync()
        {
            // Asking to the server to send a test message on the current channel you typed the command
            await Context.Channel.SendMessageAsync("Test");
        }

    }
}
