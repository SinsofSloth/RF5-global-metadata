[UsedByNativeCodeAttribute] // RVA: 0xC5F40 Offset: 0xC6041 VA: 0xC5F40
[DefaultMemberAttribute] // RVA: 0xC5F40 Offset: 0xC6041 VA: 0xC5F40
[NativeTypeAttribute] // RVA: 0xC5F40 Offset: 0xC6041 VA: 0xC5F40
[NativeHeaderAttribute] // RVA: 0xC5F40 Offset: 0xC6041 VA: 0xC5F40
public struct Quaternion : IEquatable<Quaternion> // TypeDefIndex: 2966
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Quaternion identityQuaternion; // 0x0
	public const float kEpsilon = 1E-06;

	// Properties
	public static Quaternion identity { get; }
	public Vector3 eulerAngles { get; set; }
	public Quaternion normalized { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xD5080 Offset: 0xD5181 VA: 0xD5080
	// RVA: 0x2B73F10 Offset: 0x2B74011 VA: 0x2B73F10
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[FreeFunctionAttribute] // RVA: 0xD50D0 Offset: 0xD51D1 VA: 0xD50D0
	// RVA: 0x2B74030 Offset: 0x2B74131 VA: 0x2B74030
	public static Quaternion Inverse(Quaternion rotation) { }

	[FreeFunctionAttribute] // RVA: 0xD5110 Offset: 0xD5211 VA: 0xD5110
	// RVA: 0x2B74140 Offset: 0x2B74241 VA: 0x2B74140
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xD5160 Offset: 0xD5261 VA: 0xD5160
	// RVA: 0x2B74290 Offset: 0x2B74391 VA: 0x2B74290
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xD51B0 Offset: 0xD52B1 VA: 0xD51B0
	// RVA: 0x2B743E0 Offset: 0x2B744E1 VA: 0x2B743E0
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xD5200 Offset: 0xD5301 VA: 0xD5200
	// RVA: 0x2B74530 Offset: 0x2B74631 VA: 0x2B74530
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	[FreeFunctionAttribute] // RVA: 0xD5250 Offset: 0xD5351 VA: 0xD5250
	// RVA: 0x2B74640 Offset: 0x2B74741 VA: 0x2B74640
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	[FreeFunctionAttribute] // RVA: 0xD52A0 Offset: 0xD53A1 VA: 0xD52A0
	// RVA: 0x2B74750 Offset: 0x2B74851 VA: 0x2B74750
	private static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle) { }

	[FreeFunctionAttribute] // RVA: 0xD52F0 Offset: 0xD53F1 VA: 0xD52F0
	// RVA: 0x2B74870 Offset: 0x2B74971 VA: 0x2B74870
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[FreeFunctionAttribute] // RVA: 0xD5340 Offset: 0xD5441 VA: 0xD5340
	// RVA: 0x2B749A0 Offset: 0x2B74AA1 VA: 0x2B749A0
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD5390 Offset: 0xD5491 VA: 0xD5390
	// RVA: 0x2B74AC0 Offset: 0x2B74BC1 VA: 0x2B74AC0
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0x381CF0 Offset: 0x381DF1 VA: 0x381CF0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x2B74BB0 Offset: 0x2B74CB1 VA: 0x2B74BB0
	public static Quaternion get_identity() { }

	// RVA: 0x2B74C20 Offset: 0x2B74D21 VA: 0x2B74C20
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x2B74CA0 Offset: 0x2B74DA1 VA: 0x2B74CA0
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x2B74D50 Offset: 0x2B74E51 VA: 0x2B74D50
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x2B74D70 Offset: 0x2B74E71 VA: 0x2B74D70
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x2B74E60 Offset: 0x2B74F61 VA: 0x2B74E60
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x2B74E40 Offset: 0x2B74F41 VA: 0x2B74E40
	public static float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x381D10 Offset: 0x381E11 VA: 0x381D10
	public void SetLookRotation(Vector3 view, Vector3 up) { }

	// RVA: 0x2B75040 Offset: 0x2B75141 VA: 0x2B75040
	public static float Angle(Quaternion a, Quaternion b) { }

	// RVA: 0x2B75160 Offset: 0x2B75261 VA: 0x2B75160
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x381DD0 Offset: 0x381ED1 VA: 0x381DD0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x381DE0 Offset: 0x381EE1 VA: 0x381DE0
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x2B75570 Offset: 0x2B75671 VA: 0x2B75570
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x2B756E0 Offset: 0x2B757E1 VA: 0x2B756E0
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x381DF0 Offset: 0x381EF1 VA: 0x381DF0
	public void ToAngleAxis(out float angle, out Vector3 axis) { }

	// RVA: 0x2B75970 Offset: 0x2B75A71 VA: 0x2B75970
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	// RVA: 0x2B75AE0 Offset: 0x2B75BE1 VA: 0x2B75AE0
	public static Quaternion Normalize(Quaternion q) { }

	// RVA: 0x381E00 Offset: 0x381F01 VA: 0x381E00
	public Quaternion get_normalized() { }

	// RVA: 0x381E90 Offset: 0x381F91 VA: 0x381E90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x381F00 Offset: 0x382001 VA: 0x381F00 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x381F10 Offset: 0x382011 VA: 0x381F10 Slot: 4
	public bool Equals(Quaternion other) { }

	// RVA: 0x381FB0 Offset: 0x3820B1 VA: 0x381FB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2B760D0 Offset: 0x2B761D1 VA: 0x2B760D0
	private static void .cctor() { }

	// RVA: 0x2B73FD0 Offset: 0x2B740D1 VA: 0x2B73FD0
	private static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) { }

	// RVA: 0x2B740F0 Offset: 0x2B741F1 VA: 0x2B740F0
	private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	// RVA: 0x2B74220 Offset: 0x2B74321 VA: 0x2B74220
	private static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x2B74370 Offset: 0x2B74471 VA: 0x2B74370
	private static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x2B744C0 Offset: 0x2B745C1 VA: 0x2B744C0
	private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x2B745F0 Offset: 0x2B746F1 VA: 0x2B745F0
	private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	// RVA: 0x2B74700 Offset: 0x2B74801 VA: 0x2B74700
	private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) { }

	// RVA: 0x2B74810 Offset: 0x2B74911 VA: 0x2B74810
	private static void Internal_ToAxisAngleRad_Injected(ref Quaternion q, out Vector3 axis, out float angle) { }

	// RVA: 0x2B74940 Offset: 0x2B74A41 VA: 0x2B74940
	private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) { }

	// RVA: 0x2B74A60 Offset: 0x2B74B61 VA: 0x2B74A60
	private static void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret) { }
}

