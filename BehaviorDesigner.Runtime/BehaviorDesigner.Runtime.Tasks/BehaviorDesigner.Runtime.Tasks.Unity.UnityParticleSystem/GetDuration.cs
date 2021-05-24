[TaskCategoryAttribute] // RVA: 0x151540 Offset: 0x151641 VA: 0x151540
[TaskDescriptionAttribute] // RVA: 0x151540 Offset: 0x151641 VA: 0x151540
public class GetDuration : Action // TypeDefIndex: 11187
{
	// Fields
	[TooltipAttribute] // RVA: 0x18C960 Offset: 0x18CA61 VA: 0x18C960
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18C9A0 Offset: 0x18CAA1 VA: 0x18C9A0
	[RequiredFieldAttribute] // RVA: 0x18C9A0 Offset: 0x18CAA1 VA: 0x18C9A0
	public SharedFloat storeResult; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2879710 Offset: 0x2879811 VA: 0x2879710 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2879810 Offset: 0x2879911 VA: 0x2879810 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2879920 Offset: 0x2879A21 VA: 0x2879920 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2879970 Offset: 0x2879A71 VA: 0x2879970
	public void .ctor() { }
}

