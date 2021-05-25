[TaskCategoryAttribute] // RVA: 0x150820 Offset: 0x150921 VA: 0x150820
[TaskDescriptionAttribute] // RVA: 0x150820 Offset: 0x150921 VA: 0x150820
public class SetUseGravity : Action // TypeDefIndex: 11152
{
	// Fields
	[TooltipAttribute] // RVA: 0x18AC80 Offset: 0x18AD81 VA: 0x18AC80
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18ACC0 Offset: 0x18ADC1 VA: 0x18ACC0
	public SharedBool useGravity; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2885DC0 Offset: 0x2885EC1 VA: 0x2885DC0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2885EC0 Offset: 0x2885FC1 VA: 0x2885EC0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2885FC0 Offset: 0x28860C1 VA: 0x2885FC0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2886010 Offset: 0x2886111 VA: 0x2886010
	public void .ctor() { }
}

