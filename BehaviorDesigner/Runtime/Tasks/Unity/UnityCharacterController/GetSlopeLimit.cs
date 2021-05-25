[TaskCategoryAttribute] // RVA: 0x1544E0 Offset: 0x1545E1 VA: 0x1544E0
[TaskDescriptionAttribute] // RVA: 0x1544E0 Offset: 0x1545E1 VA: 0x1544E0
public class GetSlopeLimit : Action // TypeDefIndex: 11319
{
	// Fields
	[TooltipAttribute] // RVA: 0x190BB0 Offset: 0x190CB1 VA: 0x190BB0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x190BF0 Offset: 0x190CF1 VA: 0x190BF0
	[RequiredFieldAttribute] // RVA: 0x190BF0 Offset: 0x190CF1 VA: 0x190BF0
	public SharedFloat storeValue; // 0x58
	private CharacterController characterController; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279DAD0 Offset: 0x279DBD1 VA: 0x279DAD0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279DBD0 Offset: 0x279DCD1 VA: 0x279DBD0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279DCC0 Offset: 0x279DDC1 VA: 0x279DCC0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279DD10 Offset: 0x279DE11 VA: 0x279DD10
	public void .ctor() { }
}

