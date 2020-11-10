using System.Threading;
using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;

namespace dbup_dotnet_core
{
    [Command(name: "drop")]
    public class DropDatabaseCommand
    {
        public async Task<int> OnExecuteAsync(CommandLineApplication app, CancellationToken cancellationToken = default)
        {
            return 0;
        }
    }
}