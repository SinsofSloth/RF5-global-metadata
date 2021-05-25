[DefaultMemberAttribute] // RVA: 0x147BB0 Offset: 0x147CB1 VA: 0x147BB0
public class Contour : Point2DList, ITriangulatable, IEnumerable<TriangulationPoint>, IEnumerable, IList<TriangulationPoint>, ICollection<TriangulationPoint> // TypeDefIndex: 9264
{
	// Fields
	private List<Contour> mHoles; // 0x30
	private ITriangulatable mParent; // 0x38
	private string mName; // 0x40

	// Properties
	public TriangulationPoint Item { get; set; }
	public string Name { get; set; }
	public IList<DelaunayTriangle> Triangles { get; set; }
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

	// Methods

	// RVA: 0x220DA30 Offset: 0x220DB31 VA: 0x220DA30 Slot: 49
	public TriangulationPoint get_Item(int index) { }

	// RVA: 0x220FEB0 Offset: 0x220FFB1 VA: 0x220FEB0 Slot: 50
	public void set_Item(int index, TriangulationPoint value) { }

	// RVA: 0x220FF20 Offset: 0x2210021 VA: 0x220FF20
	public string get_Name() { }

	// RVA: 0x220FF30 Offset: 0x2210031 VA: 0x220FF30
	public void set_Name(string value) { }

	// RVA: 0x220FF40 Offset: 0x2210041 VA: 0x220FF40 Slot: 27
	public IList<DelaunayTriangle> get_Triangles() { }

	// RVA: 0x220FFB0 Offset: 0x22100B1 VA: 0x220FFB0
	private void set_Triangles(IList<DelaunayTriangle> value) { }

	// RVA: 0x220FFC0 Offset: 0x22100C1 VA: 0x220FFC0 Slot: 28
	public TriangulationMode get_TriangulationMode() { }

	// RVA: 0x2210080 Offset: 0x2210181 VA: 0x2210080 Slot: 29
	public string get_FileName() { }

	// RVA: 0x2210140 Offset: 0x2210241 VA: 0x2210140 Slot: 30
	public void set_FileName(string value) { }

	// RVA: 0x2210150 Offset: 0x2210251 VA: 0x2210150 Slot: 31
	public bool get_DisplayFlipX() { }

	// RVA: 0x2210210 Offset: 0x2210311 VA: 0x2210210 Slot: 32
	public void set_DisplayFlipX(bool value) { }

	// RVA: 0x2210220 Offset: 0x2210321 VA: 0x2210220 Slot: 33
	public bool get_DisplayFlipY() { }

	// RVA: 0x22102E0 Offset: 0x22103E1 VA: 0x22102E0 Slot: 34
	public void set_DisplayFlipY(bool value) { }

	// RVA: 0x22102F0 Offset: 0x22103F1 VA: 0x22102F0 Slot: 35
	public float get_DisplayRotate() { }

	// RVA: 0x22103B0 Offset: 0x22104B1 VA: 0x22103B0 Slot: 36
	public void set_DisplayRotate(float value) { }

	// RVA: 0x22103C0 Offset: 0x22104C1 VA: 0x22103C0 Slot: 37
	public double get_Precision() { }

	// RVA: 0x2210480 Offset: 0x2210581 VA: 0x2210480 Slot: 38
	public void set_Precision(double value) { }

	// RVA: 0x2210490 Offset: 0x2210591 VA: 0x2210490 Slot: 39
	public double get_MinX() { }

	// RVA: 0x22104B0 Offset: 0x22105B1 VA: 0x22104B0 Slot: 40
	public double get_MaxX() { }

	// RVA: 0x22104D0 Offset: 0x22105D1 VA: 0x22104D0 Slot: 41
	public double get_MinY() { }

	// RVA: 0x22104F0 Offset: 0x22105F1 VA: 0x22104F0 Slot: 42
	public double get_MaxY() { }

	// RVA: 0x2210510 Offset: 0x2210611 VA: 0x2210510 Slot: 43
	public Rect2D get_Bounds() { }

	// RVA: 0x220DB10 Offset: 0x220DC11 VA: 0x220DB10
	public void .ctor(ITriangulatable parent) { }

