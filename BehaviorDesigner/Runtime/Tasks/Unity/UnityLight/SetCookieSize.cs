[TaskCategoryAttribute] // RVA: 0x153160 Offset: 0x153261 VA: 0x153160
[TaskDescriptionAttribute] // RVA: 0x153160 Offset: 0x153261 VA: 0x153160
public class SetCookieSize : Action // TypeDefIndex: 11267
{
	// Fields
	[TooltipAttribute] // RVA: 0x18F0B0 Offset: 0x18F1B1 VA: 0x18F0B0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18F0F0 Offset: 0x18F1F1 VA: 0x18F0F0
	public SharedFloat cookieSize; // 0x58
	private Light light; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A4200 Offset: 0x27A4301 VA: 0x27A4200 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A4300 Offset: 0x27A4401 VA: 0x27A4300 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A43F0 Offset: 0x27A44F1 VA: 0x27A43F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A4440 Offset: 0x27A4541 VA: 0x27A4440
	public void .ctor() { }
}

