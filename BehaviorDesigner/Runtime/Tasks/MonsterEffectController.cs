[TaskDescriptionAttribute] // RVA: 0x14AB80 Offset: 0x14AC81 VA: 0x14AB80
[TaskCategoryAttribute] // RVA: 0x14AB80 Offset: 0x14AC81 VA: 0x14AB80
[TaskIconAttribute] // RVA: 0x14AB80 Offset: 0x14AC81 VA: 0x14AB80
public class MonsterEffectController : Action // TypeDefIndex: 10908
{
	// Fields
	[TooltipAttribute] // RVA: 0x182290 Offset: 0x182391 VA: 0x182290
	public SharedEnemyBehaviorController SharedEnemyBehaviorController; // 0x50
	public SharedString EffectName; // 0x58
	public SharedBool IsLoop; // 0x60
	public SharedBool IsCreate; // 0x68

	// Methods

	// RVA: 0x20E1EE0 Offset: 0x20E1FE1 VA: 0x20E1EE0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E1F50 Offset: 0x20E2051 VA: 0x20E1F50 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E1F60 Offset: 0x20E2061 VA: 0x20E1F60
	public void .ctor() { }
}

