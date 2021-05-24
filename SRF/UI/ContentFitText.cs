[RequireComponent] // RVA: 0x126E30 Offset: 0x126F31 VA: 0x126E30
[ExecuteInEditMode] // RVA: 0x126E30 Offset: 0x126F31 VA: 0x126E30
[AddComponentMenu] // RVA: 0x126E30 Offset: 0x126F31 VA: 0x126E30
public class ContentFitText : UIBehaviour, ILayoutElement // TypeDefIndex: 4312
{
	// Fields
	public SRText CopySource; // 0x18
	public Vector2 Padding; // 0x20

	// Properties
	public float minWidth { get; }
	public float preferredWidth { get; }
	public float flexibleWidth { get; }
	public float minHeight { get; }
	public float preferredHeight { get; }
	public float flexibleHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0x1A84690 Offset: 0x1A84791 VA: 0x1A84690 Slot: 19
	public float get_minWidth() { }

	// RVA: 0x1A84740 Offset: 0x1A84841 VA: 0x1A84740 Slot: 20
	public float get_preferredWidth() { }

	// RVA: 0x1A847F0 Offset: 0x1A848F1 VA: 0x1A847F0 Slot: 21
	public float get_flexibleWidth() { }

	// RVA: 0x1A84890 Offset: 0x1A84991 VA: 0x1A84890 Slot: 22
	public float get_minHeight() { }

	// RVA: 0x1A84940 Offset: 0x1A84A41 VA: 0x1A84940 Slot: 23
	public float get_preferredHeight() { }

	// RVA: 0x1A849F0 Offset: 0x1A84AF1 VA: 0x1A849F0 Slot: 24
	public float get_flexibleHeight() { }

	// RVA: 0x1A84A90 Offset: 0x1A84B91 VA: 0x1A84A90 Slot: 25
	public int get_layoutPriority() { }

	// RVA: 0x1A84AA0 Offset: 0x1A84BA1 VA: 0x1A84AA0 Slot: 17
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1A84AD0 Offset: 0x1A84BD1 VA: 0x1A84AD0 Slot: 18
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x1A84B00 Offset: 0x1A84C01 VA: 0x1A84B00 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A84E20 Offset: 0x1A84F21 VA: 0x1A84E20
	private void CopySourceOnLayoutDirty(SRText srText) { }

	// RVA: 0x1A84EF0 Offset: 0x1A84FF1 VA: 0x1A84EF0 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1A84FC0 Offset: 0x1A850C1 VA: 0x1A84FC0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1A85220 Offset: 0x1A85321 VA: 0x1A85220 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1A852F0 Offset: 0x1A853F1 VA: 0x1A852F0 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x1A84CA0 Offset: 0x1A84DA1 VA: 0x1A84CA0
	protected void SetDirty() { }

	// RVA: 0x1A853C0 Offset: 0x1A854C1 VA: 0x1A853C0
	public void .ctor() { }
}

