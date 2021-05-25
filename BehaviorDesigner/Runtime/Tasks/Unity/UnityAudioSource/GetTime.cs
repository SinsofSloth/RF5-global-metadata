[TaskCategoryAttribute] // RVA: 0x155320 Offset: 0x155421 VA: 0x155320
[TaskDescriptionAttribute] // RVA: 0x155320 Offset: 0x155421 VA: 0x155320
public class GetTime : Action // TypeDefIndex: 11357
{
	// Fields
	[TooltipAttribute] // RVA: 0x191FB0 Offset: 0x1920B1 VA: 0x191FB0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191FF0 Offset: 0x1920F1 VA: 0x191FF0
	[RequiredFieldAttribute] // RVA: 0x191FF0 Offset: 0x1920F1 VA: 0x191FF0
	public SharedFloat storeValue; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27970F0 Offset: 0x27971F1 VA: 0x27970F0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27971F0 Offset: 0x27972F1 VA: 0x27971F0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27972E0 Offset: 0x27973E1 VA: 0x27972E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2797330 Offset: 0x2797431 VA: 0x2797330
	public void .ctor() { }
}

