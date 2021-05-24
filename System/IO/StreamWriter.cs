[ComVisibleAttribute] // RVA: 0xAEA40 Offset: 0xAEB41 VA: 0xAEA40
[Serializable]
public class StreamWriter : TextWriter // TypeDefIndex: 665
{
	// Fields
	public static readonly StreamWriter Null; // 0x0
	private Stream stream; // 0x28
	private Encoding encoding; // 0x30
	private Encoder encoder; // 0x38
	private byte[] byteBuffer; // 0x40
	private char[] charBuffer; // 0x48
	private int charPos; // 0x50
	private int charLen; // 0x54
	private bool autoFlush; // 0x58
	private bool haveWrittenPreamble; // 0x59
	private bool closable; // 0x5A
	private Task _asyncWriteTask; // 0x60
	private static Encoding _UTF8NoBOM; // 0x8

	// Properties
	internal static Encoding UTF8NoBOM { get; }
	public virtual bool AutoFlush { set; }
	internal bool LeaveOpen { get; }

	// Methods

	// RVA: 0x18B4CC0 Offset: 0x18B4DC1 VA: 0x18B4CC0
	private void CheckAsyncTaskInProgress() { }

	[FriendAccessAllowedAttribute] // RVA: 0xB87B0 Offset: 0xB88B1 VA: 0xB87B0
	// RVA: 0x18B4D70 Offset: 0x18B4E71 VA: 0x18B4D70
	internal static Encoding get_UTF8NoBOM() { }

	// RVA: 0x18B4E90 Offset: 0x18B4F91 VA: 0x18B4E90
	internal void .ctor() { }

	// RVA: 0x18B4FB0 Offset: 0x18B50B1 VA: 0x18B4FB0
	public void .ctor(Stream stream) { }

	// RVA: 0x18B5040 Offset: 0x18B5141 VA: 0x18B5040
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x189D100 Offset: 0x189D201 VA: 0x189D100
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18A17E0 Offset: 0x18A18E1 VA: 0x18A17E0
	public void .ctor(string path, bool append) { }

	// RVA: 0x18A3230 Offset: 0x18A3331 VA: 0x18A3230
	public void .ctor(string path, bool append, Encoding encoding) { }

	// RVA: 0x18B51D0 Offset: 0x18B52D1 VA: 0x18B51D0
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x18B51E0 Offset: 0x18B52E1 VA: 0x18B51E0
	internal void .ctor(string path, bool append, Encoding encoding, int bufferSize, bool checkHost) { }

	// RVA: 0x18B5050 Offset: 0x18B5151 VA: 0x18B5050
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x18B5450 Offset: 0x18B5551 VA: 0x18B5450
	private static Stream CreateFile(string path, bool append, bool checkHost) { }

	// RVA: 0x18B5520 Offset: 0x18B5621 VA: 0x18B5520 Slot: 8
	public override void Close() { }

	// RVA: 0x18B55A0 Offset: 0x18B56A1 VA: 0x18B55A0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B5850 Offset: 0x18B5951 VA: 0x18B5850 Slot: 10
	public override void Flush() { }

	// RVA: 0x18B56D0 Offset: 0x18B57D1 VA: 0x18B56D0
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x18B5880 Offset: 0x18B5981 VA: 0x18B5880 Slot: 22
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x18B56C0 Offset: 0x18B57C1 VA: 0x18B56C0
	internal bool get_LeaveOpen() { }

	// RVA: 0x189DC50 Offset: 0x189DD51 VA: 0x189DC50 Slot: 11
	public override void Write(char value) { }

	// RVA: 0x18B58E0 Offset: 0x18B59E1 VA: 0x18B58E0 Slot: 12
	public override void Write(char[] buffer) { }

