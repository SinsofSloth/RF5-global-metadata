[NativeHeaderAttribute] // RVA: 0x100C90 Offset: 0x100D91 VA: 0x100C90
public sealed class FontEngine // TypeDefIndex: 3689
{
	// Fields
	private static Glyph[] s_Glyphs; // 0x0
	private static uint[] s_GlyphIndexes_MarshallingArray_A; // 0x8
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; // 0x10
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; // 0x18
	private static GlyphRect[] s_FreeGlyphRects; // 0x20
	private static GlyphRect[] s_UsedGlyphRects; // 0x28
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x30
	private static Dictionary<uint, Glyph> s_GlyphLookupDictionary; // 0x38

	// Methods

	// RVA: 0x1BC7DA0 Offset: 0x1BC7EA1 VA: 0x1BC7DA0
	public static FontEngineError InitializeFontEngine() { }

	[NativeMethodAttribute] // RVA: 0x1019C0 Offset: 0x101AC1 VA: 0x1019C0
	// RVA: 0x1BC7E30 Offset: 0x1BC7F31 VA: 0x1BC7E30
	private static int InitializeFontEngine_Internal() { }

	// RVA: 0x1BC7E70 Offset: 0x1BC7F71 VA: 0x1BC7E70
	public static FontEngineError LoadFontFace(Font font, int pointSize) { }

	[NativeMethodAttribute] // RVA: 0x101A10 Offset: 0x101B11 VA: 0x101A10
	// RVA: 0x1BC7F20 Offset: 0x1BC8021 VA: 0x1BC7F20
	private static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize) { }

	// RVA: 0x1BC7F70 Offset: 0x1BC8071 VA: 0x1BC7F70
	public static FaceInfo GetFaceInfo() { }

	[NativeMethodAttribute] // RVA: 0x101A60 Offset: 0x101B61 VA: 0x101A60
	// RVA: 0x1BC8060 Offset: 0x1BC8161 VA: 0x1BC8060
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	[NativeMethodAttribute] // RVA: 0x101AB0 Offset: 0x101BB1 VA: 0x101AB0
	// RVA: 0x1BC80B0 Offset: 0x1BC81B1 VA: 0x1BC80B0
	internal static uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x1BC8100 Offset: 0x1BC8201 VA: 0x1BC8100
	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x101B00 Offset: 0x101C01 VA: 0x101B00
	// RVA: 0x1BC8260 Offset: 0x1BC8361 VA: 0x1BC8260
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x1BC82C0 Offset: 0x1BC83C1 VA: 0x1BC82C0
	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x101B50 Offset: 0x101C51 VA: 0x101B50
	// RVA: 0x1BC8420 Offset: 0x1BC8521 VA: 0x1BC8420
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x1BC8480 Offset: 0x1BC8581 VA: 0x1BC8480
	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x101BA0 Offset: 0x101CA1 VA: 0x101BA0
	// RVA: 0x1BC89C0 Offset: 0x1BC8AC1 VA: 0x1BC89C0
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	// RVA: 0x1BC8A70 Offset: 0x1BC8B71 VA: 0x1BC8A70
	internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[NativeMethodAttribute] // RVA: 0x101BF0 Offset: 0x101CF1 VA: 0x101BF0
	// RVA: 0x1BC94B0 Offset: 0x1BC95B1 VA: 0x1BC94B0
	private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	// RVA: 0x1BC9570 Offset: 0x1BC9671 VA: 0x1BC9570
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes) { }

	[NativeMethodAttribute] // RVA: 0x101C40 Offset: 0x101D41 VA: 0x101C40
	// RVA: 0x1BC9700 Offset: 0x1BC9801 VA: 0x1BC9700
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethodAttribute] // RVA: 0x101C90 Offset: 0x101D91 VA: 0x101C90
	// RVA: 0x1BC9750 Offset: 0x1BC9851 VA: 0x1BC9750
	private static int GetGlyphPairAdjustmentRecordsFromMarshallingArray([Out] GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	// RVA: -1 Offset: -1
	private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E9C10 Offset: 0x23E9D11 VA: 0x23E9C10
	|-FontEngine.SetMarshallingArraySize<object>
	|
	|-RVA: 0x23E9D10 Offset: 0x23E9E11 VA: 0x23E9D10
	|-FontEngine.SetMarshallingArraySize<GlyphPairAdjustmentRecord>
	*/

	[NativeMethodAttribute] // RVA: 0x101CE0 Offset: 0x101DE1 VA: 0x101CE0
	// RVA: 0x1BC97A0 Offset: 0x1BC98A1 VA: 0x1BC97A0
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x1BC97F0 Offset: 0x1BC98F1 VA: 0x1BC97F0
	private static void .cctor() { }
}

