[TaskCategoryAttribute] // RVA: 0x150100 Offset: 0x150201 VA: 0x150100
[TaskDescriptionAttribute] // RVA: 0x150100 Offset: 0x150201 VA: 0x150100
public class GetMass : Action // TypeDefIndex: 11133
{
	// Fields
	[TooltipAttribute] // RVA: 0x18A330 Offset: 0x18A431 VA: 0x18A330
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18A370 Offset: 0x18A471 VA: 0x18A370
	[RequiredFieldAttribute] // RVA: 0x18A370 Offset: 0x18A471 VA: 0x18A370
	public SharedFloat storeValue; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2883030 Offset: 0x2883131 VA: 0x2883030 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2883130 Offset: 0x2883231 VA: 0x2883130 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2883220 Offset: 0x2883321 VA: 0x2883220 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2883270 Offset: 0x2883371 VA: 0x2883270
	public void .ctor() { }
}

