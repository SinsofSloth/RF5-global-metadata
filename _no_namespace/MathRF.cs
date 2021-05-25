public class MathRF // TypeDefIndex: 7301
{
	// Methods

	// RVA: 0x1E1E3E0 Offset: 0x1E1E4E1 VA: 0x1E1E3E0
	public static long Clamp(long value, long min, long max) { }

	// RVA: -1 Offset: -1
	public static T[] MergeSort<T>(T[] source, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226D4F0 Offset: 0x226D5F1 VA: 0x226D4F0
	|-MathRF.MergeSort<object>
	|
	|-RVA: 0x226D5F0 Offset: 0x226D6F1 VA: 0x226D5F0
	|-MathRF.MergeSort<ValueTuple<float, ActionCommandBase>>
	|-MathRF.MergeSort<ValueTuple<float, object>>
	*/

	// RVA: -1 Offset: -1
	public static T[] MergeSort<T>(T[] source, int index, int length, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226D520 Offset: 0x226D621 VA: 0x226D520
	|-MathRF.MergeSort<object>
	|
	|-RVA: 0x226D620 Offset: 0x226D721 VA: 0x226D620
	|-MathRF.MergeSort<ValueTuple<float, object>>
	*/

	// RVA: -1 Offset: -1
	private static void MergeSort<T>(T[] a, T[] b, int left, int right, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D2210 Offset: 0x21D2311 VA: 0x21D2210
	|-MathRF.MergeSort<object>
	|
	|-RVA: 0x21D2300 Offset: 0x21D2401 VA: 0x21D2300
	|-MathRF.MergeSort<ValueTuple<float, object>>
	*/

	// RVA: -1 Offset: -1
	private static void Merge<T>(T[] a, T[] b, int left, int mid, int right, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D1A50 Offset: 0x21D1B51 VA: 0x21D1A50
	|-MathRF.Merge<object>
	|
	|-RVA: 0x21D1DE0 Offset: 0x21D1EE1 VA: 0x21D1DE0
	|-MathRF.Merge<ValueTuple<float, object>>
	*/

	// RVA: 0x1E1E400 Offset: 0x1E1E501 VA: 0x1E1E400
	public void .ctor() { }
}

