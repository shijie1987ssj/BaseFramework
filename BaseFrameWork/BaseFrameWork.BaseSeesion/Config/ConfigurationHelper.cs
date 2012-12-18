using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BaseFrameWork.Utility.DataTools; 
using BaseFrameWork.Modle;

namespace BaseFrameWork.BaseSeesion
{
    public class ConfigurationHelper
    {
        private static string xmlAddress = "Resource\\initConfig.xml";

        /// <summary>
        /// 获取菜单
        /// </summary> 
        /// <returns></returns>
        public static List<BaseMenu> GetMenuList()
        {
            List<BaseMenu> list = new List<BaseMenu>();
            DataTable dt = DataSetHelper.GetXmlDataSetTable("u_Function_Summary", xmlAddress);
            if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = " IsActive = 1";
                foreach (DataRow dr in dv.ToTable().Rows)
                {
                    BaseMenu m = new BaseMenu(dr);
                    list.Add(m);
                }
            }
            return list;
        } 
    }
}
