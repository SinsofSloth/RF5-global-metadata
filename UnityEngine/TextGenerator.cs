[UsedByNativeCodeAttribute] // RVA: 0xE6E40 Offset: 0xE6F41 VA: 0xE6E40
[NativeHeaderAttribute] // RVA: 0xE6E40 Offset: 0xE6F41 VA: 0xE6E40
public sealed class TextGenerator : IDisposable // TypeDefIndex: 3458
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private string m_LastString; // 0x18
	private TextGenerationSettings m_LastSettings; // 0x20
	private bool m_HasGenerated; // 0x80
	private TextGenerationError m_LastValid; // 0x84
	private readonly List<UIVertex> m_Verts; // 0x88
	private readonly List<UICharInfo> m_Characters; // 0x90
	private readonly List<UILineInfo> m_Lines; // 0x98
	private bool m_CachedVerts; // 0xA0
	private bool m_CachedCharacters; // 0xA1
	private bool m_CachedLines; // 0xA2

	// Properties
	public int characterCountVisible { get; }
	public IList<UIVertex> verts { get; }
	public IList<UICharInfo> characters { get; }
	public IList<UILineInfo> lines { get; }
	public Rect rectExtents { get; }
	public int characterCount { get; }
	public int lineCount { get; }

	// Methods

	// RVA: 0x1BCEC40 Offset: 0x1BCED41 VA: 0x1BCEC40
	public void .ctor() { }

	// RVA: 0x1BCEC50 Offset: 0x1BCED51 VA: 0x1BCEC50
	public void .ctor(int initialCapacity) { }

	// RVA: 0x1BCEDC0 Offset: 0x1BCEEC1 VA: 0x1BCEDC0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1BCEEB0 Offset: 0x1BCEFB1 VA: 0x1BCEEB0 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1BCEF90 Offset: 0x1BCF091 VA: 0x1BCEF90
	public int get_characterCountVisible() { }

	// RVA: 0x1BCF030 Offset: 0x1BCF131 VA: 0x1BCF030
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x1BCF370 Offset: 0x1BCF471 VA: 0x1BCF370
	public void Invalidate() { }

	// RVA: 0x1BCF380 Offset: 0x1BCF481 VA: 0x1BCF380
	public void GetCharacters(List<UICharInfo> characters) { }

	// RVA: 0x1BCF420 Offset: 0x1BCF521 VA: 0x1BCF420
	public void GetLines(List<UILineInfo> lines) { }

	// RVA: 0x1BCF4C0 Offset: 0x1BCF5C1 VA: 0x1BCF4C0
	public void GetVertices(List<UIVertex> vertices) { }

	// RVA: 0x1BCF560 Offset: 0x1BCF661 VA: 0x1BCF560
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x1BCF830 Offset: 0x1BCF931 VA: 0x1BCF830
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x1BCF990 Offset: 0x1BCFA91 VA: 0x1BCF990
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x1BCF6C0 Offset: 0x1BCF7C1 VA: 0x1BCF6C0
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x1BCFC20 Offset: 0x1BCFD21 VA: 0x1BCFC20
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x1BCFD00 Offset: 0x1BCFE01 VA: 0x1BCFD00
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x1BD0050 Offset: 0x1BD0151 VA: 0x1BD0050
	public IList<UIVertex> get_verts() { }

	// RVA: 0x1BD00C0 Offset: 0x1BD01C1 VA: 0x1BD00C0
	public IList<UICharInfo> get_characters() { }

	// RVA: 0x1BD0130 Offset: 0x1BD0231 VA: 0x1BD0130
	public IList<UILineInfo> get_lines() { }

	// RVA: 0x1BCF7D0 Offset: 0x1BCF8D1 VA: 0x1BCF7D0
	public Rect get_rectExtents() { }

	// RVA: 0x1BCEFE0 Offset: 0x1BCF0E1 VA: 0x1BCEFE0
	public int get_characterCount() { }

	// RVA: 0x1BD01F0 Offset: 0x1BD02F1 VA: 0x1BD01F0
	public int get_lineCount() { }

	[NativeMethodAttribute] // RVA: 0xE7120 Offset: 0xE7221 VA: 0xE7120
	// RVA: 0x1BCED80 Offset: 0x1BCEE81 VA: 0x1BCED80
	private static IntPtr Internal_Create() { }

	[NativeMethodAttribute] // RVA: 0xE7160 Offset: 0xE7261 VA: 0xE7160
	// RVA: 0x1BCEF40 Offset: 0x1BCF041 VA: 0x1BCEF40
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x1BD0240 Offset: 0x1BD0341 VA: 0x1BD0240
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x1BCFE60 Offset: 0x1BCFF61 VA: 0x1BCFE60
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[NativeThrowsAttribute] // RVA: 0xE71A0 Offset: 0xE72A1 VA: 0xE71A0
	// RVA: 0x1BCF510 Offset: 0x1BCF611 VA: 0x1BCF510
	private void GetVerticesInternal(object vertices) { }

	[NativeThrowsAttribute] // RVA: 0xE71B0 Offset: 0xE72B1 VA: 0xE71B0
	// RVA: 0x1BCF3D0 Offset: 0x1BCF4D1 VA: 0x1BCF3D0
	private void GetCharactersInternal(object characters) { }

	[NativeThrowsAttribute] // RVA: 0xE71C0 Offset: 0xE72C1 VA: 0xE71C0
	// RVA: 0x1BCF470 Offset: 0x1BCF571 VA: 0x1BCF470
	private void GetLinesInternal(object lines) { }

	// RVA: 0x1BD01A0 Offset: 0x1BD02A1 VA: 0x1BD01A0
	private void get_rectExtents_Injected(out Rect ret) { }

	// RVA: 0x1BD03A0 Offset: 0x1BD04A1 VA: 0x1BD03A0
	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }
}

