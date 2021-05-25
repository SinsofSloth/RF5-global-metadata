[StaticAccessorAttribute] // RVA: 0x10B690 Offset: 0x10B791 VA: 0x10B690
[NativeConditionalAttribute] // RVA: 0x10B690 Offset: 0x10B791 VA: 0x10B690
[NativeHeaderAttribute] // RVA: 0x10B690 Offset: 0x10B791 VA: 0x10B690
public static class AndroidJNI // TypeDefIndex: 3801
{
	// Methods

	[ThreadSafeAttribute] // RVA: 0x10B730 Offset: 0x10B831 VA: 0x10B730
	// RVA: 0x1B95190 Offset: 0x1B95291 VA: 0x1B95190
	public static IntPtr FindClass(string name) { }

	[ThreadSafeAttribute] // RVA: 0x10B740 Offset: 0x10B841 VA: 0x10B740
	// RVA: 0x1B951E0 Offset: 0x1B952E1 VA: 0x1B951E0
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafeAttribute] // RVA: 0x10B750 Offset: 0x10B851 VA: 0x10B750
	// RVA: 0x1B95230 Offset: 0x1B95331 VA: 0x1B95230
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafeAttribute] // RVA: 0x10B760 Offset: 0x10B861 VA: 0x10B760
	// RVA: 0x1B95270 Offset: 0x1B95371 VA: 0x1B95270
	public static void ExceptionClear() { }

	[ThreadSafeAttribute] // RVA: 0x10B770 Offset: 0x10B871 VA: 0x10B770
	// RVA: 0x1B952B0 Offset: 0x1B953B1 VA: 0x1B952B0
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x10B780 Offset: 0x10B881 VA: 0x10B780
	// RVA: 0x1B95300 Offset: 0x1B95401 VA: 0x1B95300
	public static void DeleteGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x10B790 Offset: 0x10B891 VA: 0x10B790
	// RVA: 0x1B95350 Offset: 0x1B95451 VA: 0x1B95350
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x10B7A0 Offset: 0x10B8A1 VA: 0x10B7A0
	// RVA: 0x1B953A0 Offset: 0x1B954A1 VA: 0x1B953A0
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x10B7B0 Offset: 0x10B8B1 VA: 0x10B7B0
	// RVA: 0x1B953F0 Offset: 0x1B954F1 VA: 0x1B953F0
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x10B7C0 Offset: 0x10B8C1 VA: 0x10B7C0
	// RVA: 0x1B95440 Offset: 0x1B95541 VA: 0x1B95440
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x10B7D0 Offset: 0x10B8D1 VA: 0x10B7D0
	// RVA: 0x1B95490 Offset: 0x1B95591 VA: 0x1B95490
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B7E0 Offset: 0x10B8E1 VA: 0x10B7E0
	// RVA: 0x1B954F0 Offset: 0x1B955F1 VA: 0x1B954F0
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x10B7F0 Offset: 0x10B8F1 VA: 0x10B7F0
	// RVA: 0x1B95540 Offset: 0x1B95641 VA: 0x1B95540
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafeAttribute] // RVA: 0x10B800 Offset: 0x10B901 VA: 0x10B800
	// RVA: 0x1B955A0 Offset: 0x1B956A1 VA: 0x1B955A0
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1B95600 Offset: 0x1B95701 VA: 0x1B95600
	public static IntPtr NewString(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x10B810 Offset: 0x10B911 VA: 0x10B810
	// RVA: 0x1B95650 Offset: 0x1B95751 VA: 0x1B95650
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafeAttribute] // RVA: 0x10B820 Offset: 0x10B921 VA: 0x10B820
	// RVA: 0x1B956A0 Offset: 0x1B957A1 VA: 0x1B956A0
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafeAttribute] // RVA: 0x10B830 Offset: 0x10B931 VA: 0x10B830
	// RVA: 0x1B956F0 Offset: 0x1B957F1 VA: 0x1B956F0
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B840 Offset: 0x10B941 VA: 0x10B840
	// RVA: 0x1B95750 Offset: 0x1B95851 VA: 0x1B95750
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B850 Offset: 0x10B951 VA: 0x10B850
	// RVA: 0x1B957B0 Offset: 0x1B958B1 VA: 0x1B957B0
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B860 Offset: 0x10B961 VA: 0x10B860
	// RVA: 0x1B95810 Offset: 0x1B95911 VA: 0x1B95810
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B870 Offset: 0x10B971 VA: 0x10B870
	// RVA: 0x1B95870 Offset: 0x1B95971 VA: 0x1B95870
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B880 Offset: 0x10B981 VA: 0x10B880
	// RVA: 0x1B958D0 Offset: 0x1B959D1 VA: 0x1B958D0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B890 Offset: 0x10B991 VA: 0x10B890
	// RVA: 0x1B95930 Offset: 0x1B95A31 VA: 0x1B95930
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B8A0 Offset: 0x10B9A1 VA: 0x10B8A0
	// RVA: 0x1B95990 Offset: 0x1B95A91 VA: 0x1B95990
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B8B0 Offset: 0x10B9B1 VA: 0x10B8B0
	// RVA: 0x1B959F0 Offset: 0x1B95AF1 VA: 0x1B959F0
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B8C0 Offset: 0x10B9C1 VA: 0x10B8C0
	// RVA: 0x1B95A50 Offset: 0x1B95B51 VA: 0x1B95A50
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B8D0 Offset: 0x10B9D1 VA: 0x10B8D0
	// RVA: 0x1B95AB0 Offset: 0x1B95BB1 VA: 0x1B95AB0
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B8E0 Offset: 0x10B9E1 VA: 0x10B8E0
	// RVA: 0x1B95B10 Offset: 0x1B95C11 VA: 0x1B95B10
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B8F0 Offset: 0x10B9F1 VA: 0x10B8F0
	// RVA: 0x1B95B70 Offset: 0x1B95C71 VA: 0x1B95B70
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B900 Offset: 0x10BA01 VA: 0x10B900
	// RVA: 0x1B95BD0 Offset: 0x1B95CD1 VA: 0x1B95BD0
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B910 Offset: 0x10BA11 VA: 0x10B910
	// RVA: 0x1B95C30 Offset: 0x1B95D31 VA: 0x1B95C30
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B920 Offset: 0x10BA21 VA: 0x10B920
	// RVA: 0x1B95C90 Offset: 0x1B95D91 VA: 0x1B95C90
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B930 Offset: 0x10BA31 VA: 0x10B930
	// RVA: 0x1B95CF0 Offset: 0x1B95DF1 VA: 0x1B95CF0
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B940 Offset: 0x10BA41 VA: 0x10B940
	// RVA: 0x1B95D50 Offset: 0x1B95E51 VA: 0x1B95D50
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B950 Offset: 0x10BA51 VA: 0x10B950
	// RVA: 0x1B95DB0 Offset: 0x1B95EB1 VA: 0x1B95DB0
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B960 Offset: 0x10BA61 VA: 0x10B960
	// RVA: 0x1B95E10 Offset: 0x1B95F11 VA: 0x1B95E10
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B970 Offset: 0x10BA71 VA: 0x10B970
	// RVA: 0x1B95E70 Offset: 0x1B95F71 VA: 0x1B95E70
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	[ThreadSafeAttribute] // RVA: 0x10B980 Offset: 0x10BA81 VA: 0x10B980
	// RVA: 0x1B95ED0 Offset: 0x1B95FD1 VA: 0x1B95ED0
	public static IntPtr ToBooleanArray(bool[] array) { }

	[ThreadSafeAttribute] // RVA: 0x10B990 Offset: 0x10BA91 VA: 0x10B990
	[ObsoleteAttribute] // RVA: 0x10B990 Offset: 0x10BA91 VA: 0x10B990
	// RVA: 0x1B95F20 Offset: 0x1B96021 VA: 0x1B95F20
	public static IntPtr ToByteArray(byte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x10B9E0 Offset: 0x10BAE1 VA: 0x10B9E0
	// RVA: 0x1B95F70 Offset: 0x1B96071 VA: 0x1B95F70
	public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafeAttribute] // RVA: 0x10B9F0 Offset: 0x10BAF1 VA: 0x10B9F0
	// RVA: 0x1B95FC0 Offset: 0x1B960C1 VA: 0x1B95FC0
	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafeAttribute] // RVA: 0x10BA00 Offset: 0x10BB01 VA: 0x10BA00
	// RVA: 0x1B96010 Offset: 0x1B96111 VA: 0x1B96010
	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafeAttribute] // RVA: 0x10BA10 Offset: 0x10BB11 VA: 0x10BA10
	// RVA: 0x1B96060 Offset: 0x1B96161 VA: 0x1B96060
	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafeAttribute] // RVA: 0x10BA20 Offset: 0x10BB21 VA: 0x10BA20
	// RVA: 0x1B960B0 Offset: 0x1B961B1 VA: 0x1B960B0
	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafeAttribute] // RVA: 0x10BA30 Offset: 0x10BB31 VA: 0x10BA30
	// RVA: 0x1B96100 Offset: 0x1B96201 VA: 0x1B96100
	public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafeAttribute] // RVA: 0x10BA40 Offset: 0x10BB41 VA: 0x10BA40
	// RVA: 0x1B96150 Offset: 0x1B96251 VA: 0x1B96150
	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafeAttribute] // RVA: 0x10BA50 Offset: 0x10BB51 VA: 0x10BA50
	// RVA: 0x1B961A0 Offset: 0x1B962A1 VA: 0x1B961A0
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	[ThreadSafeAttribute] // RVA: 0x10BA60 Offset: 0x10BB61 VA: 0x10BA60
	// RVA: 0x1B961F0 Offset: 0x1B962F1 VA: 0x1B961F0
	public static bool[] FromBooleanArray(IntPtr array) { }

	[ObsoleteAttribute] // RVA: 0x10BA70 Offset: 0x10BB71 VA: 0x10BA70
	[ThreadSafeAttribute] // RVA: 0x10BA70 Offset: 0x10BB71 VA: 0x10BA70
	// RVA: 0x1B96240 Offset: 0x1B96341 VA: 0x1B96240
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x10BAC0 Offset: 0x10BBC1 VA: 0x10BAC0
	// RVA: 0x1B96290 Offset: 0x1B96391 VA: 0x1B96290
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x10BAD0 Offset: 0x10BBD1 VA: 0x10BAD0
	// RVA: 0x1B962E0 Offset: 0x1B963E1 VA: 0x1B962E0
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x10BAE0 Offset: 0x10BBE1 VA: 0x10BAE0
	// RVA: 0x1B96330 Offset: 0x1B96431 VA: 0x1B96330
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x10BAF0 Offset: 0x10BBF1 VA: 0x10BAF0
	// RVA: 0x1B96380 Offset: 0x1B96481 VA: 0x1B96380
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x10BB00 Offset: 0x10BC01 VA: 0x10BB00
	// RVA: 0x1B963D0 Offset: 0x1B964D1 VA: 0x1B963D0
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x10BB10 Offset: 0x10BC11 VA: 0x10BB10
	// RVA: 0x1B96420 Offset: 0x1B96521 VA: 0x1B96420
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x10BB20 Offset: 0x10BC21 VA: 0x10BB20
	// RVA: 0x1B96470 Offset: 0x1B96571 VA: 0x1B96470
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x10BB30 Offset: 0x10BC31 VA: 0x10BB30
	// RVA: 0x1B964C0 Offset: 0x1B965C1 VA: 0x1B964C0
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafeAttribute] // RVA: 0x10BB40 Offset: 0x10BC41 VA: 0x10BB40
	// RVA: 0x1B96510 Offset: 0x1B96611 VA: 0x1B96510
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafeAttribute] // RVA: 0x10BB50 Offset: 0x10BC51 VA: 0x10BB50
	// RVA: 0x1B96570 Offset: 0x1B96671 VA: 0x1B96570
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[ThreadSafeAttribute] // RVA: 0x10BB60 Offset: 0x10BC61 VA: 0x10BB60
	// RVA: 0x1B965C0 Offset: 0x1B966C1 VA: 0x1B965C0
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }
}

