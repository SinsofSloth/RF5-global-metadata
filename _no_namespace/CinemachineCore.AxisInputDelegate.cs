public sealed class CinemachineCore.AxisInputDelegate : MulticastDelegate // TypeDefIndex: 4826
{
	// Methods

	// RVA: 0x171FF30 Offset: 0x1720031 VA: 0x171FF30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x171FF50 Offset: 0x1720051 VA: 0x171FF50 Slot: 13
	public virtual float Invoke(string axisName) { }

	// RVA: 0x1720330 Offset: 0x1720431 VA: 0x1720330 Slot: 14
	public virtual IAsyncResult BeginInvoke(string axisName, AsyncCallback callback, object object) { }

	// RVA: 0x1720360 Offset: 0x1720461 VA: 0x1720360 Slot: 15
	public virtual float EndInvoke(IAsyncResult result) { }
}

