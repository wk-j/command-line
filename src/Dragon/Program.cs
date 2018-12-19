﻿using System;
using System.IO;

namespace Dragon {
    class Program {

        /// <param name="intOption">An option whose argument is parsed as an int</param>
        /// <param name="boolOption">An option whose argument is parsed as a bool</param>
        /// <param name="fileOption">An option whose argument is parsed as a FileInfo</param>
        static void Main(int intOption = 42, bool boolOption = false, FileInfo fileOption = null) {
            Console.WriteLine($"The value for --int-option is: {intOption}");
            Console.WriteLine($"The value for --bool-option is: {boolOption}");
            Console.WriteLine($"The value for --file-option is: {fileOption?.FullName ?? "null"}");
        }
    }
}
