[NativeHeaderAttribute] // RVA: 0xC5E40 Offset: 0xC5F41 VA: 0xC5E40
[NativeClassAttribute] // RVA: 0xC5E40 Offset: 0xC5F41 VA: 0xC5E40
[NativeTypeAttribute] // RVA: 0xC5E40 Offset: 0xC5F41 VA: 0xC5E40
[NativeHeaderAttribute] // RVA: 0xC5E40 Offset: 0xC5F41 VA: 0xC5E40
[DefaultMemberAttribute] // RVA: 0xC5E40 Offset: 0xC5F41 VA: 0xC5E40
[RequiredByNativeCodeAttribute] // RVA: 0xC5E40 Offset: 0xC5F41 VA: 0xC5E40
public struct Vector3 : IEquatable<Vector3> // TypeDefIndex: 2965
{
	// Fields
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	private static readonly Vector3 zeroVector; // 0x0
	private static readonly Vector3 oneVector; // 0xC
	private static readonly Vector3 upVector; // 0x18
	private static readonly Vector3 downVector; // 0x24
	private static readonly Vector3 leftVector; // 0x30
	private static readonly Vector3 rightVector; // 0x3C
	private static readonly Vector3 forwardVector; // 0x48
	private static readonly Vector3 backVector; // 0x54
	private static readonly Vector3 positiveInfinityVector; // 0x60
	private static readonly Vector3 negativeInfinityVector; // 0x6C

	// Properties
	public float Item { get; set; }
	public Vector3 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector3 zero { get; }
	public static Vector3 one { get; }
	public static Vector3 forward { get; }
	public static Vector3 back { get; }
	public static Vector3 up { get; }
	public static Vector3 down { get; }
	public static Vector3 left { get; }
	public static Vector3 right { get; }
	public static Vector3 positiveInfinity { get; }
	public static Vector3 negativeInfinity { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xD4F80 Offset: 0xD5081 VA: 0xD4F80
	// RVA: 0x1B7BC20 Offset: 0x1B7BD21 VA: 0x1B7BC20
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	[FreeFunctionAttribute] // RVA: 0xD4FD0 Offset: 0xD50D1 VA: 0xD4FD0
	// RVA: 0x1B7BD70 Offset: 0x1B7BE71 VA: 0x1B7BD70
	private static void OrthoNormalize2(ref Vector3 a, ref Vector3 b) { }

	// RVA: 0x1B7BDC0 Offset: 0x1B7BEC1 VA: 0x1B7BDC0
	public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent) { }

