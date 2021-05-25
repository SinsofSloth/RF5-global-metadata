[VisibleToOtherModulesAttribute] // RVA: 0xF4E50 Offset: 0xF4F51 VA: 0xF4E50
internal class GUILayoutEntry // TypeDefIndex: 3612
{
	// Fields
	public float minWidth; // 0x10
	public float maxWidth; // 0x14
	public float minHeight; // 0x18
	public float maxHeight; // 0x1C
	public Rect rect; // 0x20
	public int stretchWidth; // 0x30
	public int stretchHeight; // 0x34
	public bool consideredForMargin; // 0x38
	private GUIStyle m_Style; // 0x40
	internal static Rect kDummyRect; // 0x0
	protected static int indent; // 0x10

	// Properties
	public GUIStyle style { get; set; }
	public virtual int marginLeft { get; }
	public virtual int marginRight { get; }
	public virtual int marginTop { get; }
	public virtual int marginBottom { get; }
	public int marginHorizontal { get; }
	public int marginVertical { get; }

	// Methods

	// RVA: 0x2D15000 Offset: 0x2D15101 VA: 0x2D15000
	public GUIStyle get_style() { }

	// RVA: 0x2D14FB0 Offset: 0x2D150B1 VA: 0x2D14FB0
	public void set_style(GUIStyle value) { }

	// RVA: 0x2D15010 Offset: 0x2D15111 VA: 0x2D15010 Slot: 4
	public virtual int get_marginLeft() { }

	// RVA: 0x2D150E0 Offset: 0x2D151E1 VA: 0x2D150E0 Slot: 5
	public virtual int get_marginRight() { }

	// RVA: 0x2D151B0 Offset: 0x2D152B1 VA: 0x2D151B0 Slot: 6
	public virtual int get_marginTop() { }

	// RVA: 0x2D15280 Offset: 0x2D15381 VA: 0x2D15280 Slot: 7
	public virtual int get_marginBottom() { }

	// RVA: 0x2D15350 Offset: 0x2D15451 VA: 0x2D15350
	public int get_marginHorizontal() { }

	// RVA: 0x2D15390 Offset: 0x2D15491 VA: 0x2D15390
	public int get_marginVertical() { }

	// RVA: 0x2D111F0 Offset: 0x2D112F1 VA: 0x2D111F0
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x2D153D0 Offset: 0x2D154D1 VA: 0x2D153D0
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x2D15510 Offset: 0x2D15611 VA: 0x2D15510 Slot: 8
	public virtual void CalcWidth() { }

	// RVA: 0x2D15520 Offset: 0x2D15621 VA: 0x2D15520 Slot: 9
	public virtual void CalcHeight() { }

	// RVA: 0x2D15530 Offset: 0x2D15631 VA: 0x2D15530 Slot: 10
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x2D15570 Offset: 0x2D15671 VA: 0x2D15570 Slot: 11
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x2D155B0 Offset: 0x2D156B1 VA: 0x2D155B0 Slot: 12
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x2D15780 Offset: 0x2D15881 VA: 0x2D15780 Slot: 13
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x2D15AD0 Offset: 0x2D15BD1 VA: 0x2D15AD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2D161C0 Offset: 0x2D162C1 VA: 0x2D161C0
	private static void .cctor() { }
}

