[NativeHeaderAttribute] // RVA: 0x103090 Offset: 0x103191 VA: 0x103090
[NativeClassAttribute] // RVA: 0x103090 Offset: 0x103191 VA: 0x103090
public sealed class CanvasRenderer : Component // TypeDefIndex: 3695
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x103310 Offset: 0x103411 VA: 0x103310
	[DebuggerBrowsableAttribute] // RVA: 0x103310 Offset: 0x103411 VA: 0x103310
	private bool <isMask>k__BackingField; // 0x18

	// Properties
	public bool hasPopInstruction { get; set; }
	public int materialCount { get; set; }
	public int popMaterialCount { get; set; }
	public int absoluteDepth { get; }
	public bool hasMoved { get; }
	public bool cullTransparentMesh { get; set; }
	[NativePropertyAttribute] // RVA: 0x103710 Offset: 0x103811 VA: 0x103710
	public bool hasRectClipping { get; }
	[NativePropertyAttribute] // RVA: 0x103750 Offset: 0x103851 VA: 0x103750
	public int relativeDepth { get; }
	[NativePropertyAttribute] // RVA: 0x103790 Offset: 0x103891 VA: 0x103790
	public bool cull { get; set; }
	[ObsoleteAttribute] // RVA: 0x1037D0 Offset: 0x1038D1 VA: 0x1037D0
	public bool isMask { get; set; }
	public Vector2 clippingSoftness { get; set; }

	// Methods

	// RVA: 0x1BC0200 Offset: 0x1BC0301 VA: 0x1BC0200
	public bool get_hasPopInstruction() { }

	// RVA: 0x1BC0250 Offset: 0x1BC0351 VA: 0x1BC0250
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x1BC02A0 Offset: 0x1BC03A1 VA: 0x1BC02A0
	public int get_materialCount() { }

	// RVA: 0x1BC02F0 Offset: 0x1BC03F1 VA: 0x1BC02F0
	public void set_materialCount(int value) { }

	// RVA: 0x1BC0340 Offset: 0x1BC0441 VA: 0x1BC0340
	public int get_popMaterialCount() { }

	// RVA: 0x1BC0390 Offset: 0x1BC0491 VA: 0x1BC0390
	public void set_popMaterialCount(int value) { }

	// RVA: 0x1BC03E0 Offset: 0x1BC04E1 VA: 0x1BC03E0
	public int get_absoluteDepth() { }

	// RVA: 0x1BC0430 Offset: 0x1BC0531 VA: 0x1BC0430
	public bool get_hasMoved() { }

	// RVA: 0x1BC0480 Offset: 0x1BC0581 VA: 0x1BC0480
	public bool get_cullTransparentMesh() { }

	// RVA: 0x1BC04D0 Offset: 0x1BC05D1 VA: 0x1BC04D0
	public void set_cullTransparentMesh(bool value) { }

	// RVA: 0x1BC0520 Offset: 0x1BC0621 VA: 0x1BC0520
	public bool get_hasRectClipping() { }

	// RVA: 0x1BC0570 Offset: 0x1BC0671 VA: 0x1BC0570
	public int get_relativeDepth() { }

	// RVA: 0x1BC05C0 Offset: 0x1BC06C1 VA: 0x1BC05C0
	public bool get_cull() { }

	// RVA: 0x1BC0610 Offset: 0x1BC0711 VA: 0x1BC0610
	public void set_cull(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x103390 Offset: 0x103491 VA: 0x103390
	// RVA: 0x1BC0660 Offset: 0x1BC0761 VA: 0x1BC0660
	public bool get_isMask() { }

	[CompilerGeneratedAttribute] // RVA: 0x1033A0 Offset: 0x1034A1 VA: 0x1033A0
	// RVA: 0x1BC0670 Offset: 0x1BC0771 VA: 0x1BC0670
	public void set_isMask(bool value) { }

	// RVA: 0x1BC0680 Offset: 0x1BC0781 VA: 0x1BC0680
	public void SetColor(Color color) { }

	// RVA: 0x1BC0730 Offset: 0x1BC0831 VA: 0x1BC0730
	public Color GetColor() { }

	// RVA: 0x1BC07E0 Offset: 0x1BC08E1 VA: 0x1BC07E0
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x1BC0890 Offset: 0x1BC0991 VA: 0x1BC0890
	public Vector2 get_clippingSoftness() { }

	// RVA: 0x1BC0940 Offset: 0x1BC0A41 VA: 0x1BC0940
	public void set_clippingSoftness(Vector2 value) { }

	// RVA: 0x1BC09F0 Offset: 0x1BC0AF1 VA: 0x1BC09F0
	public void DisableRectClipping() { }

	// RVA: 0x1BC0A40 Offset: 0x1BC0B41 VA: 0x1BC0A40
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x1BC0AA0 Offset: 0x1BC0BA1 VA: 0x1BC0AA0
	public Material GetMaterial(int index) { }

	// RVA: 0x1BC0AF0 Offset: 0x1BC0BF1 VA: 0x1BC0AF0
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x1BC0B50 Offset: 0x1BC0C51 VA: 0x1BC0B50
	public Material GetPopMaterial(int index) { }

	// RVA: 0x1BC0BA0 Offset: 0x1BC0CA1 VA: 0x1BC0BA0
	public void SetTexture(Texture texture) { }

	// RVA: 0x1BC0BF0 Offset: 0x1BC0CF1 VA: 0x1BC0BF0
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x1BC0C40 Offset: 0x1BC0D41 VA: 0x1BC0C40
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x1BC0C90 Offset: 0x1BC0D91 VA: 0x1BC0C90
	public void Clear() { }

	// RVA: 0x1BC0CE0 Offset: 0x1BC0DE1 VA: 0x1BC0CE0
	public float GetAlpha() { }

	// RVA: 0x1BC0D40 Offset: 0x1BC0E41 VA: 0x1BC0D40
	public void SetAlpha(float alpha) { }

	// RVA: 0x1BC0DE0 Offset: 0x1BC0EE1 VA: 0x1BC0DE0
	public float GetInheritedAlpha() { }

	// RVA: 0x1BC0E30 Offset: 0x1BC0F31 VA: 0x1BC0E30
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x1BC0F70 Offset: 0x1BC1071 VA: 0x1BC0F70
	public Material GetMaterial() { }

	// RVA: 0x1BC0FC0 Offset: 0x1BC10C1 VA: 0x1BC0FC0
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x1BC10F0 Offset: 0x1BC11F1 VA: 0x1BC10F0
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x1BC12C0 Offset: 0x1BC13C1 VA: 0x1BC12C0
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x1BC13C0 Offset: 0x1BC14C1 VA: 0x1BC13C0
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x1BC1520 Offset: 0x1BC1621 VA: 0x1BC1520
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector3> normals, List<Vector4> tangents) { }

	// RVA: 0x1BC1620 Offset: 0x1BC1721 VA: 0x1BC1620
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector2> uv0S, List<Vector2> uv1S, List<Vector2> uv2S, List<Vector2> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[ObsoleteAttribute] // RVA: 0x1033B0 Offset: 0x1034B1 VA: 0x1033B0
	// RVA: 0x1BC16C0 Offset: 0x1BC17C1 VA: 0x1BC16C0
	public void SetVertices(List<UIVertex> vertices) { }

	[ObsoleteAttribute] // RVA: 0x1033F0 Offset: 0x1034F1 VA: 0x1033F0
	// RVA: 0x1BC1740 Offset: 0x1BC1841 VA: 0x1BC1740
	public void SetVertices(UIVertex[] vertices, int size) { }

	[StaticAccessorAttribute] // RVA: 0x103430 Offset: 0x103531 VA: 0x103430
	// RVA: 0x1BC1270 Offset: 0x1BC1371 VA: 0x1BC1270
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[StaticAccessorAttribute] // RVA: 0x103470 Offset: 0x103571 VA: 0x103470
	// RVA: 0x1BC11D0 Offset: 0x1BC12D1 VA: 0x1BC11D0
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	[StaticAccessorAttribute] // RVA: 0x1034B0 Offset: 0x1035B1 VA: 0x1034B0
	// RVA: 0x1BC1470 Offset: 0x1BC1571 VA: 0x1BC1470
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x1BC1C00 Offset: 0x1BC1D01 VA: 0x1BC1C00
	public void .ctor() { }

	// RVA: 0x1BC06E0 Offset: 0x1BC07E1 VA: 0x1BC06E0
	private void SetColor_Injected(ref Color color) { }

	// RVA: 0x1BC0790 Offset: 0x1BC0891 VA: 0x1BC0790
	private void GetColor_Injected(out Color ret) { }

	// RVA: 0x1BC0840 Offset: 0x1BC0941 VA: 0x1BC0840
	private void EnableRectClipping_Injected(ref Rect rect) { }

	// RVA: 0x1BC08F0 Offset: 0x1BC09F1 VA: 0x1BC08F0
	private void get_clippingSoftness_Injected(out Vector2 ret) { }

	// RVA: 0x1BC09A0 Offset: 0x1BC0AA1 VA: 0x1BC09A0
	private void set_clippingSoftness_Injected(ref Vector2 value) { }
}

