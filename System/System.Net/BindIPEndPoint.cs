public sealed class BindIPEndPoint : MulticastDelegate // TypeDefIndex: 1958
{
	// Methods

	// RVA: 0x28F3C40 Offset: 0x28F3D41 VA: 0x28F3C40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x28F3C60 Offset: 0x28F3D61 VA: 0x28F3C60 Slot: 13
	public virtual IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount) { }

	// RVA: 0x28F40B0 Offset: 0x28F41B1 VA: 0x28F40B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount, AsyncCallback callback, object object) { }

	// RVA: 0x28F4150 Offset: 0x28F4251 VA: 0x28F4150 Slot: 15
	public virtual IPEndPoint EndInvoke(IAsyncResult result) { }
}

