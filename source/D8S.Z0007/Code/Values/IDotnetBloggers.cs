using System;

using R5T.T0131;
using R5T.T0165;


namespace D8S.Z0007
{
    [ValuesMarker]
    public partial interface IDotnetBloggers : IValuesMarker
    {
        #region TODO

        // https://mattferderer.com/how-to-access-hosting-environment-in-configureservices

        #endregion


        #region Static

        private static Lazy<Blogger[]> All_Internal { get; } = new Lazy<Blogger[]>(() => new[]
        {
            DotnetBloggers.Instance.Abrahamsson_Joel,
            DotnetBloggers.Instance.Brind_Mike,
            DotnetBloggers.Instance.Fritz_Jeffrey,
            DotnetBloggers.Instance.Gordon_Steve,
            DotnetBloggers.Instance.Haack_Phil,
            DotnetBloggers.Instance.Hanselman_Scott,
            DotnetBloggers.Instance.Lock_Andrew,
            DotnetBloggers.Instance.Meziantou,
            DotnetBloggers.Instance.Robert_Jason,
            DotnetBloggers.Instance.Saeed_Muhammad_Rehan,
            DotnetBloggers.Instance.Skeet_Jon,
            DotnetBloggers.Instance.Strahl_Rick,
        });

        #endregion


        public Blogger[] All => IDotnetBloggers.All_Internal.Value;


        public Blogger Abrahamsson_Joel => Blogger.From(
            "Joel Abrahamsson",
            "http://joelabrahamsson.com/");

        public Blogger Brind_Mike => Blogger.From(
            "Mike Brind",
            "http://www.mikesdotnetting.com/");

        public Blogger Fritz_Jeffrey => Blogger.From(
            "Jeffrey Fritz",
            "https://dev.to/csharpfritz");

        public Blogger Gordon_Steve => Blogger.From(
            "Steve Gordon",
            "https://www.stevejgordon.co.uk/");

        public Blogger Haack_Phil => Blogger.From(
            "Phil Haack",
            "https://haacked.com/");

        public Blogger Hanselman_Scott => Blogger.From(
            "Scott Hanselman",
            "https://www.hanselman.com/");

        public Blogger Lock_Andrew => Blogger.From(
            "Andrew Lock",
            "https://andrewlock.net/");

        public Blogger Meziantou => Blogger.From(
            "Gérald Barré (Meziantou)",
            "https://www.meziantou.net/");

        public Blogger Robert_Jason => Blogger.From(
            "Jason Robert",
            "https://espressocoder.com/");

        public Blogger Saeed_Muhammad_Rehan => Blogger.From(
            "Muhammad Rehan Saeed",
            "https://rehansaeed.com/gethashcode-made-easy/");

        public Blogger Skeet_Jon => Blogger.From(
            "Jon Skeet",
            "https://codeblog.jonskeet.uk/");

        public Blogger Strahl_Rick => Blogger.From(
            "Rick Strahl",
            "https://weblog.west-wind.com/");
    }
}
