[TaskDescriptionAttribute] // RVA: 0x14BB90 Offset: 0x14BC91 VA: 0x14BB90
[TaskCategoryAttribute] // RVA: 0x14BB90 Offset: 0x14BC91 VA: 0x14BB90
public class HasEnteredCollision : Conditional // TypeDefIndex: 10947
{
	// Fields
	[TooltipAttribute] // RVA: 0x1838D0 Offset: 0x1839D1 VA: 0x1838D0
	public SharedString tag; // 0x50
	[TooltipAttribute] // RVA: 0x183910 Offset: 0x183A11 VA: 0x183910
	public SharedGameObject collidedGameObject; // 0x58
	private bool enteredCollision; // 0x60

	// Methods

	// RVA: 0x20DF0C0 Offset: 0x20DF1C1 VA: 0x20DF0C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20DF0E0 Offset: 0x20DF1E1 VA: 0x20DF0E0 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20DF0F0 Offset: 0x20DF1F1 VA: 0x20DF0F0 Slot: 18
	public override void OnCollisionEnter(Collision collision) { }

	// RVA: 0x20DF1E0 Offset: 0x20DF2E1 VA: 0x20DF1E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20DF2E0 Offset: 0x20DF3E1 VA: 0x20DF2E0
	public void .ctor() { }
}

