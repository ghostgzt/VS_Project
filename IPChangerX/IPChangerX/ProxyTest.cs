






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using HtmlAgilityPack;
using System.Web;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Collections;
using System.IO;

namespace IPChangerX
{
    public class ProxyTest
    {
        private int RepeateTimes = 5;       //下载测试次数
        private int MaxThread = 300;        //最大线程数
        private int FileLength;             //下载内容大小
        private readonly ProxyDetail[] Proxys;      //代理类数组
        private Uri TestUri = new Uri("http://www.baidu.com/");         //下载baidu.com来测试代理
        private List<ProxyTable> proxyList = new List<ProxyTable>();    //代理列表
 
        Regex ipPattern = new Regex(@"^\d+\.\d+\.\d+\.\d+$", RegexOptions.Compiled);
        Regex numPattern = new Regex(@"^\d+$", RegexOptions.Compiled);
        Regex numCnPattern = new Regex(@"(?<word>[a-z])=""(?<num>\d)""", RegexOptions.Compiled);
        Regex ipPortPattern = new Regex(@"(?is)(?<ip>\d+\.\d+\.\d+\.\d+)[^+]*?(?<word>(\+[a-z])+)", RegexOptions.Compiled);
 
        public ProxyTest()
        {
            FileLength = GetFileLength();           //得到下载测试内容的大小
            string[] pArray = ReadAllTestProxy();   //读取需要测试的代理列表
 
            List<ProxyDetail> pList = new List<ProxyDetail>();
 
            foreach (var item in pArray)
            {
                WebProxy proxy;
                try { proxy = new WebProxy(item); }
                catch { continue; }
 
                ProxyDetail pDetail = new ProxyDetail();
                pDetail.Proxy = proxy;
                pDetail.ProxyString = item;
                pList.Add(pDetail);
            }
 
            Proxys = pList.ToArray();           //得到需要测试的代理列表
        }
 
        //得到下载测试内容的大小
        private int GetFileLength()
        {
            WebClient client = new WebClient();
            byte[] datas = client.DownloadData(TestUri);
            return datas.Length;
        }
 
