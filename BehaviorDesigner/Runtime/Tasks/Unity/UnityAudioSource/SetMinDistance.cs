[TaskCategoryAttribute] // RVA: 0x155860 Offset: 0x155961 VA: 0x155860
[TaskDescriptionAttribute] // RVA: 0x155860 Offset: 0x155961 VA: 0x155860
public class SetMinDistance : Action // TypeDefIndex: 11371
{
	// Fields
	[TooltipAttribute] // RVA: 0x192660 Offset: 0x192761 VA: 0x192660
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1926A0 Offset: 0x1927A1 VA: 0x1926A0
	public SharedFloat minDistance; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2799170 Offset: 0x2799271 VA: 0x2799170 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2799270 Offset: 0x2799371 VA: 0x2799270 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2799360 Offset: 0x2799461 VA: 0x2799360 Slot: 16
	public override void OnReset() { }

	// RVA: 0x27993B0 Offset: 0x27994B1 VA: 0x27993B0
	public void .ctor() { }
}

