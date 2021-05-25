[TaskCategoryAttribute] // RVA: 0x151DE0 Offset: 0x151EE1 VA: 0x151DE0
[TaskDescriptionAttribute] // RVA: 0x151DE0 Offset: 0x151EE1 VA: 0x151DE0
public class SetStartSize : Action // TypeDefIndex: 11210
{
	// Fields
	[TooltipAttribute] // RVA: 0x18D3E0 Offset: 0x18D4E1 VA: 0x18D3E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x18D420 Offset: 0x18D521 VA: 0x18D420
	public SharedFloat startSize; // 0x58
	private ParticleSystem particleSystem; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x287CD00 Offset: 0x287CE01 VA: 0x287CD00 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287CE00 Offset: 0x287CF01 VA: 0x287CE00 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287CF30 Offset: 0x287D031 VA: 0x287CF30 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287CF80 Offset: 0x287D081 VA: 0x287CF80
	public void .ctor() { }
}

