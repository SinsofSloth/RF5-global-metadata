[TaskCategoryAttribute] // RVA: 0x14DE30 Offset: 0x14DF31 VA: 0x14DE30
[TaskDescriptionAttribute] // RVA: 0x14DE30 Offset: 0x14DF31 VA: 0x14DE30
public class Stop : Action // TypeDefIndex: 11041
{
	// Fields
	[TooltipAttribute] // RVA: 0x1870A0 Offset: 0x1871A1 VA: 0x1870A0
	public SharedGameObject targetGameObject; // 0x50
	private PlayableDirector playableDirector; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x278E280 Offset: 0x278E381 VA: 0x278E280 Slot: 5
	public override void OnStart() { }

	// RVA: 0x278E380 Offset: 0x278E481 VA: 0x278E380 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278E460 Offset: 0x278E561 VA: 0x278E460 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278E470 Offset: 0x278E571 VA: 0x278E470
	public void .ctor() { }
}

