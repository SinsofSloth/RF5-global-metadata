[AddComponentMenu] // RVA: 0x11A070 Offset: 0x11A171 VA: 0x11A070
[ExecuteAlways] // RVA: 0x11A070 Offset: 0x11A171 VA: 0x11A070
[RequireComponent] // RVA: 0x11A070 Offset: 0x11A171 VA: 0x11A070
public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 3961
{
	// Fields
	[SerializeField] // RVA: 0x11BFE0 Offset: 0x11C0E1 VA: 0x11BFE0
	protected ContentSizeFitter.FitMode m_HorizontalFit; // 0x18
	[SerializeField] // RVA: 0x11BFF0 Offset: 0x11C0F1 VA: 0x11BFF0
	protected ContentSizeFitter.FitMode m_VerticalFit; // 0x1C
	private RectTransform m_Rect; // 0x20
	private DrivenRectTransformTracker m_Tracker; // 0x28

	// Properties
	public ContentSizeFitter.FitMode horizontalFit { get; set; }
	public ContentSizeFitter.FitMode verticalFit { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x1649810 Offset: 0x1649911 VA: 0x1649810
	public ContentSizeFitter.FitMode get_horizontalFit() { }

	// RVA: 0x1649820 Offset: 0x1649921 VA: 0x1649820
	public void set_horizontalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x16499C0 Offset: 0x1649AC1 VA: 0x16499C0
	public ContentSizeFitter.FitMode get_verticalFit() { }

	// RVA: 0x16499D0 Offset: 0x1649AD1 VA: 0x16499D0
	public void set_verticalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x1649A50 Offset: 0x1649B51 VA: 0x1649A50
	private RectTransform get_rectTransform() { }

	// RVA: 0x1649B00 Offset: 0x1649C01 VA: 0x1649B00
	protected void .ctor() { }

	// RVA: 0x1649B10 Offset: 0x1649C11 VA: 0x1649B10 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1649B20 Offset: 0x1649C21 VA: 0x1649B20 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1649C30 Offset: 0x1649D31 VA: 0x1649C30 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1649C40 Offset: 0x1649D41 VA: 0x1649C40
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x1649E20 Offset: 0x1649F21 VA: 0x1649E20 Slot: 19
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1649E50 Offset: 0x1649F51 VA: 0x1649E50 Slot: 20
	public virtual void SetLayoutVertical() { }

	// RVA: 0x16498A0 Offset: 0x16499A1 VA: 0x16498A0
	protected void SetDirty() { }
}

