using SmallCrawler;
using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("请输入Uri");
                string uriStr = Console.ReadLine();
                if (uriStr == "bay") break;
                Task.Run(() => CrawlerFun(new Uri(uriStr)));
            }
        }
        private async static Task CrawlerFun(Uri uri)
        {
            var hotelCrawler = new Crawler();
            hotelCrawler.OnStart += (s, e) =>
            {
                Console.WriteLine("爬虫开始抓取地址：" + e.Uri.ToString());
            };
            hotelCrawler.OnError += (s, e) =>
            {
                Console.WriteLine("爬虫抓取出现错误：" + e.Uri.ToString() + "，异常消息：" + e.Exception.Message);
            };
            hotelCrawler.OnCompleted += (s, e) =>
            {
                Console.WriteLine();
                Console.WriteLine("===============================================");
                Console.WriteLine("爬虫抓取任务完成！");
                Console.WriteLine("耗时：" + e.Milliseconds + "毫秒");
                Console.WriteLine("线程：" + e.ThreadId);
                Console.WriteLine("地址：" + e.Uri.ToString());
            };
            await hotelCrawler.Start(uri);
        }
    }
}
