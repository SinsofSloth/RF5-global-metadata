[TaskDescriptionAttribute] // RVA: 0x14BCB0 Offset: 0x14BDB1 VA: 0x14BCB0
[TaskCategoryAttribute] // RVA: 0x14BCB0 Offset: 0x14BDB1 VA: 0x14BCB0
public class HasEnteredTrigger2D : Conditional // TypeDefIndex: 10950
{
	// Fields
	[TooltipAttribute] // RVA: 0x183A50 Offset: 0x183B51 VA: 0x183A50
	public SharedString tag; // 0x50
	[TooltipAttribute] // RVA: 0x183A90 Offset: 0x183B91 VA: 0x183A90
	public SharedGameObject otherGameObject; // 0x58
	private bool enteredTrigger; // 0x60

	// Methods

	// RVA: 0x20DFA20 Offset: 0x20DFB21 VA: 0x20DFA20 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20DFA40 Offset: 0x20DFB41 VA: 0x20DFA40 Slot: 9
	public override void OnEnd() { }

	// RVA: 0x20DFA50 Offset: 0x20DFB51 VA: 0x20DFA50 Slot: 24
	public override void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x20DFB40 Offset: 0x20DFC41 VA: 0x20DFB40 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20DFC40 Offset: 0x20DFD41 VA: 0x20DFC40
	public void .ctor() { }
}

