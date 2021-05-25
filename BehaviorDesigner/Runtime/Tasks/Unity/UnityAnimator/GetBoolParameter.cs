[TaskCategoryAttribute] // RVA: 0x155DA0 Offset: 0x155EA1 VA: 0x155DA0
[TaskDescriptionAttribute] // RVA: 0x155DA0 Offset: 0x155EA1 VA: 0x155DA0
public class GetBoolParameter : Action // TypeDefIndex: 11385
{
	// Fields
	[TooltipAttribute] // RVA: 0x192DF0 Offset: 0x192EF1 VA: 0x192DF0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192E30 Offset: 0x192F31 VA: 0x192E30
	public SharedString paramaterName; // 0x58
	[TooltipAttribute] // RVA: 0x192E70 Offset: 0x192F71 VA: 0x192E70
	[RequiredFieldAttribute] // RVA: 0x192E70 Offset: 0x192F71 VA: 0x192E70
	public SharedBool storeValue; // 0x60
	private Animator animator; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x2790A20 Offset: 0x2790B21 VA: 0x2790A20 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2790B20 Offset: 0x2790C21 VA: 0x2790B20 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2790C30 Offset: 0x2790D31 VA: 0x2790C30 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2790CC0 Offset: 0x2790DC1 VA: 0x2790CC0
	public void .ctor() { }
}

