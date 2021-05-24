[TaskCategoryAttribute] // RVA: 0x14FEC0 Offset: 0x14FFC1 VA: 0x14FEC0
[TaskDescriptionAttribute] // RVA: 0x14FEC0 Offset: 0x14FFC1 VA: 0x14FEC0
public class GetAngularDrag : Action // TypeDefIndex: 11127
{
	// Fields
	[TooltipAttribute] // RVA: 0x189FD0 Offset: 0x18A0D1 VA: 0x189FD0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A010 Offset: 0x18A111 VA: 0x18A010
	[RequiredFieldAttribute] // RVA: 0x18A010 Offset: 0x18A111 VA: 0x18A010
	public SharedFloat storeValue; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x28821B0 Offset: 0x28822B1 VA: 0x28821B0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28822B0 Offset: 0x28823B1 VA: 0x28822B0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28823A0 Offset: 0x28824A1 VA: 0x28823A0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28823F0 Offset: 0x28824F1 VA: 0x28823F0
	public void .ctor() { }
}

