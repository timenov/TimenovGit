using System;
using System.IO;
using System.Collections.Generic;

namespace ThreeDSpace
{
    static class PathStorage
    {
        public static void Save(Path path, string dir)
        {
            using (StreamWriter sw = new StreamWriter(dir, false))
            {
                sw.Write(path.ToString());
            }
        }

        public static Path Load(string dir)
        {
            Path path = new Path();
            using (StreamReader sr = new StreamReader(dir))
            {
                while (!sr.EndOfStream)
                {
                    string[] points = sr.ReadLine().Split(new char[]{','}, StringSplitOptions.RemoveEmptyEntries);
                    path.AddPoint(new Point3D(int.Parse(points[0]), int.Parse(points[1]), int.Parse(points[2])));
                }
            }
            return path;
        }
    }
}
