using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BaseFrameWork.Utility.ConvertTools;

namespace BaseFrameWork.Modle
{
    [Serializable]
    public class BaseMenu
    {
        public BaseMenu() { }

        public BaseMenu(DataRow dr)
        {
            try
            {
                //判断最主要的项目不能为空（ID和名称）
                if (dr["Gid"] == null) return;
                if (dr["FName"] == null) return;

                this.Gid = ConvertHelper.StringToGUID(dr["Gid"].ToString());

                //如果内容不对，返回空值
                if (this.Gid == Guid.Empty) return;

                this.FName = dr["FName"].ToString();

                if (dr["ParentId"] != null)
                    this.ParentId = ConvertHelper.StringToGUID(dr["ParentId"].ToString());
                if (dr["FDescription"] != null)
                    this.FDescription = dr["FDescription"].ToString();
                if (dr["FAssembly"] != null)
                    this.FAssembly = dr["FAssembly"].ToString();
                if (dr["FTypeName"] != null)
                    this.FTypeName = dr["FTypeName"].ToString();
                if (dr["FFunctionType"] != null)
                    this.FFunctionType = ConvertHelper.StringToInt(dr["FFunctionType"].ToString());
                if (dr["MethodType"] != null)
                    this.MethodType = ConvertHelper.StringToInt(dr["MethodType"].ToString());
                if (dr["MethodName"] != null)
                    this.MethodName = dr["MethodName"].ToString();
                if (dr["ImageAlign"] != null)
                    this.ImageAlign = ConvertHelper.StringToInt(dr["ImageAlign"].ToString());
                if (dr["ImageResourceAssembly"] != null)
                    this.ImageResourceAssembly = dr["ImageResourceAssembly"].ToString();
                if (dr["ImageResourceName"] != null)
                    this.ImageResourceName = dr["ImageResourceName"].ToString();
                if (dr["PathId"] != null)
                    this.PathId = dr["PathId"].ToString();
                if (dr["OrderBy"] != null)
                    this.OrderBy = ConvertHelper.StringToInt(dr["OrderBy"].ToString());
                if (dr["IsActive"] != null)
                    this.IsActive = ConvertHelper.StringToInt(dr["IsActive"].ToString());
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// 菜单ID
        /// </summary> 
        public Guid Gid { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary> 
        public string FName { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary> 
        public Guid ParentId { get; set; } 

        /// <summary>
        /// 详细介绍
        /// </summary> 
        public string FDescription { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary> 
        public string FAssembly { get; set; }

        /// <summary>
        /// 模块DLL名称
        /// </summary> 
        public string FTypeName { get; set; }

        /// <summary>
        /// 菜单类型
        /// </summary> 
        public int FFunctionType { get; set; }

        /// <summary>
        /// 函数类型
        /// </summary> 
        public int MethodType { get; set; }

        /// <summary>
        /// 函数名称
        /// </summary> 
        public string MethodName { get; set; }

        /// <summary>
        /// 图片属性
        /// </summary> 
        public int ImageAlign { get; set; }

        /// <summary>
        /// 图片资源信息
        /// </summary> 
        public string ImageResourceAssembly { get; set; }

        /// <summary>
        /// 图片资源名称
        /// </summary> 
        public string ImageResourceName { get; set; }

        /// <summary>
        /// XML地址
        /// </summary> 
        public string PathId { get; set; }

        /// <summary>
        /// 排序
        /// </summary> 
        public int OrderBy { get; set; }

        /// <summary>
        /// 是否在用
        /// </summary> 
        public int IsActive { get; set; }
    }
}
