[TaskCategoryAttribute] // RVA: 0x14DBF0 Offset: 0x14DCF1 VA: 0x14DBF0
[TaskDescriptionAttribute] // RVA: 0x14DBF0 Offset: 0x14DCF1 VA: 0x14DBF0
public class Translate : Action // TypeDefIndex: 11035
{
	// Fields
	[TooltipAttribute] // RVA: 0x186DE0 Offset: 0x186EE1 VA: 0x186DE0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x186E20 Offset: 0x186F21 VA: 0x186E20
	public SharedVector3 translation; // 0x58
	[TooltipAttribute] // RVA: 0x186E60 Offset: 0x186F61 VA: 0x186E60
	public Space relativeTo; // 0x60
	private Transform targetTransform; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x2890E30 Offset: 0x2890F31 VA: 0x2890E30 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2890F30 Offset: 0x2891031 VA: 0x2890F30 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2891030 Offset: 0x2891131 VA: 0x2891030 Slot: 16
	public override void OnReset() { }

	// RVA: 0x28910D0 Offset: 0x28911D1 VA: 0x28910D0
	public void .ctor() { }
}

