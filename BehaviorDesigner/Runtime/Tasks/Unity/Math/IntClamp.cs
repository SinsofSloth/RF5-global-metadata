[TaskCategoryAttribute] // RVA: 0x152920 Offset: 0x152A21 VA: 0x152920
[TaskDescriptionAttribute] // RVA: 0x152920 Offset: 0x152A21 VA: 0x152920
public class IntClamp : Action // TypeDefIndex: 11243
{
	// Fields
	[TooltipAttribute] // RVA: 0x18E2D0 Offset: 0x18E3D1 VA: 0x18E2D0
	public SharedInt intVariable; // 0x50
	[TooltipAttribute] // RVA: 0x18E310 Offset: 0x18E411 VA: 0x18E310
	public SharedInt minValue; // 0x58
	[TooltipAttribute] // RVA: 0x18E350 Offset: 0x18E451 VA: 0x18E350
	public SharedInt maxValue; // 0x60

	// Methods

	// RVA: 0x20EB080 Offset: 0x20EB181 VA: 0x20EB080 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20EB170 Offset: 0x20EB271 VA: 0x20EB170 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20EB310 Offset: 0x20EB411 VA: 0x20EB310
	public void .ctor() { }
}

