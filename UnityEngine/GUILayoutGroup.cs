[VisibleToOtherModulesAttribute] // RVA: 0xF4EE0 Offset: 0xF4FE1 VA: 0xF4EE0
internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 3615
{
	// Fields
	public List<GUILayoutEntry> entries; // 0x48
	public bool isVertical; // 0x50
	public bool resetCoords; // 0x51
	public float spacing; // 0x54
	public bool sameSize; // 0x58
	public bool isWindow; // 0x59
	public int windowID; // 0x5C
	private int m_Cursor; // 0x60
	protected int m_StretchableCountX; // 0x64
	protected int m_StretchableCountY; // 0x68
	protected bool m_UserSpecifiedWidth; // 0x6C
	protected bool m_UserSpecifiedHeight; // 0x6D
	protected float m_ChildMinWidth; // 0x70
	protected float m_ChildMaxWidth; // 0x74
	protected float m_ChildMinHeight; // 0x78
	protected float m_ChildMaxHeight; // 0x7C
	protected int m_MarginLeft; // 0x80
	protected int m_MarginRight; // 0x84
	protected int m_MarginTop; // 0x88
	protected int m_MarginBottom; // 0x8C

	// Properties
	public override int marginLeft { get; }
	public override int marginRight { get; }
	public override int marginTop { get; }
	public override int marginBottom { get; }

	// Methods

	// RVA: 0x2D16250 Offset: 0x2D16351 VA: 0x2D16250 Slot: 4
	public override int get_marginLeft() { }

	// RVA: 0x2D16260 Offset: 0x2D16361 VA: 0x2D16260 Slot: 5
	public override int get_marginRight() { }

	// RVA: 0x2D16270 Offset: 0x2D16371 VA: 0x2D16270 Slot: 6
	public override int get_marginTop() { }

	// RVA: 0x2D16280 Offset: 0x2D16381 VA: 0x2D16280 Slot: 7
	public override int get_marginBottom() { }

	// RVA: 0x2D16290 Offset: 0x2D16391 VA: 0x2D16290
	public void .ctor() { }

	// RVA: 0x2D163B0 Offset: 0x2D164B1 VA: 0x2D163B0 Slot: 13
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x2D16500 Offset: 0x2D16601 VA: 0x2D16500 Slot: 12
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x2D14FF0 Offset: 0x2D150F1 VA: 0x2D14FF0
	public void ResetCursor() { }

	// RVA: 0x2D10F60 Offset: 0x2D11061 VA: 0x2D10F60
	public GUILayoutEntry GetNext() { }

	// RVA: 0x2D16620 Offset: 0x2D16721 VA: 0x2D16620
	public Rect GetLast() { }

	// RVA: 0x2D10EF0 Offset: 0x2D10FF1 VA: 0x2D10EF0
	public void Add(GUILayoutEntry e) { }

	// RVA: 0x2D169E0 Offset: 0x2D16AE1 VA: 0x2D169E0 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x2D17400 Offset: 0x2D17501 VA: 0x2D17400 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x2D17ED0 Offset: 0x2D17FD1 VA: 0x2D17ED0 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x2D18800 Offset: 0x2D18901 VA: 0x2D18800 Slot: 11
	public override void SetVertical(float y, float height) { }

	// RVA: 0x2D192E0 Offset: 0x2D193E1 VA: 0x2D192E0 Slot: 3
	public override string ToString() { }
}

