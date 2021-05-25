[Serializable]
public class IKSolverHeuristic : IKSolver // TypeDefIndex: 9486
{
	// Fields
	public Transform target; // 0x58
	public float tolerance; // 0x60
	public int maxIterations; // 0x64
	public bool useRotationLimits; // 0x68
	public bool XY; // 0x69
	public IKSolver.Bone[] bones; // 0x70
	protected Vector3 lastLocalDirection; // 0x78
	protected float chainLength; // 0x84

	// Properties
	protected virtual int minBones { get; }
	protected virtual bool boneLengthCanBeZero { get; }
	protected virtual bool allowCommonParent { get; }
	protected virtual Vector3 localDirection { get; }
	protected float positionOffset { get; }

	// Methods

	// RVA: 0x258EAF0 Offset: 0x258EBF1 VA: 0x258EAF0
	public bool SetChain(Transform[] hierarchy, Transform root) { }

	// RVA: 0x258ECB0 Offset: 0x258EDB1 VA: 0x258ECB0
	public void AddBone(Transform bone) { }

	// RVA: 0x258EE30 Offset: 0x258EF31 VA: 0x258EE30 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x258EEE0 Offset: 0x258EFE1 VA: 0x258EEE0 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x258EF60 Offset: 0x258F061 VA: 0x258EF60 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x258F2E0 Offset: 0x258F3E1 VA: 0x258F2E0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x258F2F0 Offset: 0x258F3F1 VA: 0x258F2F0 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x258F3F0 Offset: 0x258F4F1 VA: 0x258F3F0 Slot: 12
	protected virtual int get_minBones() { }

	// RVA: 0x258F400 Offset: 0x258F501 VA: 0x258F400 Slot: 13
	protected virtual bool get_boneLengthCanBeZero() { }

	// RVA: 0x258F410 Offset: 0x258F511 VA: 0x258F410 Slot: 14
	protected virtual bool get_allowCommonParent() { }

	// RVA: 0x258F420 Offset: 0x258F521 VA: 0x258F420 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x258F430 Offset: 0x258F531 VA: 0x258F430 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x25845F0 Offset: 0x25846F1 VA: 0x25845F0
	protected void InitiateBones() { }

	// RVA: 0x258F440 Offset: 0x258F541 VA: 0x258F440 Slot: 15
	protected virtual Vector3 get_localDirection() { }

	// RVA: 0x2585200 Offset: 0x2585301 VA: 0x2585200
	protected float get_positionOffset() { }

	// RVA: 0x2584E70 Offset: 0x2584F71 VA: 0x2584E70
	protected Vector3 GetSingularityOffset() { }

	// RVA: 0x258F580 Offset: 0x258F681 VA: 0x258F580
	private bool SingularityDetected() { }

	// RVA: 0x25831D0 Offset: 0x25832D1 VA: 0x25831D0
	public void .ctor() { }
}

