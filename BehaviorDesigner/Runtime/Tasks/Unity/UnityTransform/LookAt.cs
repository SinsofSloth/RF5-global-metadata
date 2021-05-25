[TaskCategoryAttribute] // RVA: 0x14D6B0 Offset: 0x14D7B1 VA: 0x14D6B0
[TaskDescriptionAttribute] // RVA: 0x14D6B0 Offset: 0x14D7B1 VA: 0x14D6B0
public class LookAt : Action // TypeDefIndex: 11021
{
	// Fields
	[TooltipAttribute] // RVA: 0x1865A0 Offset: 0x1866A1 VA: 0x1865A0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1865E0 Offset: 0x1866E1 VA: 0x1865E0
	public SharedGameObject targetLookAt; // 0x58
	[TooltipAttribute] // RVA: 0x186620 Offset: 0x186721 VA: 0x186620
	public SharedVector3 worldPosition; // 0x60
	[TooltipAttribute] // RVA: 0x186660 Offset: 0x186761 VA: 0x186660
	public Vector3 worldUp; // 0x68
	private Transform targetTransform; // 0x78
	private GameObject prevGameObject; // 0x80

	// Methods

	// RVA: 0x288E900 Offset: 0x288EA01 VA: 0x288E900 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288EA00 Offset: 0x288EB01 VA: 0x288EA00 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288EB80 Offset: 0x288EC81 VA: 0x288EB80 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288EC30 Offset: 0x288ED31 VA: 0x288EC30
	public void .ctor() { }
}

