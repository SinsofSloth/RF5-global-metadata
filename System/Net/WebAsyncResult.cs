internal class WebAsyncResult : SimpleAsyncResult // TypeDefIndex: 1994
{
	// Fields
	private int nbytes; // 0x4C
	private IAsyncResult innerAsyncResult; // 0x50
	private HttpWebResponse response; // 0x58
	private Stream writeStream; // 0x60
	private byte[] buffer; // 0x68
	private int offset; // 0x70
	private int size; // 0x74
	public bool EndCalled; // 0x78
	public bool AsyncWriteAll; // 0x79
	public HttpWebRequest AsyncObject; // 0x80

	// Properties
	internal int NBytes { get; set; }
	internal IAsyncResult InnerAsyncResult { get; set; }
	internal HttpWebResponse Response { get; }
	internal byte[] Buffer { get; }
	internal int Offset { get; }
	internal int Size { get; }

	// Methods

	// RVA: 0x16E0E30 Offset: 0x16E0F31 VA: 0x16E0E30
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x16E0E40 Offset: 0x16E0F41 VA: 0x16E0E40
	public void .ctor(HttpWebRequest request, AsyncCallback cb, object state) { }

	// RVA: 0x16E0E80 Offset: 0x16E0F81 VA: 0x16E0E80
	public void .ctor(AsyncCallback cb, object state, byte[] buffer, int offset, int size) { }

	// RVA: 0x16E0ED0 Offset: 0x16E0FD1 VA: 0x16E0ED0
	internal void Reset() { }

	// RVA: 0x16E0F20 Offset: 0x16E1021 VA: 0x16E0F20
	internal void SetCompleted(bool synch, int nbytes) { }

	// RVA: 0x16E0F30 Offset: 0x16E1031 VA: 0x16E0F30
	internal void SetCompleted(bool synch, Stream writeStream) { }

	// RVA: 0x16E0F70 Offset: 0x16E1071 VA: 0x16E0F70
	internal void SetCompleted(bool synch, HttpWebResponse response) { }

	// RVA: 0x16E0FB0 Offset: 0x16E10B1 VA: 0x16E0FB0
	internal void DoCallback() { }

	// RVA: 0x16E0FE0 Offset: 0x16E10E1 VA: 0x16E0FE0
	internal int get_NBytes() { }

	// RVA: 0x16E0FF0 Offset: 0x16E10F1 VA: 0x16E0FF0
	internal void set_NBytes(int value) { }

	// RVA: 0x16E1000 Offset: 0x16E1101 VA: 0x16E1000
	internal IAsyncResult get_InnerAsyncResult() { }

	// RVA: 0x16E1010 Offset: 0x16E1111 VA: 0x16E1010
	internal void set_InnerAsyncResult(IAsyncResult value) { }

	// RVA: 0x16E1020 Offset: 0x16E1121 VA: 0x16E1020
	internal HttpWebResponse get_Response() { }

	// RVA: 0x16E1030 Offset: 0x16E1131 VA: 0x16E1030
	internal byte[] get_Buffer() { }

	// RVA: 0x16E1040 Offset: 0x16E1141 VA: 0x16E1040
	internal int get_Offset() { }

	// RVA: 0x16E1050 Offset: 0x16E1151 VA: 0x16E1050
	internal int get_Size() { }
}

