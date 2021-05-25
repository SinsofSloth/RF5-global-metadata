[TaskCategoryAttribute] // RVA: 0x156FA0 Offset: 0x1570A1 VA: 0x156FA0
[TaskDescriptionAttribute] // RVA: 0x156FA0 Offset: 0x1570A1 VA: 0x156FA0
public class CompareSharedMonsterBehaviorState : Conditional // TypeDefIndex: 11436
{
	// Fields
	[TooltipAttribute] // RVA: 0x194CE0 Offset: 0x194DE1 VA: 0x194CE0
	public SharedMonsterBehaviorState variable; // 0x50
	[TooltipAttribute] // RVA: 0x194D20 Offset: 0x194E21 VA: 0x194D20
	public SharedMonsterBehaviorState compareTo; // 0x58

	// Methods

	// RVA: 0x20DC120 Offset: 0x20DC221 VA: 0x20DC120 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20DC1B0 Offset: 0x20DC2B1 VA: 0x20DC1B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20DC1F0 Offset: 0x20DC2F1 VA: 0x20DC1F0
	public void .ctor() { }
}

