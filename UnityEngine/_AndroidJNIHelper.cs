[UsedByNativeCodeAttribute] // RVA: 0x10B5A0 Offset: 0x10B6A1 VA: 0x10B5A0
internal sealed class _AndroidJNIHelper // TypeDefIndex: 3798
{
	// Methods

	// RVA: 0x1B96CC0 Offset: 0x1B96DC1 VA: 0x1B96CC0
	public static IntPtr CreateJavaProxy(IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x1B96AE0 Offset: 0x1B96BE1 VA: 0x1B96AE0
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x10B720 Offset: 0x10B821 VA: 0x10B720
	// RVA: 0x1B9D900 Offset: 0x1B9DA01 VA: 0x1B9D900
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x1B96D60 Offset: 0x1B96E61 VA: 0x1B96D60
	public static jvalue[] CreateJNIArgArray(object[] args) { }

	// RVA: 0x1B9E6C0 Offset: 0x1B9E7C1 VA: 0x1B9E6C0
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x1B9C220 Offset: 0x1B9C321 VA: 0x1B9C220
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x1B9B490 Offset: 0x1B9B591 VA: 0x1B9B490
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x1B97260 Offset: 0x1B97361 VA: 0x1B97260
	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	// RVA: 0x1B9DD40 Offset: 0x1B9DE41 VA: 0x1B9DD40
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA6F80 Offset: 0x1AA7081 VA: 0x1AA6F80
	|-_AndroidJNIHelper.ConvertFromJNIArray<bool>
	|
	|-RVA: 0x1AA7680 Offset: 0x1AA7781 VA: 0x1AA7680
	|-_AndroidJNIHelper.ConvertFromJNIArray<char>
	|
	|-RVA: 0x1AA7D80 Offset: 0x1AA7E81 VA: 0x1AA7D80
	|-_AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x1AA8460 Offset: 0x1AA8561 VA: 0x1AA8460
	|-_AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x1AA8B60 Offset: 0x1AA8C61 VA: 0x1AA8B60
	|-_AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x1AA9240 Offset: 0x1AA9341 VA: 0x1AA9240
	|-_AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x1AA9920 Offset: 0x1AA9A21 VA: 0x1AA9920
	|-_AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x1AAA000 Offset: 0x1AAA101 VA: 0x1AAA000
	|-_AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x1AAA700 Offset: 0x1AAA801 VA: 0x1AAA700
	|-_AndroidJNIHelper.ConvertFromJNIArray<float>
	*/

	// RVA: 0x1B974C0 Offset: 0x1B975C1 VA: 0x1B974C0
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255EF60 Offset: 0x255F061 VA: 0x255EF60
	|-_AndroidJNIHelper.GetMethodID<bool>
	|
	|-RVA: 0x255EFC0 Offset: 0x255F0C1 VA: 0x255EFC0
	|-_AndroidJNIHelper.GetMethodID<char>
	|
	|-RVA: 0x255F020 Offset: 0x255F121 VA: 0x255F020
	|-_AndroidJNIHelper.GetMethodID<double>
	|
	|-RVA: 0x255F080 Offset: 0x255F181 VA: 0x255F080
	|-_AndroidJNIHelper.GetMethodID<short>
	|
	|-RVA: 0x255F0E0 Offset: 0x255F1E1 VA: 0x255F0E0
	|-_AndroidJNIHelper.GetMethodID<int>
	|
	|-RVA: 0x255F140 Offset: 0x255F241 VA: 0x255F140
	|-_AndroidJNIHelper.GetMethodID<long>
	|
	|-RVA: 0x255F1A0 Offset: 0x255F2A1 VA: 0x255F1A0
	|-_AndroidJNIHelper.GetMethodID<object>
	|
	|-RVA: 0x255F200 Offset: 0x255F301 VA: 0x255F200
	|-_AndroidJNIHelper.GetMethodID<sbyte>
	|
	|-RVA: 0x255F260 Offset: 0x255F361 VA: 0x255F260
	|-_AndroidJNIHelper.GetMethodID<float>
	*/

	// RVA: 0x1B96630 Offset: 0x1B96731 VA: 0x1B96630
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x1B96880 Offset: 0x1B96981 VA: 0x1B96880
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x1B9EE50 Offset: 0x1B9EF51 VA: 0x1B9EE50
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x1B9EF60 Offset: 0x1B9F061 VA: 0x1B9EF60
	public static string GetSignature(object obj) { }

	// RVA: 0x1B9ED50 Offset: 0x1B9EE51 VA: 0x1B9ED50
	public static string GetSignature(object[] args) { }

	// RVA: -1 Offset: -1
	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CAD60 Offset: 0x21CAE61 VA: 0x21CAD60
	|-_AndroidJNIHelper.GetSignature<bool>
	|
	|-RVA: 0x21CAEB0 Offset: 0x21CAFB1 VA: 0x21CAEB0
	|-_AndroidJNIHelper.GetSignature<char>
	|
	|-RVA: 0x21CB000 Offset: 0x21CB101 VA: 0x21CB000
	|-_AndroidJNIHelper.GetSignature<double>
	|
	|-RVA: 0x21CB150 Offset: 0x21CB251 VA: 0x21CB150
	|-_AndroidJNIHelper.GetSignature<short>
	|
	|-RVA: 0x21CB2A0 Offset: 0x21CB3A1 VA: 0x21CB2A0
	|-_AndroidJNIHelper.GetSignature<int>
	|
	|-RVA: 0x21CB3F0 Offset: 0x21CB4F1 VA: 0x21CB3F0
	|-_AndroidJNIHelper.GetSignature<long>
	|
	|-RVA: 0x21CB540 Offset: 0x21CB641 VA: 0x21CB540
	|-_AndroidJNIHelper.GetSignature<object>
	|
	|-RVA: 0x21CB690 Offset: 0x21CB791 VA: 0x21CB690
	|-_AndroidJNIHelper.GetSignature<sbyte>
	|
	|-RVA: 0x21CB7E0 Offset: 0x21CB8E1 VA: 0x21CB7E0
	|-_AndroidJNIHelper.GetSignature<float>
	*/
}

