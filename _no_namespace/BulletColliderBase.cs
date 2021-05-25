public class BulletColliderBase : MonoBehaviour // TypeDefIndex: 6446
{
	// Fields
	[SerializeField] // RVA: 0x15C920 Offset: 0x15CA21 VA: 0x15C920
	protected BulletBase m_bullet; // 0x18
	[SerializeField] // RVA: 0x15C930 Offset: 0x15CA31 VA: 0x15C930
	protected Collider m_collider; // 0x20
	[HideInInspector] // RVA: 0x15C940 Offset: 0x15CA41 VA: 0x15C940
	protected LayerMask m_hitLayerMask; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15C950 Offset: 0x15CA51 VA: 0x15C950
	private Vector3 <CurrentPosition>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x15C960 Offset: 0x15CA61 VA: 0x15C960
	private Vector3 <PrevPosition>k__BackingField; // 0x38
	private bool ColliderEnable; // 0x44

	// Properties
	public BulletBase Bullet { get; }
	public Vector3 CurrentPosition { get; set; }
	public Vector3 PrevPosition { get; set; }

	// Methods

	// RVA: 0x2065640 Offset: 0x2065741 VA: 0x2065640
	public BulletBase get_Bullet() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B260 Offset: 0x19B361 VA: 0x19B260
	// RVA: 0x2065650 Offset: 0x2065751 VA: 0x2065650
	public Vector3 get_CurrentPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B270 Offset: 0x19B371 VA: 0x19B270
	// RVA: 0x2065660 Offset: 0x2065761 VA: 0x2065660
	protected void set_CurrentPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B280 Offset: 0x19B381 VA: 0x19B280
	// RVA: 0x2065670 Offset: 0x2065771 VA: 0x2065670
	public Vector3 get_PrevPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B290 Offset: 0x19B391 VA: 0x19B290
	// RVA: 0x2065680 Offset: 0x2065781 VA: 0x2065680
	protected void set_PrevPosition(Vector3 value) { }

	// RVA: 0x2065690 Offset: 0x2065791 VA: 0x2065690 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x20657C0 Offset: 0x20658C1 VA: 0x20657C0 Slot: 5
	public virtual void OnSetup(BulletBase bullet) { }

	// RVA: 0x2065980 Offset: 0x2065A81 VA: 0x2065980 Slot: 6
	public virtual void OnFixedUpdate(BulletBase bullet) { }

	// RVA: 0x20659D0 Offset: 0x2065AD1 VA: 0x20659D0 Slot: 7
	protected virtual void OnHit(Collider other) { }

	// RVA: 0x2065E60 Offset: 0x2065F61 VA: 0x2065E60 Slot: 8
	protected virtual void OnTriggerEnter(Collider other) { }

	// RVA: 0x2065E70 Offset: 0x2065F71 VA: 0x2065E70 Slot: 9
	protected virtual void OnTriggerStay(Collider other) { }

	// RVA: 0x2065E80 Offset: 0x2065F81 VA: 0x2065E80
	public void .ctor() { }
}

