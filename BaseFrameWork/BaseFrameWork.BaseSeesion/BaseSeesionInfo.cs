using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseFrameWork.Modle;
using System.Runtime.Caching;

namespace BaseFrameWork.BaseSeesion
{
    public class BaseSeesionInfo
    {
        public static List<BaseMenu> GetMenu()
        {
            List<BaseMenu> mlist = new List<BaseMenu>();
            ObjectCache cache = MemoryCache.Default;
            mlist = cache["menuLists"] as List<BaseMenu>;
            if (mlist == null)
            {
                mlist = ConfigurationHelper.GetMenuList();

                CacheItemPolicy policy = new CacheItemPolicy();
                
                List<string> filePaths = new List<string>();
                string cachedFilePath = AppDomain.CurrentDomain.BaseDirectory +
                    "\\Cache\\cacheText.txt";
                filePaths.Add(cachedFilePath); 

                policy.ChangeMonitors.Add(new
                    HostFileChangeMonitor(filePaths));

                cache.Set("menuLists", mlist, policy);
            }
            return mlist;
        }
    }
}
