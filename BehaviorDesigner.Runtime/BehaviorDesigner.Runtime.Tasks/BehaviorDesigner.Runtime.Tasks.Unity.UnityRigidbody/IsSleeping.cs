[TaskCategoryAttribute] // RVA: 0x150340 Offset: 0x150441 VA: 0x150340
[TaskDescriptionAttribute] // RVA: 0x150340 Offset: 0x150441 VA: 0x150340
public class IsSleeping : Conditional // TypeDefIndex: 11139
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A640 Offset: 0x18A741 VA: 0x18A640
	public SharedGameObject targetGameObject; // 0x50
	private Rigidbody rigidbody; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x2883E90 Offset: 0x2883F91 VA: 0x2883E90 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2883F90 Offset: 0x2884091 VA: 0x2883F90 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2884070 Offset: 0x2884171 VA: 0x2884070 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2884080 Offset: 0x2884181 VA: 0x2884080
	public void .ctor() { }
}

