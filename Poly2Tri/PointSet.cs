[DefaultMemberAttribute] // RVA: 0x147C70 Offset: 0x147D71 VA: 0x147C70
public class PointSet : Point2DList, ITriangulatable, IEnumerable<TriangulationPoint>, IEnumerable, IList<TriangulationPoint>, ICollection<TriangulationPoint> // TypeDefIndex: 9275
{
	// Fields
	protected Dictionary<uint, TriangulationPoint> mPointMap; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x177900 Offset: 0x177A01 VA: 0x177900
	private IList<DelaunayTriangle> <Triangles>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x177910 Offset: 0x177A11 VA: 0x177910
	private string <FileName>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x177920 Offset: 0x177A21 VA: 0x177920
	private bool <DisplayFlipX>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x177930 Offset: 0x177A31 VA: 0x177930
	private bool <DisplayFlipY>k__BackingField; // 0x49
	[CompilerGeneratedAttribute] // RVA: 0x177940 Offset: 0x177A41 VA: 0x177940
	private float <DisplayRotate>k__BackingField; // 0x4C
	protected double mPrecision; // 0x50

	// Properties
	public IList<TriangulationPoint> Points { get; set; }
	public IList<DelaunayTriangle> Triangles { get; set; }
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
	public virtual TriangulationMode TriangulationMode { get; }
	public TriangulationPoint Item { get; set; }

	// Methods

	// RVA: 0x27626B0 Offset: 0x27627B1 VA: 0x27626B0
	public IList<TriangulationPoint> get_Points() { }

