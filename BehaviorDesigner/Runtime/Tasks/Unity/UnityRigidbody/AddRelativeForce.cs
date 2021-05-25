[TaskCategoryAttribute] // RVA: 0x14FDA0 Offset: 0x14FEA1 VA: 0x14FDA0
[TaskDescriptionAttribute] // RVA: 0x14FDA0 Offset: 0x14FEA1 VA: 0x14FDA0
public class AddRelativeForce : Action // TypeDefIndex: 11124
{
	// Fields
	[TooltipAttribute] // RVA: 0x189D90 Offset: 0x189E91 VA: 0x189D90
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189DD0 Offset: 0x189ED1 VA: 0x189DD0
	public SharedVector3 force; // 0x58
	[TooltipAttribute] // RVA: 0x189E10 Offset: 0x189F11 VA: 0x189E10
	public ForceMode forceMode; // 0x60
	private Rigidbody rigidbody; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x2881A20 Offset: 0x2881B21 VA: 0x2881A20 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2881B20 Offset: 0x2881C21 VA: 0x2881B20 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2881C20 Offset: 0x2881D21 VA: 0x2881C20 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2881CC0 Offset: 0x2881DC1 VA: 0x2881CC0
	public void .ctor() { }
}

