[RequiredByNativeCodeAttribute] // RVA: 0xC6090 Offset: 0xC6191 VA: 0xC6090
[NativeClassAttribute] // RVA: 0xC6090 Offset: 0xC6191 VA: 0xC6090
[DefaultMemberAttribute] // RVA: 0xC6090 Offset: 0xC6191 VA: 0xC6090
public struct Vector2 : IEquatable<Vector2> // TypeDefIndex: 2968
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	private static readonly Vector2 zeroVector; // 0x0
	private static readonly Vector2 oneVector; // 0x8
	private static readonly Vector2 upVector; // 0x10
	private static readonly Vector2 downVector; // 0x18
	private static readonly Vector2 leftVector; // 0x20
	private static readonly Vector2 rightVector; // 0x28
	private static readonly Vector2 positiveInfinityVector; // 0x30
	private static readonly Vector2 negativeInfinityVector; // 0x38
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;

	// Properties
	public float Item { get; set; }
	public Vector2 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector2 zero { get; }
	public static Vector2 one { get; }
	public static Vector2 up { get; }
	public static Vector2 down { get; }
	public static Vector2 left { get; }
	public static Vector2 right { get; }

	// Methods

	// RVA: 0x20FC0 Offset: 0x210C1 VA: 0x20FC0
	public float get_Item(int index) { }

	// RVA: 0x21060 Offset: 0x21161 VA: 0x21060
	public void set_Item(int index, float value) { }

	// RVA: 0x21110 Offset: 0x21211 VA: 0x21110
	public void .ctor(float x, float y) { }

	// RVA: 0x21120 Offset: 0x21221 VA: 0x21120
	public void Set(float newX, float newY) { }

	// RVA: 0x1B7A6F0 Offset: 0x1B7A7F1 VA: 0x1B7A6F0
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x1B7A7A0 Offset: 0x1B7A8A1 VA: 0x1B7A7A0
	public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta) { }

	// RVA: 0x1B7A8A0 Offset: 0x1B7A9A1 VA: 0x1B7A8A0
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0x21130 Offset: 0x21231 VA: 0x21130
	public void Normalize() { }

	// RVA: 0x21140 Offset: 0x21241 VA: 0x21140
	public Vector2 get_normalized() { }

	// RVA: 0x21170 Offset: 0x21271 VA: 0x21170 Slot: 3
	public override string ToString() { }

	// RVA: 0x21180 Offset: 0x21281 VA: 0x21180 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x211C0 Offset: 0x212C1 VA: 0x211C0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x21290 Offset: 0x21391 VA: 0x21290 Slot: 4
	public bool Equals(Vector2 other) { }

	// RVA: 0x1B7AE10 Offset: 0x1B7AF11 VA: 0x1B7AE10
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x212C0 Offset: 0x213C1 VA: 0x212C0
	public float get_magnitude() { }

	// RVA: 0x21360 Offset: 0x21461 VA: 0x21360
	public float get_sqrMagnitude() { }

	// RVA: 0x1B7AE40 Offset: 0x1B7AF41 VA: 0x1B7AE40
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x1B7AFC0 Offset: 0x1B7B0C1 VA: 0x1B7AFC0
	public static float SignedAngle(Vector2 from, Vector2 to) { }

	// RVA: 0x1B7B0A0 Offset: 0x1B7B1A1 VA: 0x1B7B0A0
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x1B7B160 Offset: 0x1B7B261 VA: 0x1B7B160
	public static Vector2 ClampMagnitude(Vector2 vector, float maxLength) { }

	// RVA: 0x1B7B230 Offset: 0x1B7B331 VA: 0x1B7B230
	public static float SqrMagnitude(Vector2 a) { }

	// RVA: 0x1B7B240 Offset: 0x1B7B341 VA: 0x1B7B240
	public static Vector2 Min(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x1B7B2F0 Offset: 0x1B7B3F1 VA: 0x1B7B2F0
	public static Vector2 Max(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x1B7B3A0 Offset: 0x1B7B4A1 VA: 0x1B7B3A0
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x1B7B3B0 Offset: 0x1B7B4B1 VA: 0x1B7B3B0
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x1B7B3C0 Offset: 0x1B7B4C1 VA: 0x1B7B3C0
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x1B7B3D0 Offset: 0x1B7B4D1 VA: 0x1B7B3D0
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x1B7B3E0 Offset: 0x1B7B4E1 VA: 0x1B7B3E0
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x1B7B3F0 Offset: 0x1B7B4F1 VA: 0x1B7B3F0
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x1B7B400 Offset: 0x1B7B501 VA: 0x1B7B400
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x1B7AAE0 Offset: 0x1B7ABE1 VA: 0x1B7AAE0
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x1B7B410 Offset: 0x1B7B511 VA: 0x1B7B410
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x1B7B440 Offset: 0x1B7B541 VA: 0x1B7B440
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x1B7B4E0 Offset: 0x1B7B5E1 VA: 0x1B7B4E0
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x1B7B4F0 Offset: 0x1B7B5F1 VA: 0x1B7B4F0
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x1B7AAF0 Offset: 0x1B7ABF1 VA: 0x1B7AAF0
	public static Vector2 get_zero() { }

	// RVA: 0x1B7B510 Offset: 0x1B7B611 VA: 0x1B7B510
	public static Vector2 get_one() { }

	// RVA: 0x1B7B580 Offset: 0x1B7B681 VA: 0x1B7B580
	public static Vector2 get_up() { }

	// RVA: 0x1B7B5F0 Offset: 0x1B7B6F1 VA: 0x1B7B5F0
	public static Vector2 get_down() { }

	// RVA: 0x1B7B660 Offset: 0x1B7B761 VA: 0x1B7B660
	public static Vector2 get_left() { }

	// RVA: 0x1B7B6D0 Offset: 0x1B7B7D1 VA: 0x1B7B6D0
	public static Vector2 get_right() { }

	// RVA: 0x1B7B740 Offset: 0x1B7B841 VA: 0x1B7B740
	private static void .cctor() { }
}

