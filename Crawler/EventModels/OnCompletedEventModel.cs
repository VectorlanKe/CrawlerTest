using System;
using System.Collections.Generic;
using System.Text;

namespace SmallCrawler.EventModels
{
    /// <summary>
    /// 结果实体
    /// </summary>
    public class OnCompletedEventModel
    {
        /// <summary>
        /// 爬虫URL地址
        /// </summary>
        public Uri Uri { get; private set; }
        /// <summary>
        /// 任务线程ID
        /// </summary>
        public int ThreadId { get; private set; }
        /// <summary>
        /// 页面源代码
        /// </summary>
        public string PageSource { get; private set; }
        /// <summary>
        /// 爬虫请求执行时间
        /// </summary>
        public long Milliseconds { get; private set; }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="uri">爬虫URL地址</param>
        /// <param name="threadId">任务线程ID</param>
        /// <param name="milliseconds">页面源代码</param>
        /// <param name="pageSource">爬虫请求执行时间</param>
        public OnCompletedEventModel(Uri uri, int threadId, long milliseconds, string pageSource)
        {
            this.Uri = uri;
            this.ThreadId = threadId;
            this.Milliseconds = milliseconds;
            this.PageSource = pageSource;
        }
    }
}
