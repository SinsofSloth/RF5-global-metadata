[NativeHeaderAttribute] // RVA: 0xC51D0 Offset: 0xC52D1 VA: 0xC51D0
[NativeHeaderAttribute] // RVA: 0xC51D0 Offset: 0xC52D1 VA: 0xC51D0
[NativeHeaderAttribute] // RVA: 0xC51D0 Offset: 0xC52D1 VA: 0xC51D0
[NativeHeaderAttribute] // RVA: 0xC51D0 Offset: 0xC52D1 VA: 0xC51D0
[NativeHeaderAttribute] // RVA: 0xC51D0 Offset: 0xC52D1 VA: 0xC51D0
[NativeHeaderAttribute] // RVA: 0xC51D0 Offset: 0xC52D1 VA: 0xC51D0
[NativeHeaderAttribute] // RVA: 0xC51D0 Offset: 0xC52D1 VA: 0xC51D0
public sealed class Shader : Object // TypeDefIndex: 2890
{
	// Properties
	[ObsoleteAttribute] // RVA: 0xDE770 Offset: 0xDE871 VA: 0xDE770
	public static ShaderHardwareTier globalShaderHardwareTier { get; set; }
	[NativePropertyAttribute] // RVA: 0xDE7B0 Offset: 0xDE8B1 VA: 0xDE7B0
	public int maximumLOD { get; set; }
	[NativePropertyAttribute] // RVA: 0xDE7F0 Offset: 0xDE8F1 VA: 0xDE7F0
	public static int globalMaximumLOD { get; set; }
	public bool isSupported { get; }
	public static string globalRenderPipeline { get; set; }
	public int renderQueue { get; }
	internal DisableBatchingType disableBatching { get; }
	public int passCount { get; }

	// Methods

	// RVA: 0x2A26FE0 Offset: 0x2A270E1 VA: 0x2A26FE0
	public static ShaderHardwareTier get_globalShaderHardwareTier() { }

	// RVA: 0x2A27050 Offset: 0x2A27151 VA: 0x2A27050
	public static void set_globalShaderHardwareTier(ShaderHardwareTier value) { }

