public class DTSweepContext : TriangulationContext // TypeDefIndex: 9257
{
	// Fields
	private readonly float ALPHA; // 0x40
	public AdvancingFront Front; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x177850 Offset: 0x177951 VA: 0x177850
	private TriangulationPoint <Head>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x177860 Offset: 0x177961 VA: 0x177860
	private TriangulationPoint <Tail>k__BackingField; // 0x58
	public DTSweepBasin Basin; // 0x60
	public DTSweepEdgeEvent EdgeEvent; // 0x68
	private DTSweepPointComparator _comparator; // 0x70

	// Properties
	public TriangulationPoint Head { get; set; }
	public TriangulationPoint Tail { get; set; }
	public override TriangulationAlgorithm Algorithm { get; }
	public override bool IsDebugEnabled { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A9B10 Offset: 0x1A9C11 VA: 0x1A9B10
	// RVA: 0x2218280 Offset: 0x2218381 VA: 0x2218280
	public TriangulationPoint get_Head() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B20 Offset: 0x1A9C21 VA: 0x1A9B20
	// RVA: 0x2218290 Offset: 0x2218391 VA: 0x2218290
	public void set_Head(TriangulationPoint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B30 Offset: 0x1A9C31 VA: 0x1A9B30
	// RVA: 0x22182A0 Offset: 0x22183A1 VA: 0x22182A0
	public TriangulationPoint get_Tail() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B40 Offset: 0x1A9C41 VA: 0x1A9B40
	// RVA: 0x22182B0 Offset: 0x22183B1 VA: 0x22182B0
	public void set_Tail(TriangulationPoint value) { }

	// RVA: 0x22182C0 Offset: 0x22183C1 VA: 0x22182C0 Slot: 4
	public override TriangulationAlgorithm get_Algorithm() { }

	// RVA: 0x22182D0 Offset: 0x22183D1 VA: 0x22182D0
	public void .ctor() { }

	// RVA: 0x22183E0 Offset: 0x22184E1 VA: 0x22183E0 Slot: 8
	public override bool get_IsDebugEnabled() { }

	// RVA: 0x22183F0 Offset: 0x22184F1 VA: 0x22183F0 Slot: 9
	protected override void set_IsDebugEnabled(bool value) { }

	// RVA: 0x2213A80 Offset: 0x2213B81 VA: 0x2213A80
	public void RemoveFromList(DelaunayTriangle triangle) { }

	// RVA: 0x22142D0 Offset: 0x22143D1 VA: 0x22142D0
	public void MeshClean(DelaunayTriangle triangle) { }

	// RVA: 0x22184A0 Offset: 0x22185A1 VA: 0x22184A0
	private void MeshCleanReq(DelaunayTriangle triangle) { }

	// RVA: 0x2218660 Offset: 0x2218761 VA: 0x2218660 Slot: 7
	public override void Clear() { }

	// RVA: 0x2214700 Offset: 0x2214801 VA: 0x2214700
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x2217A40 Offset: 0x2217B41 VA: 0x2217A40
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x22143E0 Offset: 0x22144E1 VA: 0x22143E0
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x22119B0 Offset: 0x2211AB1 VA: 0x22119B0
	public void CreateAdvancingFront() { }

	// RVA: 0x22138F0 Offset: 0x22139F1 VA: 0x22138F0
	public void MapTriangleToNodes(DelaunayTriangle t) { }

	// RVA: 0x22186D0 Offset: 0x22187D1 VA: 0x22186D0 Slot: 5
	public override void PrepareTriangulation(ITriangulatable t) { }

	// RVA: 0x2212960 Offset: 0x2212A61 VA: 0x2212960
	public void FinalizeTriangulation() { }

	// RVA: 0x2218A30 Offset: 0x2218B31 VA: 0x2218A30 Slot: 6
	public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }
}

public class DTSweepContext : TriangulationContext // TypeDefIndex: 9257
{
	// Fields
	private readonly float ALPHA; // 0x40
	public AdvancingFront Front; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x177850 Offset: 0x177951 VA: 0x177850
	private TriangulationPoint <Head>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x177860 Offset: 0x177961 VA: 0x177860
	private TriangulationPoint <Tail>k__BackingField; // 0x58
	public DTSweepBasin Basin; // 0x60
	public DTSweepEdgeEvent EdgeEvent; // 0x68
	private DTSweepPointComparator _comparator; // 0x70

