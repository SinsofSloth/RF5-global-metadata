[TaskCategoryAttribute] // RVA: 0x152FE0 Offset: 0x1530E1 VA: 0x152FE0
[TaskDescriptionAttribute] // RVA: 0x152FE0 Offset: 0x1530E1 VA: 0x152FE0
public class GetShadowStrength : Action // TypeDefIndex: 11263
{
	// Fields
	[TooltipAttribute] // RVA: 0x18EE90 Offset: 0x18EF91 VA: 0x18EE90
	public SharedGameObject targetGameObject; // 0x50
	[RequiredFieldAttribute] // RVA: 0x18EED0 Offset: 0x18EFD1 VA: 0x18EED0
	[TooltipAttribute] // RVA: 0x18EED0 Offset: 0x18EFD1 VA: 0x18EED0
	public SharedFloat storeValue; // 0x58
	private Light light; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A38E0 Offset: 0x27A39E1 VA: 0x27A38E0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A39E0 Offset: 0x27A3AE1 VA: 0x27A39E0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A3AD0 Offset: 0x27A3BD1 VA: 0x27A3AD0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A3B20 Offset: 0x27A3C21 VA: 0x27A3B20
	public void .ctor() { }
}

