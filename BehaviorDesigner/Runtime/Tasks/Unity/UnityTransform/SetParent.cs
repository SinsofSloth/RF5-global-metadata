[TaskCategoryAttribute] // RVA: 0x14DA10 Offset: 0x14DB11 VA: 0x14DA10
[TaskDescriptionAttribute] // RVA: 0x14DA10 Offset: 0x14DB11 VA: 0x14DA10
public class SetParent : Action // TypeDefIndex: 11030
{
	// Fields
	[TooltipAttribute] // RVA: 0x186B60 Offset: 0x186C61 VA: 0x186B60
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186BA0 Offset: 0x186CA1 VA: 0x186BA0
	public SharedTransform parent; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x28901A0 Offset: 0x28902A1 VA: 0x28901A0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x28902A0 Offset: 0x28903A1 VA: 0x28902A0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28903A0 Offset: 0x28904A1 VA: 0x28903A0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28903E0 Offset: 0x28904E1 VA: 0x28903E0
	public void .ctor() { }
}

