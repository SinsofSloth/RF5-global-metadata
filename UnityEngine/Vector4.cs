[NativeHeaderAttribute] // RVA: 0xC61B0 Offset: 0xC62B1 VA: 0xC61B0
[NativeClassAttribute] // RVA: 0xC61B0 Offset: 0xC62B1 VA: 0xC61B0
[DefaultMemberAttribute] // RVA: 0xC61B0 Offset: 0xC62B1 VA: 0xC61B0
[RequiredByNativeCodeAttribute] // RVA: 0xC61B0 Offset: 0xC62B1 VA: 0xC61B0
public struct Vector4 : IEquatable<Vector4> // TypeDefIndex: 2971
{
	// Fields
	public const float kEpsilon = 1E-05;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Vector4 zeroVector; // 0x0
	private static readonly Vector4 oneVector; // 0x10
	private static readonly Vector4 positiveInfinityVector; // 0x20
	private static readonly Vector4 negativeInfinityVector; // 0x30

	// Properties
	public float Item { get; set; }
	public Vector4 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector4 zero { get; }
	public static Vector4 one { get; }

	// Methods

	// RVA: 0x21BF0 Offset: 0x21CF1 VA: 0x21BF0
	public float get_Item(int index) { }

	// RVA: 0x21CC0 Offset: 0x21DC1 VA: 0x21CC0
	public void set_Item(int index, float value) { }

	// RVA: 0x21DA0 Offset: 0x21EA1 VA: 0x21DA0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x1B7E930 Offset: 0x1B7EA31 VA: 0x1B7E930
	public static Vector4 Lerp(Vector4 a, Vector4 b, float t) { }

	// RVA: 0x21DC0 Offset: 0x21EC1 VA: 0x21DC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21E30 Offset: 0x21F31 VA: 0x21E30 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x21F50 Offset: 0x22051 VA: 0x21F50 Slot: 4
	public bool Equals(Vector4 other) { }

	// RVA: 0x1B7EC00 Offset: 0x1B7ED01 VA: 0x1B7EC00
	public static Vector4 Normalize(Vector4 a) { }

	// RVA: 0x21FA0 Offset: 0x220A1 VA: 0x21FA0
	public Vector4 get_normalized() { }

	// RVA: 0x1B7EFF0 Offset: 0x1B7F0F1 VA: 0x1B7EFF0
	public static float Dot(Vector4 a, Vector4 b) { }

	// RVA: 0x1B7F010 Offset: 0x1B7F111 VA: 0x1B7F010
	public static float Distance(Vector4 a, Vector4 b) { }

	// RVA: 0x1B7EDE0 Offset: 0x1B7EEE1 VA: 0x1B7EDE0
	public static float Magnitude(Vector4 a) { }

	// RVA: 0x22030 Offset: 0x22131 VA: 0x22030
	public float get_magnitude() { }

	// RVA: 0x22120 Offset: 0x22221 VA: 0x22120
	public float get_sqrMagnitude() { }

	// RVA: 0x1B7EEF0 Offset: 0x1B7EFF1 VA: 0x1B7EEF0
	public static Vector4 get_zero() { }

	// RVA: 0x1B7F330 Offset: 0x1B7F431 VA: 0x1B7F330
	public static Vector4 get_one() { }

	// RVA: 0x1B7F3A0 Offset: 0x1B7F4A1 VA: 0x1B7F3A0
	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	// RVA: 0x1B7F180 Offset: 0x1B7F281 VA: 0x1B7F180
	public static Vector4 op_Subtraction(Vector4 a, Vector4 b) { }

	// RVA: 0x1B7F3C0 Offset: 0x1B7F4C1 VA: 0x1B7F3C0
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	// RVA: 0x1B7F3E0 Offset: 0x1B7F4E1 VA: 0x1B7F3E0
	public static Vector4 op_Multiply(float d, Vector4 a) { }

	// RVA: 0x1B7EED0 Offset: 0x1B7EFD1 VA: 0x1B7EED0
	public static Vector4 op_Division(Vector4 a, float d) { }

	// RVA: 0x1B7F400 Offset: 0x1B7F501 VA: 0x1B7F400
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x1B7F440 Offset: 0x1B7F541 VA: 0x1B7F440
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x1B7F520 Offset: 0x1B7F621 VA: 0x1B7F520
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x1B7F530 Offset: 0x1B7F631 VA: 0x1B7F530
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x1B7F540 Offset: 0x1B7F641 VA: 0x1B7F540
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x1B7F550 Offset: 0x1B7F651 VA: 0x1B7F550
	public static Vector2 op_Implicit(Vector4 v) { }

	// RVA: 0x221C0 Offset: 0x222C1 VA: 0x221C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B7F740 Offset: 0x1B7F841 VA: 0x1B7F740
	private static void .cctor() { }
}

