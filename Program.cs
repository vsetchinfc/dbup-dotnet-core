using System;
using System.Threading;
using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Configuration;

namespace dbup_dotnet_core
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = CommandLineApplication.ExecuteAsync<DatabaseCommand>(args);
        }
    }
}
