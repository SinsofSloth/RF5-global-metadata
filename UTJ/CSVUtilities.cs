public static class CSVUtilities // TypeDefIndex: 9173
{
	// Fields
	private const string DefaultSeparators = ",\t";

	// Methods

	// RVA: 0x1FFA360 Offset: 0x1FFA461 VA: 0x1FFA360
	public static string BuildCSVItem(string source) { }

	// RVA: 0x1FFB470 Offset: 0x1FFB571 VA: 0x1FFB470
	public static string BuildCSVItem(string source, string separatorCharacters) { }

	// RVA: 0x1FFB5D0 Offset: 0x1FFB6D1 VA: 0x1FFB5D0
	public static IList<string> ReadNextCSVRow(TextReader reader) { }

	// RVA: 0x1FFB620 Offset: 0x1FFB721 VA: 0x1FFB620
	public static IList<string> ReadNextCSVRow(TextReader reader, string separatorCharacters) { }
}

