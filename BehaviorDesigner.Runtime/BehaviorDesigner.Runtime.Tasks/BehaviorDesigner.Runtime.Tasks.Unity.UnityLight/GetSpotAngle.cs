[TaskCategoryAttribute] // RVA: 0x153040 Offset: 0x153141 VA: 0x153040
[TaskDescriptionAttribute] // RVA: 0x153040 Offset: 0x153141 VA: 0x153040
public class GetSpotAngle : Action // TypeDefIndex: 11264
{
	// Fields
	[TooltipAttribute] // RVA: 0x18EF20 Offset: 0x18F021 VA: 0x18EF20
	public SharedGameObject targetGameObject; // 0x50
	[RequiredFieldAttribute] // RVA: 0x18EF60 Offset: 0x18F061 VA: 0x18EF60
	[TooltipAttribute] // RVA: 0x18EF60 Offset: 0x18F061 VA: 0x18EF60
	public SharedFloat storeValue; // 0x58
	private Light light; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A3B30 Offset: 0x27A3C31 VA: 0x27A3B30 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A3C30 Offset: 0x27A3D31 VA: 0x27A3C30 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A3D20 Offset: 0x27A3E21 VA: 0x27A3D20 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A3D70 Offset: 0x27A3E71 VA: 0x27A3D70
	public void .ctor() { }
}

