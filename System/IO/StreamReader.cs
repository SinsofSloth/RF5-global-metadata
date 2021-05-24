[ComVisibleAttribute] // RVA: 0xAEA20 Offset: 0xAEB21 VA: 0xAEA20
[Serializable]
public class StreamReader : TextReader // TypeDefIndex: 663
{
	// Fields
	public static readonly StreamReader Null; // 0x0
	private Stream stream; // 0x18
	private Encoding encoding; // 0x20
	private Decoder decoder; // 0x28
	private byte[] byteBuffer; // 0x30
	private char[] charBuffer; // 0x38
	private byte[] _preamble; // 0x40
	private int charPos; // 0x48
	private int charLen; // 0x4C
	private int byteLen; // 0x50
	private int bytePos; // 0x54
	private int _maxCharsPerBuffer; // 0x58
	private bool _detectEncoding; // 0x5C
	private bool _checkPreamble; // 0x5D
	private bool _isBlocked; // 0x5E
	private bool _closable; // 0x5F
	private Task _asyncReadTask; // 0x60

	// Properties
	internal static int DefaultBufferSize { get; }
	public virtual Encoding CurrentEncoding { get; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }
	public bool EndOfStream { get; }

	// Methods

	// RVA: 0x18B3200 Offset: 0x18B3301 VA: 0x18B3200
	internal static int get_DefaultBufferSize() { }

	// RVA: 0x18B3210 Offset: 0x18B3311 VA: 0x18B3210
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x18B32C0 Offset: 0x18B33C1 VA: 0x18B32C0
	internal void .ctor() { }

	// RVA: 0x18B3340 Offset: 0x18B3441 VA: 0x18B3340
	public void .ctor(Stream stream) { }

	// RVA: 0x18B33D0 Offset: 0x18B34D1 VA: 0x18B33D0
	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x189C930 Offset: 0x189CA31 VA: 0x189C930
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x18B3470 Offset: 0x18B3571 VA: 0x18B3470
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18A2770 Offset: 0x18A2871 VA: 0x18A2770
	public void .ctor(string path) { }

	// RVA: 0x18B37A0 Offset: 0x18B38A1 VA: 0x18B37A0
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x18A2980 Offset: 0x18A2A81 VA: 0x18A2980
	public void .ctor(string path, Encoding encoding) { }

	// RVA: 0x18B3840 Offset: 0x18B3941 VA: 0x18B3840
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x18B3850 Offset: 0x18B3951 VA: 0x18B3850
	internal void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost) { }

	// RVA: 0x18B3620 Offset: 0x18B3721 VA: 0x18B3620
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18B3A50 Offset: 0x18B3B51 VA: 0x18B3A50
	internal void Init(Stream stream) { }

	// RVA: 0x18B3A80 Offset: 0x18B3B81 VA: 0x18B3A80 Slot: 7
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B3B80 Offset: 0x18B3C81 VA: 0x18B3B80 Slot: 13
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x18B3B90 Offset: 0x18B3C91 VA: 0x18B3B90 Slot: 14
	public virtual Stream get_BaseStream() { }

	// RVA: 0x18B3B60 Offset: 0x18B3C61 VA: 0x18B3B60
	internal bool get_LeaveOpen() { }

	// RVA: 0x18A2B60 Offset: 0x18A2C61 VA: 0x18A2B60
	public bool get_EndOfStream() { }

	// RVA: 0x189CA90 Offset: 0x189CB91 VA: 0x189CA90 Slot: 8
	public override int Peek() { }

	// RVA: 0x18B3BA0 Offset: 0x18B3CA1 VA: 0x18B3BA0
	internal bool DataAvailable() { }

	// RVA: 0x18B3BB0 Offset: 0x18B3CB1 VA: 0x18B3BB0 Slot: 9
	public override int Read() { }

	// RVA: 0x18B3C50 Offset: 0x18B3D51 VA: 0x18B3C50 Slot: 10
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x18B40E0 Offset: 0x18B41E1 VA: 0x18B40E0 Slot: 11
	public override string ReadToEnd() { }

	// RVA: 0x18B41C0 Offset: 0x18B42C1 VA: 0x18B41C0
	private void CompressBuffer(int n) { }

	// RVA: 0x18B4210 Offset: 0x18B4311 VA: 0x18B4210
	private void DetectEncoding() { }

	// RVA: 0x18B4540 Offset: 0x18B4641 VA: 0x18B4540
	private bool IsPreamble() { }

	// RVA: 0x18B4660 Offset: 0x18B4761 VA: 0x18B4660 Slot: 15
	internal virtual int ReadBuffer() { }

	// RVA: 0x18B3EB0 Offset: 0x18B3FB1 VA: 0x18B3EB0
	private int ReadBuffer(char[] userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer) { }

	// RVA: 0x18B4810 Offset: 0x18B4911 VA: 0x18B4810 Slot: 12
	public override string ReadLine() { }

	// RVA: 0x18B4A20 Offset: 0x18B4B21 VA: 0x18B4A20
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEA20 Offset: 0xAEB21 VA: 0xAEA20
[Serializable]
public class StreamReader : TextReader // TypeDefIndex: 663
{
	// Fields
	public static readonly StreamReader Null; // 0x0
	private Stream stream; // 0x18
	private Encoding encoding; // 0x20
	private Decoder decoder; // 0x28
	private byte[] byteBuffer; // 0x30
	private char[] charBuffer; // 0x38
	private byte[] _preamble; // 0x40
	private int charPos; // 0x48
	private int charLen; // 0x4C
	private int byteLen; // 0x50
	private int bytePos; // 0x54
	private int _maxCharsPerBuffer; // 0x58
	private bool _detectEncoding; // 0x5C
	private bool _checkPreamble; // 0x5D
	private bool _isBlocked; // 0x5E
	private bool _closable; // 0x5F
	private Task _asyncReadTask; // 0x60

