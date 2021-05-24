public class PolygonOperationContext // TypeDefIndex: 9273
{
	// Fields
	public PolygonUtil.PolyOperation mOperations; // 0x10
	public Point2DList mOriginalPolygon1; // 0x18
	public Point2DList mOriginalPolygon2; // 0x20
	public Point2DList mPoly1; // 0x28
	public Point2DList mPoly2; // 0x30
	public List<EdgeIntersectInfo> mIntersections; // 0x38
	public int mStartingIndex; // 0x40
	public PolygonUtil.PolyUnionError mError; // 0x44
	public List<int> mPoly1VectorAngles; // 0x48
	public List<int> mPoly2VectorAngles; // 0x50
	public Dictionary<uint, Point2DList> mOutput; // 0x58

	// Properties
	public Point2DList Union { get; }
	public Point2DList Intersect { get; }
	public Point2DList Subtract { get; }

	// Methods

	// RVA: 0x2766EB0 Offset: 0x2766FB1 VA: 0x2766EB0
	public Point2DList get_Union() { }

	// RVA: 0x2766F70 Offset: 0x2767071 VA: 0x2766F70
	public Point2DList get_Intersect() { }

	// RVA: 0x2767030 Offset: 0x2767131 VA: 0x2767030
	public Point2DList get_Subtract() { }

	// RVA: 0x27670F0 Offset: 0x27671F1 VA: 0x27670F0
	public void .ctor() { }

	// RVA: 0x2767170 Offset: 0x2767271 VA: 0x2767170
	public void Clear() { }

	// RVA: 0x2767260 Offset: 0x2767361 VA: 0x2767260
	public bool Init(PolygonUtil.PolyOperation operations, Point2DList polygon1, Point2DList polygon2) { }

	// RVA: 0x2767D30 Offset: 0x2767E31 VA: 0x2767D30
	private bool VerticesIntersect(Point2DList polygon1, Point2DList polygon2, out List<EdgeIntersectInfo> intersections) { }

	// RVA: 0x27681C0 Offset: 0x27682C1 VA: 0x27681C0
	public bool PointInPolygonAngle(Point2D point, Point2DList polygon) { }

	// RVA: 0x27683A0 Offset: 0x27684A1 VA: 0x27683A0
	public double VectorAngle(Point2D p1, Point2D p2) { }
}

public class PolygonOperationContext // TypeDefIndex: 9273
{
	// Fields
	public PolygonUtil.PolyOperation mOperations; // 0x10
	public Point2DList mOriginalPolygon1; // 0x18
	public Point2DList mOriginalPolygon2; // 0x20
	public Point2DList mPoly1; // 0x28
	public Point2DList mPoly2; // 0x30
	public List<EdgeIntersectInfo> mIntersections; // 0x38
	public int mStartingIndex; // 0x40
	public PolygonUtil.PolyUnionError mError; // 0x44
	public List<int> mPoly1VectorAngles; // 0x48
	public List<int> mPoly2VectorAngles; // 0x50
	public Dictionary<uint, Point2DList> mOutput; // 0x58

	// Properties
	public Point2DList Union { get; }
	public Point2DList Intersect { get; }
	public Point2DList Subtract { get; }

	// Methods

	// RVA: 0x2766EB0 Offset: 0x2766FB1 VA: 0x2766EB0
	public Point2DList get_Union() { }

	// RVA: 0x2766F70 Offset: 0x2767071 VA: 0x2766F70
	public Point2DList get_Intersect() { }

	// RVA: 0x2767030 Offset: 0x2767131 VA: 0x2767030
	public Point2DList get_Subtract() { }

	// RVA: 0x27670F0 Offset: 0x27671F1 VA: 0x27670F0
	public void .ctor() { }

	// RVA: 0x2767170 Offset: 0x2767271 VA: 0x2767170
	public void Clear() { }

	// RVA: 0x2767260 Offset: 0x2767361 VA: 0x2767260
	public bool Init(PolygonUtil.PolyOperation operations, Point2DList polygon1, Point2DList polygon2) { }

	// RVA: 0x2767D30 Offset: 0x2767E31 VA: 0x2767D30
	private bool VerticesIntersect(Point2DList polygon1, Point2DList polygon2, out List<EdgeIntersectInfo> intersections) { }

	// RVA: 0x27681C0 Offset: 0x27682C1 VA: 0x27681C0
	public bool PointInPolygonAngle(Point2D point, Point2DList polygon) { }

	// RVA: 0x27683A0 Offset: 0x27684A1 VA: 0x27683A0
	public double VectorAngle(Point2D p1, Point2D p2) { }
}

public class PolygonOperationContext // TypeDefIndex: 9273
{
	// Fields
	public PolygonUtil.PolyOperation mOperations; // 0x10
	public Point2DList mOriginalPolygon1; // 0x18
	public Point2DList mOriginalPolygon2; // 0x20
	public Point2DList mPoly1; // 0x28
	public Point2DList mPoly2; // 0x30
	public List<EdgeIntersectInfo> mIntersections; // 0x38
	public int mStartingIndex; // 0x40
	public PolygonUtil.PolyUnionError mError; // 0x44
	public List<int> mPoly1VectorAngles; // 0x48
	public List<int> mPoly2VectorAngles; // 0x50
	public Dictionary<uint, Point2DList> mOutput; // 0x58

	// Properties
	public Point2DList Union { get; }
	public Point2DList Intersect { get; }
	public Point2DList Subtract { get; }

	// Methods

	// RVA: 0x2766EB0 Offset: 0x2766FB1 VA: 0x2766EB0
	public Point2DList get_Union() { }

	// RVA: 0x2766F70 Offset: 0x2767071 VA: 0x2766F70
	public Point2DList get_Intersect() { }

