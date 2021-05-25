[TaskCategoryAttribute] // RVA: 0x154DE0 Offset: 0x154EE1 VA: 0x154DE0
[TaskDescriptionAttribute] // RVA: 0x154DE0 Offset: 0x154EE1 VA: 0x154DE0
public class SetCenter : Action // TypeDefIndex: 11343
{
	// Fields
	[TooltipAttribute] // RVA: 0x191850 Offset: 0x191951 VA: 0x191850
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191890 Offset: 0x191991 VA: 0x191890
	public SharedVector3 center; // 0x58
	private BoxCollider boxCollider; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279B640 Offset: 0x279B741 VA: 0x279B640 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279B740 Offset: 0x279B841 VA: 0x279B740 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279B830 Offset: 0x279B931 VA: 0x279B830 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279B8C0 Offset: 0x279B9C1 VA: 0x279B8C0
	public void .ctor() { }
}

