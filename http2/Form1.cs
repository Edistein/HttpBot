using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace http2
{
    public partial class Form1 : Form
    {

        bool stop = false;
        bool rndua = false;
        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                Application.DoEvents();
            }
        }
        public string GetPw(Random ro)
        {

            int mode = ro.Next(0, 16);
            if (checkBox4.Checked == true)
            {
                mode = ro.Next(16, 23);
            }
            string p = "33550336";
            string[] str1 = { "b", "p", "m", "f", "d", "t", "n", "l", "g", "k", "h", "j", "y", "x", "z", "c", "s", "s", "c", "c", "c", "n", "l", "l", "l", "d", "h", "h" };
            string[] str2 = { "1314", "123", "abc", "abcabc", "123123", "666", "654", "111", "000", "aaa", "1234", "abcabc", "cao", "6rzh6" };
            string[] str3 = { "00", "01", "02", "03", "04", "05", "06", "07" };
            string[] str4 = { "B", "P", "M", "F", "D", "T", "N", "L", "G", "K", "H", "J", "Q", "X", "L", "L", "L", "L", "H", "H", "H", "Z", "Z", "Z", "C", "C", "C", "S" };
            if (mode == 0)
            {
                int p1 = ro.Next(10000, 999999);
                p = Convert.ToString(p1) + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)];
            }
            if (mode == 1)
            {
                int p1 = ro.Next(130, 152);
                int p2 = ro.Next(69999999, 899999999);
                p = Convert.ToString(p1) + Convert.ToString(p2) + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)];
            }
            if (mode == 2)
            {
                int p1 = ro.Next(1, 13);
                int p2 = ro.Next(1, 31);
                p = "20" + str3[ro.Next(0, 7)] + Convert.ToString(p1) + Convert.ToString(p2) + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)];
            }
            if (mode == 3)
            {
                int p1 = ro.Next(1, 13);
                int p2 = ro.Next(1, 31);
                p = "19" + Convert.ToString(ro.Next(71, 100)) + Convert.ToString(p1) + Convert.ToString(p2) + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)];
            }
            if (mode == 4)
            {
                int p1 = ro.Next(10000, 999999);
                p = str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + Convert.ToString(p1);
            }
            if (mode == 5)
            {
                int p1 = ro.Next(130, 152);
                int p2 = ro.Next(69999999, 899999999);
                p = str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + Convert.ToString(p1) + Convert.ToString(p2);
            }
            if (mode == 6)
            {
                int p1 = ro.Next(1, 13);
                int p2 = ro.Next(1, 31);
                p = str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + "20" + str3[ro.Next(0, 7)] + Convert.ToString(p1) + Convert.ToString(p2);
            }
            if (mode == 7)
            {
                int p1 = ro.Next(1, 13);
                int p2 = ro.Next(1, 31);
                p = str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + "19" + Convert.ToString(ro.Next(71, 100)) + Convert.ToString(p1) + Convert.ToString(p2);
            }
            if (mode == 8)
            {
                int p1 = ro.Next(10000, 999999);
                p = Convert.ToString(p1) + str4[ro.Next(0, 16)] + str4[ro.Next(0, 16)] + str4[ro.Next(0, 16)];
            }
            if (mode == 9)
            {
                int p1 = ro.Next(130, 152);
                int p2 = ro.Next(699, 899);
                int p3 = ro.Next(39999, 89999);
                p = Convert.ToString(p1) + Convert.ToString(p2) + Convert.ToString(p3) + str4[ro.Next(0, 27)] + str4[ro.Next(0, 27)] + str4[ro.Next(0, 27)];
            }
            if (mode == 10)
            {
                int p1 = ro.Next(1, 13);
                int p2 = ro.Next(1, 31);
                p = "20" + str3[ro.Next(0, 7)] + Convert.ToString(p1) + Convert.ToString(p2) + str4[ro.Next(0, 27)] + str4[ro.Next(0, 27)] + str4[ro.Next(0, 27)];
            }
            if (mode == 11)
            {
                int p1 = ro.Next(130, 152);
                int p2 = ro.Next(69999999, 899999999);
                p = str4[ro.Next(0, 27)] + str4[ro.Next(0, 27)] + str4[ro.Next(0, 27)] + Convert.ToString(p1) + Convert.ToString(p2);
            }
            if (mode == 12)
            {
                int p1 = ro.Next(1, 13);
                int p2 = ro.Next(1, 31);
                p = str4[ro.Next(0, 27)] + str4[ro.Next(0, 27)] + str4[ro.Next(0, 27)] + "20" + str3[ro.Next(0, 7)] + Convert.ToString(p1) + Convert.ToString(p2);
            }
            if (mode == 13)
            {
                int p1 = ro.Next(1, 13);
                int p2 = ro.Next(1, 31);
                p = str4[ro.Next(0, 27)] + str4[ro.Next(0, 27)] + str4[ro.Next(0, 27)] + "19" + Convert.ToString(ro.Next(71, 100)) + Convert.ToString(p1) + Convert.ToString(p2);
            }
            if (mode == 14)
            {
                p = str4[ro.Next(0, 27)] + str4[ro.Next(0, 27)] + str4[ro.Next(0, 27)] + str2[ro.Next(13)] + str2[ro.Next(13)] + str4[ro.Next(0, 27)] + str4[ro.Next(0, 27)] + str4[ro.Next(0, 27)];
            }
            if (mode == 15)
            {
                p = str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + str2[ro.Next(13)] + str2[ro.Next(13)] + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)];
            }
            if (mode == 16)
            {
                int p1 = ro.Next(130, 152);
                int p2 = ro.Next(69999999, 899999999);
                p = Convert.ToString(p1) + Convert.ToString(p2) + str4[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)];
            }
            if (mode == 17)
            {
                int p1 = ro.Next(1, 13);
                int p2 = ro.Next(1, 31);
                p = "20" + str3[ro.Next(0, 7)] + Convert.ToString(p1) + Convert.ToString(p2) + str4[ro.Next(0, 16)] + str1[ro.Next(0, 16)] + str1[ro.Next(0, 16)];
            }
            if (mode == 18)
            {
                int p1 = ro.Next(1, 13);
                int p2 = ro.Next(1, 31);
                p = str4[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + "20" + str3[ro.Next(0, 7)] + Convert.ToString(p1) + Convert.ToString(p2);
            }
            if (mode == 19)
            {
                int p1 = ro.Next(1, 13);
                int p2 = ro.Next(1, 31);
                p = str4[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + "19" + Convert.ToString(ro.Next(71, 100)) + Convert.ToString(p1) + Convert.ToString(p2);
            }
            if (mode == 20)
            {
                p = str4[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + str2[ro.Next(13)] + str2[ro.Next(13)] + str4[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + str1[ro.Next(0, 27)];
            }
            if (mode == 21)
            {
                int p1 = ro.Next(1, 13);
                int p2 = ro.Next(1, 31);
                p = str4[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + "19" + Convert.ToString(ro.Next(71, 100)) + Convert.ToString(p1) + Convert.ToString(p2);
            }
            if (mode == 22)
            {
                int p1 = ro.Next(1, 13);
                int p2 = ro.Next(1, 31);
                p = str4[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + "20" + str3[ro.Next(0, 7)] + Convert.ToString(p1) + Convert.ToString(p2);
            }
            return p;
        }
        static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
        public Form1()
        {

            InitializeComponent();

        }
       
        public void button1_Click(object sender, EventArgs e)
        {
            stop = false;
            textBox1.Enabled = false;
            textBox7.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            button1.Enabled = false;
            Random ro = new Random(GetRandomSeed());
            string ip = "";
            string p = " 33550336";
            string url = "http://" + textBox7.Text;
            string ua = "";
            string[] agent = { "Mozilla/5.0 (Linux; Android 8.0.0; LON-AL00 Build/HUAWEILON-AL00; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/70.0.3538.80 Mobile Safari/537.36 V1_AND_SQ_7.7.6_898_GM_D PA QQ/7.7.6.3680 NetType/WIFI WebP/0.4.1 Pixel/1440", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36", "Mozilla/5.0(compatible;MSIE9.0;WindowsNT6.1;Trident/5.0;", "Mozilla/5.0(WindowsNT6.1;rv:2.0.1)Gecko/20100101Firefox/4.0.1", "Mozilla/4.0(compatible;MSIE7.0;WindowsNT5.1;TheWorld)" };
            string accept = textBox5.Text;
            string ct = textBox6.Text;
            string refer = textBox8.Text;
            string ck = textBox12.Text;
            string uname = textBox9.Text;
            string pname = textBox10.Text;
            progressBar1.Value = 0;
            progressBar1.Maximum = Convert.ToInt32(textBox1.Text);
            progressBar1.Value = 0;
            for (int i = 1; i <= Convert.ToInt32(textBox1.Text); i++)
            {
                if (checkBox1.Checked == true)
                {
                    textBox3.Enabled = false;
                    ip = Convert.ToString(ro.Next(1, 255)) + "." + Convert.ToString(ro.Next(1, 255)) + "." + Convert.ToString(ro.Next(1, 255)) + "." + Convert.ToString(ro.Next(1, 255));
                    label10.Text = ip;
                }
                else
                {
                    textBox3.Enabled = true;
                    ip = textBox3.Text;
                }
                if (checkBox2.Checked == true)
                {
                    rndua = true;
                }
                else
                {
                    rndua = false;
                }
                if (stop == true)
                {
                    progressBar1.Value = 0;
                    label8.Text = "0%";
                    break;
                }
                p = GetPw(ro);
                string u = Convert.ToString(ro.Next(100000000,999999999))+ Convert.ToString(ro.Next(0,999 ));
                if (checkBox5.Checked == true)
                {
                    string[] str1 = { "b", "p", "m", "f", "d", "t", "n", "l", "g", "k", "h", "j", "y", "x", "z", "c", "s", "s", "c", "c", "c", "n", "l", "l", "l", "d", "h", "h" };
                    string[] str2 = { "1314", "123", "abc", "abcabc", "123123", "666", "654", "111", "000", "aaa", "1234", "abcabc", "cao", "6rzh6" };
                    string[] str3 = { "00", "01", "02", "03", "04", "05", "06", "07" };
                    string[] str5 = { "@hotmail.com","@163.com","@outlook.com","@126.com","@yeah.com","@sina.com","sohu.com", "@163.com", "@163.com",  "@126.com", "@126.com", "@sina.com" };
                    string[] str6 = { "zhao", "qian", "sun", "li", "zhou", "wu", "zheng", "wang", "guan", "deng", "song", "wei", "hua", "liu", "lu", "yin", "liang", "jiang", "ruan", "hou", "lan", "zhang", "qin", "huang", "jin", "ling", "yun", "zi", "chan", "zi", "ming", "chen", "buo", "zhi", "hao", "zhao", "qing", "yu", "tong", "meng", "jun", "yang", "heng" };
                    //43
                    int mode = ro.Next(0,7);
                    if (mode == 0|mode==1|mode==2)
                    {
                        u = u + "@qq.com";
                    }
                    if (mode == 3)
                    {
                        u = str1[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + ro.Next(0, 9999).ToString()+str5[ro.Next(0,11)];
                    }
                    if (mode == 4)
                    {
                        u = ro.Next(0, 9999).ToString() +str1[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + str1[ro.Next(0, 27)]+ str5[ro.Next(0, 11)]  ;
                    }
                    if (mode == 5)
                    {
                        u = str1[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + str6[ro.Next(0, 42)] + ro.Next(0, 9999).ToString() + str5[ro.Next(0, 11)];
                    }
                    if (mode == 6)
                    {
                        u = ro.Next(0, 9999).ToString() + str1[ro.Next(0, 27)] + str1[ro.Next(0, 27)] + str6[ro.Next(0, 42)] + str5[ro.Next(0, 11)];
                    }
                }
                if (rndua == true)
                {
                    ua = agent[ro.Next(0, 4)];
                    textBox4.Text = ua;
                }
                else
                {
                    ua = textBox4.Text;
                }
                try
                {
                    label4.Text =u;
                    label5.Text = p;
                    string post = uname + "=" + u + "&" + pname + "=" + p + textBox11.Text;
                    textBox13.Text = post;
                    textBox2.Text = "NO." + Convert.ToString(i) + ":   \r\n" + http.HttpPost(url, post, ip, ua, accept, ct, refer, ck);

                }
                catch (System.Exception e1)
                {
                    textBox2.Text = "NO." + Convert.ToString(i) + ":   " + e1.Message + Environment.NewLine + textBox2.Text;
                }
                progressBar1.Value++;
                label8.Text = Convert.ToString(Convert.ToSingle(i) / Convert.ToSingle(textBox1.Text) * 100 + "%");
                Application.DoEvents();
                if (checkBox3.Checked == true)
                {
                    int s = ro.Next(5, 20);
                    progressBar2.Value = 0;
                    for (int l = 1; l <= s; l++)
                    {
                        if (stop == true)
                        {
                            progressBar2.Value = 0;
                            label20.Text = "## s";
                            break;
                        }
                        progressBar2.Maximum = s;
                        Delay(1000);
                        label20.Text = Convert.ToString(s - l) + " s";
                        progressBar2.Value++;
                    }
                }
            }
            textBox1.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox7.Enabled = true;
            button1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stop = true;
            textBox3.Enabled = true;
            textBox1.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox7.Enabled = true;
            button1.Enabled = true;
            progressBar1.Value = 0;
            progressBar2.Value = 0;
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 255, 232, 232);
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.WhiteSmoke;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\"+System.Environment.UserName+"\\Desktop\\config.ini";
            fuckxml lxm = new fuckxml();
            textBox7.Text = lxm.ReadIt(path, textBox14.Text, "url");
            textBox9.Text = lxm.ReadIt(path, textBox14.Text, "user");
            textBox10.Text = lxm.ReadIt(path, textBox14.Text, "password");
            textBox5.Text = lxm.ReadIt(path, textBox14.Text, "accept");
            textBox8.Text = lxm.ReadIt(path, textBox14.Text, "refer");
            textBox11.Text = lxm.ReadIt(path, textBox14.Text,"refer");
        }
    }
    public class http
    {

        public static string HttpPost(string Url, string postDataStr, string ip, string ua, string accept, string ct, string refer, string ck)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.KeepAlive = true;
            request.ContentLength = postDataStr.Length;
            request.Accept = accept;
            request.UserAgent = ua;
            request.ContentType = ct;
            request.Referer = refer;
            request.Headers.Set("VIA", "KLGaming");
            request.Headers.Add("X_FORWARDED_FOR", ip);
            request.Headers.Add("CLIENT_IP", ip);
            request.Headers.Add("Cookie", ck);

            request.Referer = refer;
            request.CookieContainer = new CookieContainer();
            request.ContentLength = Encoding.UTF8.GetByteCount(postDataStr);
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
            myStreamWriter.Write(postDataStr);
            myStreamWriter.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }
    }
    public class fuckxml
    {
        #region 

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key,
                                                              string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key,
                                                           string def, StringBuilder retVal,
                                                           int size, string filePath);
        #endregion
        public string ReadIt(string path, string section, string key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "未能从"+path+"读取到指定信息，检查文件和section", temp, 255, path);
            int jj = temp.Length;
            return temp.ToString();
        }
    }
}