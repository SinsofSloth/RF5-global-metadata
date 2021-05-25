[TaskCategoryAttribute] // RVA: 0x1514E0 Offset: 0x1515E1 VA: 0x1514E0
[TaskDescriptionAttribute] // RVA: 0x1514E0 Offset: 0x1515E1 VA: 0x1514E0
public class Clear : Action // TypeDefIndex: 11186
{
	// Fields
	[TooltipAttribute] // RVA: 0x18C920 Offset: 0x18CA21 VA: 0x18C920
	public SharedGameObject targetGameObject; // 0x50
	private ParticleSystem particleSystem; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x2879510 Offset: 0x2879611 VA: 0x2879510 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2879610 Offset: 0x2879711 VA: 0x2879610 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x28796F0 Offset: 0x28797F1 VA: 0x28796F0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2879700 Offset: 0x2879801 VA: 0x2879700
	public void .ctor() { }
}

