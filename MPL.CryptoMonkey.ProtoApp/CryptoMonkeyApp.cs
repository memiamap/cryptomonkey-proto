using System;
using System.Linq;

namespace MPL.CryptoMonkey.ProtoApp
{
    /// <summary>
    /// A class that defines the CryptoMonkey application.
    /// </summary>
    internal class CryptoMonkeyApp : IOutputInterface
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of the class with the specified parameters.
        /// </summary>
        /// <param name="outputInterface">An IOutputInterface that is the output interface to use.</param>
        internal CryptoMonkeyApp(IOutputInterface outputInterface)
            : this(new[] { outputInterface })
        { }

        /// <summary>
        /// Creates a new instance of the class with the specified parameters.
        /// </summary>
        /// <param name="outputInterfaces">An array of IOutputInterface containing the output interfaces to use.</param>
        internal CryptoMonkeyApp(IOutputInterface[] outputInterfaces)
        {
            if (outputInterfaces != null)
            {
                if (outputInterfaces.Length > 0)
                {
                    _outputInterfaces = outputInterfaces;
                }
                else
                    throw new ArgumentException("No output interfaces were specified", nameof(outputInterfaces));
            }
            else
                throw new ArgumentNullException(nameof(outputInterfaces));

            _outputInterface = this;
        }

        #endregion

        #region Declarations
        #region _Members_
        private readonly IOutputInterface _outputInterface;
        private readonly IOutputInterface[] _outputInterfaces;

        #endregion
        #endregion

        #region Methods
        #region _Internal_
        /// <summary>
        /// Starts the CryptoMonkey Application.
        /// </summary>
        internal void Start()
        {
            _outputInterface.Clear();
            _outputInterface.WriteLine("CryptoMonkey Prototype App");
            _outputInterface.WriteLine("v0.1A 31/07/2021");
            _outputInterface.WriteLine("Copyright (c)2009-2021 Martin Parkin.  All Rights Reserved");
            _outputInterface.WriteLine("");
            char s = _outputInterface.ReadKey();
            _outputInterface.WriteLine($"{s}");

        }

        #endregion
        #region _Private_
        private void ExecuteOnOutputInterfaces(Action<IOutputInterface> action)
        {
            foreach (IOutputInterface outputInterface in _outputInterfaces)
                action(outputInterface);
        }

        #endregion
        #endregion

        #region Interfaces
        #region _IOutputInterface_
        void IOutputInterface.Clear()
        {
            ExecuteOnOutputInterfaces((outputInterface) => outputInterface.Clear());
        }

        char IOutputInterface.ReadKey()
        {
            return _outputInterfaces[0].ReadKey();
        }

        string IOutputInterface.ReadLine(bool includeNewline)
        {
            return _outputInterfaces[0].ReadLine();
        }

        void IOutputInterface.Write(string output)
        {
            ExecuteOnOutputInterfaces((outputInterface) => outputInterface.Write(output));
        }

        void IOutputInterface.WriteLine(string output)
        {
            ExecuteOnOutputInterfaces((outputInterface) => outputInterface.WriteLine(output));
        }

        #endregion
        #endregion
    }
}