[TaskCategoryAttribute] // RVA: 0x151960 Offset: 0x151A61 VA: 0x151960
[TaskDescriptionAttribute] // RVA: 0x151960 Offset: 0x151A61 VA: 0x151960
public class IsStopped : Conditional // TypeDefIndex: 11198
{
	// Fields
	[TooltipAttribute] // RVA: 0x18CEA0 Offset: 0x18CFA1 VA: 0x18CEA0
	public SharedGameObject targetGameObject; // 0x50
	private ParticleSystem particleSystem; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x287B070 Offset: 0x287B171 VA: 0x287B070 Slot: 5
	public override void OnStart() { }

	// RVA: 0x287B170 Offset: 0x287B271 VA: 0x287B170 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x287B250 Offset: 0x287B351 VA: 0x287B250 Slot: 16
	public override void OnReset() { }

	// RVA: 0x287B260 Offset: 0x287B361 VA: 0x287B260
	public void .ctor() { }
}

