[TaskCategoryAttribute] // RVA: 0x14F630 Offset: 0x14F731 VA: 0x14F630
[TaskDescriptionAttribute] // RVA: 0x14F630 Offset: 0x14F731 VA: 0x14F630
public class GetPosition : Action // TypeDefIndex: 11105
{
	// Fields
	[TooltipAttribute] // RVA: 0x189320 Offset: 0x189421 VA: 0x189320
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189360 Offset: 0x189461 VA: 0x189360
	[RequiredFieldAttribute] // RVA: 0x189360 Offset: 0x189461 VA: 0x189360
	public SharedVector2 storeValue; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2887E60 Offset: 0x2887F61 VA: 0x2887E60 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2887F60 Offset: 0x2888061 VA: 0x2887F60 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2888050 Offset: 0x2888151 VA: 0x2888050 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28880E0 Offset: 0x28881E1 VA: 0x28880E0
	public void .ctor() { }
}

