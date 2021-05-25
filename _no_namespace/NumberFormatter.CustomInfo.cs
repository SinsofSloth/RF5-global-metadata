private class NumberFormatter.CustomInfo // TypeDefIndex: 393
{
	// Fields
	public bool UseGroup; // 0x10
	public int DecimalDigits; // 0x14
	public int DecimalPointPos; // 0x18
	public int DecimalTailSharpDigits; // 0x1C
	public int IntegerDigits; // 0x20
	public int IntegerHeadSharpDigits; // 0x24
	public int IntegerHeadPos; // 0x28
	public bool UseExponent; // 0x2C
	public int ExponentDigits; // 0x30
	public int ExponentTailSharpDigits; // 0x34
	public bool ExponentNegativeSignOnly; // 0x38
	public int DividePlaces; // 0x3C
	public int Percents; // 0x40
	public int Permilles; // 0x44

	// Methods

	// RVA: 0x18E9BC0 Offset: 0x18E9CC1 VA: 0x18E9BC0
	public static void GetActiveSection(string format, ref bool positive, bool zero, ref int offset, ref int length) { }

	// RVA: 0x18E9F90 Offset: 0x18EA091 VA: 0x18E9F90
	public static NumberFormatter.CustomInfo Parse(string format, int offset, int length, NumberFormatInfo nfi) { }

	// RVA: 0x18EA930 Offset: 0x18EAA31 VA: 0x18EA930
	public string Format(string format, int offset, int length, NumberFormatInfo nfi, bool positive, StringBuilder sb_int, StringBuilder sb_dec, StringBuilder sb_exp) { }

	// RVA: 0x18EB450 Offset: 0x18EB551 VA: 0x18EB450
	public void .ctor() { }
}

