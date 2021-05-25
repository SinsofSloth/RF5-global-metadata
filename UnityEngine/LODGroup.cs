[NativeHeaderAttribute] // RVA: 0xC5750 Offset: 0xC5851 VA: 0xC5750
[StaticAccessorAttribute] // RVA: 0xC5750 Offset: 0xC5851 VA: 0xC5750
[NativeHeaderAttribute] // RVA: 0xC5750 Offset: 0xC5851 VA: 0xC5750
[NativeHeaderAttribute] // RVA: 0xC5750 Offset: 0xC5851 VA: 0xC5750
public class LODGroup : Component // TypeDefIndex: 2937
{
	// Properties
	public Vector3 localReferencePoint { get; set; }
	public float size { get; set; }
	public int lodCount { get; }
	public LODFadeMode fadeMode { get; set; }
	public bool animateCrossFading { get; set; }
	public bool enabled { get; set; }
	[StaticAccessorAttribute] // RVA: 0xDEB90 Offset: 0xDEC91 VA: 0xDEB90
	public static float crossFadeAnimationDuration { get; set; }

	// Methods

	// RVA: 0x1A2C620 Offset: 0x1A2C721 VA: 0x1A2C620
	public Vector3 get_localReferencePoint() { }

	// RVA: 0x1A2C6D0 Offset: 0x1A2C7D1 VA: 0x1A2C6D0
	public void set_localReferencePoint(Vector3 value) { }

	// RVA: 0x1A2C780 Offset: 0x1A2C881 VA: 0x1A2C780
	public float get_size() { }

	// RVA: 0x1A2C7D0 Offset: 0x1A2C8D1 VA: 0x1A2C7D0
	public void set_size(float value) { }

	[NativeMethodAttribute] // RVA: 0xD1920 Offset: 0xD1A21 VA: 0xD1920
	// RVA: 0x1A2C820 Offset: 0x1A2C921 VA: 0x1A2C820
	public int get_lodCount() { }

	// RVA: 0x1A2C870 Offset: 0x1A2C971 VA: 0x1A2C870
	public LODFadeMode get_fadeMode() { }

	// RVA: 0x1A2C8C0 Offset: 0x1A2C9C1 VA: 0x1A2C8C0
	public void set_fadeMode(LODFadeMode value) { }

	// RVA: 0x1A2C910 Offset: 0x1A2CA11 VA: 0x1A2C910
	public bool get_animateCrossFading() { }

	// RVA: 0x1A2C960 Offset: 0x1A2CA61 VA: 0x1A2C960
	public void set_animateCrossFading(bool value) { }

	// RVA: 0x1A2C9B0 Offset: 0x1A2CAB1 VA: 0x1A2C9B0
	public bool get_enabled() { }

	// RVA: 0x1A2CA00 Offset: 0x1A2CB01 VA: 0x1A2CA00
	public void set_enabled(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xD1960 Offset: 0xD1A61 VA: 0xD1960
	// RVA: 0x1A2CA50 Offset: 0x1A2CB51 VA: 0x1A2CA50
	public void RecalculateBounds() { }

	[FreeFunctionAttribute] // RVA: 0xD19B0 Offset: 0xD1AB1 VA: 0xD19B0
	// RVA: 0x1A2CAA0 Offset: 0x1A2CBA1 VA: 0x1A2CAA0
	public LOD[] GetLODs() { }

	[ObsoleteAttribute] // RVA: 0xD1A00 Offset: 0xD1B01 VA: 0xD1A00
	// RVA: 0x1A2CAF0 Offset: 0x1A2CBF1 VA: 0x1A2CAF0
	public void SetLODS(LOD[] lods) { }

	[FreeFunctionAttribute] // RVA: 0xD1A40 Offset: 0xD1B41 VA: 0xD1A40
	// RVA: 0x1A2CB40 Offset: 0x1A2CC41 VA: 0x1A2CB40
	public void SetLODs(LOD[] lods) { }

	[FreeFunctionAttribute] // RVA: 0xD1A90 Offset: 0xD1B91 VA: 0xD1A90
	// RVA: 0x1A2CB90 Offset: 0x1A2CC91 VA: 0x1A2CB90
	public void ForceLOD(int index) { }

	// RVA: 0x1A2CBE0 Offset: 0x1A2CCE1 VA: 0x1A2CBE0
	public static float get_crossFadeAnimationDuration() { }

	// RVA: 0x1A2CC20 Offset: 0x1A2CD21 VA: 0x1A2CC20
	public static void set_crossFadeAnimationDuration(float value) { }

	// RVA: 0x1A2CC70 Offset: 0x1A2CD71 VA: 0x1A2CC70
	public void .ctor() { }

	// RVA: 0x1A2C680 Offset: 0x1A2C781 VA: 0x1A2C680
	private void get_localReferencePoint_Injected(out Vector3 ret) { }

	// RVA: 0x1A2C730 Offset: 0x1A2C831 VA: 0x1A2C730
	private void set_localReferencePoint_Injected(ref Vector3 value) { }
}

