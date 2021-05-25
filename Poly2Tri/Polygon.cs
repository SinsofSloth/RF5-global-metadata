[DefaultMemberAttribute] // RVA: 0x147BF0 Offset: 0x147CF1 VA: 0x147BF0
public class Polygon : Point2DList, ITriangulatable, IEnumerable<TriangulationPoint>, IEnumerable, IList<TriangulationPoint>, ICollection<TriangulationPoint> // TypeDefIndex: 9265
{
	// Fields
	protected Dictionary<uint, TriangulationPoint> mPointMap; // 0x30
	protected List<DelaunayTriangle> mTriangles; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x177870 Offset: 0x177971 VA: 0x177870
	private string <FileName>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x177880 Offset: 0x177981 VA: 0x177880
	private bool <DisplayFlipX>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x177890 Offset: 0x177991 VA: 0x177890
	private bool <DisplayFlipY>k__BackingField; // 0x49
	[CompilerGeneratedAttribute] // RVA: 0x1778A0 Offset: 0x1779A1 VA: 0x1778A0
	private float <DisplayRotate>k__BackingField; // 0x4C
	private double mPrecision; // 0x50
	protected List<Polygon> mHoles; // 0x58
	protected List<TriangulationPoint> mSteinerPoints; // 0x60
	protected PolygonPoint _last; // 0x68

	// Properties
	public IList<TriangulationPoint> Points { get; }
	public IList<DelaunayTriangle> Triangles { get; }
	public TriangulationMode TriangulationMode { get; }
	public string FileName { get; set; }
	public bool DisplayFlipX { get; set; }
	public bool DisplayFlipY { get; set; }
	public float DisplayRotate { get; set; }
	public double Precision { get; set; }
	public double MinX { get; }
	public double MaxX { get; }
	public double MinY { get; }
	public double MaxY { get; }
	public Rect2D Bounds { get; }
	public TriangulationPoint Item { get; set; }
	public IList<Polygon> Holes { get; }

	// Methods

	// RVA: 0x2764330 Offset: 0x2764431 VA: 0x2764330
	public IList<TriangulationPoint> get_Points() { }

	// RVA: 0x2764340 Offset: 0x2764441 VA: 0x2764340 Slot: 27
	public IList<DelaunayTriangle> get_Triangles() { }

