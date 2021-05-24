public class MessagePackStreamReader : IDisposable // TypeDefIndex: 5162
{
	// Fields
	private readonly Stream stream; // 0x10
	private readonly bool leaveOpen; // 0x18
	private SequencePool.Rental sequenceRental; // 0x20
	private Nullable<SequencePosition> endOfLastMessage; // 0x30

	// Properties
	public ReadOnlySequence<byte> RemainingBytes { get; }
	private Sequence<byte> ReadData { get; }

	// Methods

	// RVA: 0x14EAC60 Offset: 0x14EAD61 VA: 0x14EAC60
	public void .ctor(Stream stream) { }

	// RVA: 0x14EAC70 Offset: 0x14EAD71 VA: 0x14EAC70
	public void .ctor(Stream stream, bool leaveOpen) { }

	// RVA: 0x14EAF80 Offset: 0x14EB081 VA: 0x14EAF80
	public ReadOnlySequence<byte> get_RemainingBytes() { }

	// RVA: 0x14EB0D0 Offset: 0x14EB1D1 VA: 0x14EB0D0
	private Sequence<byte> get_ReadData() { }

	[AsyncStateMachineAttribute] // RVA: 0x13A290 Offset: 0x13A391 VA: 0x13A290
	// RVA: 0x14EB0E0 Offset: 0x14EB1E1 VA: 0x14EB0E0
	public ValueTask<Nullable<ReadOnlySequence<byte>>> ReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14EB280 Offset: 0x14EB381 VA: 0x14EB280
	public void DiscardBufferedData() { }

	// RVA: 0x14EB2F0 Offset: 0x14EB3F1 VA: 0x14EB2F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14EB360 Offset: 0x14EB461 VA: 0x14EB360
	private void RecycleLastMessage() { }

	[AsyncStateMachineAttribute] // RVA: 0x13A300 Offset: 0x13A401 VA: 0x13A300
	// RVA: 0x14EB400 Offset: 0x14EB501 VA: 0x14EB400
	private Task<bool> TryReadMoreDataAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14EB560 Offset: 0x14EB661 VA: 0x14EB560
	private bool TryReadNextMessage(out ReadOnlySequence<byte> completeMessage) { }
}

public class MessagePackStreamReader : IDisposable // TypeDefIndex: 5162
{
	// Fields
	private readonly Stream stream; // 0x10
	private readonly bool leaveOpen; // 0x18
	private SequencePool.Rental sequenceRental; // 0x20
	private Nullable<SequencePosition> endOfLastMessage; // 0x30

	// Properties
	public ReadOnlySequence<byte> RemainingBytes { get; }
	private Sequence<byte> ReadData { get; }

	// Methods

	// RVA: 0x14EAC60 Offset: 0x14EAD61 VA: 0x14EAC60
	public void .ctor(Stream stream) { }

	// RVA: 0x14EAC70 Offset: 0x14EAD71 VA: 0x14EAC70
	public void .ctor(Stream stream, bool leaveOpen) { }

	// RVA: 0x14EAF80 Offset: 0x14EB081 VA: 0x14EAF80
	public ReadOnlySequence<byte> get_RemainingBytes() { }

	// RVA: 0x14EB0D0 Offset: 0x14EB1D1 VA: 0x14EB0D0
	private Sequence<byte> get_ReadData() { }

	[AsyncStateMachineAttribute] // RVA: 0x13A290 Offset: 0x13A391 VA: 0x13A290
	// RVA: 0x14EB0E0 Offset: 0x14EB1E1 VA: 0x14EB0E0
	public ValueTask<Nullable<ReadOnlySequence<byte>>> ReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14EB280 Offset: 0x14EB381 VA: 0x14EB280
	public void DiscardBufferedData() { }

	// RVA: 0x14EB2F0 Offset: 0x14EB3F1 VA: 0x14EB2F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14EB360 Offset: 0x14EB461 VA: 0x14EB360
	private void RecycleLastMessage() { }

	[AsyncStateMachineAttribute] // RVA: 0x13A300 Offset: 0x13A401 VA: 0x13A300
	// RVA: 0x14EB400 Offset: 0x14EB501 VA: 0x14EB400
	private Task<bool> TryReadMoreDataAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14EB560 Offset: 0x14EB661 VA: 0x14EB560
	private bool TryReadNextMessage(out ReadOnlySequence<byte> completeMessage) { }
}

