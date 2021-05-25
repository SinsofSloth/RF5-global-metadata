[TaskDescriptionAttribute] // RVA: 0x14BD70 Offset: 0x14BE71 VA: 0x14BD70
[TaskCategoryAttribute] // RVA: 0x14BD70 Offset: 0x14BE71 VA: 0x14BD70
public class HasExitedCollision2D : Conditional // TypeDefIndex: 10952
{
	// Fields
	[TooltipAttribute] // RVA: 0x183B50 Offset: 0x183C51 VA: 0x183B50
	public SharedString tag; // 0x50
	[TooltipAttribute] // RVA: 0x183B90 Offset: 0x183C91 VA: 0x183B90
	public SharedGameObject collidedGameObject; // 0x58
	private bool exitedCollision; // 0x60

	// Methods

	// RVA: 0x20DFF70 Offset: 0x20E0071 VA: 0x20DFF70 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20DFF90 Offset: 0x20E0091 VA: 0x20DFF90 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20DFFA0 Offset: 0x20E00A1 VA: 0x20DFFA0 Slot: 23
	public override void OnCollisionExit2D(Collision2D collision) { }

	// RVA: 0x20E0090 Offset: 0x20E0191 VA: 0x20E0090 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E0190 Offset: 0x20E0291 VA: 0x20E0190
	public void .ctor() { }
}

