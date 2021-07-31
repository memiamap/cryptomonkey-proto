using System;

namespace MPL.CryptoMonkey.ProtoApp
{
    /// <summary>
    /// An interface that defines an output interface for the CryptoMonkey application.
    /// </summary>
    public interface IOutputInterface
    {
        /// <summary>
        /// Clears the current output from the interface.
        /// </summary>
        void Clear();

        /// <summary>
        /// Reads a key from the interface.
        /// </summary>
        /// <returns>A char containing the key that was read.</returns>
        char ReadKey();

        /// <summary>
        /// Reads a line from the interface.
        /// </summary>
        /// <param name="includeNewline">A bool indicating whether to include the newline in the read line.</param>
        /// <returns>A string containing the line that was read.</returns>
        string ReadLine(bool includeNewline = false);

        /// <summary>
        /// Writes the specified output to the interface.
        /// </summary>
        /// <param name="output">A string containing the output to write.</param>
        void Write(string output);

        /// <summary>
        /// Writes the specified output to the interface, forcing a newline at the end.
        /// </summary>
        /// <param name="output">A string containing the output to write.</param>
        void WriteLine(string output);
    }
}