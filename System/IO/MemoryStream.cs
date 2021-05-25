[ComVisibleAttribute] // RVA: 0xAE9A0 Offset: 0xAEAA1 VA: 0xAE9A0
[Serializable]
public class MemoryStream : Stream // TypeDefIndex: 653
{
	// Fields
	private byte[] _buffer; // 0x28
	private int _origin; // 0x30
	private int _position; // 0x34
	private int _length; // 0x38
	private int _capacity; // 0x3C
	private bool _expandable; // 0x40
	private bool _writable; // 0x41
	private bool _exposable; // 0x42
	private bool _isOpen; // 0x43
	private Task<int> _lastReadTask; // 0x48

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public virtual int Capacity { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x18AAB00 Offset: 0x18AAC01 VA: 0x18AAB00
	public void .ctor() { }

	// RVA: 0x18AABA0 Offset: 0x18AACA1 VA: 0x18AABA0
	public void .ctor(int capacity) { }

	// RVA: 0x18AACB0 Offset: 0x18AADB1 VA: 0x18AACB0
	public void .ctor(byte[] buffer) { }

	// RVA: 0x18AACC0 Offset: 0x18AADC1 VA: 0x18AACC0
	public void .ctor(byte[] buffer, bool writable) { }

	// RVA: 0x18AADD0 Offset: 0x18AAED1 VA: 0x18AADD0
	public void .ctor(byte[] buffer, int index, int count) { }

	// RVA: 0x18AADE0 Offset: 0x18AAEE1 VA: 0x18AADE0
	public void .ctor(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	// RVA: 0x18AAFE0 Offset: 0x18AB0E1 VA: 0x18AAFE0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x18AAFF0 Offset: 0x18AB0F1 VA: 0x18AAFF0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x18AB000 Offset: 0x18AB101 VA: 0x18AB000 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x18AB010 Offset: 0x18AB111 VA: 0x18AB010
	private void EnsureWriteable() { }

	// RVA: 0x18AB040 Offset: 0x18AB141 VA: 0x18AB040 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x18AB0B0 Offset: 0x18AB1B1 VA: 0x18AB0B0
	private bool EnsureCapacity(int value) { }

	// RVA: 0x18AB1B0 Offset: 0x18AB2B1 VA: 0x18AB1B0 Slot: 17
	public override void Flush() { }

	// RVA: 0x18AB1C0 Offset: 0x18AB2C1 VA: 0x18AB1C0 Slot: 29
	public virtual byte[] GetBuffer() { }

	// RVA: 0x18AB260 Offset: 0x18AB361 VA: 0x18AB260 Slot: 30
	public virtual bool TryGetBuffer(out ArraySegment<byte> buffer) { }

	// RVA: 0x18AB310 Offset: 0x18AB411 VA: 0x18AB310
	internal byte[] InternalGetBuffer() { }

	// RVA: 0x18AB320 Offset: 0x18AB421 VA: 0x18AB320
	internal int InternalGetPosition() { }

	// RVA: 0x18AB360 Offset: 0x18AB461 VA: 0x18AB360
	internal int InternalReadInt32() { }

	// RVA: 0x18AB420 Offset: 0x18AB521 VA: 0x18AB420
	internal int InternalEmulateRead(int count) { }

	// RVA: 0x18AB470 Offset: 0x18AB571 VA: 0x18AB470 Slot: 31
	public virtual int get_Capacity() { }

	// RVA: 0x18AB4B0 Offset: 0x18AB5B1 VA: 0x18AB4B0 Slot: 32
	public virtual void set_Capacity(int value) { }

	// RVA: 0x18AB630 Offset: 0x18AB731 VA: 0x18AB630 Slot: 10
	public override long get_Length() { }

	// RVA: 0x18AB670 Offset: 0x18AB771 VA: 0x18AB670 Slot: 11
	public override long get_Position() { }

	// RVA: 0x18AB6B0 Offset: 0x18AB7B1 VA: 0x18AB6B0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x18AB790 Offset: 0x18AB891 VA: 0x18AB790 Slot: 25
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB86D0 Offset: 0xB87D1 VA: 0xB86D0
	// RVA: 0x18AB9D0 Offset: 0x18ABAD1 VA: 0x18AB9D0 Slot: 20
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18ABD80 Offset: 0x18ABE81 VA: 0x18ABD80 Slot: 26
	public override int ReadByte() { }

	// RVA: 0x18ABE10 Offset: 0x18ABF11 VA: 0x18ABE10 Slot: 24
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x18ABFD0 Offset: 0x18AC0D1 VA: 0x18ABFD0 Slot: 33
	public virtual byte[] ToArray() { }

	// RVA: 0x18AC0A0 Offset: 0x18AC1A1 VA: 0x18AC0A0 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0xB86F0 Offset: 0xB87F1 VA: 0xB86F0
	// RVA: 0x18AC3B0 Offset: 0x18AC4B1 VA: 0x18AC3B0 Slot: 23
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18AC6D0 Offset: 0x18AC7D1 VA: 0x18AC6D0 Slot: 28
	public override void WriteByte(byte value) { }
}

