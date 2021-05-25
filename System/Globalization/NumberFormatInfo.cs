[ComVisibleAttribute] // RVA: 0xAEE60 Offset: 0xAEF61 VA: 0xAEE60
[Serializable]
public sealed class NumberFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 727
{
	// Fields
	private static NumberFormatInfo invariantInfo; // 0x0
	internal int[] numberGroupSizes; // 0x10
	internal int[] currencyGroupSizes; // 0x18
	internal int[] percentGroupSizes; // 0x20
	internal string positiveSign; // 0x28
	internal string negativeSign; // 0x30
	internal string numberDecimalSeparator; // 0x38
	internal string numberGroupSeparator; // 0x40
	internal string currencyGroupSeparator; // 0x48
	internal string currencyDecimalSeparator; // 0x50
	internal string currencySymbol; // 0x58
	internal string ansiCurrencySymbol; // 0x60
	internal string nanSymbol; // 0x68
	internal string positiveInfinitySymbol; // 0x70
	internal string negativeInfinitySymbol; // 0x78
	internal string percentDecimalSeparator; // 0x80
	internal string percentGroupSeparator; // 0x88
	internal string percentSymbol; // 0x90
	internal string perMilleSymbol; // 0x98
	[OptionalFieldAttribute] // RVA: 0xB50A0 Offset: 0xB51A1 VA: 0xB50A0
	internal string[] nativeDigits; // 0xA0
	[OptionalFieldAttribute] // RVA: 0xB50E0 Offset: 0xB51E1 VA: 0xB50E0
	internal int m_dataItem; // 0xA8
	internal int numberDecimalDigits; // 0xAC
	internal int currencyDecimalDigits; // 0xB0
	internal int currencyPositivePattern; // 0xB4
	internal int currencyNegativePattern; // 0xB8
	internal int numberNegativePattern; // 0xBC
	internal int percentPositivePattern; // 0xC0
	internal int percentNegativePattern; // 0xC4
	internal int percentDecimalDigits; // 0xC8
	[OptionalFieldAttribute] // RVA: 0xB5120 Offset: 0xB5221 VA: 0xB5120
	internal int digitSubstitution; // 0xCC
	internal bool isReadOnly; // 0xD0
	[OptionalFieldAttribute] // RVA: 0xB5160 Offset: 0xB5261 VA: 0xB5160
	internal bool m_useUserOverride; // 0xD1
	[OptionalFieldAttribute] // RVA: 0xB51A0 Offset: 0xB52A1 VA: 0xB51A0
	internal bool m_isInvariant; // 0xD2
	[OptionalFieldAttribute] // RVA: 0xB51E0 Offset: 0xB52E1 VA: 0xB51E0
	internal bool validForParseAsNumber; // 0xD3
	[OptionalFieldAttribute] // RVA: 0xB5220 Offset: 0xB5321 VA: 0xB5220
	internal bool validForParseAsCurrency; // 0xD4
	private const NumberStyles InvalidNumberStyles = -1024;

	// Properties
	public static NumberFormatInfo InvariantInfo { get; }
	public int CurrencyDecimalDigits { get; }
	public string CurrencyDecimalSeparator { get; }
	public bool IsReadOnly { get; }
	public int[] CurrencyGroupSizes { get; }
	public int[] NumberGroupSizes { get; }
	public int[] PercentGroupSizes { get; }
	public string CurrencyGroupSeparator { get; }
	public string CurrencySymbol { get; }
	public static NumberFormatInfo CurrentInfo { get; }
	public string NaNSymbol { get; }
	public int CurrencyNegativePattern { get; }
	public int NumberNegativePattern { get; }
	public int PercentPositivePattern { get; }
	public int PercentNegativePattern { get; }
	public string NegativeInfinitySymbol { get; }
	public string NegativeSign { get; }
	public int NumberDecimalDigits { get; }
	public string NumberDecimalSeparator { get; }
	public string NumberGroupSeparator { get; }
	public int CurrencyPositivePattern { get; }
	public string PositiveInfinitySymbol { get; }
	public string PositiveSign { get; }
	public int PercentDecimalDigits { get; }
	public string PercentDecimalSeparator { get; }
	public string PercentGroupSeparator { get; }
	public string PercentSymbol { get; }
	public string PerMilleSymbol { get; }

	// Methods

	// RVA: 0x19C6DE0 Offset: 0x19C6EE1 VA: 0x19C6DE0
	public void .ctor() { }

	[OnSerializingAttribute] // RVA: 0xB88A0 Offset: 0xB89A1 VA: 0xB88A0
	// RVA: 0x19C73D0 Offset: 0x19C74D1 VA: 0x19C73D0
	private void OnSerializing(StreamingContext ctx) { }

