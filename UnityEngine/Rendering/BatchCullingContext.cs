[NativeHeaderAttribute] // RVA: 0xC87C0 Offset: 0xC88C1 VA: 0xC87C0
[UsedByNativeCodeAttribute] // RVA: 0xC87C0 Offset: 0xC88C1 VA: 0xC87C0
public struct BatchCullingContext // TypeDefIndex: 3311
{
	// Fields
	public readonly NativeArray<Plane> cullingPlanes; // 0x0
	public NativeArray<BatchVisibility> batchVisibility; // 0x10
	public NativeArray<int> visibleIndices; // 0x20
	public readonly LODParameters lodParameters; // 0x30

	// Methods

	// RVA: 0x373E20 Offset: 0x373F21 VA: 0x373E20
	public void .ctor(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, LODParameters inLodParameters) { }
}

