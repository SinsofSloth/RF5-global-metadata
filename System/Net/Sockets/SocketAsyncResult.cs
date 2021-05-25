internal sealed class SocketAsyncResult : IOAsyncResult // TypeDefIndex: 2028
{
	// Fields
	public Socket socket; // 0x30
	public SocketOperation operation; // 0x38
	private Exception DelayedException; // 0x40
	public EndPoint EndPoint; // 0x48
	public byte[] Buffer; // 0x50
	public int Offset; // 0x58
	public int Size; // 0x5C
	public SocketFlags SockFlags; // 0x60
	public Socket AcceptSocket; // 0x68
	public IPAddress[] Addresses; // 0x70
	public int Port; // 0x78
	public IList<ArraySegment<byte>> Buffers; // 0x80
	public bool ReuseSocket; // 0x88
	public int CurrentAddress; // 0x8C
	public Socket AcceptedSocket; // 0x90
	public int Total; // 0x98
	internal int error; // 0x9C
	public int EndCalled; // 0xA0

	// Properties
	public IntPtr Handle { get; }
	public SocketError ErrorCode { get; }

	// Methods

	// RVA: 0x16D9650 Offset: 0x16D9751 VA: 0x16D9650
	public IntPtr get_Handle() { }

	// RVA: 0x16D9E40 Offset: 0x16D9F41 VA: 0x16D9E40
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x16D9FF0 Offset: 0x16DA0F1 VA: 0x16D9FF0
	public SocketError get_ErrorCode() { }

	// RVA: 0x16D8630 Offset: 0x16D8731 VA: 0x16D8630
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x16DE200 Offset: 0x16DE301 VA: 0x16DE200 Slot: 8
	internal override void CompleteDisposed() { }

	// RVA: 0x16DC6F0 Offset: 0x16DC7F1 VA: 0x16DC6F0
	public void Complete() { }

	// RVA: 0x16D9640 Offset: 0x16D9741 VA: 0x16D9640
	public void Complete(bool synch) { }

	// RVA: 0x16DAA30 Offset: 0x16DAB31 VA: 0x16DAA30
	public void Complete(int total) { }

	// RVA: 0x16D9600 Offset: 0x16D9701 VA: 0x16D9600
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x16DAA00 Offset: 0x16DAB01 VA: 0x16DAA00
	public void Complete(Exception e) { }

	// RVA: 0x16DBD10 Offset: 0x16DBE11 VA: 0x16DBD10
	public void Complete(Socket s) { }

	// RVA: 0x16DC030 Offset: 0x16DC131 VA: 0x16DC030
	public void Complete(Socket s, int total) { }
}

