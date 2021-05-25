[TaskCategoryAttribute] // RVA: 0x1518A0 Offset: 0x1519A1 VA: 0x1518A0
[TaskDescriptionAttribute] // RVA: 0x1518A0 Offset: 0x1519A1 VA: 0x1518A0
public class IsPaused : Conditional // TypeDefIndex: 11196
{
	// Fields
	[TooltipAttribute] // RVA: 0x18CE20 Offset: 0x18CF21 VA: 0x18CE20
	public SharedGameObject targetGameObject; // 0x50
	private ParticleSystem particleSystem; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x287AC70 Offset: 0x287AD71 VA: 0x287AC70 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287AD70 Offset: 0x287AE71 VA: 0x287AD70 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287AE50 Offset: 0x287AF51 VA: 0x287AE50 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287AE60 Offset: 0x287AF61 VA: 0x287AE60
	public void .ctor() { }
}

