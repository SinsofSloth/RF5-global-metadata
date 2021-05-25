[TaskCategoryAttribute] // RVA: 0x154AE0 Offset: 0x154BE1 VA: 0x154AE0
[TaskDescriptionAttribute] // RVA: 0x154AE0 Offset: 0x154BE1 VA: 0x154AE0
public class SetCenter : Action // TypeDefIndex: 11335
{
	// Fields
	[TooltipAttribute] // RVA: 0x191420 Offset: 0x191521 VA: 0x191420
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x191460 Offset: 0x191561 VA: 0x191460
	public SharedVector3 center; // 0x58
	private CapsuleCollider capsuleCollider; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x279CA10 Offset: 0x279CB11 VA: 0x279CA10 Slot: 5
	public override void OnStart() { }

	// RVA: 0x279CB10 Offset: 0x279CC11 VA: 0x279CB10 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x279CC00 Offset: 0x279CD01 VA: 0x279CC00 Slot: 16
	public override void OnReset() { }

	// RVA: 0x279CC90 Offset: 0x279CD91 VA: 0x279CC90
	public void .ctor() { }
}

