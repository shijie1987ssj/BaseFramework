using System;
using System.Configuration;
namespace BaseFrameWork.Utility.DataTools
{
    
    public class PubConstant
    {
        private static string key = "woshissj";
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnectionString
        {           
            get 
            {
                string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];       
                string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
                if (ConStringEncrypt == "true")
                {
                    _connectionString =CharTools.Cryptography.DESDecrypt(_connectionString,key);
                }
                if (_connectionString == "")
                { 
                    //为空的时候，从conn.xml文件中提取
                }
                return _connectionString; 
            }
        }

        /// <summary>
        /// 得到web.config里配置项的数据库连接字符串。
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                connectionString = CharTools.Cryptography.DESDecrypt(connectionString, key);
            }
            return connectionString;
        }


    }
}
