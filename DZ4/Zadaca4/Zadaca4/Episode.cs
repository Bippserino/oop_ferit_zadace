using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Zadaca4
{
    class Episode
    {
        public int ViewerCount { get; set; }
        public double GradeSum { get; set; }
        public double MaxGrade { get; set; }
        public Description MovieDescription { get; set; }

        public Episode()
        {
            ViewerCount = 0;
            GradeSum = 0;
            MaxGrade = 0;
            MovieDescription = new Description();
        }

        public Episode(Episode other)
        {
            this.ViewerCount = other.ViewerCount;
            this.GradeSum = other.GradeSum;
            this.MaxGrade = other.MaxGrade;
            this.MovieDescription = new Description(other.MovieDescription);
        }
        public Episode(int viewerCount, double gradeSum, double maxGrade)
        {
            ViewerCount = viewerCount;
            GradeSum = gradeSum;
            MaxGrade = maxGrade;
        }
        public Episode(int viewerCount, double gradeSum, double maxGrade, Description description)
        {
            ViewerCount = viewerCount;
            GradeSum = gradeSum;
            MaxGrade = maxGrade;
            MovieDescription = description;
        }

        public void AddView(double view)
        {
            ViewerCount++;
            GradeSum += view;
            if (view > MaxGrade) MaxGrade = view;
        }

        public double GetMaxScore()
        {
            return MaxGrade;
        }

        public double GetAverageScore()
        {
            return GradeSum / ViewerCount;
        }

        public int GetViewerCount()
        {
            return ViewerCount;
        }

        public override string ToString()
        {
            return ($"{ViewerCount},{GradeSum},{MaxGrade},{MovieDescription}");
        }

        public static bool operator >(Episode e1, Episode e2)
        {
            return e1.GetAverageScore() > e2.GetAverageScore();
        }
        public static bool operator <(Episode e1, Episode e2)
        {
            return e1.GetAverageScore() > e2.GetAverageScore();
        }


    }
}