	// Properties
	internal static int DefaultBufferSize { get; }
	public virtual Encoding CurrentEncoding { get; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }
	public bool EndOfStream { get; }

	// Methods

	// RVA: 0x18B3200 Offset: 0x18B3301 VA: 0x18B3200
	internal static int get_DefaultBufferSize() { }

	// RVA: 0x18B3210 Offset: 0x18B3311 VA: 0x18B3210
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x18B32C0 Offset: 0x18B33C1 VA: 0x18B32C0
	internal void .ctor() { }

	// RVA: 0x18B3340 Offset: 0x18B3441 VA: 0x18B3340
	public void .ctor(Stream stream) { }

	// RVA: 0x18B33D0 Offset: 0x18B34D1 VA: 0x18B33D0
	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x189C930 Offset: 0x189CA31 VA: 0x189C930
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x18B3470 Offset: 0x18B3571 VA: 0x18B3470
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18A2770 Offset: 0x18A2871 VA: 0x18A2770
	public void .ctor(string path) { }

	// RVA: 0x18B37A0 Offset: 0x18B38A1 VA: 0x18B37A0
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x18A2980 Offset: 0x18A2A81 VA: 0x18A2980
	public void .ctor(string path, Encoding encoding) { }

	// RVA: 0x18B3840 Offset: 0x18B3941 VA: 0x18B3840
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x18B3850 Offset: 0x18B3951 VA: 0x18B3850
	internal void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost) { }

	// RVA: 0x18B3620 Offset: 0x18B3721 VA: 0x18B3620
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18B3A50 Offset: 0x18B3B51 VA: 0x18B3A50
	internal void Init(Stream stream) { }

	// RVA: 0x18B3A80 Offset: 0x18B3B81 VA: 0x18B3A80 Slot: 7
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B3B80 Offset: 0x18B3C81 VA: 0x18B3B80 Slot: 13
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x18B3B90 Offset: 0x18B3C91 VA: 0x18B3B90 Slot: 14
	public virtual Stream get_BaseStream() { }

	// RVA: 0x18B3B60 Offset: 0x18B3C61 VA: 0x18B3B60
	internal bool get_LeaveOpen() { }

	// RVA: 0x18A2B60 Offset: 0x18A2C61 VA: 0x18A2B60
	public bool get_EndOfStream() { }

	// RVA: 0x189CA90 Offset: 0x189CB91 VA: 0x189CA90 Slot: 8
	public override int Peek() { }

	// RVA: 0x18B3BA0 Offset: 0x18B3CA1 VA: 0x18B3BA0
	internal bool DataAvailable() { }

	// RVA: 0x18B3BB0 Offset: 0x18B3CB1 VA: 0x18B3BB0 Slot: 9
	public override int Read() { }

	// RVA: 0x18B3C50 Offset: 0x18B3D51 VA: 0x18B3C50 Slot: 10
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x18B40E0 Offset: 0x18B41E1 VA: 0x18B40E0 Slot: 11
	public override string ReadToEnd() { }

	// RVA: 0x18B41C0 Offset: 0x18B42C1 VA: 0x18B41C0
	private void CompressBuffer(int n) { }

	// RVA: 0x18B4210 Offset: 0x18B4311 VA: 0x18B4210
	private void DetectEncoding() { }

	// RVA: 0x18B4540 Offset: 0x18B4641 VA: 0x18B4540
	private bool IsPreamble() { }

	// RVA: 0x18B4660 Offset: 0x18B4761 VA: 0x18B4660 Slot: 15
	internal virtual int ReadBuffer() { }

	// RVA: 0x18B3EB0 Offset: 0x18B3FB1 VA: 0x18B3EB0
	private int ReadBuffer(char[] userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer) { }

	// RVA: 0x18B4810 Offset: 0x18B4911 VA: 0x18B4810 Slot: 12
	public override string ReadLine() { }

	// RVA: 0x18B4A20 Offset: 0x18B4B21 VA: 0x18B4A20
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEA20 Offset: 0xAEB21 VA: 0xAEA20
[Serializable]
public class StreamReader : TextReader // TypeDefIndex: 663
{
	// Fields
	public static readonly StreamReader Null; // 0x0
	private Stream stream; // 0x18
	private Encoding encoding; // 0x20
	private Decoder decoder; // 0x28
	private byte[] byteBuffer; // 0x30
	private char[] charBuffer; // 0x38
	private byte[] _preamble; // 0x40
	private int charPos; // 0x48
	private int charLen; // 0x4C
	private int byteLen; // 0x50
	private int bytePos; // 0x54
	private int _maxCharsPerBuffer; // 0x58
	private bool _detectEncoding; // 0x5C
	private bool _checkPreamble; // 0x5D
	private bool _isBlocked; // 0x5E
	private bool _closable; // 0x5F
	private Task _asyncReadTask; // 0x60

