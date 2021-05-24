[TaskDescriptionAttribute] // RVA: 0x157180 Offset: 0x157281 VA: 0x157180
[TaskCategoryAttribute] // RVA: 0x157180 Offset: 0x157281 VA: 0x157180
[HelpURLAttribute] // RVA: 0x157180 Offset: 0x157281 VA: 0x157180
[TaskIconAttribute] // RVA: 0x157180 Offset: 0x157281 VA: 0x157180
public class RotateTowardsEx : Action // TypeDefIndex: 11441
{
	// Fields
	public SharedFloat rotationEpsilon; // 0x50
	[TooltipAttribute] // RVA: 0x194F30 Offset: 0x195031 VA: 0x194F30
	public SharedFloat maxLookAtRotationDelta; // 0x58
	[TooltipAttribute] // RVA: 0x194F70 Offset: 0x195071 VA: 0x194F70
	public SharedBool onlyY; // 0x60
	[TooltipAttribute] // RVA: 0x194FB0 Offset: 0x1950B1 VA: 0x194FB0
	public SharedGameObject target; // 0x68
	[TooltipAttribute] // RVA: 0x194FF0 Offset: 0x1950F1 VA: 0x194FF0
	public SharedVector3 targetPosition; // 0x70

	// Methods

	// RVA: 0x20E3E00 Offset: 0x20E3F01 VA: 0x20E3E00 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20E3FB0 Offset: 0x20E40B1 VA: 0x20E3FB0
	private Quaternion Target() { }

	// RVA: 0x20E4180 Offset: 0x20E4281 VA: 0x20E4180 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20E4370 Offset: 0x20E4471 VA: 0x20E4370
	public void .ctor() { }
}

