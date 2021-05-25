[TaskCategoryAttribute] // RVA: 0x14D770 Offset: 0x14D871 VA: 0x14D770
[TaskDescriptionAttribute] // RVA: 0x14D770 Offset: 0x14D871 VA: 0x14D770
public class RotateAround : Action // TypeDefIndex: 11023
{
	// Fields
	[TooltipAttribute] // RVA: 0x186760 Offset: 0x186861 VA: 0x186760
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1867A0 Offset: 0x1868A1 VA: 0x1867A0
	public SharedVector3 point; // 0x58
	[TooltipAttribute] // RVA: 0x1867E0 Offset: 0x1868E1 VA: 0x1867E0
	public SharedVector3 axis; // 0x60
	[TooltipAttribute] // RVA: 0x186820 Offset: 0x186921 VA: 0x186820
	public SharedFloat angle; // 0x68
	private Transform targetTransform; // 0x70
	private GameObject prevGameObject; // 0x78

	// Methods

	// RVA: 0x288EEF0 Offset: 0x288EFF1 VA: 0x288EEF0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x288EFF0 Offset: 0x288F0F1 VA: 0x288EFF0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x288F160 Offset: 0x288F261 VA: 0x288F160 Slot: 16
	public override void OnReset() { }

	// RVA: 0x288F230 Offset: 0x288F331 VA: 0x288F230
	public void .ctor() { }
}

