private sealed class MiniJSON.Serializer // TypeDefIndex: 4679
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x1B20780 Offset: 0x1B20881 VA: 0x1B20780
	private void .ctor() { }

	// RVA: 0x1B1F3F0 Offset: 0x1B1F4F1 VA: 0x1B1F3F0
	public static string Serialize(object obj) { }

	// RVA: 0x1B20800 Offset: 0x1B20901 VA: 0x1B20800
	private void SerializeValue(object value) { }

	// RVA: 0x1B20DF0 Offset: 0x1B20EF1 VA: 0x1B20DF0
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x1B20C30 Offset: 0x1B20D31 VA: 0x1B20C30
	private void SerializeArray(IList anArray) { }

	// RVA: 0x1B209B0 Offset: 0x1B20AB1 VA: 0x1B209B0
	private void SerializeString(string str) { }

	// RVA: 0x1B21240 Offset: 0x1B21341 VA: 0x1B21240
	private void SerializeOther(object value) { }
}

