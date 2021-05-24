[HelpURLAttribute] // RVA: 0x1483F0 Offset: 0x1484F1 VA: 0x1483F0
[AddComponentMenu] // RVA: 0x1483F0 Offset: 0x1484F1 VA: 0x1483F0
public class GrounderBipedIK : Grounder // TypeDefIndex: 9425
{
	// Fields
	[TooltipAttribute] // RVA: 0x179280 Offset: 0x179381 VA: 0x179280
	public BipedIK ik; // 0x40
	[TooltipAttribute] // RVA: 0x1792C0 Offset: 0x1793C1 VA: 0x1792C0
	public float spineBend; // 0x48
	[TooltipAttribute] // RVA: 0x179300 Offset: 0x179401 VA: 0x179300
	public float spineSpeed; // 0x4C
	private Transform[] feet; // 0x50
	private Quaternion[] footRotations; // 0x58
	private Vector3 animatedPelvisLocalPosition; // 0x60
	private Vector3 solvedPelvisLocalPosition; // 0x6C
	private Vector3 spineOffset; // 0x78
	private float lastWeight; // 0x84

	// Methods

	[ContextMenu] // RVA: 0x1AA3D0 Offset: 0x1AA4D1 VA: 0x1AA3D0
	// RVA: 0x2B30840 Offset: 0x2B30941 VA: 0x2B30840 Slot: 5
	protected override void OpenUserManual() { }

	[ContextMenu] // RVA: 0x1AA410 Offset: 0x1AA511 VA: 0x1AA410
	// RVA: 0x2B30890 Offset: 0x2B30991 VA: 0x2B30890 Slot: 6
	protected override void OpenScriptReference() { }

	// RVA: 0x2B308E0 Offset: 0x2B309E1 VA: 0x2B308E0 Slot: 4
	public override void ResetPosition() { }

	// RVA: 0x2B309F0 Offset: 0x2B30AF1 VA: 0x2B309F0
	private bool IsReadyToInitiate() { }

	// RVA: 0x2B30AB0 Offset: 0x2B30BB1 VA: 0x2B30AB0
	private void Update() { }

	// RVA: 0x2B30B70 Offset: 0x2B30C71 VA: 0x2B30B70
	private void Initiate() { }

	// RVA: 0x2B31150 Offset: 0x2B31251 VA: 0x2B31150
	private void OnDisable() { }

	// RVA: 0x2B311B0 Offset: 0x2B312B1 VA: 0x2B311B0
	private void OnSolverUpdate() { }

	// RVA: 0x2B31980 Offset: 0x2B31A81 VA: 0x2B31980
	private void SetLegIK(IKSolverLimb limb, int index) { }

	// RVA: 0x2B31B00 Offset: 0x2B31C01 VA: 0x2B31B00
	private void OnPostSolverUpdate() { }

	// RVA: 0x2B31C90 Offset: 0x2B31D91 VA: 0x2B31C90
	private void OnDestroy() { }

	// RVA: 0x2B31E40 Offset: 0x2B31F41 VA: 0x2B31E40
	public void .ctor() { }
}

