using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication.Models
{
    public class Header
    {
        public string companyName { get; set; }
        public string logo { get; set; }
    }

    public class Footer
    {
        public string footerLogo { get; set; }
        public string copyrightText { get; set; }
    }

    public class Globalcomponents
    {
        public Header header { get; set; }
        public Footer footer { get; set; }
    }

    public class Subcontent
    {
        public string contentType { get; set; }
        public string richText { get; set; }
        public string imagePath { get; set; }
        public string quote { get; set; }
        public string quoteSource { get; set; }
        public string linkHref { get; set; }
        public string linkTitle { get; set; }
    }

    public class Page
    {
        public string pageUrl { get; set; }
        public string pageTitle { get; set; }
        public string bodyText { get; set; }
        public List<Subcontent> subcontent { get; set; }
    }

    public class RootObject
    {
        public Globalcomponents globalcomponents { get; set; }
        public List<Page> pages { get; set; }
    }
}
