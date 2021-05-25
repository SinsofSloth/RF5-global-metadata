[TaskDescriptionAttribute] // RVA: 0x14BBF0 Offset: 0x14BCF1 VA: 0x14BBF0
[TaskCategoryAttribute] // RVA: 0x14BBF0 Offset: 0x14BCF1 VA: 0x14BBF0
public class HasEnteredCollision2D : Conditional // TypeDefIndex: 10948
{
	// Fields
	[TooltipAttribute] // RVA: 0x183950 Offset: 0x183A51 VA: 0x183950
	public SharedString tag; // 0x50
	[TooltipAttribute] // RVA: 0x183990 Offset: 0x183A91 VA: 0x183990
	public SharedGameObject collidedGameObject; // 0x58
	private bool enteredCollision; // 0x60

	// Methods

	// RVA: 0x20DF3E0 Offset: 0x20DF4E1 VA: 0x20DF3E0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20DF400 Offset: 0x20DF501 VA: 0x20DF400 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20DF410 Offset: 0x20DF511 VA: 0x20DF410 Slot: 22
	public override void OnCollisionEnter2D(Collision2D collision) { }

	// RVA: 0x20DF500 Offset: 0x20DF601 VA: 0x20DF500 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20DF600 Offset: 0x20DF701 VA: 0x20DF600
	public void .ctor() { }
}

