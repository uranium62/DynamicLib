using System;

namespace DynamicLib.Parser
{
    /// <summary>
    /// Class ParseException
    /// </summary>
    public sealed class DynamicParseException : Exception
    {
        /// <summary>
        /// The position.
        /// </summary>
        int position;

        /// <summary>
        /// Gets the position
        /// </summary>
        public int Position
        {
            get { return position; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicParseException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="position">The position.</param>
        public DynamicParseException(string message, int position) : base(message)
        {
            this.position = position;
        }

        /// <summary>
        /// Returns a string that represents this instance.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(DynamicMessages.ParseExceptionFormat, Message, position);
        }
    }
}
