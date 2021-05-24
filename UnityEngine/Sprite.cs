[ExcludeFromPresetAttribute] // RVA: 0xC74A0 Offset: 0xC75A1 VA: 0xC74A0
[NativeHeaderAttribute] // RVA: 0xC74A0 Offset: 0xC75A1 VA: 0xC74A0
[NativeHeaderAttribute] // RVA: 0xC74A0 Offset: 0xC75A1 VA: 0xC74A0
[NativeTypeAttribute] // RVA: 0xC74A0 Offset: 0xC75A1 VA: 0xC74A0
[NativeHeaderAttribute] // RVA: 0xC74A0 Offset: 0xC75A1 VA: 0xC74A0
public sealed class Sprite : Object // TypeDefIndex: 3082
{
	// Properties
	public Bounds bounds { get; }
	public Rect rect { get; }
	public Vector4 border { get; }
	public Texture2D texture { get; }
	public float pixelsPerUnit { get; }
	public float spriteAtlasTextureScale { get; }
	public Texture2D associatedAlphaSplitTexture { get; }
	public Vector2 pivot { get; }
	public bool packed { get; }
	public SpritePackingMode packingMode { get; }
	public SpritePackingRotation packingRotation { get; }
	public Rect textureRect { get; }
	public Vector2 textureRectOffset { get; }
	public Vector2[] vertices { get; }
	public ushort[] triangles { get; }
	public Vector2[] uv { get; }

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xD8B40 Offset: 0xD8C41 VA: 0xD8B40
	// RVA: 0x2A2BD50 Offset: 0x2A2BE51 VA: 0x2A2BD50
	private void .ctor() { }

	// RVA: 0x2A2BDC0 Offset: 0x2A2BEC1 VA: 0x2A2BDC0
	internal int GetPackingMode() { }

	// RVA: 0x2A2BE10 Offset: 0x2A2BF11 VA: 0x2A2BE10
	internal int GetPackingRotation() { }

	// RVA: 0x2A2BE60 Offset: 0x2A2BF61 VA: 0x2A2BE60
	internal int GetPacked() { }

	// RVA: 0x2A2BEB0 Offset: 0x2A2BFB1 VA: 0x2A2BEB0
	internal Rect GetTextureRect() { }

	// RVA: 0x2A2BF60 Offset: 0x2A2C061 VA: 0x2A2BF60
	internal Vector2 GetTextureRectOffset() { }

	// RVA: 0x2A2C010 Offset: 0x2A2C111 VA: 0x2A2C010
	internal Vector4 GetInnerUVs() { }

	// RVA: 0x2A2C0C0 Offset: 0x2A2C1C1 VA: 0x2A2C0C0
	internal Vector4 GetOuterUVs() { }

	// RVA: 0x2A2C170 Offset: 0x2A2C271 VA: 0x2A2C170
	internal Vector4 GetPadding() { }