public class MessagePackStreamReader : IDisposable // TypeDefIndex: 5162
{
	// Fields
	private readonly Stream stream; // 0x10
	private readonly bool leaveOpen; // 0x18
	private SequencePool.Rental sequenceRental; // 0x20
	private Nullable<SequencePosition> endOfLastMessage; // 0x30

	// Properties
	public ReadOnlySequence<byte> RemainingBytes { get; }
	private Sequence<byte> ReadData { get; }

	// Methods

	// RVA: 0x14EAC60 Offset: 0x14EAD61 VA: 0x14EAC60
	public void .ctor(Stream stream) { }

	// RVA: 0x14EAC70 Offset: 0x14EAD71 VA: 0x14EAC70
	public void .ctor(Stream stream, bool leaveOpen) { }

	// RVA: 0x14EAF80 Offset: 0x14EB081 VA: 0x14EAF80
	public ReadOnlySequence<byte> get_RemainingBytes() { }

	// RVA: 0x14EB0D0 Offset: 0x14EB1D1 VA: 0x14EB0D0
	private Sequence<byte> get_ReadData() { }

	[AsyncStateMachineAttribute] // RVA: 0x13A290 Offset: 0x13A391 VA: 0x13A290
	// RVA: 0x14EB0E0 Offset: 0x14EB1E1 VA: 0x14EB0E0
	public ValueTask<Nullable<ReadOnlySequence<byte>>> ReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14EB280 Offset: 0x14EB381 VA: 0x14EB280
	public void DiscardBufferedData() { }

	// RVA: 0x14EB2F0 Offset: 0x14EB3F1 VA: 0x14EB2F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14EB360 Offset: 0x14EB461 VA: 0x14EB360
	private void RecycleLastMessage() { }

	[AsyncStateMachineAttribute] // RVA: 0x13A300 Offset: 0x13A401 VA: 0x13A300
	// RVA: 0x14EB400 Offset: 0x14EB501 VA: 0x14EB400
	private Task<bool> TryReadMoreDataAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14EB560 Offset: 0x14EB661 VA: 0x14EB560
	private bool TryReadNextMessage(out ReadOnlySequence<byte> completeMessage) { }
}

public class MessagePackStreamReader : IDisposable // TypeDefIndex: 5162
{
	// Fields
	private readonly Stream stream; // 0x10
	private readonly bool leaveOpen; // 0x18
	private SequencePool.Rental sequenceRental; // 0x20
	private Nullable<SequencePosition> endOfLastMessage; // 0x30

	// Properties
	public ReadOnlySequence<byte> RemainingBytes { get; }
	private Sequence<byte> ReadData { get; }

	// Methods

	// RVA: 0x14EAC60 Offset: 0x14EAD61 VA: 0x14EAC60
	public void .ctor(Stream stream) { }

	// RVA: 0x14EAC70 Offset: 0x14EAD71 VA: 0x14EAC70
	public void .ctor(Stream stream, bool leaveOpen) { }

	// RVA: 0x14EAF80 Offset: 0x14EB081 VA: 0x14EAF80
	public ReadOnlySequence<byte> get_RemainingBytes() { }

	// RVA: 0x14EB0D0 Offset: 0x14EB1D1 VA: 0x14EB0D0
	private Sequence<byte> get_ReadData() { }

	[AsyncStateMachineAttribute] // RVA: 0x13A290 Offset: 0x13A391 VA: 0x13A290
	// RVA: 0x14EB0E0 Offset: 0x14EB1E1 VA: 0x14EB0E0
	public ValueTask<Nullable<ReadOnlySequence<byte>>> ReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14EB280 Offset: 0x14EB381 VA: 0x14EB280
	public void DiscardBufferedData() { }

	// RVA: 0x14EB2F0 Offset: 0x14EB3F1 VA: 0x14EB2F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14EB360 Offset: 0x14EB461 VA: 0x14EB360
	private void RecycleLastMessage() { }

	[AsyncStateMachineAttribute] // RVA: 0x13A300 Offset: 0x13A401 VA: 0x13A300
	// RVA: 0x14EB400 Offset: 0x14EB501 VA: 0x14EB400
	private Task<bool> TryReadMoreDataAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14EB560 Offset: 0x14EB661 VA: 0x14EB560
	private bool TryReadNextMessage(out ReadOnlySequence<byte> completeMessage) { }
}

