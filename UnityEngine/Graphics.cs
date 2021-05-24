[NativeHeaderAttribute] // RVA: 0xC4AE0 Offset: 0xC4BE1 VA: 0xC4AE0
[NativeHeaderAttribute] // RVA: 0xC4AE0 Offset: 0xC4BE1 VA: 0xC4AE0
[NativeHeaderAttribute] // RVA: 0xC4AE0 Offset: 0xC4BE1 VA: 0xC4AE0
[NativeHeaderAttribute] // RVA: 0xC4AE0 Offset: 0xC4BE1 VA: 0xC4AE0
[NativeHeaderAttribute] // RVA: 0xC4AE0 Offset: 0xC4BE1 VA: 0xC4AE0
[NativeHeaderAttribute] // RVA: 0xC4AE0 Offset: 0xC4BE1 VA: 0xC4AE0
public class Graphics // TypeDefIndex: 2874
{
	// Fields
	internal static readonly int kMaxDrawMeshInstanceCount; // 0x0

	// Properties
	[StaticAccessorAttribute] // RVA: 0xDE310 Offset: 0xDE411 VA: 0xDE310
	public static GraphicsTier activeTier { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xCE190 Offset: 0xCE291 VA: 0xCE190
	// RVA: 0x1A29440 Offset: 0x1A29541 VA: 0x1A29440
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	// RVA: 0x1A29480 Offset: 0x1A29581 VA: 0x1A29480
	public static GraphicsTier get_activeTier() { }

	// RVA: 0x1A294C0 Offset: 0x1A295C1 VA: 0x1A294C0
	public static void set_activeTier(GraphicsTier value) { }

	[FreeFunctionAttribute] // RVA: 0xCE1D0 Offset: 0xCE2D1 VA: 0xCE1D0
	// RVA: 0x1A29510 Offset: 0x1A29611 VA: 0x1A29510
	private static void Internal_SetNullRT() { }

	[NativeMethodAttribute] // RVA: 0xCE210 Offset: 0xCE311 VA: 0xCE210
	// RVA: 0x1A29550 Offset: 0x1A29651 VA: 0x1A29550
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[FreeFunctionAttribute] // RVA: 0xCE260 Offset: 0xCE361 VA: 0xCE260
	// RVA: 0x1A29690 Offset: 0x1A29791 VA: 0x1A29690
	private static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	[StaticAccessorAttribute] // RVA: 0xCE2A0 Offset: 0xCE3A1 VA: 0xCE2A0
	// RVA: 0x1A296F0 Offset: 0x1A297F1 VA: 0x1A296F0
	public static void ClearRandomWriteTargets() { }

	[FreeFunctionAttribute] // RVA: 0xCE2E0 Offset: 0xCE3E1 VA: 0xCE2E0
	// RVA: 0x1A29730 Offset: 0x1A29831 VA: 0x1A29730
	private static void CopyTexture_Full(Texture src, Texture dst) { }

	[FreeFunctionAttribute] // RVA: 0xCE320 Offset: 0xCE421 VA: 0xCE320
	// RVA: 0x1A29780 Offset: 0x1A29881 VA: 0x1A29780
	private static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) { }

