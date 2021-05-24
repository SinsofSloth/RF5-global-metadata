[ComVisibleAttribute] // RVA: 0xAEAD0 Offset: 0xAEBD1 VA: 0xAEAD0
[Serializable]
public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 672
{
	// Fields
	public static readonly TextWriter Null; // 0x0
	private static Action<object> _WriteCharDelegate; // 0x8
	private static Action<object> _WriteStringDelegate; // 0x10
	private static Action<object> _WriteCharArrayRangeDelegate; // 0x18
	private static Action<object> _WriteLineCharDelegate; // 0x20
	private static Action<object> _WriteLineStringDelegate; // 0x28
	private static Action<object> _WriteLineCharArrayRangeDelegate; // 0x30
	private static Action<object> _FlushDelegate; // 0x38
	protected char[] CoreNewLine; // 0x18
	private IFormatProvider InternalFormatProvider; // 0x20

	// Properties
	private static string InitialNewLine { get; }
	public virtual IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x18B70E0 Offset: 0x18B71E1 VA: 0x18B70E0
	private static string get_InitialNewLine() { }

	// RVA: 0x18B70F0 Offset: 0x18B71F1 VA: 0x18B70F0
	protected void .ctor() { }

	// RVA: 0x18B4F00 Offset: 0x18B5001 VA: 0x18B4F00
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x18B7190 Offset: 0x18B7291 VA: 0x18B7190 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x18B71D0 Offset: 0x18B72D1 VA: 0x18B71D0 Slot: 8
	public virtual void Close() { }

	// RVA: 0x18B5840 Offset: 0x18B5941 VA: 0x18B5840 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18B7250 Offset: 0x18B7351 VA: 0x18B7250 Slot: 6
	public void Dispose() { }

	// RVA: 0x18B72D0 Offset: 0x18B73D1 VA: 0x18B72D0 Slot: 10
	public virtual void Flush() { }

	// RVA: 0x18B72E0 Offset: 0x18B73E1 VA: 0x18B72E0
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x18B74A0 Offset: 0x18B75A1 VA: 0x18B74A0 Slot: 11
	public virtual void Write(char value) { }

	// RVA: 0x18B74B0 Offset: 0x18B75B1 VA: 0x18B74B0 Slot: 12
	public virtual void Write(char[] buffer) { }

	// RVA: 0x18B74D0 Offset: 0x18B75D1 VA: 0x18B74D0 Slot: 13
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x18B76D0 Offset: 0x18B77D1 VA: 0x18B76D0 Slot: 14
	public virtual void Write(int value) { }

	// RVA: 0x18B7730 Offset: 0x18B7831 VA: 0x18B7730 Slot: 15
	public virtual void Write(string value) { }

	// RVA: 0x18B7770 Offset: 0x18B7871 VA: 0x18B7770 Slot: 16
	public virtual void WriteLine() { }

	// RVA: 0x18B7780 Offset: 0x18B7881 VA: 0x18B7780 Slot: 17
	public virtual void WriteLine(char value) { }

	// RVA: 0x18B77C0 Offset: 0x18B78C1 VA: 0x18B77C0 Slot: 18
	public virtual void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x18B7800 Offset: 0x18B7901 VA: 0x18B7800 Slot: 19
	public virtual void WriteLine(string value) { }

	// RVA: 0x18B79B0 Offset: 0x18B7AB1 VA: 0x18B79B0 Slot: 20
	public virtual void WriteLine(string format, object arg0) { }

	// RVA: 0x18B7A10 Offset: 0x18B7B11 VA: 0x18B7A10 Slot: 21
	public virtual void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x18B7A80 Offset: 0x18B7B81 VA: 0x18B7A80
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEAD0 Offset: 0xAEBD1 VA: 0xAEAD0
[Serializable]
public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 672
{
	// Fields
	public static readonly TextWriter Null; // 0x0
	private static Action<object> _WriteCharDelegate; // 0x8
	private static Action<object> _WriteStringDelegate; // 0x10
	private static Action<object> _WriteCharArrayRangeDelegate; // 0x18
	private static Action<object> _WriteLineCharDelegate; // 0x20
	private static Action<object> _WriteLineStringDelegate; // 0x28
	private static Action<object> _WriteLineCharArrayRangeDelegate; // 0x30
	private static Action<object> _FlushDelegate; // 0x38
	protected char[] CoreNewLine; // 0x18
	private IFormatProvider InternalFormatProvider; // 0x20

	// Properties
	private static string InitialNewLine { get; }
	public virtual IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x18B70E0 Offset: 0x18B71E1 VA: 0x18B70E0
	private static string get_InitialNewLine() { }

	// RVA: 0x18B70F0 Offset: 0x18B71F1 VA: 0x18B70F0
	protected void .ctor() { }

	// RVA: 0x18B4F00 Offset: 0x18B5001 VA: 0x18B4F00
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x18B7190 Offset: 0x18B7291 VA: 0x18B7190 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x18B71D0 Offset: 0x18B72D1 VA: 0x18B71D0 Slot: 8
	public virtual void Close() { }

	// RVA: 0x18B5840 Offset: 0x18B5941 VA: 0x18B5840 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18B7250 Offset: 0x18B7351 VA: 0x18B7250 Slot: 6
	public void Dispose() { }

	// RVA: 0x18B72D0 Offset: 0x18B73D1 VA: 0x18B72D0 Slot: 10
	public virtual void Flush() { }

	// RVA: 0x18B72E0 Offset: 0x18B73E1 VA: 0x18B72E0
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x18B74A0 Offset: 0x18B75A1 VA: 0x18B74A0 Slot: 11
	public virtual void Write(char value) { }

	// RVA: 0x18B74B0 Offset: 0x18B75B1 VA: 0x18B74B0 Slot: 12
	public virtual void Write(char[] buffer) { }

	// RVA: 0x18B74D0 Offset: 0x18B75D1 VA: 0x18B74D0 Slot: 13
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x18B76D0 Offset: 0x18B77D1 VA: 0x18B76D0 Slot: 14
	public virtual void Write(int value) { }

	// RVA: 0x18B7730 Offset: 0x18B7831 VA: 0x18B7730 Slot: 15
	public virtual void Write(string value) { }

	// RVA: 0x18B7770 Offset: 0x18B7871 VA: 0x18B7770 Slot: 16
	public virtual void WriteLine() { }

	// RVA: 0x18B7780 Offset: 0x18B7881 VA: 0x18B7780 Slot: 17
	public virtual void WriteLine(char value) { }

	// RVA: 0x18B77C0 Offset: 0x18B78C1 VA: 0x18B77C0 Slot: 18
	public virtual void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x18B7800 Offset: 0x18B7901 VA: 0x18B7800 Slot: 19
	public virtual void WriteLine(string value) { }

	// RVA: 0x18B79B0 Offset: 0x18B7AB1 VA: 0x18B79B0 Slot: 20
	public virtual void WriteLine(string format, object arg0) { }

	// RVA: 0x18B7A10 Offset: 0x18B7B11 VA: 0x18B7A10 Slot: 21
	public virtual void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x18B7A80 Offset: 0x18B7B81 VA: 0x18B7A80
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEAD0 Offset: 0xAEBD1 VA: 0xAEAD0
[Serializable]
public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 672
{
	// Fields
	public static readonly TextWriter Null; // 0x0
	private static Action<object> _WriteCharDelegate; // 0x8
	private static Action<object> _WriteStringDelegate; // 0x10
	private static Action<object> _WriteCharArrayRangeDelegate; // 0x18
	private static Action<object> _WriteLineCharDelegate; // 0x20
	private static Action<object> _WriteLineStringDelegate; // 0x28
	private static Action<object> _WriteLineCharArrayRangeDelegate; // 0x30
	private static Action<object> _FlushDelegate; // 0x38
	protected char[] CoreNewLine; // 0x18
	private IFormatProvider InternalFormatProvider; // 0x20

	// Properties
	private static string InitialNewLine { get; }
	public virtual IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x18B70E0 Offset: 0x18B71E1 VA: 0x18B70E0
	private static string get_InitialNewLine() { }

	// RVA: 0x18B70F0 Offset: 0x18B71F1 VA: 0x18B70F0
	protected void .ctor() { }

	// RVA: 0x18B4F00 Offset: 0x18B5001 VA: 0x18B4F00
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x18B7190 Offset: 0x18B7291 VA: 0x18B7190 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x18B71D0 Offset: 0x18B72D1 VA: 0x18B71D0 Slot: 8
	public virtual void Close() { }

	// RVA: 0x18B5840 Offset: 0x18B5941 VA: 0x18B5840 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18B7250 Offset: 0x18B7351 VA: 0x18B7250 Slot: 6
	public void Dispose() { }

	// RVA: 0x18B72D0 Offset: 0x18B73D1 VA: 0x18B72D0 Slot: 10
	public virtual void Flush() { }

	// RVA: 0x18B72E0 Offset: 0x18B73E1 VA: 0x18B72E0
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x18B74A0 Offset: 0x18B75A1 VA: 0x18B74A0 Slot: 11
	public virtual void Write(char value) { }

	// RVA: 0x18B74B0 Offset: 0x18B75B1 VA: 0x18B74B0 Slot: 12
	public virtual void Write(char[] buffer) { }

	// RVA: 0x18B74D0 Offset: 0x18B75D1 VA: 0x18B74D0 Slot: 13
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x18B76D0 Offset: 0x18B77D1 VA: 0x18B76D0 Slot: 14
	public virtual void Write(int value) { }

	// RVA: 0x18B7730 Offset: 0x18B7831 VA: 0x18B7730 Slot: 15
	public virtual void Write(string value) { }

	// RVA: 0x18B7770 Offset: 0x18B7871 VA: 0x18B7770 Slot: 16
	public virtual void WriteLine() { }

	// RVA: 0x18B7780 Offset: 0x18B7881 VA: 0x18B7780 Slot: 17
	public virtual void WriteLine(char value) { }

	// RVA: 0x18B77C0 Offset: 0x18B78C1 VA: 0x18B77C0 Slot: 18
	public virtual void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x18B7800 Offset: 0x18B7901 VA: 0x18B7800 Slot: 19
	public virtual void WriteLine(string value) { }

	// RVA: 0x18B79B0 Offset: 0x18B7AB1 VA: 0x18B79B0 Slot: 20
	public virtual void WriteLine(string format, object arg0) { }

	// RVA: 0x18B7A10 Offset: 0x18B7B11 VA: 0x18B7A10 Slot: 21
	public virtual void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x18B7A80 Offset: 0x18B7B81 VA: 0x18B7A80
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEAD0 Offset: 0xAEBD1 VA: 0xAEAD0
[Serializable]
public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 672
{
	// Fields
	public static readonly TextWriter Null; // 0x0
	private static Action<object> _WriteCharDelegate; // 0x8
	private static Action<object> _WriteStringDelegate; // 0x10
	private static Action<object> _WriteCharArrayRangeDelegate; // 0x18
	private static Action<object> _WriteLineCharDelegate; // 0x20
	private static Action<object> _WriteLineStringDelegate; // 0x28
	private static Action<object> _WriteLineCharArrayRangeDelegate; // 0x30
	private static Action<object> _FlushDelegate; // 0x38
	protected char[] CoreNewLine; // 0x18
	private IFormatProvider InternalFormatProvider; // 0x20

	// Properties
	private static string InitialNewLine { get; }
	public virtual IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x18B70E0 Offset: 0x18B71E1 VA: 0x18B70E0
	private static string get_InitialNewLine() { }

	// RVA: 0x18B70F0 Offset: 0x18B71F1 VA: 0x18B70F0
	protected void .ctor() { }

	// RVA: 0x18B4F00 Offset: 0x18B5001 VA: 0x18B4F00
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x18B7190 Offset: 0x18B7291 VA: 0x18B7190 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x18B71D0 Offset: 0x18B72D1 VA: 0x18B71D0 Slot: 8
	public virtual void Close() { }

	// RVA: 0x18B5840 Offset: 0x18B5941 VA: 0x18B5840 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18B7250 Offset: 0x18B7351 VA: 0x18B7250 Slot: 6
	public void Dispose() { }

	// RVA: 0x18B72D0 Offset: 0x18B73D1 VA: 0x18B72D0 Slot: 10
	public virtual void Flush() { }

	// RVA: 0x18B72E0 Offset: 0x18B73E1 VA: 0x18B72E0
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x18B74A0 Offset: 0x18B75A1 VA: 0x18B74A0 Slot: 11
	public virtual void Write(char value) { }

	// RVA: 0x18B74B0 Offset: 0x18B75B1 VA: 0x18B74B0 Slot: 12
	public virtual void Write(char[] buffer) { }

	// RVA: 0x18B74D0 Offset: 0x18B75D1 VA: 0x18B74D0 Slot: 13
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x18B76D0 Offset: 0x18B77D1 VA: 0x18B76D0 Slot: 14
	public virtual void Write(int value) { }

	// RVA: 0x18B7730 Offset: 0x18B7831 VA: 0x18B7730 Slot: 15
	public virtual void Write(string value) { }

	// RVA: 0x18B7770 Offset: 0x18B7871 VA: 0x18B7770 Slot: 16
	public virtual void WriteLine() { }

	// RVA: 0x18B7780 Offset: 0x18B7881 VA: 0x18B7780 Slot: 17
	public virtual void WriteLine(char value) { }

	// RVA: 0x18B77C0 Offset: 0x18B78C1 VA: 0x18B77C0 Slot: 18
	public virtual void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x18B7800 Offset: 0x18B7901 VA: 0x18B7800 Slot: 19
	public virtual void WriteLine(string value) { }

	// RVA: 0x18B79B0 Offset: 0x18B7AB1 VA: 0x18B79B0 Slot: 20
	public virtual void WriteLine(string format, object arg0) { }

	// RVA: 0x18B7A10 Offset: 0x18B7B11 VA: 0x18B7A10 Slot: 21
	public virtual void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x18B7A80 Offset: 0x18B7B81 VA: 0x18B7A80
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEAD0 Offset: 0xAEBD1 VA: 0xAEAD0
[Serializable]
public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 672
{
	// Fields
	public static readonly TextWriter Null; // 0x0
	private static Action<object> _WriteCharDelegate; // 0x8
	private static Action<object> _WriteStringDelegate; // 0x10
	private static Action<object> _WriteCharArrayRangeDelegate; // 0x18
	private static Action<object> _WriteLineCharDelegate; // 0x20
	private static Action<object> _WriteLineStringDelegate; // 0x28
	private static Action<object> _WriteLineCharArrayRangeDelegate; // 0x30
	private static Action<object> _FlushDelegate; // 0x38
	protected char[] CoreNewLine; // 0x18
	private IFormatProvider InternalFormatProvider; // 0x20

	// Properties
	private static string InitialNewLine { get; }
	public virtual IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x18B70E0 Offset: 0x18B71E1 VA: 0x18B70E0
	private static string get_InitialNewLine() { }

	// RVA: 0x18B70F0 Offset: 0x18B71F1 VA: 0x18B70F0
	protected void .ctor() { }

	// RVA: 0x18B4F00 Offset: 0x18B5001 VA: 0x18B4F00
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x18B7190 Offset: 0x18B7291 VA: 0x18B7190 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x18B71D0 Offset: 0x18B72D1 VA: 0x18B71D0 Slot: 8
	public virtual void Close() { }

	// RVA: 0x18B5840 Offset: 0x18B5941 VA: 0x18B5840 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18B7250 Offset: 0x18B7351 VA: 0x18B7250 Slot: 6
	public void Dispose() { }

	// RVA: 0x18B72D0 Offset: 0x18B73D1 VA: 0x18B72D0 Slot: 10
	public virtual void Flush() { }

	// RVA: 0x18B72E0 Offset: 0x18B73E1 VA: 0x18B72E0
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x18B74A0 Offset: 0x18B75A1 VA: 0x18B74A0 Slot: 11
	public virtual void Write(char value) { }

	// RVA: 0x18B74B0 Offset: 0x18B75B1 VA: 0x18B74B0 Slot: 12
	public virtual void Write(char[] buffer) { }

	// RVA: 0x18B74D0 Offset: 0x18B75D1 VA: 0x18B74D0 Slot: 13
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x18B76D0 Offset: 0x18B77D1 VA: 0x18B76D0 Slot: 14
	public virtual void Write(int value) { }

	// RVA: 0x18B7730 Offset: 0x18B7831 VA: 0x18B7730 Slot: 15
	public virtual void Write(string value) { }

	// RVA: 0x18B7770 Offset: 0x18B7871 VA: 0x18B7770 Slot: 16
	public virtual void WriteLine() { }

	// RVA: 0x18B7780 Offset: 0x18B7881 VA: 0x18B7780 Slot: 17
	public virtual void WriteLine(char value) { }

	// RVA: 0x18B77C0 Offset: 0x18B78C1 VA: 0x18B77C0 Slot: 18
	public virtual void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x18B7800 Offset: 0x18B7901 VA: 0x18B7800 Slot: 19
	public virtual void WriteLine(string value) { }

	// RVA: 0x18B79B0 Offset: 0x18B7AB1 VA: 0x18B79B0 Slot: 20
	public virtual void WriteLine(string format, object arg0) { }

	// RVA: 0x18B7A10 Offset: 0x18B7B11 VA: 0x18B7A10 Slot: 21
	public virtual void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x18B7A80 Offset: 0x18B7B81 VA: 0x18B7A80
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEAD0 Offset: 0xAEBD1 VA: 0xAEAD0
[Serializable]
public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 672
{
	// Fields
	public static readonly TextWriter Null; // 0x0
	private static Action<object> _WriteCharDelegate; // 0x8
	private static Action<object> _WriteStringDelegate; // 0x10
	private static Action<object> _WriteCharArrayRangeDelegate; // 0x18
	private static Action<object> _WriteLineCharDelegate; // 0x20
	private static Action<object> _WriteLineStringDelegate; // 0x28
	private static Action<object> _WriteLineCharArrayRangeDelegate; // 0x30
	private static Action<object> _FlushDelegate; // 0x38
	protected char[] CoreNewLine; // 0x18
	private IFormatProvider InternalFormatProvider; // 0x20

	// Properties
	private static string InitialNewLine { get; }
	public virtual IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x18B70E0 Offset: 0x18B71E1 VA: 0x18B70E0
	private static string get_InitialNewLine() { }

	// RVA: 0x18B70F0 Offset: 0x18B71F1 VA: 0x18B70F0
	protected void .ctor() { }

	// RVA: 0x18B4F00 Offset: 0x18B5001 VA: 0x18B4F00
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x18B7190 Offset: 0x18B7291 VA: 0x18B7190 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x18B71D0 Offset: 0x18B72D1 VA: 0x18B71D0 Slot: 8
	public virtual void Close() { }

	// RVA: 0x18B5840 Offset: 0x18B5941 VA: 0x18B5840 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18B7250 Offset: 0x18B7351 VA: 0x18B7250 Slot: 6
	public void Dispose() { }

	// RVA: 0x18B72D0 Offset: 0x18B73D1 VA: 0x18B72D0 Slot: 10
	public virtual void Flush() { }

	// RVA: 0x18B72E0 Offset: 0x18B73E1 VA: 0x18B72E0
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x18B74A0 Offset: 0x18B75A1 VA: 0x18B74A0 Slot: 11
	public virtual void Write(char value) { }

	// RVA: 0x18B74B0 Offset: 0x18B75B1 VA: 0x18B74B0 Slot: 12
	public virtual void Write(char[] buffer) { }

	// RVA: 0x18B74D0 Offset: 0x18B75D1 VA: 0x18B74D0 Slot: 13
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x18B76D0 Offset: 0x18B77D1 VA: 0x18B76D0 Slot: 14
	public virtual void Write(int value) { }

	// RVA: 0x18B7730 Offset: 0x18B7831 VA: 0x18B7730 Slot: 15
	public virtual void Write(string value) { }

	// RVA: 0x18B7770 Offset: 0x18B7871 VA: 0x18B7770 Slot: 16
	public virtual void WriteLine() { }

	// RVA: 0x18B7780 Offset: 0x18B7881 VA: 0x18B7780 Slot: 17
	public virtual void WriteLine(char value) { }

	// RVA: 0x18B77C0 Offset: 0x18B78C1 VA: 0x18B77C0 Slot: 18
	public virtual void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x18B7800 Offset: 0x18B7901 VA: 0x18B7800 Slot: 19
	public virtual void WriteLine(string value) { }

	// RVA: 0x18B79B0 Offset: 0x18B7AB1 VA: 0x18B79B0 Slot: 20
	public virtual void WriteLine(string format, object arg0) { }

	// RVA: 0x18B7A10 Offset: 0x18B7B11 VA: 0x18B7A10 Slot: 21
	public virtual void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x18B7A80 Offset: 0x18B7B81 VA: 0x18B7A80
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xAEAD0 Offset: 0xAEBD1 VA: 0xAEAD0
[Serializable]
public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 672
{
	// Fields
	public static readonly TextWriter Null; // 0x0
	private static Action<object> _WriteCharDelegate; // 0x8
	private static Action<object> _WriteStringDelegate; // 0x10
	private static Action<object> _WriteCharArrayRangeDelegate; // 0x18
	private static Action<object> _WriteLineCharDelegate; // 0x20
	private static Action<object> _WriteLineStringDelegate; // 0x28
	private static Action<object> _WriteLineCharArrayRangeDelegate; // 0x30
	private static Action<object> _FlushDelegate; // 0x38
	protected char[] CoreNewLine; // 0x18
	private IFormatProvider InternalFormatProvider; // 0x20

	// Properties
	private static string InitialNewLine { get; }
	public virtual IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x18B70E0 Offset: 0x18B71E1 VA: 0x18B70E0
	private static string get_InitialNewLine() { }

	// RVA: 0x18B70F0 Offset: 0x18B71F1 VA: 0x18B70F0
	protected void .ctor() { }

	// RVA: 0x18B4F00 Offset: 0x18B5001 VA: 0x18B4F00
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x18B7190 Offset: 0x18B7291 VA: 0x18B7190 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x18B71D0 Offset: 0x18B72D1 VA: 0x18B71D0 Slot: 8
	public virtual void Close() { }

	// RVA: 0x18B5840 Offset: 0x18B5941 VA: 0x18B5840 Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18B7250 Offset: 0x18B7351 VA: 0x18B7250 Slot: 6
	public void Dispose() { }

	// RVA: 0x18B72D0 Offset: 0x18B73D1 VA: 0x18B72D0 Slot: 10
	public virtual void Flush() { }

	// RVA: 0x18B72E0 Offset: 0x18B73E1 VA: 0x18B72E0
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x18B74A0 Offset: 0x18B75A1 VA: 0x18B74A0 Slot: 11
	public virtual void Write(char value) { }

	// RVA: 0x18B74B0 Offset: 0x18B75B1 VA: 0x18B74B0 Slot: 12
	public virtual void Write(char[] buffer) { }

	// RVA: 0x18B74D0 Offset: 0x18B75D1 VA: 0x18B74D0 Slot: 13
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x18B76D0 Offset: 0x18B77D1 VA: 0x18B76D0 Slot: 14
	public virtual void Write(int value) { }

	// RVA: 0x18B7730 Offset: 0x18B7831 VA: 0x18B7730 Slot: 15
	public virtual void Write(string value) { }

	// RVA: 0x18B7770 Offset: 0x18B7871 VA: 0x18B7770 Slot: 16
	public virtual void WriteLine() { }

	// RVA: 0x18B7780 Offset: 0x18B7881 VA: 0x18B7780 Slot: 17
	public virtual void WriteLine(char value) { }

	// RVA: 0x18B77C0 Offset: 0x18B78C1 VA: 0x18B77C0 Slot: 18
	public virtual void WriteLine(char[] buffer, int index, int count) { }

	// RVA: 0x18B7800 Offset: 0x18B7901 VA: 0x18B7800 Slot: 19
	public virtual void WriteLine(string value) { }

	// RVA: 0x18B79B0 Offset: 0x18B7AB1 VA: 0x18B79B0 Slot: 20
	public virtual void WriteLine(string format, object arg0) { }

	// RVA: 0x18B7A10 Offset: 0x18B7B11 VA: 0x18B7A10 Slot: 21
	public virtual void WriteLine(string format, object arg0, object arg1) { }

	// RVA: 0x18B7A80 Offset: 0x18B7B81 VA: 0x18B7A80
	private static void .cctor() { }
}

