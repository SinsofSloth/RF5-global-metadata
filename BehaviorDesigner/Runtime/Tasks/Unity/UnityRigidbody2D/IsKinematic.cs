[TaskCategoryAttribute] // RVA: 0x14F750 Offset: 0x14F851 VA: 0x14F750
[TaskDescriptionAttribute] // RVA: 0x14F750 Offset: 0x14F851 VA: 0x14F750
public class IsKinematic : Conditional // TypeDefIndex: 11108
{
	// Fields
	[TooltipAttribute] // RVA: 0x1894D0 Offset: 0x1895D1 VA: 0x1894D0
	public SharedGameObject targetGameObject; // 0x50
	private Rigidbody2D rigidbody2D; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x28885D0 Offset: 0x28886D1 VA: 0x28885D0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28886D0 Offset: 0x28887D1 VA: 0x28886D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28887B0 Offset: 0x28888B1 VA: 0x28887B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28887C0 Offset: 0x28888C1 VA: 0x28887C0
	public void .ctor() { }
}

