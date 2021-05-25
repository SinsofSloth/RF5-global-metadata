[TaskCategoryAttribute] // RVA: 0x151EA0 Offset: 0x151FA1 VA: 0x151EA0
[TaskDescriptionAttribute] // RVA: 0x151EA0 Offset: 0x151FA1 VA: 0x151EA0
public class SetTime : Action // TypeDefIndex: 11212
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D4E0 Offset: 0x18D5E1 VA: 0x18D4E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18D520 Offset: 0x18D621 VA: 0x18D520
	public SharedFloat time; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x287D220 Offset: 0x287D321 VA: 0x287D220 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287D320 Offset: 0x287D421 VA: 0x287D320 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287D410 Offset: 0x287D511 VA: 0x287D410 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287D460 Offset: 0x287D561 VA: 0x287D460
	public void .ctor() { }
}

