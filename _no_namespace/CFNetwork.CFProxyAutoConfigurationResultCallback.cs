private sealed class CFNetwork.CFProxyAutoConfigurationResultCallback : MulticastDelegate // TypeDefIndex: 1698
{
	// Methods

	// RVA: 0x16EA590 Offset: 0x16EA691 VA: 0x16EA590
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16EB8A0 Offset: 0x16EB9A1 VA: 0x16EB8A0 Slot: 13
	public virtual void Invoke(IntPtr client, IntPtr proxyList, IntPtr error) { }

	// RVA: 0x16EBB60 Offset: 0x16EBC61 VA: 0x16EBB60 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr client, IntPtr proxyList, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x16EBC10 Offset: 0x16EBD11 VA: 0x16EBC10 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

