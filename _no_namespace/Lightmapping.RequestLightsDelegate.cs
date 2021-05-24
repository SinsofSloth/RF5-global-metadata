public sealed class Lightmapping.RequestLightsDelegate : MulticastDelegate // TypeDefIndex: 3378
{
	// Methods

	// RVA: 0x2B0B660 Offset: 0x2B0B761 VA: 0x2B0B660
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2B0B110 Offset: 0x2B0B211 VA: 0x2B0B110 Slot: 13
	public virtual void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

	// RVA: 0x2B0BB10 Offset: 0x2B0BC11 VA: 0x2B0BB10 Slot: 14
	public virtual IAsyncResult BeginInvoke(Light[] requests, NativeArray<LightDataGI> lightsOutput, AsyncCallback callback, object object) { }

	// RVA: 0x2B0BBB0 Offset: 0x2B0BCB1 VA: 0x2B0BBB0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

