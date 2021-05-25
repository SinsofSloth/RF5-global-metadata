[TaskCategoryAttribute] // RVA: 0x154FC0 Offset: 0x1550C1 VA: 0x154FC0
[TaskDescriptionAttribute] // RVA: 0x154FC0 Offset: 0x1550C1 VA: 0x154FC0
public class GetIgnoreListenerPause : Action // TypeDefIndex: 11348
{
	// Fields
	[TooltipAttribute] // RVA: 0x191AA0 Offset: 0x191BA1 VA: 0x191AA0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191AE0 Offset: 0x191BE1 VA: 0x191AE0
	[RequiredFieldAttribute] // RVA: 0x191AE0 Offset: 0x191BE1 VA: 0x191AE0
	public SharedBool storeValue; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2795BD0 Offset: 0x2795CD1 VA: 0x2795BD0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2795CD0 Offset: 0x2795DD1 VA: 0x2795CD0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2795DD0 Offset: 0x2795ED1 VA: 0x2795DD0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2795E20 Offset: 0x2795F21 VA: 0x2795E20
	public void .ctor() { }
}

