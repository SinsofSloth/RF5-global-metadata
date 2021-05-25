[TaskCategoryAttribute] // RVA: 0x14DC50 Offset: 0x14DD51 VA: 0x14DC50
[TaskDescriptionAttribute] // RVA: 0x14DC50 Offset: 0x14DD51 VA: 0x14DC50
public class IsPaused : Conditional // TypeDefIndex: 11036
{
	// Fields
	[TooltipAttribute] // RVA: 0x186EA0 Offset: 0x186FA1 VA: 0x186EA0
	public SharedGameObject targetGameObject; // 0x50
	private PlayableDirector playableDirector; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x278D690 Offset: 0x278D791 VA: 0x278D690 Slot: 5
	public override void OnStart() { }

	// RVA: 0x278D790 Offset: 0x278D891 VA: 0x278D790 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278D870 Offset: 0x278D971 VA: 0x278D870 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278D880 Offset: 0x278D981 VA: 0x278D880
	public void .ctor() { }
}

