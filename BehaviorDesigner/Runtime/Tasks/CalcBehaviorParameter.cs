[TaskDescriptionAttribute] // RVA: 0x14A9C0 Offset: 0x14AAC1 VA: 0x14A9C0
[TaskCategoryAttribute] // RVA: 0x14A9C0 Offset: 0x14AAC1 VA: 0x14A9C0
[TaskIconAttribute] // RVA: 0x14A9C0 Offset: 0x14AAC1 VA: 0x14A9C0
public class CalcBehaviorParameter : Action // TypeDefIndex: 10904
{
	// Fields
	[TooltipAttribute] // RVA: 0x182010 Offset: 0x182111 VA: 0x182010
	public SharedFloat MoveSpeedMax; // 0x50
	[TooltipAttribute] // RVA: 0x182050 Offset: 0x182151 VA: 0x182050
	public SharedFloat ReturnArriveDistance; // 0x58
	[TooltipAttribute] // RVA: 0x182090 Offset: 0x182191 VA: 0x182090
	public SharedFloat AngularSpeed; // 0x60
	[TooltipAttribute] // RVA: 0x1820D0 Offset: 0x1821D1 VA: 0x1820D0
	public SharedFloat ReturnRotationDelta; // 0x68

	// Methods

	// RVA: 0x20DCBA0 Offset: 0x20DCCA1 VA: 0x20DCBA0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x20DCCB0 Offset: 0x20DCDB1 VA: 0x20DCCB0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x20DCD10 Offset: 0x20DCE11 VA: 0x20DCD10
	public void .ctor() { }
}