	// Properties
	internal static int DefaultBufferSize { get; }
	public virtual Encoding CurrentEncoding { get; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }
	public bool EndOfStream { get; }

	// Methods

	// RVA: 0x18B3200 Offset: 0x18B3301 VA: 0x18B3200
	internal static int get_DefaultBufferSize() { }

	// RVA: 0x18B3210 Offset: 0x18B3311 VA: 0x18B3210
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x18B32C0 Offset: 0x18B33C1 VA: 0x18B32C0
	internal void .ctor() { }

	// RVA: 0x18B3340 Offset: 0x18B3441 VA: 0x18B3340
	public void .ctor(Stream stream) { }

	// RVA: 0x18B33D0 Offset: 0x18B34D1 VA: 0x18B33D0
	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x189C930 Offset: 0x189CA31 VA: 0x189C930
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x18B3470 Offset: 0x18B3571 VA: 0x18B3470
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18A2770 Offset: 0x18A2871 VA: 0x18A2770
	public void .ctor(string path) { }

	// RVA: 0x18B37A0 Offset: 0x18B38A1 VA: 0x18B37A0
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x18A2980 Offset: 0x18A2A81 VA: 0x18A2980
	public void .ctor(string path, Encoding encoding) { }

	// RVA: 0x18B3840 Offset: 0x18B3941 VA: 0x18B3840
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x18B3850 Offset: 0x18B3951 VA: 0x18B3850
	internal void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost) { }

	// RVA: 0x18B3620 Offset: 0x18B3721 VA: 0x18B3620
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18B3A50 Offset: 0x18B3B51 VA: 0x18B3A50
	internal void Init(Stream stream) { }

	// RVA: 0x18B3A80 Offset: 0x18B3B81 VA: 0x18B3A80 Slot: 7
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B3B80 Offset: 0x18B3C81 VA: 0x18B3B80 Slot: 13
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x18B3B90 Offset: 0x18B3C91 VA: 0x18B3B90 Slot: 14
	public virtual Stream get_BaseStream() { }

	// RVA: 0x18B3B60 Offset: 0x18B3C61 VA: 0x18B3B60
	internal bool get_LeaveOpen() { }

	// RVA: 0x18A2B60 Offset: 0x18A2C61 VA: 0x18A2B60
	public bool get_EndOfStream() { }

	// RVA: 0x189CA90 Offset: 0x189CB91 VA: 0x189CA90 Slot: 8
	public override int Peek() { }

	// RVA: 0x18B3BA0 Offset: 0x18B3CA1 VA: 0x18B3BA0
	internal bool DataAvailable() { }

	// RVA: 0x18B3BB0 Offset: 0x18B3CB1 VA: 0x18B3BB0 Slot: 9
	public override int Read() { }

	// RVA: 0x18B3C50 Offset: 0x18B3D51 VA: 0x18B3C50 Slot: 10
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x18B40E0 Offset: 0x18B41E1 VA: 0x18B40E0 Slot: 11
	public override string ReadToEnd() { }

	// RVA: 0x18B41C0 Offset: 0x18B42C1 VA: 0x18B41C0
	private void CompressBuffer(int n) { }

	// RVA: 0x18B4210 Offset: 0x18B4311 VA: 0x18B4210
	private void DetectEncoding() { }

	// RVA: 0x18B4540 Offset: 0x18B4641 VA: 0x18B4540
	private bool IsPreamble() { }

	// RVA: 0x18B4660 Offset: 0x18B4761 VA: 0x18B4660 Slot: 15
	internal virtual int ReadBuffer() { }

	// RVA: 0x18B3EB0 Offset: 0x18B3FB1 VA: 0x18B3EB0
	private int ReadBuffer(char[] userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer) { }

	// RVA: 0x18B4810 Offset: 0x18B4911 VA: 0x18B4810 Slot: 12
	public override string ReadLine() { }

	// RVA: 0x18B4A20 Offset: 0x18B4B21 VA: 0x18B4A20
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEA20 Offset: 0xAEB21 VA: 0xAEA20
[Serializable]
public class StreamReader : TextReader // TypeDefIndex: 663
{
	// Fields
	public static readonly StreamReader Null; // 0x0
	private Stream stream; // 0x18
	private Encoding encoding; // 0x20
	private Decoder decoder; // 0x28
	private byte[] byteBuffer; // 0x30
	private char[] charBuffer; // 0x38
	private byte[] _preamble; // 0x40
	private int charPos; // 0x48
	private int charLen; // 0x4C
	private int byteLen; // 0x50
	private int bytePos; // 0x54
	private int _maxCharsPerBuffer; // 0x58
	private bool _detectEncoding; // 0x5C
	private bool _checkPreamble; // 0x5D
	private bool _isBlocked; // 0x5E
	private bool _closable; // 0x5F
	private Task _asyncReadTask; // 0x60

