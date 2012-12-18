using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace BaseFrameWork.Utility.CharTools
{
    public static class StringHelper
    {

        /// <summary>
        /// 按字节数截取字符串(后面加省略号...)
        /// </summary>
        /// <param name="origStr">原始字符串</param>
        /// <param name="endIndex">提取前endIdex个字节</param>
        /// <returns></returns>	
        public static string GetSubString(string origStr, int endIndex)
        {
            if (origStr == null || origStr.Length == 0 || endIndex < 0)
                return "";
            int bytesCount = System.Text.Encoding.GetEncoding("gb2312").GetByteCount(origStr);
            if (bytesCount > endIndex)
            {
                int readyLength = 0;
                int byteLength;
                for (int i = 0; i < origStr.Length; i++)
                {
                    byteLength = System.Text.Encoding.GetEncoding("gb2312").GetByteCount(new char[] { origStr[i] });
                    readyLength += byteLength;
                    if (readyLength == endIndex)
                    {
                        origStr = origStr.Substring(0, i + 1) + "...";
                        break;
                    }
                    else if (readyLength > endIndex)
                    {
                        origStr = origStr.Substring(0, i) + "...";
                        break;
                    }
                }
            }
            return origStr;
        }
        /// <summary>
        /// 按字节数截取字符串(不带省略号)
        /// </summary>
        /// <param name="origStr">原始字符串</param>
        /// <param name="endIndex">提取前endIdex个字节</param>
        /// <returns></returns>	
        public static string GetSub1String(string origStr, int endIndex)
        {
            if (origStr == null || origStr.Length == 0 || endIndex < 0)
                return "";
            int bytesCount = System.Text.Encoding.GetEncoding("gb2312").GetByteCount(origStr);
            if (bytesCount > endIndex)
            {
                int readyLength = 0;
                int byteLength;
                for (int i = 0; i < origStr.Length; i++)
                {
                    byteLength = System.Text.Encoding.GetEncoding("gb2312").GetByteCount(new char[] { origStr[i] });
                    readyLength += byteLength;
                    if (readyLength == endIndex)
                    {
                        origStr = origStr.Substring(0, i + 1);
                        break;
                    }
                    else if (readyLength > endIndex)
                    {
                        origStr = origStr.Substring(0, i);
                        break;
                    }
                }
            }
            return origStr;
        }
        /// <summary>
        /// 非法关键字过滤
        /// </summary>
        /// <param name="origStr">原始字符串</param>
        /// <returns></returns>	
        public static bool Getisfeifa(string origStr)
        {
            if (origStr == null || origStr.Length == 0)
                return false;
            bool fh = false;
            //涉军
            string[] names = new string[] { "复员军官", "93.1政策", "自主择业军官", "3号文件", "自主择业人员", "退伍军人", "中越自卫反击战", "校级复员军官", "（2001）3号", "政联字1号文件", "一军两策", "复员军官诉求书", "公开信", "复员军官代表", "唐山大地震老伤兵", "企业军转干部", "8023部队", "答复口径", "一个身份、两个待遇", "企转组[2006]1号文件", "[1998]7号文件", "单春", "天网", "上访", "军转干部单春" };
            //法轮功
            string[] names1 = new string[] { "保钓联合会", "军委公开信", "功学员", "器官", "党保平安", "九评传", "保平安", "陆士绅", "天灭中", "天要灭中", "青帮误国", "同修交流", "正法修炼", "突破网络", "封锁", "新三才", "新唐", "神韵晚会", "退出共产", "邪党", "余传琮", "温家", "天要灭中共", "退党保平安", "新唐人电视台", "邪教", "争鸣杂志", "超越红墙", "打倒共铲党", "共铲党", "没有共铲党", "你退了吗", "引发全球", "真腐败", "人民报消息-越南", "退出共党保平安", "引发全球退党大潮", "中共独裁" };
            //涉恐
            string[] names2 = new string[] { "恐怖主义", "袭击", "恐怖袭击", "自杀式爆炸", "汽车炸弹", "引爆", "制作炸药", "圣战", "十字军", "宗教极端主义", "原教旨主义", "基地", "塔利班", "本拉登", "达杜拉", "扎瓦赫里", "萨哈卜", "911", "炭疽病毒", "伊斯兰运动", "伊斯兰军", "伊斯兰马格里布基地组织", "伊拉克伊斯兰国", "伊斯兰解放组织", "穆斯林兄弟会", "真主党", "伊斯兰团", "东突", "东突伊斯兰运动", "东伊运", "热比娅", "世界维吾尔代表大会", "世维会", "东土耳其斯坦信息中心", "东突联盟", "东突厥斯坦", "伊斯兰运动", "东突厥斯坦民族革命阵线", "吾吉买买提", "阿巴斯", "西尔艾力" };
            //教师学生类
            string[] names3 = new string[] { "罢餐", "维权", "代考", "泄题", "示威", "游行", "静坐", "罢课", "罢考", "抗议", "公开信" };
            //涉枪、涉爆
            string[] names4 = new string[] { "原子弹", "恐怖分子", "炸药", "土制C4", "土制c4", "炸弹", "弹药", "枪", "麻醉", "军用" };
            //涉台
            string[] names5 = new string[] { "台湾独立", "马英九", "陈水扁", "国民党", "民进党", "泛蓝", "泛绿", "公投", "蓝营", "绿营", "抹黑", "抹红", "入联", "大选", "独派", "台军", "立委", "吕秀莲", "谢长廷", "台商", "台海危机", "国语运动", "连战", "机要费", "倒扁", "马营", "国民大会", "国民大会", "总统府", "行政院", "立法院", "司法院", "考试院", "监察院", "左营海军军官学校", "冈山空军官学校", "风山陆军军官学校", "工蜂六型多管火箭系统", "天剑二型飞弹", "天剑一型飞弹", "宪兵司令部", "联合后", "勤司领部", "参谋本部", "国防部", "彭湖", "台北", "台中", "台南", "竹联帮", "四海帮", "牛埔帮", "大湖帮", "十三兄弟帮", "七贤帮", "西北帮", "十二煞星帮", "铁鹰帮竹林联盟", "台湾间谍", "统独光谱", "二二八事件", "台独党纲", "台独党", "立法委员" };
            //攻击领导人
            string[] names6 = new string[] { "老江", "胡温", "胡瘟", "瘟家", "温夫人", "温公子", "胡公子", "温宝宝", "温云松", "胡海峰", "江家帮", "太子党", "江系", "胡系", "江派", "江胡", "胡主席", "温总理", "胡总书记", "团派", "红色贵族", "人马", "中共", "北京帮", "共铲党", "共残党", "共惨党", "共chan党", "ZF", "GD", "权斗", "人事", "腐败", "珠宝", "内斗", "布局", "和谐", "引咎辞职", "公开信", "请愿书", "权力分配", "胡紧套", "胡紧掏", "瘟家鸨", "瘟假鸨", "胡锦涛", "陶驷驹", "手段极为老辣", "周永康", "王小丫老公", "胡紧掏", "温加饱", "无帮国", "无官正", "胡紧掏", "温加饱", "胡紧掏", "温假饱", "胡紧套", "温加饱", "毛贼东", "毛厕洞", "毛厕东" };
            //民运、自由化
            string[] names7 = new string[] { "民运", "天安门", "学潮", "动乱", "毛泽东", "人权", "左派", "右派", "党禁", "言禁", "独裁", "报禁", "屠杀", "示威", "罢工", "静坐", "罢课", "公开信", "选举", "思潮", "请愿书", "意志", "民主党", "共和", "民权", "三民主义", "言论自由", "中共", "反右运动", "文革", "王丹", "吾尔凯西", "柴玲", "镇压", "白色恐怖", "五毛", "愤青", "fq", "宪政", "专制", "统治", "基国", "ZF", "推翻", "打倒", "丁子霖", "致信胡温", "人权圣火", "停止迫害", "维权人士", "杨春林", "丁子霖", "天安门", "富锦失地", "要人权", "高智晟", "致胡温", "公开信", "记者赵子法", "天网人权事务", "汪兆钧", "上书", "丁子霖", "中国革命党", "天网电子报" };
            //赌博
            string[] names8 = new string[] { "香港六合彩", "香港总彩", "六合采", "六和采", "香港赛马会", "香港白小姐", "香港惠泽社群", "香港曾道人", "香港黄大仙", "码中特", "六合彩", "白小姐", "曾道人", "天线宝宝", "liuhecai", "六合彩券", "六星合彩", "香港六星合彩", "六星合彩公司", "六合菜", "一字解特码", "报码聊天", "6合彩", "香港6合彩", "香港6合彩公司", "最快报码室", "码报", "马报", "香港彩票", "香港六合彩公司", "本期6合彩开奖结果", "六合彩美女图库", "惠澤社群", "猪哥6合网中国网址联盟", "香港彩宝必中六肖" };
            //维权类
            string[] names9 = new string[] { "就业歧视", "乙肝携带者", "乙肝NGO工作者", "金戈铁马", "乙肝歧视", "hbv", "乙肝维权", "乙肝战友", "1.3亿", "集体签名", "游行", "上访", "小阳", "乙肝检测", "乙肝筛选", "非法拆毁", "合法财产", "勾结奸商", "强拆当地居民房", "暴力拆迁", "非法征用", "霸占土地", "买断工龄", "买断职工", "找农总行", "找建总行", "找工总行", "代办员", "遗留问题", "业主维权", "侵害业主正当权益", "违反购房合同", "征集业主意见", "散散步", "联合签名", "抵制变电站", "反对磁悬浮" };
            //涉日
            string[] names10 = new string[] { "出海", "保钓", "游行", "示威", "钓鱼岛", "中国民间保钓联合会", "爱国者同盟", "中华抗日同盟", "李义强", "王锦思", "冯锦华", "童增" };
            //奥运安保
            string[] names11 = new string[] { "爆炸", "恐怖", "袭击", "火炬", "福娃", "抵制", "抗议", "反对", "人权", "自由", "民主", "财力物力" };
            //涉警
            string[] names12 = new string[] { "恶搞公安部领导", "兴化", "网吧实名制成为民警办案好帮手", "女警执行死刑", "四川仁寿警方冲击省人大抓上访者", "《公安机关处理邪教问题知识手册》", "借第二代身份证攻击我党和政府", "医院聘民警当副院长防医闹", "原湖北黄石民警吴幼明", "湖南省公安厅副厅长偷情酿血案", "充当涉毒场所保护伞", "警察不作为", "警察滥用职权", "警察特权", "罚款黑幕", "警察知法犯法", "警民冲突", "警察开枪", "黑恶势力保护伞" };
            //毒品
            string[] names13 = new string[] { "K粉", "冰毒", "麻古", "摇头丸", "出售", "配方", "迷药", "麻醉药", "K粉", "冰毒", "麻古", "氯胺酮", "海洛因", "cocain", "heroine", "制作工艺", "大麻", "幻药" };
            //网宿小覃补充
            string[] names14 = new string[] { "地磅解码器", "衡器解码器", "电子秤解码器", "电子称地磅解码器", "地磅解码仪", "衡器解码仪", "电子秤解码仪", "电子称地磅解码仪", "地磅遥控器", "衡器遥控器", "电子秤遥控器", "电子称地磅遥控器", "地磅控制器", "电子秤控制器", "电子称地磅控制器", "电表钥匙 ", "万能铅封  ", "电表节电器", "电表倒表器", "电表盗电器", "麻将遥控器", "加油机倒表器", "游戏机解码器", " IC卡解码器", "磁卡解码器", "磁卡复制器", " 磁卡解解密器", "银行卡解码器", "银行卡复制器", "银行卡解密器", "信用卡解码器", "信用卡复制器", "信用卡解密器", "制作工艺图", "有CT透视器", "汽车解码器", "地磅解码器.万能钥匙", "万能开锁器", "数字卫星电视接收器", "电表节电解码器", "光合显影药水", "防身药水", "电动车牌架", "挡牌器", "防盗车牌架", "电动车牌架生产厂家", "拉帘式车牌架", "看字专用摄像头", "肉毒素", "窃听器", "针孔/微型/看字/隐型摄象头", "监听器", "追踪器", "汽车翻牌器", "手机群发器", "隐型耳机", "套牌车", "枪支", "弹药", "仿真枪", "春药", "安眼药", "催情药", "香港水", "迷药", "冰毒", "摇头丸", "K粉", "海洛因", "冰毒制造方法", "代开发票", "代办证件", "调侃国家领导人", "打油诗", "公安机关/检查院具有侦察权", "律师具有调查取证权利", "私家侦探的行为是侵犯个人隐私的", "在大陆是违法的", "全中文遥控器拷贝机", "全中文遥控器拷贝机配套用遥控器", "汽车解码器", "汽车扫描仪", "汽车信号拦截器", "手机信号屏对码学习型遥控器", "感应卡拷贝机", "拷贝式感应卡", "门控主机", "手机信号屏蔽器" };
            //网上找的涉黄
            string[] names15 = new string[] { "性交", "乱交", "兽交", "FUCK", "性免费电影", "小电影", "黄色电影", "情色", "口交", "阴茎", "阴毛", "性虐待", "黄色网站", "成人网站", "成人小说", "成人文学", "成人电影", "成人影视", "黄色电影", "黄色影视", "黄色小说", "黄色文学", "成人图片", "黄色图片", "黄色漫画", "成人漫画", "成人电影", "三级片", "成人论坛", "鸡巴", "激情电影", "虐杀", "乱伦", "花花公子", "迷药", "迷幻药", "三唑", "迷奸", "换妻", "淫水", "应招", "女优", "强歼", "乱交", "色友", "婊子", "喷尿", "凌辱", "暴干", "阴唇", "坐交", "慰安妇", "猛插", "喷精", "偷窥", "小穴", "强暴", "精液", "幼交", "狂干", "兽交", "群交", "鸡巴", "阴茎", "阳具", "开苞", "肛门", "阴道", "阴蒂", "肉棍", "肉棒", "肉洞", "荡妇", "阴囊", "睾丸", "捅你", "捅我", "插我", "插你", "插她", "插他", "干你", "干她", "干他", "射精", "口交", "屁眼", "阴户", "阴门", "下体", "龟头", "阴毛", "避孕套", "你妈逼", "大鸡巴" };

            foreach (string i in names)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names1)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names2)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names3)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names4)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names5)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names6)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names7)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names8)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names9)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names10)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names11)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names12)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names13)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names14)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            foreach (string i in names15)
            {
                if (origStr.IndexOf(i) > -1)
                {
                    fh = true;
                }
            }
            return fh;
        }
        /// <summary>
        /// SQL字符串过滤
        /// </summary>
        /// <param name="Str"></param>
        /// <returns></returns>
        public static bool ProcessSqlStr(string Str)
        {
            bool ReturnValue = true;
            try
            {
                if (Str.Trim() != "")
                {

                    string SqlStr = "exec|insert+|select+|delete|update|count|chr|mid|master+|truncate|char|declare|drop+|drop+table|creat+|create|*|iframe|script|";
                    SqlStr += "exec+|insert|delete+|update+|count(|count+|chr+|+mid(|+mid+|+master+|truncate+|char+|+char(|declare+|drop+table|creat+table";
                    string[] anySqlStr = SqlStr.Split('|');
                    foreach (string ss in anySqlStr)
                    {
                        if (Str.ToLower().IndexOf(ss) >= 0)
                        {
                            ReturnValue = false;
                            break;
                        }
                    }
                }
            }
            catch
            {
                ReturnValue = false;
            }
            return ReturnValue;
        }
        /// <summary>
        /// 检测是否符合email格式
        /// </summary>
        /// <param name="strEmail">要判断的email字符串</param>
        /// <returns>判断结果</returns>
        public static bool IsValidEmail(string strEmail)
        {
            return Regex.IsMatch(strEmail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        /// <summary>
        /// 检测是否是正确的Url
        /// </summary>
        /// <param name="strUrl">要验证的Url</param>
        /// <returns>判断结果</returns>
        public static bool IsURL(string strUrl)
        {
            return Regex.IsMatch(strUrl, @"^(http|https)\://([a-zA-Z0-9\.\-]+(\:[a-zA-Z0-9\.&%\$\-]+)*@)*((25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])|localhost|([a-zA-Z0-9\-]+\.)*[a-zA-Z0-9\-]+\.(com|edu|gov|int|mil|net|org|biz|arpa|info|name|pro|aero|coop|museum|[a-zA-Z]{1,10}))(\:[0-9]+)*(/($|[a-zA-Z0-9\.\,\?\'\\\+&%\$#\=~_\-]+))*$");
        }
        /// <summary>
        /// 检测是否有Sql危险字符
        /// </summary>
        /// <param name="str">要判断字符串</param>
        /// <returns>判断结果</returns>
        public static bool IsSafeSqlString(string str)
        {

            return !Regex.IsMatch(str, @"[-|;|,|\/|\(|\)|\[|\]|\}|\{|%|@|\*|!|\']");
        }
        /// <summary>
        /// 改正sql语句中的转义字符
        /// </summary>
        public static string mashSQL(string str)
        {
            string str2;

            if (str == null)
            {
                str2 = "";
            }
            else
            {
                str = str.Replace("\'", "'");
                str2 = str;
            }
            return str2;
        }
 
        ///// <summary>
        ///// 获得当前页面客户端的IP
        ///// </summary>
        ///// <returns>当前页面客户端的IP</returns>
        //public static string GetIP()
        //{


        //    string result = String.Empty;

        //    result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        //    if (null == result || result == String.Empty)
        //    {
        //        result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
        //    }

        //    if (null == result || result == String.Empty)
        //    {
        //        result = HttpContext.Current.Request.UserHostAddress;
        //    }

        //    if (null == result || result == String.Empty || !IsIP(result))
        //    {
        //        return "0.0.0.0";
        //    }

        //    return result;

        //}
        /// <summary>
        /// 是否为ip
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static bool IsIP(string ip)
        {
            return Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");

        }
        /// <summary>
        /// 将全角数字转换为数字
        /// </summary>
        /// <param name="SBCCase"></param>
        /// <returns></returns>
        public static string SBCCaseToNumberic(string SBCCase)
        {
            char[] c = SBCCase.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                byte[] b = System.Text.Encoding.Unicode.GetBytes(c, i, 1);
                if (b.Length == 2)
                {
                    if (b[1] == 255)
                    {
                        b[0] = (byte)(b[0] + 32);
                        b[1] = 0;
                        c[i] = System.Text.Encoding.Unicode.GetChars(b)[0];
                    }
                }
            }
            return new string(c);
        }
        /// <summary>
        /// 判断某值是否在枚举内（位枚举）
        /// </summary>
        /// <param name="checkingValue">被检测的枚举值</param>
        /// <param name="expectedValue">期望的枚举值</param>
        /// <returns>是否包含</returns>
        public static bool CheckFlagsEnumEquals(Enum checkingValue, Enum expectedValue)
        {
            int intCheckingValue = Convert.ToInt32(checkingValue);
            int intExpectedValue = Convert.ToInt32(expectedValue);
            return (intCheckingValue & intExpectedValue) == intExpectedValue;
        }
    }
}
