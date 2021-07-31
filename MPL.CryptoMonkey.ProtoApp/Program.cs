using System;

namespace MPL.CryptoMonkey.ProtoApp
{
    /// <summary>
    /// A class that defines the entry point for the program.
    /// </summary>
    internal class Program
    {
        #region Methods
        #region _Public_
        public static void Main(string[] args)
        {
            CryptoMonkeyApp app = new(new ConsoleInterface());
            app.Start();
        }

        #endregion
        #endregion
    }
}