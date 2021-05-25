[TaskCategoryAttribute] // RVA: 0x14DD10 Offset: 0x14DE11 VA: 0x14DD10
[TaskDescriptionAttribute] // RVA: 0x14DD10 Offset: 0x14DE11 VA: 0x14DD10
public class Pause : Action // TypeDefIndex: 11038
{
	// Fields
	[TooltipAttribute] // RVA: 0x186F20 Offset: 0x187021 VA: 0x186F20
	public SharedGameObject targetGameObject; // 0x50
	private PlayableDirector playableDirector; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x278DA90 Offset: 0x278DB91 VA: 0x278DA90 Slot: 5
	public override void OnStart() { }

	// RVA: 0x278DB90 Offset: 0x278DC91 VA: 0x278DB90 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278DC70 Offset: 0x278DD71 VA: 0x278DC70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278DC80 Offset: 0x278DD81 VA: 0x278DC80
	public void .ctor() { }
}

