[TaskCategoryAttribute] // RVA: 0x150580 Offset: 0x150681 VA: 0x150580
[TaskDescriptionAttribute] // RVA: 0x150580 Offset: 0x150681 VA: 0x150580
public class SetConstraints : Action // TypeDefIndex: 11145
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A900 Offset: 0x18AA01 VA: 0x18A900
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A940 Offset: 0x18AA41 VA: 0x18A940
	public RigidbodyConstraints constraints; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2884D20 Offset: 0x2884E21 VA: 0x2884D20 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2884E20 Offset: 0x2884F21 VA: 0x2884E20 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2884F00 Offset: 0x2885001 VA: 0x2884F00 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2884F30 Offset: 0x2885031 VA: 0x2884F30
	public void .ctor() { }
}

