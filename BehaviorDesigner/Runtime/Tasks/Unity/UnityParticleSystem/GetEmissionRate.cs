[TaskCategoryAttribute] // RVA: 0x1515A0 Offset: 0x1516A1 VA: 0x1515A0
[TaskDescriptionAttribute] // RVA: 0x1515A0 Offset: 0x1516A1 VA: 0x1515A0
public class GetEmissionRate : Action // TypeDefIndex: 11188
{
	// Fields
	[TooltipAttribute] // RVA: 0x18C9F0 Offset: 0x18CAF1 VA: 0x18C9F0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18CA30 Offset: 0x18CB31 VA: 0x18CA30
	[RequiredFieldAttribute] // RVA: 0x18CA30 Offset: 0x18CB31 VA: 0x18CA30
	public SharedFloat storeResult; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2879980 Offset: 0x2879A81 VA: 0x2879980 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2879A80 Offset: 0x2879B81 VA: 0x2879A80 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2879B70 Offset: 0x2879C71 VA: 0x2879B70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2879BC0 Offset: 0x2879CC1 VA: 0x2879BC0
	public void .ctor() { }
}

