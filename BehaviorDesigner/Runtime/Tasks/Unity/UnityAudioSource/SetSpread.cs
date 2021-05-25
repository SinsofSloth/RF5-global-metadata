[TaskCategoryAttribute] // RVA: 0x155B00 Offset: 0x155C01 VA: 0x155B00
[TaskDescriptionAttribute] // RVA: 0x155B00 Offset: 0x155C01 VA: 0x155B00
public class SetSpread : Action // TypeDefIndex: 11378
{
	// Fields
	[TooltipAttribute] // RVA: 0x1929E0 Offset: 0x192AE1 VA: 0x1929E0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192A20 Offset: 0x192B21 VA: 0x192A20
	public SharedFloat spread; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279A210 Offset: 0x279A311 VA: 0x279A210 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279A310 Offset: 0x279A411 VA: 0x279A310 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279A400 Offset: 0x279A501 VA: 0x279A400 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279A450 Offset: 0x279A551 VA: 0x279A450
	public void .ctor() { }
}

