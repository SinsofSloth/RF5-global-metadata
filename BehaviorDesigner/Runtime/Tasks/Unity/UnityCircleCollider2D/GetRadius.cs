[TaskCategoryAttribute] // RVA: 0x1542A0 Offset: 0x1543A1 VA: 0x1542A0
[TaskDescriptionAttribute] // RVA: 0x1542A0 Offset: 0x1543A1 VA: 0x1542A0
public class GetRadius : Action // TypeDefIndex: 11313
{
	// Fields
	[TooltipAttribute] // RVA: 0x190870 Offset: 0x190971 VA: 0x190870
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1908B0 Offset: 0x1909B1 VA: 0x1908B0
	[RequiredFieldAttribute] // RVA: 0x1908B0 Offset: 0x1909B1 VA: 0x1908B0
	public SharedFloat storeValue; // 0x58
	private CircleCollider2D circleCollider2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279F9F0 Offset: 0x279FAF1 VA: 0x279F9F0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279FAF0 Offset: 0x279FBF1 VA: 0x279FAF0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279FBE0 Offset: 0x279FCE1 VA: 0x279FBE0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279FC30 Offset: 0x279FD31 VA: 0x279FC30
	public void .ctor() { }
}

