internal static class RuntimeMarshal // TypeDefIndex: 10
{
	// Methods

	// RVA: 0x19403E0 Offset: 0x19404E1 VA: 0x19403E0
	internal static string PtrToUtf8String(IntPtr ptr) { }

	// RVA: 0x19404B0 Offset: 0x19405B1 VA: 0x19404B0
	internal static SafeStringMarshal MarshalString(string str) { }

	// RVA: 0x1940580 Offset: 0x1940681 VA: 0x1940580
	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	// RVA: 0x1940610 Offset: 0x1940711 VA: 0x1940610
	internal static byte[] DecodeBlobArray(IntPtr ptr) { }

	// RVA: 0x1940720 Offset: 0x1940821 VA: 0x1940720
	internal static int AsciHexDigitValue(int c) { }

	// RVA: 0x1940750 Offset: 0x1940851 VA: 0x1940750
	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }
}

