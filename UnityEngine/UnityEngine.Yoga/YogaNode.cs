[DefaultMemberAttribute] // RVA: 0x11DEC0 Offset: 0x11DFC1 VA: 0x11DEC0
internal class YogaNode // TypeDefIndex: 4102
{
	// Fields
	internal IntPtr _ygNode; // 0x10
	private MeasureFunction _measureFunction; // 0x18
	private BaselineFunction _baselineFunction; // 0x20

	// Properties
	public float LayoutX { get; }
	public float LayoutY { get; }
	public float LayoutWidth { get; }
	public float LayoutHeight { get; }

	// Methods

	// RVA: 0x1BCBDB0 Offset: 0x1BCBEB1 VA: 0x1BCBDB0
	public float get_LayoutX() { }

	// RVA: 0x1BCBE00 Offset: 0x1BCBF01 VA: 0x1BCBE00
	public float get_LayoutY() { }

	// RVA: 0x1BCBE50 Offset: 0x1BCBF51 VA: 0x1BCBE50
	public float get_LayoutWidth() { }

	// RVA: 0x1BCBEA0 Offset: 0x1BCBFA1 VA: 0x1BCBEA0
	public float get_LayoutHeight() { }

	// RVA: 0x1BCBA30 Offset: 0x1BCBB31 VA: 0x1BCBA30
	public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x1BCBBC0 Offset: 0x1BCBCC1 VA: 0x1BCBBC0
	public static float BaselineInternal(YogaNode node, float width, float height) { }
}