	[FreeFunctionAttribute] // RVA: 0xD5020 Offset: 0xD5121 VA: 0xD5020
	// RVA: 0x1B7BE70 Offset: 0x1B7BF71 VA: 0x1B7BE70
	public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta) { }

	// RVA: 0x1B7BFC0 Offset: 0x1B7C0C1 VA: 0x1B7BFC0
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x1B7C090 Offset: 0x1B7C191 VA: 0x1B7C090
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x1B7C0C0 Offset: 0x1B7C1C1 VA: 0x1B7C0C0
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD5060 Offset: 0xD5161 VA: 0xD5060
	// RVA: 0x1B7C200 Offset: 0x1B7C301 VA: 0x1B7C200
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD5070 Offset: 0xD5171 VA: 0xD5070
	// RVA: 0x1B7C580 Offset: 0x1B7C681 VA: 0x1B7C580
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime) { }

	// RVA: 0x1B7C2E0 Offset: 0x1B7C3E1 VA: 0x1B7C2E0
	public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x21570 Offset: 0x21671 VA: 0x21570
	public float get_Item(int index) { }

	// RVA: 0x21620 Offset: 0x21721 VA: 0x21620
	public void set_Item(int index, float value) { }

	// RVA: 0x216E0 Offset: 0x217E1 VA: 0x216E0
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x216F0 Offset: 0x217F1 VA: 0x216F0
	public void .ctor(float x, float y) { }

	// RVA: 0x21700 Offset: 0x21801 VA: 0x21700
	public void Set(float newX, float newY, float newZ) { }

	// RVA: 0x1B7C7F0 Offset: 0x1B7C8F1 VA: 0x1B7C7F0
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x1B7C800 Offset: 0x1B7C901 VA: 0x1B7C800
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x21710 Offset: 0x21811 VA: 0x21710 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21770 Offset: 0x21871 VA: 0x21770 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x21860 Offset: 0x21961 VA: 0x21860 Slot: 4
	public bool Equals(Vector3 other) { }

	// RVA: 0x1B7C9C0 Offset: 0x1B7CAC1 VA: 0x1B7C9C0
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	// RVA: 0x1B7CAA0 Offset: 0x1B7CBA1 VA: 0x1B7CAA0
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x218A0 Offset: 0x219A1 VA: 0x218A0
	public void Normalize() { }

	// RVA: 0x218B0 Offset: 0x219B1 VA: 0x218B0
	public Vector3 get_normalized() { }

	// RVA: 0x1B7CA80 Offset: 0x1B7CB81 VA: 0x1B7CA80
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x1B7CFD0 Offset: 0x1B7D0D1 VA: 0x1B7CFD0
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0x1B7D160 Offset: 0x1B7D261 VA: 0x1B7D160
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	// RVA: 0x1B7D2B0 Offset: 0x1B7D3B1 VA: 0x1B7D2B0
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x1B7D480 Offset: 0x1B7D581 VA: 0x1B7D480
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	// RVA: 0x1B7D5D0 Offset: 0x1B7D6D1 VA: 0x1B7D5D0
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x1B7D6B0 Offset: 0x1B7D7B1 VA: 0x1B7D6B0
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	// RVA: 0x1B7CC40 Offset: 0x1B7CD41 VA: 0x1B7CC40
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x21940 Offset: 0x21A41 VA: 0x21940
	public float get_magnitude() { }

	// RVA: 0x1B7D850 Offset: 0x1B7D951 VA: 0x1B7D850
	public static float SqrMagnitude(Vector3 vector) { }

	// RVA: 0x219F0 Offset: 0x21AF1 VA: 0x219F0
	public float get_sqrMagnitude() { }

	// RVA: 0x1B7D870 Offset: 0x1B7D971 VA: 0x1B7D870
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x1B7D940 Offset: 0x1B7DA41 VA: 0x1B7D940
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x1B7CD00 Offset: 0x1B7CE01 VA: 0x1B7CD00
	public static Vector3 get_zero() { }

	// RVA: 0x1B7DA10 Offset: 0x1B7DB11 VA: 0x1B7DA10
	public static Vector3 get_one() { }

	// RVA: 0x1B7DA80 Offset: 0x1B7DB81 VA: 0x1B7DA80
	public static Vector3 get_forward() { }

	// RVA: 0x1B7DAF0 Offset: 0x1B7DBF1 VA: 0x1B7DAF0
	public static Vector3 get_back() { }

	// RVA: 0x1B7DB60 Offset: 0x1B7DC61 VA: 0x1B7DB60
	public static Vector3 get_up() { }

	// RVA: 0x1B7DBD0 Offset: 0x1B7DCD1 VA: 0x1B7DBD0
	public static Vector3 get_down() { }

	// RVA: 0x1B7DC40 Offset: 0x1B7DD41 VA: 0x1B7DC40
	public static Vector3 get_left() { }

	// RVA: 0x1B7DCB0 Offset: 0x1B7DDB1 VA: 0x1B7DCB0
	public static Vector3 get_right() { }

	// RVA: 0x1B7DD20 Offset: 0x1B7DE21 VA: 0x1B7DD20
	public static Vector3 get_positiveInfinity() { }

	// RVA: 0x1B7DD90 Offset: 0x1B7DE91 VA: 0x1B7DD90
	public static Vector3 get_negativeInfinity() { }

	// RVA: 0x1B7DE00 Offset: 0x1B7DF01 VA: 0x1B7DE00
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x1B7DE10 Offset: 0x1B7DF11 VA: 0x1B7DE10
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x1B7DE20 Offset: 0x1B7DF21 VA: 0x1B7DE20
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x1B7DE30 Offset: 0x1B7DF31 VA: 0x1B7DE30
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x1B7DE40 Offset: 0x1B7DF41 VA: 0x1B7DE40
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x1B7CCF0 Offset: 0x1B7CDF1 VA: 0x1B7CCF0
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x1B7DE60 Offset: 0x1B7DF61 VA: 0x1B7DE60
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x1B7DEA0 Offset: 0x1B7DFA1 VA: 0x1B7DEA0
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x21A10 Offset: 0x21B11 VA: 0x21A10 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B7E0F0 Offset: 0x1B7E1F1 VA: 0x1B7E0F0
	private static void .cctor() { }

	// RVA: 0x1B7BD00 Offset: 0x1B7BE01 VA: 0x1B7BD00
	private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }

	// RVA: 0x1B7BF50 Offset: 0x1B7C051 VA: 0x1B7BF50
	private static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret) { }
}

