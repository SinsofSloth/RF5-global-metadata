[TaskCategoryAttribute] // RVA: 0x14FB70 Offset: 0x14FC71 VA: 0x14FB70
[TaskDescriptionAttribute] // RVA: 0x14FB70 Offset: 0x14FC71 VA: 0x14FB70
public class Sleep : Conditional // TypeDefIndex: 11119
{
	// Fields
	[TooltipAttribute] // RVA: 0x1899D0 Offset: 0x189AD1 VA: 0x1899D0
	public SharedGameObject targetGameObject; // 0x50
	private Rigidbody2D rigidbody2D; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x2889F30 Offset: 0x288A031 VA: 0x2889F30 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288A030 Offset: 0x288A131 VA: 0x288A030 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288A110 Offset: 0x288A211 VA: 0x288A110 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288A120 Offset: 0x288A221 VA: 0x288A120
	public void .ctor() { }
}

