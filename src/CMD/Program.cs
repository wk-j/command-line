using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Threading.Tasks;

namespace CMD {
    class Program {
        static async Task Main(string[] args) {
            var optionThatTakesInt = new Option(
                "--int-option",
                "An option whose argument is parsed as an int",
                new Argument<int>(defaultValue: 42)
            );

            var optionThatTakesBool = new Option(
                "--bool-option",
                "An option whose argument is parsed as a bool",
                new Argument<bool>()
            );

            var optionThatTakesFileInfo = new Option(
                "--file-option",
                "An option whose argument is parsed as a FileInfo",
                new Argument<FileInfo>()
            );

            var rootCommand = new RootCommand();
            rootCommand.Description = "My sample app";
            rootCommand.AddOption(optionThatTakesInt);
            rootCommand.AddOption(optionThatTakesBool);
            rootCommand.AddOption(optionThatTakesFileInfo);

            rootCommand.Handler = CommandHandler.Create<int, bool, FileInfo>((i, b, f) => {
                Console.WriteLine($"Int value = {i}");
                Console.WriteLine($"Bool value = {b}");
                Console.WriteLine($"File value = {f?.FullName}");
            });

            await rootCommand.InvokeAsync(args);
        }
    }
}
