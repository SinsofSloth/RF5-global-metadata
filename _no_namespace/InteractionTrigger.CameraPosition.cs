[Serializable]
public class InteractionTrigger.CameraPosition // TypeDefIndex: 9523
{
	// Fields
	[TooltipAttribute] // RVA: 0x198450 Offset: 0x198551 VA: 0x198450
	public Collider lookAtTarget; // 0x10
	[TooltipAttribute] // RVA: 0x198490 Offset: 0x198591 VA: 0x198490
	public Vector3 direction; // 0x18
	[TooltipAttribute] // RVA: 0x1984D0 Offset: 0x1985D1 VA: 0x1984D0
	public float maxDistance; // 0x24
	[TooltipAttribute] // RVA: 0x198510 Offset: 0x198611 VA: 0x198510
	[RangeAttribute] // RVA: 0x198510 Offset: 0x198611 VA: 0x198510
	public float maxAngle; // 0x28
	[TooltipAttribute] // RVA: 0x198570 Offset: 0x198671 VA: 0x198570
	public bool fixYAxis; // 0x2C

	// Methods

	// RVA: 0x2918E90 Offset: 0x2918F91 VA: 0x2918E90
	public Quaternion GetRotation() { }

	// RVA: 0x2919040 Offset: 0x2919141 VA: 0x2919040
	public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error) { }

	// RVA: 0x2919320 Offset: 0x2919421 VA: 0x2919320
	public void .ctor() { }
}

