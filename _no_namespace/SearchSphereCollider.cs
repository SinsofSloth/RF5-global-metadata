public class SearchSphereCollider : MonoBehaviour // TypeDefIndex: 6786
{
	// Fields
	protected LayerMask m_HitLayerMask; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15F830 Offset: 0x15F931 VA: 0x15F830
	private SearchSphereHitEvent <m_HitEvent>k__BackingField; // 0x20
	protected Vector3 m_BackupPosition; // 0x28
	[SerializeField] // RVA: 0x15F840 Offset: 0x15F941 VA: 0x15F840
	public float m_Radius; // 0x34
	[SerializeField] // RVA: 0x15F850 Offset: 0x15F951 VA: 0x15F850
	public Vector3 m_Center; // 0x38

	// Properties
	public SearchSphereHitEvent m_HitEvent { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19CF60 Offset: 0x19D061 VA: 0x19CF60
	// RVA: 0x1C82410 Offset: 0x1C82511 VA: 0x1C82410
	public SearchSphereHitEvent get_m_HitEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CF70 Offset: 0x19D071 VA: 0x19CF70
	// RVA: 0x1C82420 Offset: 0x1C82521 VA: 0x1C82420
	public void set_m_HitEvent(SearchSphereHitEvent value) { }

	// RVA: 0x1C82430 Offset: 0x1C82531 VA: 0x1C82430
	protected void Start() { }

	// RVA: 0x1C824D0 Offset: 0x1C825D1 VA: 0x1C824D0
	protected void FixedUpdate() { }

	// RVA: 0x1C827C0 Offset: 0x1C828C1 VA: 0x1C827C0
	protected void ResetBackupPosition(Vector3 position) { }

	// RVA: 0x1C82530 Offset: 0x1C82631 VA: 0x1C82530
	protected void CheckHit() { }

	// RVA: 0x1C827D0 Offset: 0x1C828D1 VA: 0x1C827D0
	public void SetRadius(float radius) { }

	// RVA: 0x1C827E0 Offset: 0x1C828E1 VA: 0x1C827E0
	public void .ctor() { }
}

