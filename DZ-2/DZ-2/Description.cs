using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_2
{
    public class Description
    {

        private int EpisodeNum;
        private TimeSpan EpisodeLen;
        private string EpisodeName;  

        public Description(int episodeNum, TimeSpan episodeLen, string episodeName)
        {
            EpisodeNum = episodeNum;
            EpisodeName = episodeName;
            EpisodeLen = episodeLen;
        }

        public override string ToString()
        {
            return $"{EpisodeNum}, {EpisodeLen}, {EpisodeName}";
        }
    }
}
