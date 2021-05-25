[AddComponentMenu] // RVA: 0x11A400 Offset: 0x11A501 VA: 0x11A400
[ExecuteAlways] // RVA: 0x11A400 Offset: 0x11A501 VA: 0x11A400
[DisallowMultipleComponent] // RVA: 0x11A400 Offset: 0x11A501 VA: 0x11A400
[RequireComponent] // RVA: 0x11A400 Offset: 0x11A501 VA: 0x11A400
public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 3992
{
	// Fields
	private readonly RectangularVertexClipper m_VertexClipper; // 0x18
	private RectTransform m_RectTransform; // 0x20
	private HashSet<MaskableGraphic> m_MaskableTargets; // 0x28
	private HashSet<IClippable> m_ClipTargets; // 0x30
	private bool m_ShouldRecalculateClipRects; // 0x38
	private List<RectMask2D> m_Clippers; // 0x40
	private Rect m_LastClipRectCanvasSpace; // 0x48
	private bool m_ForceClip; // 0x58
	[SerializeField] // RVA: 0x11C310 Offset: 0x11C411 VA: 0x11C310
	private Vector4 m_Padding; // 0x5C
	[SerializeField] // RVA: 0x11C320 Offset: 0x11C421 VA: 0x11C320
	private Vector2Int m_Softness; // 0x6C
	private Canvas m_Canvas; // 0x78
	private Vector3[] m_Corners; // 0x80

	// Properties
	public Vector4 padding { get; set; }
	public Vector2Int softness { get; set; }
	private Canvas Canvas { get; }
	public Rect canvasRect { get; }
	public RectTransform rectTransform { get; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x18C3E90 Offset: 0x18C3F91 VA: 0x18C3E90
	public Vector4 get_padding() { }

	// RVA: 0x18C3EA0 Offset: 0x18C3FA1 VA: 0x18C3EA0
	public void set_padding(Vector4 value) { }

	// RVA: 0x18C3EC0 Offset: 0x18C3FC1 VA: 0x18C3EC0
	public Vector2Int get_softness() { }

	// RVA: 0x18C3ED0 Offset: 0x18C3FD1 VA: 0x18C3ED0
	public void set_softness(Vector2Int value) { }

	// RVA: 0x18C3FB0 Offset: 0x18C40B1 VA: 0x18C3FB0
	private Canvas get_Canvas() { }

	// RVA: 0x18C4110 Offset: 0x18C4211 VA: 0x18C4110
	public Rect get_canvasRect() { }

	// RVA: 0x18C41D0 Offset: 0x18C42D1 VA: 0x18C41D0
	public RectTransform get_rectTransform() { }

	// RVA: 0x18C4480 Offset: 0x18C4581 VA: 0x18C4480
	protected void .ctor() { }

	// RVA: 0x18C46B0 Offset: 0x18C47B1 VA: 0x18C46B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x18C46F0 Offset: 0x18C47F1 VA: 0x18C46F0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x18C47A0 Offset: 0x18C48A1 VA: 0x18C47A0 Slot: 19
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x18C48E0 Offset: 0x18C49E1 VA: 0x18C48E0
	private Rect get_rootCanvasRect() { }

	// RVA: 0x18C4B30 Offset: 0x18C4C31 VA: 0x18C4B30 Slot: 20
	public virtual void PerformClipping() { }

	// RVA: 0x18C5310 Offset: 0x18C5411 VA: 0x18C5310 Slot: 21
	public virtual void UpdateClipSoftness() { }

	// RVA: 0x18C24D0 Offset: 0x18C25D1 VA: 0x18C24D0
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x18C2340 Offset: 0x18C2441 VA: 0x18C2340
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x18C5600 Offset: 0x18C5701 VA: 0x18C5600 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18C5630 Offset: 0x18C5731 VA: 0x18C5630 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }
}