	// RVA: 0x220D930 Offset: 0x220DA31 VA: 0x220D930
	public void .ctor(ITriangulatable parent, IList<TriangulationPoint> points, Point2DList.WindingOrderType windingOrder) { }

	// RVA: 0x2210890 Offset: 0x2210991 VA: 0x2210890 Slot: 3
	public override string ToString() { }

	// RVA: 0x2210900 Offset: 0x2210A01 VA: 0x2210900 Slot: 48
	private IEnumerator<TriangulationPoint> System.Collections.Generic.IEnumerable<Poly2Tri.TriangulationPoint>.GetEnumerator() { }

	// RVA: 0x2210970 Offset: 0x2210A71 VA: 0x2210970 Slot: 51
	public int IndexOf(TriangulationPoint p) { }

	// RVA: 0x22109E0 Offset: 0x2210AE1 VA: 0x22109E0 Slot: 56
	public void Add(TriangulationPoint p) { }

	// RVA: 0x2210A00 Offset: 0x2210B01 VA: 0x2210A00 Slot: 20
	protected override void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon) { }

	// RVA: 0x2210B70 Offset: 0x2210C71 VA: 0x2210B70 Slot: 22
	public override void AddRange(IEnumerator<Point2D> iter, Point2DList.WindingOrderType windingOrder) { }

	// RVA: 0x2210520 Offset: 0x2210621 VA: 0x2210520
	public void AddRange(IList<TriangulationPoint> points, Point2DList.WindingOrderType windingOrder) { }

	// RVA: 0x2211070 Offset: 0x2211171 VA: 0x2211070 Slot: 52
	public void Insert(int idx, TriangulationPoint p) { }

	// RVA: 0x2211090 Offset: 0x2211191 VA: 0x2211090 Slot: 60
	public bool Remove(TriangulationPoint p) { }

	// RVA: 0x22110A0 Offset: 0x22111A1 VA: 0x22110A0 Slot: 58
	public bool Contains(TriangulationPoint p) { }

	// RVA: 0x2211110 Offset: 0x2211211 VA: 0x2211110 Slot: 59
	public void CopyTo(TriangulationPoint[] array, int arrayIndex) { }

	// RVA: 0x2211300 Offset: 0x2211401 VA: 0x2211300
	protected void AddHole(Contour c) { }

	// RVA: 0x220DE50 Offset: 0x220DF51 VA: 0x220DE50
	public int GetNumHoles(bool parentIsHole) { }

	// RVA: 0x2211380 Offset: 0x2211481 VA: 0x2211380
	public int GetNumHoles() { }

	// RVA: 0x22113D0 Offset: 0x22114D1 VA: 0x22113D0
	public Contour GetHole(int idx) { }

	// RVA: 0x220E190 Offset: 0x220E291 VA: 0x220E190
	public void GetActualHoles(bool parentIsHole, ref List<Contour> holes) { }

	// RVA: 0x2211480 Offset: 0x2211581 VA: 0x2211480
	public List.Enumerator<Contour> GetHoleEnumerator() { }

	// RVA: 0x220FB40 Offset: 0x220FC41 VA: 0x220FB40
	public void InitializeHoles(ConstrainedPointSet cps) { }

	// RVA: 0x220E400 Offset: 0x220E501 VA: 0x220E400
	public static void InitializeHoles(List<Contour> holes, ITriangulatable parent, ConstrainedPointSet cps) { }

	// RVA: 0x22114F0 Offset: 0x22115F1 VA: 0x22114F0 Slot: 44
	public void Prepare(TriangulationContext tcx) { }

	// RVA: 0x2211560 Offset: 0x2211661 VA: 0x2211560 Slot: 45
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x22115D0 Offset: 0x22116D1 VA: 0x22115D0 Slot: 46
	public void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	// RVA: 0x2211640 Offset: 0x2211741 VA: 0x2211640 Slot: 47
	public void ClearTriangles() { }

	// RVA: 0x22116B0 Offset: 0x22117B1 VA: 0x22116B0
	public Point2D FindPointInContour() { }

	// RVA: 0x22117F0 Offset: 0x22118F1 VA: 0x22117F0
	public bool IsPointInsideContour(Point2D p) { }
}

