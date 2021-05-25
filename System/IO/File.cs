[ComVisibleAttribute] // RVA: 0xAEB20 Offset: 0xAEC21 VA: 0xAEB20
public static class File // TypeDefIndex: 679
{
	// Methods

	// RVA: 0x18A1720 Offset: 0x18A1821 VA: 0x18A1720
	public static StreamWriter AppendText(string path) { }

	// RVA: 0x18A1870 Offset: 0x18A1971 VA: 0x18A1870
	public static FileStream Create(string path) { }

	// RVA: 0x18A18F0 Offset: 0x18A19F1 VA: 0x18A18F0
	public static FileStream Create(string path, int bufferSize) { }

	// RVA: 0x18A19B0 Offset: 0x18A1AB1 VA: 0x18A19B0
	public static StreamWriter CreateText(string path) { }

	// RVA: 0x189FE00 Offset: 0x189FF01 VA: 0x189FE00
	public static void Delete(string path) { }

	// RVA: 0x189E760 Offset: 0x189E861 VA: 0x189E760
	public static bool Exists(string path) { }

	// RVA: 0x18A1EF0 Offset: 0x18A1FF1 VA: 0x18A1EF0
	public static void Move(string sourceFileName, string destFileName) { }

	// RVA: 0x18A2550 Offset: 0x18A2651 VA: 0x18A2550
	public static FileStream Open(string path, FileMode mode) { }

	// RVA: 0x18A2620 Offset: 0x18A2721 VA: 0x18A2620
	public static FileStream OpenRead(string path) { }

	// RVA: 0x18A26A0 Offset: 0x18A27A1 VA: 0x18A26A0
	public static StreamReader OpenText(string path) { }

	// RVA: 0x18A2800 Offset: 0x18A2901 VA: 0x18A2800
	public static string[] ReadAllLines(string path, Encoding encoding) { }

	// RVA: 0x18A2A10 Offset: 0x18A2B11 VA: 0x18A2A10
	private static string[] ReadAllLines(StreamReader reader) { }

	// RVA: 0x18A2BD0 Offset: 0x18A2CD1 VA: 0x18A2BD0
	public static string ReadAllText(string path) { }

	// RVA: 0x18A2D60 Offset: 0x18A2E61 VA: 0x18A2D60
	public static string ReadAllText(string path, Encoding encoding) { }

	// RVA: 0x18A2EF0 Offset: 0x18A2FF1 VA: 0x18A2EF0
	public static void WriteAllBytes(string path, byte[] bytes) { }

	// RVA: 0x18A3070 Offset: 0x18A3171 VA: 0x18A3070
	public static void WriteAllText(string path, string contents) { }

	// RVA: 0x18A30F0 Offset: 0x18A31F1 VA: 0x18A30F0
	public static void WriteAllText(string path, string contents, Encoding encoding) { }

	// RVA: 0x18A3240 Offset: 0x18A3341 VA: 0x18A3240
	internal static int FillAttributeInfo(string path, ref MonoIOStat data, bool tryagain, bool returnErrorOnNotFound) { }
}

