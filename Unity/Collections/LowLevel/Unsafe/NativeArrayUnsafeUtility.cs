[ExtensionAttribute] // RVA: 0xC3F30 Offset: 0xC4031 VA: 0xC3F30
public static class NativeArrayUnsafeUtility // TypeDefIndex: 2818
{
	// Methods

	// RVA: -1 Offset: -1
	public static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F8550 Offset: 0x34F8651 VA: 0x34F8550
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>
	|
	|-RVA: 0x34F8560 Offset: 0x34F8661 VA: 0x34F8560
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>
	|
	|-RVA: 0x34F8570 Offset: 0x34F8671 VA: 0x34F8570
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BoneWeight1>
	|
	|-RVA: 0x34F8580 Offset: 0x34F8681 VA: 0x34F8580
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<LightDataGI>
	|
	|-RVA: 0x34F8590 Offset: 0x34F8691 VA: 0x34F8590
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Plane>
	|
	|-RVA: 0x34F85A0 Offset: 0x34F86A1 VA: 0x34F85A0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BatchVisibility>
	*/

	[ExtensionAttribute] // RVA: 0xCC300 Offset: 0xCC401 VA: 0xCC300
	// RVA: -1 Offset: -1
	public static void* GetUnsafeReadOnlyPtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BDE50 Offset: 0x23BDF51 VA: 0x23BDE50
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<byte>
	|
	|-RVA: 0x23BDE60 Offset: 0x23BDF61 VA: 0x23BDE60
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<BoneWeight1>
	|
	|-RVA: 0x23BDE70 Offset: 0x23BDF71 VA: 0x23BDE70
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ParticleSystem.Particle>
	*/
}

