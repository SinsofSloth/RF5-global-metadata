[TaskCategoryAttribute] // RVA: 0x155A40 Offset: 0x155B41 VA: 0x155A40
[TaskDescriptionAttribute] // RVA: 0x155A40 Offset: 0x155B41 VA: 0x155A40
public class SetScheduledEndTime : Action // TypeDefIndex: 11376
{
	// Fields
	[TooltipAttribute] // RVA: 0x1928E0 Offset: 0x1929E1 VA: 0x1928E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192920 Offset: 0x192A21 VA: 0x192920
	public SharedFloat time; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2799CF0 Offset: 0x2799DF1 VA: 0x2799CF0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2799DF0 Offset: 0x2799EF1 VA: 0x2799DF0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2799EF0 Offset: 0x2799FF1 VA: 0x2799EF0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2799F40 Offset: 0x279A041 VA: 0x2799F40
	public void .ctor() { }
}

