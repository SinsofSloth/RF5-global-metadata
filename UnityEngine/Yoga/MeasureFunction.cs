internal sealed class MeasureFunction : MulticastDelegate // TypeDefIndex: 4099
{
	// Methods

	// RVA: 0x1BCB360 Offset: 0x1BCB461 VA: 0x1BCB360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BCB380 Offset: 0x1BCB481 VA: 0x1BCB380 Slot: 13
	public virtual YogaSize Invoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x1BCB840 Offset: 0x1BCB941 VA: 0x1BCB840 Slot: 14
	public virtual IAsyncResult BeginInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, AsyncCallback callback, object object) { }

	// RVA: 0x1BCB920 Offset: 0x1BCBA21 VA: 0x1BCB920 Slot: 15
	public virtual YogaSize EndInvoke(IAsyncResult result) { }
}

