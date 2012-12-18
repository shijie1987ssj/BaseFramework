using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseFrameWork.Utility.DataTools;
using BaseFrameWork.Utility.CharTools;
using BaseFrameWork.BaseSeesion;
using BaseFrameWork.Modle;

namespace BaseFrameWork.UI.BaseWinframeProject
{
    public partial class FrmIndex : Form
    {
        public FrmIndex()
        {
            InitializeComponent();

            initPage();
        }
        
        private void initPage()
        {
            InitMenuItem();
        }

        private void InitMenuItem()
        { 
             List<BaseMenu> mList = BaseSeesionInfo.GetMenu();
            foreach (BaseMenu bm in mList)
            { 
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name =bm.Gid.ToString(); //menuname
                item.Text = bm.FName;
                item.Tag = bm.Gid;
                //menuStrip2.Items[item.Name].Enabled = false;
                //InitSubMenuItem(menuStrip2.Items[item.Name]);
            } 
        }

        //初始化一级菜单的所有子菜单
        private void InitSubMenuItem(ToolStripItem item)
        {
            string mname = item.Name;
            ToolStripMenuItem pItem = (ToolStripMenuItem)item;
            //根据父菜单项加载子菜单
            string sql = "select * from tb_menu where fmuname ='" + mname + "'";
            //DataTable dt = GetTableBySql(sql);
            //if (dt.Rows.Count != 0)
            //{
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        ToolStripMenuItem subItem = new ToolStripMenuItem();
            //        subItem.Name = dr[3].ToString();
            //        try
            //        {
            //            pItem.DropDownItems[subItem.Name].Enabled = false;
            //        }
            //        catch (Exception e)
            //        {
            //            MessageBox.Show(e.Message);
            //        }
            //    }
            //}
        }

        #region 测试
        //            string s =  Cryptography.DESEncrypt("Data Source=192.168.114.4;Initial Catalog=tst_c21_imp_meta;User ID=sa;Password=c21access;Persist Security Info=True", "woshissj");

        //            //+Uw9NwRJcR7zmMFYqmmygloSzFtJL3xQYuCD7pZTSb5/bePuFlCO2n6MibT9ckU6t9Zb0ejhpvxljWSKVUf5msxkkRZrHUiDIJ/38jEdVtyRUKUrSueFEoxj0ZWhyPFJqTTSN7SAQxz/bdkEKiWAHPlu1l+dZISo
        //            //+Uw9NwRJcR7zmMFYqmmygloSzFtJL3xQYuCD7pZTSb5/bePuFlCO2n6MibT9ckU6/qL4Q6tVDoD4shx31cLfzITsjnF0AItgVpUp1He60lNbiBfaCexlHXhR4Yh7WFSkHuS4Wn9QAaS3z7O8hRWiga3CArusoNoO

        //            string s1 =  @"SELECT     Gid, ParentId, FName, FDescription, FAssembly, FTypeName, FFunctionType, MethodType, MethodName, ImageAlign, ImageResourceAssembly, 
        //                      ImageResourceName, PathId, OrderBy, IsActive
        //FROM         u_Function_Summary AS ufs";

        //            DataSet ds = new DataSet();
        //            DataTable dt = DbHelperSQL.Query(s1).Tables[0].Copy();
        //            dt.TableName = "u_Function_Summary";
        //            ds.Tables.Add(dt);

        //            s1 = @"SELECT     DBName, DBHash, DBProvider, ConnStr, IsActive, Descript
        //FROM         s_connect_details1 AS scd";
        //            DataTable dt1 = DbHelperSQL.Query(s1).Tables[0].Copy();
        //            dt1.TableName = "s_connect_details";
        //            ds.Tables.Add(dt1);

        //            ds.WriteXml("initConfissssssssg.xml");
        #endregion
    }
}
