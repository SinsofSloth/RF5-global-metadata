[TaskCategoryAttribute] // RVA: 0x156940 Offset: 0x156A41 VA: 0x156940
[TaskDescriptionAttribute] // RVA: 0x156940 Offset: 0x156A41 VA: 0x156940
public class CrossFadeQueued : Action // TypeDefIndex: 11419
{
	// Fields
	[TooltipAttribute] // RVA: 0x194440 Offset: 0x194541 VA: 0x194440
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x194480 Offset: 0x194581 VA: 0x194480
	public SharedString animationName; // 0x58
	[TooltipAttribute] // RVA: 0x1944C0 Offset: 0x1945C1 VA: 0x1944C0
	public float fadeLength; // 0x60
	[TooltipAttribute] // RVA: 0x194500 Offset: 0x194601 VA: 0x194500
	public QueueMode queue; // 0x64
	[TooltipAttribute] // RVA: 0x194540 Offset: 0x194641 VA: 0x194540
	public PlayMode playMode; // 0x68
	private Animation animation; // 0x70
	private GameObject prevGameObject; // 0x78

	// Methods

	// RVA: 0x278EB70 Offset: 0x278EC71 VA: 0x278EB70 Slot: 5
	public override void OnStart() { }

	// RVA: 0x278EC70 Offset: 0x278ED71 VA: 0x278EC70 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278ED70 Offset: 0x278EE71 VA: 0x278ED70 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278EE00 Offset: 0x278EF01 VA: 0x278EE00
	public void .ctor() { }
}

