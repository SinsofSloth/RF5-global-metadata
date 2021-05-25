[TaskCategoryAttribute] // RVA: 0x14E490 Offset: 0x14E591 VA: 0x14E490
[TaskDescriptionAttribute] // RVA: 0x14E490 Offset: 0x14E591 VA: 0x14E490
public class SetCenter : Action // TypeDefIndex: 11058
{
	// Fields
	[TooltipAttribute] // RVA: 0x187980 Offset: 0x187A81 VA: 0x187980
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1879C0 Offset: 0x187AC1 VA: 0x1879C0
	public SharedVector3 center; // 0x58
	private SphereCollider sphereCollider; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288A800 Offset: 0x288A901 VA: 0x288A800 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288A900 Offset: 0x288AA01 VA: 0x288A900 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288A9F0 Offset: 0x288AAF1 VA: 0x288A9F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288AA80 Offset: 0x288AB81 VA: 0x288AA80
	public void .ctor() { }
}

