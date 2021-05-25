[TaskCategoryAttribute] // RVA: 0x155E60 Offset: 0x155F61 VA: 0x155E60
[TaskDescriptionAttribute] // RVA: 0x155E60 Offset: 0x155F61 VA: 0x155E60
public class GetDeltaRotation : Action // TypeDefIndex: 11387
{
	// Fields
	[TooltipAttribute] // RVA: 0x192F50 Offset: 0x193051 VA: 0x192F50
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192F90 Offset: 0x193091 VA: 0x192F90
	[RequiredFieldAttribute] // RVA: 0x192F90 Offset: 0x193091 VA: 0x192F90
	public SharedQuaternion storeValue; // 0x58
	private Animator animator; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2790F60 Offset: 0x2791061 VA: 0x2790F60 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2791060 Offset: 0x2791161 VA: 0x2791060 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2791150 Offset: 0x2791251 VA: 0x2791150 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27911E0 Offset: 0x27912E1 VA: 0x27911E0
	public void .ctor() { }
}

