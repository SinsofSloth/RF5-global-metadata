[TaskDescriptionAttribute] // RVA: 0x14BD10 Offset: 0x14BE11 VA: 0x14BD10
[TaskCategoryAttribute] // RVA: 0x14BD10 Offset: 0x14BE11 VA: 0x14BD10
public class HasExitedCollision : Conditional // TypeDefIndex: 10951
{
	// Fields
	[TooltipAttribute] // RVA: 0x183AD0 Offset: 0x183BD1 VA: 0x183AD0
	public SharedString tag; // 0x50
	[TooltipAttribute] // RVA: 0x183B10 Offset: 0x183C11 VA: 0x183B10
	public SharedGameObject collidedGameObject; // 0x58
	private bool exitedCollision; // 0x60

	// Methods

	// RVA: 0x20DFD40 Offset: 0x20DFE41 VA: 0x20DFD40 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20DFD60 Offset: 0x20DFE61 VA: 0x20DFD60 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20DFD70 Offset: 0x20DFE71 VA: 0x20DFD70 Slot: 19
	public override void OnCollisionExit(Collision collision) { }

	// RVA: 0x20DFE60 Offset: 0x20DFF61 VA: 0x20DFE60 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20DFE70 Offset: 0x20DFF71 VA: 0x20DFE70
	public void .ctor() { }
}

