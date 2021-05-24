[ComVisibleAttribute] // RVA: 0xAEAA0 Offset: 0xAEBA1 VA: 0xAEAA0
[Serializable]
public abstract class TextReader : MarshalByRefObject, IDisposable // TypeDefIndex: 668
{
	// Fields
	private static Func<object, string> _ReadLineDelegate; // 0x0
	private static Func<object, int> _ReadDelegate; // 0x8
	public static readonly TextReader Null; // 0x10

	// Methods

	// RVA: 0x18B3330 Offset: 0x18B3431 VA: 0x18B3330
	protected void .ctor() { }

	// RVA: 0x18B6510 Offset: 0x18B6611 VA: 0x18B6510 Slot: 6
	public void Dispose() { }

	// RVA: 0x18B3B70 Offset: 0x18B3C71 VA: 0x18B3B70 Slot: 7
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18B6590 Offset: 0x18B6691 VA: 0x18B6590 Slot: 8
	public virtual int Peek() { }

	// RVA: 0x18B65A0 Offset: 0x18B66A1 VA: 0x18B65A0 Slot: 9
	public virtual int Read() { }

	// RVA: 0x18B65B0 Offset: 0x18B66B1 VA: 0x18B65B0 Slot: 10
	public virtual int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x18B67B0 Offset: 0x18B68B1 VA: 0x18B67B0 Slot: 11
	public virtual string ReadToEnd() { }

	// RVA: 0x18B68B0 Offset: 0x18B69B1 VA: 0x18B68B0 Slot: 12
	public virtual string ReadLine() { }

	// RVA: 0x18B69E0 Offset: 0x18B6AE1 VA: 0x18B69E0
	public static TextReader Synchronized(TextReader reader) { }

	// RVA: 0x18B6B80 Offset: 0x18B6C81 VA: 0x18B6B80
	private static void .cctor() { }
}

