internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest // TypeDefIndex: 1710
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBCDD0 Offset: 0xBCED1 VA: 0xBCDD0
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xBCDE0 Offset: 0xBCEE1 VA: 0xBCDE0
	private int <CurrentSize>k__BackingField; // 0x40

	// Properties
	protected BufferOffsetSize UserBuffer { get; }
	protected int CurrentSize { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xBD420 Offset: 0xBD521 VA: 0xBD420
	// RVA: 0x16F0470 Offset: 0x16F0571 VA: 0x16F0470
	protected BufferOffsetSize get_UserBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD430 Offset: 0xBD531 VA: 0xBD430
	// RVA: 0x16F0480 Offset: 0x16F0581 VA: 0x16F0480
	protected int get_CurrentSize() { }

	[CompilerGeneratedAttribute] // RVA: 0xBD440 Offset: 0xBD541 VA: 0xBD440
	// RVA: 0x16F0490 Offset: 0x16F0591 VA: 0x16F0490
	protected void set_CurrentSize(int value) { }

	// RVA: 0x16F04A0 Offset: 0x16F05A1 VA: 0x16F04A0
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x16F06D0 Offset: 0x16F07D1 VA: 0x16F06D0 Slot: 3
	public override string ToString() { }
}

