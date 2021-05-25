[TaskCategoryAttribute] // RVA: 0x14D890 Offset: 0x14D991 VA: 0x14D890
[TaskDescriptionAttribute] // RVA: 0x14D890 Offset: 0x14D991 VA: 0x14D890
public class SetLocalEulerAngles : Action // TypeDefIndex: 11026
{
	// Fields
	[TooltipAttribute] // RVA: 0x186960 Offset: 0x186A61 VA: 0x186960
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1869A0 Offset: 0x186AA1 VA: 0x1869A0
	public SharedVector3 localEulerAngles; // 0x58
	private Transform targetTransform; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x288F760 Offset: 0x288F861 VA: 0x288F760 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288F860 Offset: 0x288F961 VA: 0x288F860 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288F950 Offset: 0x288FA51 VA: 0x288F950 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288F9E0 Offset: 0x288FAE1 VA: 0x288F9E0
	public void .ctor() { }
}

