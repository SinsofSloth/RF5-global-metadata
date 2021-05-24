[NativeHeaderAttribute] // RVA: 0xC6C70 Offset: 0xC6D71 VA: 0xC6C70
internal sealed class NoAllocHelpers // TypeDefIndex: 3018
{
	// Methods

	// RVA: -1 Offset: -1
	public static void ResizeList<T>(List<T> list, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E7080 Offset: 0x23E7181 VA: 0x23E7080
	|-NoAllocHelpers.ResizeList<int>
	|
	|-RVA: 0x23E71A0 Offset: 0x23E72A1 VA: 0x23E71A0
	|-NoAllocHelpers.ResizeList<object>
	|
	|-RVA: 0x23E72C0 Offset: 0x23E73C1 VA: 0x23E72C0
	|-NoAllocHelpers.ResizeList<float>
	|
	|-RVA: 0x23E73E0 Offset: 0x23E74E1 VA: 0x23E73E0
	|-NoAllocHelpers.ResizeList<ushort>
	|
	|-RVA: 0x23E7500 Offset: 0x23E7601 VA: 0x23E7500
	|-NoAllocHelpers.ResizeList<BoneWeight>
	|
	|-RVA: 0x23E7620 Offset: 0x23E7721 VA: 0x23E7620
	|-NoAllocHelpers.ResizeList<Color32>
	|
	|-RVA: 0x23E7740 Offset: 0x23E7841 VA: 0x23E7740
	|-NoAllocHelpers.ResizeList<Color>
	|
	|-RVA: 0x23E7860 Offset: 0x23E7961 VA: 0x23E7860
	|-NoAllocHelpers.ResizeList<Matrix4x4>
	|
	|-RVA: 0x23E7980 Offset: 0x23E7A81 VA: 0x23E7980
	|-NoAllocHelpers.ResizeList<Rect>
	|
	|-RVA: 0x23E7AA0 Offset: 0x23E7BA1 VA: 0x23E7AA0
	|-NoAllocHelpers.ResizeList<SphericalHarmonicsL2>
	|
	|-RVA: 0x23E7BC0 Offset: 0x23E7CC1 VA: 0x23E7BC0
	|-NoAllocHelpers.ResizeList<Vector2>
	|
	|-RVA: 0x23E7CE0 Offset: 0x23E7DE1 VA: 0x23E7CE0
	|-NoAllocHelpers.ResizeList<Vector3>
	|
	|-RVA: 0x23E7E00 Offset: 0x23E7F01 VA: 0x23E7E00
	|-NoAllocHelpers.ResizeList<Vector4>
	*/

	// RVA: -1 Offset: -1
	public static void EnsureListElemCount<T>(List<T> list, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E69C0 Offset: 0x23E6AC1 VA: 0x23E69C0
	|-NoAllocHelpers.EnsureListElemCount<int>
	|
	|-RVA: 0x23E6A50 Offset: 0x23E6B51 VA: 0x23E6A50
	|-NoAllocHelpers.EnsureListElemCount<object>
	|-NoAllocHelpers.EnsureListElemCount<Material>
	|
	|-RVA: 0x23E6AE0 Offset: 0x23E6BE1 VA: 0x23E6AE0
	|-NoAllocHelpers.EnsureListElemCount<float>
	|
	|-RVA: 0x23E6B70 Offset: 0x23E6C71 VA: 0x23E6B70
	|-NoAllocHelpers.EnsureListElemCount<ushort>
	|
	|-RVA: 0x23E6C00 Offset: 0x23E6D01 VA: 0x23E6C00
	|-NoAllocHelpers.EnsureListElemCount<BoneWeight>
	|
	|-RVA: 0x23E6C90 Offset: 0x23E6D91 VA: 0x23E6C90
	|-NoAllocHelpers.EnsureListElemCount<Color32>
	|
	|-RVA: 0x23E6D20 Offset: 0x23E6E21 VA: 0x23E6D20
	|-NoAllocHelpers.EnsureListElemCount<Color>
	|
	|-RVA: 0x23E6DB0 Offset: 0x23E6EB1 VA: 0x23E6DB0
	|-NoAllocHelpers.EnsureListElemCount<Matrix4x4>
	|
	|-RVA: 0x23E6E40 Offset: 0x23E6F41 VA: 0x23E6E40
	|-NoAllocHelpers.EnsureListElemCount<Rect>
	|
	|-RVA: 0x23E6ED0 Offset: 0x23E6FD1 VA: 0x23E6ED0
	|-NoAllocHelpers.EnsureListElemCount<Vector2>
	|
	|-RVA: 0x23E6F60 Offset: 0x23E7061 VA: 0x23E6F60
	|-NoAllocHelpers.EnsureListElemCount<Vector3>
	|
	|-RVA: 0x23E6FF0 Offset: 0x23E70F1 VA: 0x23E6FF0
	|-NoAllocHelpers.EnsureListElemCount<Vector4>
	*/

	// RVA: 0x2B6A320 Offset: 0x2B6A421 VA: 0x2B6A320
	public static int SafeLength(Array values) { }

	// RVA: -1 Offset: -1
	public static int SafeLength<T>(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255E390 Offset: 0x255E491 VA: 0x255E390
	|-NoAllocHelpers.SafeLength<int>
	|
	|-RVA: 0x255E3B0 Offset: 0x255E4B1 VA: 0x255E3B0
	|-NoAllocHelpers.SafeLength<object>
	|
	|-RVA: 0x255E3D0 Offset: 0x255E4D1 VA: 0x255E3D0
	|-NoAllocHelpers.SafeLength<ushort>
	|
	|-RVA: 0x255E3F0 Offset: 0x255E4F1 VA: 0x255E3F0
	|-NoAllocHelpers.SafeLength<Color32>
	|
	|-RVA: 0x255E410 Offset: 0x255E511 VA: 0x255E410
	|-NoAllocHelpers.SafeLength<Color>
	|
	|-RVA: 0x255E430 Offset: 0x255E531 VA: 0x255E430
	|-NoAllocHelpers.SafeLength<Vector2>
	|
	|-RVA: 0x255E450 Offset: 0x255E551 VA: 0x255E450
	|-NoAllocHelpers.SafeLength<Vector3>
	|
	|-RVA: 0x255E470 Offset: 0x255E571 VA: 0x255E470
	|-NoAllocHelpers.SafeLength<Vector4>
	*/

	// RVA: -1 Offset: -1
	public static T[] ExtractArrayFromListT<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F7130 Offset: 0x34F7231 VA: 0x34F7130
	|-NoAllocHelpers.ExtractArrayFromListT<int>
	|
	|-RVA: 0x34F71A0 Offset: 0x34F72A1 VA: 0x34F71A0
	|-NoAllocHelpers.ExtractArrayFromListT<object>
	|-NoAllocHelpers.ExtractArrayFromListT<Material>
	|
	|-RVA: 0x34F7210 Offset: 0x34F7311 VA: 0x34F7210
	|-NoAllocHelpers.ExtractArrayFromListT<float>
	|
	|-RVA: 0x34F7280 Offset: 0x34F7381 VA: 0x34F7280
	|-NoAllocHelpers.ExtractArrayFromListT<ushort>
	|
	|-RVA: 0x34F72F0 Offset: 0x34F73F1 VA: 0x34F72F0
	|-NoAllocHelpers.ExtractArrayFromListT<BoneWeight>
	|
	|-RVA: 0x34F7360 Offset: 0x34F7461 VA: 0x34F7360
	|-NoAllocHelpers.ExtractArrayFromListT<Color>
	|
	|-RVA: 0x34F73D0 Offset: 0x34F74D1 VA: 0x34F73D0
	|-NoAllocHelpers.ExtractArrayFromListT<Matrix4x4>
	|
	|-RVA: 0x34F7440 Offset: 0x34F7541 VA: 0x34F7440
	|-NoAllocHelpers.ExtractArrayFromListT<Rect>
	|
	|-RVA: 0x34F74B0 Offset: 0x34F75B1 VA: 0x34F74B0
	|-NoAllocHelpers.ExtractArrayFromListT<SphericalHarmonicsL2>
	|
	|-RVA: 0x34F7520 Offset: 0x34F7621 VA: 0x34F7520
	|-NoAllocHelpers.ExtractArrayFromListT<Vector3>
	|
	|-RVA: 0x34F7590 Offset: 0x34F7691 VA: 0x34F7590
	|-NoAllocHelpers.ExtractArrayFromListT<Vector4>
	*/

	[FreeFunctionAttribute] // RVA: 0xD6DC0 Offset: 0xD6EC1 VA: 0xD6DC0
	// RVA: 0x2B6A330 Offset: 0x2B6A431 VA: 0x2B6A330
	internal static void Internal_ResizeList(object list, int size) { }

	[FreeFunctionAttribute] // RVA: 0xD6E00 Offset: 0xD6F01 VA: 0xD6E00
	// RVA: 0x2B6A380 Offset: 0x2B6A481 VA: 0x2B6A380
	public static Array ExtractArrayFromList(object list) { }
}

