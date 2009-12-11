/*
 * Uso de NLog con archivo de configuracion.
 * IMPORTANTE: Copiar el archivo Nlog.xsd a al carpeta
 * c:\Archivos de programa\Microsoft Visual Studio 8\Xml\Schemas\
 * despues reiniciar el Visual Studio y el intelisence nos ayudara a 
 * completar los tags xml dentro del XML o App.config
 */
using NLog.Config;

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

            LogFactory logFactory = new LogFactory(new XmlLoggingConfiguration("c:\\NLog.config"));

            //TargetCollection targetCollection = LogManager.Configuration.GetConfiguredNamedTargets();
            //int cant = targetCollection.Count;
            //Target target = targetCollection[0];

            //if (target is FileTarget)
            //{
            //    string nombreArchivo = (target as FileTarget).FileName;
            //    Console.WriteLine(nombreArchivo);
            //}

            Logger logger1 = logFactory.GetLogger("Logger1");
            Logger logger2 = logFactory.GetLogger("Logger2");

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
            #region "Public properites exposed"

            /// <summary>
            /// Gets or sets AppValue.
            /// </summary>
            public string AppValue { get; set; }

            #endregion

            #region "Protected overriding Methods"

            /// <summary>
            /// Returns the estimated number of characters that are needed to hold the rendered value for the specified logging event.
            /// </summary>
            /// <param name="logEvent">Logging event information.</param>
            /// <returns>The number of characters.</returns>
            /// <remarks>If the exact number is not known or expensive to calculate this function should return a rough estimate
            ///  that's big enough in most cases, but not too big, in order to conserve memory.
            /// </remarks>
            protected override int GetEstimatedBufferSize(LogEventInfo logEvent)
            {
                return 35;
            }

            /// <summary>
            /// Determines whether the value produced by the layout renderer is fixed per current app-domain.
            /// </summary>
            /// <returns>
            /// The boolean value. <c>true</c> makes the value of the layout renderer be precalculated and inserted as a literal in the resulting layout string.
            /// </returns>
            protected override bool IsAppDomainFixed()
            {
                return true;
            }

            /// <summary>
            /// Renders the specified environmental information and appends it to the specified <see cref="T:System.Text.StringBuilder"/>.
            /// </summary>
            /// <param name="builder">The <see cref="T:System.Text.StringBuilder"/> to append the rendered data to.
            /// </param><param name="logEvent">Logging event.</param>
            protected override void Append(StringBuilder builder, LogEventInfo logEvent)
            {
                builder.Append(ApplyPadding(ConfigurationManager.AppSettings[AppValue]));
            }

            #endregion
        }
    }
}
