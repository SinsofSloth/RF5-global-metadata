[Serializable]
public class BulletMainModule : IBulletModule // TypeDefIndex: 6472
{
	// Fields
	[SerializeField] // RVA: 0x15CC20 Offset: 0x15CD21 VA: 0x15CC20
	public int maxHitCount; // 0x10
	[SerializeField] // RVA: 0x15CC30 Offset: 0x15CD31 VA: 0x15CC30
	public BulletHitChara hitChara; // 0x18
	[SerializeField] // RVA: 0x15CC40 Offset: 0x15CD41 VA: 0x15CC40
	public BulletHitObstacle hitObstacle; // 0x20
	[SerializeField] // RVA: 0x15CC50 Offset: 0x15CD51 VA: 0x15CC50
	public BulletLaserNew laser; // 0x28
	[SerializeField] // RVA: 0x15CC60 Offset: 0x15CD61 VA: 0x15CC60
	public List<BulletSubModule> modules; // 0x30
	private int m_hitCount; // 0x38

	// Methods

	// RVA: 0x2062640 Offset: 0x2062741 VA: 0x2062640 Slot: 4
	public void OnSetup(BulletBase bullet) { }

	// RVA: 0x2062B10 Offset: 0x2062C11 VA: 0x2062B10 Slot: 5
	public void OnUpdate(BulletBase bullet) { }

	// RVA: 0x2062EF0 Offset: 0x2062FF1 VA: 0x2062EF0 Slot: 6
	public void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x2063270 Offset: 0x2063371 VA: 0x2063270
	public void OnHit(BulletBase bullet, Collider collider, Vector3 point, Vector3 normal) { }

	// RVA: 0x2063860 Offset: 0x2063961 VA: 0x2063860
	public void OnDead(BulletBase bullet) { }

	// RVA: 0x2063C90 Offset: 0x2063D91 VA: 0x2063C90
	public void DoExtension(BulletBase bullet) { }

	// RVA: 0x20640D0 Offset: 0x20641D1 VA: 0x20640D0
	public void .ctor() { }
}

