public sealed class Simplifier.ProgressDelegate : MulticastDelegate // TypeDefIndex: 9211
{
	// Methods

	// RVA: 0x1F5EC20 Offset: 0x1F5ED21 VA: 0x1F5EC20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F5B9F0 Offset: 0x1F5BAF1 VA: 0x1F5B9F0 Slot: 13
	public virtual void Invoke(string strTitle, string strProgressMessage, float fT) { }

	// RVA: 0x1F5EC40 Offset: 0x1F5ED41 VA: 0x1F5EC40 Slot: 14
	public virtual IAsyncResult BeginInvoke(string strTitle, string strProgressMessage, float fT, AsyncCallback callback, object object) { }

	// RVA: 0x1F5ECE0 Offset: 0x1F5EDE1 VA: 0x1F5ECE0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

