[TaskCategoryAttribute] // RVA: 0x1557A0 Offset: 0x1558A1 VA: 0x1557A0
[TaskDescriptionAttribute] // RVA: 0x1557A0 Offset: 0x1558A1 VA: 0x1557A0
public class SetLoop : Action // TypeDefIndex: 11369
{
	// Fields
	[TooltipAttribute] // RVA: 0x192560 Offset: 0x192661 VA: 0x192560
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1925A0 Offset: 0x1926A1 VA: 0x1925A0
	public SharedBool loop; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2798CC0 Offset: 0x2798DC1 VA: 0x2798CC0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2798DC0 Offset: 0x2798EC1 VA: 0x2798DC0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2798EC0 Offset: 0x2798FC1 VA: 0x2798EC0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2798F10 Offset: 0x2799011 VA: 0x2798F10
	public void .ctor() { }
}