	// RVA: 0x189D5F0 Offset: 0x189D6F1 VA: 0x189D5F0 Slot: 13
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x189DB70 Offset: 0x189DC71 VA: 0x189DB70 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x18B59C0 Offset: 0x18B5AC1 VA: 0x18B59C0
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEA40 Offset: 0xAEB41 VA: 0xAEA40
[Serializable]
public class StreamWriter : TextWriter // TypeDefIndex: 665
{
	// Fields
	public static readonly StreamWriter Null; // 0x0
	private Stream stream; // 0x28
	private Encoding encoding; // 0x30
	private Encoder encoder; // 0x38
	private byte[] byteBuffer; // 0x40
	private char[] charBuffer; // 0x48
	private int charPos; // 0x50
	private int charLen; // 0x54
	private bool autoFlush; // 0x58
	private bool haveWrittenPreamble; // 0x59
	private bool closable; // 0x5A
	private Task _asyncWriteTask; // 0x60
	private static Encoding _UTF8NoBOM; // 0x8

	// Properties
	internal static Encoding UTF8NoBOM { get; }
	public virtual bool AutoFlush { set; }
	internal bool LeaveOpen { get; }

	// Methods

	// RVA: 0x18B4CC0 Offset: 0x18B4DC1 VA: 0x18B4CC0
	private void CheckAsyncTaskInProgress() { }

	[FriendAccessAllowedAttribute] // RVA: 0xB87B0 Offset: 0xB88B1 VA: 0xB87B0
	// RVA: 0x18B4D70 Offset: 0x18B4E71 VA: 0x18B4D70
	internal static Encoding get_UTF8NoBOM() { }

	// RVA: 0x18B4E90 Offset: 0x18B4F91 VA: 0x18B4E90
	internal void .ctor() { }

	// RVA: 0x18B4FB0 Offset: 0x18B50B1 VA: 0x18B4FB0
	public void .ctor(Stream stream) { }

	// RVA: 0x18B5040 Offset: 0x18B5141 VA: 0x18B5040
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x189D100 Offset: 0x189D201 VA: 0x189D100
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18A17E0 Offset: 0x18A18E1 VA: 0x18A17E0
	public void .ctor(string path, bool append) { }

	// RVA: 0x18A3230 Offset: 0x18A3331 VA: 0x18A3230
	public void .ctor(string path, bool append, Encoding encoding) { }

	// RVA: 0x18B51D0 Offset: 0x18B52D1 VA: 0x18B51D0
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x18B51E0 Offset: 0x18B52E1 VA: 0x18B51E0
	internal void .ctor(string path, bool append, Encoding encoding, int bufferSize, bool checkHost) { }

	// RVA: 0x18B5050 Offset: 0x18B5151 VA: 0x18B5050
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x18B5450 Offset: 0x18B5551 VA: 0x18B5450
	private static Stream CreateFile(string path, bool append, bool checkHost) { }

	// RVA: 0x18B5520 Offset: 0x18B5621 VA: 0x18B5520 Slot: 8
	public override void Close() { }

	// RVA: 0x18B55A0 Offset: 0x18B56A1 VA: 0x18B55A0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B5850 Offset: 0x18B5951 VA: 0x18B5850 Slot: 10
	public override void Flush() { }

	// RVA: 0x18B56D0 Offset: 0x18B57D1 VA: 0x18B56D0
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x18B5880 Offset: 0x18B5981 VA: 0x18B5880 Slot: 22
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x18B56C0 Offset: 0x18B57C1 VA: 0x18B56C0
	internal bool get_LeaveOpen() { }

	// RVA: 0x189DC50 Offset: 0x189DD51 VA: 0x189DC50 Slot: 11
	public override void Write(char value) { }

	// RVA: 0x18B58E0 Offset: 0x18B59E1 VA: 0x18B58E0 Slot: 12
	public override void Write(char[] buffer) { }

