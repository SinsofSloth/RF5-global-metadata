internal class HebrewNumber // TypeDefIndex: 722
{
	// Fields
	private static HebrewNumber.HebrewValue[] HebrewValues; // 0x0
	private static char maxHebrewNumberCh; // 0x8
	private static readonly HebrewNumber.HS[][] NumberPasingState; // 0x10

	// Methods

	// RVA: 0x19C3400 Offset: 0x19C3501 VA: 0x19C3400
	internal static string ToString(int Number) { }

	// RVA: 0x19C3680 Offset: 0x19C3781 VA: 0x19C3680
	internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context) { }

	// RVA: 0x19C3870 Offset: 0x19C3971 VA: 0x19C3870
	internal static bool IsDigit(char ch) { }

	// RVA: 0x19C3990 Offset: 0x19C3A91 VA: 0x19C3990
	private static void .cctor() { }
}

