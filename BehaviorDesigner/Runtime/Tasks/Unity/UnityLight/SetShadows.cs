[TaskCategoryAttribute] // RVA: 0x1533A0 Offset: 0x1534A1 VA: 0x1533A0
[TaskDescriptionAttribute] // RVA: 0x1533A0 Offset: 0x1534A1 VA: 0x1533A0
public class SetShadows : Action // TypeDefIndex: 11273
{
	// Fields
	[TooltipAttribute] // RVA: 0x18F3B0 Offset: 0x18F4B1 VA: 0x18F3B0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18F3F0 Offset: 0x18F4F1 VA: 0x18F3F0
	public LightShadows shadows; // 0x58
	private Light light; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A4FD0 Offset: 0x27A50D1 VA: 0x27A4FD0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A50D0 Offset: 0x27A51D1 VA: 0x27A50D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A51B0 Offset: 0x27A52B1 VA: 0x27A51B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A51C0 Offset: 0x27A52C1 VA: 0x27A51C0
	public void .ctor() { }
}

