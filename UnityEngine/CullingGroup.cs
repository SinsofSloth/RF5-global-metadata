[NativeHeaderAttribute] // RVA: 0xC44D0 Offset: 0xC45D1 VA: 0xC44D0
public class CullingGroup : IDisposable // TypeDefIndex: 2848
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private CullingGroup.StateChanged m_OnStateChanged; // 0x18

	// Properties
	public CullingGroup.StateChanged onStateChanged { get; set; }
	public Camera targetCamera { set; }

	// Methods

	// RVA: 0x2B04360 Offset: 0x2B04461 VA: 0x2B04360
	public void .ctor() { }

	// RVA: 0x2B04410 Offset: 0x2B04511 VA: 0x2B04410 Slot: 1
	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0xCD8D0 Offset: 0xCD9D1 VA: 0xCD8D0
	// RVA: 0x2B04530 Offset: 0x2B04631 VA: 0x2B04530
	private void DisposeInternal() { }

	// RVA: 0x2B04580 Offset: 0x2B04681 VA: 0x2B04580 Slot: 4
	public void Dispose() { }

	// RVA: 0x2B045F0 Offset: 0x2B046F1 VA: 0x2B045F0
	public CullingGroup.StateChanged get_onStateChanged() { }

	// RVA: 0x2B04600 Offset: 0x2B04701 VA: 0x2B04600
	public void set_onStateChanged(CullingGroup.StateChanged value) { }

	// RVA: 0x2B04610 Offset: 0x2B04711 VA: 0x2B04610
	public void set_targetCamera(Camera value) { }

	// RVA: 0x2B04660 Offset: 0x2B04761 VA: 0x2B04660
	public void SetBoundingSpheres(BoundingSphere[] array) { }

	// RVA: 0x2B046B0 Offset: 0x2B047B1 VA: 0x2B046B0
	public void SetBoundingSphereCount(int count) { }

	[NativeThrowsAttribute] // RVA: 0xCD920 Offset: 0xCDA21 VA: 0xCD920
	[FreeFunctionAttribute] // RVA: 0xCD920 Offset: 0xCDA21 VA: 0xCD920
	// RVA: 0x2B04700 Offset: 0x2B04801 VA: 0x2B04700
	public bool IsVisible(int index) { }

	[NativeThrowsAttribute] // RVA: 0xCD980 Offset: 0xCDA81 VA: 0xCD980
	[FreeFunctionAttribute] // RVA: 0xCD980 Offset: 0xCDA81 VA: 0xCD980
	// RVA: 0x2B04750 Offset: 0x2B04851 VA: 0x2B04750
	public int GetDistance(int index) { }

	[FreeFunctionAttribute] // RVA: 0xCD9E0 Offset: 0xCDAE1 VA: 0xCD9E0
	// RVA: 0x2B047A0 Offset: 0x2B048A1 VA: 0x2B047A0
	public void SetBoundingDistances(float[] distances) { }

	[NativeMethodAttribute] // RVA: 0xCDA30 Offset: 0xCDB31 VA: 0xCDA30
	// RVA: 0x2B047F0 Offset: 0x2B048F1 VA: 0x2B047F0
	private void SetDistanceReferencePoint_InternalTransform(Transform transform) { }

	// RVA: 0x2B04840 Offset: 0x2B04941 VA: 0x2B04840
	public void SetDistanceReferencePoint(Transform transform) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCDA70 Offset: 0xCDB71 VA: 0xCDA70
	// RVA: 0x2B04890 Offset: 0x2B04991 VA: 0x2B04890
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

	[FreeFunctionAttribute] // RVA: 0xCDA80 Offset: 0xCDB81 VA: 0xCDA80
	// RVA: 0x2B043C0 Offset: 0x2B044C1 VA: 0x2B043C0
	private static IntPtr Init(object scripting) { }

	[FreeFunctionAttribute] // RVA: 0xCDAC0 Offset: 0xCDBC1 VA: 0xCDAC0
	// RVA: 0x2B044E0 Offset: 0x2B045E1 VA: 0x2B044E0
	private void FinalizerFailure() { }
}

