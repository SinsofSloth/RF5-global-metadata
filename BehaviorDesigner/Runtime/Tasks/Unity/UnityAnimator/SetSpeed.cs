[TaskCategoryAttribute] // RVA: 0x1565E0 Offset: 0x1566E1 VA: 0x1565E0
[TaskDescriptionAttribute] // RVA: 0x1565E0 Offset: 0x1566E1 VA: 0x1565E0
public class SetSpeed : Action // TypeDefIndex: 11410
{
	// Fields
	[TooltipAttribute] // RVA: 0x193F00 Offset: 0x194001 VA: 0x193F00
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x193F40 Offset: 0x194041 VA: 0x193F40
	public SharedFloat speed; // 0x58
	private Animator animator; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2794970 Offset: 0x2794A71 VA: 0x2794970 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2794A70 Offset: 0x2794B71 VA: 0x2794A70 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2794B60 Offset: 0x2794C61 VA: 0x2794B60 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2794BB0 Offset: 0x2794CB1 VA: 0x2794BB0
	public void .ctor() { }
}