	[FreeFunctionAttribute] // RVA: 0xD8B50 Offset: 0xD8C51 VA: 0xD8B50
	// RVA: 0x2A2C220 Offset: 0x2A2C321 VA: 0x2A2C220
	internal static Sprite CreateSpriteWithoutTextureScripting(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	[FreeFunctionAttribute] // RVA: 0xD8B90 Offset: 0xD8C91 VA: 0xD8B90
	// RVA: 0x2A2C300 Offset: 0x2A2C401 VA: 0x2A2C300
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x2A2C450 Offset: 0x2A2C551 VA: 0x2A2C450
	public Bounds get_bounds() { }

	// RVA: 0x2A2C510 Offset: 0x2A2C611 VA: 0x2A2C510
	public Rect get_rect() { }

	// RVA: 0x2A2C5C0 Offset: 0x2A2C6C1 VA: 0x2A2C5C0
	public Vector4 get_border() { }

	// RVA: 0x2A2C670 Offset: 0x2A2C771 VA: 0x2A2C670
	public Texture2D get_texture() { }

	[NativeMethodAttribute] // RVA: 0xD8BD0 Offset: 0xD8CD1 VA: 0xD8BD0
	// RVA: 0x2A2C6C0 Offset: 0x2A2C7C1 VA: 0x2A2C6C0
	public float get_pixelsPerUnit() { }

	[NativeMethodAttribute] // RVA: 0xD8C10 Offset: 0xD8D11 VA: 0xD8C10
	// RVA: 0x2A2C710 Offset: 0x2A2C811 VA: 0x2A2C710
	public float get_spriteAtlasTextureScale() { }

	[NativeMethodAttribute] // RVA: 0xD8C50 Offset: 0xD8D51 VA: 0xD8C50
	// RVA: 0x2A2C760 Offset: 0x2A2C861 VA: 0x2A2C760
	public Texture2D get_associatedAlphaSplitTexture() { }

	[NativeMethodAttribute] // RVA: 0xD8C90 Offset: 0xD8D91 VA: 0xD8C90
	// RVA: 0x2A2C7B0 Offset: 0x2A2C8B1 VA: 0x2A2C7B0
	public Vector2 get_pivot() { }

	// RVA: 0x2A2C860 Offset: 0x2A2C961 VA: 0x2A2C860
	public bool get_packed() { }

	// RVA: 0x2A2C8B0 Offset: 0x2A2C9B1 VA: 0x2A2C8B0
	public SpritePackingMode get_packingMode() { }

	// RVA: 0x2A2C900 Offset: 0x2A2CA01 VA: 0x2A2C900
	public SpritePackingRotation get_packingRotation() { }

	// RVA: 0x2A2C950 Offset: 0x2A2CA51 VA: 0x2A2C950
	public Rect get_textureRect() { }

	// RVA: 0x2A2CA50 Offset: 0x2A2CB51 VA: 0x2A2CA50
	public Vector2 get_textureRectOffset() { }

	[FreeFunctionAttribute] // RVA: 0xD8CD0 Offset: 0xD8DD1 VA: 0xD8CD0
	// RVA: 0x2A2CBA0 Offset: 0x2A2CCA1 VA: 0x2A2CBA0
	public Vector2[] get_vertices() { }

	[FreeFunctionAttribute] // RVA: 0xD8D20 Offset: 0xD8E21 VA: 0xD8D20
	// RVA: 0x2A2CBF0 Offset: 0x2A2CCF1 VA: 0x2A2CBF0
	public ushort[] get_triangles() { }

	[FreeFunctionAttribute] // RVA: 0xD8D70 Offset: 0xD8E71 VA: 0xD8D70
	// RVA: 0x2A2CC40 Offset: 0x2A2CD41 VA: 0x2A2CC40
	public Vector2[] get_uv() { }

	// RVA: 0x2A2CC90 Offset: 0x2A2CD91 VA: 0x2A2CC90
	public int GetPhysicsShapeCount() { }

	// RVA: 0x2A2CCE0 Offset: 0x2A2CDE1 VA: 0x2A2CCE0
	public int GetPhysicsShapePointCount(int shapeIdx) { }

	[NativeMethodAttribute] // RVA: 0xD8DC0 Offset: 0xD8EC1 VA: 0xD8DC0
	// RVA: 0x2A2CE30 Offset: 0x2A2CF31 VA: 0x2A2CE30
	private int Internal_GetPhysicsShapePointCount(int shapeIdx) { }

	// RVA: 0x2A2CE80 Offset: 0x2A2CF81 VA: 0x2A2CE80
	public int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape) { }

	[FreeFunctionAttribute] // RVA: 0xD8E00 Offset: 0xD8F01 VA: 0xD8E00
	// RVA: 0x2A2CFF0 Offset: 0x2A2D0F1 VA: 0x2A2CFF0
	private static void GetPhysicsShapeImpl(Sprite sprite, int shapeIdx, List<Vector2> physicsShape) { }

