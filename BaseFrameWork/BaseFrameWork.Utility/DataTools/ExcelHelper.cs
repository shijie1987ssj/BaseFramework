using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Web;

namespace BaseFrameWork.Utility.DataTools
{
   public static class ExcelHelper
    {

        /// <summary> 
        /// 读取Excel文档 
        /// </summary> 
        /// <param name="Path">文件名称</param> 
        /// <returns>返回一个数据集</returns> 
        public static DataSet ExcelToDS(string Path)
        {
            DataSet ds = null;
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Path + ";" + "Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string strExcel = "";
            OleDbDataAdapter myCommand = null;
            DataTable dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" });
            //包含excel中表名的字符串数组
            string[] strTableNames = new string[dtSheetName.Rows.Count];
            for (int k = 0; k < dtSheetName.Rows.Count; k++)
            {
                strTableNames[k] = dtSheetName.Rows[k]["TABLE_NAME"].ToString();
            }
            strExcel = "select * from [" + strTableNames[0] + "]";
            myCommand = new OleDbDataAdapter(strExcel, strConn);
            ds = new DataSet();
            myCommand.Fill(ds, "table1");
            conn.Close();
            return ds;
        }

        /// <summary> 
        /// 写入Excel文档 
        /// </summary> 
        /// <param name="Path">文件名称</param> 
        public static bool SaveFP2toExcel(string Path)
        {
            /*try
            {
                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Path + ";" + "Extended Properties=Excel 8.0;";
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                System.Data.OleDb.OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                //cmd.CommandText ="UPDATE [sheet1$] SET 姓名='2005-01-01' WHERE 工号='日期'"; 
                //cmd.ExecuteNonQuery (); 
                for (int i = 0; i < fp2.Sheets[0].RowCount - 1; i++)
                {
                    if (fp2.Sheets[0].Cells[i, 0].Text != "")
                    {
                        cmd.CommandText = "INSERT INTO [sheet1$] (工号,姓名,部门,职务,日期,时间) VALUES('" + fp2.Sheets[0].Cells[i, 0].Text + "','" +
                        fp2.Sheets[0].Cells[i, 1].Text + "','" + fp2.Sheets[0].Cells[i, 2].Text + "','" + fp2.Sheets[0].Cells[i, 3].Text +
                        "','" + fp2.Sheets[0].Cells[i, 4].Text + "','" + fp2.Sheets[0].Cells[i, 5].Text + "')";
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
                return true;
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                System.Diagnostics.Debug.WriteLine("写入Excel发生错误：" + ex.Message);
            }*/
            return false;
        }
       /// <summary>
       /// 输入至Excel文件
       /// </summary>
       /// <param name="dt"></param>
       /// <param name="FileName"></param>
        public static void CreateExcel(DataTable dt, string FileName)
        {
            //HttpResponse resp = HttpContext.Current.Response;
            //resp.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
            //resp.AppendHeader("Content-Disposition", "attachment;filename=" + FileName + ".xls");
            //string colHeaders = string.Empty;
            //string ls_item = string.Empty;
            //DataRow[] myRow = dt.Select();
            //int cl = dt.Columns.Count;
            //for (int i = 0; i < cl; i++)
            //{
            //    if (i == cl - 1)
            //    {
            //        colHeaders += dt.Columns[i].Caption.ToString() + "\n";
            //    }
            //    else
            //    {
            //        colHeaders += dt.Columns[i].Caption.ToString() + "\t";
            //    }
            //}
            //resp.Write(colHeaders);

            //foreach (DataRow dr in myRow)
            //{
            //    for (int j = 0; j < cl; j++)
            //    {
            //        if (j == cl - 1)
            //        {
            //            ls_item += dr[j].ToString() + "\n";
            //        }
            //        else
            //        {
            //            ls_item += dr[j].ToString() + "\t";
            //        }
            //    }
            //}
            //resp.Write(ls_item);
            //ls_item = string.Empty;
            //resp.End();
        }
    }
}
