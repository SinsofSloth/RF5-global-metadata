[AddComponentMenu] // RVA: 0x1276B0 Offset: 0x1277B1 VA: 0x1276B0
public class FlowLayoutGroup : LayoutGroup // TypeDefIndex: 4339
{
	// Fields
	private readonly IList<RectTransform> _rowList; // 0x58
	private float _layoutHeight; // 0x60
	public bool ChildForceExpandHeight; // 0x64
	public bool ChildForceExpandWidth; // 0x65
	public float Spacing; // 0x68

	// Properties
	protected bool IsCenterAlign { get; }
	protected bool IsRightAlign { get; }
	protected bool IsMiddleAlign { get; }
	protected bool IsLowerAlign { get; }

	// Methods

	// RVA: 0x1A86960 Offset: 0x1A86A61 VA: 0x1A86960
	protected bool get_IsCenterAlign() { }

	// RVA: 0x1A86990 Offset: 0x1A86A91 VA: 0x1A86990
	protected bool get_IsRightAlign() { }

	// RVA: 0x1A869C0 Offset: 0x1A86AC1 VA: 0x1A869C0
	protected bool get_IsMiddleAlign() { }

	// RVA: 0x1A869F0 Offset: 0x1A86AF1 VA: 0x1A869F0
	protected bool get_IsLowerAlign() { }

	// RVA: 0x1A86A20 Offset: 0x1A86B21 VA: 0x1A86A20 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1A86B90 Offset: 0x1A86C91 VA: 0x1A86B90 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x1A871C0 Offset: 0x1A872C1 VA: 0x1A871C0 Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x1A87230 Offset: 0x1A87331 VA: 0x1A87230 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x1A86C00 Offset: 0x1A86D01 VA: 0x1A86C00
	public float SetLayout(float width, int axis, bool layoutInput) { }

	// RVA: 0x1A872A0 Offset: 0x1A873A1 VA: 0x1A872A0
	private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight) { }

	// RVA: 0x1A872F0 Offset: 0x1A873F1 VA: 0x1A872F0
	protected void LayoutRow(IList<RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis) { }

	// RVA: 0x1A86AB0 Offset: 0x1A86BB1 VA: 0x1A86AB0
	public float GetGreatestMinimumChildWidth() { }

	// RVA: 0x1A87790 Offset: 0x1A87891 VA: 0x1A87790
	public void .ctor() { }
}

