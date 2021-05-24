[StaticAccessorAttribute] // RVA: 0xC4910 Offset: 0xC4A11 VA: 0xC4910
[NativeHeaderAttribute] // RVA: 0xC4910 Offset: 0xC4A11 VA: 0xC4910
public sealed class Gizmos // TypeDefIndex: 2865
{
	// Properties
	public static Color color { get; set; }
	public static Matrix4x4 matrix { get; set; }

	// Methods

	[NativeThrowsAttribute] // RVA: 0xCDE70 Offset: 0xCDF71 VA: 0xCDE70
	// RVA: 0x1A28240 Offset: 0x1A28341 VA: 0x1A28240
	public static void DrawLine(Vector3 from, Vector3 to) { }

	[NativeThrowsAttribute] // RVA: 0xCDE80 Offset: 0xCDF81 VA: 0xCDE80
	// RVA: 0x1A282F0 Offset: 0x1A283F1 VA: 0x1A282F0
	public static void DrawWireSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0xCDE90 Offset: 0xCDF91 VA: 0xCDE90
	// RVA: 0x1A283A0 Offset: 0x1A284A1 VA: 0x1A283A0
	public static void DrawSphere(Vector3 center, float radius) { }

	[NativeThrowsAttribute] // RVA: 0xCDEA0 Offset: 0xCDFA1 VA: 0xCDEA0
	// RVA: 0x1A28450 Offset: 0x1A28551 VA: 0x1A28450
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0xCDEB0 Offset: 0xCDFB1 VA: 0xCDEB0
	// RVA: 0x1A28500 Offset: 0x1A28601 VA: 0x1A28500
	public static void DrawCube(Vector3 center, Vector3 size) { }

	[NativeThrowsAttribute] // RVA: 0xCDEC0 Offset: 0xCDFC1 VA: 0xCDEC0
	// RVA: 0x1A285B0 Offset: 0x1A286B1 VA: 0x1A285B0
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[NativeThrowsAttribute] // RVA: 0xCDED0 Offset: 0xCDFD1 VA: 0xCDED0
	// RVA: 0x1A286B0 Offset: 0x1A287B1 VA: 0x1A286B0
	public static void DrawIcon(Vector3 center, string name, bool allowScaling) { }

	[NativeThrowsAttribute] // RVA: 0xCDEE0 Offset: 0xCDFE1 VA: 0xCDEE0
	// RVA: 0x1A28750 Offset: 0x1A28851 VA: 0x1A28750
	public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint) { }

	// RVA: 0x1A28840 Offset: 0x1A28941 VA: 0x1A28840
	public static Color get_color() { }

	// RVA: 0x1A288F0 Offset: 0x1A289F1 VA: 0x1A288F0
	public static void set_color(Color value) { }

	// RVA: 0x1A28990 Offset: 0x1A28A91 VA: 0x1A28990
	public static Matrix4x4 get_matrix() { }

	// RVA: 0x1A28A60 Offset: 0x1A28B61 VA: 0x1A28A60
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x1A28B00 Offset: 0x1A28C01 VA: 0x1A28B00
	public static void DrawRay(Vector3 from, Vector3 direction) { }

	[ExcludeFromDocsAttribute] // RVA: 0xCDEF0 Offset: 0xCDFF1 VA: 0xCDEF0
	// RVA: 0x1A28BF0 Offset: 0x1A28CF1 VA: 0x1A28BF0
	public static void DrawMesh(Mesh mesh) { }

	// RVA: 0x1A28D20 Offset: 0x1A28E21 VA: 0x1A28D20
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	[ExcludeFromDocsAttribute] // RVA: 0xCDF00 Offset: 0xCE001 VA: 0xCDF00
	// RVA: 0x1A28DA0 Offset: 0x1A28EA1 VA: 0x1A28DA0
	public static void DrawIcon(Vector3 center, string name) { }

	// RVA: 0x1A282A0 Offset: 0x1A283A1 VA: 0x1A282A0
	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	// RVA: 0x1A28350 Offset: 0x1A28451 VA: 0x1A28350
	private static void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x1A28400 Offset: 0x1A28501 VA: 0x1A28400
	private static void DrawSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x1A284B0 Offset: 0x1A285B1 VA: 0x1A284B0
	private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x1A28560 Offset: 0x1A28661 VA: 0x1A28560
	private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x1A28640 Offset: 0x1A28741 VA: 0x1A28640
	private static void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) { }

	// RVA: 0x1A287D0 Offset: 0x1A288D1 VA: 0x1A287D0
	private static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint) { }

	// RVA: 0x1A288A0 Offset: 0x1A289A1 VA: 0x1A288A0
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x1A28940 Offset: 0x1A28A41 VA: 0x1A28940
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x1A28A10 Offset: 0x1A28B11 VA: 0x1A28A10
	private static void get_matrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1A28AB0 Offset: 0x1A28BB1 VA: 0x1A28AB0
	private static void set_matrix_Injected(ref Matrix4x4 value) { }
}

