[TaskCategoryAttribute] // RVA: 0x155920 Offset: 0x155A21 VA: 0x155920
[TaskDescriptionAttribute] // RVA: 0x155920 Offset: 0x155A21 VA: 0x155920
public class SetPitch : Action // TypeDefIndex: 11373
{
	// Fields
	[TooltipAttribute] // RVA: 0x192760 Offset: 0x192861 VA: 0x192760
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1927A0 Offset: 0x1928A1 VA: 0x1927A0
	public SharedFloat pitch; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2799620 Offset: 0x2799721 VA: 0x2799620 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2799720 Offset: 0x2799821 VA: 0x2799720 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2799810 Offset: 0x2799911 VA: 0x2799810 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2799860 Offset: 0x2799961 VA: 0x2799860
	public void .ctor() { }
}