	[FreeFunctionAttribute] // RVA: 0xCFA10 Offset: 0xCFB11 VA: 0xCFA10
	// RVA: 0x2A270C0 Offset: 0x2A271C1 VA: 0x2A270C0
	public static Shader Find(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCFA50 Offset: 0xCFB51 VA: 0xCFA50
	// RVA: 0x2A27110 Offset: 0x2A27211 VA: 0x2A27110
	internal static Shader FindBuiltin(string name) { }

	// RVA: 0x2A27160 Offset: 0x2A27261 VA: 0x2A27160
	public int get_maximumLOD() { }

	// RVA: 0x2A271B0 Offset: 0x2A272B1 VA: 0x2A271B0
	public void set_maximumLOD(int value) { }

	// RVA: 0x2A27200 Offset: 0x2A27301 VA: 0x2A27200
	public static int get_globalMaximumLOD() { }

	// RVA: 0x2A27240 Offset: 0x2A27341 VA: 0x2A27240
	public static void set_globalMaximumLOD(int value) { }

	[NativeMethodAttribute] // RVA: 0xCFA90 Offset: 0xCFB91 VA: 0xCFA90
	// RVA: 0x2A27290 Offset: 0x2A27391 VA: 0x2A27290
	public bool get_isSupported() { }

	// RVA: 0x2A272E0 Offset: 0x2A273E1 VA: 0x2A272E0
	public static string get_globalRenderPipeline() { }

	// RVA: 0x2A27320 Offset: 0x2A27421 VA: 0x2A27320
	public static void set_globalRenderPipeline(string value) { }

	[FreeFunctionAttribute] // RVA: 0xCFAD0 Offset: 0xCFBD1 VA: 0xCFAD0
	// RVA: 0x2A27370 Offset: 0x2A27471 VA: 0x2A27370
	public static void EnableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0xCFB10 Offset: 0xCFC11 VA: 0xCFB10
	// RVA: 0x2A273C0 Offset: 0x2A274C1 VA: 0x2A273C0
	public static void DisableKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0xCFB50 Offset: 0xCFC51 VA: 0xCFB50
	// RVA: 0x2A27410 Offset: 0x2A27511 VA: 0x2A27410
	public static bool IsKeywordEnabled(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0xCFB90 Offset: 0xCFC91 VA: 0xCFB90
	// RVA: 0x2A27460 Offset: 0x2A27561 VA: 0x2A27460
	public int get_renderQueue() { }

	[FreeFunctionAttribute] // RVA: 0xCFBE0 Offset: 0xCFCE1 VA: 0xCFBE0
	// RVA: 0x2A274B0 Offset: 0x2A275B1 VA: 0x2A274B0
	internal DisableBatchingType get_disableBatching() { }

	[FreeFunctionAttribute] // RVA: 0xCFC30 Offset: 0xCFD31 VA: 0xCFC30
	// RVA: 0x2A27500 Offset: 0x2A27601 VA: 0x2A27500
	public static void WarmupAllShaders() { }

	[FreeFunctionAttribute] // RVA: 0xCFC40 Offset: 0xCFD41 VA: 0xCFC40
	// RVA: 0x2A27540 Offset: 0x2A27641 VA: 0x2A27540
	internal static int TagToID(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCFC80 Offset: 0xCFD81 VA: 0xCFC80
	// RVA: 0x2A27590 Offset: 0x2A27691 VA: 0x2A27590
	internal static string IDToTag(int name) { }

	[FreeFunctionAttribute] // RVA: 0xCFCC0 Offset: 0xCFDC1 VA: 0xCFCC0
	// RVA: 0x2A275E0 Offset: 0x2A276E1 VA: 0x2A275E0
	public static int PropertyToID(string name) { }

	// RVA: 0x2A27630 Offset: 0x2A27731 VA: 0x2A27630
	public Shader GetDependency(string name) { }

	[FreeFunctionAttribute] // RVA: 0xCFD10 Offset: 0xCFE11 VA: 0xCFD10
	// RVA: 0x2A27680 Offset: 0x2A27781 VA: 0x2A27680
	public int get_passCount() { }

	// RVA: 0x2A276D0 Offset: 0x2A277D1 VA: 0x2A276D0
	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	[FreeFunctionAttribute] // RVA: 0xCFD60 Offset: 0xCFE61 VA: 0xCFD60
	// RVA: 0x2A277D0 Offset: 0x2A278D1 VA: 0x2A277D0
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunctionAttribute] // RVA: 0xCFDB0 Offset: 0xCFEB1 VA: 0xCFDB0
	// RVA: 0x2A27830 Offset: 0x2A27931 VA: 0x2A27830
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunctionAttribute] // RVA: 0xCFDF0 Offset: 0xCFEF1 VA: 0xCFDF0
	// RVA: 0x2A27880 Offset: 0x2A27981 VA: 0x2A27880
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0xCFE30 Offset: 0xCFF31 VA: 0xCFE30
	// RVA: 0x2A27930 Offset: 0x2A27A31 VA: 0x2A27930
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0xCFE70 Offset: 0xCFF71 VA: 0xCFE70
	// RVA: 0x2A279D0 Offset: 0x2A27AD1 VA: 0x2A279D0
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	[FreeFunctionAttribute] // RVA: 0xCFEB0 Offset: 0xCFFB1 VA: 0xCFEB0
	// RVA: 0x2A27A20 Offset: 0x2A27B21 VA: 0x2A27A20
	private static void SetGlobalRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0xCFEF0 Offset: 0xCFFF1 VA: 0xCFEF0
	// RVA: 0x2A27A80 Offset: 0x2A27B81 VA: 0x2A27A80
	private static void SetGlobalBufferImpl(int name, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0xCFF30 Offset: 0xD0031 VA: 0xCFF30
	// RVA: 0x2A27AD0 Offset: 0x2A27BD1 VA: 0x2A27AD0
	private static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[FreeFunctionAttribute] // RVA: 0xCFF70 Offset: 0xD0071 VA: 0xCFF70
	// RVA: 0x2A27B40 Offset: 0x2A27C41 VA: 0x2A27B40
	private static float GetGlobalFloatImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xCFFB0 Offset: 0xD00B1 VA: 0xCFFB0
	// RVA: 0x2A27B90 Offset: 0x2A27C91 VA: 0x2A27B90
	private static Vector4 GetGlobalVectorImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xCFFF0 Offset: 0xD00F1 VA: 0xCFFF0
	// RVA: 0x2A27C40 Offset: 0x2A27D41 VA: 0x2A27C40
	private static Matrix4x4 GetGlobalMatrixImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD0030 Offset: 0xD0131 VA: 0xD0030
	// RVA: 0x2A27D20 Offset: 0x2A27E21 VA: 0x2A27D20
	private static Texture GetGlobalTextureImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD0070 Offset: 0xD0171 VA: 0xD0070
	// RVA: 0x2A27D70 Offset: 0x2A27E71 VA: 0x2A27D70
	private static void SetGlobalFloatArrayImpl(int name, float[] values, int count) { }

	[FreeFunctionAttribute] // RVA: 0xD00B0 Offset: 0xD01B1 VA: 0xD00B0
	// RVA: 0x2A27DD0 Offset: 0x2A27ED1 VA: 0x2A27DD0
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	[FreeFunctionAttribute] // RVA: 0xD00F0 Offset: 0xD01F1 VA: 0xD00F0
	// RVA: 0x2A27E30 Offset: 0x2A27F31 VA: 0x2A27E30
	private static void SetGlobalMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[FreeFunctionAttribute] // RVA: 0xD0130 Offset: 0xD0231 VA: 0xD0130
	// RVA: 0x2A27E90 Offset: 0x2A27F91 VA: 0x2A27E90
	private static float[] GetGlobalFloatArrayImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD0170 Offset: 0xD0271 VA: 0xD0170
	// RVA: 0x2A27EE0 Offset: 0x2A27FE1 VA: 0x2A27EE0
	private static Vector4[] GetGlobalVectorArrayImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD01B0 Offset: 0xD02B1 VA: 0xD01B0
	// RVA: 0x2A27F30 Offset: 0x2A28031 VA: 0x2A27F30
	private static Matrix4x4[] GetGlobalMatrixArrayImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD01F0 Offset: 0xD02F1 VA: 0xD01F0
	// RVA: 0x2A27F80 Offset: 0x2A28081 VA: 0x2A27F80
	private static int GetGlobalFloatArrayCountImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD0230 Offset: 0xD0331 VA: 0xD0230
	// RVA: 0x2A27FD0 Offset: 0x2A280D1 VA: 0x2A27FD0
	private static int GetGlobalVectorArrayCountImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD0270 Offset: 0xD0371 VA: 0xD0270
	// RVA: 0x2A28020 Offset: 0x2A28121 VA: 0x2A28020
	private static int GetGlobalMatrixArrayCountImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD02B0 Offset: 0xD03B1 VA: 0xD02B0
	// RVA: 0x2A28070 Offset: 0x2A28171 VA: 0x2A28070
	private static void ExtractGlobalFloatArrayImpl(int name, [Out] float[] val) { }

	[FreeFunctionAttribute] // RVA: 0xD02F0 Offset: 0xD03F1 VA: 0xD02F0
	// RVA: 0x2A280C0 Offset: 0x2A281C1 VA: 0x2A280C0
	private static void ExtractGlobalVectorArrayImpl(int name, [Out] Vector4[] val) { }

	[FreeFunctionAttribute] // RVA: 0xD0330 Offset: 0xD0431 VA: 0xD0330
	// RVA: 0x2A28110 Offset: 0x2A28211 VA: 0x2A28110
	private static void ExtractGlobalMatrixArrayImpl(int name, [Out] Matrix4x4[] val) { }

	// RVA: 0x2A28160 Offset: 0x2A28261 VA: 0x2A28160
	private static void SetGlobalFloatArray(int name, float[] values, int count) { }

	// RVA: 0x2A28280 Offset: 0x2A28381 VA: 0x2A28280
	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x2A283A0 Offset: 0x2A284A1 VA: 0x2A283A0
	private static void SetGlobalMatrixArray(int name, Matrix4x4[] values, int count) { }

	// RVA: 0x2A284C0 Offset: 0x2A285C1 VA: 0x2A284C0
	private static void ExtractGlobalFloatArray(int name, List<float> values) { }

	// RVA: 0x2A28640 Offset: 0x2A28741 VA: 0x2A28640
	private static void ExtractGlobalVectorArray(int name, List<Vector4> values) { }

	// RVA: 0x2A287C0 Offset: 0x2A288C1 VA: 0x2A287C0
	private static void ExtractGlobalMatrixArray(int name, List<Matrix4x4> values) { }

	// RVA: 0x2A28940 Offset: 0x2A28A41 VA: 0x2A28940
	public static void SetGlobalFloat(string name, float value) { }

	// RVA: 0x2A289C0 Offset: 0x2A28AC1 VA: 0x2A289C0
	public static void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x2A28A10 Offset: 0x2A28B11 VA: 0x2A28A10
	public static void SetGlobalInt(string name, int value) { }

	// RVA: 0x2A28AA0 Offset: 0x2A28BA1 VA: 0x2A28AA0
	public static void SetGlobalInt(int nameID, int value) { }

	// RVA: 0x2A28AF0 Offset: 0x2A28BF1 VA: 0x2A28AF0
	public static void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x2A28BA0 Offset: 0x2A28CA1 VA: 0x2A28BA0
	public static void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x2A28C00 Offset: 0x2A28D01 VA: 0x2A28C00
	public static void SetGlobalColor(string name, Color value) { }

	// RVA: 0x2A28CC0 Offset: 0x2A28DC1 VA: 0x2A28CC0
	public static void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x2A28D20 Offset: 0x2A28E21 VA: 0x2A28D20
	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x2A28DD0 Offset: 0x2A28ED1 VA: 0x2A28DD0
	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x2A28E40 Offset: 0x2A28F41 VA: 0x2A28E40
	public static void SetGlobalTexture(string name, Texture value) { }

	// RVA: 0x2A28EC0 Offset: 0x2A28FC1 VA: 0x2A28EC0
	public static void SetGlobalTexture(int nameID, Texture value) { }

	// RVA: 0x2A28F10 Offset: 0x2A29011 VA: 0x2A28F10
	public static void SetGlobalTexture(string name, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0x2A28FA0 Offset: 0x2A290A1 VA: 0x2A28FA0
	public static void SetGlobalTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0x2A29000 Offset: 0x2A29101 VA: 0x2A29000
	public static void SetGlobalBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x2A29080 Offset: 0x2A29181 VA: 0x2A29080
	public static void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x2A290D0 Offset: 0x2A291D1 VA: 0x2A290D0
	public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	// RVA: 0x2A29140 Offset: 0x2A29241 VA: 0x2A29140
	public static void SetGlobalFloatArray(string name, List<float> values) { }

	// RVA: 0x2A291E0 Offset: 0x2A292E1 VA: 0x2A291E0
	public static void SetGlobalFloatArray(int nameID, List<float> values) { }

	// RVA: 0x2A29260 Offset: 0x2A29361 VA: 0x2A29260
	public static void SetGlobalFloatArray(string name, float[] values) { }

	// RVA: 0x2A292C0 Offset: 0x2A293C1 VA: 0x2A292C0
	public static void SetGlobalFloatArray(int nameID, float[] values) { }

	// RVA: 0x2A292E0 Offset: 0x2A293E1 VA: 0x2A292E0
	public static void SetGlobalVectorArray(string name, List<Vector4> values) { }

	// RVA: 0x2A29380 Offset: 0x2A29481 VA: 0x2A29380
	public static void SetGlobalVectorArray(int nameID, List<Vector4> values) { }

	// RVA: 0x2A29400 Offset: 0x2A29501 VA: 0x2A29400
	public static void SetGlobalVectorArray(string name, Vector4[] values) { }

	// RVA: 0x2A29460 Offset: 0x2A29561 VA: 0x2A29460
	public static void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	// RVA: 0x2A29480 Offset: 0x2A29581 VA: 0x2A29480
	public static void SetGlobalMatrixArray(string name, List<Matrix4x4> values) { }

	// RVA: 0x2A29520 Offset: 0x2A29621 VA: 0x2A29520
	public static void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	// RVA: 0x2A295A0 Offset: 0x2A296A1 VA: 0x2A295A0
	public static void SetGlobalMatrixArray(string name, Matrix4x4[] values) { }

	// RVA: 0x2A29600 Offset: 0x2A29701 VA: 0x2A29600
	public static void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	// RVA: 0x2A29620 Offset: 0x2A29721 VA: 0x2A29620
	public static float GetGlobalFloat(string name) { }

	// RVA: 0x2A296A0 Offset: 0x2A297A1 VA: 0x2A296A0
	public static float GetGlobalFloat(int nameID) { }

	// RVA: 0x2A296F0 Offset: 0x2A297F1 VA: 0x2A296F0
	public static int GetGlobalInt(string name) { }

	// RVA: 0x2A29770 Offset: 0x2A29871 VA: 0x2A29770
	public static int GetGlobalInt(int nameID) { }

	// RVA: 0x2A297C0 Offset: 0x2A298C1 VA: 0x2A297C0
	public static Vector4 GetGlobalVector(string name) { }

	// RVA: 0x2A29850 Offset: 0x2A29951 VA: 0x2A29850
	public static Vector4 GetGlobalVector(int nameID) { }

	// RVA: 0x2A298B0 Offset: 0x2A299B1 VA: 0x2A298B0
	public static Color GetGlobalColor(string name) { }

	// RVA: 0x2A29940 Offset: 0x2A29A41 VA: 0x2A29940
	public static Color GetGlobalColor(int nameID) { }

	// RVA: 0x2A299B0 Offset: 0x2A29AB1 VA: 0x2A299B0
	public static Matrix4x4 GetGlobalMatrix(string name) { }

	// RVA: 0x2A29AA0 Offset: 0x2A29BA1 VA: 0x2A29AA0
	public static Matrix4x4 GetGlobalMatrix(int nameID) { }

	// RVA: 0x2A29B60 Offset: 0x2A29C61 VA: 0x2A29B60
	public static Texture GetGlobalTexture(string name) { }

	// RVA: 0x2A29BE0 Offset: 0x2A29CE1 VA: 0x2A29BE0
	public static Texture GetGlobalTexture(int nameID) { }

	// RVA: 0x2A29C30 Offset: 0x2A29D31 VA: 0x2A29C30
	public static float[] GetGlobalFloatArray(string name) { }

	// RVA: 0x2A29D00 Offset: 0x2A29E01 VA: 0x2A29D00
	public static float[] GetGlobalFloatArray(int nameID) { }

	// RVA: 0x2A29DA0 Offset: 0x2A29EA1 VA: 0x2A29DA0
	public static Vector4[] GetGlobalVectorArray(string name) { }

	// RVA: 0x2A29E70 Offset: 0x2A29F71 VA: 0x2A29E70
	public static Vector4[] GetGlobalVectorArray(int nameID) { }

	// RVA: 0x2A29F10 Offset: 0x2A2A011 VA: 0x2A29F10
	public static Matrix4x4[] GetGlobalMatrixArray(string name) { }

	// RVA: 0x2A29FE0 Offset: 0x2A2A0E1 VA: 0x2A29FE0
	public static Matrix4x4[] GetGlobalMatrixArray(int nameID) { }

	// RVA: 0x2A2A080 Offset: 0x2A2A181 VA: 0x2A2A080
	public static void GetGlobalFloatArray(string name, List<float> values) { }

	// RVA: 0x2A2A0E0 Offset: 0x2A2A1E1 VA: 0x2A2A0E0
	public static void GetGlobalFloatArray(int nameID, List<float> values) { }

	// RVA: 0x2A2A0F0 Offset: 0x2A2A1F1 VA: 0x2A2A0F0
	public static void GetGlobalVectorArray(string name, List<Vector4> values) { }

	// RVA: 0x2A2A150 Offset: 0x2A2A251 VA: 0x2A2A150
	public static void GetGlobalVectorArray(int nameID, List<Vector4> values) { }

	// RVA: 0x2A2A160 Offset: 0x2A2A261 VA: 0x2A2A160
	public static void GetGlobalMatrixArray(string name, List<Matrix4x4> values) { }

	// RVA: 0x2A2A1C0 Offset: 0x2A2A2C1 VA: 0x2A2A1C0
	public static void GetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	// RVA: 0x2A2A1D0 Offset: 0x2A2A2D1 VA: 0x2A2A1D0
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xD0370 Offset: 0xD0471 VA: 0xD0370
	// RVA: 0x2A2A240 Offset: 0x2A2A341 VA: 0x2A2A240
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD03B0 Offset: 0xD04B1 VA: 0xD03B0
	// RVA: 0x2A2A290 Offset: 0x2A2A391 VA: 0x2A2A290
	private static int GetPropertyNameId(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD03F0 Offset: 0xD04F1 VA: 0xD03F0
	// RVA: 0x2A2A2E0 Offset: 0x2A2A3E1 VA: 0x2A2A2E0
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD0430 Offset: 0xD0531 VA: 0xD0430
	// RVA: 0x2A2A330 Offset: 0x2A2A431 VA: 0x2A2A330
	private static string GetPropertyDescription(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD0470 Offset: 0xD0571 VA: 0xD0470
	// RVA: 0x2A2A380 Offset: 0x2A2A481 VA: 0x2A2A380
	private static ShaderPropertyFlags GetPropertyFlags(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD04B0 Offset: 0xD05B1 VA: 0xD04B0
	// RVA: 0x2A2A3D0 Offset: 0x2A2A4D1 VA: 0x2A2A3D0
	private static string[] GetPropertyAttributes(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD04F0 Offset: 0xD05F1 VA: 0xD04F0
	// RVA: 0x2A2A420 Offset: 0x2A2A521 VA: 0x2A2A420
	private static Vector4 GetPropertyDefaultValue(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD0530 Offset: 0xD0631 VA: 0xD0530
	// RVA: 0x2A2A4F0 Offset: 0x2A2A5F1 VA: 0x2A2A4F0
	private static TextureDimension GetPropertyTextureDimension(Shader shader, int propertyIndex) { }

	[FreeFunctionAttribute] // RVA: 0xD0570 Offset: 0xD0671 VA: 0xD0570
	// RVA: 0x2A2A540 Offset: 0x2A2A641 VA: 0x2A2A540
	private static string GetPropertyTextureDefaultName(Shader shader, int propertyIndex) { }

	// RVA: 0x2A2A590 Offset: 0x2A2A691 VA: 0x2A2A590
	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	// RVA: 0x2A2A660 Offset: 0x2A2A761 VA: 0x2A2A660
	public int GetPropertyCount() { }

	// RVA: 0x2A2A6B0 Offset: 0x2A2A7B1 VA: 0x2A2A6B0
	public int FindPropertyIndex(string propertyName) { }

	// RVA: 0x2A2A700 Offset: 0x2A2A801 VA: 0x2A2A700
	public string GetPropertyName(int propertyIndex) { }

	// RVA: 0x2A2A760 Offset: 0x2A2A861 VA: 0x2A2A760
	public int GetPropertyNameId(int propertyIndex) { }

	// RVA: 0x2A2A7C0 Offset: 0x2A2A8C1 VA: 0x2A2A7C0
	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	// RVA: 0x2A2A820 Offset: 0x2A2A921 VA: 0x2A2A820
	public string GetPropertyDescription(int propertyIndex) { }

	// RVA: 0x2A2A880 Offset: 0x2A2A981 VA: 0x2A2A880
	public ShaderPropertyFlags GetPropertyFlags(int propertyIndex) { }

	// RVA: 0x2A2A8E0 Offset: 0x2A2A9E1 VA: 0x2A2A8E0
	public string[] GetPropertyAttributes(int propertyIndex) { }

	// RVA: 0x2A2A940 Offset: 0x2A2AA41 VA: 0x2A2A940
	public float GetPropertyDefaultFloatValue(int propertyIndex) { }

	// RVA: 0x2A2AA80 Offset: 0x2A2AB81 VA: 0x2A2AA80
	public Vector4 GetPropertyDefaultVectorValue(int propertyIndex) { }

	// RVA: 0x2A2ABA0 Offset: 0x2A2ACA1 VA: 0x2A2ABA0
	public Vector2 GetPropertyRangeLimits(int propertyIndex) { }

	// RVA: 0x2A2AD10 Offset: 0x2A2AE11 VA: 0x2A2AD10
	public TextureDimension GetPropertyTextureDimension(int propertyIndex) { }

	// RVA: 0x2A2AE10 Offset: 0x2A2AF11 VA: 0x2A2AE10
	public string GetPropertyTextureDefaultName(int propertyIndex) { }

	// RVA: 0x2A278E0 Offset: 0x2A279E1 VA: 0x2A278E0
	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x2A27980 Offset: 0x2A27A81 VA: 0x2A27980
	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x2A27BF0 Offset: 0x2A27CF1 VA: 0x2A27BF0
	private static void GetGlobalVectorImpl_Injected(int name, out Vector4 ret) { }

	// RVA: 0x2A27CD0 Offset: 0x2A27DD1 VA: 0x2A27CD0
	private static void GetGlobalMatrixImpl_Injected(int name, out Matrix4x4 ret) { }

	// RVA: 0x2A2A490 Offset: 0x2A2A591 VA: 0x2A2A490
	private static void GetPropertyDefaultValue_Injected(Shader shader, int propertyIndex, out Vector4 ret) { }
}

