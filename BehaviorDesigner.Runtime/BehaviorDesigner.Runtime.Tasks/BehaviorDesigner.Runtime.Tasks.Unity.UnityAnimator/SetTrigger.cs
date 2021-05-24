[TaskCategoryAttribute] // RVA: 0x156640 Offset: 0x156741 VA: 0x156640
[TaskDescriptionAttribute] // RVA: 0x156640 Offset: 0x156741 VA: 0x156640
public class SetTrigger : Action // TypeDefIndex: 11411
{
	// Fields
	[TooltipAttribute] // RVA: 0x193F80 Offset: 0x194081 VA: 0x193F80
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x193FC0 Offset: 0x1940C1 VA: 0x193FC0
	public SharedString paramaterName; // 0x58
	private Animator animator; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2794BC0 Offset: 0x2794CC1 VA: 0x2794BC0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2794CC0 Offset: 0x2794DC1 VA: 0x2794CC0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2794DC0 Offset: 0x2794EC1 VA: 0x2794DC0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2794E30 Offset: 0x2794F31 VA: 0x2794E30
	public void .ctor() { }
}

