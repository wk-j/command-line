using System;
using System.IO;

namespace Dragon {
    class Program {
        static void Main(int intOption = 42, bool boolOption = false, FileInfo fileOption = null) {
            Console.WriteLine($"The value for --int-option is: {intOption}");
            Console.WriteLine($"The value for --bool-option is: {boolOption}");
            Console.WriteLine($"The value for --file-option is: {fileOption?.FullName ?? "null"}");
        }
    }
}
