[TaskCategoryAttribute] // RVA: 0x1568E0 Offset: 0x1569E1 VA: 0x1568E0
[TaskDescriptionAttribute] // RVA: 0x1568E0 Offset: 0x1569E1 VA: 0x1568E0
public class CrossFade : Action // TypeDefIndex: 11418
{
	// Fields
	[TooltipAttribute] // RVA: 0x194300 Offset: 0x194401 VA: 0x194300
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x194340 Offset: 0x194441 VA: 0x194340
	public SharedString animationName; // 0x58
	[TooltipAttribute] // RVA: 0x194380 Offset: 0x194481 VA: 0x194380
	public SharedFloat animationSpeed; // 0x60
	[TooltipAttribute] // RVA: 0x1943C0 Offset: 0x1944C1 VA: 0x1943C0
	public SharedFloat fadeLength; // 0x68
	[TooltipAttribute] // RVA: 0x194400 Offset: 0x194501 VA: 0x194400
	public PlayMode playMode; // 0x70
	private Animation animation; // 0x78
	private GameObject prevGameObject; // 0x80

	// Methods

	// RVA: 0x278E730 Offset: 0x278E831 VA: 0x278E730 Slot: 5
	public override void OnStart() { }

	// RVA: 0x278E830 Offset: 0x278E931 VA: 0x278E830 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278EA50 Offset: 0x278EB51 VA: 0x278EA50 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278EB10 Offset: 0x278EC11 VA: 0x278EB10
	public void .ctor() { }
}

