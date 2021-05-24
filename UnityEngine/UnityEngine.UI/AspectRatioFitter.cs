[AddComponentMenu] // RVA: 0x119F10 Offset: 0x11A011 VA: 0x119F10
[ExecuteAlways] // RVA: 0x119F10 Offset: 0x11A011 VA: 0x119F10
[RequireComponent] // RVA: 0x119F10 Offset: 0x11A011 VA: 0x119F10
[DisallowMultipleComponent] // RVA: 0x119F10 Offset: 0x11A011 VA: 0x119F10
public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 3955
{
	// Fields
	[SerializeField] // RVA: 0x11BC80 Offset: 0x11BD81 VA: 0x11BC80
	private AspectRatioFitter.AspectMode m_AspectMode; // 0x18
	[SerializeField] // RVA: 0x11BC90 Offset: 0x11BD91 VA: 0x11BC90
	private float m_AspectRatio; // 0x1C
	private RectTransform m_Rect; // 0x20
	private bool m_DelayedSetDirty; // 0x28
	private DrivenRectTransformTracker m_Tracker; // 0x29

	// Properties
	public AspectRatioFitter.AspectMode aspectMode { get; set; }
	public float aspectRatio { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x16449A0 Offset: 0x1644AA1 VA: 0x16449A0
	public AspectRatioFitter.AspectMode get_aspectMode() { }

	// RVA: 0x16449B0 Offset: 0x1644AB1 VA: 0x16449B0
	public void set_aspectMode(AspectRatioFitter.AspectMode value) { }

	// RVA: 0x1644A40 Offset: 0x1644B41 VA: 0x1644A40
	public float get_aspectRatio() { }

	// RVA: 0x1644A50 Offset: 0x1644B51 VA: 0x1644A50
	public void set_aspectRatio(float value) { }

	// RVA: 0x1644AD0 Offset: 0x1644BD1 VA: 0x1644AD0
	private RectTransform get_rectTransform() { }

	// RVA: 0x1644B80 Offset: 0x1644C81 VA: 0x1644B80
	protected void .ctor() { }

	// RVA: 0x1644B90 Offset: 0x1644C91 VA: 0x1644B90 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1644BA0 Offset: 0x1644CA1 VA: 0x1644BA0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1644CB0 Offset: 0x1644DB1 VA: 0x1644CB0 Slot: 19
	protected virtual void Update() { }

	// RVA: 0x1644CD0 Offset: 0x1644DD1 VA: 0x1644CD0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1644CE0 Offset: 0x1644DE1 VA: 0x1644CE0
	private void UpdateRect() { }

	// RVA: 0x1645680 Offset: 0x1645781 VA: 0x1645680
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x16454D0 Offset: 0x16455D1 VA: 0x16454D0
	private Vector2 GetParentSize() { }

	// RVA: 0x1645840 Offset: 0x1645941 VA: 0x1645840 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1645850 Offset: 0x1645951 VA: 0x1645850 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0x1644A30 Offset: 0x1644B31 VA: 0x1644A30
	protected void SetDirty() { }
}

