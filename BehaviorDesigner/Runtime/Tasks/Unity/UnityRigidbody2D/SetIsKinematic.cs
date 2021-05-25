[TaskCategoryAttribute] // RVA: 0x14FA50 Offset: 0x14FB51 VA: 0x14FA50
[TaskDescriptionAttribute] // RVA: 0x14FA50 Offset: 0x14FB51 VA: 0x14FA50
public class SetIsKinematic : Action // TypeDefIndex: 11116
{
	// Fields
	[TooltipAttribute] // RVA: 0x189850 Offset: 0x189951 VA: 0x189850
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189890 Offset: 0x189991 VA: 0x189890
	public SharedBool isKinematic; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x28897F0 Offset: 0x28898F1 VA: 0x28897F0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28898F0 Offset: 0x28899F1 VA: 0x28898F0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28899F0 Offset: 0x2889AF1 VA: 0x28899F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2889A40 Offset: 0x2889B41 VA: 0x2889A40
	public void .ctor() { }
}

