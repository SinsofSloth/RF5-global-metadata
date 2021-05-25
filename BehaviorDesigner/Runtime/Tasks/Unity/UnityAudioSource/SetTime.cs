[TaskCategoryAttribute] // RVA: 0x155B60 Offset: 0x155C61 VA: 0x155B60
[TaskDescriptionAttribute] // RVA: 0x155B60 Offset: 0x155C61 VA: 0x155B60
public class SetTime : Action // TypeDefIndex: 11379
{
	// Fields
	[TooltipAttribute] // RVA: 0x192A60 Offset: 0x192B61 VA: 0x192A60
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x192AA0 Offset: 0x192BA1 VA: 0x192AA0
	public SharedFloat time; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279A460 Offset: 0x279A561 VA: 0x279A460 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279A560 Offset: 0x279A661 VA: 0x279A560 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279A650 Offset: 0x279A751 VA: 0x279A650 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279A6A0 Offset: 0x279A7A1 VA: 0x279A6A0
	public void .ctor() { }
}

