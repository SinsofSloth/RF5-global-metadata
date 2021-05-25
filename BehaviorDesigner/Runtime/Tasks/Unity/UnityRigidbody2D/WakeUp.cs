[TaskCategoryAttribute] // RVA: 0x14FBD0 Offset: 0x14FCD1 VA: 0x14FBD0
[TaskDescriptionAttribute] // RVA: 0x14FBD0 Offset: 0x14FCD1 VA: 0x14FBD0
public class WakeUp : Conditional // TypeDefIndex: 11120
{
	// Fields
	[TooltipAttribute] // RVA: 0x189A10 Offset: 0x189B11 VA: 0x189A10
	public SharedGameObject targetGameObject; // 0x50
	private Rigidbody2D rigidbody2D; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x288A130 Offset: 0x288A231 VA: 0x288A130 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288A230 Offset: 0x288A331 VA: 0x288A230 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288A310 Offset: 0x288A411 VA: 0x288A310 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288A320 Offset: 0x288A421 VA: 0x288A320
	public void .ctor() { }
}

