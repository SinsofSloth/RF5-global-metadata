[TaskCategoryAttribute] // RVA: 0x1561C0 Offset: 0x1562C1 VA: 0x1561C0
[TaskDescriptionAttribute] // RVA: 0x1561C0 Offset: 0x1562C1 VA: 0x1561C0
public class IsName : Conditional // TypeDefIndex: 11396
{
	// Fields
	[TooltipAttribute] // RVA: 0x193500 Offset: 0x193601 VA: 0x193500
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x193540 Offset: 0x193641 VA: 0x193540
	public SharedInt index; // 0x58
	[TooltipAttribute] // RVA: 0x193580 Offset: 0x193681 VA: 0x193580
	public SharedString name; // 0x60
	private Animator animator; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x2792420 Offset: 0x2792521 VA: 0x2792420 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2792520 Offset: 0x2792621 VA: 0x2792520 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2792680 Offset: 0x2792781 VA: 0x2792680 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2792710 Offset: 0x2792811 VA: 0x2792710
	public void .ctor() { }
}

