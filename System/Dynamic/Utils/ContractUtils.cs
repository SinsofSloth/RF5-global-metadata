internal static class ContractUtils // TypeDefIndex: 2733
{
	// Properties
	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC1570 Offset: 0xC1671 VA: 0xC1570
	public static Exception Unreachable { get; }

	// Methods

	// RVA: 0x16A0010 Offset: 0x16A0111 VA: 0x16A0010
	public static Exception get_Unreachable() { }

	// RVA: 0x16A0080 Offset: 0x16A0181 VA: 0x16A0080
	public static void Requires(bool precondition, string paramName) { }

	// RVA: 0x169DCF0 Offset: 0x169DDF1 VA: 0x169DCF0
	public static void RequiresNotNull(object value, string paramName) { }

	// RVA: 0x16A0170 Offset: 0x16A0271 VA: 0x16A0170
	public static void RequiresNotNull(object value, string paramName, int index) { }

	// RVA: -1 Offset: -1
	public static void RequiresNotNullItems<T>(IList<T> array, string arrayName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24B6B20 Offset: 0x24B6C21 VA: 0x24B6B20
	|-ContractUtils.RequiresNotNullItems<CatchBlock>
	|-ContractUtils.RequiresNotNullItems<object>
	*/

	// RVA: 0x16A0210 Offset: 0x16A0311 VA: 0x16A0210
	private static string GetParamName(string paramName, int index) { }

	// RVA: -1 Offset: -1
	public static void RequiresArrayRange<T>(IList<T> array, int offset, int count, string offsetName, string countName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24B6840 Offset: 0x24B6941 VA: 0x24B6840
	|-ContractUtils.RequiresArrayRange<KeyValuePair<object, object>>
	|-ContractUtils.RequiresArrayRange<KeyValuePair<string, object>>
	|
	|-RVA: 0x24B69B0 Offset: 0x24B6AB1 VA: 0x24B69B0
	|-ContractUtils.RequiresArrayRange<object>
	|-ContractUtils.RequiresArrayRange<string>
	*/
}

