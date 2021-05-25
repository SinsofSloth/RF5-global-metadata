internal sealed class GUIGridSizer : GUILayoutEntry // TypeDefIndex: 3613
{
	// Fields
	private readonly int m_Count; // 0x48
	private readonly int m_XCount; // 0x4C
	private readonly float m_MinButtonWidth; // 0x50
	private readonly float m_MaxButtonWidth; // 0x54
	private readonly float m_MinButtonHeight; // 0x58
	private readonly float m_MaxButtonHeight; // 0x5C

	// Properties
	private int rows { get; }

	// Methods

	// RVA: 0x2D10410 Offset: 0x2D10511 VA: 0x2D10410
	public static Rect GetRect(GUIContent[] contents, int xCount, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x2D10660 Offset: 0x2D10761 VA: 0x2D10660
	private void .ctor(GUIContent[] contents, int xCount, GUIStyle buttonStyle, GUILayoutOption[] options) { }

	// RVA: 0x2D11330 Offset: 0x2D11431 VA: 0x2D11330
	private int get_rows() { }
}

