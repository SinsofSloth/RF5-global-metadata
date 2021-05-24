internal class WindowsConsoleDriver : IConsoleDriver // TypeDefIndex: 438
{
	// Fields
	private IntPtr inputHandle; // 0x10
	private IntPtr outputHandle; // 0x18
	private short defaultAttribute; // 0x20

	// Methods

	// RVA: 0x1AE8AF0 Offset: 0x1AE8BF1 VA: 0x1AE8AF0
	public void .ctor() { }

	// RVA: 0x1AE8D90 Offset: 0x1AE8E91 VA: 0x1AE8D90 Slot: 4
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x1AE90A0 Offset: 0x1AE91A1 VA: 0x1AE90A0
	private static bool IsModifierKey(short virtualKeyCode) { }

	// RVA: 0x1AE8C60 Offset: 0x1AE8D61 VA: 0x1AE8C60
	private static extern IntPtr GetStdHandle(Handles handle) { }

	// RVA: 0x1AE8CF0 Offset: 0x1AE8DF1 VA: 0x1AE8CF0
	private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

	// RVA: 0x1AE8FB0 Offset: 0x1AE90B1 VA: 0x1AE8FB0
	private static extern bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }
}

