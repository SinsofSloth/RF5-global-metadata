public sealed class EaseFunction : MulticastDelegate // TypeDefIndex: 4917
{
	// Methods

	// RVA: 0x198BDC0 Offset: 0x198BEC1 VA: 0x198BDC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x198A160 Offset: 0x198A261 VA: 0x198A160 Slot: 13
	public virtual float Invoke(float time, float duration, float overshootOrAmplitude, float period) { }

	// RVA: 0x1998490 Offset: 0x1998591 VA: 0x1998490 Slot: 14
	public virtual IAsyncResult BeginInvoke(float time, float duration, float overshootOrAmplitude, float period, AsyncCallback callback, object object) { }

	// RVA: 0x1998560 Offset: 0x1998661 VA: 0x1998560 Slot: 15
	public virtual float EndInvoke(IAsyncResult result) { }
}