	// Properties
	public TriangulationPoint Head { get; set; }
	public TriangulationPoint Tail { get; set; }
	public override TriangulationAlgorithm Algorithm { get; }
	public override bool IsDebugEnabled { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A9B10 Offset: 0x1A9C11 VA: 0x1A9B10
	// RVA: 0x2218280 Offset: 0x2218381 VA: 0x2218280
	public TriangulationPoint get_Head() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B20 Offset: 0x1A9C21 VA: 0x1A9B20
	// RVA: 0x2218290 Offset: 0x2218391 VA: 0x2218290
	public void set_Head(TriangulationPoint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B30 Offset: 0x1A9C31 VA: 0x1A9B30
	// RVA: 0x22182A0 Offset: 0x22183A1 VA: 0x22182A0
	public TriangulationPoint get_Tail() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B40 Offset: 0x1A9C41 VA: 0x1A9B40
	// RVA: 0x22182B0 Offset: 0x22183B1 VA: 0x22182B0
	public void set_Tail(TriangulationPoint value) { }

	// RVA: 0x22182C0 Offset: 0x22183C1 VA: 0x22182C0 Slot: 4
	public override TriangulationAlgorithm get_Algorithm() { }

	// RVA: 0x22182D0 Offset: 0x22183D1 VA: 0x22182D0
	public void .ctor() { }

	// RVA: 0x22183E0 Offset: 0x22184E1 VA: 0x22183E0 Slot: 8
	public override bool get_IsDebugEnabled() { }

	// RVA: 0x22183F0 Offset: 0x22184F1 VA: 0x22183F0 Slot: 9
	protected override void set_IsDebugEnabled(bool value) { }

	// RVA: 0x2213A80 Offset: 0x2213B81 VA: 0x2213A80
	public void RemoveFromList(DelaunayTriangle triangle) { }

	// RVA: 0x22142D0 Offset: 0x22143D1 VA: 0x22142D0
	public void MeshClean(DelaunayTriangle triangle) { }

	// RVA: 0x22184A0 Offset: 0x22185A1 VA: 0x22184A0
	private void MeshCleanReq(DelaunayTriangle triangle) { }

	// RVA: 0x2218660 Offset: 0x2218761 VA: 0x2218660 Slot: 7
	public override void Clear() { }

	// RVA: 0x2214700 Offset: 0x2214801 VA: 0x2214700
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x2217A40 Offset: 0x2217B41 VA: 0x2217A40
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x22143E0 Offset: 0x22144E1 VA: 0x22143E0
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x22119B0 Offset: 0x2211AB1 VA: 0x22119B0
	public void CreateAdvancingFront() { }

	// RVA: 0x22138F0 Offset: 0x22139F1 VA: 0x22138F0
	public void MapTriangleToNodes(DelaunayTriangle t) { }

	// RVA: 0x22186D0 Offset: 0x22187D1 VA: 0x22186D0 Slot: 5
	public override void PrepareTriangulation(ITriangulatable t) { }

	// RVA: 0x2212960 Offset: 0x2212A61 VA: 0x2212960
	public void FinalizeTriangulation() { }

	// RVA: 0x2218A30 Offset: 0x2218B31 VA: 0x2218A30 Slot: 6
	public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }
}

public class DTSweepContext : TriangulationContext // TypeDefIndex: 9257
{
	// Fields
	private readonly float ALPHA; // 0x40
	public AdvancingFront Front; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x177850 Offset: 0x177951 VA: 0x177850
	private TriangulationPoint <Head>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x177860 Offset: 0x177961 VA: 0x177860
	private TriangulationPoint <Tail>k__BackingField; // 0x58
	public DTSweepBasin Basin; // 0x60
	public DTSweepEdgeEvent EdgeEvent; // 0x68
	private DTSweepPointComparator _comparator; // 0x70

