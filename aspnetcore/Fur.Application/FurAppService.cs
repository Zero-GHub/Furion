﻿using Fur.DynamicApiController;

namespace Fur.Application
{
    /// <summary>
    /// 控制器注释
    /// </summary>
    [ApiDescriptionSettings(Tag = "All Apis")]
    public class FurAppService : IDynamicApiController
    {
        /// <summary>
        /// 动作方法注释
        /// </summary>
        /// <returns></returns>
        public string Get()
        {
            return nameof(Fur);
        }

        /// <summary>
        /// 通过Id获取
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Get(int id)
        {
            return id;
        }
    }
}