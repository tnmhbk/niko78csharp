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
    using System;
    using System.Runtime.Remoting;
    using System.Runtime.Serialization;

    /// <summary>
    /// Excepcion remota
    /// </summary>
    [Serializable]
    public class CustomRemotableException : RemotingException
    {
        /// <summary>
        /// Mensade de la ex.
        /// </summary>
        private readonly string _internalMessage;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRemotableException"/> class.
        /// </summary>
        /// <param name="info">The info of ex.</param>
        /// <param name="context">The context.</param>
        public CustomRemotableException(SerializationInfo info, StreamingContext context)
        {
            _internalMessage = (string)info.GetValue("_internalMessage", typeof(string));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRemotableException"/> class.
        /// </summary>
        public CustomRemotableException()
        {
            _internalMessage = String.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRemotableException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public CustomRemotableException(string message)
        {
            _internalMessage = message;
        }

        /// <summary>
        /// Gets Message information.
        /// </summary>
        public override string Message
        {
            get
            {
                return _internalMessage;
            }
        }

        /// <summary>
        /// When overridden in a derived class, sets the <see cref="T:System.Runtime.Serialization.SerializationInfo"/> with information about the exception.
        /// </summary>
        /// <param name="info">The info of exception.</param>
        /// <param name="context">The context.</param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("_internalMessage", _internalMessage);
        }
    }
}
