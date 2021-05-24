[TaskCategoryAttribute] // RVA: 0x154480 Offset: 0x154581 VA: 0x154480
[TaskDescriptionAttribute] // RVA: 0x154480 Offset: 0x154581 VA: 0x154480
public class GetRadius : Action // TypeDefIndex: 11318
{
	// Fields
	[TooltipAttribute] // RVA: 0x190B20 Offset: 0x190C21 VA: 0x190B20
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x190B60 Offset: 0x190C61 VA: 0x190B60
	[RequiredFieldAttribute] // RVA: 0x190B60 Offset: 0x190C61 VA: 0x190B60
	public SharedFloat storeValue; // 0x58
	private CharacterController characterController; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279D880 Offset: 0x279D981 VA: 0x279D880 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279D980 Offset: 0x279DA81 VA: 0x279D980 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279DA70 Offset: 0x279DB71 VA: 0x279DA70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279DAC0 Offset: 0x279DBC1 VA: 0x279DAC0
	public void .ctor() { }
}

