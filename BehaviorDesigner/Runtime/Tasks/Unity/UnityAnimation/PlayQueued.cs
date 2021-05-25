[TaskCategoryAttribute] // RVA: 0x156AC0 Offset: 0x156BC1 VA: 0x156AC0
[TaskDescriptionAttribute] // RVA: 0x156AC0 Offset: 0x156BC1 VA: 0x156AC0
public class PlayQueued : Action // TypeDefIndex: 11423
{
	// Fields
	[TooltipAttribute] // RVA: 0x194750 Offset: 0x194851 VA: 0x194750
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x194790 Offset: 0x194891 VA: 0x194790
	public SharedString animationName; // 0x58
	[TooltipAttribute] // RVA: 0x1947D0 Offset: 0x1948D1 VA: 0x1947D0
	public QueueMode queue; // 0x60
	[TooltipAttribute] // RVA: 0x194810 Offset: 0x194911 VA: 0x194810
	public PlayMode playMode; // 0x64
	private Animation animation; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x278F640 Offset: 0x278F741 VA: 0x278F640 Slot: 5
	public override void OnStart() { }

	// RVA: 0x278F740 Offset: 0x278F841 VA: 0x278F740 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x278F840 Offset: 0x278F941 VA: 0x278F840 Slot: 16
	public override void OnReset() { }

	// RVA: 0x278F8C0 Offset: 0x278F9C1 VA: 0x278F8C0
	public void .ctor() { }
}

