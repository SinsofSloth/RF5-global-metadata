[TaskCategoryAttribute] // RVA: 0x14DDD0 Offset: 0x14DED1 VA: 0x14DDD0
[TaskDescriptionAttribute] // RVA: 0x14DDD0 Offset: 0x14DED1 VA: 0x14DDD0
public class Resume : Action // TypeDefIndex: 11040
{
	// Fields
	[TooltipAttribute] // RVA: 0x187020 Offset: 0x187121 VA: 0x187020
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x187060 Offset: 0x187161 VA: 0x187060
	public SharedBool stopWhenComplete; // 0x58
	private PlayableDirector playableDirector; // 0x60
	private GameObject prevGameObject; // 0x68
	private bool playbackStarted; // 0x70

	// Methods

	// RVA: 0x278DFC0 Offset: 0x278E0C1 VA: 0x278DFC0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x278E0C0 Offset: 0x278E1C1 VA: 0x278E0C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278E220 Offset: 0x278E321 VA: 0x278E220 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278E270 Offset: 0x278E371 VA: 0x278E270
	public void .ctor() { }
}

