internal static class TimeSpanFormat // TypeDefIndex: 732
{
	// Fields
	internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals; // 0x0
	internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals; // 0x28

	// Methods

	// RVA: 0x19CB9C0 Offset: 0x19CBAC1 VA: 0x19CB9C0
	private static string IntToString(int n, int digits) { }

	// RVA: 0x19CB9E0 Offset: 0x19CBAE1 VA: 0x19CB9E0
	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	// RVA: 0x19CBC30 Offset: 0x19CBD31 VA: 0x19CBC30
	private static string FormatStandard(TimeSpan value, bool isInvariant, string format, TimeSpanFormat.Pattern pattern) { }

	// RVA: 0x19CC1D0 Offset: 0x19CC2D1 VA: 0x19CC1D0
	internal static string FormatCustomized(TimeSpan value, string format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19CD140 Offset: 0x19CD241 VA: 0x19CD140
	private static void .cctor() { }
}