	// RVA: 0x189D5F0 Offset: 0x189D6F1 VA: 0x189D5F0 Slot: 13
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x189DB70 Offset: 0x189DC71 VA: 0x189DB70 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x18B59C0 Offset: 0x18B5AC1 VA: 0x18B59C0
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEA40 Offset: 0xAEB41 VA: 0xAEA40
[Serializable]
public class StreamWriter : TextWriter // TypeDefIndex: 665
{
	// Fields
	public static readonly StreamWriter Null; // 0x0
	private Stream stream; // 0x28
	private Encoding encoding; // 0x30
	private Encoder encoder; // 0x38
	private byte[] byteBuffer; // 0x40
	private char[] charBuffer; // 0x48
	private int charPos; // 0x50
	private int charLen; // 0x54
	private bool autoFlush; // 0x58
	private bool haveWrittenPreamble; // 0x59
	private bool closable; // 0x5A
	private Task _asyncWriteTask; // 0x60
	private static Encoding _UTF8NoBOM; // 0x8

	// Properties
	internal static Encoding UTF8NoBOM { get; }
	public virtual bool AutoFlush { set; }
	internal bool LeaveOpen { get; }

	// Methods

	// RVA: 0x18B4CC0 Offset: 0x18B4DC1 VA: 0x18B4CC0
	private void CheckAsyncTaskInProgress() { }

	[FriendAccessAllowedAttribute] // RVA: 0xB87B0 Offset: 0xB88B1 VA: 0xB87B0
	// RVA: 0x18B4D70 Offset: 0x18B4E71 VA: 0x18B4D70
	internal static Encoding get_UTF8NoBOM() { }

	// RVA: 0x18B4E90 Offset: 0x18B4F91 VA: 0x18B4E90
	internal void .ctor() { }

	// RVA: 0x18B4FB0 Offset: 0x18B50B1 VA: 0x18B4FB0
	public void .ctor(Stream stream) { }

	// RVA: 0x18B5040 Offset: 0x18B5141 VA: 0x18B5040
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x189D100 Offset: 0x189D201 VA: 0x189D100
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18A17E0 Offset: 0x18A18E1 VA: 0x18A17E0
	public void .ctor(string path, bool append) { }

	// RVA: 0x18A3230 Offset: 0x18A3331 VA: 0x18A3230
	public void .ctor(string path, bool append, Encoding encoding) { }

	// RVA: 0x18B51D0 Offset: 0x18B52D1 VA: 0x18B51D0
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x18B51E0 Offset: 0x18B52E1 VA: 0x18B51E0
	internal void .ctor(string path, bool append, Encoding encoding, int bufferSize, bool checkHost) { }

	// RVA: 0x18B5050 Offset: 0x18B5151 VA: 0x18B5050
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x18B5450 Offset: 0x18B5551 VA: 0x18B5450
	private static Stream CreateFile(string path, bool append, bool checkHost) { }

	// RVA: 0x18B5520 Offset: 0x18B5621 VA: 0x18B5520 Slot: 8
	public override void Close() { }

	// RVA: 0x18B55A0 Offset: 0x18B56A1 VA: 0x18B55A0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B5850 Offset: 0x18B5951 VA: 0x18B5850 Slot: 10
	public override void Flush() { }

	// RVA: 0x18B56D0 Offset: 0x18B57D1 VA: 0x18B56D0
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x18B5880 Offset: 0x18B5981 VA: 0x18B5880 Slot: 22
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x18B56C0 Offset: 0x18B57C1 VA: 0x18B56C0
	internal bool get_LeaveOpen() { }

	// RVA: 0x189DC50 Offset: 0x189DD51 VA: 0x189DC50 Slot: 11
	public override void Write(char value) { }

	// RVA: 0x18B58E0 Offset: 0x18B59E1 VA: 0x18B58E0 Slot: 12
	public override void Write(char[] buffer) { }

