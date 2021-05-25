public static class Marshal // TypeDefIndex: 1323
{
	// Fields
	public static readonly int SystemMaxDBCSCharSize; // 0x0
	public static readonly int SystemDefaultCharSize; // 0x4

	// Methods

	// RVA: 0x18043C0 Offset: 0x18044C1 VA: 0x18043C0
	public static IntPtr AllocCoTaskMem(int cb) { }

	[ReliabilityContractAttribute] // RVA: 0xB9750 Offset: 0xB9851 VA: 0xB9750
	// RVA: 0x18043D0 Offset: 0x18044D1 VA: 0x18043D0
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContractAttribute] // RVA: 0xB9770 Offset: 0xB9871 VA: 0xB9770
	// RVA: 0x18043E0 Offset: 0x18044E1 VA: 0x18043E0
	public static IntPtr AllocHGlobal(int cb) { }

	// RVA: 0x1804470 Offset: 0x1804571 VA: 0x1804470
	internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x1804480 Offset: 0x1804581 VA: 0x1804480
	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	// RVA: 0x1804490 Offset: 0x1804591 VA: 0x1804490
	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x1804520 Offset: 0x1804621 VA: 0x1804520
	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length) { }

	// RVA: 0x18045B0 Offset: 0x18046B1 VA: 0x18045B0
	public static void Copy(IntPtr source, char[] destination, int startIndex, int length) { }

	// RVA: 0x1804640 Offset: 0x1804741 VA: 0x1804640
	public static void FreeBSTR(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0xB9790 Offset: 0xB9891 VA: 0xB9790
	// RVA: 0x1804650 Offset: 0x1804751 VA: 0x1804650
	public static void FreeHGlobal(IntPtr hglobal) { }

	// RVA: 0x1804660 Offset: 0x1804761 VA: 0x1804660
	private static void ClearUnicode(IntPtr ptr) { }

	// RVA: 0x1804820 Offset: 0x1804921 VA: 0x1804820
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

	// RVA: 0x1804890 Offset: 0x1804991 VA: 0x1804890
	public static int GetHRForException(Exception e) { }

	[ReliabilityContractAttribute] // RVA: 0xB97B0 Offset: 0xB98B1 VA: 0xB97B0
	// RVA: 0x18048A0 Offset: 0x18049A1 VA: 0x18048A0
	public static int GetLastWin32Error() { }

	// RVA: 0x18048B0 Offset: 0x18049B1 VA: 0x18048B0
	public static string PtrToStringAnsi(IntPtr ptr) { }

	// RVA: 0x18048C0 Offset: 0x18049C1 VA: 0x18048C0
	public static string PtrToStringUni(IntPtr ptr) { }

	[ComVisibleAttribute] // RVA: 0xB97D0 Offset: 0xB98D1 VA: 0xB97D0
	// RVA: 0x18048D0 Offset: 0x18049D1 VA: 0x18048D0
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	// RVA: -1 Offset: -1
	public static T PtrToStructure<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2264200 Offset: 0x2264301 VA: 0x2264200
	|-Marshal.PtrToStructure<UnityTls.unitytls_interface_struct>
	|-Marshal.PtrToStructure<object>
	|
	|-RVA: 0x22640D0 Offset: 0x22641D1 VA: 0x22640D0
	|-Marshal.PtrToStructure<Win32_FIXED_INFO>
	*/

	// RVA: 0x18047D0 Offset: 0x18048D1 VA: 0x18047D0
	public static short ReadInt16(IntPtr ptr, int ofs) { }

	[ReliabilityContractAttribute] // RVA: 0xB97F0 Offset: 0xB98F1 VA: 0xB97F0
	// RVA: 0x18048E0 Offset: 0x18049E1 VA: 0x18048E0
	public static int ReadInt32(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0xB9810 Offset: 0xB9911 VA: 0xB9810
	// RVA: 0x1804930 Offset: 0x1804A31 VA: 0x1804930
	public static long ReadInt64(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0xB9830 Offset: 0xB9931 VA: 0xB9830
	// RVA: 0x18049A0 Offset: 0x1804AA1 VA: 0x18049A0
	public static IntPtr ReadIntPtr(IntPtr ptr) { }

	[ReliabilityContractAttribute] // RVA: 0xB9850 Offset: 0xB9951 VA: 0xB9850
	// RVA: 0x1804AD0 Offset: 0x1804BD1 VA: 0x1804AD0
	private static int ReleaseInternal(IntPtr pUnk) { }

	[ReliabilityContractAttribute] // RVA: 0xB9870 Offset: 0xB9971 VA: 0xB9870
	// RVA: 0x1804AE0 Offset: 0x1804BE1 VA: 0x1804AE0
	public static int Release(IntPtr pUnk) { }

	[ComVisibleAttribute] // RVA: 0xB9890 Offset: 0xB9991 VA: 0xB9890
	// RVA: 0x1804BB0 Offset: 0x1804CB1 VA: 0x1804BB0
	public static int SizeOf(object structure) { }

	// RVA: 0x1804C40 Offset: 0x1804D41 VA: 0x1804C40
	public static int SizeOf(Type t) { }

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255C780 Offset: 0x255C881 VA: 0x255C780
	|-Marshal.SizeOf<byte>
	|
	|-RVA: 0x255C820 Offset: 0x255C921 VA: 0x255C820
	|-Marshal.SizeOf<double>
	|
	|-RVA: 0x255C8C0 Offset: 0x255C9C1 VA: 0x255C8C0
	|-Marshal.SizeOf<int>
	|
	|-RVA: 0x255C960 Offset: 0x255CA61 VA: 0x255C960
	|-Marshal.SizeOf<object>
	|
	|-RVA: 0x255CA00 Offset: 0x255CB01 VA: 0x255CA00
	|-Marshal.SizeOf<float>
	|
	|-RVA: 0x255CAA0 Offset: 0x255CBA1 VA: 0x255CAA0
	|-Marshal.SizeOf<Bounds>
	|
	|-RVA: 0x255CB40 Offset: 0x255CC41 VA: 0x255CB40
	|-Marshal.SizeOf<Color>
	|
	|-RVA: 0x255CBE0 Offset: 0x255CCE1 VA: 0x255CBE0
	|-Marshal.SizeOf<Quaternion>
	|
	|-RVA: 0x255CC80 Offset: 0x255CD81 VA: 0x255CC80
	|-Marshal.SizeOf<Rect>
	|
	|-RVA: 0x255CD20 Offset: 0x255CE21 VA: 0x255CD20
	|-Marshal.SizeOf<Vector2>
	|
	|-RVA: 0x255CDC0 Offset: 0x255CEC1 VA: 0x255CDC0
	|-Marshal.SizeOf<Vector3>
	|
	|-RVA: 0x255CE60 Offset: 0x255CF61 VA: 0x255CE60
	|-Marshal.SizeOf<Vector4>
	*/

	// RVA: 0x1804C50 Offset: 0x1804D51 VA: 0x1804C50
	public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s) { }

	// RVA: 0x1804F60 Offset: 0x1805061 VA: 0x1804F60
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ReliabilityContractAttribute] // RVA: 0xB98B0 Offset: 0xB99B1 VA: 0xB98B0
	[ComVisibleAttribute] // RVA: 0xB98B0 Offset: 0xB99B1 VA: 0xB98B0
	// RVA: 0x1805020 Offset: 0x1805121 VA: 0x1805020
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	// RVA: -1 Offset: -1
	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23DA110 Offset: 0x23DA211 VA: 0x23DA110
	|-Marshal.StructureToPtr<object>
	*/

	// RVA: 0x1805030 Offset: 0x1805131 VA: 0x1805030
	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	// RVA: -1 Offset: -1
	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255E840 Offset: 0x255E941 VA: 0x255E840
	|-Marshal.UnsafeAddrOfPinnedArrayElement<byte>
	|
	|-RVA: 0x255E8C0 Offset: 0x255E9C1 VA: 0x255E8C0
	|-Marshal.UnsafeAddrOfPinnedArrayElement<object>
	*/

	// RVA: 0x1804770 Offset: 0x1804871 VA: 0x1804770
	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	// RVA: 0x1805040 Offset: 0x1805141 VA: 0x1805040
	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255E770 Offset: 0x255E871 VA: 0x255E770
	|-Marshal.GetFunctionPointerForDelegate<object>
	|-Marshal.GetFunctionPointerForDelegate<OSSpecificSynchronizationContext.InvocationEntryDelegate>
	|-Marshal.GetFunctionPointerForDelegate<ConcaveColliderInterface.LogDelegate>
	*/

	// RVA: 0x1805050 Offset: 0x1805151 VA: 0x1805050
	private static void .cctor() { }
}

