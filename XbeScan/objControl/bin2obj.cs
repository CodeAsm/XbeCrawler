using System.IO;

namespace objControl
{
    public class bin2Obj
    {
        /// <summary>
        /// Demo function, multiply x with y.
        /// TODO: remove after basic functions added
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static long Multiply(long x, long y)
        {
            return (x * y);
        }

        public static byte[] getByteFullArray(Stream input) {
            ///http://www.yoda.arachsys.com/csharp/readbinary.html
            /// http://stackoverflow.com/questions/221925/creating-a-byte-array-from-a-stream
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}
