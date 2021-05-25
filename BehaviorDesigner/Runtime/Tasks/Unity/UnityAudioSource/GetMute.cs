[TaskCategoryAttribute] // RVA: 0x1551A0 Offset: 0x1552A1 VA: 0x1551A0
[TaskDescriptionAttribute] // RVA: 0x1551A0 Offset: 0x1552A1 VA: 0x1551A0
public class GetMute : Action // TypeDefIndex: 11353
{
	// Fields
	[TooltipAttribute] // RVA: 0x191D70 Offset: 0x191E71 VA: 0x191D70
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191DB0 Offset: 0x191EB1 VA: 0x191DB0
	[RequiredFieldAttribute] // RVA: 0x191DB0 Offset: 0x191EB1 VA: 0x191DB0
	public SharedBool storeValue; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2796790 Offset: 0x2796891 VA: 0x2796790 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2796890 Offset: 0x2796991 VA: 0x2796890 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2796990 Offset: 0x2796A91 VA: 0x2796990 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27969E0 Offset: 0x2796AE1 VA: 0x27969E0
	public void .ctor() { }
}

