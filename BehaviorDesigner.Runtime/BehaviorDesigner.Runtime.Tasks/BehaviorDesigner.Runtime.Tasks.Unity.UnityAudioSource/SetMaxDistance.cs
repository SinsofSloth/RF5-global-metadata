[TaskCategoryAttribute] // RVA: 0x155800 Offset: 0x155901 VA: 0x155800
[TaskDescriptionAttribute] // RVA: 0x155800 Offset: 0x155901 VA: 0x155800
public class SetMaxDistance : Action // TypeDefIndex: 11370
{
	// Fields
	[TooltipAttribute] // RVA: 0x1925E0 Offset: 0x1926E1 VA: 0x1925E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192620 Offset: 0x192721 VA: 0x192620
	public SharedFloat maxDistance; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2798F20 Offset: 0x2799021 VA: 0x2798F20 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2799020 Offset: 0x2799121 VA: 0x2799020 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2799110 Offset: 0x2799211 VA: 0x2799110 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2799160 Offset: 0x2799261 VA: 0x2799160
	public void .ctor() { }
}

