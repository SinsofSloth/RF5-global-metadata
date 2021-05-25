[RequiredByNativeCodeAttribute] // RVA: 0xC5C00 Offset: 0xC5D01 VA: 0xC5C00
[NativeClassAttribute] // RVA: 0xC5C00 Offset: 0xC5D01 VA: 0xC5C00
[DefaultMemberAttribute] // RVA: 0xC5C00 Offset: 0xC5D01 VA: 0xC5C00
[NativeHeaderAttribute] // RVA: 0xC5C00 Offset: 0xC5D01 VA: 0xC5C00
public struct Color : IEquatable<Color> // TypeDefIndex: 2958
{
	// Fields
	public float r; // 0x0
	public float g; // 0x4
	public float b; // 0x8
	public float a; // 0xC

	// Properties
	public static Color red { get; }
	public static Color green { get; }
	public static Color blue { get; }
	public static Color white { get; }
	public static Color black { get; }
	public static Color yellow { get; }
	public static Color cyan { get; }
	public static Color magenta { get; }
	public static Color gray { get; }
	public static Color grey { get; }
	public static Color clear { get; }
	public Color linear { get; }
	public float maxColorComponent { get; }

	// Methods

	// RVA: 0x37C250 Offset: 0x37C351 VA: 0x37C250
	public void .ctor(float r, float g, float b, float a) { }

	// RVA: 0x37C270 Offset: 0x37C371 VA: 0x37C270
	public void .ctor(float r, float g, float b) { }

	// RVA: 0x37C290 Offset: 0x37C391 VA: 0x37C290 Slot: 3
	public override string ToString() { }

	// RVA: 0x37C2A0 Offset: 0x37C3A1 VA: 0x37C2A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37C2F0 Offset: 0x37C3F1 VA: 0x37C2F0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37C300 Offset: 0x37C401 VA: 0x37C300 Slot: 4
	public bool Equals(Color other) { }

	// RVA: 0x2B00440 Offset: 0x2B00541 VA: 0x2B00440
	public static Color op_Addition(Color a, Color b) { }

	// RVA: 0x2B00460 Offset: 0x2B00561 VA: 0x2B00460
	public static Color op_Subtraction(Color a, Color b) { }

	// RVA: 0x2B00480 Offset: 0x2B00581 VA: 0x2B00480
	public static Color op_Multiply(Color a, Color b) { }

	// RVA: 0x2B004A0 Offset: 0x2B005A1 VA: 0x2B004A0
	public static Color op_Multiply(Color a, float b) { }

	// RVA: 0x2B004C0 Offset: 0x2B005C1 VA: 0x2B004C0
	public static Color op_Multiply(float b, Color a) { }

	// RVA: 0x2B004E0 Offset: 0x2B005E1 VA: 0x2B004E0
	public static Color op_Division(Color a, float b) { }

	// RVA: 0x2B00500 Offset: 0x2B00601 VA: 0x2B00500
	public static bool op_Equality(Color lhs, Color rhs) { }

	// RVA: 0x2B00620 Offset: 0x2B00721 VA: 0x2B00620
	public static bool op_Inequality(Color lhs, Color rhs) { }

	// RVA: 0x2B00640 Offset: 0x2B00741 VA: 0x2B00640
	public static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x37C3A0 Offset: 0x37C4A1 VA: 0x37C3A0
	internal Color RGBMultiplied(float multiplier) { }

	// RVA: 0x2B00750 Offset: 0x2B00851 VA: 0x2B00750
	public static Color get_red() { }

	// RVA: 0x2B00770 Offset: 0x2B00871 VA: 0x2B00770
	public static Color get_green() { }

	// RVA: 0x2B00790 Offset: 0x2B00891 VA: 0x2B00790
	public static Color get_blue() { }

	// RVA: 0x2B007B0 Offset: 0x2B008B1 VA: 0x2B007B0
	public static Color get_white() { }

	// RVA: 0x2B007D0 Offset: 0x2B008D1 VA: 0x2B007D0
	public static Color get_black() { }

	// RVA: 0x2B007F0 Offset: 0x2B008F1 VA: 0x2B007F0
	public static Color get_yellow() { }

	// RVA: 0x2B00810 Offset: 0x2B00911 VA: 0x2B00810
	public static Color get_cyan() { }

	// RVA: 0x2B00830 Offset: 0x2B00931 VA: 0x2B00830
	public static Color get_magenta() { }

	// RVA: 0x2B00850 Offset: 0x2B00951 VA: 0x2B00850
	public static Color get_gray() { }

	// RVA: 0x2B00870 Offset: 0x2B00971 VA: 0x2B00870
	public static Color get_grey() { }

	// RVA: 0x2B00890 Offset: 0x2B00991 VA: 0x2B00890
	public static Color get_clear() { }

	// RVA: 0x37C3C0 Offset: 0x37C4C1 VA: 0x37C3C0
	public Color get_linear() { }

	// RVA: 0x37C3D0 Offset: 0x37C4D1 VA: 0x37C3D0
	public float get_maxColorComponent() { }

	// RVA: 0x2B00290 Offset: 0x2B00391 VA: 0x2B00290
	public static Vector4 op_Implicit(Color c) { }

	// RVA: 0x2B009F0 Offset: 0x2B00AF1 VA: 0x2B009F0
	public static Color op_Implicit(Vector4 v) { }

	// RVA: 0x2B00A00 Offset: 0x2B00B01 VA: 0x2B00A00
	public static Color HSVToRGB(float H, float S, float V) { }

	// RVA: 0x2B00A10 Offset: 0x2B00B11 VA: 0x2B00A10
	public static Color HSVToRGB(float H, float S, float V, bool hdr) { }
}

