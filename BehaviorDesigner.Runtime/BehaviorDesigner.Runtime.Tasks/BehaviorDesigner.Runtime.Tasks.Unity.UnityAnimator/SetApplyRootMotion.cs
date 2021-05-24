[TaskCategoryAttribute] // RVA: 0x156340 Offset: 0x156441 VA: 0x156340
[TaskDescriptionAttribute] // RVA: 0x156340 Offset: 0x156441 VA: 0x156340
public class SetApplyRootMotion : Action // TypeDefIndex: 11400
{
	// Fields
	[TooltipAttribute] // RVA: 0x193940 Offset: 0x193A41 VA: 0x193940
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x193980 Offset: 0x193A81 VA: 0x193980
	public SharedBool rootMotion; // 0x58
	private Animator animator; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2792FE0 Offset: 0x27930E1 VA: 0x2792FE0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x27930E0 Offset: 0x27931E1 VA: 0x27930E0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x27931E0 Offset: 0x27932E1 VA: 0x27931E0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2793230 Offset: 0x2793331 VA: 0x2793230
	public void .ctor() { }
}

