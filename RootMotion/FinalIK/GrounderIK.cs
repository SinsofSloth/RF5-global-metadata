[HelpURLAttribute] // RVA: 0x1484B0 Offset: 0x1485B1 VA: 0x1484B0
[AddComponentMenu] // RVA: 0x1484B0 Offset: 0x1485B1 VA: 0x1484B0
public class GrounderIK : Grounder // TypeDefIndex: 9428
{
	// Fields
	public IK[] legs; // 0x40
	[TooltipAttribute] // RVA: 0x179400 Offset: 0x179501 VA: 0x179400
	public Transform pelvis; // 0x48
	[TooltipAttribute] // RVA: 0x179440 Offset: 0x179541 VA: 0x179440
	public Transform characterRoot; // 0x50
	[TooltipAttribute] // RVA: 0x179480 Offset: 0x179581 VA: 0x179480
	[RangeAttribute] // RVA: 0x179480 Offset: 0x179581 VA: 0x179480
	public float rootRotationWeight; // 0x58
	[TooltipAttribute] // RVA: 0x1794E0 Offset: 0x1795E1 VA: 0x1794E0
	public float rootRotationSpeed; // 0x5C
	[TooltipAttribute] // RVA: 0x179520 Offset: 0x179621 VA: 0x179520
	public float maxRootRotationAngle; // 0x60
	private Transform[] feet; // 0x68
	private Quaternion[] footRotations; // 0x70
	private Vector3 animatedPelvisLocalPosition; // 0x78
	private Vector3 solvedPelvisLocalPosition; // 0x84
	private int solvedFeet; // 0x90
	private bool solved; // 0x94
	private float lastWeight; // 0x98
	private Rigidbody characterRootRigidbody; // 0xA0

	// Methods

	[ContextMenu] // RVA: 0x1AA510 Offset: 0x1AA611 VA: 0x1AA510
	// RVA: 0x2B32F80 Offset: 0x2B33081 VA: 0x2B32F80 Slot: 5
	protected override void OpenUserManual() { }

	[ContextMenu] // RVA: 0x1AA550 Offset: 0x1AA651 VA: 0x1AA550
	// RVA: 0x2B32FD0 Offset: 0x2B330D1 VA: 0x2B32FD0 Slot: 6
	protected override void OpenScriptReference() { }

	// RVA: 0x2B33020 Offset: 0x2B33121 VA: 0x2B33020 Slot: 4
	public override void ResetPosition() { }

	// RVA: 0x2B33040 Offset: 0x2B33141 VA: 0x2B33040
	private bool IsReadyToInitiate() { }

	// RVA: 0x2B33230 Offset: 0x2B33331 VA: 0x2B33230
	private void OnDisable() { }

	// RVA: 0x2B33330 Offset: 0x2B33431 VA: 0x2B33330
	private void Update() { }

	// RVA: 0x2B33A90 Offset: 0x2B33B91 VA: 0x2B33A90
	private void Initiate() { }

	// RVA: 0x2B33EE0 Offset: 0x2B33FE1 VA: 0x2B33EE0
	private void OnSolverUpdate() { }

	// RVA: 0x2B34160 Offset: 0x2B34261 VA: 0x2B34160
	private void SetLegIK(int index) { }

	// RVA: 0x2B34490 Offset: 0x2B34591 VA: 0x2B34490
	private void OnPostSolverUpdate() { }

	// RVA: 0x2B34630 Offset: 0x2B34731 VA: 0x2B34630
	private void OnDestroy() { }

	// RVA: 0x2B34820 Offset: 0x2B34921 VA: 0x2B34820
	public void .ctor() { }
}

