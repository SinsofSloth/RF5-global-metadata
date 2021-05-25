[HelpURLAttribute] // RVA: 0x148CE0 Offset: 0x148DE1 VA: 0x148CE0
[AddComponentMenu] // RVA: 0x148CE0 Offset: 0x148DE1 VA: 0x148CE0
public class RotationLimitAngle : RotationLimit // TypeDefIndex: 9535
{
	// Fields
	[RangeAttribute] // RVA: 0x17C050 Offset: 0x17C151 VA: 0x17C050
	public float limit; // 0x38
	[RangeAttribute] // RVA: 0x17C070 Offset: 0x17C171 VA: 0x17C070
	public float twistLimit; // 0x3C

	// Methods

	[ContextMenu] // RVA: 0x1ABDA0 Offset: 0x1ABEA1 VA: 0x1ABDA0
	// RVA: 0x2920D90 Offset: 0x2920E91 VA: 0x2920D90
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x1ABDE0 Offset: 0x1ABEE1 VA: 0x1ABDE0
	// RVA: 0x2920DE0 Offset: 0x2920EE1 VA: 0x2920DE0
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x1ABE20 Offset: 0x1ABF21 VA: 0x1ABE20
	// RVA: 0x2920E30 Offset: 0x2920F31 VA: 0x2920E30
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x1ABE60 Offset: 0x1ABF61 VA: 0x1ABE60
	// RVA: 0x2920E80 Offset: 0x2920F81 VA: 0x2920E80
	private void ASThread() { }

	// RVA: 0x2920ED0 Offset: 0x2920FD1 VA: 0x2920ED0 Slot: 4
	protected override Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x2920F90 Offset: 0x2921091 VA: 0x2920F90
	private Quaternion LimitSwing(Quaternion rotation) { }

	// RVA: 0x29211D0 Offset: 0x29212D1 VA: 0x29211D0
	public void .ctor() { }
}