	[OnDeserializingAttribute] // RVA: 0xB88B0 Offset: 0xB89B1 VA: 0xB88B0
	// RVA: 0x19C7470 Offset: 0x19C7571 VA: 0x19C7470
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserializedAttribute] // RVA: 0xB88C0 Offset: 0xB89C1 VA: 0xB88C0
	// RVA: 0x19C7480 Offset: 0x19C7581 VA: 0x19C7480
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x19C6DF0 Offset: 0x19C6EF1 VA: 0x19C6DF0
	internal void .ctor(CultureData cultureData) { }

	// RVA: 0x19C7490 Offset: 0x19C7591 VA: 0x19C7490
	public static NumberFormatInfo get_InvariantInfo() { }

	// RVA: 0x19C7630 Offset: 0x19C7731 VA: 0x19C7630
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	// RVA: 0x19C78D0 Offset: 0x19C79D1 VA: 0x19C78D0 Slot: 4
	public object Clone() { }

	// RVA: 0x19C7950 Offset: 0x19C7A51 VA: 0x19C7950
	public int get_CurrencyDecimalDigits() { }

	// RVA: 0x19C7960 Offset: 0x19C7A61 VA: 0x19C7960
	public string get_CurrencyDecimalSeparator() { }

	// RVA: 0x19C7970 Offset: 0x19C7A71 VA: 0x19C7970
	public bool get_IsReadOnly() { }

	// RVA: 0x19C7980 Offset: 0x19C7A81 VA: 0x19C7980
	public int[] get_CurrencyGroupSizes() { }

	// RVA: 0x19C7A00 Offset: 0x19C7B01 VA: 0x19C7A00
	public int[] get_NumberGroupSizes() { }

	// RVA: 0x19C7A80 Offset: 0x19C7B81 VA: 0x19C7A80
	public int[] get_PercentGroupSizes() { }

	// RVA: 0x19C7B00 Offset: 0x19C7C01 VA: 0x19C7B00
	public string get_CurrencyGroupSeparator() { }

	// RVA: 0x19C7B10 Offset: 0x19C7C11 VA: 0x19C7B10
	public string get_CurrencySymbol() { }

	// RVA: 0x19C77E0 Offset: 0x19C78E1 VA: 0x19C77E0
	public static NumberFormatInfo get_CurrentInfo() { }

	// RVA: 0x19C7B20 Offset: 0x19C7C21 VA: 0x19C7B20
	public string get_NaNSymbol() { }

	// RVA: 0x19C7B30 Offset: 0x19C7C31 VA: 0x19C7B30
	public int get_CurrencyNegativePattern() { }

	// RVA: 0x19C7B40 Offset: 0x19C7C41 VA: 0x19C7B40
	public int get_NumberNegativePattern() { }

	// RVA: 0x19C7B50 Offset: 0x19C7C51 VA: 0x19C7B50
	public int get_PercentPositivePattern() { }

	// RVA: 0x19C7B60 Offset: 0x19C7C61 VA: 0x19C7B60
	public int get_PercentNegativePattern() { }

	// RVA: 0x19C7B70 Offset: 0x19C7C71 VA: 0x19C7B70
	public string get_NegativeInfinitySymbol() { }

	// RVA: 0x19C7B80 Offset: 0x19C7C81 VA: 0x19C7B80
	public string get_NegativeSign() { }

	// RVA: 0x19C7B90 Offset: 0x19C7C91 VA: 0x19C7B90
	public int get_NumberDecimalDigits() { }

	// RVA: 0x19C7BA0 Offset: 0x19C7CA1 VA: 0x19C7BA0
	public string get_NumberDecimalSeparator() { }

	// RVA: 0x19C7BB0 Offset: 0x19C7CB1 VA: 0x19C7BB0
	public string get_NumberGroupSeparator() { }

	// RVA: 0x19C7BC0 Offset: 0x19C7CC1 VA: 0x19C7BC0
	public int get_CurrencyPositivePattern() { }

	// RVA: 0x19C7BD0 Offset: 0x19C7CD1 VA: 0x19C7BD0
	public string get_PositiveInfinitySymbol() { }

	// RVA: 0x19C7BE0 Offset: 0x19C7CE1 VA: 0x19C7BE0
	public string get_PositiveSign() { }

	// RVA: 0x19C7BF0 Offset: 0x19C7CF1 VA: 0x19C7BF0
	public int get_PercentDecimalDigits() { }

	// RVA: 0x19C7C00 Offset: 0x19C7D01 VA: 0x19C7C00
	public string get_PercentDecimalSeparator() { }

	// RVA: 0x19C7C10 Offset: 0x19C7D11 VA: 0x19C7C10
	public string get_PercentGroupSeparator() { }

	// RVA: 0x19C7C20 Offset: 0x19C7D21 VA: 0x19C7C20
	public string get_PercentSymbol() { }

	// RVA: 0x19C7C30 Offset: 0x19C7D31 VA: 0x19C7C30
	public string get_PerMilleSymbol() { }

	// RVA: 0x19C7C40 Offset: 0x19C7D41 VA: 0x19C7C40 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x19C7550 Offset: 0x19C7651 VA: 0x19C7550
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	// RVA: 0x19C7CE0 Offset: 0x19C7DE1 VA: 0x19C7CE0
	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	// RVA: 0x19C7DD0 Offset: 0x19C7ED1 VA: 0x19C7DD0
	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }
}

