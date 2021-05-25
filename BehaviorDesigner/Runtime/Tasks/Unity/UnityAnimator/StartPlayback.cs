[TaskCategoryAttribute] // RVA: 0x1566A0 Offset: 0x1567A1 VA: 0x1566A0
[TaskDescriptionAttribute] // RVA: 0x1566A0 Offset: 0x1567A1 VA: 0x1566A0
public class StartPlayback : Action // TypeDefIndex: 11412
{
	// Fields
	[TooltipAttribute] // RVA: 0x194000 Offset: 0x194101 VA: 0x194000
	public SharedGameObject targetGameObject; // 0x50
	private Animator animator; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x2794E40 Offset: 0x2794F41 VA: 0x2794E40 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2794F40 Offset: 0x2795041 VA: 0x2794F40 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2795020 Offset: 0x2795121 VA: 0x2795020 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2795030 Offset: 0x2795131 VA: 0x2795030
	public void .ctor() { }
}

