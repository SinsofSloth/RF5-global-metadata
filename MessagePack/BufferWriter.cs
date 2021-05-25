[IsByRefLikeAttribute] // RVA: 0x1391A0 Offset: 0x1392A1 VA: 0x1391A0
[ObsoleteAttribute] // RVA: 0x1391A0 Offset: 0x1392A1 VA: 0x1391A0
internal struct BufferWriter // TypeDefIndex: 5119
{
	// Fields
	private IBufferWriter<byte> _output; // 0x0
	private Span<byte> _span; // 0x8
	private ArraySegment<byte> _segment; // 0x20
	private int _buffered; // 0x30
	private long _bytesCommitted; // 0x38
	private SequencePool _sequencePool; // 0x40
	private SequencePool.Rental _rental; // 0x48

	// Properties
	public Span<byte> Span { get; }
	public long BytesCommitted { get; }
	internal IBufferWriter<byte> UnderlyingWriter { get; }
	internal SequencePool.Rental SequenceRental { get; }

	// Methods

	// RVA: 0x5C70 Offset: 0x5D71 VA: 0x5C70
	public void .ctor(IBufferWriter<byte> output) { }

	// RVA: 0x5C80 Offset: 0x5D81 VA: 0x5C80
	internal void .ctor(SequencePool sequencePool, byte[] array) { }

	// RVA: 0x5C90 Offset: 0x5D91 VA: 0x5C90
	public Span<byte> get_Span() { }

	// RVA: 0x5CB0 Offset: 0x5DB1 VA: 0x5CB0
	public long get_BytesCommitted() { }

	// RVA: 0x5CC0 Offset: 0x5DC1 VA: 0x5CC0
	internal IBufferWriter<byte> get_UnderlyingWriter() { }

	// RVA: 0x5CD0 Offset: 0x5DD1 VA: 0x5CD0
	internal SequencePool.Rental get_SequenceRental() { }

	// RVA: 0x5CE0 Offset: 0x5DE1 VA: 0x5CE0
	public Span<byte> GetSpan(int sizeHint) { }

	// RVA: 0x5D70 Offset: 0x5E71 VA: 0x5D70
	public ref byte GetPointer(int sizeHint) { }

	// RVA: 0x5E80 Offset: 0x5F81 VA: 0x5E80
	public void Commit() { }

	// RVA: 0x5F90 Offset: 0x6091 VA: 0x5F90
	public void Advance(int count) { }

	// RVA: 0x5FA0 Offset: 0x60A1 VA: 0x5FA0
	public void Write(ReadOnlySpan<byte> source) { }

	// RVA: 0x6080 Offset: 0x6181 VA: 0x6080
	public void Ensure(int count = 1) { }

	// RVA: 0x6100 Offset: 0x6201 VA: 0x6100
	internal bool TryGetUncommittedSpan(out ReadOnlySpan<byte> span) { }

	// RVA: 0x6110 Offset: 0x6211 VA: 0x6110
	private void EnsureMore(int count = 0) { }

	// RVA: 0x6120 Offset: 0x6221 VA: 0x6120
	private void WriteMultiBuffer(ReadOnlySpan<byte> source) { }

	// RVA: 0x6160 Offset: 0x6261 VA: 0x6160
	private void MigrateToSequence() { }
}

