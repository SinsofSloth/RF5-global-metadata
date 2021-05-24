internal sealed class FileWebStream : FileStream, ICloseEx // TypeDefIndex: 1944
{
	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x177F130 Offset: 0x177F231 VA: 0x177F130
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x1780010 Offset: 0x1780111 VA: 0x1780010
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x17807C0 Offset: 0x17808C1 VA: 0x17807C0 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1780840 Offset: 0x1780941 VA: 0x1780840 Slot: 30
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1780880 Offset: 0x1780981 VA: 0x1780880 Slot: 25
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1780A40 Offset: 0x1780B41 VA: 0x1780A40 Slot: 27
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1780B50 Offset: 0x1780C51 VA: 0x1780B50 Slot: 18
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1780C70 Offset: 0x1780D71 VA: 0x1780C70 Slot: 19
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x1780D60 Offset: 0x1780E61 VA: 0x1780D60 Slot: 21
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1780E80 Offset: 0x1780F81 VA: 0x1780E80 Slot: 22
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x1780990 Offset: 0x1780A91 VA: 0x1780990
	private void CheckError() { }
}

