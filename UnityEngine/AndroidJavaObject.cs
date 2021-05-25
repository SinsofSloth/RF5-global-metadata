public class AndroidJavaObject : IDisposable // TypeDefIndex: 3795
{
	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x1B99EC0 Offset: 0x1B99FC1 VA: 0x1B99EC0
	public void .ctor(string className, object[] args) { }

	// RVA: 0x1B9A2C0 Offset: 0x1B9A3C1 VA: 0x1B9A2C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1B9A340 Offset: 0x1B9A441 VA: 0x1B9A340
	public IntPtr GetRawObject() { }

	// RVA: 0x1B9A380 Offset: 0x1B9A481 VA: 0x1B9A380
	public IntPtr GetRawClass() { }

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x280FF70 Offset: 0x2810071 VA: 0x280FF70
	|-AndroidJavaObject.Call<bool>
	|
	|-RVA: 0x280FF90 Offset: 0x2810091 VA: 0x280FF90
	|-AndroidJavaObject.Call<char>
	|
	|-RVA: 0x280FFB0 Offset: 0x28100B1 VA: 0x280FFB0
	|-AndroidJavaObject.Call<double>
	|
	|-RVA: 0x280FFD0 Offset: 0x28100D1 VA: 0x280FFD0
	|-AndroidJavaObject.Call<short>
	|
	|-RVA: 0x280FFF0 Offset: 0x28100F1 VA: 0x280FFF0
	|-AndroidJavaObject.Call<int>
	|
	|-RVA: 0x2810010 Offset: 0x2810111 VA: 0x2810010
	|-AndroidJavaObject.Call<long>
	|
	|-RVA: 0x2810030 Offset: 0x2810131 VA: 0x2810030
	|-AndroidJavaObject.Call<object>
	|-AndroidJavaObject.Call<string>
	|-AndroidJavaObject.Call<AndroidJavaObject>
	|
	|-RVA: 0x2810050 Offset: 0x2810151 VA: 0x2810050
	|-AndroidJavaObject.Call<sbyte>
	|
	|-RVA: 0x2810070 Offset: 0x2810171 VA: 0x2810070
	|-AndroidJavaObject.Call<float>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2810090 Offset: 0x2810191 VA: 0x2810090
	|-AndroidJavaObject.CallStatic<int>
	|
	|-RVA: 0x28100B0 Offset: 0x28101B1 VA: 0x28100B0
	|-AndroidJavaObject.CallStatic<object>
	|-AndroidJavaObject.CallStatic<AndroidJavaObject>
	*/

	// RVA: 0x1B99B30 Offset: 0x1B99C31 VA: 0x1B99B30
	protected void DebugPrint(string msg) { }

	// RVA: 0x1B99F00 Offset: 0x1B9A001 VA: 0x1B99F00
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x1B9A3E0 Offset: 0x1B9A4E1 VA: 0x1B9A3E0
	internal void .ctor(IntPtr jobject) { }

	// RVA: 0x1B998D0 Offset: 0x1B999D1 VA: 0x1B998D0
	internal void .ctor() { }

	// RVA: 0x1B9A650 Offset: 0x1B9A751 VA: 0x1B9A650 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1B9A6D0 Offset: 0x1B9A7D1 VA: 0x1B9A6D0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28100D0 Offset: 0x28101D1 VA: 0x28100D0
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0x2811280 Offset: 0x2811381 VA: 0x2811280
	|-AndroidJavaObject._Call<char>
	|
	|-RVA: 0x2812420 Offset: 0x2812521 VA: 0x2812420
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x28135E0 Offset: 0x28136E1 VA: 0x28135E0
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x2814780 Offset: 0x2814881 VA: 0x2814780
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x2815920 Offset: 0x2815A21 VA: 0x2815920
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x2816AC0 Offset: 0x2816BC1 VA: 0x2816AC0
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x2817B60 Offset: 0x2817C61 VA: 0x2817B60
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x2818D00 Offset: 0x2818E01 VA: 0x2818D00
	|-AndroidJavaObject._Call<float>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2819EC0 Offset: 0x2819FC1 VA: 0x2819EC0
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x281B060 Offset: 0x281B161 VA: 0x281B060
	|-AndroidJavaObject._CallStatic<object>
	*/

	// RVA: 0x1B9A810 Offset: 0x1B9A911 VA: 0x1B9A810
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x1B9A920 Offset: 0x1B9AA21 VA: 0x1B9A920
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: 0x1B9A360 Offset: 0x1B9A461 VA: 0x1B9A360
	protected IntPtr _GetRawObject() { }

	// RVA: 0x1B9A3A0 Offset: 0x1B9A4A1 VA: 0x1B9A3A0
	protected IntPtr _GetRawClass() { }

	// RVA: 0x1B9AA30 Offset: 0x1B9AB31 VA: 0x1B9AA30
	private static void .cctor() { }
}

