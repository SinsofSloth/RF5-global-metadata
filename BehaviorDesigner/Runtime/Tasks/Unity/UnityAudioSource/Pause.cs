[TaskCategoryAttribute] // RVA: 0x1554A0 Offset: 0x1555A1 VA: 0x1554A0
[TaskDescriptionAttribute] // RVA: 0x1554A0 Offset: 0x1555A1 VA: 0x1554A0
public class Pause : Action // TypeDefIndex: 11361
{
	// Fields
	[TooltipAttribute] // RVA: 0x1921A0 Offset: 0x1922A1 VA: 0x1921A0
	public SharedGameObject targetGameObject; // 0x50
	private AudioSource audioSource; // 0x58
	private GameObject prevGameObject; // 0x60

	// Methods

	// RVA: 0x27979F0 Offset: 0x2797AF1 VA: 0x27979F0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2797AF0 Offset: 0x2797BF1 VA: 0x2797AF0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2797BD0 Offset: 0x2797CD1 VA: 0x2797BD0 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2797BE0 Offset: 0x2797CE1 VA: 0x2797BE0
	public void .ctor() { }
}

