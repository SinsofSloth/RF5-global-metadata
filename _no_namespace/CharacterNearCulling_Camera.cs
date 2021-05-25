public class CharacterNearCulling_Camera : SingletonMonoBehaviour<CharacterNearCulling_Camera> // TypeDefIndex: 6769
{
	// Fields
	[SerializeField] // RVA: 0x15F5B0 Offset: 0x15F6B1 VA: 0x15F5B0
	private float m_Radius; // 0x18
	[SerializeField] // RVA: 0x15F5C0 Offset: 0x15F6C1 VA: 0x15F5C0
	private LayerMask m_LayerMask; // 0x1C
	private Dictionary<Collider, CharacterNearCullingController> StayControllers; // 0x20
	private List<Collider> OnExitList; // 0x28

	// Methods

	// RVA: 0x1E55A70 Offset: 0x1E55B71 VA: 0x1E55A70
	private void Start() { }

	// RVA: 0x1E55AE0 Offset: 0x1E55BE1 VA: 0x1E55AE0
	private void OnDisable() { }

	// RVA: 0x1E55C60 Offset: 0x1E55D61 VA: 0x1E55C60
	private void FixedUpdate() { }

	// RVA: 0x1E56300 Offset: 0x1E56401 VA: 0x1E56300
	public void .ctor() { }
}