        //读取需要测试的代理列表
        private string[] ReadAllTestProxy()
        {
            //通过网站得到一些新的代理地址
            HashSet<string> proxyHash = GetProxyFromWeb();
            //读取数据库里面的代理地址，测试还可以使用否
            using (SqlDataReader reader = DataBaseHelper.GetHelper().ExecuteReader("select Proxy from ProxyTable"))
            {
                if (reader != null)
                {
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            proxyHash.Add(reader["Proxy"].ToString());
                        }
                    }//reader
                }//if
            }//using
            return proxyHash.ToArray();
        }
        #region 从网络上得到代理IP
        //从cnProxy得到代理地址
        private HashSet<string> GetFromCnproxy()
        {
            HashSet<string> proxyHash = new HashSet<string>();
 
            WebClient client = new WebClient();
            string DefaultUserAgent = @"Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.186 Safari/535.1";
            string DefaultPostContentType = "application/x-www-form-urlencoded";
            client.Credentials = CredentialCache.DefaultCredentials;
            client.Headers.Add("User-Agent", DefaultUserAgent);
            client.Headers.Add("Content-Type", DefaultPostContentType);
 
            for (int pageIndex = 1; pageIndex < 11; ++pageIndex)
            {
                Uri uri = new Uri(string.Format("http://www.cnproxy.com/proxy{0}.html", pageIndex));
 
                client.Headers.Add("Referer", uri.AbsoluteUri);
 
                string content = Encoding.GetEncoding("gb2312").GetString(client.DownloadData(uri));
 
                //该网站的代理端口是通过js得到的
                Dictionary<string, string> wordToNum = new Dictionary<string, string>();
                foreach (Match m in numCnPattern.Matches(content))
                    if (!wordToNum.ContainsKey(m.Groups["word"].Value))
                        wordToNum.Add(m.Groups["word"].Value, m.Groups["num"].Value);
 
                //正则匹配到代理地址等
                foreach (Match m in ipPortPattern.Matches(content))
                {
                    try
                    {
                        string ip = m.Groups["ip"].Value + ":";
                        string[] words = m.Groups["word"].Value.Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var word in words)
                            ip += wordToNum[word];
                        proxyHash.Add(ip);
                    }
                    catch { }
                }
            }
            return proxyHash;
        }
 
        //通过heibai网站得到代理地址
        private HashSet<string> GetFromHeibai()
        {
            HashSet<string> ipHash = new HashSet<string>();
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            WebClient client = new WebClient();
            string DefaultUserAgent = @"Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.186 Safari/535.1";
            string DefaultPostContentType = "application/x-www-form-urlencoded";
 
            client.Credentials = CredentialCache.DefaultCredentials;
            client.Headers.Add("User-Agent", DefaultUserAgent);
            client.Headers.Add("Content-Type", DefaultPostContentType);
 
            //得到十页的代理内容
            for (int pageIndex = 1; pageIndex < 11; ++pageIndex)
            {
                Uri uri = new Uri(string.Format("http://www.heibai.net/proxy/index.php?act=list&port=&type=&country=&page={0}", pageIndex));
 
                client.Headers.Add("Referer", uri.AbsoluteUri);
 
                byte[] bytes = client.DownloadData(uri);
                string content = WebUtility.HtmlDecode(Encoding.GetEncoding("utf-8").GetString(bytes));
 
                htmlDoc.LoadHtml(content);
 
                //get paraNodes part
                var paraNodes = htmlDoc.DocumentNode.SelectNodes(@"//tr[@class='cells']");
 
                if (paraNodes == null)
                    return ipHash;
 
                HtmlAgilityPack.HtmlDocument htmlD = new HtmlAgilityPack.HtmlDocument();
 
                foreach (var node in paraNodes)
                {
                    htmlD.LoadHtml(node.OuterHtml);
                    var ipNode = htmlD.DocumentNode.SelectSingleNode(@"//td[2]");
                    var portNode = htmlD.DocumentNode.SelectSingleNode(@"//td[3]");
 
                    if ((ipNode != null && ipPattern.IsMatch(ipNode.InnerText.Trim()) &&
                    portNode != null) && numPattern.IsMatch(portNode.InnerText.Trim()))
                        ipHash.Add(ipNode.InnerText.Trim() + ":" + portNode.InnerText.Trim());
                }
            }
            return ipHash;
        }
 
        //通过proxy360得到代理地址
        private HashSet<string> GetFromProxy360()
        {
            HashSet<string> ipHash = new HashSet<string>();
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            WebClient client = new WebClient();
            string DefaultUserAgent = @"Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.186 Safari/535.1";
            string DefaultPostContentType = "application/x-www-form-urlencoded";
 
            client.Credentials = CredentialCache.DefaultCredentials;
            client.Headers.Add("User-Agent", DefaultUserAgent);
            client.Headers.Add("Content-Type", DefaultPostContentType);
 
            Uri uri = new Uri("http://www.proxy360.cn/default.aspx");
 
            client.Headers.Add("Referer", uri.AbsoluteUri);
 
            byte[] bytes = client.DownloadData(uri);
            string content = WebUtility.HtmlDecode(Encoding.GetEncoding("utf-8").GetString(bytes));
 
            htmlDoc.LoadHtml(content);
 
            //get paraNodes part
            var paraNodes = htmlDoc.DocumentNode.SelectNodes(@"//div[@class='proxylistitem']");
 
            if (paraNodes == null)
                return ipHash;
 
            HtmlAgilityPack.HtmlDocument htmlD = new HtmlAgilityPack.HtmlDocument();
 
            foreach (var node in paraNodes)
            {
                htmlD.LoadHtml(node.OuterHtml);
                var ipNode = htmlD.DocumentNode.SelectSingleNode(@"//span[@class='tbBottomLine'][1]");
                var portNode = htmlD.DocumentNode.SelectSingleNode(@"//span[@class='tbBottomLine'][2]");
 
                if ((ipNode != null && ipPattern.IsMatch(ipNode.InnerText.Trim()) &&
                    portNode != null) && numPattern.IsMatch(portNode.InnerText.Trim()))
                    ipHash.Add(ipNode.InnerText.Trim() + ":" + portNode.InnerText.Trim());
            }
 
            return ipHash;
        }
 
        //通过dailiip网站得到代理地址
        private HashSet<string> GetFromDailiip()
        {
            HashSet<string> ipHash = new HashSet<string>();
            WebClient client = new WebClient();
            string DefaultUserAgent = @"Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.186 Safari/535.1";
            string DefaultPostContentType = "application/x-www-form-urlencoded";
 
            client.Credentials = CredentialCache.DefaultCredentials;
            client.Headers.Add("User-Agent", DefaultUserAgent);
            client.Headers.Add("Content-Type", DefaultPostContentType);
 
            Uri uri = new Uri("http://www.dailiip.com/");
 
            client.Headers.Add("Referer", uri.AbsoluteUri);
 
            byte[] bytes = client.DownloadData(uri);
            string content = WebUtility.HtmlDecode(Encoding.GetEncoding("gb2312").GetString(bytes));
            foreach (Match m in dailiipPattern.Matches(content))
            {
                ipHash.Add(m.Groups["ip"].Value + ":" + m.Groups["port"].Value);
            }
            return ipHash;
        }
 
        //通过xker网站得到代理地址
        private HashSet<string> GetFromXker()
        {
            HashSet<string> ipHash = new HashSet<string>();
            WebClient client = new WebClient();
            string DefaultUserAgent = @"Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.186 Safari/535.1";
            string DefaultPostContentType = "application/x-www-form-urlencoded";
 
            client.Credentials = CredentialCache.DefaultCredentials;
            client.Headers.Add("User-Agent", DefaultUserAgent);
            client.Headers.Add("Content-Type", DefaultPostContentType);
 
            Uri uri = new Uri("http://www.xker.com/ip/");
 
            client.Headers.Add("Referer", uri.AbsoluteUri);
 
            byte[] bytes = client.DownloadData(uri);
            string content = WebUtility.HtmlDecode(Encoding.GetEncoding("gb2312").GetString(bytes));
            foreach (Match m in xkerPattern.Matches(content))
            {
                ipHash.Add(m.Groups["ip"].Value + ":" + m.Groups["port"].Value);
            }
            return ipHash;
        }
 
        //通过18daili网站得到代理地址
        private HashSet<string> GetFrom18daili()
        {
            HashSet<string> ipHash = new HashSet<string>();
            WebClient client = new WebClient();
            string DefaultUserAgent = @"Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.186 Safari/535.1";
            string DefaultPostContentType = "application/x-www-form-urlencoded";
 
            client.Credentials = CredentialCache.DefaultCredentials;
            client.Headers.Add("User-Agent", DefaultUserAgent);
            client.Headers.Add("Content-Type", DefaultPostContentType);
 
            Uri uri = new Uri("http://www.18daili.com/SearchLocationForAjax.php");
 
            client.Headers.Add("Referer", uri.AbsoluteUri);
 
            byte[] bytes = client.DownloadData(uri);
            string content = WebUtility.HtmlDecode(Encoding.GetEncoding("UTF-8").GetString(bytes));
            foreach (Match m in daili18Pattern.Matches(content))
            {
                ipHash.Add(m.Groups["ip"].Value + ":" + m.Groups["port"].Value);
            }
            return ipHash;
        }
 
        //通过35wl网站得到代理地址
        private HashSet<string> GetFrom35wl()
        {
            HashSet<string> ipHash = new HashSet<string>();
            WebClient client = new WebClient();
            string DefaultUserAgent = @"Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.186 Safari/535.1";
            string DefaultPostContentType = "application/x-www-form-urlencoded";
 
            client.Credentials = CredentialCache.DefaultCredentials;
            client.Headers.Add("User-Agent", DefaultUserAgent);
            client.Headers.Add("Content-Type", DefaultPostContentType);
 
            Uri uri = new Uri("http://www.35wl.com/tools/dlfwq.htm");
 
            client.Headers.Add("Referer", uri.AbsoluteUri);
 
            byte[] bytes = client.DownloadData(uri);
            string content = WebUtility.HtmlDecode(Encoding.GetEncoding("gb2312").GetString(bytes));
            foreach (Match m in wl35Pattern.Matches(content))
            {
                ipHash.Add(m.Groups["ip"].Value + ":" + m.Groups["port"].Value);
            }
            return ipHash;
        }
 
        //通过51proxied网站得到代理地址
        private HashSet<string> GetFrom51proxied()
        {
            HashSet<string> ipHash = new HashSet<string>();
            try
            {
                WebClient client = new WebClient();
                string DefaultUserAgent = @"Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.186 Safari/535.1";
                string DefaultPostContentType = "application/x-www-form-urlencoded";
 
                client.Credentials = CredentialCache.DefaultCredentials;
                client.Headers.Add("User-Agent", DefaultUserAgent);
                client.Headers.Add("Content-Type", DefaultPostContentType);
 
                Uri uri = new Uri("http://www.51proxied.com/http_fast.html");
 
                client.Headers.Add("Referer", uri.AbsoluteUri);
 
                byte[] bytes = client.DownloadData(uri);
                string content = WebUtility.HtmlDecode(Encoding.GetEncoding("UTF-8").GetString(bytes));
                foreach (Match m in proxiedPattern.Matches(content))
                {
                    ipHash.Add(m.Groups["ip"].Value + ":" + m.Groups["port"].Value);
                }
                 
            }
            catch { }
            return ipHash;
        }
 
        //通过nntime网站得到代理地址
        private HashSet<string> GetFromnntime()
        {
            HashSet<string> ipHash = new HashSet<string>();
            try
            {
                WebClient client = new WebClient();
                string DefaultUserAgent = @"Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.186 Safari/535.1";
                string DefaultPostContentType = "application/x-www-form-urlencoded";
 
                client.Credentials = CredentialCache.DefaultCredentials;
                client.Headers.Add("User-Agent", DefaultUserAgent);
                client.Headers.Add("Content-Type", DefaultPostContentType);
 
                Uri uri = new Uri("http://nntime.com/");
 
                client.Headers.Add("Referer", uri.AbsoluteUri);
 
                byte[] bytes = client.DownloadData(uri);
                string content = WebUtility.HtmlDecode(Encoding.GetEncoding("iso-8859-1").GetString(bytes));
                Dictionary<string, string> charDic = new Dictionary<string, string>();
                foreach (Match m in numnntimePattern.Matches(content))
                    if (!charDic.ContainsKey(m.Groups["word"].Value))
                        charDic.Add(m.Groups["word"].Value, m.Groups["num"].Value);
 
                foreach (Match m in nntimePattern.Matches(content))
                {
                    try
                    {
                        string ip = m.Groups["ip"].Value + ":";
                        string[] words = m.Groups["word"].Value.Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var word in words)
                            ip += charDic[word];
                        ipHash.Add(ip);
                    }
                    catch { }
                }
            }
            catch { }
            return ipHash;
        }
 
        //通过realbooster网站得到代理地址
        private HashSet<string> GetFromrealbooster()
        {
            HashSet<string> ipHash = new HashSet<string>();
            WebClient client = new WebClient();
            string DefaultUserAgent = @"Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.186 Safari/535.1";
            string DefaultPostContentType = "application/x-www-form-urlencoded";
 
            client.Credentials = CredentialCache.DefaultCredentials;
            client.Headers.Add("User-Agent", DefaultUserAgent);
            client.Headers.Add("Content-Type", DefaultPostContentType);
 
            Uri uri = new Uri("http://realbooster.com/seo-services/free-proxy-list-tool/");
 
            client.Headers.Add("Referer", uri.AbsoluteUri);
 
            byte[] bytes = client.DownloadData(uri);
            string content = WebUtility.HtmlDecode(Encoding.GetEncoding("UTF-8").GetString(bytes));
 
            foreach (Match m in realboosterPattern.Matches(content))
            {
                try
                {
                    ipHash.Add(m.Groups["ip"].Value + ":" + m.Groups["port"].Value);
                }
                catch { }
            }
            return ipHash;
        }
 
        //通过simpleproxylist网站得到代理地址
        private HashSet<string> GetFromsimpleproxylist()
        {
 
            HashSet<string> ipHash = new HashSet<string>();
            WebClient client = new WebClient();
            string DefaultUserAgent = @"Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.186 Safari/535.1";
            string DefaultPostContentType = "application/x-www-form-urlencoded";
 
            client.Credentials = CredentialCache.DefaultCredentials;
            client.Headers.Add("User-Agent", DefaultUserAgent);
            client.Headers.Add("Content-Type", DefaultPostContentType);
            for (int i = 1; i < 10; ++i)
            {
                Uri uri = new Uri("http://simpleproxylist.com/search.php?p=" + i.ToString() + "&country=CN");
 
                client.Headers.Add("Referer", uri.AbsoluteUri);
 
                byte[] bytes = client.DownloadData(uri);
                string content = System.Web.HttpUtility.HtmlDecode(Encoding.GetEncoding("UTF-8").GetString(bytes));
 
                foreach (Match m in simpleproxylistPattern.Matches(content))
                {
                    try
                    {
                        string ip = m.Groups["ip"].Value + ":";
                        string[] word = m.Groups["word"].Value.Split(new string[] { "&#" }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var w in word)
                            ip += (char)(int.Parse(w));
                        ipHash.Add(ip);
                    }
                    catch { }
                }
            }
            return ipHash;
        }
 
        //通过proxy-ip-list网站得到代理地址
        private static HashSet<string> GetFromproxyiplist()
        {
 
            HashSet<string> ipHash = new HashSet<string>();
            WebClient client = new WebClient();
            string DefaultUserAgent = @"Mozilla/5.0 (Windows NT 5.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.186 Safari/535.1";
            string DefaultPostContentType = "application/x-www-form-urlencoded";
 
            client.Credentials = CredentialCache.DefaultCredentials;
            client.Headers.Add("User-Agent", DefaultUserAgent);
            client.Headers.Add("Content-Type", DefaultPostContentType);
            Uri uri = new Uri("http://proxy-ip-list.com/");
 
            client.Headers.Add("Referer", uri.AbsoluteUri);
 
            byte[] bytes = client.DownloadData(uri);
            string content = HttpUtility.HtmlDecode(HttpUtility.HtmlDecode(Encoding.GetEncoding("UTF-8").GetString(bytes)));
 
 
            Regex proxyiplistPattern = new Regex(@"(?<ip>(\d{1,3}\.){3}\d{1,3}):(?<port>\d+)</td>", RegexOptions.Compiled);
 
            foreach (Match m in proxyiplistPattern.Matches(content))
            {
                try
                {
                    ipHash.Add(m.Groups["ip"].Value + ":" + m.Groups["port"].Value);
 
                }
                catch { }
            }
 
            return ipHash;
        }
 
        //在网站上得到新代理地址
        private HashSet<string> GetProxyFromWeb()
        {
            HashSet<string> proxyHash = new HashSet<string>();
 
            ///cnproxy
            foreach (var proxy in GetFromCnproxy())
            {
                proxyHash.Add(proxy);
            }
            ///heibai
            foreach (var proxy in GetFromHeibai())
            {
                proxyHash.Add(proxy);
            }
            ///proxy360
            foreach (var proxy in GetFromProxy360())
            {
                proxyHash.Add(proxy);
            }
            ///dailiip
            foreach (var proxy in GetFromDailiip())
            {
                proxyHash.Add(proxy);
            }
            ///xker
            foreach (var proxy in GetFromXker())
            {
                proxyHash.Add(proxy);
            }
            ///18daili
            foreach (var proxy in GetFrom18daili())
            {
                proxyHash.Add(proxy);
            }
            ///35wl
            foreach (var proxy in GetFrom35wl())
            {
                proxyHash.Add(proxy);
            }
            ///51proxied
            foreach (var proxy in GetFrom51proxied())
            {
                proxyHash.Add(proxy);
            }
            ///nntime
            foreach (var proxy in GetFromnntime())
            {
                proxyHash.Add(proxy);
            }
            ///realbooster
            foreach (var proxy in GetFromrealbooster())
            {
                proxyHash.Add(proxy);
            }
            ///simpleproxylist
            foreach (var proxy in GetFromsimpleproxylist())
            {
                proxyHash.Add(proxy);
            }
            ///proxyiplist
            foreach (var proxy in GetFromproxyiplist())
            {
                proxyHash.Add(proxy);
            }
            return proxyHash;
        }
 
        #endregion
        //测试代理是否可用
        public void Start()
        {
 
            ParallelOptions taskParallet = new ParallelOptions();
            taskParallet.MaxDegreeOfParallelism = MaxThread;
            int count = 0;
 
            for (int i = 0; i < RepeateTimes; i++)
            {
                Parallel.ForEach(Proxys, taskParallet, current =>
                {
                    if (current.Error != null)
                        return;
 
                    Stopwatch sw = new Stopwatch();
                    WebClient wc = new WebClient();
                    InitWebClient(wc, TestUri, TestUri);
                    wc.Proxy = current.Proxy;
                    sw.Restart();
                    try
                    {
                        byte[] data = wc.DownloadData(TestUri);
                        sw.Stop();
                        current.Milliseconds = sw.ElapsedMilliseconds;
                        current.ContentLength = data.Length;
 
                        if (current.ContentLength != FileLength)
                            current.Error = new Exception("下载错误");
 
                        string log = string.Format("{0} - {1} - {2} - {3}", current.ProxyString, current.ContentLength, current.Milliseconds, count);
                        Console.WriteLine(log);
                    }
                    catch (Exception e)
                    {
                        current.Error = e;
                        Console.WriteLine("{0} - {1} - {2}", current.ProxyString, e.Message, count);
                    }
 
                    Interlocked.Increment(ref count);
                });
 
                Array.Sort(Proxys, new Comparison<ProxyDetail>((a, b) => b.Milliseconds.CompareTo(a.Milliseconds)));
            }
 
            SaveProxy();
            Console.WriteLine("结束");
        }
 
        //保存代理地址
        private void SaveProxy()
        {
            //在这里可以排序取前多少可以使用的
            //Array.Sort(Proxys, new Comparison<ProxyDetail>((a, b) => a.Milliseconds.CompareTo(b.Milliseconds)));
 
            //这里取了下载时间小于10000毫秒的代理
            for (int i = 0; i < Proxys.Length; ++i)
                if (Proxys[i].Error == null && Proxys[i].Milliseconds < 10000)
                    proxyList.Add(new ProxyTable(Proxys[i].ProxyString));
 
            //写入数据库
            ProxyTable.AddToDB(proxyList.ToArray());
        }
 
        private const string DefaultUserAgent = @"Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; CIBA; .NET4.0C; .NET4.0E)";
        private const string DefaultPostContentType = "application/x-www-form-urlencoded";
 
        //初始化WebClient
        private static void InitWebClient(WebClient webClient, Uri uri, Uri pUri)
        {
            webClient.Credentials = CredentialCache.DefaultCredentials;
            webClient.Headers.Add("User-Agent", DefaultUserAgent);
            webClient.Headers.Add("Content-Type", DefaultPostContentType);
            webClient.Headers.Add("Referer", pUri.AbsoluteUri);
            ServicePoint servicePoint = ServicePointManager.FindServicePoint(uri);
            if (servicePoint.Expect100Continue == true)
                servicePoint.Expect100Continue = false;
        }
 
    }
 
    /// <summary>
    /// 测试Proxy时需要用到的一些参数
    /// </summary>
    public class ProxyDetail
    {
        public WebProxy Proxy;
        public string ProxyString;
        public int ContentLength;
        public long Milliseconds;
        public Exception Error;
    }
 
    /// <summary>
    /// 表ProxyTable
    /// </summary>
    public class ProxyTable
    {
        public int ProxyId;
        public string Proxy;
 
        public ProxyTable(string proxy)
        {
            ProxyId = 0;
            Proxy = proxy;
        }
 
        public static void AddToDB(ProxyTable[] data)
        {
            DataBaseHelper helper = DataBaseHelper.GetHelper();
 
            DataTable dataTable = GetTableSchema();
            for (int i = 0; i < data.Length; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["Proxy"] = data[i].Proxy;
                dataTable.Rows.Add(dataRow);
            }
            helper.ExecuteNonQuery("truncate table ProxyTable");
            helper.AddToDatabase(dataTable);
            dataTable.Clear();
        }
 
        private static DataTable GetTableSchema()
        {
            DataTable dt = new DataTable("ProxyTable");
            dt.Columns.Add("Proxy", typeof(string));
            return dt;
        }
    }
}


