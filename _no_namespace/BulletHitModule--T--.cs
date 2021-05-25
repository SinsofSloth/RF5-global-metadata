public abstract class BulletHitModule<T> : BulletSubModule // TypeDefIndex: 6452
{
	// Fields
	private const float effectMinInterval = 0.1;
	[SerializeField] // RVA: 0x15C980 Offset: 0x15CA81 VA: 0x15C980
	public int maxHitCount; // 0x0
	[SerializeField] // RVA: 0x15C990 Offset: 0x15CA91 VA: 0x15C990
	public float Interval; // 0x0
	[SerializeField] // RVA: 0x15C9A0 Offset: 0x15CAA1 VA: 0x15C9A0
	public EffectID effectID; // 0x0
	[SerializeField] // RVA: 0x15C9B0 Offset: 0x15CAB1 VA: 0x15C9B0
	public SoundID soundID; // 0x0
	protected Dictionary<T, int> m_HitList; // 0x0
	private Dictionary<T, int> m_HitCounter; // 0x0
	private Dictionary<T, BulletHitModule.Timer<T>> m_DisableTimer; // 0x0
	private List<T> m_RemoveList; // 0x0
	private Dictionary<T, BulletHitModule.Timer<T>> m_EffectTimer; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnUpdate(BulletBase bullet) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2570A10 Offset: 0x2570B11 VA: 0x2570A10
	|-BulletHitModule<CharacterBase>.OnUpdate
	|-BulletHitModule<object>.OnUpdate
	|-BulletHitModule<Collider>.OnUpdate
	*/

	// RVA: -1 Offset: -1
	private void UpdateDisableTimer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2570A60 Offset: 0x2570B61 VA: 0x2570A60
	|-BulletHitModule<object>.UpdateDisableTimer
	*/

	// RVA: -1 Offset: -1
	private void UpdateEffectIntervalTimer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2570F30 Offset: 0x2571031 VA: 0x2570F30
	|-BulletHitModule<object>.UpdateEffectIntervalTimer
	*/

	// RVA: -1 Offset: -1
	protected bool CheckHitDisable(T hit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2571410 Offset: 0x2571511 VA: 0x2571410
	|-BulletHitModule<CharacterBase>.CheckHitDisable
	|-BulletHitModule<object>.CheckHitDisable
	|-BulletHitModule<Collider>.CheckHitDisable
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool OnHit(BulletBase bullet, T hit, Vector3 point, Vector3 normal) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25714E0 Offset: 0x25715E1 VA: 0x25714E0
	|-BulletHitModule<CharacterBase>.OnHit
	|-BulletHitModule<object>.OnHit
	|-BulletHitModule<Collider>.OnHit
	*/

	// RVA: -1 Offset: -1
	private void PlayHitEffect(BulletBase bullet, T hit, Vector3 point, Vector3 normal) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25716D0 Offset: 0x25717D1 VA: 0x25716D0
	|-BulletHitModule<object>.PlayHitEffect
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25719A0 Offset: 0x2571AA1 VA: 0x25719A0
	|-BulletHitModule<CharacterBase>..ctor
	|-BulletHitModule<object>..ctor
	|-BulletHitModule<Collider>..ctor
	*/
}

