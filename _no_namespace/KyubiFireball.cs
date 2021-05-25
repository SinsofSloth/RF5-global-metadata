public class KyubiFireball : ProjectileBulletBase // TypeDefIndex: 8958
{
	// Fields
	public Collider Target; // 0x110
	private float MaxCurve; // 0x118
	private float ReadyAttackTime; // 0x11C
	private bool IsReadyAttack; // 0x120
	private Vector3 ReadyAttackPosition; // 0x124
	private Vector3 StartPosition; // 0x130
	private float T; // 0x13C

	// Methods

	// RVA: 0x21795C0 Offset: 0x21796C1 VA: 0x21795C0
	public void StartReadyAttack(Vector3 readyAttackPosition) { }

	// RVA: 0x217B550 Offset: 0x217B651 VA: 0x217B550
	private void UpdateMoveTarget() { }

	// RVA: 0x217B970 Offset: 0x217BA71 VA: 0x217B970
	private void UpdateReadyAttackMove() { }

	// RVA: 0x217BA80 Offset: 0x217BB81 VA: 0x217BA80 Slot: 6
	protected override void UpdateBehavior() { }

	// RVA: 0x217BB40 Offset: 0x217BC41 VA: 0x217BB40
	public void .ctor() { }
}

