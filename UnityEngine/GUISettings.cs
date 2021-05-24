[NativeHeaderAttribute] // RVA: 0xF4BA0 Offset: 0xF4CA1 VA: 0xF4BA0
[Serializable]
public sealed class GUISettings // TypeDefIndex: 3602
{
	// Fields
	[SerializeField] // RVA: 0xF5750 Offset: 0xF5851 VA: 0xF5750
	private bool m_DoubleClickSelectsWord; // 0x10
	[SerializeField] // RVA: 0xF5760 Offset: 0xF5861 VA: 0xF5760
	private bool m_TripleClickSelectsLine; // 0x11
	[SerializeField] // RVA: 0xF5770 Offset: 0xF5871 VA: 0xF5770
	private Color m_CursorColor; // 0x14
	[SerializeField] // RVA: 0xF5780 Offset: 0xF5881 VA: 0xF5780
	private float m_CursorFlashSpeed; // 0x24
	[SerializeField] // RVA: 0xF5790 Offset: 0xF5891 VA: 0xF5790
	private Color m_SelectionColor; // 0x28

	// Properties
	public bool doubleClickSelectsWord { get; }
	public bool tripleClickSelectsLine { get; }
	public Color cursorColor { get; }
	public float cursorFlashSpeed { get; }
	public Color selectionColor { get; }

	// Methods

	// RVA: 0x2D1BB40 Offset: 0x2D1BC41 VA: 0x2D1BB40
	private static float Internal_GetCursorFlashSpeed() { }

	// RVA: 0x2D07DA0 Offset: 0x2D07EA1 VA: 0x2D07DA0
	public bool get_doubleClickSelectsWord() { }

	// RVA: 0x2D07DB0 Offset: 0x2D07EB1 VA: 0x2D07DB0
	public bool get_tripleClickSelectsLine() { }

	// RVA: 0x2D1BB80 Offset: 0x2D1BC81 VA: 0x2D1BB80
	public Color get_cursorColor() { }

	// RVA: 0x2D1BB90 Offset: 0x2D1BC91 VA: 0x2D1BB90
	public float get_cursorFlashSpeed() { }

	// RVA: 0x2D1BBE0 Offset: 0x2D1BCE1 VA: 0x2D1BBE0
	public Color get_selectionColor() { }

	// RVA: 0x2D1BBF0 Offset: 0x2D1BCF1 VA: 0x2D1BBF0
	public void .ctor() { }
}

