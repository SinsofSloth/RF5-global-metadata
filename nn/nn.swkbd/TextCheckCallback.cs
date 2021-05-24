[UnmanagedFunctionPointerAttribute] // RVA: 0x157280 Offset: 0x157381 VA: 0x157280
public sealed class TextCheckCallback : MulticastDelegate // TypeDefIndex: 11469
{
	// Methods

	// RVA: 0x34F5110 Offset: 0x34F5211 VA: 0x34F5110
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x34F5130 Offset: 0x34F5231 VA: 0x34F5130 Slot: 13
	public virtual TextCheckResult Invoke(IntPtr pOutDialogTextBuf, ref long pOutDialogTextLengthSize, ref String pStr) { }

	// RVA: 0x34F5400 Offset: 0x34F5501 VA: 0x34F5400 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr pOutDialogTextBuf, ref long pOutDialogTextLengthSize, ref String pStr, AsyncCallback callback, object object) { }

	// RVA: 0x34F54D0 Offset: 0x34F55D1 VA: 0x34F54D0 Slot: 15
	public virtual TextCheckResult EndInvoke(ref long pOutDialogTextLengthSize, ref String pStr, IAsyncResult result) { }
}

