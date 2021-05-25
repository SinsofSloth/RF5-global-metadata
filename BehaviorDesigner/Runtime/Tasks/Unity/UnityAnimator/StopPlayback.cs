[TaskCategoryAttribute] // RVA: 0x156760 Offset: 0x156861 VA: 0x156760
[TaskDescriptionAttribute] // RVA: 0x156760 Offset: 0x156861 VA: 0x156760
public class StopPlayback : Action // TypeDefIndex: 11414
{
	// Fields
	[TooltipAttribute] // RVA: 0x1940C0 Offset: 0x1941C1 VA: 0x1940C0
	public SharedGameObject targetGameObject; // 0x50
	private Animator animator; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x2795260 Offset: 0x2795361 VA: 0x2795260 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2795360 Offset: 0x2795461 VA: 0x2795360 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2795440 Offset: 0x2795541 VA: 0x2795440 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2795450 Offset: 0x2795551 VA: 0x2795450
	public void .ctor() { }
}

