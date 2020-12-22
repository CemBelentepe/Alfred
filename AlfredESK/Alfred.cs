using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfredESK
{
    public struct SearchInfo
    {
        private string location;
        private int areaMin;
        private int areaMax;

        public SearchInfo(string location, int areaMin, int areaMax)
        {
            this.location = location;
            this.areaMin = areaMin;
            this.areaMax = areaMax;
        }
    }

    public struct SearchResult
    {
        public readonly string name;
        public readonly int area;

        public SearchResult(string name, int area)
        {
            this.name = name;
            this.area = area;
        }

        override public String ToString()
        {
            return $"{name} | {area}";
        }
    }

    public class Alfred
    {
        public enum Website { Sahibinden };
        public Website searchSite;

        public Alfred(Website searchSite = Website.Sahibinden)
        {
            this.searchSite = searchSite;
        }

        public List<SearchResult> Search(SearchInfo info)
        {
            List<SearchResult> results = new List<SearchResult>
            {
                new SearchResult("House 1", 100),
                new SearchResult("House 2", 120)
            };

            return results;
        }
    }
}
