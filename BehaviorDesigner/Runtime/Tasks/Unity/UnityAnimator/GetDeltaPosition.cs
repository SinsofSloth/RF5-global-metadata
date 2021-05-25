[TaskCategoryAttribute] // RVA: 0x155E00 Offset: 0x155F01 VA: 0x155E00
[TaskDescriptionAttribute] // RVA: 0x155E00 Offset: 0x155F01 VA: 0x155E00
public class GetDeltaPosition : Action // TypeDefIndex: 11386
{
	// Fields
	[TooltipAttribute] // RVA: 0x192EC0 Offset: 0x192FC1 VA: 0x192EC0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192F00 Offset: 0x193001 VA: 0x192F00
	[RequiredFieldAttribute] // RVA: 0x192F00 Offset: 0x193001 VA: 0x192F00
	public SharedVector3 storeValue; // 0x58
	private Animator animator; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2790CD0 Offset: 0x2790DD1 VA: 0x2790CD0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2790DD0 Offset: 0x2790ED1 VA: 0x2790DD0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2790EC0 Offset: 0x2790FC1 VA: 0x2790EC0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2790F50 Offset: 0x2791051 VA: 0x2790F50
	public void .ctor() { }
}

