internal class AndroidJNISafe // TypeDefIndex: 3802
{
	// Methods

	// RVA: 0x1B974F0 Offset: 0x1B975F1 VA: 0x1B974F0
	public static void CheckException() { }

	// RVA: 0x1B97AB0 Offset: 0x1B97BB1 VA: 0x1B97AB0
	public static void DeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x1B97B50 Offset: 0x1B97C51 VA: 0x1B97B50
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x1B97A10 Offset: 0x1B97B11 VA: 0x1B97A10
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x1B97BF0 Offset: 0x1B97CF1 VA: 0x1B97BF0
	public static IntPtr NewString(string chars) { }

	// RVA: 0x1B97C70 Offset: 0x1B97D71 VA: 0x1B97C70
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x1B97CF0 Offset: 0x1B97DF1 VA: 0x1B97CF0
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x1B97D70 Offset: 0x1B97E71 VA: 0x1B97D70
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1B97E10 Offset: 0x1B97F11 VA: 0x1B97E10
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x1B97EB0 Offset: 0x1B97FB1 VA: 0x1B97EB0
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x1B97F30 Offset: 0x1B98031 VA: 0x1B97F30
	public static IntPtr FindClass(string name) { }

	// RVA: 0x1B97FB0 Offset: 0x1B980B1 VA: 0x1B97FB0
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98050 Offset: 0x1B98151 VA: 0x1B98050
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B980F0 Offset: 0x1B981F1 VA: 0x1B980F0
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98190 Offset: 0x1B98291 VA: 0x1B98190
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98230 Offset: 0x1B98331 VA: 0x1B98230
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B982D0 Offset: 0x1B983D1 VA: 0x1B982D0
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98380 Offset: 0x1B98481 VA: 0x1B98380
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98430 Offset: 0x1B98531 VA: 0x1B98430
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B984D0 Offset: 0x1B985D1 VA: 0x1B984D0
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98570 Offset: 0x1B98671 VA: 0x1B98570
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98610 Offset: 0x1B98711 VA: 0x1B98610
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B986B0 Offset: 0x1B987B1 VA: 0x1B986B0
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98750 Offset: 0x1B98851 VA: 0x1B98750
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B987F0 Offset: 0x1B988F1 VA: 0x1B987F0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98890 Offset: 0x1B98991 VA: 0x1B98890
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98930 Offset: 0x1B98A31 VA: 0x1B98930
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B989E0 Offset: 0x1B98AE1 VA: 0x1B989E0
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98A90 Offset: 0x1B98B91 VA: 0x1B98A90
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98B30 Offset: 0x1B98C31 VA: 0x1B98B30
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98BD0 Offset: 0x1B98CD1 VA: 0x1B98BD0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98C70 Offset: 0x1B98D71 VA: 0x1B98C70
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98D10 Offset: 0x1B98E11 VA: 0x1B98D10
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1B98DB0 Offset: 0x1B98EB1 VA: 0x1B98DB0
	public static char[] FromCharArray(IntPtr array) { }

	// RVA: 0x1B98E30 Offset: 0x1B98F31 VA: 0x1B98E30
	public static double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x1B98EB0 Offset: 0x1B98FB1 VA: 0x1B98EB0
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x1B98F30 Offset: 0x1B99031 VA: 0x1B98F30
	public static long[] FromLongArray(IntPtr array) { }

	// RVA: 0x1B98FB0 Offset: 0x1B990B1 VA: 0x1B98FB0
	public static short[] FromShortArray(IntPtr array) { }

	// RVA: 0x1B99030 Offset: 0x1B99131 VA: 0x1B99030
	public static byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x1B990B0 Offset: 0x1B991B1 VA: 0x1B990B0
	public static sbyte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x1B99130 Offset: 0x1B99231 VA: 0x1B99130
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x1B991B0 Offset: 0x1B992B1 VA: 0x1B991B0
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x1B99230 Offset: 0x1B99331 VA: 0x1B99230
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x1B992C0 Offset: 0x1B993C1 VA: 0x1B992C0
	public static IntPtr ToCharArray(char[] array) { }

	// RVA: 0x1B99340 Offset: 0x1B99441 VA: 0x1B99340
	public static IntPtr ToDoubleArray(double[] array) { }

	// RVA: 0x1B993C0 Offset: 0x1B994C1 VA: 0x1B993C0
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x1B99440 Offset: 0x1B99541 VA: 0x1B99440
	public static IntPtr ToLongArray(long[] array) { }

	// RVA: 0x1B994C0 Offset: 0x1B995C1 VA: 0x1B994C0
	public static IntPtr ToShortArray(short[] array) { }

	// RVA: 0x1B99540 Offset: 0x1B99641 VA: 0x1B99540
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x1B995C0 Offset: 0x1B996C1 VA: 0x1B995C0
	public static IntPtr ToSByteArray(sbyte[] array) { }

	// RVA: 0x1B99640 Offset: 0x1B99741 VA: 0x1B99640
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x1B996C0 Offset: 0x1B997C1 VA: 0x1B996C0
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x1B99740 Offset: 0x1B99841 VA: 0x1B99740
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x1B997D0 Offset: 0x1B998D1 VA: 0x1B997D0
	public static int GetArrayLength(IntPtr array) { }
}

