// --------------------------------------------------------------------------------------------------------------------- 
// <copyright file="Program.cs" company="Say No More">
//   2009
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// ---------------------------------------------------------------------------------------------------------------------
namespace TestMultiple
{
    using NLog;
    using NLog.Targets;

    class Program
    {
        static void Main(string[] args)
        {
            FileTarget target = new FileTarget();
            target.Layout = "${longdate} - ${message}";
            target.FileName = "${basedir}/logs/${logger}.log";
            target.ArchiveFileName = "${basedir}/archives/${logger}/${logger}.{#####}.txt";
            target.ArchiveEvery = FileTarget.ArchiveEveryMode.Minute;
            target.ArchiveNumbering = FileTarget.ArchiveNumberingMode.Rolling;
            target.MaxArchiveFiles = 2;
            target.ArchiveAboveSize = 10000;
            target.ConcurrentWrites = true;

            NLog.Config.SimpleConfigurator.ConfigureForTargetLogging(target, LogLevel.Debug);

            Logger logger1 = LogManager.GetLogger("ArchivoSalida1");
            Logger logger2 = LogManager.GetLogger("ArchivoSalida2");

            for (int i = 0; i < 1000; i++)
            {
                logger1.Debug("Archivo de salida 1: " + i.ToString("000"));
                logger2.Debug("Archivo de salida 2:" + i.ToString("000"));
            }

        }
    }
}
