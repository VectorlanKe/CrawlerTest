using SmallCrawler.EventModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmallCrawler
{
    public interface ICrawler
    {
        /// <summary>
        /// 爬虫启动事件
        /// </summary>
        event EventHandler<OnStartEventModel> OnStart;
        /// <summary>
        /// 爬虫完成事件
        /// </summary>
        event EventHandler<OnCompletedEventModel> OnCompleted;
        /// <summary>
        /// 爬虫出错事件
        /// </summary>
        event EventHandler<OnErrorEventModel> OnError;
        /// <summary>
        /// 异步爬虫
        /// </summary>
        /// <param name="uri">爬虫URL地址</param>
        /// <param name="proxy">代理服务器</param>
        /// <returns></returns>
        Task<string> Start(Uri uri, string proxy); 
    }
}
