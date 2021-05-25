[TaskCategoryAttribute] // RVA: 0x14DD70 Offset: 0x14DE71 VA: 0x14DD70
[TaskDescriptionAttribute] // RVA: 0x14DD70 Offset: 0x14DE71 VA: 0x14DD70
public class Play : Action // TypeDefIndex: 11039
{
	// Fields
	[TooltipAttribute] // RVA: 0x186F60 Offset: 0x187061 VA: 0x186F60
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186FA0 Offset: 0x1870A1 VA: 0x186FA0
	public PlayableAsset playableAsset; // 0x58
	[TooltipAttribute] // RVA: 0x186FE0 Offset: 0x1870E1 VA: 0x186FE0
	public SharedBool stopWhenComplete; // 0x60
	private PlayableDirector playableDirector; // 0x68
	private GameObject prevGameObject; // 0x70
	private bool playbackStarted; // 0x78

	// Methods

	// RVA: 0x278DC90 Offset: 0x278DD91 VA: 0x278DC90 Slot: 5
	public override void OnStart() { }

	// RVA: 0x278DD90 Offset: 0x278DE91 VA: 0x278DD90 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278DF60 Offset: 0x278E061 VA: 0x278DF60 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278DFB0 Offset: 0x278E0B1 VA: 0x278DFB0
	public void .ctor() { }
}

