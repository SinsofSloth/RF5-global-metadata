[Serializable]
public class HitData : MonoBehaviour // TypeDefIndex: 7615
{
	// Fields
	[SerializeField] // RVA: 0x168520 Offset: 0x168621 VA: 0x168520
	public Collider HitCollider; // 0x18
	[SerializeField] // RVA: 0x168530 Offset: 0x168631 VA: 0x168530
	public HitEvent OnHitTriggerEnter; // 0x20
	private bool IsCanStop; // 0x28
	private Vector3 ColliderCenter; // 0x2C

	// Methods

	// RVA: 0x23045F0 Offset: 0x23046F1 VA: 0x23045F0
	private void Awake() { }

	// RVA: 0x23047A0 Offset: 0x23048A1 VA: 0x23047A0
	private void Reset() { }

	[ContextMenu] // RVA: 0x1A2170 Offset: 0x1A2271 VA: 0x1A2170
	// RVA: 0x2304600 Offset: 0x2304701 VA: 0x2304600
	public void ResetUnit() { }

	// RVA: 0x23047B0 Offset: 0x23048B1 VA: 0x23047B0
	public void DoPlay(float scale) { }

	// RVA: 0x23048A0 Offset: 0x23049A1 VA: 0x23048A0
	public bool DoStop() { }

	// RVA: 0x23048F0 Offset: 0x23049F1 VA: 0x23048F0
	private void FixedUpdate() { }

	// RVA: 0x2304900 Offset: 0x2304A01 VA: 0x2304900
	private void OnTriggerEnter(Collider collider) { }

	// RVA: 0x2304970 Offset: 0x2304A71 VA: 0x2304970
	public void .ctor() { }
}

