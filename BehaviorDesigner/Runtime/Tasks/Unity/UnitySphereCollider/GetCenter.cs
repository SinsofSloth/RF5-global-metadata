[TaskCategoryAttribute] // RVA: 0x14E3D0 Offset: 0x14E4D1 VA: 0x14E3D0
[TaskDescriptionAttribute] // RVA: 0x14E3D0 Offset: 0x14E4D1 VA: 0x14E3D0
public class GetCenter : Action // TypeDefIndex: 11056
{
	// Fields
	[TooltipAttribute] // RVA: 0x187860 Offset: 0x187961 VA: 0x187860
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1878A0 Offset: 0x1879A1 VA: 0x1878A0
	[RequiredFieldAttribute] // RVA: 0x1878A0 Offset: 0x1879A1 VA: 0x1878A0
	public SharedVector3 storeValue; // 0x58
	private SphereCollider sphereCollider; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288A330 Offset: 0x288A431 VA: 0x288A330 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288A430 Offset: 0x288A531 VA: 0x288A430 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288A520 Offset: 0x288A621 VA: 0x288A520 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288A5A0 Offset: 0x288A6A1 VA: 0x288A5A0
	public void .ctor() { }
}

