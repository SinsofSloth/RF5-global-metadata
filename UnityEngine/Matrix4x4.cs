[NativeHeaderAttribute] // RVA: 0xC5D60 Offset: 0xC5E61 VA: 0xC5D60
[NativeClassAttribute] // RVA: 0xC5D60 Offset: 0xC5E61 VA: 0xC5D60
[NativeTypeAttribute] // RVA: 0xC5D60 Offset: 0xC5E61 VA: 0xC5D60
[DefaultMemberAttribute] // RVA: 0xC5D60 Offset: 0xC5E61 VA: 0xC5D60
[RequiredByNativeCodeAttribute] // RVA: 0xC5D60 Offset: 0xC5E61 VA: 0xC5D60
public struct Matrix4x4 : IEquatable<Matrix4x4> // TypeDefIndex: 2964
{
	// Fields
	[NativeNameAttribute] // RVA: 0xCA330 Offset: 0xCA431 VA: 0xCA330
	public float m00; // 0x0
	[NativeNameAttribute] // RVA: 0xCA370 Offset: 0xCA471 VA: 0xCA370
	public float m10; // 0x4
	[NativeNameAttribute] // RVA: 0xCA3B0 Offset: 0xCA4B1 VA: 0xCA3B0
	public float m20; // 0x8
	[NativeNameAttribute] // RVA: 0xCA3F0 Offset: 0xCA4F1 VA: 0xCA3F0
	public float m30; // 0xC
	[NativeNameAttribute] // RVA: 0xCA430 Offset: 0xCA531 VA: 0xCA430
	public float m01; // 0x10
	[NativeNameAttribute] // RVA: 0xCA470 Offset: 0xCA571 VA: 0xCA470
	public float m11; // 0x14
	[NativeNameAttribute] // RVA: 0xCA4B0 Offset: 0xCA5B1 VA: 0xCA4B0
	public float m21; // 0x18
	[NativeNameAttribute] // RVA: 0xCA4F0 Offset: 0xCA5F1 VA: 0xCA4F0
	public float m31; // 0x1C
	[NativeNameAttribute] // RVA: 0xCA530 Offset: 0xCA631 VA: 0xCA530
	public float m02; // 0x20
	[NativeNameAttribute] // RVA: 0xCA570 Offset: 0xCA671 VA: 0xCA570
	public float m12; // 0x24
	[NativeNameAttribute] // RVA: 0xCA5B0 Offset: 0xCA6B1 VA: 0xCA5B0
	public float m22; // 0x28
	[NativeNameAttribute] // RVA: 0xCA5F0 Offset: 0xCA6F1 VA: 0xCA5F0
	public float m32; // 0x2C
	[NativeNameAttribute] // RVA: 0xCA630 Offset: 0xCA731 VA: 0xCA630
	public float m03; // 0x30
	[NativeNameAttribute] // RVA: 0xCA670 Offset: 0xCA771 VA: 0xCA670
	public float m13; // 0x34
	[NativeNameAttribute] // RVA: 0xCA6B0 Offset: 0xCA7B1 VA: 0xCA6B0
	public float m23; // 0x38
	[NativeNameAttribute] // RVA: 0xCA6F0 Offset: 0xCA7F1 VA: 0xCA6F0
	public float m33; // 0x3C
	private static readonly Matrix4x4 zeroMatrix; // 0x0
	private static readonly Matrix4x4 identityMatrix; // 0x40

	// Properties
	public Vector3 lossyScale { get; }
	public Matrix4x4 inverse { get; }
	public float Item { get; set; }
	public float Item { get; set; }
	public static Matrix4x4 zero { get; }
	public static Matrix4x4 identity { get; }

	// Methods

	[ThreadSafeAttribute] // RVA: 0xD4E80 Offset: 0xD4F81 VA: 0xD4E80
	// RVA: 0x18660 Offset: 0x18761 VA: 0x18660
	private Vector3 GetLossyScale() { }

