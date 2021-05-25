[TaskCategoryAttribute] // RVA: 0x1553E0 Offset: 0x1554E1 VA: 0x1553E0
[TaskDescriptionAttribute] // RVA: 0x1553E0 Offset: 0x1554E1 VA: 0x1553E0
public class GetVolume : Action // TypeDefIndex: 11359
{
	// Fields
	[TooltipAttribute] // RVA: 0x1920D0 Offset: 0x1921D1 VA: 0x1920D0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192110 Offset: 0x192211 VA: 0x192110
	[RequiredFieldAttribute] // RVA: 0x192110 Offset: 0x192211 VA: 0x192110
	public SharedFloat storeValue; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27975A0 Offset: 0x27976A1 VA: 0x27975A0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27976A0 Offset: 0x27977A1 VA: 0x27976A0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2797790 Offset: 0x2797891 VA: 0x2797790 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27977E0 Offset: 0x27978E1 VA: 0x27977E0
	public void .ctor() { }
}

