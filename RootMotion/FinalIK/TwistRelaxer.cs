public class TwistRelaxer : MonoBehaviour // TypeDefIndex: 9506
{
	// Fields
	public IK ik; // 0x18
	[TooltipAttribute] // RVA: 0x17B5B0 Offset: 0x17B6B1 VA: 0x17B5B0
	public Transform parent; // 0x20
	[TooltipAttribute] // RVA: 0x17B5F0 Offset: 0x17B6F1 VA: 0x17B5F0
	public Transform child; // 0x28
	[TooltipAttribute] // RVA: 0x17B630 Offset: 0x17B731 VA: 0x17B630
	[RangeAttribute] // RVA: 0x17B630 Offset: 0x17B731 VA: 0x17B630
	public float weight; // 0x30
	[TooltipAttribute] // RVA: 0x17B690 Offset: 0x17B791 VA: 0x17B690
	[RangeAttribute] // RVA: 0x17B690 Offset: 0x17B791 VA: 0x17B690
	public float parentChildCrossfade; // 0x34
	[TooltipAttribute] // RVA: 0x17B6F0 Offset: 0x17B7F1 VA: 0x17B6F0
	[RangeAttribute] // RVA: 0x17B6F0 Offset: 0x17B7F1 VA: 0x17B6F0
	public float twistAngleOffset; // 0x38
	private Vector3 twistAxis; // 0x3C
	private Vector3 axis; // 0x48
	private Vector3 axisRelativeToParentDefault; // 0x54
	private Vector3 axisRelativeToChildDefault; // 0x60

	// Methods

	// RVA: 0x2925300 Offset: 0x2925401 VA: 0x2925300
	public void Relax() { }

	// RVA: 0x29256E0 Offset: 0x29257E1 VA: 0x29256E0
	private void Start() { }

	// RVA: 0x2925B90 Offset: 0x2925C91 VA: 0x2925B90
	private void OnPostUpdate() { }

	// RVA: 0x2925C20 Offset: 0x2925D21 VA: 0x2925C20
	private void LateUpdate() { }

	// RVA: 0x2925CB0 Offset: 0x2925DB1 VA: 0x2925CB0
	private void OnDestroy() { }

	// RVA: 0x2925DE0 Offset: 0x2925EE1 VA: 0x2925DE0
	public void .ctor() { }
}

