[TaskCategoryAttribute] // RVA: 0x14FC30 Offset: 0x14FD31 VA: 0x14FC30
[TaskDescriptionAttribute] // RVA: 0x14FC30 Offset: 0x14FD31 VA: 0x14FC30
public class AddExplosionForce : Action // TypeDefIndex: 11121
{
	// Fields
	[TooltipAttribute] // RVA: 0x189A50 Offset: 0x189B51 VA: 0x189A50
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189A90 Offset: 0x189B91 VA: 0x189A90
	public SharedFloat explosionForce; // 0x58
	[TooltipAttribute] // RVA: 0x189AD0 Offset: 0x189BD1 VA: 0x189AD0
	public SharedVector3 explosionPosition; // 0x60
	[TooltipAttribute] // RVA: 0x189B10 Offset: 0x189C11 VA: 0x189B10
	public SharedFloat explosionRadius; // 0x68
	[TooltipAttribute] // RVA: 0x189B50 Offset: 0x189C51 VA: 0x189B50
	public float upwardsModifier; // 0x70
	[TooltipAttribute] // RVA: 0x189B90 Offset: 0x189C91 VA: 0x189B90
	public ForceMode forceMode; // 0x74
	private Rigidbody rigidbody; // 0x78
	private GameObject prevGameObject; // 0x80

	// Methods

	// RVA: 0x2881120 Offset: 0x2881221 VA: 0x2881120 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2881220 Offset: 0x2881321 VA: 0x2881220 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2881380 Offset: 0x2881481 VA: 0x2881380 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2881450 Offset: 0x2881551 VA: 0x2881450
	public void .ctor() { }
}

