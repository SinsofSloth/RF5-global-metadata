public class SocketAsyncEventArgs : EventArgs, IDisposable // TypeDefIndex: 2027
{
	// Fields
	private bool disposed; // 0x10
	internal int in_progress; // 0x14
	internal EndPoint remote_ep; // 0x18
	internal Socket current_socket; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBCF90 Offset: 0xBD091 VA: 0xBCF90
	private Socket <AcceptSocket>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xBCFA0 Offset: 0xBD0A1 VA: 0xBCFA0
	private int <BytesTransferred>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0xBCFB0 Offset: 0xBD0B1 VA: 0xBCFB0
	private SocketError <SocketError>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0xBCFC0 Offset: 0xBD0C1 VA: 0xBCFC0
	private EventHandler<SocketAsyncEventArgs> Completed; // 0x38

	// Properties
	public Socket AcceptSocket { get; set; }
	internal int BytesTransferred { set; }
	public SocketError SocketError { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xBDB60 Offset: 0xBDC61 VA: 0xBDB60
	// RVA: 0x16DE0B0 Offset: 0x16DE1B1 VA: 0x16DE0B0
	public Socket get_AcceptSocket() { }

	[CompilerGeneratedAttribute] // RVA: 0xBDB70 Offset: 0xBDC71 VA: 0xBDB70
	// RVA: 0x16DE0C0 Offset: 0x16DE1C1 VA: 0x16DE0C0
	public void set_AcceptSocket(Socket value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBDB80 Offset: 0xBDC81 VA: 0xBDB80
	// RVA: 0x16DE0D0 Offset: 0x16DE1D1 VA: 0x16DE0D0
	internal void set_BytesTransferred(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0xBDB90 Offset: 0xBDC91 VA: 0xBDB90
	// RVA: 0x16DE0E0 Offset: 0x16DE1E1 VA: 0x16DE0E0
	public void set_SocketError(SocketError value) { }

	// RVA: 0x16DE0F0 Offset: 0x16DE1F1 VA: 0x16DE0F0
	private void Dispose(bool disposing) { }

	// RVA: 0x16DE110 Offset: 0x16DE211 VA: 0x16DE110 Slot: 4
	public void Dispose() { }

	// RVA: 0x16DBB90 Offset: 0x16DBC91 VA: 0x16DBB90
	internal void Complete() { }

	// RVA: 0x16DE190 Offset: 0x16DE291 VA: 0x16DE190 Slot: 5
	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }
}

