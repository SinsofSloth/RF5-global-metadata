[RequiredComponentAttribute] // RVA: 0x14FC90 Offset: 0x14FD91 VA: 0x14FC90
[TaskCategoryAttribute] // RVA: 0x14FC90 Offset: 0x14FD91 VA: 0x14FC90
[TaskDescriptionAttribute] // RVA: 0x14FC90 Offset: 0x14FD91 VA: 0x14FC90
public class AddForce : Action // TypeDefIndex: 11122
{
	// Fields
	[TooltipAttribute] // RVA: 0x189BD0 Offset: 0x189CD1 VA: 0x189BD0
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189C10 Offset: 0x189D11 VA: 0x189C10
	public SharedVector3 force; // 0x58
	[TooltipAttribute] // RVA: 0x189C50 Offset: 0x189D51 VA: 0x189C50
	public ForceMode forceMode; // 0x60
	private Rigidbody rigidbody; // 0x68
	private GameObject prevGameObject; // 0x70

	// Methods

	// RVA: 0x2881460 Offset: 0x2881561 VA: 0x2881460 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2881560 Offset: 0x2881661 VA: 0x2881560 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2881660 Offset: 0x2881761 VA: 0x2881660 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2881700 Offset: 0x2881801 VA: 0x2881700
	public void .ctor() { }
}