	// Properties
	public TriangulationPoint Head { get; set; }
	public TriangulationPoint Tail { get; set; }
	public override TriangulationAlgorithm Algorithm { get; }
	public override bool IsDebugEnabled { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A9B10 Offset: 0x1A9C11 VA: 0x1A9B10
	// RVA: 0x2218280 Offset: 0x2218381 VA: 0x2218280
	public TriangulationPoint get_Head() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B20 Offset: 0x1A9C21 VA: 0x1A9B20
	// RVA: 0x2218290 Offset: 0x2218391 VA: 0x2218290
	public void set_Head(TriangulationPoint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B30 Offset: 0x1A9C31 VA: 0x1A9B30
	// RVA: 0x22182A0 Offset: 0x22183A1 VA: 0x22182A0
	public TriangulationPoint get_Tail() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B40 Offset: 0x1A9C41 VA: 0x1A9B40
	// RVA: 0x22182B0 Offset: 0x22183B1 VA: 0x22182B0
	public void set_Tail(TriangulationPoint value) { }

	// RVA: 0x22182C0 Offset: 0x22183C1 VA: 0x22182C0 Slot: 4
	public override TriangulationAlgorithm get_Algorithm() { }

	// RVA: 0x22182D0 Offset: 0x22183D1 VA: 0x22182D0
	public void .ctor() { }

	// RVA: 0x22183E0 Offset: 0x22184E1 VA: 0x22183E0 Slot: 8
	public override bool get_IsDebugEnabled() { }

	// RVA: 0x22183F0 Offset: 0x22184F1 VA: 0x22183F0 Slot: 9
	protected override void set_IsDebugEnabled(bool value) { }

	// RVA: 0x2213A80 Offset: 0x2213B81 VA: 0x2213A80
	public void RemoveFromList(DelaunayTriangle triangle) { }

	// RVA: 0x22142D0 Offset: 0x22143D1 VA: 0x22142D0
	public void MeshClean(DelaunayTriangle triangle) { }

	// RVA: 0x22184A0 Offset: 0x22185A1 VA: 0x22184A0
	private void MeshCleanReq(DelaunayTriangle triangle) { }

	// RVA: 0x2218660 Offset: 0x2218761 VA: 0x2218660 Slot: 7
	public override void Clear() { }

	// RVA: 0x2214700 Offset: 0x2214801 VA: 0x2214700
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x2217A40 Offset: 0x2217B41 VA: 0x2217A40
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x22143E0 Offset: 0x22144E1 VA: 0x22143E0
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x22119B0 Offset: 0x2211AB1 VA: 0x22119B0
	public void CreateAdvancingFront() { }

	// RVA: 0x22138F0 Offset: 0x22139F1 VA: 0x22138F0
	public void MapTriangleToNodes(DelaunayTriangle t) { }

	// RVA: 0x22186D0 Offset: 0x22187D1 VA: 0x22186D0 Slot: 5
	public override void PrepareTriangulation(ITriangulatable t) { }

	// RVA: 0x2212960 Offset: 0x2212A61 VA: 0x2212960
	public void FinalizeTriangulation() { }

	// RVA: 0x2218A30 Offset: 0x2218B31 VA: 0x2218A30 Slot: 6
	public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }
}

public class DTSweepContext : TriangulationContext // TypeDefIndex: 9257
{
	// Fields
	private readonly float ALPHA; // 0x40
	public AdvancingFront Front; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x177850 Offset: 0x177951 VA: 0x177850
	private TriangulationPoint <Head>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x177860 Offset: 0x177961 VA: 0x177860
	private TriangulationPoint <Tail>k__BackingField; // 0x58
	public DTSweepBasin Basin; // 0x60
	public DTSweepEdgeEvent EdgeEvent; // 0x68
	private DTSweepPointComparator _comparator; // 0x70

	// Properties
	public TriangulationPoint Head { get; set; }
	public TriangulationPoint Tail { get; set; }
	public override TriangulationAlgorithm Algorithm { get; }
	public override bool IsDebugEnabled { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A9B10 Offset: 0x1A9C11 VA: 0x1A9B10
	// RVA: 0x2218280 Offset: 0x2218381 VA: 0x2218280
	public TriangulationPoint get_Head() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B20 Offset: 0x1A9C21 VA: 0x1A9B20
	// RVA: 0x2218290 Offset: 0x2218391 VA: 0x2218290
	public void set_Head(TriangulationPoint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B30 Offset: 0x1A9C31 VA: 0x1A9B30
	// RVA: 0x22182A0 Offset: 0x22183A1 VA: 0x22182A0
	public TriangulationPoint get_Tail() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B40 Offset: 0x1A9C41 VA: 0x1A9B40
	// RVA: 0x22182B0 Offset: 0x22183B1 VA: 0x22182B0
	public void set_Tail(TriangulationPoint value) { }

	// RVA: 0x22182C0 Offset: 0x22183C1 VA: 0x22182C0 Slot: 4
	public override TriangulationAlgorithm get_Algorithm() { }

	// RVA: 0x22182D0 Offset: 0x22183D1 VA: 0x22182D0
	public void .ctor() { }

	// RVA: 0x22183E0 Offset: 0x22184E1 VA: 0x22183E0 Slot: 8
	public override bool get_IsDebugEnabled() { }

	// RVA: 0x22183F0 Offset: 0x22184F1 VA: 0x22183F0 Slot: 9
	protected override void set_IsDebugEnabled(bool value) { }

	// RVA: 0x2213A80 Offset: 0x2213B81 VA: 0x2213A80
	public void RemoveFromList(DelaunayTriangle triangle) { }

	// RVA: 0x22142D0 Offset: 0x22143D1 VA: 0x22142D0
	public void MeshClean(DelaunayTriangle triangle) { }

	// RVA: 0x22184A0 Offset: 0x22185A1 VA: 0x22184A0
	private void MeshCleanReq(DelaunayTriangle triangle) { }

	// RVA: 0x2218660 Offset: 0x2218761 VA: 0x2218660 Slot: 7
	public override void Clear() { }

	// RVA: 0x2214700 Offset: 0x2214801 VA: 0x2214700
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x2217A40 Offset: 0x2217B41 VA: 0x2217A40
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x22143E0 Offset: 0x22144E1 VA: 0x22143E0
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x22119B0 Offset: 0x2211AB1 VA: 0x22119B0
	public void CreateAdvancingFront() { }

	// RVA: 0x22138F0 Offset: 0x22139F1 VA: 0x22138F0
	public void MapTriangleToNodes(DelaunayTriangle t) { }

	// RVA: 0x22186D0 Offset: 0x22187D1 VA: 0x22186D0 Slot: 5
	public override void PrepareTriangulation(ITriangulatable t) { }

	// RVA: 0x2212960 Offset: 0x2212A61 VA: 0x2212960
	public void FinalizeTriangulation() { }

	// RVA: 0x2218A30 Offset: 0x2218B31 VA: 0x2218A30 Slot: 6
	public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }
}

public class DTSweepContext : TriangulationContext // TypeDefIndex: 9257
{
	// Fields
	private readonly float ALPHA; // 0x40
	public AdvancingFront Front; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x177850 Offset: 0x177951 VA: 0x177850
	private TriangulationPoint <Head>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x177860 Offset: 0x177961 VA: 0x177860
	private TriangulationPoint <Tail>k__BackingField; // 0x58
	public DTSweepBasin Basin; // 0x60
	public DTSweepEdgeEvent EdgeEvent; // 0x68
	private DTSweepPointComparator _comparator; // 0x70

