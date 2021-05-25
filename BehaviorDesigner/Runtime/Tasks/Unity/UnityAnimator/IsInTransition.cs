[TaskCategoryAttribute] // RVA: 0x156160 Offset: 0x156261 VA: 0x156160
[TaskDescriptionAttribute] // RVA: 0x156160 Offset: 0x156261 VA: 0x156160
public class IsInTransition : Conditional // TypeDefIndex: 11395
{
	// Fields
	[TooltipAttribute] // RVA: 0x193480 Offset: 0x193581 VA: 0x193480
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1934C0 Offset: 0x1935C1 VA: 0x1934C0
	public SharedInt index; // 0x58
	private Animator animator; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27921C0 Offset: 0x27922C1 VA: 0x27921C0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27922C0 Offset: 0x27923C1 VA: 0x27922C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27923C0 Offset: 0x27924C1 VA: 0x27923C0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2792410 Offset: 0x2792511 VA: 0x2792410
	public void .ctor() { }
}

