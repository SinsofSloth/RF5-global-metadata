public abstract class InteractionColliderBase : MonoBehaviour // TypeDefIndex: 6689
{
	// Fields
	protected const int ResultMaxCount = 512;
	[SerializeField] // RVA: 0x15EDC0 Offset: 0x15EEC1 VA: 0x15EDC0
	protected LayerMask m_LayerMask; // 0x18
	[SerializeField] // RVA: 0x15EDD0 Offset: 0x15EED1 VA: 0x15EDD0
	protected float m_Radius; // 0x1C
	[SerializeField] // RVA: 0x15EDE0 Offset: 0x15EEE1 VA: 0x15EDE0
	protected Vector3 m_Center; // 0x20
	protected static Collider[] m_Results; // 0x0
	protected static HashSet<Collider> m_DeleteHash; // 0x8
	protected HashSet<Collider> m_EntryHash; // 0x30

	// Properties
	public Vector3 Center { get; }

	// Methods

	// RVA: 0x20CD6A0 Offset: 0x20CD7A1 VA: 0x20CD6A0
	public Vector3 get_Center() { }

	// RVA: 0x20CD770 Offset: 0x20CD871 VA: 0x20CD770
	protected bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x20CEB10 Offset: 0x20CEC11 VA: 0x20CEB10
	protected void .ctor() { }

	// RVA: 0x20CEE60 Offset: 0x20CEF61 VA: 0x20CEE60
	private static void .cctor() { }
}

