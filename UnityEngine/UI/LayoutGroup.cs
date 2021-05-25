[DisallowMultipleComponent] // RVA: 0x11A240 Offset: 0x11A341 VA: 0x11A240
[ExecuteAlways] // RVA: 0x11A240 Offset: 0x11A341 VA: 0x11A240
[RequireComponent] // RVA: 0x11A240 Offset: 0x11A341 VA: 0x11A240
public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 3975
{
	// Fields
	[SerializeField] // RVA: 0x11C150 Offset: 0x11C251 VA: 0x11C150
	protected RectOffset m_Padding; // 0x18
	[SerializeField] // RVA: 0x11C160 Offset: 0x11C261 VA: 0x11C160
	protected TextAnchor m_ChildAlignment; // 0x20
	private RectTransform m_Rect; // 0x28
	protected DrivenRectTransformTracker m_Tracker; // 0x30
	private Vector2 m_TotalMinSize; // 0x34
	private Vector2 m_TotalPreferredSize; // 0x3C
	private Vector2 m_TotalFlexibleSize; // 0x44
	private List<RectTransform> m_RectChildren; // 0x50

	// Properties
	public RectOffset padding { get; set; }
	public TextAnchor childAlignment { get; set; }
	protected RectTransform rectTransform { get; }
	protected List<RectTransform> rectChildren { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }
	private bool isRootLayoutGroup { get; }

	// Methods

	// RVA: 0x18BB430 Offset: 0x18BB531 VA: 0x18BB430
	public RectOffset get_padding() { }

	// RVA: 0x18BB440 Offset: 0x18BB541 VA: 0x18BB440
	public void set_padding(RectOffset value) { }

	// RVA: 0x18BB4B0 Offset: 0x18BB5B1 VA: 0x18BB4B0
	public TextAnchor get_childAlignment() { }

	// RVA: 0x18BB4C0 Offset: 0x18BB5C1 VA: 0x18BB4C0
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x18BB530 Offset: 0x18BB631 VA: 0x18BB530
	protected RectTransform get_rectTransform() { }

	// RVA: 0x18BB5E0 Offset: 0x18BB6E1 VA: 0x18BB5E0
	protected List<RectTransform> get_rectChildren() { }

	// RVA: 0x18BB5F0 Offset: 0x18BB6F1 VA: 0x18BB5F0 Slot: 28
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void CalculateLayoutInputVertical() { }

	// RVA: 0x18BBA30 Offset: 0x18BBB31 VA: 0x18BBA30 Slot: 30
	public virtual float get_minWidth() { }

	// RVA: 0x18BBA50 Offset: 0x18BBB51 VA: 0x18BBA50 Slot: 31
	public virtual float get_preferredWidth() { }

	// RVA: 0x18BBA70 Offset: 0x18BBB71 VA: 0x18BBA70 Slot: 32
	public virtual float get_flexibleWidth() { }

	// RVA: 0x18BBA90 Offset: 0x18BBB91 VA: 0x18BBA90 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x18BBAA0 Offset: 0x18BBBA1 VA: 0x18BBAA0 Slot: 34
	public virtual float get_preferredHeight() { }

	// RVA: 0x18BBAB0 Offset: 0x18BBBB1 VA: 0x18BBAB0 Slot: 35
	public virtual float get_flexibleHeight() { }

	// RVA: 0x18BBAC0 Offset: 0x18BBBC1 VA: 0x18BBAC0 Slot: 36
	public virtual int get_layoutPriority() { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void SetLayoutHorizontal() { }

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void SetLayoutVertical() { }

	// RVA: 0x18BBAD0 Offset: 0x18BBBD1 VA: 0x18BBAD0
	protected void .ctor() { }

	// RVA: 0x18BBC10 Offset: 0x18BBD11 VA: 0x18BBC10 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x18BBE00 Offset: 0x18BBF01 VA: 0x18BBE00 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x18BBF10 Offset: 0x18BC011 VA: 0x18BBF10 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x18BBA40 Offset: 0x18BBB41 VA: 0x18BBA40
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x18BBA60 Offset: 0x18BBB61 VA: 0x18BBA60
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x18BBA80 Offset: 0x18BBB81 VA: 0x18BBA80
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x18BBF20 Offset: 0x18BC021 VA: 0x18BBF20
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x18BC0D0 Offset: 0x18BC1D1 VA: 0x18BC0D0
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x18BC110 Offset: 0x18BC211 VA: 0x18BC110
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x18BC170 Offset: 0x18BC271 VA: 0x18BC170
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x18BC230 Offset: 0x18BC331 VA: 0x18BC230
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x18BC3F0 Offset: 0x18BC4F1 VA: 0x18BC3F0
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x18BC4B0 Offset: 0x18BC5B1 VA: 0x18BC4B0
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x18BC690 Offset: 0x18BC791 VA: 0x18BC690
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x18BC7D0 Offset: 0x18BC8D1 VA: 0x18BC7D0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x18BC810 Offset: 0x18BC911 VA: 0x18BC810 Slot: 39
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: -1 Offset: -1
	protected void SetProperty<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E9F70 Offset: 0x23EA071 VA: 0x23E9F70
	|-LayoutGroup.SetProperty<bool>
	|
	|-RVA: 0x23EA000 Offset: 0x23EA101 VA: 0x23EA000
	|-LayoutGroup.SetProperty<int>
	|
	|-RVA: 0x23EA090 Offset: 0x23EA191 VA: 0x23EA090
	|-LayoutGroup.SetProperty<Int32Enum>
	|-LayoutGroup.SetProperty<TextAnchor>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Axis>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Constraint>
	|-LayoutGroup.SetProperty<GridLayoutGroup.Corner>
	|
	|-RVA: 0x23EA150 Offset: 0x23EA251 VA: 0x23EA150
	|-LayoutGroup.SetProperty<object>
	|-LayoutGroup.SetProperty<RectOffset>
	|
	|-RVA: 0x23EA1D0 Offset: 0x23EA2D1 VA: 0x23EA1D0
	|-LayoutGroup.SetProperty<float>
	|
	|-RVA: 0x23EA260 Offset: 0x23EA361 VA: 0x23EA260
	|-LayoutGroup.SetProperty<Vector2>
	*/

	// RVA: 0x18BBC40 Offset: 0x18BBD41 VA: 0x18BBC40
	protected void SetDirty() { }

	[IteratorStateMachineAttribute] // RVA: 0x11D090 Offset: 0x11D191 VA: 0x11D090
	// RVA: 0x18BC820 Offset: 0x18BC921 VA: 0x18BC820
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }
}

