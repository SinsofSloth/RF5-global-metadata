[TaskCategoryAttribute] // RVA: 0x154360 Offset: 0x154461 VA: 0x154360
[TaskDescriptionAttribute] // RVA: 0x154360 Offset: 0x154461 VA: 0x154360
public class SetRadius : Action // TypeDefIndex: 11315
{
	// Fields
	[TooltipAttribute] // RVA: 0x190980 Offset: 0x190A81 VA: 0x190980
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1909C0 Offset: 0x190AC1 VA: 0x1909C0
	public SharedFloat radius; // 0x58
	private CircleCollider2D circleCollider2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279FF20 Offset: 0x27A0021 VA: 0x279FF20 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27A0020 Offset: 0x27A0121 VA: 0x27A0020 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27A0110 Offset: 0x27A0211 VA: 0x27A0110 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27A0160 Offset: 0x27A0261 VA: 0x27A0160
	public void .ctor() { }
}

