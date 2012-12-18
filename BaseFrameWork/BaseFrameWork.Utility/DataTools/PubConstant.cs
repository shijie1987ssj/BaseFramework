using System;
using System.Configuration;
namespace BaseFrameWork.Utility.DataTools
{
    
    public class PubConstant
    {
        private static string key = "woshissj";
        /// <summary>
        /// ��ȡ�����ַ���
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
                    //Ϊ�յ�ʱ�򣬴�conn.xml�ļ�����ȡ
                }
                return _connectionString; 
            }
        }

        /// <summary>
        /// �õ�web.config������������ݿ������ַ�����
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
