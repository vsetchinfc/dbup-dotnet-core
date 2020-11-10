using System;
using System.Threading;
using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;

namespace dbup_dotnet_core
{
    [Command(name: "create")]
    public class CreateDatabaseCommand
    {
        public async Task<int> OnExecuteAsync(CommandLineApplication app, CancellationToken cancellationToken = default)
        {
            Console.WriteLine("Running create database command");
            return 0;
        }
    }
}