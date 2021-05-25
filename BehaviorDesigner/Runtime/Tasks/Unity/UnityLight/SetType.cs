[TaskCategoryAttribute] // RVA: 0x153460 Offset: 0x153561 VA: 0x153460
[TaskDescriptionAttribute] // RVA: 0x153460 Offset: 0x153561 VA: 0x153460
public class SetType : Action // TypeDefIndex: 11275
{
	// Fields
	[TooltipAttribute] // RVA: 0x18F4B0 Offset: 0x18F5B1 VA: 0x18F4B0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18F4F0 Offset: 0x18F5F1 VA: 0x18F4F0
	public LightType type; // 0x58
	private Light light; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A5420 Offset: 0x27A5521 VA: 0x27A5420 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A5520 Offset: 0x27A5621 VA: 0x27A5520 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A5600 Offset: 0x27A5701 VA: 0x27A5600 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A5610 Offset: 0x27A5711 VA: 0x27A5610
	public void .ctor() { }
}