public class MessagePackStreamReader : IDisposable // TypeDefIndex: 5162
{
	// Fields
	private readonly Stream stream; // 0x10
	private readonly bool leaveOpen; // 0x18
	private SequencePool.Rental sequenceRental; // 0x20
	private Nullable<SequencePosition> endOfLastMessage; // 0x30

	// Properties
	public ReadOnlySequence<byte> RemainingBytes { get; }
	private Sequence<byte> ReadData { get; }

	// Methods

	// RVA: 0x14EAC60 Offset: 0x14EAD61 VA: 0x14EAC60
	public void .ctor(Stream stream) { }

	// RVA: 0x14EAC70 Offset: 0x14EAD71 VA: 0x14EAC70
	public void .ctor(Stream stream, bool leaveOpen) { }

	// RVA: 0x14EAF80 Offset: 0x14EB081 VA: 0x14EAF80
	public ReadOnlySequence<byte> get_RemainingBytes() { }

	// RVA: 0x14EB0D0 Offset: 0x14EB1D1 VA: 0x14EB0D0
	private Sequence<byte> get_ReadData() { }

	[AsyncStateMachineAttribute] // RVA: 0x13A290 Offset: 0x13A391 VA: 0x13A290
	// RVA: 0x14EB0E0 Offset: 0x14EB1E1 VA: 0x14EB0E0
	public ValueTask<Nullable<ReadOnlySequence<byte>>> ReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14EB280 Offset: 0x14EB381 VA: 0x14EB280
	public void DiscardBufferedData() { }

	// RVA: 0x14EB2F0 Offset: 0x14EB3F1 VA: 0x14EB2F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14EB360 Offset: 0x14EB461 VA: 0x14EB360
	private void RecycleLastMessage() { }

	[AsyncStateMachineAttribute] // RVA: 0x13A300 Offset: 0x13A401 VA: 0x13A300
	// RVA: 0x14EB400 Offset: 0x14EB501 VA: 0x14EB400
	private Task<bool> TryReadMoreDataAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14EB560 Offset: 0x14EB661 VA: 0x14EB560
	private bool TryReadNextMessage(out ReadOnlySequence<byte> completeMessage) { }
}

public class MessagePackStreamReader : IDisposable // TypeDefIndex: 5162
{
	// Fields
	private readonly Stream stream; // 0x10
	private readonly bool leaveOpen; // 0x18
	private SequencePool.Rental sequenceRental; // 0x20
	private Nullable<SequencePosition> endOfLastMessage; // 0x30

	// Properties
	public ReadOnlySequence<byte> RemainingBytes { get; }
	private Sequence<byte> ReadData { get; }

	// Methods

	// RVA: 0x14EAC60 Offset: 0x14EAD61 VA: 0x14EAC60
	public void .ctor(Stream stream) { }

	// RVA: 0x14EAC70 Offset: 0x14EAD71 VA: 0x14EAC70
	public void .ctor(Stream stream, bool leaveOpen) { }

	// RVA: 0x14EAF80 Offset: 0x14EB081 VA: 0x14EAF80
	public ReadOnlySequence<byte> get_RemainingBytes() { }

	// RVA: 0x14EB0D0 Offset: 0x14EB1D1 VA: 0x14EB0D0
	private Sequence<byte> get_ReadData() { }

	[AsyncStateMachineAttribute] // RVA: 0x13A290 Offset: 0x13A391 VA: 0x13A290
	// RVA: 0x14EB0E0 Offset: 0x14EB1E1 VA: 0x14EB0E0
	public ValueTask<Nullable<ReadOnlySequence<byte>>> ReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14EB280 Offset: 0x14EB381 VA: 0x14EB280
	public void DiscardBufferedData() { }

	// RVA: 0x14EB2F0 Offset: 0x14EB3F1 VA: 0x14EB2F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14EB360 Offset: 0x14EB461 VA: 0x14EB360
	private void RecycleLastMessage() { }

	[AsyncStateMachineAttribute] // RVA: 0x13A300 Offset: 0x13A401 VA: 0x13A300
	// RVA: 0x14EB400 Offset: 0x14EB501 VA: 0x14EB400
	private Task<bool> TryReadMoreDataAsync(CancellationToken cancellationToken) { }

	// RVA: 0x14EB560 Offset: 0x14EB661 VA: 0x14EB560
	private bool TryReadNextMessage(out ReadOnlySequence<byte> completeMessage) { }
}

