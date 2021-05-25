[HelpURLAttribute] // RVA: 0x1487B0 Offset: 0x1488B1 VA: 0x1487B0
[AddComponentMenu] // RVA: 0x1487B0 Offset: 0x1488B1 VA: 0x1487B0
public class FullBodyBipedIK : IK // TypeDefIndex: 9441
{
	// Fields
	public BipedReferences references; // 0x38
	public IKSolverFullBodyBiped solver; // 0x40

	// Methods

	[ContextMenu] // RVA: 0x1AACB0 Offset: 0x1AADB1 VA: 0x1AACB0
	// RVA: 0x2B2ED10 Offset: 0x2B2EE11 VA: 0x2B2ED10 Slot: 8
	protected override void OpenUserManual() { }

	[ContextMenu] // RVA: 0x1AACF0 Offset: 0x1AADF1 VA: 0x1AACF0
	// RVA: 0x2B2ED60 Offset: 0x2B2EE61 VA: 0x2B2ED60 Slot: 9
	protected override void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x1AAD30 Offset: 0x1AAE31 VA: 0x1AAD30
	// RVA: 0x2B2EDB0 Offset: 0x2B2EEB1 VA: 0x2B2EDB0
	private void OpenSetupTutorial() { }

	[ContextMenu] // RVA: 0x1AAD70 Offset: 0x1AAE71 VA: 0x1AAD70
	// RVA: 0x2B2EE00 Offset: 0x2B2EF01 VA: 0x2B2EE00
	private void OpenInspectorTutorial() { }

	[ContextMenu] // RVA: 0x1AADB0 Offset: 0x1AAEB1 VA: 0x1AADB0
	// RVA: 0x2B2EE50 Offset: 0x2B2EF51 VA: 0x2B2EE50
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x1AADF0 Offset: 0x1AAEF1 VA: 0x1AADF0
	// RVA: 0x2B2EEA0 Offset: 0x2B2EFA1 VA: 0x2B2EEA0
	private void ASThread() { }

	// RVA: 0x2B2EEF0 Offset: 0x2B2EFF1 VA: 0x2B2EEF0
	public void SetReferences(BipedReferences references, Transform rootNode) { }

	// RVA: 0x2B2EF40 Offset: 0x2B2F041 VA: 0x2B2EF40 Slot: 7
	public override IKSolver GetIKSolver() { }

	// RVA: 0x2B2EF50 Offset: 0x2B2F051 VA: 0x2B2EF50
	public bool ReferencesError(ref string errorMessage) { }

	// RVA: 0x2B2F120 Offset: 0x2B2F221 VA: 0x2B2F120
	public bool ReferencesWarning(ref string warningMessage) { }

	[ContextMenu] // RVA: 0x1AAE30 Offset: 0x1AAF31 VA: 0x1AAE30
	// RVA: 0x2B2F480 Offset: 0x2B2F581 VA: 0x2B2F480
	private void Reinitiate() { }

	[ContextMenu] // RVA: 0x1AAE70 Offset: 0x1AAF71 VA: 0x1AAE70
	// RVA: 0x2B2F4E0 Offset: 0x2B2F5E1 VA: 0x2B2F4E0
	private void AutoDetectReferences() { }

	// RVA: 0x2B2F5E0 Offset: 0x2B2F6E1 VA: 0x2B2F5E0
	public void .ctor() { }
}

