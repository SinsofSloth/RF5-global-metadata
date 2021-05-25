public class DTSweepDebugContext : TriangulationDebugContext // TypeDefIndex: 9258
{
	// Fields
	private DelaunayTriangle _primaryTriangle; // 0x18
	private DelaunayTriangle _secondaryTriangle; // 0x20
	private TriangulationPoint _activePoint; // 0x28
	private AdvancingFrontNode _activeNode; // 0x30
	private DTSweepConstraint _activeConstraint; // 0x38

	// Properties
	public DelaunayTriangle PrimaryTriangle { get; set; }
	public DelaunayTriangle SecondaryTriangle { get; set; }
	public TriangulationPoint ActivePoint { get; set; }
	public AdvancingFrontNode ActiveNode { get; set; }
	public DTSweepConstraint ActiveConstraint { get; set; }
	public bool IsDebugContext { get; }

	// Methods

	// RVA: 0x2218AD0 Offset: 0x2218BD1 VA: 0x2218AD0
	public DelaunayTriangle get_PrimaryTriangle() { }

	// RVA: 0x2215100 Offset: 0x2215201 VA: 0x2215100
	public void set_PrimaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x2218AE0 Offset: 0x2218BE1 VA: 0x2218AE0
	public DelaunayTriangle get_SecondaryTriangle() { }

	// RVA: 0x2216CA0 Offset: 0x2216DA1 VA: 0x2216CA0
	public void set_SecondaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x2218AF0 Offset: 0x2218BF1 VA: 0x2218AF0
	public TriangulationPoint get_ActivePoint() { }

	// RVA: 0x2218B00 Offset: 0x2218C01 VA: 0x2218B00
	public void set_ActivePoint(TriangulationPoint value) { }

	// RVA: 0x2218B80 Offset: 0x2218C81 VA: 0x2218B80
	public AdvancingFrontNode get_ActiveNode() { }

	// RVA: 0x2213FB0 Offset: 0x22140B1 VA: 0x2213FB0
	public void set_ActiveNode(AdvancingFrontNode value) { }

	// RVA: 0x2218B90 Offset: 0x2218C91 VA: 0x2218B90
	public DTSweepConstraint get_ActiveConstraint() { }

	// RVA: 0x2212BE0 Offset: 0x2212CE1 VA: 0x2212BE0
	public void set_ActiveConstraint(DTSweepConstraint value) { }

	// RVA: 0x2218490 Offset: 0x2218591 VA: 0x2218490
	public void .ctor(DTSweepContext tcx) { }

	// RVA: 0x2218BA0 Offset: 0x2218CA1 VA: 0x2218BA0
	public bool get_IsDebugContext() { }

	// RVA: 0x2218BB0 Offset: 0x2218CB1 VA: 0x2218BB0 Slot: 4
	public override void Clear() { }
}

