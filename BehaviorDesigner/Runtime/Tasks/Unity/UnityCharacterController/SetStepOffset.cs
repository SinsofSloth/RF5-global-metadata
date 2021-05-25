[TaskCategoryAttribute] // RVA: 0x1548A0 Offset: 0x1549A1 VA: 0x1548A0
[TaskDescriptionAttribute] // RVA: 0x1548A0 Offset: 0x1549A1 VA: 0x1548A0
public class SetStepOffset : Action // TypeDefIndex: 11329
{
	// Fields
	[TooltipAttribute] // RVA: 0x1910E0 Offset: 0x1911E1 VA: 0x1910E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191120 Offset: 0x191221 VA: 0x191120
	public SharedFloat stepOffset; // 0x58
	private CharacterController characterController; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279F230 Offset: 0x279F331 VA: 0x279F230 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279F330 Offset: 0x279F431 VA: 0x279F330 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279F420 Offset: 0x279F521 VA: 0x279F420 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279F470 Offset: 0x279F571 VA: 0x279F470
	public void .ctor() { }
}

