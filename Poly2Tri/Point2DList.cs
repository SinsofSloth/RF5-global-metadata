[DefaultMemberAttribute] // RVA: 0x147D30 Offset: 0x147E31 VA: 0x147D30
public class Point2DList : IEnumerable<Point2D>, IEnumerable, IList<Point2D>, ICollection<Point2D> // TypeDefIndex: 9295
{
	// Fields
	public static readonly int kMaxPolygonVertices; // 0x0
	public static readonly double kLinearSlop; // 0x8
	public static readonly double kAngularSlop; // 0x10
	protected List<Point2D> mPoints; // 0x10
	protected Rect2D mBoundingBox; // 0x18
	protected Point2DList.WindingOrderType mWindingOrder; // 0x20
	protected double mEpsilon; // 0x28

	// Properties
	public Rect2D BoundingBox { get; }
	public Point2DList.WindingOrderType WindingOrder { get; set; }
	public double Epsilon { get; }
	public Point2D Item { get; set; }
	public int Count { get; }
	public virtual bool IsReadOnly { get; }

	// Methods

	// RVA: 0x275CFD0 Offset: 0x275D0D1 VA: 0x275CFD0
	public Rect2D get_BoundingBox() { }

	// RVA: 0x275CFE0 Offset: 0x275D0E1 VA: 0x275CFE0
	public Point2DList.WindingOrderType get_WindingOrder() { }

	// RVA: 0x275CFF0 Offset: 0x275D0F1 VA: 0x275CFF0
	public void set_WindingOrder(Point2DList.WindingOrderType value) { }

	// RVA: 0x275D0E0 Offset: 0x275D1E1 VA: 0x275D0E0
	public double get_Epsilon() { }

	// RVA: 0x275D0F0 Offset: 0x275D1F1 VA: 0x275D0F0 Slot: 6
	public Point2D get_Item(int index) { }

	// RVA: 0x275D170 Offset: 0x275D271 VA: 0x275D170 Slot: 7
	public void set_Item(int index, Point2D value) { }

	// RVA: 0x275D1E0 Offset: 0x275D2E1 VA: 0x275D1E0 Slot: 11
	public int get_Count() { }

	// RVA: 0x275D230 Offset: 0x275D331 VA: 0x275D230 Slot: 18
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x275D240 Offset: 0x275D341 VA: 0x275D240
	public void .ctor() { }

	// RVA: 0x275D380 Offset: 0x275D481 VA: 0x275D380
	public void .ctor(int capacity) { }

	// RVA: 0x275D4A0 Offset: 0x275D5A1 VA: 0x275D4A0
	public void .ctor(IList<Point2D> l) { }

	// RVA: 0x275D630 Offset: 0x275D731 VA: 0x275D630
	public void .ctor(Point2DList l) { }

	// RVA: 0x275D8B0 Offset: 0x275D9B1 VA: 0x275D8B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x275DAD0 Offset: 0x275DBD1 VA: 0x275DAD0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x275DB60 Offset: 0x275DC61 VA: 0x275DB60 Slot: 4
	private IEnumerator<Point2D> System.Collections.Generic.IEnumerable<Poly2Tri.Point2D>.GetEnumerator() { }

	// RVA: 0x275DBE0 Offset: 0x275DCE1 VA: 0x275DBE0 Slot: 14
	public void Clear() { }

	// RVA: 0x275DCB0 Offset: 0x275DDB1 VA: 0x275DCB0 Slot: 8
	public int IndexOf(Point2D p) { }

	// RVA: 0x275DD20 Offset: 0x275DE21 VA: 0x275DD20 Slot: 19
	public virtual void Add(Point2D p) { }

