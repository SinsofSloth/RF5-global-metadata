public static class Console // TypeDefIndex: 361
{
	// Fields
	internal static TextWriter stdout; // 0x0
	private static TextWriter stderr; // 0x8
	private static TextReader stdin; // 0x10
	private static Encoding inputEncoding; // 0x18
	private static Encoding outputEncoding; // 0x20
	private static ConsoleCancelEventHandler cancel_event; // 0x28
	private static readonly Console.InternalCancelHandler cancel_handler; // 0x30

	// Properties
	public static TextWriter Error { get; }
	public static Encoding InputEncoding { get; }
	public static Encoding OutputEncoding { get; }

	// Methods

	// RVA: 0x29773E0 Offset: 0x29774E1 VA: 0x29773E0
	private static void .cctor() { }

	// RVA: 0x2977810 Offset: 0x2977911 VA: 0x2977810
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	// RVA: 0x2977F40 Offset: 0x2978041 VA: 0x2977F40
	public static TextWriter get_Error() { }

	// RVA: 0x2977FB0 Offset: 0x29780B1 VA: 0x2977FB0
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	// RVA: 0x2977EA0 Offset: 0x2977FA1 VA: 0x2977EA0
	public static Stream OpenStandardError(int bufferSize) { }

	// RVA: 0x2977D60 Offset: 0x2977E61 VA: 0x2977D60
	public static Stream OpenStandardInput(int bufferSize) { }

	// RVA: 0x2977E00 Offset: 0x2977F01 VA: 0x2977E00
	public static Stream OpenStandardOutput(int bufferSize) { }

	// RVA: 0x29780E0 Offset: 0x29781E1 VA: 0x29780E0
	public static void SetOut(TextWriter newOut) { }

	// RVA: 0x2978190 Offset: 0x2978291 VA: 0x2978190
	public static Encoding get_InputEncoding() { }

	// RVA: 0x2978200 Offset: 0x2978301 VA: 0x2978200
	public static Encoding get_OutputEncoding() { }

	// RVA: 0x2978270 Offset: 0x2978371 VA: 0x2978270
	public static ConsoleKeyInfo ReadKey() { }

	// RVA: 0x2978330 Offset: 0x2978431 VA: 0x2978330
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x2978490 Offset: 0x2978591 VA: 0x2978490
	internal static void DoConsoleCancelEvent() { }
}

public static class Console // TypeDefIndex: 361
{
	// Fields
	internal static TextWriter stdout; // 0x0
	private static TextWriter stderr; // 0x8
	private static TextReader stdin; // 0x10
	private static Encoding inputEncoding; // 0x18
	private static Encoding outputEncoding; // 0x20
	private static ConsoleCancelEventHandler cancel_event; // 0x28
	private static readonly Console.InternalCancelHandler cancel_handler; // 0x30

	// Properties
	public static TextWriter Error { get; }
	public static Encoding InputEncoding { get; }
	public static Encoding OutputEncoding { get; }

	// Methods

	// RVA: 0x29773E0 Offset: 0x29774E1 VA: 0x29773E0
	private static void .cctor() { }

	// RVA: 0x2977810 Offset: 0x2977911 VA: 0x2977810
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	// RVA: 0x2977F40 Offset: 0x2978041 VA: 0x2977F40
	public static TextWriter get_Error() { }

	// RVA: 0x2977FB0 Offset: 0x29780B1 VA: 0x2977FB0
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	// RVA: 0x2977EA0 Offset: 0x2977FA1 VA: 0x2977EA0
	public static Stream OpenStandardError(int bufferSize) { }

	// RVA: 0x2977D60 Offset: 0x2977E61 VA: 0x2977D60
	public static Stream OpenStandardInput(int bufferSize) { }

	// RVA: 0x2977E00 Offset: 0x2977F01 VA: 0x2977E00
	public static Stream OpenStandardOutput(int bufferSize) { }

	// RVA: 0x29780E0 Offset: 0x29781E1 VA: 0x29780E0
	public static void SetOut(TextWriter newOut) { }

	// RVA: 0x2978190 Offset: 0x2978291 VA: 0x2978190
	public static Encoding get_InputEncoding() { }

	// RVA: 0x2978200 Offset: 0x2978301 VA: 0x2978200
	public static Encoding get_OutputEncoding() { }

	// RVA: 0x2978270 Offset: 0x2978371 VA: 0x2978270
	public static ConsoleKeyInfo ReadKey() { }

	// RVA: 0x2978330 Offset: 0x2978431 VA: 0x2978330
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x2978490 Offset: 0x2978591 VA: 0x2978490
	internal static void DoConsoleCancelEvent() { }
}

