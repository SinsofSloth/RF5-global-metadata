public class PolygonPoint : TriangulationPoint // TypeDefIndex: 9266
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1778B0 Offset: 0x1779B1 VA: 0x1778B0
	private PolygonPoint <Next>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x1778C0 Offset: 0x1779C1 VA: 0x1778C0
	private PolygonPoint <Previous>k__BackingField; // 0x38

	// Properties
	public PolygonPoint Next { get; set; }
	public PolygonPoint Previous { get; set; }

	// Methods

	// RVA: 0x2766AF0 Offset: 0x2766BF1 VA: 0x2766AF0
	public void .ctor(double x, double y) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9BD0 Offset: 0x1A9CD1 VA: 0x1A9BD0
	// RVA: 0x27684E0 Offset: 0x27685E1 VA: 0x27684E0
	public PolygonPoint get_Next() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9BE0 Offset: 0x1A9CE1 VA: 0x1A9BE0
	// RVA: 0x27684F0 Offset: 0x27685F1 VA: 0x27684F0
	public void set_Next(PolygonPoint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9BF0 Offset: 0x1A9CF1 VA: 0x1A9BF0
	// RVA: 0x2768500 Offset: 0x2768601 VA: 0x2768500
	public PolygonPoint get_Previous() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9C00 Offset: 0x1A9D01 VA: 0x1A9C00
	// RVA: 0x2768510 Offset: 0x2768611 VA: 0x2768510
	public void set_Previous(PolygonPoint value) { }

	// RVA: 0x2768520 Offset: 0x2768621 VA: 0x2768520
	public static Point2D ToBasePoint(PolygonPoint p) { }

	// RVA: 0x2768530 Offset: 0x2768631 VA: 0x2768530
	public static TriangulationPoint ToTriangulationPoint(PolygonPoint p) { }
}

