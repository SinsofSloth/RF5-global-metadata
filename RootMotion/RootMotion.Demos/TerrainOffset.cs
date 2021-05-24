public class TerrainOffset : MonoBehaviour // TypeDefIndex: 9334
{
	// Fields
	public AimIK aimIK; // 0x18
	public Vector3 raycastOffset; // 0x20
	public LayerMask raycastLayers; // 0x2C
	public float min; // 0x30
	public float max; // 0x34
	public float lerpSpeed; // 0x38
	private RaycastHit hit; // 0x3C
	private Vector3 offset; // 0x68

	// Methods

	// RVA: 0x272B210 Offset: 0x272B311 VA: 0x272B210
	private void LateUpdate() { }

	// RVA: 0x272B480 Offset: 0x272B581 VA: 0x272B480
	private Vector3 GetGroundHeightOffset(Vector3 worldPosition) { }

	// RVA: 0x272B6D0 Offset: 0x272B7D1 VA: 0x272B6D0
	public void .ctor() { }
}

