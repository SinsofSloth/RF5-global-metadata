[TaskCategoryAttribute] // RVA: 0x154240 Offset: 0x154341 VA: 0x154240
[TaskDescriptionAttribute] // RVA: 0x154240 Offset: 0x154341 VA: 0x154240
public class GetOffset : Action // TypeDefIndex: 11312
{
	// Fields
	[TooltipAttribute] // RVA: 0x1907E0 Offset: 0x1908E1 VA: 0x1907E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x190820 Offset: 0x190921 VA: 0x190820
	[RequiredFieldAttribute] // RVA: 0x190820 Offset: 0x190921 VA: 0x190820
	public SharedVector3 storeValue; // 0x58
	private CircleCollider2D circleCollider2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279F710 Offset: 0x279F811 VA: 0x279F710 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279F810 Offset: 0x279F911 VA: 0x279F810 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279F950 Offset: 0x279FA51 VA: 0x279F950 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279F9E0 Offset: 0x279FAE1 VA: 0x279F9E0
	public void .ctor() { }
}

