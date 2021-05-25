[HelpURLAttribute] // RVA: 0x148D40 Offset: 0x148E41 VA: 0x148D40
[AddComponentMenu] // RVA: 0x148D40 Offset: 0x148E41 VA: 0x148D40
public class RotationLimitHinge : RotationLimit // TypeDefIndex: 9536
{
	// Fields
	public bool useLimits; // 0x38
	public float min; // 0x3C
	public float max; // 0x40
	[HideInInspector] // RVA: 0x17C090 Offset: 0x17C191 VA: 0x17C090
	public float zeroAxisDisplayOffset; // 0x44
	private Quaternion lastRotation; // 0x48
	private float lastAngle; // 0x58

	// Methods

	[ContextMenu] // RVA: 0x1ABEA0 Offset: 0x1ABFA1 VA: 0x1ABEA0
	// RVA: 0x2921260 Offset: 0x2921361 VA: 0x2921260
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x1ABEE0 Offset: 0x1ABFE1 VA: 0x1ABEE0
	// RVA: 0x29212B0 Offset: 0x29213B1 VA: 0x29212B0
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x1ABF20 Offset: 0x1AC021 VA: 0x1ABF20
	// RVA: 0x2921300 Offset: 0x2921401 VA: 0x2921300
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x1ABF60 Offset: 0x1AC061 VA: 0x1ABF60
	// RVA: 0x2921350 Offset: 0x2921451 VA: 0x2921350
	private void ASThread() { }

	// RVA: 0x29213A0 Offset: 0x29214A1 VA: 0x29213A0 Slot: 4
	protected override Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x29213D0 Offset: 0x29214D1 VA: 0x29213D0
	private Quaternion LimitHinge(Quaternion rotation) { }

	// RVA: 0x29216D0 Offset: 0x29217D1 VA: 0x29216D0
	public void .ctor() { }
}

