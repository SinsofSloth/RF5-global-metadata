[TaskCategoryAttribute] // RVA: 0x157060 Offset: 0x157161 VA: 0x157060
[TaskDescriptionAttribute] // RVA: 0x157060 Offset: 0x157161 VA: 0x157060
public class CompareSharedMonsterReadyToAttackBehaviorType : Conditional // TypeDefIndex: 11438
{
	// Fields
	[TooltipAttribute] // RVA: 0x194DF0 Offset: 0x194EF1 VA: 0x194DF0
	public SharedMovementBehaviorType variable; // 0x50
	[TooltipAttribute] // RVA: 0x194E30 Offset: 0x194F31 VA: 0x194E30
	public SharedMovementBehaviorType compareTo; // 0x58

	// Methods

	// RVA: 0x20DC200 Offset: 0x20DC301 VA: 0x20DC200 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20DC290 Offset: 0x20DC391 VA: 0x20DC290 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20DC2D0 Offset: 0x20DC3D1 VA: 0x20DC2D0
	public void .ctor() { }
}

