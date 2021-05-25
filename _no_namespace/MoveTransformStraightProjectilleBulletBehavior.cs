public class MoveTransformStraightProjectilleBulletBehavior : ProjectileBulletBehaviorBase // TypeDefIndex: 8394
{
	// Fields
	private Vector3 MovePosition; // 0x18
	private float Duration; // 0x24
	private float EndSpeed; // 0x28
	private float WaitTime; // 0x2C
	private MoveTransformStraightProjectilleBulletBehavior.State IsWait; // 0x30
	private Transform TargetCharacterTransform; // 0x38

	// Methods

	// RVA: 0x1CDB5E0 Offset: 0x1CDB6E1 VA: 0x1CDB5E0
	public void .ctor(Transform moveTransform, Transform targetCharacterTransform, float duration, float endSpeed, float waitTime) { }

	// RVA: 0x1CDB700 Offset: 0x1CDB801 VA: 0x1CDB700 Slot: 6
	public override void Setup(ProjectileBulletBase projectileBulletBase) { }

	// RVA: 0x1CDB820 Offset: 0x1CDB921 VA: 0x1CDB820 Slot: 8
	public override void BeginUpdate() { }
}

