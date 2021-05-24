[TaskCategoryAttribute] // RVA: 0x154780 Offset: 0x154881 VA: 0x154780
[TaskDescriptionAttribute] // RVA: 0x154780 Offset: 0x154881 VA: 0x154780
public class SetHeight : Action // TypeDefIndex: 11326
{
	// Fields
	[TooltipAttribute] // RVA: 0x190F60 Offset: 0x191061 VA: 0x190F60
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x190FA0 Offset: 0x1910A1 VA: 0x190FA0
	public SharedFloat height; // 0x58
	private CharacterController characterController; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279EB40 Offset: 0x279EC41 VA: 0x279EB40 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279EC40 Offset: 0x279ED41 VA: 0x279EC40 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279ED30 Offset: 0x279EE31 VA: 0x279ED30 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279ED80 Offset: 0x279EE81 VA: 0x279ED80
	public void .ctor() { }
}

