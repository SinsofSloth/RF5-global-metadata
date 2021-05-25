[TaskCategoryAttribute] // RVA: 0x14FB10 Offset: 0x14FC11 VA: 0x14FB10
[TaskDescriptionAttribute] // RVA: 0x14FB10 Offset: 0x14FC11 VA: 0x14FB10
public class SetVelocity : Action // TypeDefIndex: 11118
{
	// Fields
	[TooltipAttribute] // RVA: 0x189950 Offset: 0x189A51 VA: 0x189950
	public SharedGameObject targetGameObject; // 0x50
	[TooltipAttribute] // RVA: 0x189990 Offset: 0x189A91 VA: 0x189990
	public SharedVector2 velocity; // 0x58
	private Rigidbody2D rigidbody2D; // 0x60
	private GameObject prevGameObject; // 0x68

	// Methods

	// RVA: 0x2889CA0 Offset: 0x2889DA1 VA: 0x2889CA0 Slot: 5
	public override void OnStart() { }

	// RVA: 0x2889DA0 Offset: 0x2889EA1 VA: 0x2889DA0 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x2889E90 Offset: 0x2889F91 VA: 0x2889E90 Slot: 16
	public override void OnReset() { }

	// RVA: 0x2889F20 Offset: 0x288A021 VA: 0x2889F20
	public void .ctor() { }
}

