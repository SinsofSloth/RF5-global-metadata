[ExtensionAttribute] // RVA: 0xAB540 Offset: 0xAB641 VA: 0xAB540
internal static class SpanHelpers // TypeDefIndex: 107
{
	// Methods

	// RVA: 0x2646FA0 Offset: 0x26470A1 VA: 0x2646FA0
	private static bool IsReferenceOrContainsReferencesCore(Type type) { }
}

[ExtensionAttribute] // RVA: 0x128B00 Offset: 0x128C01 VA: 0x128B00
internal static class SpanHelpers // TypeDefIndex: 4384
{
	// Methods

	// RVA: 0x1B6AB00 Offset: 0x1B6AC01 VA: 0x1B6AB00
	public static int IndexOf(ref byte searchSpace, byte value, int length) { }

	// RVA: 0x1B6B1F0 Offset: 0x1B6B2F1 VA: 0x1B6B1F0
	public static bool SequenceEqual(ref byte first, ref byte second, NUInt length) { }

	// RVA: 0x1B6B5F0 Offset: 0x1B6B6F1 VA: 0x1B6B5F0
	private static int LocateFirstFoundByte(Vector<byte> match) { }

	// RVA: 0x1B6B780 Offset: 0x1B6B881 VA: 0x1B6B780
	private static int LocateFirstFoundByte(ulong match) { }

	// RVA: 0x1B6B7B0 Offset: 0x1B6B8B1 VA: 0x1B6B7B0
	private static Vector<byte> GetVector(byte vectorByte) { }

	// RVA: 0x1B6B8B0 Offset: 0x1B6B9B1 VA: 0x1B6B8B0
	public static int IndexOf(ref char searchSpace, char value, int length) { }

	// RVA: 0x1B6BC60 Offset: 0x1B6BD61 VA: 0x1B6BC60
	private static int LocateFirstFoundChar(Vector<ushort> match) { }