	// RVA: 0x275DD40 Offset: 0x275DE41 VA: 0x275DD40 Slot: 20
	protected virtual void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon) { }

	// RVA: 0x275E030 Offset: 0x275E131 VA: 0x275E030 Slot: 21
	public virtual void AddRange(Point2DList l) { }

	// RVA: 0x275E0F0 Offset: 0x275E1F1 VA: 0x275E0F0 Slot: 22
	public virtual void AddRange(IEnumerator<Point2D> iter, Point2DList.WindingOrderType windingOrder) { }

	// RVA: 0x275E460 Offset: 0x275E561 VA: 0x275E460 Slot: 23
	public virtual void Insert(int idx, Point2D item) { }

	// RVA: 0x275E480 Offset: 0x275E581 VA: 0x275E480 Slot: 24
	public virtual bool Remove(Point2D p) { }

	// RVA: 0x275E640 Offset: 0x275E741 VA: 0x275E640 Slot: 25
	public virtual void RemoveAt(int idx) { }

	// RVA: 0x275E700 Offset: 0x275E801 VA: 0x275E700 Slot: 26
	public virtual void RemoveRange(int idxStart, int count) { }

	// RVA: 0x275E7C0 Offset: 0x275E8C1 VA: 0x275E7C0 Slot: 15
	public bool Contains(Point2D p) { }

	// RVA: 0x275E830 Offset: 0x275E931 VA: 0x275E830 Slot: 16
	public void CopyTo(Point2D[] array, int arrayIndex) { }

	// RVA: 0x275E520 Offset: 0x275E621 VA: 0x275E520
	public void CalculateBounds() { }

	// RVA: 0x275DF50 Offset: 0x275E051 VA: 0x275DF50
	public double CalculateEpsilon() { }

	// RVA: 0x275D0B0 Offset: 0x275D1B1 VA: 0x275D0B0
	public Point2DList.WindingOrderType CalculateWindingOrder() { }

	// RVA: 0x275EC10 Offset: 0x275ED11 VA: 0x275EC10
	public int NextIndex(int index) { }

	// RVA: 0x275EC80 Offset: 0x275ED81 VA: 0x275EC80
	public int PreviousIndex(int index) { }

	// RVA: 0x275E9E0 Offset: 0x275EAE1 VA: 0x275E9E0
	public double GetSignedArea() { }

	// RVA: 0x275ECF0 Offset: 0x275EDF1 VA: 0x275ECF0
	public double GetArea() { }

	// RVA: 0x275EF30 Offset: 0x275F031 VA: 0x275EF30
	public Point2D GetCentroid() { }

	// RVA: 0x275F210 Offset: 0x275F311 VA: 0x275F210
	public void Translate(Point2D vector) { }

	// RVA: 0x275F350 Offset: 0x275F451 VA: 0x275F350
	public void Scale(Point2D value) { }

	// RVA: 0x275F490 Offset: 0x275F591 VA: 0x275F490
	public void Rotate(double radians) { }

	// RVA: 0x275F680 Offset: 0x275F781 VA: 0x275F680
	public bool IsDegenerate() { }

	// RVA: 0x275FA90 Offset: 0x275FB91 VA: 0x275FA90
	public bool IsConvex() { }

	// RVA: 0x275FE70 Offset: 0x275FF71 VA: 0x275FE70
	public bool IsSimple() { }

	// RVA: 0x2760120 Offset: 0x2760221 VA: 0x2760120
	public Point2DList.PolygonError CheckPolygon() { }

	// RVA: 0x2760A40 Offset: 0x2760B41 VA: 0x2760A40
	public static string GetErrorString(Point2DList.PolygonError error) { }

	// RVA: 0x2761090 Offset: 0x2761191 VA: 0x2761090
	public void RemoveDuplicateNeighborPoints() { }

	// RVA: 0x27612A0 Offset: 0x27613A1 VA: 0x27612A0
	public void Simplify() { }

	// RVA: 0x27612B0 Offset: 0x27613B1 VA: 0x27612B0
	public void Simplify(double bias) { }

	// RVA: 0x27615C0 Offset: 0x27616C1 VA: 0x27615C0
	public void MergeParallelEdges(double tolerance) { }

	// RVA: 0x2761EC0 Offset: 0x2761FC1 VA: 0x2761EC0
	public void ProjectToAxis(Point2D axis, out double min, out double max) { }

	// RVA: 0x27620F0 Offset: 0x27621F1 VA: 0x27620F0
	private static void .cctor() { }
}

