[TaskCategoryAttribute] // RVA: 0x155020 Offset: 0x155121 VA: 0x155020
[TaskDescriptionAttribute] // RVA: 0x155020 Offset: 0x155121 VA: 0x155020
public class GetIgnoreListenerVolume : Action // TypeDefIndex: 11349
{
	// Fields
	[TooltipAttribute] // RVA: 0x191B30 Offset: 0x191C31 VA: 0x191B30
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191B70 Offset: 0x191C71 VA: 0x191B70
	[RequiredFieldAttribute] // RVA: 0x191B70 Offset: 0x191C71 VA: 0x191B70
	public SharedBool storeValue; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2795E30 Offset: 0x2795F31 VA: 0x2795E30 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2795F30 Offset: 0x2796031 VA: 0x2795F30 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2796030 Offset: 0x2796131 VA: 0x2796030 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2796080 Offset: 0x2796181 VA: 0x2796080
	public void .ctor() { }
}

