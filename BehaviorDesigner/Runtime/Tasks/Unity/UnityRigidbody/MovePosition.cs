[TaskCategoryAttribute] // RVA: 0x1503A0 Offset: 0x1504A1 VA: 0x1503A0
[TaskDescriptionAttribute] // RVA: 0x1503A0 Offset: 0x1504A1 VA: 0x1503A0
public class MovePosition : Action // TypeDefIndex: 11140
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A680 Offset: 0x18A781 VA: 0x18A680
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A6C0 Offset: 0x18A7C1 VA: 0x18A6C0
	public SharedVector3 position; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2884090 Offset: 0x2884191 VA: 0x2884090 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2884190 Offset: 0x2884291 VA: 0x2884190 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2884280 Offset: 0x2884381 VA: 0x2884280 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2884310 Offset: 0x2884411 VA: 0x2884310
	public void .ctor() { }
}

