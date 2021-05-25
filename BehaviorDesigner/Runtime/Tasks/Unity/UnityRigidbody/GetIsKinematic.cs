[TaskCategoryAttribute] // RVA: 0x1500A0 Offset: 0x1501A1 VA: 0x1500A0
[TaskDescriptionAttribute] // RVA: 0x1500A0 Offset: 0x1501A1 VA: 0x1500A0
public class GetIsKinematic : Action // TypeDefIndex: 11132
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A2A0 Offset: 0x18A3A1 VA: 0x18A2A0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A2E0 Offset: 0x18A3E1 VA: 0x18A2E0
	[RequiredFieldAttribute] // RVA: 0x18A2E0 Offset: 0x18A3E1 VA: 0x18A2E0
	public SharedBool storeValue; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2882DD0 Offset: 0x2882ED1 VA: 0x2882DD0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2882ED0 Offset: 0x2882FD1 VA: 0x2882ED0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2882FD0 Offset: 0x28830D1 VA: 0x2882FD0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2883020 Offset: 0x2883121 VA: 0x2883020
	public void .ctor() { }
}

