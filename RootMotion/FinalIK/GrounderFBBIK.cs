[HelpURLAttribute] // RVA: 0x148450 Offset: 0x148551 VA: 0x148450
[AddComponentMenu] // RVA: 0x148450 Offset: 0x148551 VA: 0x148450
public class GrounderFBBIK : Grounder // TypeDefIndex: 9426
{
	// Fields
	[TooltipAttribute] // RVA: 0x179340 Offset: 0x179441 VA: 0x179340
	public FullBodyBipedIK ik; // 0x40
	[TooltipAttribute] // RVA: 0x179380 Offset: 0x179481 VA: 0x179380
	public float spineBend; // 0x48
	[TooltipAttribute] // RVA: 0x1793C0 Offset: 0x1794C1 VA: 0x1793C0
	public float spineSpeed; // 0x4C
	public GrounderFBBIK.SpineEffector[] spine; // 0x50
	private Transform[] feet; // 0x58
	private Vector3 spineOffset; // 0x60
	private bool firstSolve; // 0x6C

	// Methods

	[ContextMenu] // RVA: 0x1AA450 Offset: 0x1AA551 VA: 0x1AA450
	// RVA: 0x2B31FA0 Offset: 0x2B320A1 VA: 0x2B31FA0
	private void OpenTutorial() { }

	[ContextMenu] // RVA: 0x1AA490 Offset: 0x1AA591 VA: 0x1AA490
	// RVA: 0x2B31FF0 Offset: 0x2B320F1 VA: 0x2B31FF0 Slot: 5
	protected override void OpenUserManual() { }

	[ContextMenu] // RVA: 0x1AA4D0 Offset: 0x1AA5D1 VA: 0x1AA4D0
	// RVA: 0x2B32040 Offset: 0x2B32141 VA: 0x2B32040 Slot: 6
	protected override void OpenScriptReference() { }

	// RVA: 0x2B32090 Offset: 0x2B32191 VA: 0x2B32090 Slot: 4
	public override void ResetPosition() { }

	// RVA: 0x2B32110 Offset: 0x2B32211 VA: 0x2B32110
	private bool IsReadyToInitiate() { }

	// RVA: 0x2B321B0 Offset: 0x2B322B1 VA: 0x2B321B0
	private void Update() { }

	// RVA: 0x2B324B0 Offset: 0x2B325B1 VA: 0x2B324B0
	private void FixedUpdate() { }

	// RVA: 0x2B324C0 Offset: 0x2B325C1 VA: 0x2B324C0
	private void LateUpdate() { }

	// RVA: 0x2B32270 Offset: 0x2B32371 VA: 0x2B32270
	private void Initiate() { }

	// RVA: 0x2B324D0 Offset: 0x2B325D1 VA: 0x2B324D0
	private void OnSolverUpdate() { }

	// RVA: 0x2B32970 Offset: 0x2B32A71 VA: 0x2B32970
	private void SetLegIK(IKEffector effector, Grounding.Leg leg) { }

	// RVA: 0x2B32B30 Offset: 0x2B32C31 VA: 0x2B32B30
	private void OnDrawGizmosSelected() { }

	// RVA: 0x2B32C90 Offset: 0x2B32D91 VA: 0x2B32C90
	private void OnDestroy() { }

	// RVA: 0x2B32DC0 Offset: 0x2B32EC1 VA: 0x2B32DC0
	public void .ctor() { }
}

