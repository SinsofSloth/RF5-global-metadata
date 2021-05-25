[UnmanagedFunctionPointerAttribute] // RVA: 0xBB7D0 Offset: 0xBB8D1 VA: 0xBB7D0
public sealed class UnityTls.unitytls_tlsctx_write_callback : MulticastDelegate // TypeDefIndex: 1643
{
	// Methods

	// RVA: 0x16FFF80 Offset: 0x1700081 VA: 0x16FFF80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FFFA0 Offset: 0x17000A1 VA: 0x16FFFA0 Slot: 13
	public virtual IntPtr Invoke(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1700280 Offset: 0x1700381 VA: 0x1700280 Slot: 14
	public virtual IAsyncResult BeginInvoke(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1700330 Offset: 0x1700431 VA: 0x1700330 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}