public static class Console // TypeDefIndex: 361
{
	// Fields
	internal static TextWriter stdout; // 0x0
	private static TextWriter stderr; // 0x8
	private static TextReader stdin; // 0x10
	private static Encoding inputEncoding; // 0x18
	private static Encoding outputEncoding; // 0x20
	private static ConsoleCancelEventHandler cancel_event; // 0x28
	private static readonly Console.InternalCancelHandler cancel_handler; // 0x30

	// Properties
	public static TextWriter Error { get; }
	public static Encoding InputEncoding { get; }
	public static Encoding OutputEncoding { get; }

	// Methods

	// RVA: 0x29773E0 Offset: 0x29774E1 VA: 0x29773E0
	private static void .cctor() { }

	// RVA: 0x2977810 Offset: 0x2977911 VA: 0x2977810
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	// RVA: 0x2977F40 Offset: 0x2978041 VA: 0x2977F40
	public static TextWriter get_Error() { }

	// RVA: 0x2977FB0 Offset: 0x29780B1 VA: 0x2977FB0
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	// RVA: 0x2977EA0 Offset: 0x2977FA1 VA: 0x2977EA0
	public static Stream OpenStandardError(int bufferSize) { }

	// RVA: 0x2977D60 Offset: 0x2977E61 VA: 0x2977D60
	public static Stream OpenStandardInput(int bufferSize) { }

	// RVA: 0x2977E00 Offset: 0x2977F01 VA: 0x2977E00
	public static Stream OpenStandardOutput(int bufferSize) { }

	// RVA: 0x29780E0 Offset: 0x29781E1 VA: 0x29780E0
	public static void SetOut(TextWriter newOut) { }

	// RVA: 0x2978190 Offset: 0x2978291 VA: 0x2978190
	public static Encoding get_InputEncoding() { }

	// RVA: 0x2978200 Offset: 0x2978301 VA: 0x2978200
	public static Encoding get_OutputEncoding() { }

	// RVA: 0x2978270 Offset: 0x2978371 VA: 0x2978270
	public static ConsoleKeyInfo ReadKey() { }

	// RVA: 0x2978330 Offset: 0x2978431 VA: 0x2978330
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x2978490 Offset: 0x2978591 VA: 0x2978490
	internal static void DoConsoleCancelEvent() { }
}

public static class Console // TypeDefIndex: 361
{
	// Fields
	internal static TextWriter stdout; // 0x0
	private static TextWriter stderr; // 0x8
	private static TextReader stdin; // 0x10
	private static Encoding inputEncoding; // 0x18
	private static Encoding outputEncoding; // 0x20
	private static ConsoleCancelEventHandler cancel_event; // 0x28
	private static readonly Console.InternalCancelHandler cancel_handler; // 0x30

	// Properties
	public static TextWriter Error { get; }
	public static Encoding InputEncoding { get; }
	public static Encoding OutputEncoding { get; }

	// Methods

	// RVA: 0x29773E0 Offset: 0x29774E1 VA: 0x29773E0
	private static void .cctor() { }

	// RVA: 0x2977810 Offset: 0x2977911 VA: 0x2977810
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	// RVA: 0x2977F40 Offset: 0x2978041 VA: 0x2977F40
	public static TextWriter get_Error() { }

	// RVA: 0x2977FB0 Offset: 0x29780B1 VA: 0x2977FB0
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	// RVA: 0x2977EA0 Offset: 0x2977FA1 VA: 0x2977EA0
	public static Stream OpenStandardError(int bufferSize) { }

	// RVA: 0x2977D60 Offset: 0x2977E61 VA: 0x2977D60
	public static Stream OpenStandardInput(int bufferSize) { }

	// RVA: 0x2977E00 Offset: 0x2977F01 VA: 0x2977E00
	public static Stream OpenStandardOutput(int bufferSize) { }

	// RVA: 0x29780E0 Offset: 0x29781E1 VA: 0x29780E0
	public static void SetOut(TextWriter newOut) { }

	// RVA: 0x2978190 Offset: 0x2978291 VA: 0x2978190
	public static Encoding get_InputEncoding() { }

	// RVA: 0x2978200 Offset: 0x2978301 VA: 0x2978200
	public static Encoding get_OutputEncoding() { }

	// RVA: 0x2978270 Offset: 0x2978371 VA: 0x2978270
	public static ConsoleKeyInfo ReadKey() { }

	// RVA: 0x2978330 Offset: 0x2978431 VA: 0x2978330
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x2978490 Offset: 0x2978591 VA: 0x2978490
	internal static void DoConsoleCancelEvent() { }
}

