[AddComponentMenu] // RVA: 0x11AC20 Offset: 0x11AD21 VA: 0x11AC20
[RequireComponent] // RVA: 0x11AC20 Offset: 0x11AD21 VA: 0x11AC20
public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 4092
{
	// Fields
	protected const int kNoEventMaskSet = -1;
	protected Camera m_EventCamera; // 0x20
	[SerializeField] // RVA: 0x11CD40 Offset: 0x11CE41 VA: 0x11CD40
	protected LayerMask m_EventMask; // 0x28
	[SerializeField] // RVA: 0x11CD50 Offset: 0x11CE51 VA: 0x11CD50
	protected int m_MaxRayIntersections; // 0x2C
	protected int m_LastMaxRayIntersections; // 0x30
	private RaycastHit[] m_Hits; // 0x38

	// Properties
	public override Camera eventCamera { get; }
	public virtual int depth { get; }
	public int finalEventMask { get; }
	public LayerMask eventMask { get; set; }
	public int maxRayIntersections { get; set; }

	// Methods

	// RVA: 0x163CC90 Offset: 0x163CD91 VA: 0x163CC90
	protected void .ctor() { }

	// RVA: 0x163D6B0 Offset: 0x163D7B1 VA: 0x163D6B0 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x163D770 Offset: 0x163D871 VA: 0x163D770 Slot: 22
	public virtual int get_depth() { }

	// RVA: 0x163D5D0 Offset: 0x163D6D1 VA: 0x163D5D0
	public int get_finalEventMask() { }

	// RVA: 0x163D840 Offset: 0x163D941 VA: 0x163D840
	public LayerMask get_eventMask() { }

	// RVA: 0x163D850 Offset: 0x163D951 VA: 0x163D850
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x163D860 Offset: 0x163D961 VA: 0x163D860
	public int get_maxRayIntersections() { }

	// RVA: 0x163D870 Offset: 0x163D971 VA: 0x163D870
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x163D270 Offset: 0x163D371 VA: 0x163D270
	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane) { }

	// RVA: 0x163D880 Offset: 0x163D981 VA: 0x163D880 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }
}

