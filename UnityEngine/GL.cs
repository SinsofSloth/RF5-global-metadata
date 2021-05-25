[StaticAccessorAttribute] // RVA: 0xC4BD0 Offset: 0xC4CD1 VA: 0xC4BD0
[NativeHeaderAttribute] // RVA: 0xC4BD0 Offset: 0xC4CD1 VA: 0xC4BD0
[NativeHeaderAttribute] // RVA: 0xC4BD0 Offset: 0xC4CD1 VA: 0xC4BD0
[NativeHeaderAttribute] // RVA: 0xC4BD0 Offset: 0xC4CD1 VA: 0xC4BD0
[NativeHeaderAttribute] // RVA: 0xC4BD0 Offset: 0xC4CD1 VA: 0xC4BD0
public sealed class GL // TypeDefIndex: 2875
{
	// Properties
	[NativePropertyAttribute] // RVA: 0xDE350 Offset: 0xDE451 VA: 0xDE350
	public static bool invertCulling { set; }

	// Methods

	[NativeNameAttribute] // RVA: 0xCE660 Offset: 0xCE761 VA: 0xCE660
	// RVA: 0x2B0C6E0 Offset: 0x2B0C7E1 VA: 0x2B0C6E0
	public static void Vertex3(float x, float y, float z) { }

	[NativeNameAttribute] // RVA: 0xCE6A0 Offset: 0xCE7A1 VA: 0xCE6A0
	// RVA: 0x2B0C740 Offset: 0x2B0C841 VA: 0x2B0C740
	public static void TexCoord3(float x, float y, float z) { }

	// RVA: 0x2B0C7A0 Offset: 0x2B0C8A1 VA: 0x2B0C7A0
	public static void TexCoord2(float x, float y) { }

	[NativeNameAttribute] // RVA: 0xCE6E0 Offset: 0xCE7E1 VA: 0xCE6E0
	// RVA: 0x2B0C7F0 Offset: 0x2B0C8F1 VA: 0x2B0C7F0
	public static void MultiTexCoord3(int unit, float x, float y, float z) { }

	// RVA: 0x2B0C860 Offset: 0x2B0C961 VA: 0x2B0C860
	public static void MultiTexCoord2(int unit, float x, float y) { }

	// RVA: 0x2B0C8C0 Offset: 0x2B0C9C1 VA: 0x2B0C8C0
	public static void set_invertCulling(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xCE720 Offset: 0xCE821 VA: 0xCE720
	// RVA: 0x2B0C910 Offset: 0x2B0CA11 VA: 0x2B0C910
	public static void PushMatrix() { }

	[FreeFunctionAttribute] // RVA: 0xCE760 Offset: 0xCE861 VA: 0xCE760
	// RVA: 0x2B0C950 Offset: 0x2B0CA51 VA: 0x2B0C950
	public static void PopMatrix() { }

	[FreeFunctionAttribute] // RVA: 0xCE7A0 Offset: 0xCE8A1 VA: 0xCE7A0
	// RVA: 0x2B0C990 Offset: 0x2B0CA91 VA: 0x2B0C990
	public static void LoadIdentity() { }

	[FreeFunctionAttribute] // RVA: 0xCE7E0 Offset: 0xCE8E1 VA: 0xCE7E0
	// RVA: 0x2B0C9D0 Offset: 0x2B0CAD1 VA: 0x2B0C9D0
	public static void LoadOrtho() { }

	[FreeFunctionAttribute] // RVA: 0xCE820 Offset: 0xCE921 VA: 0xCE820
	// RVA: 0x2B0CA10 Offset: 0x2B0CB11 VA: 0x2B0CA10
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	[FreeFunctionAttribute] // RVA: 0xCE860 Offset: 0xCE961 VA: 0xCE860
	// RVA: 0x2B0CAB0 Offset: 0x2B0CBB1 VA: 0x2B0CAB0
	public static void InvalidateState() { }

	[FreeFunctionAttribute] // RVA: 0xCE8A0 Offset: 0xCE9A1 VA: 0xCE8A0
	// RVA: 0x2B0CAF0 Offset: 0x2B0CBF1 VA: 0x2B0CAF0
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	[FreeFunctionAttribute] // RVA: 0xCE8E0 Offset: 0xCE9E1 VA: 0xCE8E0
	// RVA: 0x2B0CBF0 Offset: 0x2B0CCF1 VA: 0x2B0CBF0
	private static void GLIssuePluginEvent(IntPtr callback, int eventID) { }

	// RVA: 0x2B0CC40 Offset: 0x2B0CD41 VA: 0x2B0CC40
	public static void IssuePluginEvent(IntPtr callback, int eventID) { }

	[FreeFunctionAttribute] // RVA: 0xCE8F0 Offset: 0xCE9F1 VA: 0xCE8F0
	// RVA: 0x2B0CD10 Offset: 0x2B0CE11 VA: 0x2B0CD10
	public static void Begin(int mode) { }

	[FreeFunctionAttribute] // RVA: 0xCE940 Offset: 0xCEA41 VA: 0xCE940
	// RVA: 0x2B0CD60 Offset: 0x2B0CE61 VA: 0x2B0CD60
	public static void End() { }

	[FreeFunctionAttribute] // RVA: 0xCE980 Offset: 0xCEA81 VA: 0xCE980
	// RVA: 0x2B0CDA0 Offset: 0x2B0CEA1 VA: 0x2B0CDA0
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x2B0CE90 Offset: 0x2B0CF91 VA: 0x2B0CE90
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0xCE990 Offset: 0xCEA91 VA: 0xCE990
	// RVA: 0x2B0CF00 Offset: 0x2B0D001 VA: 0x2B0CF00
	public static void ClearWithSkybox(bool clearDepth, Camera camera) { }

	// RVA: 0x2B0CA60 Offset: 0x2B0CB61 VA: 0x2B0CA60
	private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	// RVA: 0x2B0CB90 Offset: 0x2B0CC91 VA: 0x2B0CB90
	private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	// RVA: 0x2B0CE20 Offset: 0x2B0CF21 VA: 0x2B0CE20
	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }
}

