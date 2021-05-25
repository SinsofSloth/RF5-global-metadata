[TaskCategoryAttribute] // RVA: 0x14F450 Offset: 0x14F551 VA: 0x14F450
[TaskDescriptionAttribute] // RVA: 0x14F450 Offset: 0x14F551 VA: 0x14F450
public class GetAngularVelocity : Action // TypeDefIndex: 11100
{
	// Fields
	[TooltipAttribute] // RVA: 0x189050 Offset: 0x189151 VA: 0x189050
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189090 Offset: 0x189191 VA: 0x189090
	[RequiredFieldAttribute] // RVA: 0x189090 Offset: 0x189191 VA: 0x189090
	public SharedFloat storeValue; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x28872C0 Offset: 0x28873C1 VA: 0x28872C0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28873C0 Offset: 0x28874C1 VA: 0x28873C0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28874B0 Offset: 0x28875B1 VA: 0x28874B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2887500 Offset: 0x2887601 VA: 0x2887500
	public void .ctor() { }
}

