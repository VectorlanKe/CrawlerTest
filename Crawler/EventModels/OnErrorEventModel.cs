using System;
using System.Collections.Generic;
using System.Text;

namespace SmallCrawler.EventModels
{
    /// <summary>
    /// 异常事件实体
    /// </summary>
    public class OnErrorEventModel
    {
        /// <summary>
        /// 爬虫URL地址
        /// </summary>
        public Uri Uri { get; set; }
        /// <summary>
        /// 异常
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="uri">爬虫URL地址</param>
        /// <param name="exception">异常</param>
        public OnErrorEventModel(Uri uri, Exception exception)
        {
            this.Uri = uri;
            this.Exception = exception;
        }
    }
}
