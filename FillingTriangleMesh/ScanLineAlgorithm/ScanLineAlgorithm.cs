using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FillingTriangleMesh
{
    /// <summary>
    /// Class that defines scan-line algorithm with sorted list of vertices.
    /// </summary>
    public class ScanLineAlgorithm
    {
        private readonly List<Point> polygon;
        private readonly List<AETPointer> AETs;
        private readonly Stack<int> indexes;

        public static List<Point> convertTriangleToPointsList(Triangle triangle)
        {
            return new List<Point>() { new Point((int) triangle.P0.X, (int) triangle.P0.Y),
                                       new Point((int) triangle.P1.X, (int) triangle.P1.Y),
                                       new Point((int) triangle.P2.X, (int) triangle.P2.Y) };
        }

        public static double getM(Point p1, Point p2)
        {
            return Math.Abs(p1.X - p2.X) < AETPointer.minM ? 
                double.PositiveInfinity : (p2.Y - p1.Y) / (p2.X - p1.X);
        }

        public ScanLineAlgorithm(List<Point> polygon)
        {
            this.AETs = new List<AETPointer>();
            this.polygon = polygon;
            this.indexes = new Stack<int>(polygon.Select((point, index) => 
                new KeyValuePair<Point, int>(point, index)).
                OrderByDescending(sortedValue => sortedValue.Key.Y).
                Select(keyValuepair => keyValuepair.Value));
        }


        /// <summary>
        /// Function calculates the point of the row that will be filled using vertex sorting.
        /// </summary>
        /// <returns>Range points of the row that will be filled.</returns>
        public IEnumerable<(List<int> xList, int y)> getPoints()
        {
            // Get y range from sorted set of indexes
            (int yMin, int yMax) yRange = ((int) polygon[indexes.Peek()].Y, (int) polygon[indexes.Last()].Y);
            var aetPointer = new AETPointer();

            for (int y = yRange.yMin + 1; y <= yRange.yMax; ++y)
            {
                while (indexes.Count > 0 && polygon[indexes.Peek()].Y == y - 1)
                {
                    int currIndex = indexes.Pop();
                    Point currPoint = polygon[currIndex];

                    int prevIndex = (currIndex - 1 + polygon.Count) % polygon.Count;
                    Point prevPoint = polygon[prevIndex];

                    int nextIndex = (currIndex + 1) % polygon.Count;
                    Point nextPoint = polygon[nextIndex];

                    // Add or remove previous edge
                    if (prevPoint.Y >= currPoint.Y)
                        AETs.Add(new AETPointer(prevPoint.Y, currPoint.X, getM(currPoint, prevPoint)));
                    else if (prevPoint.Y < currPoint.Y)
                    {
                        aetPointer.x = prevPoint.X;
                        aetPointer.yMax = (int)prevPoint.Y;
                        AETs.Remove(aetPointer);
                    }

                    // Add or remove next edge
                    if (nextPoint.Y >= currPoint.Y)
                        AETs.Add(new AETPointer(nextPoint.Y, currPoint.X, getM(currPoint, nextPoint)));
                    else if (nextPoint.Y < currPoint.Y)
                    {
                        aetPointer.x = nextPoint.X;
                        aetPointer.yMax = (int)nextPoint.Y;
                        AETs.Remove(aetPointer);
                    }
                }

                // Return sorted x values of AETPointers
                yield return (AETs.Select(aetPointer => aetPointer.intX).OrderBy(x => x).ToList(), y);

                // Update list of AETPointers
                AETs.RemoveAll(aetPointer => aetPointer.yMax <= y);
                foreach (var ptr in AETs)
                    ptr.move();
            }
        }
    }
}