	// RVA: 0x189D5F0 Offset: 0x189D6F1 VA: 0x189D5F0 Slot: 13
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x189DB70 Offset: 0x189DC71 VA: 0x189DB70 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x18B59C0 Offset: 0x18B5AC1 VA: 0x18B59C0
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEA40 Offset: 0xAEB41 VA: 0xAEA40
[Serializable]
public class StreamWriter : TextWriter // TypeDefIndex: 665
{
	// Fields
	public static readonly StreamWriter Null; // 0x0
	private Stream stream; // 0x28
	private Encoding encoding; // 0x30
	private Encoder encoder; // 0x38
	private byte[] byteBuffer; // 0x40
	private char[] charBuffer; // 0x48
	private int charPos; // 0x50
	private int charLen; // 0x54
	private bool autoFlush; // 0x58
	private bool haveWrittenPreamble; // 0x59
	private bool closable; // 0x5A
	private Task _asyncWriteTask; // 0x60
	private static Encoding _UTF8NoBOM; // 0x8

	// Properties
	internal static Encoding UTF8NoBOM { get; }
	public virtual bool AutoFlush { set; }
	internal bool LeaveOpen { get; }

	// Methods

	// RVA: 0x18B4CC0 Offset: 0x18B4DC1 VA: 0x18B4CC0
	private void CheckAsyncTaskInProgress() { }

	[FriendAccessAllowedAttribute] // RVA: 0xB87B0 Offset: 0xB88B1 VA: 0xB87B0
	// RVA: 0x18B4D70 Offset: 0x18B4E71 VA: 0x18B4D70
	internal static Encoding get_UTF8NoBOM() { }

	// RVA: 0x18B4E90 Offset: 0x18B4F91 VA: 0x18B4E90
	internal void .ctor() { }

	// RVA: 0x18B4FB0 Offset: 0x18B50B1 VA: 0x18B4FB0
	public void .ctor(Stream stream) { }

	// RVA: 0x18B5040 Offset: 0x18B5141 VA: 0x18B5040
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x189D100 Offset: 0x189D201 VA: 0x189D100
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18A17E0 Offset: 0x18A18E1 VA: 0x18A17E0
	public void .ctor(string path, bool append) { }

	// RVA: 0x18A3230 Offset: 0x18A3331 VA: 0x18A3230
	public void .ctor(string path, bool append, Encoding encoding) { }

	// RVA: 0x18B51D0 Offset: 0x18B52D1 VA: 0x18B51D0
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x18B51E0 Offset: 0x18B52E1 VA: 0x18B51E0
	internal void .ctor(string path, bool append, Encoding encoding, int bufferSize, bool checkHost) { }

	// RVA: 0x18B5050 Offset: 0x18B5151 VA: 0x18B5050
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x18B5450 Offset: 0x18B5551 VA: 0x18B5450
	private static Stream CreateFile(string path, bool append, bool checkHost) { }

	// RVA: 0x18B5520 Offset: 0x18B5621 VA: 0x18B5520 Slot: 8
	public override void Close() { }

	// RVA: 0x18B55A0 Offset: 0x18B56A1 VA: 0x18B55A0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B5850 Offset: 0x18B5951 VA: 0x18B5850 Slot: 10
	public override void Flush() { }

	// RVA: 0x18B56D0 Offset: 0x18B57D1 VA: 0x18B56D0
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x18B5880 Offset: 0x18B5981 VA: 0x18B5880 Slot: 22
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x18B56C0 Offset: 0x18B57C1 VA: 0x18B56C0
	internal bool get_LeaveOpen() { }

	// RVA: 0x189DC50 Offset: 0x189DD51 VA: 0x189DC50 Slot: 11
	public override void Write(char value) { }

	// RVA: 0x18B58E0 Offset: 0x18B59E1 VA: 0x18B58E0 Slot: 12
	public override void Write(char[] buffer) { }

