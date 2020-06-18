﻿namespace Rox.Blog
{
    /// <summary>
    /// 包含实体, 仓储接口,领域服务接口及其实现和其他领域对象
    /// </summary>
    [Dependency(
        typeof(BlogDomainSharedModule)
        )]
    public class BlogDomainModule : ModuleBase
    {
    }
}
