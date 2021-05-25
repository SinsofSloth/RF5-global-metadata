internal class TermInfoDriver : IConsoleDriver // TypeDefIndex: 404
{
	// Fields
	private static int* native_terminal_size; // 0x0
	private static int terminal_size; // 0x8
	private static readonly string[] locations; // 0x10
	private TermInfoReader reader; // 0x10
	private int cursorLeft; // 0x18
	private int cursorTop; // 0x1C
	private string title; // 0x20
	private string titleFormat; // 0x28
	private bool cursorVisible; // 0x30
	private string csrVisible; // 0x38
	private string csrInvisible; // 0x40
	private string clear; // 0x48
	private string bell; // 0x50
	private string term; // 0x58
	private StreamReader stdin; // 0x60
	private CStreamWriter stdout; // 0x68
	private int windowWidth; // 0x70
	private int windowHeight; // 0x74
	private int bufferHeight; // 0x78
	private int bufferWidth; // 0x7C
	private char[] buffer; // 0x80
	private int readpos; // 0x88
	private int writepos; // 0x8C
	private string keypadXmit; // 0x90
	private string keypadLocal; // 0x98
	private bool inited; // 0xA0
	private object initLock; // 0xA8
	private bool initKeys; // 0xB0
	private string origPair; // 0xB8
	private string origColors; // 0xC0
	private string cursorAddress; // 0xC8
	private ConsoleColor fgcolor; // 0xD0
	private string setfgcolor; // 0xD8
	private string setbgcolor; // 0xE0
	private int maxColors; // 0xE8
	private bool noGetPosition; // 0xEC
	private Hashtable keymap; // 0xF0
	private ByteMatcher rootmap; // 0xF8
	private int rl_startx; // 0x100
	private int rl_starty; // 0x104
	private byte[] control_characters; // 0x108
	private static readonly int[] _consoleColorToAnsiCode; // 0x18
	private char[] echobuf; // 0x110
	private int echon; // 0x118

	// Properties
	public bool Initialized { get; }
	public int WindowHeight { get; }
	public int WindowWidth { get; }

	// Methods

	// RVA: 0x2A6A570 Offset: 0x2A6A671 VA: 0x2A6A570
	private static string TryTermInfoDir(string dir, string term) { }

	// RVA: 0x2A6A6A0 Offset: 0x2A6A7A1 VA: 0x2A6A6A0
	private static string SearchTerminfo(string term) { }

	// RVA: 0x2A6A830 Offset: 0x2A6A931 VA: 0x2A6A830
	private void WriteConsole(string str) { }

	// RVA: 0x2A6A860 Offset: 0x2A6A961 VA: 0x2A6A860
	public void .ctor(string term) { }

	// RVA: 0x2A6AF90 Offset: 0x2A6B091 VA: 0x2A6AF90 Slot: 5
	public bool get_Initialized() { }

	// RVA: 0x2A6AFA0 Offset: 0x2A6B0A1 VA: 0x2A6AFA0 Slot: 6
	public void Init() { }

	// RVA: 0x2A6BE30 Offset: 0x2A6BF31 VA: 0x2A6BE30
	private void IncrementX() { }

	// RVA: 0x2A6BF50 Offset: 0x2A6C051 VA: 0x2A6BF50
	public void WriteSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x2A6C2A0 Offset: 0x2A6C3A1 VA: 0x2A6C2A0
	public void WriteSpecialKey(char c) { }

	// RVA: 0x2A6C470 Offset: 0x2A6C571 VA: 0x2A6C470
	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x2A6C510 Offset: 0x2A6C611 VA: 0x2A6C510
	public bool IsSpecialKey(char c) { }

	// RVA: 0x2A6BB50 Offset: 0x2A6BC51 VA: 0x2A6BB50
	private void GetCursorPosition() { }

	// RVA: 0x2A6C6C0 Offset: 0x2A6C7C1 VA: 0x2A6C6C0
	private void CheckWindowDimensions() { }

	// RVA: 0x2A6BF10 Offset: 0x2A6C011 VA: 0x2A6BF10 Slot: 7
	public int get_WindowHeight() { }

	// RVA: 0x2A6BED0 Offset: 0x2A6BFD1 VA: 0x2A6BED0 Slot: 8
	public int get_WindowWidth() { }

	// RVA: 0x2A6C5B0 Offset: 0x2A6C6B1 VA: 0x2A6C5B0
	private void AddToBuffer(int b) { }

	// RVA: 0x2A6C860 Offset: 0x2A6C961 VA: 0x2A6C860
	private void AdjustBuffer() { }

	// RVA: 0x2A6C2E0 Offset: 0x2A6C3E1 VA: 0x2A6C2E0
	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	// RVA: 0x2A6C880 Offset: 0x2A6C981 VA: 0x2A6C880
	private object GetKeyFromBuffer(bool cooked) { }

	// RVA: 0x2A6CB70 Offset: 0x2A6CC71 VA: 0x2A6CB70
	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	// RVA: 0x2A6CF00 Offset: 0x2A6D001 VA: 0x2A6CF00
	private bool InputPending() { }

	// RVA: 0x2A6CF30 Offset: 0x2A6D031 VA: 0x2A6CF30
	private void QueueEcho(char c) { }

	// RVA: 0x2A6D070 Offset: 0x2A6D171 VA: 0x2A6D070
	private void Echo(ConsoleKeyInfo key) { }

	// RVA: 0x2A6D150 Offset: 0x2A6D251 VA: 0x2A6D150
	private void EchoFlush() { }

	// RVA: 0x2A6D190 Offset: 0x2A6D291 VA: 0x2A6D190
	public int Read([In] [Out] char[] dest, int index, int count) { }

	// RVA: 0x2A6D910 Offset: 0x2A6DA11 VA: 0x2A6D910 Slot: 4
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x2A6D9A0 Offset: 0x2A6DAA1 VA: 0x2A6D9A0 Slot: 9
	public string ReadLine() { }

	// RVA: 0x2A6DC80 Offset: 0x2A6DD81 VA: 0x2A6DC80
	public string ReadToEnd() { }

	// RVA: 0x2A6D9B0 Offset: 0x2A6DAB1 VA: 0x2A6D9B0
	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	// RVA: 0x2A6C0A0 Offset: 0x2A6C1A1 VA: 0x2A6C0A0 Slot: 10
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x2A6DC90 Offset: 0x2A6DD91 VA: 0x2A6DC90
	private void CreateKeyMap() { }

	// RVA: 0x2A6CD60 Offset: 0x2A6CE61 VA: 0x2A6CD60
	private void InitKeys() { }

	// RVA: 0x2A6FB30 Offset: 0x2A6FC31 VA: 0x2A6FB30
	private void AddStringMapping(TermInfoStrings s) { }

	// RVA: 0x2A6FC60 Offset: 0x2A6FD61 VA: 0x2A6FC60
	private static void .cctor() { }
}

