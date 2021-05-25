[ExecuteInEditMode] // RVA: 0x146740 Offset: 0x146841 VA: 0x146740
public class EquipCollision : MonoBehaviour // TypeDefIndex: 7648
{
	// Fields
	[SerializeField] // RVA: 0x168790 Offset: 0x168891 VA: 0x168790
	private BoxCollider m_BoxCollider; // 0x18
	[SerializeField] // RVA: 0x1687A0 Offset: 0x1688A1 VA: 0x1687A0
	private XWeaponTrail m_XWeaponTrail; // 0x20
	private EquipCollisionHitEvent m_OnHitEvent; // 0x28

	// Properties
	public EquipCollisionHitEvent OnHitEvent { get; }

	// Methods

	// RVA: 0x2021400 Offset: 0x2021501 VA: 0x2021400
	public EquipCollisionHitEvent get_OnHitEvent() { }

	// RVA: 0x2021410 Offset: 0x2021511 VA: 0x2021410
	private void Start() { }

	// RVA: 0x20214B0 Offset: 0x20215B1 VA: 0x20214B0
	public void Setup(Vector3 center, Vector3 size) { }

	// RVA: 0x20216B0 Offset: 0x20217B1 VA: 0x20216B0
	public void Activate() { }

	// RVA: 0x20216D0 Offset: 0x20217D1 VA: 0x20216D0
	public void Deactivate() { }

	// RVA: 0x2021950 Offset: 0x2021A51 VA: 0x2021950
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x20219C0 Offset: 0x2021AC1 VA: 0x20219C0
	public void .ctor() { }
}