	// Properties
	internal static int DefaultBufferSize { get; }
	public virtual Encoding CurrentEncoding { get; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }
	public bool EndOfStream { get; }

	// Methods

	// RVA: 0x18B3200 Offset: 0x18B3301 VA: 0x18B3200
	internal static int get_DefaultBufferSize() { }

	// RVA: 0x18B3210 Offset: 0x18B3311 VA: 0x18B3210
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x18B32C0 Offset: 0x18B33C1 VA: 0x18B32C0
	internal void .ctor() { }

	// RVA: 0x18B3340 Offset: 0x18B3441 VA: 0x18B3340
	public void .ctor(Stream stream) { }

	// RVA: 0x18B33D0 Offset: 0x18B34D1 VA: 0x18B33D0
	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x189C930 Offset: 0x189CA31 VA: 0x189C930
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x18B3470 Offset: 0x18B3571 VA: 0x18B3470
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18A2770 Offset: 0x18A2871 VA: 0x18A2770
	public void .ctor(string path) { }

	// RVA: 0x18B37A0 Offset: 0x18B38A1 VA: 0x18B37A0
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x18A2980 Offset: 0x18A2A81 VA: 0x18A2980
	public void .ctor(string path, Encoding encoding) { }

	// RVA: 0x18B3840 Offset: 0x18B3941 VA: 0x18B3840
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x18B3850 Offset: 0x18B3951 VA: 0x18B3850
	internal void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost) { }

	// RVA: 0x18B3620 Offset: 0x18B3721 VA: 0x18B3620
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18B3A50 Offset: 0x18B3B51 VA: 0x18B3A50
	internal void Init(Stream stream) { }

	// RVA: 0x18B3A80 Offset: 0x18B3B81 VA: 0x18B3A80 Slot: 7
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B3B80 Offset: 0x18B3C81 VA: 0x18B3B80 Slot: 13
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x18B3B90 Offset: 0x18B3C91 VA: 0x18B3B90 Slot: 14
	public virtual Stream get_BaseStream() { }

	// RVA: 0x18B3B60 Offset: 0x18B3C61 VA: 0x18B3B60
	internal bool get_LeaveOpen() { }

	// RVA: 0x18A2B60 Offset: 0x18A2C61 VA: 0x18A2B60
	public bool get_EndOfStream() { }

	// RVA: 0x189CA90 Offset: 0x189CB91 VA: 0x189CA90 Slot: 8
	public override int Peek() { }

	// RVA: 0x18B3BA0 Offset: 0x18B3CA1 VA: 0x18B3BA0
	internal bool DataAvailable() { }

	// RVA: 0x18B3BB0 Offset: 0x18B3CB1 VA: 0x18B3BB0 Slot: 9
	public override int Read() { }

	// RVA: 0x18B3C50 Offset: 0x18B3D51 VA: 0x18B3C50 Slot: 10
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x18B40E0 Offset: 0x18B41E1 VA: 0x18B40E0 Slot: 11
	public override string ReadToEnd() { }

	// RVA: 0x18B41C0 Offset: 0x18B42C1 VA: 0x18B41C0
	private void CompressBuffer(int n) { }

	// RVA: 0x18B4210 Offset: 0x18B4311 VA: 0x18B4210
	private void DetectEncoding() { }

	// RVA: 0x18B4540 Offset: 0x18B4641 VA: 0x18B4540
	private bool IsPreamble() { }

	// RVA: 0x18B4660 Offset: 0x18B4761 VA: 0x18B4660 Slot: 15
	internal virtual int ReadBuffer() { }

	// RVA: 0x18B3EB0 Offset: 0x18B3FB1 VA: 0x18B3EB0
	private int ReadBuffer(char[] userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer) { }

	// RVA: 0x18B4810 Offset: 0x18B4911 VA: 0x18B4810 Slot: 12
	public override string ReadLine() { }

	// RVA: 0x18B4A20 Offset: 0x18B4B21 VA: 0x18B4A20
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEA20 Offset: 0xAEB21 VA: 0xAEA20
[Serializable]
public class StreamReader : TextReader // TypeDefIndex: 663
{
	// Fields
	public static readonly StreamReader Null; // 0x0
	private Stream stream; // 0x18
	private Encoding encoding; // 0x20
	private Decoder decoder; // 0x28
	private byte[] byteBuffer; // 0x30
	private char[] charBuffer; // 0x38
	private byte[] _preamble; // 0x40
	private int charPos; // 0x48
	private int charLen; // 0x4C
	private int byteLen; // 0x50
	private int bytePos; // 0x54
	private int _maxCharsPerBuffer; // 0x58
	private bool _detectEncoding; // 0x5C
	private bool _checkPreamble; // 0x5D
	private bool _isBlocked; // 0x5E
	private bool _closable; // 0x5F
	private Task _asyncReadTask; // 0x60

