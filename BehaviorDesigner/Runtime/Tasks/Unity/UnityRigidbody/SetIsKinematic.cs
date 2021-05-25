[TaskCategoryAttribute] // RVA: 0x1506A0 Offset: 0x1507A1 VA: 0x1506A0
[TaskDescriptionAttribute] // RVA: 0x1506A0 Offset: 0x1507A1 VA: 0x1506A0
public class SetIsKinematic : Action // TypeDefIndex: 11148
{
	// Fields
	[TooltipAttribute] // RVA: 0x18AA80 Offset: 0x18AB81 VA: 0x18AA80
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18AAC0 Offset: 0x18ABC1 VA: 0x18AAC0
	public SharedBool isKinematic; // 0x58
	private Rigidbody rigidbody; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x28853F0 Offset: 0x28854F1 VA: 0x28853F0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28854F0 Offset: 0x28855F1 VA: 0x28854F0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28855F0 Offset: 0x28856F1 VA: 0x28855F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2885640 Offset: 0x2885741 VA: 0x2885640
	public void .ctor() { }
}

