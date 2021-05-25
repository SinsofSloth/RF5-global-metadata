public class TriangulationUtil // TypeDefIndex: 9287
{
	// Methods

	// RVA: 0x27720B0 Offset: 0x27721B1 VA: 0x27720B0
	public static bool SmartIncircle(Point2D pa, Point2D pb, Point2D pc, Point2D pd) { }

	// RVA: 0x2772240 Offset: 0x2772341 VA: 0x2772240
	public static bool InScanArea(Point2D pa, Point2D pb, Point2D pc, Point2D pd) { }

	// RVA: 0x275F8E0 Offset: 0x275F9E1 VA: 0x275F8E0
	public static Orientation Orient2d(Point2D pa, Point2D pb, Point2D pc) { }

	// RVA: 0x2772380 Offset: 0x2772481 VA: 0x2772380
	public static bool PointInBoundingBox(double xmin, double xmax, double ymin, double ymax, Point2D p) { }

	// RVA: 0x2772430 Offset: 0x2772531 VA: 0x2772430
	public static bool PointOnLineSegment2D(Point2D lineStart, Point2D lineEnd, Point2D p, double epsilon) { }

	// RVA: 0x2772520 Offset: 0x2772621 VA: 0x2772520
	public static bool PointOnLineSegment2D(double x1, double y1, double x2, double y2, double x, double y, double epsilon) { }

	// RVA: 0x2770020 Offset: 0x2770121 VA: 0x2770020
	public static bool RectsIntersect(Rect2D r1, Rect2D r2) { }

	// RVA: 0x276E250 Offset: 0x276E351 VA: 0x276E250
	public static bool LinesIntersect2D(Point2D ptStart0, Point2D ptEnd0, Point2D ptStart1, Point2D ptEnd1, bool firstIsSegment, bool secondIsSegment, bool coincidentEndPointCollisions, ref Point2D pIntersectionPt, double epsilon) { }

	// RVA: 0x27600F0 Offset: 0x27601F1 VA: 0x27600F0
	public static bool LinesIntersect2D(Point2D ptStart0, Point2D ptEnd0, Point2D ptStart1, Point2D ptEnd1, ref Point2D pIntersectionPt, double epsilon) { }

	// RVA: 0x27726B0 Offset: 0x27727B1 VA: 0x27726B0
	public static double LI2DDotProduct(Point2D v0, Point2D v1) { }

	// RVA: 0x276A370 Offset: 0x276A471 VA: 0x276A370
	public static bool RaysIntersect2D(Point2D ptRayOrigin0, Point2D ptRayVector0, Point2D ptRayOrigin1, Point2D ptRayVector1, ref Point2D ptIntersection) { }

	// RVA: 0x2772740 Offset: 0x2772841 VA: 0x2772740
	public void .ctor() { }
}

