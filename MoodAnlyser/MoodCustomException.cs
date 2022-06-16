using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnlyser
{
    class MoodCustomException:Exception
    {
        /// <summary>
        /// Enum for Exception type
        /// </summary>
        public enum ExpType
        {
            Empty_Message, Null_Message
        }
        public readonly ExpType type;
        /// <summary>
        /// Parameterized Constructor sets the exception type and message
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public MoodCustomException(ExpType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
