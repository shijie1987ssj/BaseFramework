using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrameWork.Utility.ConvertTools
{
    public class ConvertHelper
    {
        /// <summary>
        /// 将String转为Int
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int StringToInt(string s)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(s);
            }
            catch
            {}
            return i;
        }

        /// <summary>
        /// 将String转为GUID
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Guid StringToGUID(string s)
        {
            Guid i;
            try
            {
                i = Guid.Parse(s);
            }
            catch
            { 
                i = Guid.Empty; 
            }
            return i;
        }
    }
}
