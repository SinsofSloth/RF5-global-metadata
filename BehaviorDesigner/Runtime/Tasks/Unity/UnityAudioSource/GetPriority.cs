[TaskCategoryAttribute] // RVA: 0x155260 Offset: 0x155361 VA: 0x155260
[TaskDescriptionAttribute] // RVA: 0x155260 Offset: 0x155361 VA: 0x155260
public class GetPriority : Action // TypeDefIndex: 11355
{
	// Fields
	[TooltipAttribute] // RVA: 0x191E90 Offset: 0x191F91 VA: 0x191E90
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191ED0 Offset: 0x191FD1 VA: 0x191ED0
	[RequiredFieldAttribute] // RVA: 0x191ED0 Offset: 0x191FD1 VA: 0x191ED0
	public SharedInt storeValue; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2796C40 Offset: 0x2796D41 VA: 0x2796C40 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2796D40 Offset: 0x2796E41 VA: 0x2796D40 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2796E40 Offset: 0x2796F41 VA: 0x2796E40 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2796E90 Offset: 0x2796F91 VA: 0x2796E90
	public void .ctor() { }
}

