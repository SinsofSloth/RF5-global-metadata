internal static class DateTimeParse // TypeDefIndex: 236
{
	// Fields
	internal static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser; // 0x0
	private static DateTimeParse.DS[][] dateParsingStates; // 0x8

	// Methods

	// RVA: 0x199E9F0 Offset: 0x199EAF1 VA: 0x199E9F0
	internal static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x199EB10 Offset: 0x199EC11 VA: 0x199EB10
	internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x199F550 Offset: 0x199F651 VA: 0x199F550
	private static bool MatchWord(ref __DTString str, string target) { }

	// RVA: 0x199F6A0 Offset: 0x199F7A1 VA: 0x199F6A0
	private static bool GetTimeZoneName(ref __DTString str) { }

	// RVA: 0x199F750 Offset: 0x199F851 VA: 0x199F750
	internal static bool IsDigit(char ch) { }

	// RVA: 0x199F770 Offset: 0x199F871 VA: 0x199F770
	private static bool ParseFraction(ref __DTString str, out double result) { }

	// RVA: 0x199F860 Offset: 0x199F961 VA: 0x199F860
	private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result) { }

	// RVA: 0x199FAF0 Offset: 0x199FBF1 VA: 0x199FAF0
	private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result) { }

	// RVA: 0x199FCA0 Offset: 0x199FDA1 VA: 0x199FCA0
	private static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x19A0FA0 Offset: 0x19A10A1 VA: 0x19A0FA0
	private static bool VerifyValidPunctuation(ref __DTString str) { }

	// RVA: 0x19A1140 Offset: 0x19A1241 VA: 0x19A1140
	private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x19A1420 Offset: 0x19A1521 VA: 0x19A1420
	private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x19A1610 Offset: 0x19A1711 VA: 0x19A1610
	private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x19A1840 Offset: 0x19A1941 VA: 0x19A1840
	private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear) { }

	// RVA: 0x19A1950 Offset: 0x19A1A51 VA: 0x19A1950
	private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day) { }

	// RVA: 0x19A19E0 Offset: 0x19A1AE1 VA: 0x19A19E0
	private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year) { }

	// RVA: 0x19A1AA0 Offset: 0x19A1BA1 VA: 0x19A1AA0
	private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year) { }

	// RVA: 0x19A1B60 Offset: 0x19A1C61 VA: 0x19A1B60
	private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month) { }

	// RVA: 0x19A1C20 Offset: 0x19A1D21 VA: 0x19A1C20
	private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x19A1DF0 Offset: 0x19A1EF1 VA: 0x19A1DF0
	private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19A2060 Offset: 0x19A2161 VA: 0x19A2060
	private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19A2490 Offset: 0x19A2591 VA: 0x19A2490
	private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19A27A0 Offset: 0x19A28A1 VA: 0x19A27A0
	private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19A2920 Offset: 0x19A2A21 VA: 0x19A2920
	private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19A2C30 Offset: 0x19A2D31 VA: 0x19A2C30
	private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19A2F40 Offset: 0x19A3041 VA: 0x19A2F40
	private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19A30F0 Offset: 0x19A31F1 VA: 0x19A30F0
	private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19A32F0 Offset: 0x19A33F1 VA: 0x19A32F0
	private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19A3400 Offset: 0x19A3501 VA: 0x19A3400
	private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19A3510 Offset: 0x19A3611 VA: 0x19A3510
	private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19A3610 Offset: 0x19A3711 VA: 0x19A3610
	private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw) { }

	// RVA: 0x19A3690 Offset: 0x19A3791 VA: 0x19A3690
	private static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark) { }

	// RVA: 0x19A36E0 Offset: 0x19A37E1 VA: 0x19A36E0
	private static bool GetTimeOfN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x19A37A0 Offset: 0x19A38A1 VA: 0x19A37A0
	private static bool GetTimeOfNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x19A3860 Offset: 0x19A3961 VA: 0x19A3860
	private static bool GetTimeOfNNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x19A3930 Offset: 0x19A3A31 VA: 0x19A3930
	private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x19A3A00 Offset: 0x19A3B01 VA: 0x19A3A00
	private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x19A3AF0 Offset: 0x19A3BF1 VA: 0x19A3AF0
	private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19A3D80 Offset: 0x19A3E81 VA: 0x19A3D80
	private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok) { }

	// RVA: 0x19A3EC0 Offset: 0x19A3FC1 VA: 0x19A3EC0
	internal static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19A0AA0 Offset: 0x19A0BA1 VA: 0x19A0AA0
	internal static bool ProcessTerminaltState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x19A42B0 Offset: 0x19A43B1 VA: 0x19A42B0
	internal static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x19A4C50 Offset: 0x19A4D51 VA: 0x19A4C50
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x19A43A0 Offset: 0x19A44A1 VA: 0x19A43A0
	internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x19A57E0 Offset: 0x19A58E1 VA: 0x19A57E0
	private static bool DetermineTimeZoneAdjustments(ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly) { }

	// RVA: 0x19A59B0 Offset: 0x19A5AB1 VA: 0x19A59B0
	private static bool DateTimeOffsetTimeZonePostProcessing(ref DateTimeResult result, DateTimeStyles styles) { }

	// RVA: 0x19A5BC0 Offset: 0x19A5CC1 VA: 0x19A5BC0
	private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result) { }

	// RVA: 0x19A5CB0 Offset: 0x19A5DB1 VA: 0x19A5CB0
	private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly) { }

	// RVA: 0x19A4DA0 Offset: 0x19A4EA1 VA: 0x19A4DA0
	private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x19A60A0 Offset: 0x19A61A1 VA: 0x19A60A0
	internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number) { }

	// RVA: 0x19A5EE0 Offset: 0x19A5FE1 VA: 0x19A5EE0
	internal static bool ParseDigits(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x19A6190 Offset: 0x19A6291 VA: 0x19A6190
	internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result) { }

	// RVA: 0x19A6260 Offset: 0x19A6361 VA: 0x19A6260
	private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result) { }

	// RVA: 0x19A6390 Offset: 0x19A6491 VA: 0x19A6390
	private static bool ParseSign(ref __DTString str, ref bool result) { }

	// RVA: 0x19A6420 Offset: 0x19A6521 VA: 0x19A6420
	private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result) { }

	// RVA: 0x19A6700 Offset: 0x19A6801 VA: 0x19A6700
	private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x19A6890 Offset: 0x19A6991 VA: 0x19A6890
	private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x19A6A60 Offset: 0x19A6B61 VA: 0x19A6A60
	private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x19A6E50 Offset: 0x19A6F51 VA: 0x19A6E50
	private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x19A7240 Offset: 0x19A7341 VA: 0x19A7240
	private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x19A7390 Offset: 0x19A7491 VA: 0x19A7390
	private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x19A74C0 Offset: 0x19A75C1 VA: 0x19A74C0
	private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x19A75A0 Offset: 0x19A76A1 VA: 0x19A75A0
	private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result) { }

	// RVA: 0x19A1CD0 Offset: 0x19A1DD1 VA: 0x19A1CD0
	private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x19A54D0 Offset: 0x19A55D1 VA: 0x19A54D0
	private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles) { }

	// RVA: 0x19A7680 Offset: 0x19A7781 VA: 0x19A7680
	private static string ExpandPredefinedFormat(string format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result) { }

	// RVA: 0x19A7AA0 Offset: 0x19A7BA1 VA: 0x19A7AA0
	private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x19A8F30 Offset: 0x19A9031 VA: 0x19A8F30
	internal static bool TryParseQuoteString(string format, int pos, StringBuilder result, out int returnValue) { }

	// RVA: 0x199EEC0 Offset: 0x199EFC1 VA: 0x199EEC0
	private static bool DoStrictParse(string s, string formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x199EC80 Offset: 0x199ED81 VA: 0x199EC80
	private static Exception GetDateTimeParseException(ref DateTimeResult result) { }

	// RVA: 0x19A9060 Offset: 0x19A9161 VA: 0x19A9060
	private static void .cctor() { }
}