	// Properties
	internal static int DefaultBufferSize { get; }
	public virtual Encoding CurrentEncoding { get; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }
	public bool EndOfStream { get; }

	// Methods

	// RVA: 0x18B3200 Offset: 0x18B3301 VA: 0x18B3200
	internal static int get_DefaultBufferSize() { }

	// RVA: 0x18B3210 Offset: 0x18B3311 VA: 0x18B3210
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x18B32C0 Offset: 0x18B33C1 VA: 0x18B32C0
	internal void .ctor() { }

	// RVA: 0x18B3340 Offset: 0x18B3441 VA: 0x18B3340
	public void .ctor(Stream stream) { }

	// RVA: 0x18B33D0 Offset: 0x18B34D1 VA: 0x18B33D0
	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x189C930 Offset: 0x189CA31 VA: 0x189C930
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x18B3470 Offset: 0x18B3571 VA: 0x18B3470
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18A2770 Offset: 0x18A2871 VA: 0x18A2770
	public void .ctor(string path) { }

	// RVA: 0x18B37A0 Offset: 0x18B38A1 VA: 0x18B37A0
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x18A2980 Offset: 0x18A2A81 VA: 0x18A2980
	public void .ctor(string path, Encoding encoding) { }

	// RVA: 0x18B3840 Offset: 0x18B3941 VA: 0x18B3840
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x18B3850 Offset: 0x18B3951 VA: 0x18B3850
	internal void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost) { }

	// RVA: 0x18B3620 Offset: 0x18B3721 VA: 0x18B3620
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18B3A50 Offset: 0x18B3B51 VA: 0x18B3A50
	internal void Init(Stream stream) { }

	// RVA: 0x18B3A80 Offset: 0x18B3B81 VA: 0x18B3A80 Slot: 7
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B3B80 Offset: 0x18B3C81 VA: 0x18B3B80 Slot: 13
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x18B3B90 Offset: 0x18B3C91 VA: 0x18B3B90 Slot: 14
	public virtual Stream get_BaseStream() { }

	// RVA: 0x18B3B60 Offset: 0x18B3C61 VA: 0x18B3B60
	internal bool get_LeaveOpen() { }

	// RVA: 0x18A2B60 Offset: 0x18A2C61 VA: 0x18A2B60
	public bool get_EndOfStream() { }

	// RVA: 0x189CA90 Offset: 0x189CB91 VA: 0x189CA90 Slot: 8
	public override int Peek() { }

	// RVA: 0x18B3BA0 Offset: 0x18B3CA1 VA: 0x18B3BA0
	internal bool DataAvailable() { }

	// RVA: 0x18B3BB0 Offset: 0x18B3CB1 VA: 0x18B3BB0 Slot: 9
	public override int Read() { }

	// RVA: 0x18B3C50 Offset: 0x18B3D51 VA: 0x18B3C50 Slot: 10
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x18B40E0 Offset: 0x18B41E1 VA: 0x18B40E0 Slot: 11
	public override string ReadToEnd() { }

	// RVA: 0x18B41C0 Offset: 0x18B42C1 VA: 0x18B41C0
	private void CompressBuffer(int n) { }

	// RVA: 0x18B4210 Offset: 0x18B4311 VA: 0x18B4210
	private void DetectEncoding() { }

	// RVA: 0x18B4540 Offset: 0x18B4641 VA: 0x18B4540
	private bool IsPreamble() { }

	// RVA: 0x18B4660 Offset: 0x18B4761 VA: 0x18B4660 Slot: 15
	internal virtual int ReadBuffer() { }

	// RVA: 0x18B3EB0 Offset: 0x18B3FB1 VA: 0x18B3EB0
	private int ReadBuffer(char[] userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer) { }

	// RVA: 0x18B4810 Offset: 0x18B4911 VA: 0x18B4810 Slot: 12
	public override string ReadLine() { }

	// RVA: 0x18B4A20 Offset: 0x18B4B21 VA: 0x18B4A20
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEA20 Offset: 0xAEB21 VA: 0xAEA20
[Serializable]
public class StreamReader : TextReader // TypeDefIndex: 663
{
	// Fields
	public static readonly StreamReader Null; // 0x0
	private Stream stream; // 0x18
	private Encoding encoding; // 0x20
	private Decoder decoder; // 0x28
	private byte[] byteBuffer; // 0x30
	private char[] charBuffer; // 0x38
	private byte[] _preamble; // 0x40
	private int charPos; // 0x48
	private int charLen; // 0x4C
	private int byteLen; // 0x50
	private int bytePos; // 0x54
	private int _maxCharsPerBuffer; // 0x58
	private bool _detectEncoding; // 0x5C
	private bool _checkPreamble; // 0x5D
	private bool _isBlocked; // 0x5E
	private bool _closable; // 0x5F
	private Task _asyncReadTask; // 0x60

