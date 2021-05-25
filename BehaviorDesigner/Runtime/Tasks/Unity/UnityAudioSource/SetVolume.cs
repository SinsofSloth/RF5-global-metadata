[TaskCategoryAttribute] // RVA: 0x155C20 Offset: 0x155D21 VA: 0x155C20
[TaskDescriptionAttribute] // RVA: 0x155C20 Offset: 0x155D21 VA: 0x155C20
public class SetVolume : Action // TypeDefIndex: 11381
{
	// Fields
	[TooltipAttribute] // RVA: 0x192B60 Offset: 0x192C61 VA: 0x192B60
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192BA0 Offset: 0x192CA1 VA: 0x192BA0
	public SharedFloat volume; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279A8D0 Offset: 0x279A9D1 VA: 0x279A8D0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279A9D0 Offset: 0x279AAD1 VA: 0x279A9D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279AAC0 Offset: 0x279ABC1 VA: 0x279AAC0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279AB10 Offset: 0x279AC11 VA: 0x279AB10
	public void .ctor() { }
}

