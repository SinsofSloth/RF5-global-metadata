[NativeHeaderAttribute] // RVA: 0xC3F40 Offset: 0xC4041 VA: 0xC3F40
[StaticAccessorAttribute] // RVA: 0xC3F40 Offset: 0xC4041 VA: 0xC3F40
public static class UnsafeUtility // TypeDefIndex: 2819
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool IsBlittable<T>() { }

	[ThreadSafeAttribute] // RVA: 0xCC310 Offset: 0xCC411 VA: 0xCC310
	// RVA: 0x2AF3CE0 Offset: 0x2AF3DE1 VA: 0x2AF3CE0
	public static void* Malloc(long size, int alignment, Allocator allocator) { }

	[ThreadSafeAttribute] // RVA: 0xCC320 Offset: 0xCC421 VA: 0xCC320
	// RVA: 0x2AF3D40 Offset: 0x2AF3E41 VA: 0x2AF3D40
	public static void Free(void* memory, Allocator allocator) { }

	[ThreadSafeAttribute] // RVA: 0xCC330 Offset: 0xCC431 VA: 0xCC330
	// RVA: 0x2AF3D90 Offset: 0x2AF3E91 VA: 0x2AF3D90
	public static void MemSet(void* destination, byte value, long size) { }

	// RVA: 0x2AF3DF0 Offset: 0x2AF3EF1 VA: 0x2AF3DF0
	public static void MemClear(void* destination, long size) { }

	[ThreadSafeAttribute] // RVA: 0xCC340 Offset: 0xCC441 VA: 0xCC340
	// RVA: 0x2AF3E50 Offset: 0x2AF3F51 VA: 0x2AF3E50
	public static int SizeOf(Type type) { }

	[ThreadSafeAttribute] // RVA: 0xCC350 Offset: 0xCC451 VA: 0xCC350
	// RVA: 0x2AF3EA0 Offset: 0x2AF3FA1 VA: 0x2AF3EA0
	public static bool IsBlittable(Type type) { }

	// RVA: 0x2AF3EF0 Offset: 0x2AF3FF1 VA: 0x2AF3EF0
	private static bool IsBlittableValueType(Type t) { }

	// RVA: 0x2AF3F70 Offset: 0x2AF4071 VA: 0x2AF3F70
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	// RVA: 0x2AF4190 Offset: 0x2AF4291 VA: 0x2AF4190
	internal static bool IsArrayBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	internal static bool IsGenericListBlittable<T>() { }

	// RVA: 0x2AF4230 Offset: 0x2AF4331 VA: 0x2AF4230
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	internal static string GetReasonForGenericListNonBlittable<T>() { }

	// RVA: -1 Offset: -1
	public static int AlignOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255DE10 Offset: 0x255DF11 VA: 0x255DE10
	|-UnsafeUtility.AlignOf<byte>
	|
	|-RVA: 0x255DE60 Offset: 0x255DF61 VA: 0x255DE60
	|-UnsafeUtility.AlignOf<int>
	|
	|-RVA: 0x255DEB0 Offset: 0x255DFB1 VA: 0x255DEB0
	|-UnsafeUtility.AlignOf<float>
	|
	|-RVA: 0x255DF00 Offset: 0x255E001 VA: 0x255DF00
	|-UnsafeUtility.AlignOf<PropertySceneHandle>
	|
	|-RVA: 0x255DF50 Offset: 0x255E051 VA: 0x255DF50
	|-UnsafeUtility.AlignOf<TransformStreamHandle>
	|
	|-RVA: 0x255DFA0 Offset: 0x255E0A1 VA: 0x255DFA0
	|-UnsafeUtility.AlignOf<BoneWeight1>
	|
	|-RVA: 0x255DFF0 Offset: 0x255E0F1 VA: 0x255DFF0
	|-UnsafeUtility.AlignOf<LightDataGI>
	|
	|-RVA: 0x255E040 Offset: 0x255E141 VA: 0x255E040
	|-UnsafeUtility.AlignOf<ParticleSystem.Particle>
	|
	|-RVA: 0x255E090 Offset: 0x255E191 VA: 0x255E090
	|-UnsafeUtility.AlignOf<Plane>
	|
	|-RVA: 0x255E0E0 Offset: 0x255E1E1 VA: 0x255E0E0
	|-UnsafeUtility.AlignOf<Quaternion>
	|
	|-RVA: 0x255E130 Offset: 0x255E231 VA: 0x255E130
	|-UnsafeUtility.AlignOf<BatchVisibility>
	|
	|-RVA: 0x255E180 Offset: 0x255E281 VA: 0x255E180
	|-UnsafeUtility.AlignOf<Vector3>
	*/

	// RVA: -1 Offset: -1
	public static void CopyPtrToStructure<T>(void* ptr, out T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E2590 Offset: 0x23E2691 VA: 0x23E2590
	|-UnsafeUtility.CopyPtrToStructure<AnimationStream>
	*/

	// RVA: -1 Offset: -1
	private static void InternalCopyPtrToStructure<T>(void* ptr, out T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E25C0 Offset: 0x23E26C1 VA: 0x23E25C0
	|-UnsafeUtility.InternalCopyPtrToStructure<AnimationStream>
	*/

	// RVA: -1 Offset: -1
	public static void CopyStructureToPtr<T>(ref T input, void* ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E25A0 Offset: 0x23E26A1 VA: 0x23E25A0
	|-UnsafeUtility.CopyStructureToPtr<AimIKJob>
	|
	|-RVA: 0x23E25B0 Offset: 0x23E26B1 VA: 0x23E25B0
	|-UnsafeUtility.CopyStructureToPtr<CCDIKJob>
	*/

	// RVA: -1 Offset: -1
	private static void InternalCopyStructureToPtr<T>(ref T input, void* ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E25F0 Offset: 0x23E26F1 VA: 0x23E25F0
	|-UnsafeUtility.InternalCopyStructureToPtr<AimIKJob>
	|
	|-RVA: 0x23E2620 Offset: 0x23E2721 VA: 0x23E2620
	|-UnsafeUtility.InternalCopyStructureToPtr<CCDIKJob>
	*/

	// RVA: -1 Offset: -1
	public static T ReadArrayElement<T>(void* source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2265670 Offset: 0x2265771 VA: 0x2265670
	|-UnsafeUtility.ReadArrayElement<byte>
	|
	|-RVA: 0x2265680 Offset: 0x2265781 VA: 0x2265680
	|-UnsafeUtility.ReadArrayElement<int>
	|
	|-RVA: 0x2265690 Offset: 0x2265791 VA: 0x2265690
	|-UnsafeUtility.ReadArrayElement<object>
	|
	|-RVA: 0x22656A0 Offset: 0x22657A1 VA: 0x22656A0
	|-UnsafeUtility.ReadArrayElement<float>
	|
	|-RVA: 0x22656B0 Offset: 0x22657B1 VA: 0x22656B0
	|-UnsafeUtility.ReadArrayElement<PropertySceneHandle>
	|
	|-RVA: 0x22656C0 Offset: 0x22657C1 VA: 0x22656C0
	|-UnsafeUtility.ReadArrayElement<TransformStreamHandle>
	|
	|-RVA: 0x22656E0 Offset: 0x22657E1 VA: 0x22656E0
	|-UnsafeUtility.ReadArrayElement<BoneWeight1>
	|
	|-RVA: 0x22656F0 Offset: 0x22657F1 VA: 0x22656F0
	|-UnsafeUtility.ReadArrayElement<LightDataGI>
	|
	|-RVA: 0x2265710 Offset: 0x2265811 VA: 0x2265710
	|-UnsafeUtility.ReadArrayElement<ParticleSystem.Particle>
	|
	|-RVA: 0x2265730 Offset: 0x2265831 VA: 0x2265730
	|-UnsafeUtility.ReadArrayElement<Plane>
	|
	|-RVA: 0x2265740 Offset: 0x2265841 VA: 0x2265740
	|-UnsafeUtility.ReadArrayElement<Quaternion>
	|
	|-RVA: 0x2265750 Offset: 0x2265851 VA: 0x2265750
	|-UnsafeUtility.ReadArrayElement<BatchVisibility>
	|
	|-RVA: 0x2265770 Offset: 0x2265871 VA: 0x2265770
	|-UnsafeUtility.ReadArrayElement<Vector3>
	*/

	// RVA: -1 Offset: -1
	public static void WriteArrayElement<T>(void* destination, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E2670 Offset: 0x23E2771 VA: 0x23E2670
	|-UnsafeUtility.WriteArrayElement<byte>
	|
	|-RVA: 0x23E2680 Offset: 0x23E2781 VA: 0x23E2680
	|-UnsafeUtility.WriteArrayElement<int>
	|
	|-RVA: 0x23E2690 Offset: 0x23E2791 VA: 0x23E2690
	|-UnsafeUtility.WriteArrayElement<object>
	|
	|-RVA: 0x23E26A0 Offset: 0x23E27A1 VA: 0x23E26A0
	|-UnsafeUtility.WriteArrayElement<float>
	|
	|-RVA: 0x23E26B0 Offset: 0x23E27B1 VA: 0x23E26B0
	|-UnsafeUtility.WriteArrayElement<PropertySceneHandle>
	|
	|-RVA: 0x23E26C0 Offset: 0x23E27C1 VA: 0x23E26C0
	|-UnsafeUtility.WriteArrayElement<TransformStreamHandle>
	|
	|-RVA: 0x23E26E0 Offset: 0x23E27E1 VA: 0x23E26E0
	|-UnsafeUtility.WriteArrayElement<BoneWeight1>
	|
	|-RVA: 0x23E26F0 Offset: 0x23E27F1 VA: 0x23E26F0
	|-UnsafeUtility.WriteArrayElement<LightDataGI>
	|
	|-RVA: 0x23E2720 Offset: 0x23E2821 VA: 0x23E2720
	|-UnsafeUtility.WriteArrayElement<ParticleSystem.Particle>
	|
	|-RVA: 0x23E2750 Offset: 0x23E2851 VA: 0x23E2750
	|-UnsafeUtility.WriteArrayElement<Plane>
	|
	|-RVA: 0x23E2770 Offset: 0x23E2871 VA: 0x23E2770
	|-UnsafeUtility.WriteArrayElement<Quaternion>
	|
	|-RVA: 0x23E2790 Offset: 0x23E2891 VA: 0x23E2790
	|-UnsafeUtility.WriteArrayElement<BatchVisibility>
	|
	|-RVA: 0x23E27B0 Offset: 0x23E28B1 VA: 0x23E27B0
	|-UnsafeUtility.WriteArrayElement<Vector3>
	*/

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255E210 Offset: 0x255E311 VA: 0x255E210
	|-UnsafeUtility.SizeOf<byte>
	|
	|-RVA: 0x255E220 Offset: 0x255E321 VA: 0x255E220
	|-UnsafeUtility.SizeOf<int>
	|
	|-RVA: 0x255E230 Offset: 0x255E331 VA: 0x255E230
	|-UnsafeUtility.SizeOf<float>
	|
	|-RVA: 0x255E240 Offset: 0x255E341 VA: 0x255E240
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<byte>>
	|
	|-RVA: 0x255E250 Offset: 0x255E351 VA: 0x255E250
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int>>
	|
	|-RVA: 0x255E260 Offset: 0x255E361 VA: 0x255E260
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float>>
	|
	|-RVA: 0x255E270 Offset: 0x255E371 VA: 0x255E270
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<PropertySceneHandle>>
	|
	|-RVA: 0x255E280 Offset: 0x255E381 VA: 0x255E280
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<TransformStreamHandle>>
	|
	|-RVA: 0x255E290 Offset: 0x255E391 VA: 0x255E290
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BoneWeight1>>
	|
	|-RVA: 0x255E2A0 Offset: 0x255E3A1 VA: 0x255E2A0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightDataGI>>
	|
	|-RVA: 0x255E2B0 Offset: 0x255E3B1 VA: 0x255E2B0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ParticleSystem.Particle>>
	|
	|-RVA: 0x255E2C0 Offset: 0x255E3C1 VA: 0x255E2C0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Plane>>
	|
	|-RVA: 0x255E2D0 Offset: 0x255E3D1 VA: 0x255E2D0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Quaternion>>
	|
	|-RVA: 0x255E2E0 Offset: 0x255E3E1 VA: 0x255E2E0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BatchVisibility>>
	|
	|-RVA: 0x255E2F0 Offset: 0x255E3F1 VA: 0x255E2F0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector3>>
	|
	|-RVA: 0x255E300 Offset: 0x255E401 VA: 0x255E300
	|-UnsafeUtility.SizeOf<PropertySceneHandle>
	|
	|-RVA: 0x255E310 Offset: 0x255E411 VA: 0x255E310
	|-UnsafeUtility.SizeOf<TransformStreamHandle>
	|
	|-RVA: 0x255E320 Offset: 0x255E421 VA: 0x255E320
	|-UnsafeUtility.SizeOf<BoneWeight1>
	|
	|-RVA: 0x255E330 Offset: 0x255E431 VA: 0x255E330
	|-UnsafeUtility.SizeOf<LightDataGI>
	|
	|-RVA: 0x255E340 Offset: 0x255E441 VA: 0x255E340
	|-UnsafeUtility.SizeOf<ParticleSystem.Particle>
	|
	|-RVA: 0x255E350 Offset: 0x255E451 VA: 0x255E350
	|-UnsafeUtility.SizeOf<Plane>
	|
	|-RVA: 0x255E360 Offset: 0x255E461 VA: 0x255E360
	|-UnsafeUtility.SizeOf<Quaternion>
	|
	|-RVA: 0x255E370 Offset: 0x255E471 VA: 0x255E370
	|-UnsafeUtility.SizeOf<BatchVisibility>
	|
	|-RVA: 0x255E380 Offset: 0x255E481 VA: 0x255E380
	|-UnsafeUtility.SizeOf<Vector3>
	*/

	// RVA: -1 Offset: -1
	public static int EnumToInt<T>(T enumValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255E1D0 Offset: 0x255E2D1 VA: 0x255E1D0
	|-UnsafeUtility.EnumToInt<Int32Enum>
	*/

	// RVA: -1 Offset: -1
	private static void InternalEnumToInt<T>(ref T enumValue, ref int intValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E2650 Offset: 0x23E2751 VA: 0x23E2650
	|-UnsafeUtility.InternalEnumToInt<Int32Enum>
	|
	|-RVA: 0x23E2660 Offset: 0x23E2761 VA: 0x23E2660
	|-UnsafeUtility.InternalEnumToInt<object>
	*/
}

