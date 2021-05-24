[TaskCategoryAttribute] // RVA: 0x14FF80 Offset: 0x150081 VA: 0x14FF80
[TaskDescriptionAttribute] // RVA: 0x14FF80 Offset: 0x150081 VA: 0x14FF80
public class GetCenterOfMass : Action // TypeDefIndex: 11129
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A0F0 Offset: 0x18A1F1 VA: 0x18A0F0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A130 Offset: 0x18A231 VA: 0x18A130
	[RequiredFieldAttribute] // RVA: 0x18A130 Offset: 0x18A231 VA: 0x18A130
	public SharedVector3 storeValue; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2882690 Offset: 0x2882791 VA: 0x2882690 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2882790 Offset: 0x2882891 VA: 0x2882790 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2882880 Offset: 0x2882981 VA: 0x2882880 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2882910 Offset: 0x2882A11 VA: 0x2882910
	public void .ctor() { }
}

