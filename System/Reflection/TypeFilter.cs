[ComVisibleAttribute] // RVA: 0xADFB0 Offset: 0xAE0B1 VA: 0xADFB0
[Serializable]
public sealed class TypeFilter : MulticastDelegate // TypeDefIndex: 564
{
	// Methods

	// RVA: 0x17F2CF0 Offset: 0x17F2DF1 VA: 0x17F2CF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17F2D10 Offset: 0x17F2E11 VA: 0x17F2D10 Slot: 13
	public virtual bool Invoke(Type m, object filterCriteria) { }

	// RVA: 0x17F3140 Offset: 0x17F3241 VA: 0x17F3140 Slot: 14
	public virtual IAsyncResult BeginInvoke(Type m, object filterCriteria, AsyncCallback callback, object object) { }

	// RVA: 0x17F3170 Offset: 0x17F3271 VA: 0x17F3170 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

