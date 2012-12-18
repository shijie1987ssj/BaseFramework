using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BaseFrameWork.Utility.DataTools
{
    public class DataSetHelper
    {  
        /// <summary>
        /// 获取XML数据中的数据表
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="xmlAddress">XML地址（例如“D:\files\test.xml”）</param>
        /// <returns></returns>
        public static DataTable GetXmlDataSetTable(string tableName, string xmlAddress)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(xmlAddress);
            return ds.Tables[tableName];
        }

        /// <summary>
        /// 判断Dataset指定表是否包括数据
        /// </summary>
        /// <param name="ds">Dataset</param>
        /// <param name="tableName">表名</param>
        /// <returns></returns>
        public static bool isHaveRow(DataSet ds, string tableName)
        {
            if (ds != null && ds.Tables != null && ds.Tables[tableName] != null && ds.Tables[tableName].Rows != null && ds.Tables[tableName].Rows.Count > 0) 
                return true; 
            else
                return false;
        } 
    }
}
