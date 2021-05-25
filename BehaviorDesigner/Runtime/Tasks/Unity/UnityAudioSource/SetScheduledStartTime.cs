[TaskCategoryAttribute] // RVA: 0x155AA0 Offset: 0x155BA1 VA: 0x155AA0
[TaskDescriptionAttribute] // RVA: 0x155AA0 Offset: 0x155BA1 VA: 0x155AA0
public class SetScheduledStartTime : Action // TypeDefIndex: 11377
{
	// Fields
	[TooltipAttribute] // RVA: 0x192960 Offset: 0x192A61 VA: 0x192960
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x1929A0 Offset: 0x192AA1 VA: 0x1929A0
	public SharedFloat time; // 0x58
	private AudioSource audioSource; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2799F80 Offset: 0x279A081 VA: 0x2799F80 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279A080 Offset: 0x279A181 VA: 0x279A080 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279A180 Offset: 0x279A281 VA: 0x279A180 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279A1D0 Offset: 0x279A2D1 VA: 0x279A1D0
	public void .ctor() { }
}

