[TaskCategoryAttribute] // RVA: 0x14F990 Offset: 0x14FA91 VA: 0x14F990
[TaskDescriptionAttribute] // RVA: 0x14F990 Offset: 0x14FA91 VA: 0x14F990
public class SetDrag : Action // TypeDefIndex: 11114
{
	// Fields
	[TooltipAttribute] // RVA: 0x189750 Offset: 0x189851 VA: 0x189750
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189790 Offset: 0x189891 VA: 0x189790
	public SharedFloat drag; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2889350 Offset: 0x2889451 VA: 0x2889350 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2889450 Offset: 0x2889551 VA: 0x2889450 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2889540 Offset: 0x2889641 VA: 0x2889540 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2889590 Offset: 0x2889691 VA: 0x2889590
	public void .ctor() { }
}

