[TaskCategoryAttribute] // RVA: 0x153280 Offset: 0x153381 VA: 0x153280
[TaskDescriptionAttribute] // RVA: 0x153280 Offset: 0x153381 VA: 0x153280
public class SetRange : Action // TypeDefIndex: 11270
{
	// Fields
	[TooltipAttribute] // RVA: 0x18F230 Offset: 0x18F331 VA: 0x18F230
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18F270 Offset: 0x18F371 VA: 0x18F270
	public SharedFloat range; // 0x58
	private Light light; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A48E0 Offset: 0x27A49E1 VA: 0x27A48E0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A49E0 Offset: 0x27A4AE1 VA: 0x27A49E0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A4AD0 Offset: 0x27A4BD1 VA: 0x27A4AD0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A4B20 Offset: 0x27A4C21 VA: 0x27A4B20
	public void .ctor() { }
}

