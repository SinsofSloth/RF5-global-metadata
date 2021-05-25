[Serializable]
public class BulletHitObstacle : BulletHitModule<Collider> // TypeDefIndex: 6456
{
	// Fields
	[SerializeField] // RVA: 0x15C9F0 Offset: 0x15CAF1 VA: 0x15C9F0
	public BulletHitObstacleEvent hitEventType; // 0x58

	// Methods

	// RVA: 0x2068A50 Offset: 0x2068B51 VA: 0x2068A50 Slot: 7
	public override void OnSetup(BulletBase bullet) { }

	// RVA: 0x2068AC0 Offset: 0x2068BC1 VA: 0x2068AC0 Slot: 13
	public override bool OnHit(BulletBase bullet, Collider obstacle, Vector3 point, Vector3 normal) { }

	// RVA: 0x2068D60 Offset: 0x2068E61 VA: 0x2068D60
	public void .ctor() { }
}

