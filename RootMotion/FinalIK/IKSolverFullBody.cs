[Serializable]
public class IKSolverFullBody : IKSolver // TypeDefIndex: 9482
{
	// Fields
	[RangeAttribute] // RVA: 0x17B190 Offset: 0x17B291 VA: 0x17B190
	public int iterations; // 0x58
	public FBIKChain[] chain; // 0x60
	public IKEffector[] effectors; // 0x68
	public IKMappingSpine spineMapping; // 0x70
	public IKMappingBone[] boneMappings; // 0x78
	public IKMappingLimb[] limbMappings; // 0x80
	public bool FABRIKPass; // 0x88
	public IKSolver.UpdateDelegate OnPreRead; // 0x90
	public IKSolver.UpdateDelegate OnPreSolve; // 0x98
	public IKSolver.IterationDelegate OnPreIteration; // 0xA0
	public IKSolver.IterationDelegate OnPostIteration; // 0xA8
	public IKSolver.UpdateDelegate OnPreBend; // 0xB0
	public IKSolver.UpdateDelegate OnPostSolve; // 0xB8
	public IKSolver.UpdateDelegate OnStoreDefaultLocalState; // 0xC0
	public IKSolver.UpdateDelegate OnFixTransforms; // 0xC8

	// Methods

	// RVA: 0x2589B80 Offset: 0x2589C81 VA: 0x2589B80
	public IKEffector GetEffector(Transform t) { }

	// RVA: 0x2589C80 Offset: 0x2589D81 VA: 0x2589C80
	public FBIKChain GetChain(Transform transform) { }

	// RVA: 0x2589CF0 Offset: 0x2589DF1 VA: 0x2589CF0
	public int GetChainIndex(Transform transform) { }

	// RVA: 0x257DF10 Offset: 0x257E011 VA: 0x257DF10
	public IKSolver.Node GetNode(int chainIndex, int nodeIndex) { }

	// RVA: 0x2589E30 Offset: 0x2589F31 VA: 0x2589E30
	public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex) { }

	// RVA: 0x2589EB0 Offset: 0x2589FB1 VA: 0x2589EB0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x258A0A0 Offset: 0x258A1A1 VA: 0x258A0A0 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x258A220 Offset: 0x258A321 VA: 0x258A220 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x258A420 Offset: 0x258A521 VA: 0x258A420 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x258A540 Offset: 0x258A641 VA: 0x258A540 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x258A680 Offset: 0x258A781 VA: 0x258A680 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x258A800 Offset: 0x258A901 VA: 0x258A800 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x258A9C0 Offset: 0x258AAC1 VA: 0x258A9C0 Slot: 12
	protected virtual void ReadPose() { }

	// RVA: 0x258AC10 Offset: 0x258AD11 VA: 0x258AC10 Slot: 13
	protected virtual void Solve() { }

	// RVA: 0x258AF10 Offset: 0x258B011 VA: 0x258AF10 Slot: 14
	protected virtual void ApplyBendConstraints() { }

	// RVA: 0x258AF60 Offset: 0x258B061 VA: 0x258AF60 Slot: 15
	protected virtual void WritePose() { }

	// RVA: 0x258B050 Offset: 0x258B151 VA: 0x258B050
	public void .ctor() { }
}

