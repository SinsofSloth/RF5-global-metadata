[TaskCategoryAttribute] // RVA: 0x156700 Offset: 0x156801 VA: 0x156700
[TaskDescriptionAttribute] // RVA: 0x156700 Offset: 0x156801 VA: 0x156700
public class StartRecording : Action // TypeDefIndex: 11413
{
	// Fields
	[TooltipAttribute] // RVA: 0x194040 Offset: 0x194141 VA: 0x194040
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x194080 Offset: 0x194181 VA: 0x194080
	public int frameCount; // 0x58
	private Animator animator; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2795040 Offset: 0x2795141 VA: 0x2795040 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2795140 Offset: 0x2795241 VA: 0x2795140 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2795220 Offset: 0x2795321 VA: 0x2795220 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2795250 Offset: 0x2795351 VA: 0x2795250
	public void .ctor() { }
}