	// Properties
	internal static int DefaultBufferSize { get; }
	public virtual Encoding CurrentEncoding { get; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }
	public bool EndOfStream { get; }

	// Methods

	// RVA: 0x18B3200 Offset: 0x18B3301 VA: 0x18B3200
	internal static int get_DefaultBufferSize() { }

	// RVA: 0x18B3210 Offset: 0x18B3311 VA: 0x18B3210
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x18B32C0 Offset: 0x18B33C1 VA: 0x18B32C0
	internal void .ctor() { }

	// RVA: 0x18B3340 Offset: 0x18B3441 VA: 0x18B3340
	public void .ctor(Stream stream) { }

	// RVA: 0x18B33D0 Offset: 0x18B34D1 VA: 0x18B33D0
	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x189C930 Offset: 0x189CA31 VA: 0x189C930
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x18B3470 Offset: 0x18B3571 VA: 0x18B3470
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18A2770 Offset: 0x18A2871 VA: 0x18A2770
	public void .ctor(string path) { }

	// RVA: 0x18B37A0 Offset: 0x18B38A1 VA: 0x18B37A0
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x18A2980 Offset: 0x18A2A81 VA: 0x18A2980
	public void .ctor(string path, Encoding encoding) { }

	// RVA: 0x18B3840 Offset: 0x18B3941 VA: 0x18B3840
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x18B3850 Offset: 0x18B3951 VA: 0x18B3850
	internal void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost) { }

	// RVA: 0x18B3620 Offset: 0x18B3721 VA: 0x18B3620
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18B3A50 Offset: 0x18B3B51 VA: 0x18B3A50
	internal void Init(Stream stream) { }

	// RVA: 0x18B3A80 Offset: 0x18B3B81 VA: 0x18B3A80 Slot: 7
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B3B80 Offset: 0x18B3C81 VA: 0x18B3B80 Slot: 13
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x18B3B90 Offset: 0x18B3C91 VA: 0x18B3B90 Slot: 14
	public virtual Stream get_BaseStream() { }

	// RVA: 0x18B3B60 Offset: 0x18B3C61 VA: 0x18B3B60
	internal bool get_LeaveOpen() { }

	// RVA: 0x18A2B60 Offset: 0x18A2C61 VA: 0x18A2B60
	public bool get_EndOfStream() { }

	// RVA: 0x189CA90 Offset: 0x189CB91 VA: 0x189CA90 Slot: 8
	public override int Peek() { }

	// RVA: 0x18B3BA0 Offset: 0x18B3CA1 VA: 0x18B3BA0
	internal bool DataAvailable() { }

	// RVA: 0x18B3BB0 Offset: 0x18B3CB1 VA: 0x18B3BB0 Slot: 9
	public override int Read() { }

	// RVA: 0x18B3C50 Offset: 0x18B3D51 VA: 0x18B3C50 Slot: 10
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x18B40E0 Offset: 0x18B41E1 VA: 0x18B40E0 Slot: 11
	public override string ReadToEnd() { }

	// RVA: 0x18B41C0 Offset: 0x18B42C1 VA: 0x18B41C0
	private void CompressBuffer(int n) { }

	// RVA: 0x18B4210 Offset: 0x18B4311 VA: 0x18B4210
	private void DetectEncoding() { }

	// RVA: 0x18B4540 Offset: 0x18B4641 VA: 0x18B4540
	private bool IsPreamble() { }

	// RVA: 0x18B4660 Offset: 0x18B4761 VA: 0x18B4660 Slot: 15
	internal virtual int ReadBuffer() { }

	// RVA: 0x18B3EB0 Offset: 0x18B3FB1 VA: 0x18B3EB0
	private int ReadBuffer(char[] userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer) { }

	// RVA: 0x18B4810 Offset: 0x18B4911 VA: 0x18B4810 Slot: 12
	public override string ReadLine() { }

	// RVA: 0x18B4A20 Offset: 0x18B4B21 VA: 0x18B4A20
	private static void .cctor() { }
}

