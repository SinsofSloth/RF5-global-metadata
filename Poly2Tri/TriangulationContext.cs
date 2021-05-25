public abstract class TriangulationContext // TypeDefIndex: 9279
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x177950 Offset: 0x177A51 VA: 0x177950
	private TriangulationDebugContext <DebugContext>k__BackingField; // 0x10
	public readonly List<DelaunayTriangle> Triangles; // 0x18
	public readonly List<TriangulationPoint> Points; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x177960 Offset: 0x177A61 VA: 0x177960
	private TriangulationMode <TriangulationMode>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x177970 Offset: 0x177A71 VA: 0x177970
	private ITriangulatable <Triangulatable>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x177980 Offset: 0x177A81 VA: 0x177980
	private int <StepCount>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x177990 Offset: 0x177A91 VA: 0x177990
	private bool <IsDebugEnabled>k__BackingField; // 0x3C

	// Properties
	public TriangulationDebugContext DebugContext { get; set; }
	public TriangulationMode TriangulationMode { get; set; }
	public ITriangulatable Triangulatable { get; set; }
	public int StepCount { get; set; }
	public abstract TriangulationAlgorithm Algorithm { get; }
	public virtual bool IsDebugEnabled { get; set; }
	public DTSweepDebugContext DTDebugContext { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A9D10 Offset: 0x1A9E11 VA: 0x1A9D10
	// RVA: 0x2770F80 Offset: 0x2771081 VA: 0x2770F80
	public TriangulationDebugContext get_DebugContext() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9D20 Offset: 0x1A9E21 VA: 0x1A9D20
	// RVA: 0x2770F90 Offset: 0x2771091 VA: 0x2770F90
	protected void set_DebugContext(TriangulationDebugContext value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9D30 Offset: 0x1A9E31 VA: 0x1A9D30
	// RVA: 0x2770FA0 Offset: 0x27710A1 VA: 0x2770FA0
	public TriangulationMode get_TriangulationMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9D40 Offset: 0x1A9E41 VA: 0x1A9D40
	// RVA: 0x2770FB0 Offset: 0x27710B1 VA: 0x2770FB0
	protected void set_TriangulationMode(TriangulationMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9D50 Offset: 0x1A9E51 VA: 0x1A9D50
	// RVA: 0x2770FC0 Offset: 0x27710C1 VA: 0x2770FC0
	public ITriangulatable get_Triangulatable() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9D60 Offset: 0x1A9E61 VA: 0x1A9D60
	// RVA: 0x2770FD0 Offset: 0x27710D1 VA: 0x2770FD0
	private void set_Triangulatable(ITriangulatable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9D70 Offset: 0x1A9E71 VA: 0x1A9D70
	// RVA: 0x2770FE0 Offset: 0x27710E1 VA: 0x2770FE0
	public int get_StepCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9D80 Offset: 0x1A9E81 VA: 0x1A9D80
	// RVA: 0x2770FF0 Offset: 0x27710F1 VA: 0x2770FF0
	private void set_StepCount(int value) { }

	// RVA: 0x2771000 Offset: 0x2771101 VA: 0x2771000
	public void Done() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract TriangulationAlgorithm get_Algorithm() { }

	// RVA: 0x2771010 Offset: 0x2771111 VA: 0x2771010 Slot: 5
	public virtual void PrepareTriangulation(ITriangulatable t) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }

	// RVA: 0x2771150 Offset: 0x2771251 VA: 0x2771150
	public void Update(string message) { }

	// RVA: 0x2771160 Offset: 0x2771261 VA: 0x2771160 Slot: 7
	public virtual void Clear() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9D90 Offset: 0x1A9E91 VA: 0x1A9D90
	// RVA: 0x27711E0 Offset: 0x27712E1 VA: 0x27711E0 Slot: 8
	public virtual bool get_IsDebugEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9DA0 Offset: 0x1A9EA1 VA: 0x1A9DA0
	// RVA: 0x27711F0 Offset: 0x27712F1 VA: 0x27711F0 Slot: 9
	protected virtual void set_IsDebugEnabled(bool value) { }

	// RVA: 0x2771200 Offset: 0x2771301 VA: 0x2771200
	public DTSweepDebugContext get_DTDebugContext() { }

	// RVA: 0x27712A0 Offset: 0x27713A1 VA: 0x27712A0
	protected void .ctor() { }
}

