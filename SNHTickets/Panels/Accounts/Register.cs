using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using SNHTickets.Util;

namespace SNHTickets.Panels.Accounts
{
    public partial class Register : Form
    {
        //登录使用的URL
        //String snh_register_url = "http://shop.snh48.com/user.php";
        //用于提交的数据字典
        Dictionary<String, String> dirRigData;
        //用于提交的数据字符串
        //String strRigData;
        //cookies容器
        public CookieContainer cookieCon { get; set; }
        //编码器
        ASCIIEncoding encoding;

        public Register()
        {
            InitializeComponent();
            dirRigData = new Dictionary<String, String>();
            cookieCon = new CookieContainer();
            encoding = new ASCIIEncoding();
        }

        private void RegisterAccount(String username, String password)
        {
            dirRigData.Clear();
            //构建注册要使用的POST数据
            dirRigData.Add("username", username);
            dirRigData.Add("email", RandomString(8) + "@sina.com");
            dirRigData.Add("password", password);
            dirRigData.Add("confirm_password", password);
            //扩展字段，手机号，不校验
            dirRigData.Add("extend_field5", RandomPhone("186"));
            //密保问题
            dirRigData.Add("sel_question", "old_address");
            //密保答案
            dirRigData.Add("passwd_answer", "123456");
            //扩展字段，QQ号，可以留空
            dirRigData.Add("extend_field2", "");
            //填写完毕
            dirRigData.Add("agreement", "1");
            dirRigData.Add("act", "register");
            dirRigData.Add("back_act", "");
            dirRigData.Add("Submit", "");
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterAccount(tb_username.Text, tb_password.Text);
        }

        private String RandomString(Int32 size)
        {
            Random randomSeed = new Random();
            StringBuilder RandStr = new StringBuilder(size);

            //ASCII起始位置97是a，生成的是26个小写字母组成的字符串
            int Start = 97;
            for(int i = 0; i < size; i++)
            {
                RandStr.Append((char)(26 * randomSeed.NextDouble() + Start));
            }
            return RandStr.ToString();
        }

        private String RandomPhone(String startNum)
        {
            //生成一个以比如186开头的手机号码
            Random randomSeed = new Random();
            StringBuilder RandStr = new StringBuilder(8);

            //ASCII起始位置48是0，生成的是10个数字组成的字符串
            int Start = 48;
            for (int i = 0; i < 8; i++)
            {
                RandStr.Append((char)(10 * randomSeed.NextDouble() + Start));
            }
            return startNum + RandStr.ToString();
        }
    }
}
