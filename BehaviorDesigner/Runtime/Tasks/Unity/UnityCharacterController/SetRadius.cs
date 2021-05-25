[TaskCategoryAttribute] // RVA: 0x1547E0 Offset: 0x1548E1 VA: 0x1547E0
[TaskDescriptionAttribute] // RVA: 0x1547E0 Offset: 0x1548E1 VA: 0x1547E0
public class SetRadius : Action // TypeDefIndex: 11327
{
	// Fields
	[TooltipAttribute] // RVA: 0x190FE0 Offset: 0x1910E1 VA: 0x190FE0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191020 Offset: 0x191121 VA: 0x191020
	public SharedFloat radius; // 0x58
	private CharacterController characterController; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279ED90 Offset: 0x279EE91 VA: 0x279ED90 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279EE90 Offset: 0x279EF91 VA: 0x279EE90 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279EF80 Offset: 0x279F081 VA: 0x279EF80 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279EFD0 Offset: 0x279F0D1 VA: 0x279EFD0
	public void .ctor() { }
}