	// RVA: 0x2764350 Offset: 0x2764451 VA: 0x2764350 Slot: 28
	public TriangulationMode get_TriangulationMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B50 Offset: 0x1A9C51 VA: 0x1A9B50
	// RVA: 0x2764360 Offset: 0x2764461 VA: 0x2764360 Slot: 29
	public string get_FileName() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B60 Offset: 0x1A9C61 VA: 0x1A9B60
	// RVA: 0x2764370 Offset: 0x2764471 VA: 0x2764370 Slot: 30
	public void set_FileName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B70 Offset: 0x1A9C71 VA: 0x1A9B70
	// RVA: 0x2764380 Offset: 0x2764481 VA: 0x2764380 Slot: 31
	public bool get_DisplayFlipX() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B80 Offset: 0x1A9C81 VA: 0x1A9B80
	// RVA: 0x2764390 Offset: 0x2764491 VA: 0x2764390 Slot: 32
	public void set_DisplayFlipX(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B90 Offset: 0x1A9C91 VA: 0x1A9B90
	// RVA: 0x27643A0 Offset: 0x27644A1 VA: 0x27643A0 Slot: 33
	public bool get_DisplayFlipY() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9BA0 Offset: 0x1A9CA1 VA: 0x1A9BA0
	// RVA: 0x27643B0 Offset: 0x27644B1 VA: 0x27643B0 Slot: 34
	public void set_DisplayFlipY(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9BB0 Offset: 0x1A9CB1 VA: 0x1A9BB0
	// RVA: 0x27643C0 Offset: 0x27644C1 VA: 0x27643C0 Slot: 35
	public float get_DisplayRotate() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9BC0 Offset: 0x1A9CC1 VA: 0x1A9BC0
	// RVA: 0x27643D0 Offset: 0x27644D1 VA: 0x27643D0 Slot: 36
	public void set_DisplayRotate(float value) { }

	// RVA: 0x27643E0 Offset: 0x27644E1 VA: 0x27643E0 Slot: 37
	public double get_Precision() { }

	// RVA: 0x27643F0 Offset: 0x27644F1 VA: 0x27643F0 Slot: 38
	public void set_Precision(double value) { }

	// RVA: 0x2764400 Offset: 0x2764501 VA: 0x2764400 Slot: 39
	public double get_MinX() { }

	// RVA: 0x2764420 Offset: 0x2764521 VA: 0x2764420 Slot: 40
	public double get_MaxX() { }

	// RVA: 0x2764440 Offset: 0x2764541 VA: 0x2764440 Slot: 41
	public double get_MinY() { }

	// RVA: 0x2764460 Offset: 0x2764561 VA: 0x2764460 Slot: 42
	public double get_MaxY() { }

	// RVA: 0x2764480 Offset: 0x2764581 VA: 0x2764480 Slot: 43
	public Rect2D get_Bounds() { }

	// RVA: 0x2764490 Offset: 0x2764591 VA: 0x2764490 Slot: 49
	public TriangulationPoint get_Item(int index) { }

	// RVA: 0x2764570 Offset: 0x2764671 VA: 0x2764570 Slot: 50
	public void set_Item(int index, TriangulationPoint value) { }

	// RVA: 0x27645E0 Offset: 0x27646E1 VA: 0x27645E0
	public IList<Polygon> get_Holes() { }

	// RVA: 0x27645F0 Offset: 0x27646F1 VA: 0x27645F0
	public void .ctor(IList<PolygonPoint> points) { }

	// RVA: 0x2764B40 Offset: 0x2764C41 VA: 0x2764B40
	public void .ctor(IEnumerable<PolygonPoint> points) { }

	// RVA: 0x2764BD0 Offset: 0x2764CD1 VA: 0x2764BD0
	public void .ctor(PolygonPoint[] points) { }

	// RVA: 0x2764BE0 Offset: 0x2764CE1 VA: 0x2764BE0 Slot: 48
	private IEnumerator<TriangulationPoint> System.Collections.Generic.IEnumerable<Poly2Tri.TriangulationPoint>.GetEnumerator() { }

	// RVA: 0x2764C60 Offset: 0x2764D61 VA: 0x2764C60 Slot: 51
	public int IndexOf(TriangulationPoint p) { }

	// RVA: 0x2764CD0 Offset: 0x2764DD1 VA: 0x2764CD0 Slot: 19
	public override void Add(Point2D p) { }

	// RVA: 0x2764CF0 Offset: 0x2764DF1 VA: 0x2764CF0 Slot: 56
	public void Add(TriangulationPoint p) { }

	// RVA: 0x2764D10 Offset: 0x2764E11 VA: 0x2764D10
	public void Add(PolygonPoint p) { }

	// RVA: 0x2764D30 Offset: 0x2764E31 VA: 0x2764D30 Slot: 20
	protected override void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon) { }

	// RVA: 0x27647A0 Offset: 0x27648A1 VA: 0x27647A0
	public void AddRange(IList<PolygonPoint> points, Point2DList.WindingOrderType windingOrder) { }

	// RVA: 0x2764EC0 Offset: 0x2764FC1 VA: 0x2764EC0
	public void AddRange(IList<TriangulationPoint> points, Point2DList.WindingOrderType windingOrder) { }

	// RVA: 0x2765260 Offset: 0x2765361 VA: 0x2765260 Slot: 52
	public void Insert(int idx, TriangulationPoint p) { }

	// RVA: 0x2765280 Offset: 0x2765381 VA: 0x2765280 Slot: 60
	public bool Remove(TriangulationPoint p) { }

	// RVA: 0x2765320 Offset: 0x2765421 VA: 0x2765320
	public void RemovePoint(PolygonPoint p) { }

	// RVA: 0x27654F0 Offset: 0x27655F1 VA: 0x27654F0 Slot: 58
	public bool Contains(TriangulationPoint p) { }

	// RVA: 0x2765560 Offset: 0x2765661 VA: 0x2765560 Slot: 59
	public void CopyTo(TriangulationPoint[] array, int arrayIndex) { }

	// RVA: 0x2765780 Offset: 0x2765881 VA: 0x2765780
	public void AddSteinerPoint(TriangulationPoint point) { }

	// RVA: 0x2765830 Offset: 0x2765931 VA: 0x2765830
	public void AddSteinerPoints(List<TriangulationPoint> points) { }

	// RVA: 0x27658E0 Offset: 0x27659E1 VA: 0x27658E0
	public void ClearSteinerPoints() { }

	// RVA: 0x2765940 Offset: 0x2765A41 VA: 0x2765940
	public void AddHole(Polygon poly) { }

	// RVA: 0x27659F0 Offset: 0x2765AF1 VA: 0x27659F0 Slot: 45
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x2765A60 Offset: 0x2765B61 VA: 0x2765A60 Slot: 46
	public void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	// RVA: 0x2765AD0 Offset: 0x2765BD1 VA: 0x2765AD0 Slot: 47
	public void ClearTriangles() { }

	// RVA: 0x2765B30 Offset: 0x2765C31 VA: 0x2765B30
	public bool IsPointInside(TriangulationPoint p) { }

	// RVA: 0x2765EE0 Offset: 0x2765FE1 VA: 0x2765EE0 Slot: 44
	public void Prepare(TriangulationContext tcx) { }
}

