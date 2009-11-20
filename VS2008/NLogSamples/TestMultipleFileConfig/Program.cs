/*
 * Uso de NLog con archivo de configuracion.
 * IMPORTANTE: Copiar el archivo Nlog.xsd a al carpeta
 * c:\Archivos de programa\Microsoft Visual Studio 8\Xml\Schemas\
 * despues reiniciar el Visual Studio y el intelisence nos ayudara a 
 * completar los tags xml dentro del XML o App.config
 */
using NLog;

namespace TestMultipleFileConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = LogManager.GetLogger("Logger1");
            Logger logger2 = LogManager.GetLogger("Logger2");

            for (int i = 0; i < 1000; i++)
            {
                logger1.Debug("Archivo de salida 1: " + i.ToString("000"));
                logger2.Debug("Archivo de salida 2: " + i.ToString("000"));
            }
        }
    }
}
