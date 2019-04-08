using System;
using System.Collections.Generic;
using System.Text;

namespace SmallCrawler.EventModels
{
    /// <summary>
    /// 启动事件实体
    /// </summary>
    public class OnStartEventModel
    {
        /// <summary>
        /// 爬虫URL地址
        /// </summary>
        public Uri Uri { get; set; }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="uri">爬虫URL地址</param>
        public OnStartEventModel(Uri uri)
        {
            this.Uri = uri;
        }
    }
}
