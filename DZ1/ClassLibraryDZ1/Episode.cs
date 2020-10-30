using System;
using System.Collections.Generic;
using System.Text;

namespace DZ1
{
    public class Episode
    {
        public Episode (int viewerCount, double collectiveScore, double maxScore)
        {
            ViewerCount = viewerCount;
            CollectiveScore = collectiveScore;
            MaxScore = maxScore;
        }
        
        public Episode()
        {

        }

        private int ViewerCount { get; set; }
        private double CollectiveScore { get; set; }
        private double MaxScore { get; set; }

        public void AddView(double score)
        {
            this.CollectiveScore += score;
            
            if (score > this.MaxScore)
            {
                this.MaxScore = score;
            }

            this.ViewerCount++;
        }

        public double GetMaxScore()
        {
            return this.MaxScore;
        }

        public int GetViewerCount()
        {
            return this.ViewerCount;
        }

        public double GetAverageScore()
        {
            return this.CollectiveScore / this.ViewerCount;
        }
    }
        

}
