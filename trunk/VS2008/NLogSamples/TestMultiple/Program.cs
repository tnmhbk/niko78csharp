// --------------------------------------------------------------------------------------------------------------------- 
// <copyright file="Program.cs" company="Say No More">
//   2009
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// ---------------------------------------------------------------------------------------------------------------------
using System;
using NLog.Config;

namespace TestMultiple
{
    using NLog;
    using NLog.Targets;

    class Program
    {
        static void Main(string[] args)
        {
            FileTarget target1 = new FileTarget();
            target1.Name = "File1";
            target1.Layout = "${longdate} - ${level} - ${message}";
            target1.FileName = "${basedir}/logs/${logger}.log";
            target1.ArchiveFileName = "${basedir}/archives/${logger}/${logger}.{#####}.txt";
            target1.ArchiveEvery = FileTarget.ArchiveEveryMode.None;
            target1.ArchiveNumbering = FileTarget.ArchiveNumberingMode.Rolling;
            target1.MaxArchiveFiles = 2;
            target1.ArchiveAboveSize = 10000;
            target1.ConcurrentWrites = false;

            FileTarget target2 = new FileTarget();
            target2.Name = "File2";
            target2.Layout = "${longdate} - ${level} - ${message}";
            target2.FileName = "${basedir}/logs/${logger}.log";
            target2.ArchiveFileName = "${basedir}/archives/${logger}/${logger}.{#####}.txt";
            target2.ArchiveEvery = FileTarget.ArchiveEveryMode.None;
            target2.ArchiveNumbering = FileTarget.ArchiveNumberingMode.Sequence;
            target2.MaxArchiveFiles = 2;
            target2.ArchiveAboveSize = 10000;
            target2.ConcurrentWrites = false;

            LogManager.ThrowExceptions = true;

            LoggingConfiguration loggingConfiguration = new LoggingConfiguration();
            
            LoggingRule loggingRule1 = new LoggingRule("ArchivoSalida1", LogLevel.Trace, target1);
            loggingConfiguration.LoggingRules.Add(loggingRule1);
            LogManager.Configuration = loggingConfiguration;

            LoggingRule loggingRule2 = new LoggingRule("ArchivoSalida2", LogLevel.Trace, target2);
            LogManager.Configuration.LoggingRules.Add(loggingRule2);
            LogManager.Configuration = loggingConfiguration;

            Logger logger1 = LogManager.GetLogger("ArchivoSalida1");
            Logger logger2 = LogManager.GetLogger("ArchivoSalida2");
            Logger logger3 = LogManager.GetLogger("ArchivoSalida3");

            for (int i = 0; i < 1000; i++)
            {
                logger1.Info("Archivo de salida 1:" + i.ToString("000"));
                logger2.Debug("Archivo de salida 2:" + i.ToString("000"));
                logger3.Warn("Que paso");
            }

        }
    }
}
