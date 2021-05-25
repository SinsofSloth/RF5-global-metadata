[ComVisibleAttribute] // RVA: 0xADB10 Offset: 0xADC11 VA: 0xADB10
[Serializable]
public sealed class MemberFilter : MulticastDelegate // TypeDefIndex: 545
{
	// Methods

	// RVA: 0x1968810 Offset: 0x1968911 VA: 0x1968810
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1968830 Offset: 0x1968931 VA: 0x1968830 Slot: 13
	public virtual bool Invoke(MemberInfo m, object filterCriteria) { }

	// RVA: 0x1968C60 Offset: 0x1968D61 VA: 0x1968C60 Slot: 14
	public virtual IAsyncResult BeginInvoke(MemberInfo m, object filterCriteria, AsyncCallback callback, object object) { }

	// RVA: 0x1968C90 Offset: 0x1968D91 VA: 0x1968C90 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