	// Properties
	public TriangulationPoint Head { get; set; }
	public TriangulationPoint Tail { get; set; }
	public override TriangulationAlgorithm Algorithm { get; }
	public override bool IsDebugEnabled { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A9B10 Offset: 0x1A9C11 VA: 0x1A9B10
	// RVA: 0x2218280 Offset: 0x2218381 VA: 0x2218280
	public TriangulationPoint get_Head() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B20 Offset: 0x1A9C21 VA: 0x1A9B20
	// RVA: 0x2218290 Offset: 0x2218391 VA: 0x2218290
	public void set_Head(TriangulationPoint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B30 Offset: 0x1A9C31 VA: 0x1A9B30
	// RVA: 0x22182A0 Offset: 0x22183A1 VA: 0x22182A0
	public TriangulationPoint get_Tail() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9B40 Offset: 0x1A9C41 VA: 0x1A9B40
	// RVA: 0x22182B0 Offset: 0x22183B1 VA: 0x22182B0
	public void set_Tail(TriangulationPoint value) { }

	// RVA: 0x22182C0 Offset: 0x22183C1 VA: 0x22182C0 Slot: 4
	public override TriangulationAlgorithm get_Algorithm() { }

	// RVA: 0x22182D0 Offset: 0x22183D1 VA: 0x22182D0
	public void .ctor() { }

	// RVA: 0x22183E0 Offset: 0x22184E1 VA: 0x22183E0 Slot: 8
	public override bool get_IsDebugEnabled() { }

	// RVA: 0x22183F0 Offset: 0x22184F1 VA: 0x22183F0 Slot: 9
	protected override void set_IsDebugEnabled(bool value) { }

	// RVA: 0x2213A80 Offset: 0x2213B81 VA: 0x2213A80
	public void RemoveFromList(DelaunayTriangle triangle) { }

	// RVA: 0x22142D0 Offset: 0x22143D1 VA: 0x22142D0
	public void MeshClean(DelaunayTriangle triangle) { }

	// RVA: 0x22184A0 Offset: 0x22185A1 VA: 0x22184A0
	private void MeshCleanReq(DelaunayTriangle triangle) { }

	// RVA: 0x2218660 Offset: 0x2218761 VA: 0x2218660 Slot: 7
	public override void Clear() { }

	// RVA: 0x2214700 Offset: 0x2214801 VA: 0x2214700
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x2217A40 Offset: 0x2217B41 VA: 0x2217A40
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x22143E0 Offset: 0x22144E1 VA: 0x22143E0
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x22119B0 Offset: 0x2211AB1 VA: 0x22119B0
	public void CreateAdvancingFront() { }

	// RVA: 0x22138F0 Offset: 0x22139F1 VA: 0x22138F0
	public void MapTriangleToNodes(DelaunayTriangle t) { }

	// RVA: 0x22186D0 Offset: 0x22187D1 VA: 0x22186D0 Slot: 5
	public override void PrepareTriangulation(ITriangulatable t) { }

	// RVA: 0x2212960 Offset: 0x2212A61 VA: 0x2212960
	public void FinalizeTriangulation() { }

	// RVA: 0x2218A30 Offset: 0x2218B31 VA: 0x2218A30 Slot: 6
	public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }
}

