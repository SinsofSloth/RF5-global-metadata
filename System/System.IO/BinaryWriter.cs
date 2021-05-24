[ComVisibleAttribute] // RVA: 0xAE860 Offset: 0xAE961 VA: 0xAE860
[Serializable]
public class BinaryWriter : IDisposable // TypeDefIndex: 635
{
	// Fields
	public static readonly BinaryWriter Null; // 0x0
	protected Stream OutStream; // 0x10
	private byte[] _buffer; // 0x18
	private Encoding _encoding; // 0x20
	private Encoder _encoder; // 0x28
	[OptionalFieldAttribute] // RVA: 0xB4850 Offset: 0xB4951 VA: 0xB4850
	private bool _leaveOpen; // 0x30
	private byte[] _largeByteBuffer; // 0x38
	private int _maxChars; // 0x40

	// Methods

	// RVA: 0x19D2D40 Offset: 0x19D2E41 VA: 0x19D2D40
	protected void .ctor() { }

	// RVA: 0x19D2E50 Offset: 0x19D2F51 VA: 0x19D2E50
	public void .ctor(Stream output, Encoding encoding) { }

	// RVA: 0x19D2E60 Offset: 0x19D2F61 VA: 0x19D2E60
	public void .ctor(Stream output, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x19D3010 Offset: 0x19D3111 VA: 0x19D3010 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x19D3060 Offset: 0x19D3161 VA: 0x19D3060 Slot: 4
	public void Dispose() { }

	// RVA: 0x19D3070 Offset: 0x19D3171 VA: 0x19D3070 Slot: 6
	public virtual void Flush() { }

	// RVA: 0x19D30A0 Offset: 0x19D31A1 VA: 0x19D30A0 Slot: 7
	public virtual void Write(bool value) { }

	// RVA: 0x19D3100 Offset: 0x19D3201 VA: 0x19D3100 Slot: 8
	public virtual void Write(byte value) { }

	// RVA: 0x19D3130 Offset: 0x19D3231 VA: 0x19D3130 Slot: 9
	public virtual void Write(byte[] buffer) { }

	// RVA: 0x19D31E0 Offset: 0x19D32E1 VA: 0x19D31E0 Slot: 10
	public virtual void Write(byte[] buffer, int index, int count) { }

	// RVA: 0x19D3210 Offset: 0x19D3311 VA: 0x19D3210 Slot: 11
	public virtual void Write(char ch) { }

	// RVA: 0x19D3340 Offset: 0x19D3441 VA: 0x19D3340 Slot: 12
	public virtual void Write(char[] chars) { }

	// RVA: 0x19D3420 Offset: 0x19D3521 VA: 0x19D3420 Slot: 13
	public virtual void Write(double value) { }

	// RVA: 0x19D3470 Offset: 0x19D3571 VA: 0x19D3470 Slot: 14
	public virtual void Write(short value) { }

	[CLSCompliantAttribute] // RVA: 0xB8650 Offset: 0xB8751 VA: 0xB8650
	// RVA: 0x19D34F0 Offset: 0x19D35F1 VA: 0x19D34F0 Slot: 15
	public virtual void Write(ushort value) { }

	// RVA: 0x19D3570 Offset: 0x19D3671 VA: 0x19D3570 Slot: 16
	public virtual void Write(int value) { }

	[CLSCompliantAttribute] // RVA: 0xB8670 Offset: 0xB8771 VA: 0xB8670
	// RVA: 0x19D3620 Offset: 0x19D3721 VA: 0x19D3620 Slot: 17
	public virtual void Write(uint value) { }

	// RVA: 0x19D36D0 Offset: 0x19D37D1 VA: 0x19D36D0 Slot: 18
	public virtual void Write(long value) { }

	[CLSCompliantAttribute] // RVA: 0xB8690 Offset: 0xB8791 VA: 0xB8690
	// RVA: 0x19D37F0 Offset: 0x19D38F1 VA: 0x19D37F0 Slot: 19
	public virtual void Write(ulong value) { }

	// RVA: 0x19D3910 Offset: 0x19D3A11 VA: 0x19D3910 Slot: 20
	public virtual void Write(float value) { }

	// RVA: 0x19D3960 Offset: 0x19D3A61 VA: 0x19D3960 Slot: 21
	public virtual void Write(string value) { }

	// RVA: 0x19D3C40 Offset: 0x19D3D41 VA: 0x19D3C40
	protected void Write7BitEncodedInt(int value) { }

	// RVA: 0x19D3CB0 Offset: 0x19D3DB1 VA: 0x19D3CB0
	private static void .cctor() { }
}

