using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace http2
{
   
public partial class Form1 : Form
    {
        bool stop = false;
        public Form1()
        {
            
            InitializeComponent();
            
        }
        static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            stop = false;
            textBox1.Enabled = false;
            button1.Enabled = false;
            Random ro = new Random(GetRandomSeed());
            
            string p =" 33550336";
            progressBar1.Value = 0;
            progressBar1.Maximum= Convert.ToInt32(textBox1.Text);
            string[] str1 = { "b","p", "m" , "f" , "d","t" , "n" , "l" , "g" , "k" , "h" , "j" , "q" , "x" };
            string[] str2 = { "1314","123","abc","abcabc","123123","666","654","111","000","aaa","1234","abcabc"};
            string[] str3 = { "00","01","02","03","04","05","06","07"};
            
            for (int i = 1; i <= Convert.ToInt32(textBox1.Text); i++)
            {
                if (stop == true)
                {
                    progressBar1.Value = 0;
                    label8.Text = "0%";
                    break;
                 }
                string u = Convert.ToString(ro.Next(222,999))+ Convert.ToString(ro.Next(10, 99)) + Convert.ToString(ro.Next(10, 99)) + Convert.ToString(ro.Next(10, 999));
                int mode =ro.Next(0,8);
                if (mode == 0)
                {
                    int p1 = ro.Next(10000,999999);
                    p = Convert.ToString(p1) + str1[ro.Next(0, 13)]+ str1[ro.Next(0, 13)]+str1[ro.Next(0, 13)];
                }
                if (mode == 1)
                {
                    int p1 = ro.Next(10000, 9999999);
                   p = Convert.ToString(p1) + str2[ro.Next(0,11)];
                }
                if (mode ==2)
                {
                    int p1 = ro.Next(1, 13);
                    int p2=ro.Next(1,31);
                    p="20"+str3[ro.Next(0,7)]+Convert.ToString(p1)+Convert.ToString(p2)+str1[ro.Next(0, 13)] + str1[ro.Next(0, 13)] + str1[ro.Next(0, 13)];
                }
                if (mode == 3)
                {
                    int p1 = ro.Next(1, 13);
                    int p2 = ro.Next(1, 31);
                    p="19"+Convert.ToString(ro.Next(71,100))+ Convert.ToString(p1) + Convert.ToString(p2) + str1[ro.Next(0, 13)] + str1[ro.Next(0, 13)] + str1[ro.Next(0, 13)];
                }
                if (mode == 4)
                {
                    int p1 = ro.Next(10000, 999999);
                   p = str1[ro.Next(0, 13)] + str1[ro.Next(0, 13)] + str1[ro.Next(0, 13)]+Convert.ToString(p1) ;
                }
                if (mode == 5)
                {
                    int p1 = ro.Next(10000, 9999999);
                    p = str2[ro.Next(0, 11)]+Convert.ToString(p1)  ;
                }
                if (mode == 6)
                {
                    int p1 = ro.Next(1, 13);
                    int p2 = ro.Next(1, 31);
                    p = str1[ro.Next(0, 13)] + str1[ro.Next(0, 13)] + str1[ro.Next(0, 13)]+ "20" + str3[ro.Next(0, 7)] + Convert.ToString(p1) + Convert.ToString(p2) ;
                }
                if (mode == 7)
                {
                    int p1 = ro.Next(1, 13);
                    int p2 = ro.Next(1, 31);
                    p = str1[ro.Next(0, 13)] + str1[ro.Next(0, 13)] + str1[ro.Next(0, 13)]+ "19" + Convert.ToString(ro.Next(71, 100)) + Convert.ToString(p1) + Convert.ToString(p2) ;
                }


                try
                {
                    label4.Text = Convert.ToString(u);
                    label5.Text = p;
                    string post = "u=" + u+ "&p=" + p;
                    textBox2.Text= "NO." + Convert.ToString(i) + ":   \r\n" + http.HttpPost("http://z1.ssd322.cn.com/", post);
                   

                }
                catch (System.Exception e1)
                {
                    textBox2.Text ="NO."+Convert.ToString(i)+":   "+e1.Message + Environment.NewLine+textBox2.Text;
                }
                progressBar1.Value++;
                label8.Text = Convert.ToString(Convert .ToSingle(i)/Convert.ToSingle(textBox1.Text)*100+"%");
                Application.DoEvents();
             }
            textBox1.Enabled = true;
            button1.Enabled = true;
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Cyan;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.WhiteSmoke;
        }
    }
    public class http
    {
       public static string HttpPost(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.KeepAlive = true;
            request.ContentLength =postDataStr.Length ;
            request.Accept = "text/html, application/xhtml+xml,application/xml;1=0.9,image/webq,image/apng,image/tpg,*/*;q=0.8";
            request.UserAgent = "Mozilla/5.0 (Linux; Android 8.0.0; LON-AL00 Build/HUAWEILON-AL00; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/70.0.3538.80 Mobile Safari/537.36 V1_AND_SQ_7.7.6_898_GM_D PA QQ/7.7.6.3680 NetType/WIFI WebP/0.4.1 Pixel/1440";
            request.ContentType = "application/x-www-form-urlencoded";
           
            request.Referer = "http://z1.ssd322.cn.com/cn2/login/h5_aq_login.asp";
            request.CookieContainer = new CookieContainer();

            request.ContentLength = Encoding.UTF8.GetByteCount(postDataStr);
            // request.CookieContainer = Cookie;
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
            myStreamWriter.Write(postDataStr);
            myStreamWriter.Close();
  
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // response.Cookies = cookie.GetCookies(response.ResponseUri);
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }
    }
}
