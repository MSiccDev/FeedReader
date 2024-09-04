namespace CodeHollow.FeedReader.Parser
{
    using Feeds;
    using System.Xml.Linq;

    internal abstract class AbstractXmlFeedParser : IFeedParser
    {
        public BaseFeed Parse(string feedXml)
        {
            var feedDoc = XDocument.Parse(feedXml);

            return Parse(feedXml, feedDoc);
        }

        public abstract BaseFeed Parse(string feedXml, XDocument feedDoc);
    }
}
