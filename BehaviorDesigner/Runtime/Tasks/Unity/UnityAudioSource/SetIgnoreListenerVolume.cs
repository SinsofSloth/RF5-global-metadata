[TaskCategoryAttribute] // RVA: 0x1556E0 Offset: 0x1557E1 VA: 0x1556E0
[TaskDescriptionAttribute] // RVA: 0x1556E0 Offset: 0x1557E1 VA: 0x1556E0
public class SetIgnoreListenerVolume : Action // TypeDefIndex: 11367
{
	// Fields
	[TooltipAttribute] // RVA: 0x192460 Offset: 0x192561 VA: 0x192460
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1924A0 Offset: 0x1925A1 VA: 0x1924A0
	public SharedBool ignoreListenerVolume; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2798A60 Offset: 0x2798B61 VA: 0x2798A60 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2798B60 Offset: 0x2798C61 VA: 0x2798B60 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2798C60 Offset: 0x2798D61 VA: 0x2798C60 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2798CB0 Offset: 0x2798DB1 VA: 0x2798CB0
	public void .ctor() { }
}

