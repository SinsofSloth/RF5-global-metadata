[TaskCategoryAttribute] // RVA: 0x14FF20 Offset: 0x150021 VA: 0x14FF20
[TaskDescriptionAttribute] // RVA: 0x14FF20 Offset: 0x150021 VA: 0x14FF20
public class GetAngularVelocity : Action // TypeDefIndex: 11128
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A060 Offset: 0x18A161 VA: 0x18A060
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A0A0 Offset: 0x18A1A1 VA: 0x18A0A0
	[RequiredFieldAttribute] // RVA: 0x18A0A0 Offset: 0x18A1A1 VA: 0x18A0A0
	public SharedVector3 storeValue; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2882400 Offset: 0x2882501 VA: 0x2882400 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2882500 Offset: 0x2882601 VA: 0x2882500 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28825F0 Offset: 0x28826F1 VA: 0x28825F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2882680 Offset: 0x2882781 VA: 0x2882680
	public void .ctor() { }
}