	// RVA: 0x2767030 Offset: 0x2767131 VA: 0x2767030
	public Point2DList get_Subtract() { }

	// RVA: 0x27670F0 Offset: 0x27671F1 VA: 0x27670F0
	public void .ctor() { }

	// RVA: 0x2767170 Offset: 0x2767271 VA: 0x2767170
	public void Clear() { }

	// RVA: 0x2767260 Offset: 0x2767361 VA: 0x2767260
	public bool Init(PolygonUtil.PolyOperation operations, Point2DList polygon1, Point2DList polygon2) { }

	// RVA: 0x2767D30 Offset: 0x2767E31 VA: 0x2767D30
	private bool VerticesIntersect(Point2DList polygon1, Point2DList polygon2, out List<EdgeIntersectInfo> intersections) { }

	// RVA: 0x27681C0 Offset: 0x27682C1 VA: 0x27681C0
	public bool PointInPolygonAngle(Point2D point, Point2DList polygon) { }

	// RVA: 0x27683A0 Offset: 0x27684A1 VA: 0x27683A0
	public double VectorAngle(Point2D p1, Point2D p2) { }
}

public class PolygonOperationContext // TypeDefIndex: 9273
{
	// Fields
	public PolygonUtil.PolyOperation mOperations; // 0x10
	public Point2DList mOriginalPolygon1; // 0x18
	public Point2DList mOriginalPolygon2; // 0x20
	public Point2DList mPoly1; // 0x28
	public Point2DList mPoly2; // 0x30
	public List<EdgeIntersectInfo> mIntersections; // 0x38
	public int mStartingIndex; // 0x40
	public PolygonUtil.PolyUnionError mError; // 0x44
	public List<int> mPoly1VectorAngles; // 0x48
	public List<int> mPoly2VectorAngles; // 0x50
	public Dictionary<uint, Point2DList> mOutput; // 0x58

	// Properties
	public Point2DList Union { get; }
	public Point2DList Intersect { get; }
	public Point2DList Subtract { get; }

	// Methods

	// RVA: 0x2766EB0 Offset: 0x2766FB1 VA: 0x2766EB0
	public Point2DList get_Union() { }

	// RVA: 0x2766F70 Offset: 0x2767071 VA: 0x2766F70
	public Point2DList get_Intersect() { }

	// RVA: 0x2767030 Offset: 0x2767131 VA: 0x2767030
	public Point2DList get_Subtract() { }

	// RVA: 0x27670F0 Offset: 0x27671F1 VA: 0x27670F0
	public void .ctor() { }

	// RVA: 0x2767170 Offset: 0x2767271 VA: 0x2767170
	public void Clear() { }

	// RVA: 0x2767260 Offset: 0x2767361 VA: 0x2767260
	public bool Init(PolygonUtil.PolyOperation operations, Point2DList polygon1, Point2DList polygon2) { }

	// RVA: 0x2767D30 Offset: 0x2767E31 VA: 0x2767D30
	private bool VerticesIntersect(Point2DList polygon1, Point2DList polygon2, out List<EdgeIntersectInfo> intersections) { }

	// RVA: 0x27681C0 Offset: 0x27682C1 VA: 0x27681C0
	public bool PointInPolygonAngle(Point2D point, Point2DList polygon) { }

	// RVA: 0x27683A0 Offset: 0x27684A1 VA: 0x27683A0
	public double VectorAngle(Point2D p1, Point2D p2) { }
}

public class PolygonOperationContext // TypeDefIndex: 9273
{
	// Fields
	public PolygonUtil.PolyOperation mOperations; // 0x10
	public Point2DList mOriginalPolygon1; // 0x18
	public Point2DList mOriginalPolygon2; // 0x20
	public Point2DList mPoly1; // 0x28
	public Point2DList mPoly2; // 0x30
	public List<EdgeIntersectInfo> mIntersections; // 0x38
	public int mStartingIndex; // 0x40
	public PolygonUtil.PolyUnionError mError; // 0x44
	public List<int> mPoly1VectorAngles; // 0x48
	public List<int> mPoly2VectorAngles; // 0x50
	public Dictionary<uint, Point2DList> mOutput; // 0x58

	// Properties
	public Point2DList Union { get; }
	public Point2DList Intersect { get; }
	public Point2DList Subtract { get; }

	// Methods

	// RVA: 0x2766EB0 Offset: 0x2766FB1 VA: 0x2766EB0
	public Point2DList get_Union() { }

	// RVA: 0x2766F70 Offset: 0x2767071 VA: 0x2766F70
	public Point2DList get_Intersect() { }

	// RVA: 0x2767030 Offset: 0x2767131 VA: 0x2767030
	public Point2DList get_Subtract() { }

	// RVA: 0x27670F0 Offset: 0x27671F1 VA: 0x27670F0
	public void .ctor() { }

	// RVA: 0x2767170 Offset: 0x2767271 VA: 0x2767170
	public void Clear() { }

	// RVA: 0x2767260 Offset: 0x2767361 VA: 0x2767260
	public bool Init(PolygonUtil.PolyOperation operations, Point2DList polygon1, Point2DList polygon2) { }

	// RVA: 0x2767D30 Offset: 0x2767E31 VA: 0x2767D30
	private bool VerticesIntersect(Point2DList polygon1, Point2DList polygon2, out List<EdgeIntersectInfo> intersections) { }

	// RVA: 0x27681C0 Offset: 0x27682C1 VA: 0x27681C0
	public bool PointInPolygonAngle(Point2D point, Point2DList polygon) { }

	// RVA: 0x27683A0 Offset: 0x27684A1 VA: 0x27683A0
	public double VectorAngle(Point2D p1, Point2D p2) { }
}

