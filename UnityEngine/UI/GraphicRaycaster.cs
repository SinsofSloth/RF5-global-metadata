[AddComponentMenu] // RVA: 0x119D60 Offset: 0x119E61 VA: 0x119D60
[RequireComponent] // RVA: 0x119D60 Offset: 0x119E61 VA: 0x119D60
public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 3929
{
	// Fields
	protected const int kNoEventMaskSet = -1;
	[FormerlySerializedAsAttribute] // RVA: 0x11B5B0 Offset: 0x11B6B1 VA: 0x11B5B0
	[SerializeField] // RVA: 0x11B5B0 Offset: 0x11B6B1 VA: 0x11B5B0
	private bool m_IgnoreReversedGraphics; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0x11B600 Offset: 0x11B701 VA: 0x11B600
	[SerializeField] // RVA: 0x11B600 Offset: 0x11B701 VA: 0x11B600
	private GraphicRaycaster.BlockingObjects m_BlockingObjects; // 0x24
	[SerializeField] // RVA: 0x11B650 Offset: 0x11B751 VA: 0x11B650
	protected LayerMask m_BlockingMask; // 0x28
	private Canvas m_Canvas; // 0x30
	private List<Graphic> m_RaycastResults; // 0x38
	private static readonly List<Graphic> s_SortedGraphics; // 0x0

	// Properties
	public override int sortOrderPriority { get; }
	public override int renderOrderPriority { get; }
	public bool ignoreReversedGraphics { get; set; }
	public GraphicRaycaster.BlockingObjects blockingObjects { get; set; }
	private Canvas canvas { get; }
	public override Camera eventCamera { get; }

	// Methods

	// RVA: 0x1868830 Offset: 0x1868931 VA: 0x1868830 Slot: 20
	public override int get_sortOrderPriority() { }

	// RVA: 0x1868A50 Offset: 0x1868B51 VA: 0x1868A50 Slot: 21
	public override int get_renderOrderPriority() { }

	// RVA: 0x1868BC0 Offset: 0x1868CC1 VA: 0x1868BC0
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x1868BD0 Offset: 0x1868CD1 VA: 0x1868BD0
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x1868BE0 Offset: 0x1868CE1 VA: 0x1868BE0
	public GraphicRaycaster.BlockingObjects get_blockingObjects() { }

	// RVA: 0x1868BF0 Offset: 0x1868CF1 VA: 0x1868BF0
	public void set_blockingObjects(GraphicRaycaster.BlockingObjects value) { }

	// RVA: 0x1868C00 Offset: 0x1868D01 VA: 0x1868C00
	protected void .ctor() { }

	// RVA: 0x18689A0 Offset: 0x1868AA1 VA: 0x18689A0
	private Canvas get_canvas() { }

	// RVA: 0x1868CA0 Offset: 0x1868DA1 VA: 0x1868CA0 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x186A800 Offset: 0x186A901 VA: 0x186A800 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x186A180 Offset: 0x186A281 VA: 0x186A180
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	// RVA: 0x186AB90 Offset: 0x186AC91 VA: 0x186AB90
	private static void .cctor() { }
}

