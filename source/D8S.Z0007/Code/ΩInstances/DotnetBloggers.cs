using System;


namespace D8S.Z0007
{
    public class DotnetBloggers : IDotnetBloggers
    {
        #region Infrastructure

        public static IDotnetBloggers Instance { get; } = new DotnetBloggers();


        private DotnetBloggers()
        {
        }

        #endregion
    }
}