	// RVA: 0x18720 Offset: 0x18821 VA: 0x18720
	public Vector3 get_lossyScale() { }

	[FreeFunctionAttribute] // RVA: 0xD4E90 Offset: 0xD4F91 VA: 0xD4E90
	// RVA: 0x1A39100 Offset: 0x1A39201 VA: 0x1A39100
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	// RVA: 0x187E0 Offset: 0x188E1 VA: 0x187E0
	public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunctionAttribute] // RVA: 0xD4EE0 Offset: 0xD4FE1 VA: 0xD4EE0
	// RVA: 0x1A39370 Offset: 0x1A39471 VA: 0x1A39370
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x188F0 Offset: 0x189F1 VA: 0x188F0
	public Matrix4x4 get_inverse() { }

	[FreeFunctionAttribute] // RVA: 0xD4F30 Offset: 0xD5031 VA: 0xD4F30
	// RVA: 0x1A39630 Offset: 0x1A39731 VA: 0x1A39630
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	// RVA: 0x18900 Offset: 0x18A01 VA: 0x18900
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x18960 Offset: 0x18A61 VA: 0x18960
	public float get_Item(int row, int column) { }

	// RVA: 0x18970 Offset: 0x18A71 VA: 0x18970
	public void set_Item(int row, int column, float value) { }

	// RVA: 0x18980 Offset: 0x18A81 VA: 0x18980
	public float get_Item(int index) { }

	// RVA: 0x18990 Offset: 0x18A91 VA: 0x18990
	public void set_Item(int index, float value) { }

	// RVA: 0x189A0 Offset: 0x18AA1 VA: 0x189A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x189B0 Offset: 0x18AB1 VA: 0x189B0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x18A70 Offset: 0x18B71 VA: 0x18A70 Slot: 4
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x1A3A080 Offset: 0x1A3A181 VA: 0x1A3A080
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x1A3A2F0 Offset: 0x1A3A3F1 VA: 0x1A3A2F0
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	// RVA: 0x1A3A390 Offset: 0x1A3A491 VA: 0x1A3A390
	public static bool op_Equality(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x18AC0 Offset: 0x18BC1 VA: 0x18AC0
	public Vector4 GetColumn(int index) { }

	// RVA: 0x18AD0 Offset: 0x18BD1 VA: 0x18AD0
	public void SetColumn(int index, Vector4 column) { }

	// RVA: 0x18B50 Offset: 0x18C51 VA: 0x18B50
	public void SetRow(int index, Vector4 row) { }

	// RVA: 0x18BC0 Offset: 0x18CC1 VA: 0x18BC0
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x18C60 Offset: 0x18D61 VA: 0x18C60
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x18CE0 Offset: 0x18DE1 VA: 0x18CE0
	public Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0x1A3A9A0 Offset: 0x1A3AAA1 VA: 0x1A3A9A0
	public static Matrix4x4 Translate(Vector3 vector) { }

	// RVA: 0x1A3A9D0 Offset: 0x1A3AAD1 VA: 0x1A3A9D0
	public static Matrix4x4 Rotate(Quaternion q) { }

	// RVA: 0x1A3AA80 Offset: 0x1A3AB81 VA: 0x1A3AA80
	public static Matrix4x4 get_zero() { }

	// RVA: 0x1A3AB10 Offset: 0x1A3AC11 VA: 0x1A3AB10
	public static Matrix4x4 get_identity() { }

	// RVA: 0x18D40 Offset: 0x18E41 VA: 0x18D40 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A3B110 Offset: 0x1A3B211 VA: 0x1A3B110
	private static void .cctor() { }

	// RVA: 0x1A38FF0 Offset: 0x1A390F1 VA: 0x1A38FF0
	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	// RVA: 0x1A39200 Offset: 0x1A39301 VA: 0x1A39200
	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

	// RVA: 0x1A39450 Offset: 0x1A39551 VA: 0x1A39450
	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x1A39730 Offset: 0x1A39831 VA: 0x1A39730
	private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret) { }
}

