using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace Windows_Link_Maker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var xs = new OpenFileDialog();
            xs.FileName = "";
            xs.Filter = "All Files *.*|*.*";
            xs.ShowDialog();
            if (xs.FileName != "") {
             // MessageBox.Show(xs.FileName,"Result");
              textBox1.Text = xs.FileName;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var xs = new SaveFileDialog();
            xs.FileName = "";
            string[] sArray = textBox1.Text.Replace(" ","").Split('.');
            var xf = "";
            if (textBox1.Text.Length > 0) {
                xf = sArray[sArray.LongLength - 1] + " Files" + "*." + sArray[sArray.LongLength - 1] + "|*." + sArray[sArray.LongLength - 1] + "|";
            }
            xs.Filter =xf + "All Files *.*|*.*";
            xs.ShowDialog();
            if (xs.FileName != "")
            {
              //  MessageBox.Show(xs.FileName, "Result");
                textBox2.Text = xs.FileName;
                
            }
        }

    

        private void button3_Click(object sender, EventArgs e)
        {
            var xs = new FolderBrowserDialog();
            xs.SelectedPath = "";
            xs.ShowNewFolderButton = true;
            xs.ShowDialog();
            if (xs.SelectedPath != "")
            {
             //   MessageBox.Show(xs.SelectedPath, "Result");
           
                textBox3.Text = xs.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var xs = new FolderBrowserDialog();
            xs.SelectedPath = "";
            xs.ShowNewFolderButton = true;
            xs.ShowDialog();
            if (xs.SelectedPath != "")
            {
              //  MessageBox.Show(xs.SelectedPath, "Result");

                textBox4.Text = xs.SelectedPath;
            }
        }

        string runit(string execus,string paramx) {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(execus, paramx);

            psi.CreateNoWindow = true; //若为false，则会出现cmd的黑窗体  
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;

            System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi);
            
        return  (  p.StandardOutput.ReadToEnd()); 
        
        }

        string cmdit(string cc) {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            //要执行的程序名称
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            //可能接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;
            //由调用程序获取输出信息
            p.StartInfo.CreateNoWindow = true;
            //不显示程序窗口
            p.Start();//启动程序
            //向CMD窗口发送输入信息：
            p.StandardInput.WriteLine(cc);//重启电脑（C#中可不好做哦）
            p.StandardInput.WriteLine("exit");
            //获取CMD窗口的输出信息：
            string sOutput = p.StandardOutput.ReadToEnd();
            return sOutput;
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
                      if (textBox3.Text.Length > 0 && textBox4.Text.Length > 0) {
                if (textBox3.Text!=textBox4.Text)
                { 
                    var pp = "/d ";
                       
                        if (checkBox2.Checked) { pp = pp + "/j"; }
                        if (Directory.Exists(textBox4.Text))
                        {
                            var dg = Directory.GetFileSystemEntries(textBox4.Text);
                        //    MessageBox.Show(Convert.ToString(dg.LongLength), "123");
                            if (dg.LongLength > 0)
                            {

                                if (MessageBox.Show("目标目录不为空,是否要删除?", "目标目录不为空", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    Directory.Delete( textBox4.Text);

                                }





                            }
                            else { Directory.Delete( textBox4.Text); }
                        }
                        MessageBox.Show(cmdit("mklink  " + pp + " " + "\"" + textBox4.Text + "\"" + " " + "\"" + textBox3.Text+"\""));
                     System.Diagnostics.Process.Start("Explorer.exe", "/select," + "\""+textBox4.Text+"\"");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0) {
                if (textBox1.Text!=textBox2.Text)
                {
                    var pp = "";
                    if (checkBox4.Checked) { pp = "/h "; }
                    if (File.Exists( textBox2.Text))
                    {
                      
                      
                        if (MessageBox.Show("目标路径已经存在,是否要替换?", "目标路径已经存在", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            File.Delete(textBox2.Text);

                            
                        }
                        
                         
                    }
                    MessageBox.Show(cmdit("mklink  "  + pp  + " " + "\"" + textBox2.Text + "\"" + " " + "\"" + textBox1.Text+"\""));
                    System.Diagnostics.Process.Start("Explorer.exe", "/select," + "\"" + textBox2.Text+"\"");

                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked==true){MessageBox.Show("硬连接只能在同一个盘符里建立！","提醒信息");}
        }
    }
}
