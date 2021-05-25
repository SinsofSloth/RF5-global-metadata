[TaskCategoryAttribute] // RVA: 0x152F20 Offset: 0x153021 VA: 0x152F20
[TaskDescriptionAttribute] // RVA: 0x152F20 Offset: 0x153021 VA: 0x152F20
public class GetRange : Action // TypeDefIndex: 11261
{
	// Fields
	[TooltipAttribute] // RVA: 0x18ED70 Offset: 0x18EE71 VA: 0x18ED70
	public SharedGameObject targetGameObject; // 0x50
	[RequiredFieldAttribute] // RVA: 0x18EDB0 Offset: 0x18EEB1 VA: 0x18EDB0
	[TooltipAttribute] // RVA: 0x18EDB0 Offset: 0x18EEB1 VA: 0x18EDB0
	public SharedFloat storeValue; // 0x58
	private Light light; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A3440 Offset: 0x27A3541 VA: 0x27A3440 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A3540 Offset: 0x27A3641 VA: 0x27A3540 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A3630 Offset: 0x27A3731 VA: 0x27A3630 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A3680 Offset: 0x27A3781 VA: 0x27A3680
	public void .ctor() { }
}