	// RVA: 0x189D5F0 Offset: 0x189D6F1 VA: 0x189D5F0 Slot: 13
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x189DB70 Offset: 0x189DC71 VA: 0x189DB70 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x18B59C0 Offset: 0x18B5AC1 VA: 0x18B59C0
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEA40 Offset: 0xAEB41 VA: 0xAEA40
[Serializable]
public class StreamWriter : TextWriter // TypeDefIndex: 665
{
	// Fields
	public static readonly StreamWriter Null; // 0x0
	private Stream stream; // 0x28
	private Encoding encoding; // 0x30
	private Encoder encoder; // 0x38
	private byte[] byteBuffer; // 0x40
	private char[] charBuffer; // 0x48
	private int charPos; // 0x50
	private int charLen; // 0x54
	private bool autoFlush; // 0x58
	private bool haveWrittenPreamble; // 0x59
	private bool closable; // 0x5A
	private Task _asyncWriteTask; // 0x60
	private static Encoding _UTF8NoBOM; // 0x8

	// Properties
	internal static Encoding UTF8NoBOM { get; }
	public virtual bool AutoFlush { set; }
	internal bool LeaveOpen { get; }

	// Methods

	// RVA: 0x18B4CC0 Offset: 0x18B4DC1 VA: 0x18B4CC0
	private void CheckAsyncTaskInProgress() { }

	[FriendAccessAllowedAttribute] // RVA: 0xB87B0 Offset: 0xB88B1 VA: 0xB87B0
	// RVA: 0x18B4D70 Offset: 0x18B4E71 VA: 0x18B4D70
	internal static Encoding get_UTF8NoBOM() { }

	// RVA: 0x18B4E90 Offset: 0x18B4F91 VA: 0x18B4E90
	internal void .ctor() { }

	// RVA: 0x18B4FB0 Offset: 0x18B50B1 VA: 0x18B4FB0
	public void .ctor(Stream stream) { }

	// RVA: 0x18B5040 Offset: 0x18B5141 VA: 0x18B5040
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x189D100 Offset: 0x189D201 VA: 0x189D100
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18A17E0 Offset: 0x18A18E1 VA: 0x18A17E0
	public void .ctor(string path, bool append) { }

	// RVA: 0x18A3230 Offset: 0x18A3331 VA: 0x18A3230
	public void .ctor(string path, bool append, Encoding encoding) { }

	// RVA: 0x18B51D0 Offset: 0x18B52D1 VA: 0x18B51D0
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x18B51E0 Offset: 0x18B52E1 VA: 0x18B51E0
	internal void .ctor(string path, bool append, Encoding encoding, int bufferSize, bool checkHost) { }

	// RVA: 0x18B5050 Offset: 0x18B5151 VA: 0x18B5050
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x18B5450 Offset: 0x18B5551 VA: 0x18B5450
	private static Stream CreateFile(string path, bool append, bool checkHost) { }

	// RVA: 0x18B5520 Offset: 0x18B5621 VA: 0x18B5520 Slot: 8
	public override void Close() { }

	// RVA: 0x18B55A0 Offset: 0x18B56A1 VA: 0x18B55A0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B5850 Offset: 0x18B5951 VA: 0x18B5850 Slot: 10
	public override void Flush() { }

	// RVA: 0x18B56D0 Offset: 0x18B57D1 VA: 0x18B56D0
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x18B5880 Offset: 0x18B5981 VA: 0x18B5880 Slot: 22
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x18B56C0 Offset: 0x18B57C1 VA: 0x18B56C0
	internal bool get_LeaveOpen() { }

	// RVA: 0x189DC50 Offset: 0x189DD51 VA: 0x189DC50 Slot: 11
	public override void Write(char value) { }

	// RVA: 0x18B58E0 Offset: 0x18B59E1 VA: 0x18B58E0 Slot: 12
	public override void Write(char[] buffer) { }

