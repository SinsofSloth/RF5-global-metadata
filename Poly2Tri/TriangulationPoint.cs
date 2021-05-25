public class TriangulationPoint : Point2D // TypeDefIndex: 9282
{
	// Fields
	public static readonly double kVertexCodeDefaultPrecision; // 0x0
	protected uint mVertexCode; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x1779A0 Offset: 0x177AA1 VA: 0x1779A0
	private List<DTSweepConstraint> <Edges>k__BackingField; // 0x28

	// Properties
	public override double X { get; set; }
	public override double Y { get; set; }
	public uint VertexCode { get; }
	public List<DTSweepConstraint> Edges { get; set; }
	public bool HasEdges { get; }

	// Methods

	// RVA: 0x27713A0 Offset: 0x27714A1 VA: 0x27713A0 Slot: 5
	public override double get_X() { }

	// RVA: 0x27713B0 Offset: 0x27714B1 VA: 0x27713B0 Slot: 6
	public override void set_X(double value) { }

	// RVA: 0x2771450 Offset: 0x2771551 VA: 0x2771450 Slot: 7
	public override double get_Y() { }

	// RVA: 0x2771460 Offset: 0x2771561 VA: 0x2771460 Slot: 8
	public override void set_Y(double value) { }

	// RVA: 0x2771500 Offset: 0x2771601 VA: 0x2771500
	public uint get_VertexCode() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9DB0 Offset: 0x1A9EB1 VA: 0x1A9DB0
	// RVA: 0x2771510 Offset: 0x2771611 VA: 0x2771510
	public List<DTSweepConstraint> get_Edges() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9DC0 Offset: 0x1A9EC1 VA: 0x1A9DC0
	// RVA: 0x2771520 Offset: 0x2771621 VA: 0x2771520
	private void set_Edges(List<DTSweepConstraint> value) { }

	// RVA: 0x2771530 Offset: 0x2771631 VA: 0x2771530
	public bool get_HasEdges() { }

	// RVA: 0x2762370 Offset: 0x2762471 VA: 0x2762370
	public void .ctor(double x, double y) { }

	// RVA: 0x2771540 Offset: 0x2771641 VA: 0x2771540
	public void .ctor(double x, double y, double precision) { }

	// RVA: 0x27715E0 Offset: 0x27716E1 VA: 0x27715E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2771660 Offset: 0x2771761 VA: 0x2771660 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2771670 Offset: 0x2771771 VA: 0x2771670 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x27717A0 Offset: 0x27718A1 VA: 0x27717A0 Slot: 9
	public override void Set(double x, double y) { }

	// RVA: 0x27634A0 Offset: 0x27635A1 VA: 0x27634A0
	public static uint CreateVertexCode(double x, double y, double precision) { }

	// RVA: 0x2771850 Offset: 0x2771951 VA: 0x2771850
	public void AddEdge(DTSweepConstraint e) { }

	// RVA: 0x2771900 Offset: 0x2771A01 VA: 0x2771900
	public bool HasEdge(TriangulationPoint p) { }

	// RVA: 0x2771930 Offset: 0x2771A31 VA: 0x2771930
	public bool GetEdge(TriangulationPoint p, out DTSweepConstraint edge) { }

	// RVA: 0x2771D00 Offset: 0x2771E01 VA: 0x2771D00
	public static Point2D ToPoint2D(TriangulationPoint p) { }

	// RVA: 0x2771D10 Offset: 0x2771E11 VA: 0x2771D10
	private static void .cctor() { }
}

