public class ScriptWork // TypeDefIndex: 7226
{
	// Fields
	private byte[] m_TextTableWork; // 0x10
	private int Addr; // 0x18
	private stCommand_t command; // 0x20
	private int commandNum; // 0x38
	private int commandIndex; // 0x3C
	public string filePath; // 0x40
	private static readonly int[][] CommandArgList; // 0x0

	// Methods

	// RVA: 0x21068B0 Offset: 0x21069B1 VA: 0x21068B0
	public bool LoadTextFile(byte[] byteWork) { }

	// RVA: 0x2106A20 Offset: 0x2106B21 VA: 0x2106A20
	public void Reset() { }

	// RVA: 0x2106A30 Offset: 0x2106B31 VA: 0x2106A30
	public void ForceEnd() { }

	// RVA: 0x2106980 Offset: 0x2106A81 VA: 0x2106980
	private int GetTextTableInt(int addr, int size) { }

	// RVA: 0x2106A40 Offset: 0x2106B41 VA: 0x2106A40
	private string GetTextTableString(int addr, int len) { }

	// RVA: 0x2106B90 Offset: 0x2106C91 VA: 0x2106B90
	public stCommand_t ReadNext() { }

	// RVA: 0x21071E0 Offset: 0x21072E1 VA: 0x21071E0
	public stCommand_t CommandSkip(CommandList cmd) { }

	// RVA: 0x2107270 Offset: 0x2107371 VA: 0x2107270
	public void .ctor() { }

	// RVA: 0x21072D0 Offset: 0x21073D1 VA: 0x21072D0
	private static void .cctor() { }
}

