internal sealed class TailStream : Stream // TypeDefIndex: 944
{
	// Fields
	private byte[] _Buffer; // 0x28
	private int _BufferSize; // 0x30
	private int _BufferIndex; // 0x34
	private bool _BufferFull; // 0x38

	// Properties
	public byte[] Buffer { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x2639100 Offset: 0x2639201 VA: 0x2639100
	public void .ctor(int bufferSize) { }

	// RVA: 0x26391A0 Offset: 0x26392A1 VA: 0x26391A0
	public void Clear() { }

	// RVA: 0x26391B0 Offset: 0x26392B1 VA: 0x26391B0 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2639270 Offset: 0x2639371 VA: 0x2639270
	public byte[] get_Buffer() { }

	// RVA: 0x26392F0 Offset: 0x26393F1 VA: 0x26392F0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x2639300 Offset: 0x2639401 VA: 0x2639300 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2639310 Offset: 0x2639411 VA: 0x2639310 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x2639320 Offset: 0x2639421 VA: 0x2639320 Slot: 10
	public override long get_Length() { }

	// RVA: 0x26393A0 Offset: 0x26394A1 VA: 0x26393A0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x2639420 Offset: 0x2639521 VA: 0x2639420 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x26394A0 Offset: 0x26395A1 VA: 0x26394A0 Slot: 17
	public override void Flush() { }

	// RVA: 0x26394B0 Offset: 0x26395B1 VA: 0x26394B0 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2639530 Offset: 0x2639631 VA: 0x2639530 Slot: 25
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x26395B0 Offset: 0x26396B1 VA: 0x26395B0 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }
}

