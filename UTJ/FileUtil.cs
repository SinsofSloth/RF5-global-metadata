public class FileUtil // TypeDefIndex: 9176
{
	// Methods

	// RVA: 0x1FFE550 Offset: 0x1FFE651 VA: 0x1FFE550
	public static string ReadAllText(string inFilePath, Encoding inDefaultEncoding) { }

	// RVA: 0x1FFEA50 Offset: 0x1FFEB51 VA: 0x1FFEA50
	public static string ReadAllText(string inFilePath) { }

	// RVA: 0x1FFEA90 Offset: 0x1FFEB91 VA: 0x1FFEA90
	public static string[] ReadAllLines(string inFilePath, Encoding inDefaultEncoding) { }

	// RVA: 0x1FFEC10 Offset: 0x1FFED11 VA: 0x1FFEC10
	public static string[] ReadAllLines(string inFilePath) { }

	// RVA: 0x1FFEC50 Offset: 0x1FFED51 VA: 0x1FFEC50
	public static bool WriteAllText(string filePath, string text, Encoding encoding) { }

	// RVA: 0x1FFE6B0 Offset: 0x1FFE7B1 VA: 0x1FFE6B0
	public static Encoding TryToDetectEncoding(string inFilePath, Encoding inDefaultEncoding) { }

	// RVA: 0x1FFF000 Offset: 0x1FFF101 VA: 0x1FFF000
	public static Encoding TryToDetectEncoding(string inFilePath) { }

	// RVA: 0x1FFF030 Offset: 0x1FFF131 VA: 0x1FFF030
	public static void ExploreToDirectory(string directory) { }

	// RVA: 0x1FFEDD0 Offset: 0x1FFEED1 VA: 0x1FFEDD0
	private static byte[] ReadFirstBytesOfFile(string inFilePath, int inNumBytesToRead) { }

	// RVA: 0x1FFEF70 Offset: 0x1FFF071 VA: 0x1FFEF70
	private static bool CheckIfBufferStartsWithHeader(byte[] inBuffer, byte[] inHeader) { }

	// RVA: 0x1FFF040 Offset: 0x1FFF141 VA: 0x1FFF040
	public void .ctor() { }
}

