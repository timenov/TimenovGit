using System;
using System.Text;
using System.Collections.Generic;

namespace ThreeDSpace
{
    class Path
    {
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            points.Add(point);
        }

        public override string ToString()
        {
            StringBuilder fullList = new StringBuilder();
            foreach (var point in points)
            {
                fullList.AppendLine(point.ToString());                
            }
            return fullList.ToString().Trim();
        }
    }
}
