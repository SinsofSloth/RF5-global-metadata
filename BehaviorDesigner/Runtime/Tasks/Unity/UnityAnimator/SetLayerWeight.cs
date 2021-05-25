[TaskCategoryAttribute] // RVA: 0x1564C0 Offset: 0x1565C1 VA: 0x1564C0
[TaskDescriptionAttribute] // RVA: 0x1564C0 Offset: 0x1565C1 VA: 0x1564C0
public class SetLayerWeight : Action // TypeDefIndex: 11407
{
	// Fields
	[TooltipAttribute] // RVA: 0x193CC0 Offset: 0x193DC1 VA: 0x193CC0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x193D00 Offset: 0x193E01 VA: 0x193D00
	public SharedInt index; // 0x58
	[TooltipAttribute] // RVA: 0x193D40 Offset: 0x193E41 VA: 0x193D40
	public SharedFloat weight; // 0x60
	private Animator animator; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x27941F0 Offset: 0x27942F1 VA: 0x27941F0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27942F0 Offset: 0x27943F1 VA: 0x27942F0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2794410 Offset: 0x2794511 VA: 0x2794410 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2794470 Offset: 0x2794571 VA: 0x2794470
	public void .ctor() { }
}

