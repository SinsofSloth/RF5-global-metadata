[NativeHeaderAttribute] // RVA: 0xC52F0 Offset: 0xC53F1 VA: 0xC52F0
[NativeHeaderAttribute] // RVA: 0xC52F0 Offset: 0xC53F1 VA: 0xC52F0
public class Material : Object // TypeDefIndex: 2891
{
	// Properties
	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; set; }
	public Vector2 mainTextureOffset { get; set; }
	public Vector2 mainTextureScale { get; set; }
	public int renderQueue { get; set; }
	internal int rawRenderQueue { get; }
	public MaterialGlobalIlluminationFlags globalIlluminationFlags { get; set; }
	public bool doubleSidedGI { get; set; }
	[NativePropertyAttribute] // RVA: 0xDE830 Offset: 0xDE931 VA: 0xDE830
	public bool enableInstancing { get; set; }
	public int passCount { get; }
	public string[] shaderKeywords { get; set; }

	// Methods

	[ObsoleteAttribute] // RVA: 0xD05B0 Offset: 0xD06B1 VA: 0xD05B0
	// RVA: 0x1A31920 Offset: 0x1A31A21 VA: 0x1A31920
	public static Material Create(string scriptContents) { }

	[FreeFunctionAttribute] // RVA: 0xD05F0 Offset: 0xD06F1 VA: 0xD05F0
	// RVA: 0x1A31A90 Offset: 0x1A31B91 VA: 0x1A31A90
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunctionAttribute] // RVA: 0xD0630 Offset: 0xD0731 VA: 0xD0630
	// RVA: 0x1A31AE0 Offset: 0x1A31BE1 VA: 0x1A31AE0
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunctionAttribute] // RVA: 0xD0670 Offset: 0xD0771 VA: 0xD0670
	// RVA: 0x1A31B30 Offset: 0x1A31C31 VA: 0x1A31B30
	private static void CreateWithString(Material self) { }

	// RVA: 0x1A31B80 Offset: 0x1A31C81 VA: 0x1A31B80
	public void .ctor(Shader shader) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD06B0 Offset: 0xD07B1 VA: 0xD06B0
	// RVA: 0x1A31C20 Offset: 0x1A31D21 VA: 0x1A31C20
	public void .ctor(Material source) { }

	[EditorBrowsableAttribute] // RVA: 0xD06C0 Offset: 0xD07C1 VA: 0xD06C0
	[ObsoleteAttribute] // RVA: 0xD06C0 Offset: 0xD07C1 VA: 0xD06C0
	// RVA: 0x1A319F0 Offset: 0x1A31AF1 VA: 0x1A319F0
	public void .ctor(string contents) { }

	// RVA: 0x1A31CC0 Offset: 0x1A31DC1 VA: 0x1A31CC0
	internal static Material GetDefaultMaterial() { }

	// RVA: 0x1A31D00 Offset: 0x1A31E01 VA: 0x1A31D00
	internal static Material GetDefaultParticleMaterial() { }

	// RVA: 0x1A31D40 Offset: 0x1A31E41 VA: 0x1A31D40
	internal static Material GetDefaultLineMaterial() { }

	// RVA: 0x1A31D80 Offset: 0x1A31E81 VA: 0x1A31D80
	public Shader get_shader() { }

	// RVA: 0x1A31DD0 Offset: 0x1A31ED1 VA: 0x1A31DD0
	public void set_shader(Shader value) { }

	// RVA: 0x1A31E20 Offset: 0x1A31F21 VA: 0x1A31E20
	public Color get_color() { }

	// RVA: 0x1A32060 Offset: 0x1A32161 VA: 0x1A32060
	public void set_color(Color value) { }

	// RVA: 0x1A32280 Offset: 0x1A32381 VA: 0x1A32280
	public Texture get_mainTexture() { }

	// RVA: 0x1A32420 Offset: 0x1A32521 VA: 0x1A32420
	public void set_mainTexture(Texture value) { }

	// RVA: 0x1A325E0 Offset: 0x1A326E1 VA: 0x1A325E0
	public Vector2 get_mainTextureOffset() { }

	// RVA: 0x1A32800 Offset: 0x1A32901 VA: 0x1A32800
	public void set_mainTextureOffset(Vector2 value) { }

	// RVA: 0x1A329E0 Offset: 0x1A32AE1 VA: 0x1A329E0
	public Vector2 get_mainTextureScale() { }

	// RVA: 0x1A32C00 Offset: 0x1A32D01 VA: 0x1A32C00
	public void set_mainTextureScale(Vector2 value) { }

	[NativeNameAttribute] // RVA: 0xD0720 Offset: 0xD0821 VA: 0xD0720
	// RVA: 0x1A31F20 Offset: 0x1A32021 VA: 0x1A31F20
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeNameAttribute] // RVA: 0xD0760 Offset: 0xD0861 VA: 0xD0760
	// RVA: 0x1A32DE0 Offset: 0x1A32EE1 VA: 0x1A32DE0
	public bool HasProperty(int nameID) { }

	// RVA: 0x1A32E30 Offset: 0x1A32F31 VA: 0x1A32E30
	public bool HasProperty(string name) { }

	[NativeNameAttribute] // RVA: 0xD07A0 Offset: 0xD08A1 VA: 0xD07A0
	// RVA: 0x1A32E90 Offset: 0x1A32F91 VA: 0x1A32E90
	public int get_renderQueue() { }

	[NativeNameAttribute] // RVA: 0xD07E0 Offset: 0xD08E1 VA: 0xD07E0
	// RVA: 0x1A32EE0 Offset: 0x1A32FE1 VA: 0x1A32EE0
	public void set_renderQueue(int value) { }

	[NativeNameAttribute] // RVA: 0xD0820 Offset: 0xD0921 VA: 0xD0820
	// RVA: 0x1A32F30 Offset: 0x1A33031 VA: 0x1A32F30
	internal int get_rawRenderQueue() { }

	// RVA: 0x1A32F80 Offset: 0x1A33081 VA: 0x1A32F80
	public void EnableKeyword(string keyword) { }

	// RVA: 0x1A32FD0 Offset: 0x1A330D1 VA: 0x1A32FD0
	public void DisableKeyword(string keyword) { }

	// RVA: 0x1A33020 Offset: 0x1A33121 VA: 0x1A33020
	public bool IsKeywordEnabled(string keyword) { }

	// RVA: 0x1A33070 Offset: 0x1A33171 VA: 0x1A33070
	public MaterialGlobalIlluminationFlags get_globalIlluminationFlags() { }

	// RVA: 0x1A330C0 Offset: 0x1A331C1 VA: 0x1A330C0
	public void set_globalIlluminationFlags(MaterialGlobalIlluminationFlags value) { }

	// RVA: 0x1A33110 Offset: 0x1A33211 VA: 0x1A33110
	public bool get_doubleSidedGI() { }

	// RVA: 0x1A33160 Offset: 0x1A33261 VA: 0x1A33160
	public void set_doubleSidedGI(bool value) { }

	// RVA: 0x1A2AFD0 Offset: 0x1A2B0D1 VA: 0x1A2AFD0
	public bool get_enableInstancing() { }

	// RVA: 0x1A331B0 Offset: 0x1A332B1 VA: 0x1A331B0
	public void set_enableInstancing(bool value) { }

	// RVA: 0x1A33200 Offset: 0x1A33301 VA: 0x1A33200
	public int get_passCount() { }

	[FreeFunctionAttribute] // RVA: 0xD0860 Offset: 0xD0961 VA: 0xD0860
	// RVA: 0x1A33250 Offset: 0x1A33351 VA: 0x1A33250
	public void SetShaderPassEnabled(string passName, bool enabled) { }

	[FreeFunctionAttribute] // RVA: 0xD08B0 Offset: 0xD09B1 VA: 0xD08B0
	// RVA: 0x1A332B0 Offset: 0x1A333B1 VA: 0x1A332B0
	public bool GetShaderPassEnabled(string passName) { }

	// RVA: 0x1A33300 Offset: 0x1A33401 VA: 0x1A33300
	public string GetPassName(int pass) { }

	// RVA: 0x1A33350 Offset: 0x1A33451 VA: 0x1A33350
	public int FindPass(string passName) { }

	// RVA: 0x1A333A0 Offset: 0x1A334A1 VA: 0x1A333A0
	public void SetOverrideTag(string tag, string val) { }

	[NativeNameAttribute] // RVA: 0xD0900 Offset: 0xD0A01 VA: 0xD0900
	// RVA: 0x1A33400 Offset: 0x1A33501 VA: 0x1A33400
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	// RVA: 0x1A33470 Offset: 0x1A33571 VA: 0x1A33470
	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	// RVA: 0x1A334E0 Offset: 0x1A335E1 VA: 0x1A334E0
	public string GetTag(string tag, bool searchFallbacks) { }

	[FreeFunctionAttribute] // RVA: 0xD0940 Offset: 0xD0A41 VA: 0xD0940
	[NativeThrowsAttribute] // RVA: 0xD0940 Offset: 0xD0A41 VA: 0xD0940
	// RVA: 0x1A33580 Offset: 0x1A33681 VA: 0x1A33580
	public void Lerp(Material start, Material end, float t) { }

	[FreeFunctionAttribute] // RVA: 0xD09A0 Offset: 0xD0AA1 VA: 0xD09A0
	// RVA: 0x1A335F0 Offset: 0x1A336F1 VA: 0x1A335F0
	public bool SetPass(int pass) { }

	[FreeFunctionAttribute] // RVA: 0xD09F0 Offset: 0xD0AF1 VA: 0xD09F0
	// RVA: 0x1A33640 Offset: 0x1A33741 VA: 0x1A33640
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunctionAttribute] // RVA: 0xD0A40 Offset: 0xD0B41 VA: 0xD0A40
	// RVA: 0x1A33690 Offset: 0x1A33791 VA: 0x1A33690
	private string[] GetShaderKeywords() { }

	[FreeFunctionAttribute] // RVA: 0xD0A90 Offset: 0xD0B91 VA: 0xD0A90
	// RVA: 0x1A336E0 Offset: 0x1A337E1 VA: 0x1A336E0
	private void SetShaderKeywords(string[] names) { }

	// RVA: 0x1A33730 Offset: 0x1A33831 VA: 0x1A33730
	public string[] get_shaderKeywords() { }

	// RVA: 0x1A33780 Offset: 0x1A33881 VA: 0x1A33780
	public void set_shaderKeywords(string[] value) { }

	// RVA: 0x1A337D0 Offset: 0x1A338D1 VA: 0x1A337D0
	public int ComputeCRC() { }

	[FreeFunctionAttribute] // RVA: 0xD0AE0 Offset: 0xD0BE1 VA: 0xD0AE0
	// RVA: 0x1A33820 Offset: 0x1A33921 VA: 0x1A33820
	public string[] GetTexturePropertyNames() { }

	[FreeFunctionAttribute] // RVA: 0xD0B30 Offset: 0xD0C31 VA: 0xD0B30
	// RVA: 0x1A33870 Offset: 0x1A33971 VA: 0x1A33870
	public int[] GetTexturePropertyNameIDs() { }

	[FreeFunctionAttribute] // RVA: 0xD0B80 Offset: 0xD0C81 VA: 0xD0B80
	// RVA: 0x1A338C0 Offset: 0x1A339C1 VA: 0x1A338C0
	private void GetTexturePropertyNamesInternal(object outNames) { }

	[FreeFunctionAttribute] // RVA: 0xD0BD0 Offset: 0xD0CD1 VA: 0xD0BD0
	// RVA: 0x1A33910 Offset: 0x1A33A11 VA: 0x1A33910
	private void GetTexturePropertyNameIDsInternal(object outNames) { }

	// RVA: 0x1A33960 Offset: 0x1A33A61 VA: 0x1A33960
	public void GetTexturePropertyNames(List<string> outNames) { }

	// RVA: 0x1A339B0 Offset: 0x1A33AB1 VA: 0x1A339B0
	public void GetTexturePropertyNameIDs(List<int> outNames) { }

	[NativeNameAttribute] // RVA: 0xD0C20 Offset: 0xD0D21 VA: 0xD0C20
	// RVA: 0x1A33A00 Offset: 0x1A33B01 VA: 0x1A33A00
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0xD0C60 Offset: 0xD0D61 VA: 0xD0C60
	// RVA: 0x1A33A60 Offset: 0x1A33B61 VA: 0x1A33A60
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0xD0CA0 Offset: 0xD0DA1 VA: 0xD0CA0
	// RVA: 0x1A33B30 Offset: 0x1A33C31 VA: 0x1A33B30
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0xD0CE0 Offset: 0xD0DE1 VA: 0xD0CE0
	// RVA: 0x1A33BF0 Offset: 0x1A33CF1 VA: 0x1A33BF0
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0xD0D20 Offset: 0xD0E21 VA: 0xD0D20
	// RVA: 0x1A33C50 Offset: 0x1A33D51 VA: 0x1A33C50
	private void SetRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	[NativeNameAttribute] // RVA: 0xD0D60 Offset: 0xD0E61 VA: 0xD0D60
	// RVA: 0x1A33CC0 Offset: 0x1A33DC1 VA: 0x1A33CC0
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeNameAttribute] // RVA: 0xD0DA0 Offset: 0xD0EA1 VA: 0xD0DA0
	// RVA: 0x1A33D20 Offset: 0x1A33E21 VA: 0x1A33D20
	private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[NativeNameAttribute] // RVA: 0xD0DE0 Offset: 0xD0EE1 VA: 0xD0DE0
	// RVA: 0x1A33D90 Offset: 0x1A33E91 VA: 0x1A33D90
	private float GetFloatImpl(int name) { }

	[NativeNameAttribute] // RVA: 0xD0E20 Offset: 0xD0F21 VA: 0xD0E20
	// RVA: 0x1A33DE0 Offset: 0x1A33EE1 VA: 0x1A33DE0
	private Color GetColorImpl(int name) { }

	[NativeNameAttribute] // RVA: 0xD0E60 Offset: 0xD0F61 VA: 0xD0E60
	// RVA: 0x1A33EB0 Offset: 0x1A33FB1 VA: 0x1A33EB0
	private Matrix4x4 GetMatrixImpl(int name) { }

	[NativeNameAttribute] // RVA: 0xD0EA0 Offset: 0xD0FA1 VA: 0xD0EA0
	// RVA: 0x1A33FB0 Offset: 0x1A340B1 VA: 0x1A33FB0
	private Texture GetTextureImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD0EE0 Offset: 0xD0FE1 VA: 0xD0EE0
	// RVA: 0x1A34000 Offset: 0x1A34101 VA: 0x1A34000
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[FreeFunctionAttribute] // RVA: 0xD0F30 Offset: 0xD1031 VA: 0xD0F30
	// RVA: 0x1A34070 Offset: 0x1A34171 VA: 0x1A34070
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	[FreeFunctionAttribute] // RVA: 0xD0F80 Offset: 0xD1081 VA: 0xD0F80
	// RVA: 0x1A340E0 Offset: 0x1A341E1 VA: 0x1A340E0
	private void SetColorArrayImpl(int name, Color[] values, int count) { }

	[FreeFunctionAttribute] // RVA: 0xD0FD0 Offset: 0xD10D1 VA: 0xD0FD0
	// RVA: 0x1A34150 Offset: 0x1A34251 VA: 0x1A34150
	private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[FreeFunctionAttribute] // RVA: 0xD1020 Offset: 0xD1121 VA: 0xD1020
	// RVA: 0x1A341C0 Offset: 0x1A342C1 VA: 0x1A341C0
	private float[] GetFloatArrayImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD1070 Offset: 0xD1171 VA: 0xD1070
	// RVA: 0x1A34210 Offset: 0x1A34311 VA: 0x1A34210
	private Vector4[] GetVectorArrayImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD10C0 Offset: 0xD11C1 VA: 0xD10C0
	// RVA: 0x1A34260 Offset: 0x1A34361 VA: 0x1A34260
	private Color[] GetColorArrayImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD1110 Offset: 0xD1211 VA: 0xD1110
	// RVA: 0x1A342B0 Offset: 0x1A343B1 VA: 0x1A342B0
	private Matrix4x4[] GetMatrixArrayImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD1160 Offset: 0xD1261 VA: 0xD1160
	// RVA: 0x1A34300 Offset: 0x1A34401 VA: 0x1A34300
	private int GetFloatArrayCountImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD11B0 Offset: 0xD12B1 VA: 0xD11B0
	// RVA: 0x1A34350 Offset: 0x1A34451 VA: 0x1A34350
	private int GetVectorArrayCountImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD1200 Offset: 0xD1301 VA: 0xD1200
	// RVA: 0x1A343A0 Offset: 0x1A344A1 VA: 0x1A343A0
	private int GetColorArrayCountImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD1250 Offset: 0xD1351 VA: 0xD1250
	// RVA: 0x1A343F0 Offset: 0x1A344F1 VA: 0x1A343F0
	private int GetMatrixArrayCountImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0xD12A0 Offset: 0xD13A1 VA: 0xD12A0
	// RVA: 0x1A34440 Offset: 0x1A34541 VA: 0x1A34440
	private void ExtractFloatArrayImpl(int name, [Out] float[] val) { }

	[FreeFunctionAttribute] // RVA: 0xD12F0 Offset: 0xD13F1 VA: 0xD12F0
	// RVA: 0x1A344A0 Offset: 0x1A345A1 VA: 0x1A344A0
	private void ExtractVectorArrayImpl(int name, [Out] Vector4[] val) { }

	[FreeFunctionAttribute] // RVA: 0xD1340 Offset: 0xD1441 VA: 0xD1340
	// RVA: 0x1A34500 Offset: 0x1A34601 VA: 0x1A34500
	private void ExtractColorArrayImpl(int name, [Out] Color[] val) { }

	[FreeFunctionAttribute] // RVA: 0xD1390 Offset: 0xD1491 VA: 0xD1390
	// RVA: 0x1A34560 Offset: 0x1A34661 VA: 0x1A34560
	private void ExtractMatrixArrayImpl(int name, [Out] Matrix4x4[] val) { }

	[NativeNameAttribute] // RVA: 0xD13E0 Offset: 0xD14E1 VA: 0xD13E0
	// RVA: 0x1A345C0 Offset: 0x1A346C1 VA: 0x1A345C0
	private Vector4 GetTextureScaleAndOffsetImpl(int name) { }

	[NativeNameAttribute] // RVA: 0xD1420 Offset: 0xD1521 VA: 0xD1420
	// RVA: 0x1A34690 Offset: 0x1A34791 VA: 0x1A34690
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeNameAttribute] // RVA: 0xD1460 Offset: 0xD1561 VA: 0xD1460
	// RVA: 0x1A34750 Offset: 0x1A34851 VA: 0x1A34750
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	// RVA: 0x1A34810 Offset: 0x1A34911 VA: 0x1A34810
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x1A34940 Offset: 0x1A34A41 VA: 0x1A34940
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x1A34A70 Offset: 0x1A34B71 VA: 0x1A34A70
	private void SetColorArray(int name, Color[] values, int count) { }

	// RVA: 0x1A34BA0 Offset: 0x1A34CA1 VA: 0x1A34BA0
	private void SetMatrixArray(int name, Matrix4x4[] values, int count) { }

	// RVA: 0x1A34CD0 Offset: 0x1A34DD1 VA: 0x1A34CD0
	private void ExtractFloatArray(int name, List<float> values) { }

	// RVA: 0x1A34E60 Offset: 0x1A34F61 VA: 0x1A34E60
	private void ExtractVectorArray(int name, List<Vector4> values) { }

	// RVA: 0x1A34FF0 Offset: 0x1A350F1 VA: 0x1A34FF0
	private void ExtractColorArray(int name, List<Color> values) { }

	// RVA: 0x1A35180 Offset: 0x1A35281 VA: 0x1A35180
	private void ExtractMatrixArray(int name, List<Matrix4x4> values) { }

	// RVA: 0x1A35310 Offset: 0x1A35411 VA: 0x1A35310
	public void SetFloat(string name, float value) { }

	// RVA: 0x1A35380 Offset: 0x1A35481 VA: 0x1A35380
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x1A353E0 Offset: 0x1A354E1 VA: 0x1A353E0
	public void SetInt(string name, int value) { }

	// RVA: 0x1A35450 Offset: 0x1A35551 VA: 0x1A35450
	public void SetInt(int nameID, int value) { }

	// RVA: 0x1A321E0 Offset: 0x1A322E1 VA: 0x1A321E0
	public void SetColor(string name, Color value) { }

	// RVA: 0x1A32170 Offset: 0x1A32271 VA: 0x1A32170
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x1A354B0 Offset: 0x1A355B1 VA: 0x1A354B0
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x1A35560 Offset: 0x1A35661 VA: 0x1A35560
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x1A355D0 Offset: 0x1A356D1 VA: 0x1A355D0
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x1A35660 Offset: 0x1A35761 VA: 0x1A35660
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x1A32570 Offset: 0x1A32671 VA: 0x1A32570
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x1A32510 Offset: 0x1A32611 VA: 0x1A32510
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x1A356E0 Offset: 0x1A357E1 VA: 0x1A356E0
	public void SetTexture(string name, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0x1A35760 Offset: 0x1A35861 VA: 0x1A35760
	public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	// RVA: 0x1A357D0 Offset: 0x1A358D1 VA: 0x1A357D0
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x1A35840 Offset: 0x1A35941 VA: 0x1A35840
	public void SetBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x1A358A0 Offset: 0x1A359A1 VA: 0x1A358A0
	public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size) { }

	// RVA: 0x1A35920 Offset: 0x1A35A21 VA: 0x1A35920
	public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	// RVA: 0x1A35990 Offset: 0x1A35A91 VA: 0x1A35990
	public void SetFloatArray(string name, List<float> values) { }

	// RVA: 0x1A35A20 Offset: 0x1A35B21 VA: 0x1A35A20
	public void SetFloatArray(int nameID, List<float> values) { }

	// RVA: 0x1A35AA0 Offset: 0x1A35BA1 VA: 0x1A35AA0
	public void SetFloatArray(string name, float[] values) { }

	// RVA: 0x1A35AF0 Offset: 0x1A35BF1 VA: 0x1A35AF0
	public void SetFloatArray(int nameID, float[] values) { }

	// RVA: 0x1A35B10 Offset: 0x1A35C11 VA: 0x1A35B10
	public void SetColorArray(string name, List<Color> values) { }

	// RVA: 0x1A35BA0 Offset: 0x1A35CA1 VA: 0x1A35BA0
	public void SetColorArray(int nameID, List<Color> values) { }

	// RVA: 0x1A35C20 Offset: 0x1A35D21 VA: 0x1A35C20
	public void SetColorArray(string name, Color[] values) { }

	// RVA: 0x1A35C70 Offset: 0x1A35D71 VA: 0x1A35C70
	public void SetColorArray(int nameID, Color[] values) { }

	// RVA: 0x1A35C90 Offset: 0x1A35D91 VA: 0x1A35C90
	public void SetVectorArray(string name, List<Vector4> values) { }

	// RVA: 0x1A35D20 Offset: 0x1A35E21 VA: 0x1A35D20
	public void SetVectorArray(int nameID, List<Vector4> values) { }

	// RVA: 0x1A35DA0 Offset: 0x1A35EA1 VA: 0x1A35DA0
	public void SetVectorArray(string name, Vector4[] values) { }

	// RVA: 0x1A35DF0 Offset: 0x1A35EF1 VA: 0x1A35DF0
	public void SetVectorArray(int nameID, Vector4[] values) { }

	// RVA: 0x1A35E10 Offset: 0x1A35F11 VA: 0x1A35E10
	public void SetMatrixArray(string name, List<Matrix4x4> values) { }

	// RVA: 0x1A35EA0 Offset: 0x1A35FA1 VA: 0x1A35EA0
	public void SetMatrixArray(int nameID, List<Matrix4x4> values) { }

	// RVA: 0x1A35F20 Offset: 0x1A36021 VA: 0x1A35F20
	public void SetMatrixArray(string name, Matrix4x4[] values) { }

	// RVA: 0x1A35F70 Offset: 0x1A36071 VA: 0x1A35F70
	public void SetMatrixArray(int nameID, Matrix4x4[] values) { }

	// RVA: 0x1A35F90 Offset: 0x1A36091 VA: 0x1A35F90
	public float GetFloat(string name) { }

	// RVA: 0x1A35FF0 Offset: 0x1A360F1 VA: 0x1A35FF0
	public float GetFloat(int nameID) { }

	// RVA: 0x1A36040 Offset: 0x1A36141 VA: 0x1A36040
	public int GetInt(string name) { }

	// RVA: 0x1A360B0 Offset: 0x1A361B1 VA: 0x1A360B0
	public int GetInt(int nameID) { }

	// RVA: 0x1A31FE0 Offset: 0x1A320E1 VA: 0x1A31FE0
	public Color GetColor(string name) { }

	// RVA: 0x1A31F70 Offset: 0x1A32071 VA: 0x1A31F70
	public Color GetColor(int nameID) { }

	// RVA: 0x1A36110 Offset: 0x1A36211 VA: 0x1A36110
	public Vector4 GetVector(string name) { }

	// RVA: 0x1A36190 Offset: 0x1A36291 VA: 0x1A36190
	public Vector4 GetVector(int nameID) { }

	// RVA: 0x1A36210 Offset: 0x1A36311 VA: 0x1A36210
	public Matrix4x4 GetMatrix(string name) { }

	// RVA: 0x1A362F0 Offset: 0x1A363F1 VA: 0x1A362F0
	public Matrix4x4 GetMatrix(int nameID) { }

	// RVA: 0x1A323C0 Offset: 0x1A324C1 VA: 0x1A323C0
	public Texture GetTexture(string name) { }

	// RVA: 0x1A32370 Offset: 0x1A32471 VA: 0x1A32370
	public Texture GetTexture(int nameID) { }

	// RVA: 0x1A363C0 Offset: 0x1A364C1 VA: 0x1A363C0
	public float[] GetFloatArray(string name) { }

	// RVA: 0x1A36470 Offset: 0x1A36571 VA: 0x1A36470
	public float[] GetFloatArray(int nameID) { }

	// RVA: 0x1A36520 Offset: 0x1A36621 VA: 0x1A36520
	public Color[] GetColorArray(string name) { }

	// RVA: 0x1A365D0 Offset: 0x1A366D1 VA: 0x1A365D0
	public Color[] GetColorArray(int nameID) { }

	// RVA: 0x1A36680 Offset: 0x1A36781 VA: 0x1A36680
	public Vector4[] GetVectorArray(string name) { }

	// RVA: 0x1A36730 Offset: 0x1A36831 VA: 0x1A36730
	public Vector4[] GetVectorArray(int nameID) { }

	// RVA: 0x1A367E0 Offset: 0x1A368E1 VA: 0x1A367E0
	public Matrix4x4[] GetMatrixArray(string name) { }

	// RVA: 0x1A36890 Offset: 0x1A36991 VA: 0x1A36890
	public Matrix4x4[] GetMatrixArray(int nameID) { }

	// RVA: 0x1A36940 Offset: 0x1A36A41 VA: 0x1A36940
	public void GetFloatArray(string name, List<float> values) { }

	// RVA: 0x1A36980 Offset: 0x1A36A81 VA: 0x1A36980
	public void GetFloatArray(int nameID, List<float> values) { }

	// RVA: 0x1A36990 Offset: 0x1A36A91 VA: 0x1A36990
	public void GetColorArray(string name, List<Color> values) { }

	// RVA: 0x1A369D0 Offset: 0x1A36AD1 VA: 0x1A369D0
	public void GetColorArray(int nameID, List<Color> values) { }

	// RVA: 0x1A369E0 Offset: 0x1A36AE1 VA: 0x1A369E0
	public void GetVectorArray(string name, List<Vector4> values) { }

	// RVA: 0x1A36A20 Offset: 0x1A36B21 VA: 0x1A36A20
	public void GetVectorArray(int nameID, List<Vector4> values) { }

	// RVA: 0x1A36A30 Offset: 0x1A36B31 VA: 0x1A36A30
	public void GetMatrixArray(string name, List<Matrix4x4> values) { }

	// RVA: 0x1A36A70 Offset: 0x1A36B71 VA: 0x1A36A70
	public void GetMatrixArray(int nameID, List<Matrix4x4> values) { }

	// RVA: 0x1A32960 Offset: 0x1A32A61 VA: 0x1A32960
	public void SetTextureOffset(string name, Vector2 value) { }

	// RVA: 0x1A32900 Offset: 0x1A32A01 VA: 0x1A32900
	public void SetTextureOffset(int nameID, Vector2 value) { }

	// RVA: 0x1A32D60 Offset: 0x1A32E61 VA: 0x1A32D60
	public void SetTextureScale(string name, Vector2 value) { }

	// RVA: 0x1A32D00 Offset: 0x1A32E01 VA: 0x1A32D00
	public void SetTextureScale(int nameID, Vector2 value) { }

	// RVA: 0x1A32770 Offset: 0x1A32871 VA: 0x1A32770
	public Vector2 GetTextureOffset(string name) { }

	// RVA: 0x1A326F0 Offset: 0x1A327F1 VA: 0x1A326F0
	public Vector2 GetTextureOffset(int nameID) { }

	// RVA: 0x1A32B70 Offset: 0x1A32C71 VA: 0x1A32B70
	public Vector2 GetTextureScale(string name) { }

	// RVA: 0x1A32AF0 Offset: 0x1A32BF1 VA: 0x1A32AF0
	public Vector2 GetTextureScale(int nameID) { }

	// RVA: 0x1A33AD0 Offset: 0x1A33BD1 VA: 0x1A33AD0
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x1A33B90 Offset: 0x1A33C91 VA: 0x1A33B90
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x1A33E50 Offset: 0x1A33F51 VA: 0x1A33E50
	private void GetColorImpl_Injected(int name, out Color ret) { }

	// RVA: 0x1A33F50 Offset: 0x1A34051 VA: 0x1A33F50
	private void GetMatrixImpl_Injected(int name, out Matrix4x4 ret) { }

	// RVA: 0x1A34630 Offset: 0x1A34731 VA: 0x1A34630
	private void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret) { }

	// RVA: 0x1A346F0 Offset: 0x1A347F1 VA: 0x1A346F0
	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	// RVA: 0x1A347B0 Offset: 0x1A348B1 VA: 0x1A347B0
	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }
}

