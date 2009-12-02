// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExceptionRemotas.cs" company="Say No More">
//   2009
// </copyright>
// <summary>
//   Excepcion remota
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RemotingObject
{
    using System.Runtime.Remoting;
    using System.Runtime.Serialization;

    /// <summary>
    /// Excepcion remota
    /// </summary>
    public class CustomRemotableException : RemotingException, ISerializable
    {
    }
}
