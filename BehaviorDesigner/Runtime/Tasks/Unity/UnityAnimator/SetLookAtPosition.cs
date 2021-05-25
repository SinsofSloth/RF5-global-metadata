[TaskCategoryAttribute] // RVA: 0x156520 Offset: 0x156621 VA: 0x156520
[TaskDescriptionAttribute] // RVA: 0x156520 Offset: 0x156621 VA: 0x156520
public class SetLookAtPosition : Action // TypeDefIndex: 11408
{
	// Fields
	[TooltipAttribute] // RVA: 0x193D80 Offset: 0x193E81 VA: 0x193D80
	public SharedVector3 position; // 0x50
	private Animator animator; // 0x58
	private bool positionSet; // 0x60

	// Methods

	// RVA: 0x2794480 Offset: 0x2794581 VA: 0x2794480 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27944F0 Offset: 0x27945F1 VA: 0x27944F0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27945C0 Offset: 0x27946C1 VA: 0x27945C0 Slot: 27
	public override void OnAnimatorIK() { }

	// RVA: 0x2794670 Offset: 0x2794771 VA: 0x2794670 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27946F0 Offset: 0x27947F1 VA: 0x27946F0
	public void .ctor() { }
}

