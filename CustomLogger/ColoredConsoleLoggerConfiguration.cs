using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingSample.CustomLogger
{
    public class ColoredConsoleLoggerConfiguration
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Warning;
        public int EventId { get; set; } = 0;
        public ConsoleColor ConsoleColor { get; set; } = ConsoleColor.Yellow;
    }
}
