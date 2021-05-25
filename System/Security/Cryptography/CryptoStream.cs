[ComVisibleAttribute] // RVA: 0xAFE30 Offset: 0xAFF31 VA: 0xAFE30
public class CryptoStream : Stream, IDisposable // TypeDefIndex: 923
{
	// Fields
	private Stream _stream; // 0x28
	private ICryptoTransform _Transform; // 0x30
	private byte[] _InputBuffer; // 0x38
	private int _InputBufferIndex; // 0x40
	private int _InputBlockSize; // 0x44
	private byte[] _OutputBuffer; // 0x48
	private int _OutputBufferIndex; // 0x50
	private int _OutputBlockSize; // 0x54
	private CryptoStreamMode _transformMode; // 0x58
	private bool _canRead; // 0x5C
	private bool _canWrite; // 0x5D
	private bool _finalBlockTransformed; // 0x5E

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public bool HasFlushedFinalBlock { get; }

	// Methods

	// RVA: 0x1946610 Offset: 0x1946711 VA: 0x1946610
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	// RVA: 0x1946980 Offset: 0x1946A81 VA: 0x1946980 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1946990 Offset: 0x1946A91 VA: 0x1946990 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x19469A0 Offset: 0x1946AA1 VA: 0x19469A0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x19469B0 Offset: 0x1946AB1 VA: 0x19469B0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x1946A30 Offset: 0x1946B31 VA: 0x1946A30 Slot: 11
	public override long get_Position() { }

	// RVA: 0x1946AB0 Offset: 0x1946BB1 VA: 0x1946AB0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x1946B30 Offset: 0x1946C31 VA: 0x1946B30
	public bool get_HasFlushedFinalBlock() { }

	// RVA: 0x1946B40 Offset: 0x1946C41 VA: 0x1946B40
	public void FlushFinalBlock() { }

	// RVA: 0x1946D80 Offset: 0x1946E81 VA: 0x1946D80 Slot: 17
	public override void Flush() { }

	// RVA: 0x1946D90 Offset: 0x1946E91 VA: 0x1946D90 Slot: 24
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1946E10 Offset: 0x1946F11 VA: 0x1946E10 Slot: 25
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x1947520 Offset: 0x1947621 VA: 0x1947520 Slot: 20
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xB9190 Offset: 0xB9291 VA: 0xB9190
	// RVA: 0x19477C0 Offset: 0x19478C1 VA: 0x19477C0
	private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1947950 Offset: 0x1947A51 VA: 0x1947950 Slot: 27
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1947EA0 Offset: 0x1947FA1 VA: 0x1947EA0 Slot: 23
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xB9200 Offset: 0xB9301 VA: 0xB9200
	// RVA: 0x1948130 Offset: 0x1948231 VA: 0x1948130
	private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x19482D0 Offset: 0x19483D1 VA: 0x19482D0
	public void Clear() { }

	// RVA: 0x19482E0 Offset: 0x19483E1 VA: 0x19482E0 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1946800 Offset: 0x1946901 VA: 0x1946800
	private void InitializeBuffer() { }
}

