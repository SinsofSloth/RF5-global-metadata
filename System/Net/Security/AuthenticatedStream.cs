public abstract class AuthenticatedStream : Stream // TypeDefIndex: 2031
{
	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Properties
	protected Stream InnerStream { get; }
	public abstract bool IsAuthenticated { get; }

	// Methods

	// RVA: 0x16CA3D0 Offset: 0x16CA4D1 VA: 0x16CA3D0
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x16CA580 Offset: 0x16CA681 VA: 0x16CA580
	protected Stream get_InnerStream() { }

	// RVA: 0x16CA590 Offset: 0x16CA691 VA: 0x16CA590 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool get_IsAuthenticated() { }
}

