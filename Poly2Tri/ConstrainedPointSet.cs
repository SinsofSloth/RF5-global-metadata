public class ConstrainedPointSet : PointSet // TypeDefIndex: 9274
{
	// Fields
	protected Dictionary<uint, TriangulationConstraint> mConstraintMap; // 0x58
	protected List<Contour> mHoles; // 0x60

	// Properties
	public override TriangulationMode TriangulationMode { get; }

	// Methods

	// RVA: 0x220C190 Offset: 0x220C291 VA: 0x220C190 Slot: 61
	public override TriangulationMode get_TriangulationMode() { }

	// RVA: 0x220C1A0 Offset: 0x220C2A1 VA: 0x220C1A0
	public void .ctor(List<TriangulationPoint> bounds) { }

	// RVA: 0x220C600 Offset: 0x220C701 VA: 0x220C600
	public void .ctor(List<TriangulationPoint> bounds, List<TriangulationConstraint> constraints) { }

	// RVA: 0x220C910 Offset: 0x220CA11 VA: 0x220C910
	public void .ctor(List<TriangulationPoint> bounds, int[] indices) { }

	// RVA: 0x220C270 Offset: 0x220C371 VA: 0x220C270
	protected void AddBoundaryConstraints() { }

	// RVA: 0x220CDC0 Offset: 0x220CEC1 VA: 0x220CDC0 Slot: 19
	public override void Add(Point2D p) { }

	// RVA: 0x220CE60 Offset: 0x220CF61 VA: 0x220CE60 Slot: 62
	public override void Add(TriangulationPoint p) { }

	// RVA: 0x220CE70 Offset: 0x220CF71 VA: 0x220CE70 Slot: 63
	public override bool AddRange(List<TriangulationPoint> points) { }

	// RVA: 0x220CF90 Offset: 0x220D091 VA: 0x220CF90
	public bool AddHole(List<TriangulationPoint> points, string name) { }

	// RVA: 0x220C6E0 Offset: 0x220C7E1 VA: 0x220C6E0
	public bool AddConstraints(List<TriangulationConstraint> constraints) { }

	// RVA: 0x220CBB0 Offset: 0x220CCB1 VA: 0x220CBB0
	public bool AddConstraint(TriangulationConstraint tc) { }

	// RVA: 0x220DBF0 Offset: 0x220DCF1 VA: 0x220DBF0
	public bool TryGetConstraint(uint constraintCode, out TriangulationConstraint tc) { }

	// RVA: 0x220DC60 Offset: 0x220DD61 VA: 0x220DC60
	public int GetNumConstraints() { }

	// RVA: 0x220DCC0 Offset: 0x220DDC1 VA: 0x220DCC0
	public Dictionary.Enumerator<uint, TriangulationConstraint> GetConstraintEnumerator() { }

	// RVA: 0x220DD30 Offset: 0x220DE31 VA: 0x220DD30
	public int GetNumHoles() { }

	// RVA: 0x220DF80 Offset: 0x220E081 VA: 0x220DF80
	public Contour GetHole(int idx) { }

	// RVA: 0x220E030 Offset: 0x220E131 VA: 0x220E030
	public int GetActualHoles(out List<Contour> holes) { }

	// RVA: 0x220E2E0 Offset: 0x220E3E1 VA: 0x220E2E0
	protected void InitializeHoles() { }

	// RVA: 0x220FC70 Offset: 0x220FD71 VA: 0x220FC70 Slot: 65
	public override bool Initialize() { }

	// RVA: 0x220FCA0 Offset: 0x220FDA1 VA: 0x220FCA0 Slot: 66
	public override void Prepare(TriangulationContext tcx) { }

	// RVA: 0x220FDE0 Offset: 0x220FEE1 VA: 0x220FDE0 Slot: 64
	public override void AddTriangle(DelaunayTriangle t) { }
}

