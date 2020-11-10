using System;
using System.Threading;
using System.Threading.Tasks;
using AVSC.Database.Enums;
using McMaster.Extensions.CommandLineUtils;
using DbType = AVSC.Database.Enums.DatabaseType;

namespace dbup_dotnet_core
{
    [Command(name: "dbup-dotnet-core")]
    [Subcommand(typeof(DropDatabaseCommand))]
    [Subcommand(typeof(CreateDatabaseCommand))]
    [HelpOption("-? | --help")]
    public class DatabaseCommand
    {
        [Option("-m | --mode", "Mode for standing data", CommandOptionType.SingleValue)]
        public int Mode { get; set; }

        [Option(template: "-dt | --database-type", description: "Database Type: Sql Server, MySQL...", CommandOptionType.SingleValue)]
        public (bool HasValue, DatabaseType value) DatabaseType { get; }

        public async Task<int> OnExecuteAsync(CommandLineApplication app, CancellationToken cancellationToken = default)
        {
            if (!this.DatabaseType.HasValue)
            {
                app.ShowHelp();
            }

            Console.WriteLine(DatabaseType.value.ToString());

            switch (DatabaseType.value)
            {
                case DbType.SqlServer:
                    Console.WriteLine("Sql Sever");
                    break;
            }


            return 0;
        }
    }
}