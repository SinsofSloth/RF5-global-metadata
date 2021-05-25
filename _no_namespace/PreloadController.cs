public class PreloadController : MonoBehaviour // TypeDefIndex: 7691
{
	// Fields
	[SerializeField] // RVA: 0x168A10 Offset: 0x168B11 VA: 0x168A10
	protected string Key; // 0x18
	[SerializeField] // RVA: 0x168A20 Offset: 0x168B21 VA: 0x168A20
	protected List<Collider> LoadCollider; // 0x20
	[SerializeField] // RVA: 0x168A30 Offset: 0x168B31 VA: 0x168A30
	protected Collider RemoveCollider; // 0x28
	private PreloadSceneHandle Scene; // 0x30

	// Methods

	// RVA: 0x2774E10 Offset: 0x2774F11 VA: 0x2774E10 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x27750B0 Offset: 0x27751B1 VA: 0x27750B0 Slot: 5
	protected virtual void OnDestroy() { }

	// RVA: 0x27750C0 Offset: 0x27751C1 VA: 0x27750C0 Slot: 6
	protected virtual void OnComplete(PreloadSceneHandle handle) { }

	// RVA: 0x2775160 Offset: 0x2775261 VA: 0x2775160 Slot: 7
	protected virtual void OnPreloadEnter(Collider mine, Collider other) { }

	// RVA: 0x2775570 Offset: 0x2775671 VA: 0x2775570 Slot: 8
	protected virtual void OnPreloadExit(Collider mine, Collider other) { }

	// RVA: 0x2775860 Offset: 0x2775961 VA: 0x2775860
	public void .ctor() { }
}

