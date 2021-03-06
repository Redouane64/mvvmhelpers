using System.IO;
using Windows.Storage.Streams;

namespace JulMar.IO
{
    /// <summary>
    /// Extension methods for streams
    /// </summary>
    public static class StreamExtensions
    {
        /// <summary>
        /// Returns an IRandomAccessStream for a given stream input
        /// </summary>
        /// <param name="stream">Stream to wrap</param>
        /// <returns>WinRT RandomAccessStream</returns>
        public static IRandomAccessStream AsRandomAccessStream(this Stream stream)
        {
            return new RandomAccessStream(stream);
        }
    }
}