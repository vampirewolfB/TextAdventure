using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBase_Adventure.Utility
{
    internal class WindowUtillity
    {
        // Utillity tool to adjust the window size.
        internal static void SetWindow(int width, int height)
        {
            try
            {
                Console.SetWindowSize(width, height);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                throw;
            }
        }
    }
}
