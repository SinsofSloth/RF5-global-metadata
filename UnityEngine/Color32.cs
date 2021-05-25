[UsedByNativeCodeAttribute] // RVA: 0xC5CA0 Offset: 0xC5DA1 VA: 0xC5CA0
[DefaultMemberAttribute] // RVA: 0xC5CA0 Offset: 0xC5DA1 VA: 0xC5CA0
public struct Color32 // TypeDefIndex: 2959
{
	// Fields
	[IgnoreAttribute] // RVA: 0xCA2F0 Offset: 0xCA3F1 VA: 0xCA2F0
	private int rgba; // 0x0
	public byte r; // 0x0
	public byte g; // 0x1
	public byte b; // 0x2
	public byte a; // 0x3

	// Methods

	// RVA: 0x37C460 Offset: 0x37C561 VA: 0x37C460
	public void .ctor(byte r, byte g, byte b, byte a) { }

	// RVA: 0x2B00C30 Offset: 0x2B00D31 VA: 0x2B00C30
	public static Color32 op_Implicit(Color c) { }

	// RVA: 0x2B00F40 Offset: 0x2B01041 VA: 0x2B00F40
	public static Color op_Implicit(Color32 c) { }

	// RVA: 0x2B00F80 Offset: 0x2B01081 VA: 0x2B00F80
	public static Color32 Lerp(Color32 a, Color32 b, float t) { }

	// RVA: 0x37C480 Offset: 0x37C581 VA: 0x37C480 Slot: 3
	public override string ToString() { }
}

