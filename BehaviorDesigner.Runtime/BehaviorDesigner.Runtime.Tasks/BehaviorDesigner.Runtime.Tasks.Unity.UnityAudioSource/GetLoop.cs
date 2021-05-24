[TaskCategoryAttribute] // RVA: 0x155080 Offset: 0x155181 VA: 0x155080
[TaskDescriptionAttribute] // RVA: 0x155080 Offset: 0x155181 VA: 0x155080
public class GetLoop : Action // TypeDefIndex: 11350
{
	// Fields
	[TooltipAttribute] // RVA: 0x191BC0 Offset: 0x191CC1 VA: 0x191BC0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191C00 Offset: 0x191D01 VA: 0x191C00
	[RequiredFieldAttribute] // RVA: 0x191C00 Offset: 0x191D01 VA: 0x191C00
	public SharedBool storeValue; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2796090 Offset: 0x2796191 VA: 0x2796090 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2796190 Offset: 0x2796291 VA: 0x2796190 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2796290 Offset: 0x2796391 VA: 0x2796290 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27962E0 Offset: 0x27963E1 VA: 0x27962E0
	public void .ctor() { }
}

