[DefaultMemberAttribute] // RVA: 0xBC300 Offset: 0xBC401 VA: 0xBC300
internal class HeaderInfoTable // TypeDefIndex: 1912
{
	// Fields
	private static Hashtable HeaderHashTable; // 0x0
	private static HeaderInfo UnknownHeaderInfo; // 0x8
	private static HeaderParser SingleParser; // 0x10
	private static HeaderParser MultiParser; // 0x18

	// Properties
	internal HeaderInfo Item { get; }

	// Methods

	// RVA: 0x1789730 Offset: 0x1789831 VA: 0x1789730
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x17897E0 Offset: 0x17898E1 VA: 0x17897E0
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x1789B40 Offset: 0x1789C41 VA: 0x1789B40
	private static void .cctor() { }

	// RVA: 0x178BA00 Offset: 0x178BB01 VA: 0x178BA00
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x178BB00 Offset: 0x178BC01 VA: 0x178BB00
	public void .ctor() { }
}

