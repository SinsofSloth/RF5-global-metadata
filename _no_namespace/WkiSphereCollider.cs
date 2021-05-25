public class WkiSphereCollider : MonoBehaviour // TypeDefIndex: 7537
{
	// Fields
	[SerializeField] // RVA: 0x166F40 Offset: 0x167041 VA: 0x166F40
	public float m_Radius; // 0x18
	[SerializeField] // RVA: 0x166F50 Offset: 0x167051 VA: 0x166F50
	public Vector3 m_Center; // 0x1C
	[SerializeField] // RVA: 0x166F60 Offset: 0x167061 VA: 0x166F60
	public WkiHitEvent m_HitEvent; // 0x28
	protected LayerMask m_HitLayerMask; // 0x30
	protected Vector3 m_BackupPosition; // 0x34

	// Methods

	// RVA: 0x1D07E00 Offset: 0x1D07F01 VA: 0x1D07E00
	protected void Start() { }

	// RVA: 0x1D07EB0 Offset: 0x1D07FB1 VA: 0x1D07EB0
	protected void OnEnable() { }

	// RVA: 0x1D07EF0 Offset: 0x1D07FF1 VA: 0x1D07EF0
	public void OnFixeUpdate() { }

	// RVA: 0x1D081E0 Offset: 0x1D082E1 VA: 0x1D081E0
	protected void ResetBackupPosition(Vector3 position) { }

	// RVA: 0x1D07F50 Offset: 0x1D08051 VA: 0x1D07F50
	protected void CheckHit() { }

	// RVA: 0x1D081F0 Offset: 0x1D082F1 VA: 0x1D081F0
	public void SetRadius(float radius) { }

	// RVA: 0x1D08200 Offset: 0x1D08301 VA: 0x1D08200
	public void .ctor() { }
}

