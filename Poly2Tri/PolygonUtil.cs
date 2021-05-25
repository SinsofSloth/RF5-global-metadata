public class PolygonUtil // TypeDefIndex: 9268
{
	// Methods

	// RVA: 0x27686F0 Offset: 0x27687F1 VA: 0x27686F0
	public static Point2DList.WindingOrderType CalculateWindingOrder(IList<Point2D> l) { }

	// RVA: 0x2768A70 Offset: 0x2768B71 VA: 0x2768A70
	public static bool PolygonsAreSame2D(IList<Point2D> poly1, IList<Point2D> poly2) { }

	// RVA: 0x2765B40 Offset: 0x2765C41 VA: 0x2765B40
	public static bool PointInPolygon2D(IList<Point2D> polygon, Point2D p) { }

	// RVA: 0x2769010 Offset: 0x2769111 VA: 0x2769010
	public static bool PolygonsIntersect2D(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2) { }

	// RVA: 0x27695C0 Offset: 0x27696C1 VA: 0x27695C0
	public bool PolygonContainsPolygon(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2) { }

	// RVA: 0x27695E0 Offset: 0x27696E1 VA: 0x27695E0
	public static bool PolygonContainsPolygon(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2, bool runIntersectionTest) { }

	// RVA: 0x27698C0 Offset: 0x27699C1 VA: 0x27698C0
	public static void ClipPolygonToEdge2D(Point2D edgeBegin, Point2D edgeEnd, IList<Point2D> poly, out List<Point2D> outPoly) { }

	// RVA: 0x276A710 Offset: 0x276A811 VA: 0x276A710
	public static void ClipPolygonToPolygon(IList<Point2D> poly, IList<Point2D> clipPoly, out List<Point2D> outPoly) { }

	// RVA: 0x276AA60 Offset: 0x276AB61 VA: 0x276AA60
	public static PolygonUtil.PolyUnionError PolygonUnion(Point2DList polygon1, Point2DList polygon2, out Point2DList union) { }

	// RVA: 0x276AB70 Offset: 0x276AC71 VA: 0x276AB70
	protected static void PolygonUnionInternal(PolygonOperationContext ctx) { }

	// RVA: 0x276B350 Offset: 0x276B451 VA: 0x276B350
	public static PolygonUtil.PolyUnionError PolygonIntersect(Point2DList polygon1, Point2DList polygon2, out Point2DList intersectOut) { }

	// RVA: 0x276B460 Offset: 0x276B561 VA: 0x276B460
	protected static void PolygonIntersectInternal(PolygonOperationContext ctx) { }

	// RVA: 0x276BD90 Offset: 0x276BE91 VA: 0x276BD90
	public static PolygonUtil.PolyUnionError PolygonSubtract(Point2DList polygon1, Point2DList polygon2, out Point2DList subtract) { }

	// RVA: 0x276BEA0 Offset: 0x276BFA1 VA: 0x276BEA0
	public static void PolygonSubtractInternal(PolygonOperationContext ctx) { }

	// RVA: 0x276C890 Offset: 0x276C991 VA: 0x276C890
	public static PolygonUtil.PolyUnionError PolygonOperation(PolygonUtil.PolyOperation operations, Point2DList polygon1, Point2DList polygon2, out Dictionary<uint, Point2DList> results) { }

	// RVA: 0x276C9D0 Offset: 0x276CAD1 VA: 0x276C9D0
	public static PolygonUtil.PolyUnionError PolygonOperation(PolygonOperationContext ctx) { }

	// RVA: 0x276CA40 Offset: 0x276CB41 VA: 0x276CA40
	public static List<Point2DList> SplitComplexPolygon(Point2DList verts, double epsilon) { }

	// RVA: 0x276E980 Offset: 0x276EA81 VA: 0x276E980
	private static List<Point2DList> SplitComplexPolygonCleanup(IList<Point2D> orig) { }

	// RVA: 0x276F370 Offset: 0x276F471 VA: 0x276F370
	public void .ctor() { }
}

