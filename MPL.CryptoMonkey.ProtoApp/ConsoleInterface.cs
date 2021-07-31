using System;

namespace MPL.CryptoMonkey.ProtoApp
{
    /// <summary>
    /// A class that defines the console interface to the application.
    /// </summary>
    internal class ConsoleInterface : IOutputInterface
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        internal ConsoleInterface()
        {
            _newLine = Environment.NewLine;
        }

        #endregion

        #region Declarations
        #region _Members_
        private readonly string _newLine;

        #endregion
        #endregion

        #region Interfaces
        #region _IOutputInterface_
        void IOutputInterface.Clear()
        {
            Console.Clear();
        }

        char IOutputInterface.ReadKey()
        {
            return Console.ReadKey().KeyChar;
        }

        string IOutputInterface.ReadLine(bool includeNewline)
        {
            string? returnValue;

            returnValue = Console.ReadLine();
            if (includeNewline && !returnValue.EndsWith(_newLine))
                returnValue += _newLine;

            return returnValue;
        }

        void IOutputInterface.Write(string output)
        {
            Console.Write(output);
        }

        void IOutputInterface.WriteLine(string output)
        {
            Console.WriteLine(output);
        }

        #endregion
        #endregion
    }
}