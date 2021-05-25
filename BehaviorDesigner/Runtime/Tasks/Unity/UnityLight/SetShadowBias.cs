[TaskCategoryAttribute] // RVA: 0x1532E0 Offset: 0x1533E1 VA: 0x1532E0
[TaskDescriptionAttribute] // RVA: 0x1532E0 Offset: 0x1533E1 VA: 0x1532E0
public class SetShadowBias : Action // TypeDefIndex: 11271
{
	// Fields
	[TooltipAttribute] // RVA: 0x18F2B0 Offset: 0x18F3B1 VA: 0x18F2B0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18F2F0 Offset: 0x18F3F1 VA: 0x18F2F0
	public SharedFloat shadowBias; // 0x58
	private Light light; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A4B30 Offset: 0x27A4C31 VA: 0x27A4B30 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A4C30 Offset: 0x27A4D31 VA: 0x27A4C30 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A4D20 Offset: 0x27A4E21 VA: 0x27A4D20 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A4D70 Offset: 0x27A4E71 VA: 0x27A4D70
	public void .ctor() { }
}

