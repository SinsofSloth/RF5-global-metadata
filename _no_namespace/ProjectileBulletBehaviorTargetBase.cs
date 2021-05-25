public class ProjectileBulletBehaviorTargetBase : ProjectileBulletBehaviorBase // TypeDefIndex: 8388
{
	// Fields
	protected Collider TargetCollider; // 0x18
	protected Vector3 TargetPosition; // 0x20
	private bool IsSetTargetPostion; // 0x2C

	// Methods

	// RVA: 0x1DEC620 Offset: 0x1DEC721 VA: 0x1DEC620
	public void .ctor(Collider targetCollider) { }

	// RVA: 0x1DEC660 Offset: 0x1DEC761 VA: 0x1DEC660 Slot: 12
	protected virtual void UpdateTargetPosition() { }

	// RVA: 0x1DEC740 Offset: 0x1DEC841 VA: 0x1DEC740 Slot: 13
	public virtual void SetTargetPosition(Vector3 position) { }

	// RVA: 0x1DEC760 Offset: 0x1DEC861 VA: 0x1DEC760 Slot: 14
	public virtual void ResetTargetPosition() { }

	// RVA: 0x1DEC770 Offset: 0x1DEC871 VA: 0x1DEC770
	protected Vector3 GetTargetDirection() { }
}

