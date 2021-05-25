[TaskCategoryAttribute] // RVA: 0x1502E0 Offset: 0x1503E1 VA: 0x1502E0
[TaskDescriptionAttribute] // RVA: 0x1502E0 Offset: 0x1503E1 VA: 0x1502E0
public class IsKinematic : Conditional // TypeDefIndex: 11138
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A600 Offset: 0x18A701 VA: 0x18A600
	public SharedGameObject targetGameObject; // 0x50
	private Rigidbody rigidbody; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x2883C90 Offset: 0x2883D91 VA: 0x2883C90 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2883D90 Offset: 0x2883E91 VA: 0x2883D90 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2883E70 Offset: 0x2883F71 VA: 0x2883E70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2883E80 Offset: 0x2883F81 VA: 0x2883E80
	public void .ctor() { }
}

