public class Rect2D // TypeDefIndex: 9298
{
	// Fields
	private double mMinX; // 0x10
	private double mMaxX; // 0x18
	private double mMinY; // 0x20
	private double mMaxY; // 0x28

	// Properties
	public double MinX { get; set; }
	public double MaxX { get; set; }
	public double MinY { get; set; }
	public double MaxY { get; set; }
	public double Left { get; set; }
	public double Right { get; set; }
	public double Top { get; set; }
	public double Bottom { get; set; }
	public double Width { get; }
	public double Height { get; }
	public bool Empty { get; }

	// Methods

	// RVA: 0x276F380 Offset: 0x276F481 VA: 0x276F380
	public double get_MinX() { }

	// RVA: 0x276F390 Offset: 0x276F491 VA: 0x276F390
	public void set_MinX(double value) { }

	// RVA: 0x276F3A0 Offset: 0x276F4A1 VA: 0x276F3A0
	public double get_MaxX() { }

	// RVA: 0x276F3B0 Offset: 0x276F4B1 VA: 0x276F3B0
	public void set_MaxX(double value) { }

	// RVA: 0x276F3C0 Offset: 0x276F4C1 VA: 0x276F3C0
	public double get_MinY() { }

	// RVA: 0x276F3D0 Offset: 0x276F4D1 VA: 0x276F3D0
	public void set_MinY(double value) { }

	// RVA: 0x276F3E0 Offset: 0x276F4E1 VA: 0x276F3E0
	public double get_MaxY() { }

	// RVA: 0x276F3F0 Offset: 0x276F4F1 VA: 0x276F3F0
	public void set_MaxY(double value) { }

	// RVA: 0x276F400 Offset: 0x276F501 VA: 0x276F400
	public double get_Left() { }

	// RVA: 0x276F410 Offset: 0x276F511 VA: 0x276F410
	public void set_Left(double value) { }

	// RVA: 0x276F420 Offset: 0x276F521 VA: 0x276F420
	public double get_Right() { }

	// RVA: 0x276F430 Offset: 0x276F531 VA: 0x276F430
	public void set_Right(double value) { }

	// RVA: 0x276F440 Offset: 0x276F541 VA: 0x276F440
	public double get_Top() { }

	// RVA: 0x276F450 Offset: 0x276F551 VA: 0x276F450
	public void set_Top(double value) { }

	// RVA: 0x276F460 Offset: 0x276F561 VA: 0x276F460
	public double get_Bottom() { }

	// RVA: 0x276F470 Offset: 0x276F571 VA: 0x276F470
	public void set_Bottom(double value) { }

	// RVA: 0x275E9C0 Offset: 0x275EAC1 VA: 0x275E9C0
	public double get_Width() { }

	// RVA: 0x275E9D0 Offset: 0x275EAD1 VA: 0x275E9D0
	public double get_Height() { }

	// RVA: 0x276F480 Offset: 0x276F581 VA: 0x276F480
	public bool get_Empty() { }

	// RVA: 0x275D340 Offset: 0x275D441 VA: 0x275D340
	public void .ctor() { }

	// RVA: 0x276F4B0 Offset: 0x276F5B1 VA: 0x276F4B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x276F4C0 Offset: 0x276F5C1 VA: 0x276F4C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x276F5C0 Offset: 0x276F6C1 VA: 0x276F5C0
	public bool Equals(Rect2D r) { }

	// RVA: 0x276F640 Offset: 0x276F741 VA: 0x276F640
	public bool Equals(Rect2D r, double epsilon) { }

	// RVA: 0x275DC90 Offset: 0x275DD91 VA: 0x275DC90
	public void Clear() { }

	// RVA: 0x276F7E0 Offset: 0x276F8E1 VA: 0x276F7E0
	public void Set(double xmin, double xmax, double ymin, double ymax) { }

	// RVA: 0x275D870 Offset: 0x275D971 VA: 0x275D870
	public void Set(Rect2D b) { }

	// RVA: 0x276F8F0 Offset: 0x276F9F1 VA: 0x276F8F0
	public void SetSize(double w, double h) { }

	// RVA: 0x276F910 Offset: 0x276FA11 VA: 0x276F910
	public bool Contains(double x, double y) { }

	// RVA: 0x276F960 Offset: 0x276FA61 VA: 0x276F960
	public bool Contains(Point2D p) { }

	// RVA: 0x276FA20 Offset: 0x276FB21 VA: 0x276FA20
	public bool Contains(Rect2D r) { }

	// RVA: 0x276FA90 Offset: 0x276FB91 VA: 0x276FA90
	public bool ContainsInclusive(double x, double y) { }

	// RVA: 0x276FAE0 Offset: 0x276FBE1 VA: 0x276FAE0
	public bool ContainsInclusive(double x, double y, double epsilon) { }

	// RVA: 0x276FB40 Offset: 0x276FC41 VA: 0x276FB40
	public bool ContainsInclusive(Point2D p) { }

	// RVA: 0x276FC00 Offset: 0x276FD01 VA: 0x276FC00
	public bool ContainsInclusive(Point2D p, double epsilon) { }

	// RVA: 0x276FCE0 Offset: 0x276FDE1 VA: 0x276FCE0
	public bool ContainsInclusive(Rect2D r) { }

	// RVA: 0x276FD50 Offset: 0x276FE51 VA: 0x276FD50
	public bool ContainsInclusive(Rect2D r, double epsilon) { }

	// RVA: 0x2769550 Offset: 0x2769651 VA: 0x2769550
	public bool Intersects(Rect2D r) { }

	// RVA: 0x276FDD0 Offset: 0x276FED1 VA: 0x276FDD0
	public Point2D GetCenter() { }

	// RVA: 0x276FE60 Offset: 0x276FF61 VA: 0x276FE60
	public bool IsNormalized() { }

	// RVA: 0x276F800 Offset: 0x276F901 VA: 0x276F800
	public void Normalize() { }

	// RVA: 0x275DE30 Offset: 0x275DF31 VA: 0x275DE30
	public void AddPoint(Point2D p) { }

	// RVA: 0x276FE90 Offset: 0x276FF91 VA: 0x276FE90
	public void Inflate(double w, double h) { }

	// RVA: 0x276FEC0 Offset: 0x276FFC1 VA: 0x276FEC0
	public void Inflate(double left, double top, double right, double bottom) { }

	// RVA: 0x276FEF0 Offset: 0x276FFF1 VA: 0x276FEF0
	public void Offset(double w, double h) { }

	// RVA: 0x276FF20 Offset: 0x2770021 VA: 0x276FF20
	public void SetPosition(double x, double y) { }

	// RVA: 0x276FF50 Offset: 0x2770051 VA: 0x276FF50
	public bool Intersection(Rect2D r1, Rect2D r2) { }

	// RVA: 0x27700A0 Offset: 0x27701A1 VA: 0x27700A0
	public void Union(Rect2D r1, Rect2D r2) { }
}

