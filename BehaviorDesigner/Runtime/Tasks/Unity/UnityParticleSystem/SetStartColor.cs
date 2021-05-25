[TaskCategoryAttribute] // RVA: 0x151C60 Offset: 0x151D61 VA: 0x151C60
[TaskDescriptionAttribute] // RVA: 0x151C60 Offset: 0x151D61 VA: 0x151C60
public class SetStartColor : Action // TypeDefIndex: 11206
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D1E0 Offset: 0x18D2E1 VA: 0x18D1E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18D220 Offset: 0x18D321 VA: 0x18D220
	public SharedColor startColor; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x287C2B0 Offset: 0x287C3B1 VA: 0x287C2B0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287C3B0 Offset: 0x287C4B1 VA: 0x287C3B0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287C4F0 Offset: 0x287C5F1 VA: 0x287C4F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287C540 Offset: 0x287C641 VA: 0x287C540
	public void .ctor() { }
}

