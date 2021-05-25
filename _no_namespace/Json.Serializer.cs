private sealed class Json.Serializer // TypeDefIndex: 4295
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x1A7F4A0 Offset: 0x1A7F5A1 VA: 0x1A7F4A0
	private void .ctor() { }

	// RVA: 0x1A7E1C0 Offset: 0x1A7E2C1 VA: 0x1A7E1C0
	public static string Serialize(object obj) { }

	// RVA: 0x1A7F520 Offset: 0x1A7F621 VA: 0x1A7F520
	private void SerializeValue(object value) { }

	// RVA: 0x1A7FC40 Offset: 0x1A7FD41 VA: 0x1A7FC40
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x1A7F950 Offset: 0x1A7FA51 VA: 0x1A7F950
	private void SerializeArray(IList anArray) { }

	// RVA: 0x1A7F6D0 Offset: 0x1A7F7D1 VA: 0x1A7F6D0
	private void SerializeString(string str) { }

	// RVA: 0x1A80090 Offset: 0x1A80191 VA: 0x1A80090
	private void SerializeOther(object value) { }
}

