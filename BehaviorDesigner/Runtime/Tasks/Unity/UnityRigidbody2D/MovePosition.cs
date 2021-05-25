[TaskCategoryAttribute] // RVA: 0x14F810 Offset: 0x14F911 VA: 0x14F810
[TaskDescriptionAttribute] // RVA: 0x14F810 Offset: 0x14F911 VA: 0x14F810
public class MovePosition : Action // TypeDefIndex: 11110
{
	// Fields
	[TooltipAttribute] // RVA: 0x189550 Offset: 0x189651 VA: 0x189550
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189590 Offset: 0x189691 VA: 0x189590
	public SharedVector2 position; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x28889D0 Offset: 0x2888AD1 VA: 0x28889D0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2888AD0 Offset: 0x2888BD1 VA: 0x2888AD0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2888BC0 Offset: 0x2888CC1 VA: 0x2888BC0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2888C50 Offset: 0x2888D51 VA: 0x2888C50
	public void .ctor() { }
}

