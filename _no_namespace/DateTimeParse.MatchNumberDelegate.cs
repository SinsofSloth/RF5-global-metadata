internal sealed class DateTimeParse.MatchNumberDelegate : MulticastDelegate // TypeDefIndex: 237
{
	// Methods

	// RVA: 0x19A9830 Offset: 0x19A9931 VA: 0x19A9830
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19A8C60 Offset: 0x19A8D61 VA: 0x19A8C60 Slot: 13
	public virtual bool Invoke(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x19A9850 Offset: 0x19A9951 VA: 0x19A9850 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref __DTString str, int digitLen, out int result, AsyncCallback callback, object object) { }

	// RVA: 0x19A9920 Offset: 0x19A9A21 VA: 0x19A9920 Slot: 15
	public virtual bool EndInvoke(ref __DTString str, out int result, IAsyncResult __result) { }
}

