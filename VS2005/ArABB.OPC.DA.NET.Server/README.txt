------------------------------
ArABB OPC.NET Da Server README
------------------------------

Esta solucion muestra como implementar un servidor OPC DA en .NET. Consta de dos grandes partes:

OPC.DA.Server.Wrapped
---------------------

Aplicacion realizada en C++ que implementa las interfaces DCOM de OPC DA. Este ejecutable es solo
una cascara (Wrapper) que envuelve e invoca los metodos de Assemblies .NET.

OPC.NET.DA.Server
----------------

Libreria COM visible que es utilizada por el Wrapper. Aqui se escribe codigo custom .NET para el OPC.

Ademas cuenta con un tool que permite registrar el OPC Server en un PC.

Ejemplo implementado:
---------------------

La clase "Opc.Da.Device.cs" que muestra un ejemplo de como cambiar el valor de los tags.

La definicion de los tags OPC son configurados en el archivo "ArABB.OPC.DA.Server.device.xml".


Registracion del Servidor:
--------------------------

1 - Registar el COM de C++:

Ejecutar el comando: ArABB.OPC.DA.Server.exe /regserver

SubFolder: ArABB.OPC.DA.NET.Server\OPC.DA.Server.Wrapped\ArABB.OPC.DA.Sever\Debug>

2 - Registrar El Ensabldo .NET para que sea COM Visible:

Ejecutar por LINEA DE COMANDO en el folder del tool:

Opc.ConfigTool.exe -ra "e:\PROGRAMACION\Code.Google\trunk\VS2005\ArABB.OPC.DA.NET.Server\OPC.NET.DA.Server\ArABB.OPC.NET.DA.Server\bin\Debug\OpcDaSampleServer.dll"

Nota: Cambiar el path hacia la DLL de .NET segun sea necesario.

3 - Registrar el OPC Server:

usar Opc.ConfigTool.exe -> menu -> register opc server el clasid, escricir el valor 

1437DC7F-D66E-4AA3-BA79-2CD0A4A6F3D8

este valor esta tomado del archivo: "ArABB.OPC.DA.Server.config.xml"