	// RVA: 0x1B6BDF0 Offset: 0x1B6BEF1 VA: 0x1B6BDF0
	private static int LocateFirstFoundChar(ulong match) { }

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(ref T searchSpace, T value, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255CF00 Offset: 0x255D001 VA: 0x255CF00
	|-SpanHelpers.IndexOf<byte>
	|
	|-RVA: 0x255D330 Offset: 0x255D431 VA: 0x255D330
	|-SpanHelpers.IndexOf<object>
	*/

	// RVA: -1 Offset: -1
	public static bool SequenceEqual<T>(ref T first, ref T second, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CF230 Offset: 0x22CF331 VA: 0x22CF230
	|-SpanHelpers.SequenceEqual<byte>
	|
	|-RVA: 0x22CF820 Offset: 0x22CF921 VA: 0x22CF820
	|-SpanHelpers.SequenceEqual<object>
	*/

	// RVA: -1 Offset: -1
	public static void CopyTo<T>(ref T dst, int dstLength, ref T src, int srcLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23DA190 Offset: 0x23DA291 VA: 0x23DA190
	|-SpanHelpers.CopyTo<byte>
	|
	|-RVA: 0x23DA770 Offset: 0x23DA871 VA: 0x23DA770
	|-SpanHelpers.CopyTo<char>
	|
	|-RVA: 0x23DAD50 Offset: 0x23DAE51 VA: 0x23DAD50
	|-SpanHelpers.CopyTo<double>
	|
	|-RVA: 0x23DB330 Offset: 0x23DB431 VA: 0x23DB330
	|-SpanHelpers.CopyTo<int>
	|
	|-RVA: 0x23DB910 Offset: 0x23DBA11 VA: 0x23DB910
	|-SpanHelpers.CopyTo<long>
	|
	|-RVA: 0x23DBEF0 Offset: 0x23DBFF1 VA: 0x23DBEF0
	|-SpanHelpers.CopyTo<object>
	|
	|-RVA: 0x23DC530 Offset: 0x23DC631 VA: 0x23DC530
	|-SpanHelpers.CopyTo<float>
	|
	|-RVA: 0x23DCB10 Offset: 0x23DCC11 VA: 0x23DCB10
	|-SpanHelpers.CopyTo<ushort>
	|
	|-RVA: 0x23DD0F0 Offset: 0x23DD1F1 VA: 0x23DD0F0
	|-SpanHelpers.CopyTo<uint>
	|
	|-RVA: 0x23DD6D0 Offset: 0x23DD7D1 VA: 0x23DD6D0
	|-SpanHelpers.CopyTo<Bounds>
	|
	|-RVA: 0x23DDD10 Offset: 0x23DDE11 VA: 0x23DDD10
	|-SpanHelpers.CopyTo<Color>
	|
	|-RVA: 0x23DE2F0 Offset: 0x23DE3F1 VA: 0x23DE2F0
	|-SpanHelpers.CopyTo<Quaternion>
	|
	|-RVA: 0x23DE8D0 Offset: 0x23DE9D1 VA: 0x23DE8D0
	|-SpanHelpers.CopyTo<Rect>
	|
	|-RVA: 0x23DEEB0 Offset: 0x23DEFB1 VA: 0x23DEEB0
	|-SpanHelpers.CopyTo<Vector2>
	|
	|-RVA: 0x23DF490 Offset: 0x23DF591 VA: 0x23DF490
	|-SpanHelpers.CopyTo<Vector3>
	|
	|-RVA: 0x23DFAD0 Offset: 0x23DFBD1 VA: 0x23DFAD0
	|-SpanHelpers.CopyTo<Vector4>
	*/

	[ExtensionAttribute] // RVA: 0x128FC0 Offset: 0x1290C1 VA: 0x128FC0
	// RVA: -1 Offset: -1
	public static IntPtr Add<T>(IntPtr start, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255E940 Offset: 0x255EA41 VA: 0x255E940
	|-SpanHelpers.Add<byte>
	|
	|-RVA: 0x255E990 Offset: 0x255EA91 VA: 0x255E990
	|-SpanHelpers.Add<char>
	|
	|-RVA: 0x255E9E0 Offset: 0x255EAE1 VA: 0x255E9E0
	|-SpanHelpers.Add<double>
	|
	|-RVA: 0x255EA30 Offset: 0x255EB31 VA: 0x255EA30
	|-SpanHelpers.Add<int>
	|
	|-RVA: 0x255EA80 Offset: 0x255EB81 VA: 0x255EA80
	|-SpanHelpers.Add<long>
	|
	|-RVA: 0x255EAD0 Offset: 0x255EBD1 VA: 0x255EAD0
	|-SpanHelpers.Add<object>
	|
	|-RVA: 0x255EB20 Offset: 0x255EC21 VA: 0x255EB20
	|-SpanHelpers.Add<float>
	|
	|-RVA: 0x255EB70 Offset: 0x255EC71 VA: 0x255EB70
	|-SpanHelpers.Add<ushort>
	|
	|-RVA: 0x255EBC0 Offset: 0x255ECC1 VA: 0x255EBC0
	|-SpanHelpers.Add<uint>
	|
	|-RVA: 0x255EC10 Offset: 0x255ED11 VA: 0x255EC10
	|-SpanHelpers.Add<Bounds>
	|
	|-RVA: 0x255EC60 Offset: 0x255ED61 VA: 0x255EC60
	|-SpanHelpers.Add<Color>
	|
	|-RVA: 0x255ECB0 Offset: 0x255EDB1 VA: 0x255ECB0
	|-SpanHelpers.Add<Quaternion>
	|
	|-RVA: 0x255ED00 Offset: 0x255EE01 VA: 0x255ED00
	|-SpanHelpers.Add<Rect>
	|
	|-RVA: 0x255ED50 Offset: 0x255EE51 VA: 0x255ED50
	|-SpanHelpers.Add<Vector2>
	|
	|-RVA: 0x255EDA0 Offset: 0x255EEA1 VA: 0x255EDA0
	|-SpanHelpers.Add<Vector3>
	|
	|-RVA: 0x255EDF0 Offset: 0x255EEF1 VA: 0x255EDF0
	|-SpanHelpers.Add<Vector4>
	*/

	// RVA: -1 Offset: -1
	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22CE730 Offset: 0x22CE831 VA: 0x22CE730
	|-SpanHelpers.IsReferenceOrContainsReferences<byte>
	|
	|-RVA: 0x22CE7E0 Offset: 0x22CE8E1 VA: 0x22CE7E0
	|-SpanHelpers.IsReferenceOrContainsReferences<char>
	|
	|-RVA: 0x22CE890 Offset: 0x22CE991 VA: 0x22CE890
	|-SpanHelpers.IsReferenceOrContainsReferences<double>
	|
	|-RVA: 0x22CE940 Offset: 0x22CEA41 VA: 0x22CE940
	|-SpanHelpers.IsReferenceOrContainsReferences<int>
	|
	|-RVA: 0x22CE9F0 Offset: 0x22CEAF1 VA: 0x22CE9F0
	|-SpanHelpers.IsReferenceOrContainsReferences<long>
	|
	|-RVA: 0x22CEAA0 Offset: 0x22CEBA1 VA: 0x22CEAA0
	|-SpanHelpers.IsReferenceOrContainsReferences<object>
	|
	|-RVA: 0x22CEB50 Offset: 0x22CEC51 VA: 0x22CEB50
	|-SpanHelpers.IsReferenceOrContainsReferences<float>
	|
	|-RVA: 0x22CEC00 Offset: 0x22CED01 VA: 0x22CEC00
	|-SpanHelpers.IsReferenceOrContainsReferences<ushort>
	|
	|-RVA: 0x22CECB0 Offset: 0x22CEDB1 VA: 0x22CECB0
	|-SpanHelpers.IsReferenceOrContainsReferences<uint>
	|
	|-RVA: 0x22CED60 Offset: 0x22CEE61 VA: 0x22CED60
	|-SpanHelpers.IsReferenceOrContainsReferences<Bounds>
	|
	|-RVA: 0x22CEE10 Offset: 0x22CEF11 VA: 0x22CEE10
	|-SpanHelpers.IsReferenceOrContainsReferences<Color>
	|
	|-RVA: 0x22CEEC0 Offset: 0x22CEFC1 VA: 0x22CEEC0
	|-SpanHelpers.IsReferenceOrContainsReferences<Quaternion>
	|
	|-RVA: 0x22CEF70 Offset: 0x22CF071 VA: 0x22CEF70
	|-SpanHelpers.IsReferenceOrContainsReferences<Rect>
	|
	|-RVA: 0x22CF020 Offset: 0x22CF121 VA: 0x22CF020
	|-SpanHelpers.IsReferenceOrContainsReferences<Vector2>
	|
	|-RVA: 0x22CF0D0 Offset: 0x22CF1D1 VA: 0x22CF0D0
	|-SpanHelpers.IsReferenceOrContainsReferences<Vector3>
	|
	|-RVA: 0x22CF180 Offset: 0x22CF281 VA: 0x22CF180
	|-SpanHelpers.IsReferenceOrContainsReferences<Vector4>
	*/

	// RVA: 0x1B6BE10 Offset: 0x1B6BF11 VA: 0x1B6BE10
	private static bool IsReferenceOrContainsReferencesCore(Type type) { }

	// RVA: 0x1B6C200 Offset: 0x1B6C301 VA: 0x1B6C200
	public static void ClearLessThanPointerSized(byte* ptr, UIntPtr byteLength) { }

	// RVA: 0x1B6C2D0 Offset: 0x1B6C3D1 VA: 0x1B6C2D0
	public static void ClearLessThanPointerSized(ref byte b, UIntPtr byteLength) { }

	// RVA: 0x1B6C3B0 Offset: 0x1B6C4B1 VA: 0x1B6C3B0
	public static void ClearPointerSizedWithoutReferences(ref byte b, UIntPtr byteLength) { }

	// RVA: 0x1B6C6E0 Offset: 0x1B6C7E1 VA: 0x1B6C6E0
	public static void ClearPointerSizedWithReferences(ref IntPtr ip, UIntPtr pointerSizeLength) { }

	[ExtensionAttribute] // RVA: 0x128FD0 Offset: 0x1290D1 VA: 0x128FD0
	// RVA: 0x1B6CA40 Offset: 0x1B6CB41 VA: 0x1B6CA40
	private static bool LessThanEqual(IntPtr index, UIntPtr length) { }
}

