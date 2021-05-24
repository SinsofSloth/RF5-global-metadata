public struct TextGenerationSettings // TypeDefIndex: 3457
{
	// Fields
	public Font font; // 0x0
	public Color color; // 0x8
	public int fontSize; // 0x18
	public float lineSpacing; // 0x1C
	public bool richText; // 0x20
	public float scaleFactor; // 0x24
	public FontStyle fontStyle; // 0x28
	public TextAnchor textAnchor; // 0x2C
	public bool alignByGeometry; // 0x30
	public bool resizeTextForBestFit; // 0x31
	public int resizeTextMinSize; // 0x34
	public int resizeTextMaxSize; // 0x38
	public bool updateBounds; // 0x3C
	public VerticalWrapMode verticalOverflow; // 0x40
	public HorizontalWrapMode horizontalOverflow; // 0x44
	public Vector2 generationExtents; // 0x48
	public Vector2 pivot; // 0x50
	public bool generateOutOfBounds; // 0x58

	// Methods

	// RVA: 0x26450 Offset: 0x26551 VA: 0x26450
	private bool CompareColors(Color left, Color right) { }

	// RVA: 0x26460 Offset: 0x26561 VA: 0x26460
	private bool CompareVector2(Vector2 left, Vector2 right) { }

	// RVA: 0x26470 Offset: 0x26571 VA: 0x26470
	public bool Equals(TextGenerationSettings other) { }
}

