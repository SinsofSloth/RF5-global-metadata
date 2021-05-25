[TaskCategoryAttribute] // RVA: 0x156CA0 Offset: 0x156DA1 VA: 0x156CA0
[TaskDescriptionAttribute] // RVA: 0x156CA0 Offset: 0x156DA1 VA: 0x156CA0
public class Stop : Action // TypeDefIndex: 11428
{
	// Fields
	[TooltipAttribute] // RVA: 0x194A10 Offset: 0x194B11 VA: 0x194A10
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x194A50 Offset: 0x194B51 VA: 0x194A50
	public SharedString animationName; // 0x58
	private Animation animation; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2790230 Offset: 0x2790331 VA: 0x2790230 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2790330 Offset: 0x2790431 VA: 0x2790330 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2790460 Offset: 0x2790561 VA: 0x2790460 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27904D0 Offset: 0x27905D1 VA: 0x27904D0
	public void .ctor() { }
}