	// RVA: 0x189D5F0 Offset: 0x189D6F1 VA: 0x189D5F0 Slot: 13
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x189DB70 Offset: 0x189DC71 VA: 0x189DB70 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x18B59C0 Offset: 0x18B5AC1 VA: 0x18B59C0
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEA40 Offset: 0xAEB41 VA: 0xAEA40
[Serializable]
public class StreamWriter : TextWriter // TypeDefIndex: 665
{
	// Fields
	public static readonly StreamWriter Null; // 0x0
	private Stream stream; // 0x28
	private Encoding encoding; // 0x30
	private Encoder encoder; // 0x38
	private byte[] byteBuffer; // 0x40
	private char[] charBuffer; // 0x48
	private int charPos; // 0x50
	private int charLen; // 0x54
	private bool autoFlush; // 0x58
	private bool haveWrittenPreamble; // 0x59
	private bool closable; // 0x5A
	private Task _asyncWriteTask; // 0x60
	private static Encoding _UTF8NoBOM; // 0x8

	// Properties
	internal static Encoding UTF8NoBOM { get; }
	public virtual bool AutoFlush { set; }
	internal bool LeaveOpen { get; }

	// Methods

	// RVA: 0x18B4CC0 Offset: 0x18B4DC1 VA: 0x18B4CC0
	private void CheckAsyncTaskInProgress() { }

	[FriendAccessAllowedAttribute] // RVA: 0xB87B0 Offset: 0xB88B1 VA: 0xB87B0
	// RVA: 0x18B4D70 Offset: 0x18B4E71 VA: 0x18B4D70
	internal static Encoding get_UTF8NoBOM() { }

	// RVA: 0x18B4E90 Offset: 0x18B4F91 VA: 0x18B4E90
	internal void .ctor() { }

	// RVA: 0x18B4FB0 Offset: 0x18B50B1 VA: 0x18B4FB0
	public void .ctor(Stream stream) { }

	// RVA: 0x18B5040 Offset: 0x18B5141 VA: 0x18B5040
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x189D100 Offset: 0x189D201 VA: 0x189D100
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x18A17E0 Offset: 0x18A18E1 VA: 0x18A17E0
	public void .ctor(string path, bool append) { }

	// RVA: 0x18A3230 Offset: 0x18A3331 VA: 0x18A3230
	public void .ctor(string path, bool append, Encoding encoding) { }

	// RVA: 0x18B51D0 Offset: 0x18B52D1 VA: 0x18B51D0
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x18B51E0 Offset: 0x18B52E1 VA: 0x18B51E0
	internal void .ctor(string path, bool append, Encoding encoding, int bufferSize, bool checkHost) { }

	// RVA: 0x18B5050 Offset: 0x18B5151 VA: 0x18B5050
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x18B5450 Offset: 0x18B5551 VA: 0x18B5450
	private static Stream CreateFile(string path, bool append, bool checkHost) { }

	// RVA: 0x18B5520 Offset: 0x18B5621 VA: 0x18B5520 Slot: 8
	public override void Close() { }

	// RVA: 0x18B55A0 Offset: 0x18B56A1 VA: 0x18B55A0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18B5850 Offset: 0x18B5951 VA: 0x18B5850 Slot: 10
	public override void Flush() { }

	// RVA: 0x18B56D0 Offset: 0x18B57D1 VA: 0x18B56D0
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x18B5880 Offset: 0x18B5981 VA: 0x18B5880 Slot: 22
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x18B56C0 Offset: 0x18B57C1 VA: 0x18B56C0
	internal bool get_LeaveOpen() { }

	// RVA: 0x189DC50 Offset: 0x189DD51 VA: 0x189DC50 Slot: 11
	public override void Write(char value) { }

	// RVA: 0x18B58E0 Offset: 0x18B59E1 VA: 0x18B58E0 Slot: 12
	public override void Write(char[] buffer) { }

	// RVA: 0x189D5F0 Offset: 0x189D6F1 VA: 0x189D5F0 Slot: 13
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x189DB70 Offset: 0x189DC71 VA: 0x189DB70 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x18B59C0 Offset: 0x18B5AC1 VA: 0x18B59C0
	private static void .cctor() { }
}

