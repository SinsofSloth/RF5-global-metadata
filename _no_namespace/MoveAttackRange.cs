[TaskCategoryAttribute] // RVA: 0x145390 Offset: 0x145491 VA: 0x145390
public class MoveAttackRange : Action // TypeDefIndex: 6358
{
	// Fields
	public SharedGameObject Target; // 0x50
	public SharedFloat MinAttackRange; // 0x58
	public SharedFloat MaxAttackRange; // 0x60
	public SharedFloat SphereCastHeight; // 0x68
	public SharedFloat SphereCastInterval; // 0x70
	public SharedBool OnlyUseMaxRange; // 0x78
	public SharedMovementBehaviorType ReturnReadyToAttackBehaviorType; // 0x80
	public SharedFloat ReturnMoveSpeedScale; // 0x88
	public SharedFloat ReturnLeaveRange; // 0x90
	public SharedFloat ReturnCloseRange; // 0x98
	private AIInput AIInput; // 0xA0
	public static readonly string OnlyUseMaxRangeKryName; // 0x0
	private float SphereCastTimer; // 0xA8
	private float SphereCastRadius; // 0xAC
	private float SphereCastMaxDistance; // 0xB0
	private RaycastHit[] SphereCastHit; // 0xB8

	// Methods

	// RVA: 0x1CD95A0 Offset: 0x1CD96A1 VA: 0x1CD95A0 Slot: 4
	public override void OnAwake() { }

	// RVA: 0x1CD9670 Offset: 0x1CD9771 VA: 0x1CD9670 Slot: 5
	public override void OnStart() { }

	// RVA: 0x1CD9710 Offset: 0x1CD9811 VA: 0x1CD9710 Slot: 6
	public override TaskStatus OnUpdate() { }

	// RVA: 0x1CD9AF0 Offset: 0x1CD9BF1 VA: 0x1CD9AF0
	private bool IsHitTargetSphereCast() { }

	// RVA: 0x1CD9E80 Offset: 0x1CD9F81 VA: 0x1CD9E80 Slot: 17
	public override void OnDrawGizmos() { }

	// RVA: 0x1CD9E90 Offset: 0x1CD9F91 VA: 0x1CD9E90
	public void .ctor() { }

	// RVA: 0x1CD9F00 Offset: 0x1CDA001 VA: 0x1CD9F00
	private static void .cctor() { }
}