	// RVA: 0x2A2D050 Offset: 0x2A2D151 VA: 0x2A2D050
	public void OverridePhysicsShape(IList<Vector2[]> physicsShapes) { }

	[FreeFunctionAttribute] // RVA: 0xD8E50 Offset: 0xD8F51 VA: 0xD8E50
	// RVA: 0x2A2D460 Offset: 0x2A2D561 VA: 0x2A2D460
	private static void OverridePhysicsShapeCount(Sprite sprite, int physicsShapeCount) { }

	[FreeFunctionAttribute] // RVA: 0xD8E90 Offset: 0xD8F91 VA: 0xD8E90
	// RVA: 0x2A2D4B0 Offset: 0x2A2D5B1 VA: 0x2A2D4B0
	private static void OverridePhysicsShape(Sprite sprite, Vector2[] physicsShape, int idx) { }

	[FreeFunctionAttribute] // RVA: 0xD8EE0 Offset: 0xD8FE1 VA: 0xD8EE0
	// RVA: 0x2A2D510 Offset: 0x2A2D611 VA: 0x2A2D510
	public void OverrideGeometry(Vector2[] vertices, ushort[] triangles) { }

	// RVA: 0x2A2D570 Offset: 0x2A2D671 VA: 0x2A2D570
	internal static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	// RVA: 0x2A2D5E0 Offset: 0x2A2D6E1 VA: 0x2A2D5E0
	internal static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits) { }

	// RVA: 0x2A2D650 Offset: 0x2A2D751 VA: 0x2A2D650
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x2A2DA50 Offset: 0x2A2DB51 VA: 0x2A2DA50
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0x2A2DA70 Offset: 0x2A2DB71 VA: 0x2A2DA70
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	// RVA: 0x2A2DB70 Offset: 0x2A2DC71 VA: 0x2A2DB70
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	// RVA: 0x2A2DC60 Offset: 0x2A2DD61 VA: 0x2A2DC60
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	// RVA: 0x2A2DD50 Offset: 0x2A2DE51 VA: 0x2A2DD50
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0x2A2BF10 Offset: 0x2A2C011 VA: 0x2A2BF10
	private void GetTextureRect_Injected(out Rect ret) { }

	// RVA: 0x2A2BFC0 Offset: 0x2A2C0C1 VA: 0x2A2BFC0
	private void GetTextureRectOffset_Injected(out Vector2 ret) { }

	// RVA: 0x2A2C070 Offset: 0x2A2C171 VA: 0x2A2C070
	private void GetInnerUVs_Injected(out Vector4 ret) { }

	// RVA: 0x2A2C120 Offset: 0x2A2C221 VA: 0x2A2C120
	private void GetOuterUVs_Injected(out Vector4 ret) { }

	// RVA: 0x2A2C1D0 Offset: 0x2A2C2D1 VA: 0x2A2C1D0
	private void GetPadding_Injected(out Vector4 ret) { }

	// RVA: 0x2A2C290 Offset: 0x2A2C391 VA: 0x2A2C290
	private static Sprite CreateSpriteWithoutTextureScripting_Injected(ref Rect rect, ref Vector2 pivot, float pixelsToUnits, Texture2D texture) { }

	// RVA: 0x2A2C3B0 Offset: 0x2A2C4B1 VA: 0x2A2C3B0
	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x2A2C4C0 Offset: 0x2A2C5C1 VA: 0x2A2C4C0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x2A2C570 Offset: 0x2A2C671 VA: 0x2A2C570
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x2A2C620 Offset: 0x2A2C721 VA: 0x2A2C620
	private void get_border_Injected(out Vector4 ret) { }

	// RVA: 0x2A2C810 Offset: 0x2A2C911 VA: 0x2A2C810
	private void get_pivot_Injected(out Vector2 ret) { }
}

