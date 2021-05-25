public sealed class SwitchVideoPlayer.MovieEventDelegate : MulticastDelegate // TypeDefIndex: 3888
{
	// Methods

	// RVA: 0x3518710 Offset: 0x3518811 VA: 0x3518710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35183A0 Offset: 0x35184A1 VA: 0x35183A0 Slot: 13
	public virtual void Invoke(SwitchVideoPlayer.Event eventtype) { }

	// RVA: 0x3518730 Offset: 0x3518831 VA: 0x3518730 Slot: 14
	public virtual IAsyncResult BeginInvoke(SwitchVideoPlayer.Event eventtype, AsyncCallback callback, object object) { }

	// RVA: 0x35187C0 Offset: 0x35188C1 VA: 0x35187C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