public static class Console // TypeDefIndex: 361
{
	// Fields
	internal static TextWriter stdout; // 0x0
	private static TextWriter stderr; // 0x8
	private static TextReader stdin; // 0x10
	private static Encoding inputEncoding; // 0x18
	private static Encoding outputEncoding; // 0x20
	private static ConsoleCancelEventHandler cancel_event; // 0x28
	private static readonly Console.InternalCancelHandler cancel_handler; // 0x30

	// Properties
	public static TextWriter Error { get; }
	public static Encoding InputEncoding { get; }
	public static Encoding OutputEncoding { get; }

	// Methods

	// RVA: 0x29773E0 Offset: 0x29774E1 VA: 0x29773E0
	private static void .cctor() { }

	// RVA: 0x2977810 Offset: 0x2977911 VA: 0x2977810
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	// RVA: 0x2977F40 Offset: 0x2978041 VA: 0x2977F40
	public static TextWriter get_Error() { }

	// RVA: 0x2977FB0 Offset: 0x29780B1 VA: 0x2977FB0
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	// RVA: 0x2977EA0 Offset: 0x2977FA1 VA: 0x2977EA0
	public static Stream OpenStandardError(int bufferSize) { }

	// RVA: 0x2977D60 Offset: 0x2977E61 VA: 0x2977D60
	public static Stream OpenStandardInput(int bufferSize) { }

	// RVA: 0x2977E00 Offset: 0x2977F01 VA: 0x2977E00
	public static Stream OpenStandardOutput(int bufferSize) { }

	// RVA: 0x29780E0 Offset: 0x29781E1 VA: 0x29780E0
	public static void SetOut(TextWriter newOut) { }

	// RVA: 0x2978190 Offset: 0x2978291 VA: 0x2978190
	public static Encoding get_InputEncoding() { }

	// RVA: 0x2978200 Offset: 0x2978301 VA: 0x2978200
	public static Encoding get_OutputEncoding() { }

	// RVA: 0x2978270 Offset: 0x2978371 VA: 0x2978270
	public static ConsoleKeyInfo ReadKey() { }

	// RVA: 0x2978330 Offset: 0x2978431 VA: 0x2978330
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x2978490 Offset: 0x2978591 VA: 0x2978490
	internal static void DoConsoleCancelEvent() { }
}

public static class Console // TypeDefIndex: 361
{
	// Fields
	internal static TextWriter stdout; // 0x0
	private static TextWriter stderr; // 0x8
	private static TextReader stdin; // 0x10
	private static Encoding inputEncoding; // 0x18
	private static Encoding outputEncoding; // 0x20
	private static ConsoleCancelEventHandler cancel_event; // 0x28
	private static readonly Console.InternalCancelHandler cancel_handler; // 0x30

	// Properties
	public static TextWriter Error { get; }
	public static Encoding InputEncoding { get; }
	public static Encoding OutputEncoding { get; }

	// Methods

	// RVA: 0x29773E0 Offset: 0x29774E1 VA: 0x29773E0
	private static void .cctor() { }

	// RVA: 0x2977810 Offset: 0x2977911 VA: 0x2977810
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	// RVA: 0x2977F40 Offset: 0x2978041 VA: 0x2977F40
	public static TextWriter get_Error() { }

	// RVA: 0x2977FB0 Offset: 0x29780B1 VA: 0x2977FB0
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	// RVA: 0x2977EA0 Offset: 0x2977FA1 VA: 0x2977EA0
	public static Stream OpenStandardError(int bufferSize) { }

	// RVA: 0x2977D60 Offset: 0x2977E61 VA: 0x2977D60
	public static Stream OpenStandardInput(int bufferSize) { }

	// RVA: 0x2977E00 Offset: 0x2977F01 VA: 0x2977E00
	public static Stream OpenStandardOutput(int bufferSize) { }

	// RVA: 0x29780E0 Offset: 0x29781E1 VA: 0x29780E0
	public static void SetOut(TextWriter newOut) { }

	// RVA: 0x2978190 Offset: 0x2978291 VA: 0x2978190
	public static Encoding get_InputEncoding() { }

	// RVA: 0x2978200 Offset: 0x2978301 VA: 0x2978200
	public static Encoding get_OutputEncoding() { }

	// RVA: 0x2978270 Offset: 0x2978371 VA: 0x2978270
	public static ConsoleKeyInfo ReadKey() { }

	// RVA: 0x2978330 Offset: 0x2978431 VA: 0x2978330
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x2978490 Offset: 0x2978591 VA: 0x2978490
	internal static void DoConsoleCancelEvent() { }
}