	[FreeFunctionAttribute] // RVA: 0xCE360 Offset: 0xCE461 VA: 0xCE360
	// RVA: 0x1A29800 Offset: 0x1A29901 VA: 0x1A29800
	private static void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY) { }

	[FreeFunctionAttribute] // RVA: 0xCE3A0 Offset: 0xCE4A1 VA: 0xCE3A0
	// RVA: 0x1A298D0 Offset: 0x1A299D1 VA: 0x1A298D0
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	[FreeFunctionAttribute] // RVA: 0xCE3E0 Offset: 0xCE4E1 VA: 0xCE3E0
	[VisibleToOtherModulesAttribute] // RVA: 0xCE3E0 Offset: 0xCE4E1 VA: 0xCE3E0
	// RVA: 0x1A299E0 Offset: 0x1A29AE1 VA: 0x1A299E0
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	[FreeFunctionAttribute] // RVA: 0xCE490 Offset: 0xCE591 VA: 0xCE490
	// RVA: 0x1A29A30 Offset: 0x1A29B31 VA: 0x1A29A30
	private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunctionAttribute] // RVA: 0xCE4D0 Offset: 0xCE5D1 VA: 0xCE4D0
	// RVA: 0x1A29C10 Offset: 0x1A29D11 VA: 0x1A29C10
	private static void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunctionAttribute] // RVA: 0xCE510 Offset: 0xCE611 VA: 0xCE510
	// RVA: 0x1A29CE0 Offset: 0x1A29DE1 VA: 0x1A29CE0
	private static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[FreeFunctionAttribute] // RVA: 0xCE550 Offset: 0xCE651 VA: 0xCE550
	// RVA: 0x1A29D40 Offset: 0x1A29E41 VA: 0x1A29D40
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	[FreeFunctionAttribute] // RVA: 0xCE590 Offset: 0xCE691 VA: 0xCE590
	// RVA: 0x1A29DB0 Offset: 0x1A29EB1 VA: 0x1A29DB0
	private static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[FreeFunctionAttribute] // RVA: 0xCE5D0 Offset: 0xCE6D1 VA: 0xCE5D0
	// RVA: 0x1A29E20 Offset: 0x1A29F21 VA: 0x1A29E20
	private static void Blit2(Texture source, RenderTexture dest) { }

	// RVA: 0x1A29E70 Offset: 0x1A29F71 VA: 0x1A29E70
	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x1A29FA0 Offset: 0x1A2A0A1 VA: 0x1A29FA0
	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x1A2A120 Offset: 0x1A2A221 VA: 0x1A2A120
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x1A2A1B0 Offset: 0x1A2A2B1 VA: 0x1A2A1B0
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	// RVA: 0x1A2A380 Offset: 0x1A2A481 VA: 0x1A2A380
	public static void CopyTexture(Texture src, Texture dst) { }

	// RVA: 0x1A2A430 Offset: 0x1A2A531 VA: 0x1A2A430
	public static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) { }

	// RVA: 0x1A2A510 Offset: 0x1A2A611 VA: 0x1A2A510
	public static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY) { }

	// RVA: 0x1A2A620 Offset: 0x1A2A721 VA: 0x1A2A620
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	// RVA: 0x1A2A7D0 Offset: 0x1A2A8D1 VA: 0x1A2A7D0
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	// RVA: 0x1A2A8A0 Offset: 0x1A2A9A1 VA: 0x1A2A8A0
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x1A2AAC0 Offset: 0x1A2ABC1 VA: 0x1A2AAC0
	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x1A2B030 Offset: 0x1A2B131 VA: 0x1A2B030
	public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset = 0) { }

	// RVA: 0x1A2B120 Offset: 0x1A2B221 VA: 0x1A2B120
	public static void Blit(Texture source, RenderTexture dest) { }

	// RVA: 0x1A2B1D0 Offset: 0x1A2B2D1 VA: 0x1A2B1D0
	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	// RVA: 0x1A2B290 Offset: 0x1A2B391 VA: 0x1A2B290
	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x1A2B3A0 Offset: 0x1A2B4A1 VA: 0x1A2B3A0
	public static void Blit(Texture source, Material mat, int pass) { }

	// RVA: 0x1A2B460 Offset: 0x1A2B561 VA: 0x1A2B460
	public static void Blit(Texture source, Material mat) { }

	// RVA: 0x1A2B560 Offset: 0x1A2B661 VA: 0x1A2B560
	public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[ExcludeFromDocsAttribute] // RVA: 0xCE610 Offset: 0xCE711 VA: 0xCE610
	// RVA: 0x1A2B680 Offset: 0x1A2B781 VA: 0x1A2B680
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) { }

	[ExcludeFromDocsAttribute] // RVA: 0xCE620 Offset: 0xCE721 VA: 0xCE620
	// RVA: 0x1A2B860 Offset: 0x1A2B961 VA: 0x1A2B860
	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer) { }

	[ExcludeFromDocsAttribute] // RVA: 0xCE630 Offset: 0xCE731 VA: 0xCE630
	// RVA: 0x1A2B940 Offset: 0x1A2BA41 VA: 0x1A2B940
	public static void SetRenderTarget(RenderTexture rt) { }

	[ExcludeFromDocsAttribute] // RVA: 0xCE640 Offset: 0xCE741 VA: 0xCE640
	// RVA: 0x1A2BA10 Offset: 0x1A2BB11 VA: 0x1A2BA10
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face) { }

	[ExcludeFromDocsAttribute] // RVA: 0xCE650 Offset: 0xCE751 VA: 0xCE650
	// RVA: 0x1A2BAF0 Offset: 0x1A2BBF1 VA: 0x1A2BAF0
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav) { }

	// RVA: 0x1A2BB70 Offset: 0x1A2BC71 VA: 0x1A2BB70
	private static void .cctor() { }

	// RVA: 0x1A29620 Offset: 0x1A29721 VA: 0x1A29620
	private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x1A29980 Offset: 0x1A29A81 VA: 0x1A29980
	private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix) { }

	// RVA: 0x1A29B40 Offset: 0x1A29C41 VA: 0x1A29B40
	private static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }
}

