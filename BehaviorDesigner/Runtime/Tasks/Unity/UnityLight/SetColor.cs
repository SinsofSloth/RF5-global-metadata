[TaskCategoryAttribute] // RVA: 0x1530A0 Offset: 0x1531A1 VA: 0x1530A0
[TaskDescriptionAttribute] // RVA: 0x1530A0 Offset: 0x1531A1 VA: 0x1530A0
public class SetColor : Action // TypeDefIndex: 11265
{
	// Fields
	[TooltipAttribute] // RVA: 0x18EFB0 Offset: 0x18F0B1 VA: 0x18EFB0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18EFF0 Offset: 0x18F0F1 VA: 0x18EFF0
	public SharedColor color; // 0x58
	private Light light; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A3D80 Offset: 0x27A3E81 VA: 0x27A3D80 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A3E80 Offset: 0x27A3F81 VA: 0x27A3E80 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A3F70 Offset: 0x27A4071 VA: 0x27A3F70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A3FC0 Offset: 0x27A40C1 VA: 0x27A3FC0
	public void .ctor() { }
}