	// RVA: 0x27626C0 Offset: 0x27627C1 VA: 0x27626C0
	private void set_Points(IList<TriangulationPoint> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9C70 Offset: 0x1A9D71 VA: 0x1A9C70
	// RVA: 0x27626D0 Offset: 0x27627D1 VA: 0x27626D0 Slot: 27
	public IList<DelaunayTriangle> get_Triangles() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9C80 Offset: 0x1A9D81 VA: 0x1A9C80
	// RVA: 0x27626E0 Offset: 0x27627E1 VA: 0x27626E0
	private void set_Triangles(IList<DelaunayTriangle> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9C90 Offset: 0x1A9D91 VA: 0x1A9C90
	// RVA: 0x27626F0 Offset: 0x27627F1 VA: 0x27626F0 Slot: 29
	public string get_FileName() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9CA0 Offset: 0x1A9DA1 VA: 0x1A9CA0
	// RVA: 0x2762700 Offset: 0x2762801 VA: 0x2762700 Slot: 30
	public void set_FileName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9CB0 Offset: 0x1A9DB1 VA: 0x1A9CB0
	// RVA: 0x2762710 Offset: 0x2762811 VA: 0x2762710 Slot: 31
	public bool get_DisplayFlipX() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9CC0 Offset: 0x1A9DC1 VA: 0x1A9CC0
	// RVA: 0x2762720 Offset: 0x2762821 VA: 0x2762720 Slot: 32
	public void set_DisplayFlipX(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9CD0 Offset: 0x1A9DD1 VA: 0x1A9CD0
	// RVA: 0x2762730 Offset: 0x2762831 VA: 0x2762730 Slot: 33
	public bool get_DisplayFlipY() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9CE0 Offset: 0x1A9DE1 VA: 0x1A9CE0
	// RVA: 0x2762740 Offset: 0x2762841 VA: 0x2762740 Slot: 34
	public void set_DisplayFlipY(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9CF0 Offset: 0x1A9DF1 VA: 0x1A9CF0
	// RVA: 0x2762750 Offset: 0x2762851 VA: 0x2762750 Slot: 35
	public float get_DisplayRotate() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9D00 Offset: 0x1A9E01 VA: 0x1A9D00
	// RVA: 0x2762760 Offset: 0x2762861 VA: 0x2762760 Slot: 36
	public void set_DisplayRotate(float value) { }

	// RVA: 0x2762770 Offset: 0x2762871 VA: 0x2762770 Slot: 37
	public double get_Precision() { }

	// RVA: 0x2762780 Offset: 0x2762881 VA: 0x2762780 Slot: 38
	public void set_Precision(double value) { }

	// RVA: 0x2762790 Offset: 0x2762891 VA: 0x2762790 Slot: 39
	public double get_MinX() { }

	// RVA: 0x27627B0 Offset: 0x27628B1 VA: 0x27627B0 Slot: 40
	public double get_MaxX() { }

	// RVA: 0x27627D0 Offset: 0x27628D1 VA: 0x27627D0 Slot: 41
	public double get_MinY() { }

	// RVA: 0x27627F0 Offset: 0x27628F1 VA: 0x27627F0 Slot: 42
	public double get_MaxY() { }

	// RVA: 0x2762810 Offset: 0x2762911 VA: 0x2762810 Slot: 43
	public Rect2D get_Bounds() { }

	// RVA: 0x2762820 Offset: 0x2762921 VA: 0x2762820 Slot: 61
	public virtual TriangulationMode get_TriangulationMode() { }

	// RVA: 0x2762830 Offset: 0x2762931 VA: 0x2762830 Slot: 49
	public TriangulationPoint get_Item(int index) { }

	// RVA: 0x2762910 Offset: 0x2762A11 VA: 0x2762910 Slot: 50
	public void set_Item(int index, TriangulationPoint value) { }

	// RVA: 0x2762980 Offset: 0x2762A81 VA: 0x2762980
	public void .ctor(List<TriangulationPoint> bounds) { }

	// RVA: 0x2762C80 Offset: 0x2762D81 VA: 0x2762C80 Slot: 48
	private IEnumerator<TriangulationPoint> System.Collections.Generic.IEnumerable<Poly2Tri.TriangulationPoint>.GetEnumerator() { }

	// RVA: 0x2762D40 Offset: 0x2762E41 VA: 0x2762D40 Slot: 51
	public int IndexOf(TriangulationPoint p) { }

	// RVA: 0x2762DB0 Offset: 0x2762EB1 VA: 0x2762DB0 Slot: 19
	public override void Add(Point2D p) { }

	// RVA: 0x2762E50 Offset: 0x2762F51 VA: 0x2762E50 Slot: 62
	public virtual void Add(TriangulationPoint p) { }

	// RVA: 0x2762E60 Offset: 0x2762F61 VA: 0x2762E60 Slot: 20
	protected override void Add(Point2D p, int idx, bool constrainToBounds) { }

	// RVA: 0x2762B80 Offset: 0x2762C81 VA: 0x2762B80
	protected bool Add(TriangulationPoint p, int idx, bool constrainToBounds) { }

	// RVA: 0x27630F0 Offset: 0x27631F1 VA: 0x27630F0 Slot: 22
	public override void AddRange(IEnumerator<Point2D> iter, Point2DList.WindingOrderType windingOrder) { }

	// RVA: 0x27632C0 Offset: 0x27633C1 VA: 0x27632C0 Slot: 63
	public virtual bool AddRange(List<TriangulationPoint> points) { }

	// RVA: 0x27633E0 Offset: 0x27634E1 VA: 0x27633E0
	public bool TryGetPoint(double x, double y, out TriangulationPoint p) { }

	// RVA: 0x27636F0 Offset: 0x27637F1 VA: 0x27636F0 Slot: 52
	public void Insert(int idx, TriangulationPoint item) { }

	// RVA: 0x2763760 Offset: 0x2763861 VA: 0x2763760 Slot: 24
	public override bool Remove(Point2D p) { }

	// RVA: 0x27637D0 Offset: 0x27638D1 VA: 0x27637D0 Slot: 60
	public bool Remove(TriangulationPoint p) { }

	// RVA: 0x2763840 Offset: 0x2763941 VA: 0x2763840 Slot: 25
	public override void RemoveAt(int idx) { }

	// RVA: 0x27638F0 Offset: 0x27639F1 VA: 0x27638F0 Slot: 58
	public bool Contains(TriangulationPoint p) { }

	// RVA: 0x2763960 Offset: 0x2763A61 VA: 0x2763960 Slot: 59
	public void CopyTo(TriangulationPoint[] array, int arrayIndex) { }

	// RVA: 0x2763B80 Offset: 0x2763C81 VA: 0x2763B80
	protected bool ConstrainPointToBounds(Point2D p) { }

	// RVA: 0x2762F10 Offset: 0x2763011 VA: 0x2762F10
	protected bool ConstrainPointToBounds(TriangulationPoint p) { }

	// RVA: 0x2763D60 Offset: 0x2763E61 VA: 0x2763D60 Slot: 64
	public virtual void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x2763E30 Offset: 0x2763F31 VA: 0x2763E30 Slot: 46
	public void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	// RVA: 0x27640B0 Offset: 0x27641B1 VA: 0x27640B0 Slot: 47
	public void ClearTriangles() { }

	// RVA: 0x2764170 Offset: 0x2764271 VA: 0x2764170 Slot: 65
	public virtual bool Initialize() { }

	// RVA: 0x2764180 Offset: 0x2764281 VA: 0x2764180 Slot: 66
	public virtual void Prepare(TriangulationContext tcx) { }
}

