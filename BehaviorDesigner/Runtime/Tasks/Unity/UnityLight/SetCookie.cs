[TaskCategoryAttribute] // RVA: 0x153100 Offset: 0x153201 VA: 0x153100
[TaskDescriptionAttribute] // RVA: 0x153100 Offset: 0x153201 VA: 0x153100
public class SetCookie : Action // TypeDefIndex: 11266
{
	// Fields
	[TooltipAttribute] // RVA: 0x18F030 Offset: 0x18F131 VA: 0x18F030
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18F070 Offset: 0x18F171 VA: 0x18F070
	public Texture2D cookie; // 0x58
	private Light light; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x27A3FD0 Offset: 0x27A40D1 VA: 0x27A3FD0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A40D0 Offset: 0x27A41D1 VA: 0x27A40D0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A41B0 Offset: 0x27A42B1 VA: 0x27A41B0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A41F0 Offset: 0x27A42F1 VA: 0x27A41F0
	public void .ctor() { }
}

