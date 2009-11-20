/*
 * Uso de NLog con archivo de configuracion.
 * IMPORTANTE: Copiar el archivo Nlog.xsd a al carpeta
 * c:\Archivos de programa\Microsoft Visual Studio 8\Xml\Schemas\
 * despues reiniciar el Visual Studio y el intelisence nos ayudara a 
 * completar los tags xml dentro del XML o App.config
 */
namespace TestMultipleAppConfig
{
    using System;
    using System.Configuration;
    using System.Text;
    using NLog;
    using NLog.Targets;

    public class Program
    {
        static void Main(string[] args)
        {
            LayoutRendererFactory.AddLayoutRenderer("AppSetting", typeof(AppSettingLayoutReader));

            TargetCollection targetCollection = LogManager.Configuration.GetConfiguredNamedTargets();
            int cant = targetCollection.Count;
            Target target = targetCollection[0];

            if (target is FileTarget)
            {
                string nombreArchivo = (target as FileTarget).FileName;
                Console.WriteLine(nombreArchivo);
            }

            Logger logger1 = LogManager.GetLogger("Logger1");
            Logger logger2 = LogManager.GetLogger("Logger2");

            for (int i = 0; i < 1000; i++)
            {
                logger1.Debug("Archivo de salida 1: " + i.ToString("000"));
                logger2.Debug("Archivo de salida 2: " + i.ToString("000"));
            }

            Console.WriteLine("Press any key to contine");
            Console.ReadLine();
        }

        /// <summary>
        /// This is an example of a configurable parameter 
        /// </summary>
        [LayoutRenderer("AppSetting")]
        public sealed class AppSettingLayoutReader : LayoutRenderer
        {
            /// <summary>
            /// Gets or sets AppValue.
            /// </summary>
            public string AppValue { get; set; }

            protected override int GetEstimatedBufferSize(LogEventInfo ev)
            {
                // since hour is expressed by 2 digits we need at most 2-character 
                // buffer for it 
                return 20;
            }

            protected override bool IsAppDomainFixed()
            {
                return true;
            }

            protected override void Append(StringBuilder builder, LogEventInfo ev)
            {
                builder.Append(ApplyPadding(ConfigurationManager.AppSettings[AppValue]));
            }
        }
    }
}
