[TaskCategoryAttribute] // RVA: 0x154B40 Offset: 0x154C41 VA: 0x154B40
[TaskDescriptionAttribute] // RVA: 0x154B40 Offset: 0x154C41 VA: 0x154B40
public class SetDirection : Action // TypeDefIndex: 11336
{
	// Fields
	[TooltipAttribute] // RVA: 0x1914A0 Offset: 0x1915A1 VA: 0x1914A0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1914E0 Offset: 0x1915E1 VA: 0x1914E0
	public SharedInt direction; // 0x58
	private CapsuleCollider capsuleCollider; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279CCA0 Offset: 0x279CDA1 VA: 0x279CCA0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279CDA0 Offset: 0x279CEA1 VA: 0x279CDA0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279CEA0 Offset: 0x279CFA1 VA: 0x279CEA0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279CEF0 Offset: 0x279CFF1 VA: 0x279CEF0
	public void .ctor() { }
}

