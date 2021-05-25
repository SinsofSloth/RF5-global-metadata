[TaskCategoryAttribute] // RVA: 0x153220 Offset: 0x153321 VA: 0x153220
[TaskDescriptionAttribute] // RVA: 0x153220 Offset: 0x153321 VA: 0x153220
public class SetIntensity : Action // TypeDefIndex: 11269
{
	// Fields
	[TooltipAttribute] // RVA: 0x18F1B0 Offset: 0x18F2B1 VA: 0x18F1B0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18F1F0 Offset: 0x18F2F1 VA: 0x18F1F0
	public SharedFloat intensity; // 0x58
	private Light light; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A4690 Offset: 0x27A4791 VA: 0x27A4690 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A4790 Offset: 0x27A4891 VA: 0x27A4790 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A4880 Offset: 0x27A4981 VA: 0x27A4880 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A48D0 Offset: 0x27A49D1 VA: 0x27A48D0
	public void .ctor() { }
}

