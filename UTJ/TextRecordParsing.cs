public class TextRecordParsing // TypeDefIndex: 9188
{
	// Fields
	public const string DefaultSeparators = "\t,";

	// Properties
	public static IEnumerable<string> DefaultCommentPrefixes { get; }

	// Methods

	// RVA: 0x23A5DB0 Offset: 0x23A5EB1 VA: 0x23A5DB0
	public static IEnumerable<string> get_DefaultCommentPrefixes() { }

	// RVA: 0x23A5F10 Offset: 0x23A6011 VA: 0x23A5F10
	public static string GetString(List<string> items, int index) { }

	// RVA: 0x23A5FA0 Offset: 0x23A60A1 VA: 0x23A5FA0
	public static bool GetBool(List<string> items, int index) { }

	// RVA: 0x23A6110 Offset: 0x23A6211 VA: 0x23A6110
	public static bool GetInt(List<string> items, int index, ref int output) { }

	// RVA: 0x23A61D0 Offset: 0x23A62D1 VA: 0x23A61D0
	public static bool GetFloat(List<string> items, int index, ref float output) { }

	// RVA: 0x23A6290 Offset: 0x23A6391 VA: 0x23A6290
	public static bool GetVector3(List<string> items, int startIndex, ref Vector3 output) { }

	// RVA: 0x23A63D0 Offset: 0x23A64D1 VA: 0x23A63D0
	public static List<TextRecordParsing.Record> ParseRecordsFromReader(TextReader reader, string entrySeparators = "\t,", IEnumerable<string> commentPrefixes) { }

	// RVA: 0x23A68B0 Offset: 0x23A69B1 VA: 0x23A68B0
	public static List<TextRecordParsing.Record> ParseRecordsFromFile(string sourcePath, Encoding encoding, string entrySeparators = "\t,", IEnumerable<string> commentPrefixes) { }

	// RVA: 0x23A0030 Offset: 0x23A0131 VA: 0x23A0030
	public static List<TextRecordParsing.Record> ParseRecordsFromText(string sourceText, string entrySeparators = "\t,", IEnumerable<string> commentPrefixes) { }

	// RVA: 0x23A0270 Offset: 0x23A0371 VA: 0x23A0270
	public static List<TextRecordParsing.Record> GetSectionRecords(List<TextRecordParsing.Record> sourceRecords, string sectionName) { }

	// RVA: 0x23A6730 Offset: 0x23A6831 VA: 0x23A6730
	private static bool LineIsCommentedOut(string trimmedLine, IEnumerable<string> commentPrefixes) { }

	// RVA: 0x23A6B30 Offset: 0x23A6C31 VA: 0x23A6B30
	public void .ctor() { }
}

