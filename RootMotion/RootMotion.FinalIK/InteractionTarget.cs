[HelpURLAttribute] // RVA: 0x148BB0 Offset: 0x148CB1 VA: 0x148BB0
[AddComponentMenu] // RVA: 0x148BB0 Offset: 0x148CB1 VA: 0x148BB0
public class InteractionTarget : MonoBehaviour // TypeDefIndex: 9519
{
	// Fields
	[TooltipAttribute] // RVA: 0x17BC50 Offset: 0x17BD51 VA: 0x17BC50
	public FullBodyBipedEffector effectorType; // 0x18
	[TooltipAttribute] // RVA: 0x17BC90 Offset: 0x17BD91 VA: 0x17BC90
	public InteractionTarget.Multiplier[] multipliers; // 0x20
	[TooltipAttribute] // RVA: 0x17BCD0 Offset: 0x17BDD1 VA: 0x17BCD0
	public float interactionSpeedMlp; // 0x28
	[TooltipAttribute] // RVA: 0x17BD10 Offset: 0x17BE11 VA: 0x17BD10
	public Transform pivot; // 0x30
	[TooltipAttribute] // RVA: 0x17BD50 Offset: 0x17BE51 VA: 0x17BD50
	public Vector3 twistAxis; // 0x38
	[TooltipAttribute] // RVA: 0x17BD90 Offset: 0x17BE91 VA: 0x17BD90
	public float twistWeight; // 0x44
	[TooltipAttribute] // RVA: 0x17BDD0 Offset: 0x17BED1 VA: 0x17BDD0
	public float swingWeight; // 0x48
	[TooltipAttribute] // RVA: 0x17BE10 Offset: 0x17BF11 VA: 0x17BE10
	public bool rotateOnce; // 0x4C
	private Quaternion defaultLocalRotation; // 0x50
	private Transform lastPivot; // 0x60

	// Methods

	[ContextMenu] // RVA: 0x1AB990 Offset: 0x1ABA91 VA: 0x1AB990
	// RVA: 0x29181B0 Offset: 0x29182B1 VA: 0x29181B0
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x1AB9D0 Offset: 0x1ABAD1 VA: 0x1AB9D0
	// RVA: 0x2918200 Offset: 0x2918301 VA: 0x2918200
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x1ABA10 Offset: 0x1ABB11 VA: 0x1ABA10
	// RVA: 0x2918250 Offset: 0x2918351 VA: 0x2918250
	private void OpenTutorial1() { }

	[ContextMenu] // RVA: 0x1ABA50 Offset: 0x1ABB51 VA: 0x1ABA50
	// RVA: 0x29182A0 Offset: 0x29183A1 VA: 0x29182A0
	private void OpenTutorial2() { }

	[ContextMenu] // RVA: 0x1ABA90 Offset: 0x1ABB91 VA: 0x1ABA90
	// RVA: 0x29182F0 Offset: 0x29183F1 VA: 0x29182F0
	private void OpenTutorial3() { }

	[ContextMenu] // RVA: 0x1ABAD0 Offset: 0x1ABBD1 VA: 0x1ABAD0
	// RVA: 0x2918340 Offset: 0x2918441 VA: 0x2918340
	private void OpenTutorial4() { }

	[ContextMenu] // RVA: 0x1ABB10 Offset: 0x1ABC11 VA: 0x1ABB10
	// RVA: 0x2918390 Offset: 0x2918491 VA: 0x2918390
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x1ABB50 Offset: 0x1ABC51 VA: 0x1ABB50
	// RVA: 0x29183E0 Offset: 0x29184E1 VA: 0x29183E0
	private void ASThread() { }

	// RVA: 0x2918430 Offset: 0x2918531 VA: 0x2918430
	public float GetValue(InteractionObject.WeightCurve.Type curveType) { }

	// RVA: 0x29184B0 Offset: 0x29185B1 VA: 0x29184B0
	public void ResetRotation() { }

	// RVA: 0x2918550 Offset: 0x2918651 VA: 0x2918550
	public void RotateTo(Vector3 position) { }

	// RVA: 0x2918A90 Offset: 0x2918B91 VA: 0x2918A90
	public void .ctor() { }
}

