using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace ProxyTest
{
    class Program
    {

        static System.Timers.Timer proxyTimer = new System.Timers.Timer();

        static void Main(string[] args)
        {

            proxyTimer = new System.Timers.Timer();
            proxyTimer.Interval = 1000 * 60;
            proxyTimer.Elapsed += new System.Timers.ElapsedEventHandler(DoProxyTest);
            proxyTimer.Enabled = true;
            proxyTimer.Start();

            Thread.Sleep(-1);
        }

        static bool proxyIsRunning = false;

        static void DoProxyTest(object sender, System.Timers.ElapsedEventArgs e)
        {
            Write("Start to running ProxyTest function!");
            if (proxyIsRunning)
            {
                Write("End ProxyTest function! by : ProxyTest is running now!" + Environment.NewLine);
                return;
            }

            proxyTimer.Interval = 1000 * 60 * 60 * 24; //每天执行一次

            int rowCount = IPChangerX.DataBaseHelper.GetHelper().GetRowCount("ProxyTable");
            Write("ProxyTable Count:" + rowCount);
            IPChangerX.ProxyTest proxy = new IPChangerX.ProxyTest();
            proxy.Start();
            rowCount = IPChangerX.DataBaseHelper.GetHelper().GetRowCount("ProxyTable");
            Write("ProxyTable Count:" + rowCount);

            Write("End ProxyTest function!" + Environment.NewLine);
        }

        static void Write(string contents)
        {
            File.AppendAllText(@"log/proxyLog.txt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " : " + contents + Environment.NewLine);
        }
    }
}