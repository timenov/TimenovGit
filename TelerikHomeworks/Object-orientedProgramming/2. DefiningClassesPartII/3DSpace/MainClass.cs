using System;

namespace ThreeDSpace
{
    class MainClass
    {
        public static void Main()
        {
            Point3D p = new Point3D();
            p.X = 2;
            p.Y = 3;
            p.Z = 4;

            Path path = new Path();
            path.AddPoint(p);
            path.AddPoint(Point3D.PointO);

            PathStorage.Save(path, @"../../paths.txt");
            Path n = PathStorage.Load(@"../../paths.txt");

            Console.WriteLine(n.ToString());
        }
    }
}
