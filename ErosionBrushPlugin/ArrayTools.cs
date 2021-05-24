[ExtensionAttribute] // RVA: 0x149590 Offset: 0x149691 VA: 0x149590
public static class ArrayTools // TypeDefIndex: 9710
{
	// Methods

	[ExtensionAttribute] // RVA: 0x1AC7B0 Offset: 0x1AC8B1 VA: 0x1AC7B0
	// RVA: 0x2AE2E80 Offset: 0x2AE2F81 VA: 0x2AE2E80
	public static int Find(Array array, object obj) { }

	// RVA: -1 Offset: -1
	public static int Find<T>(T[] array, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21B1630 Offset: 0x21B1731 VA: 0x21B1630
	|-ArrayTools.Find<object>
	*/

	// RVA: -1 Offset: -1
	public static void RemoveAt<T>(ref T[] array, int num) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D00F0 Offset: 0x21D01F1 VA: 0x21D00F0
	|-ArrayTools.RemoveAt<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] RemoveAt<T>(T[] array, int num) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226D230 Offset: 0x226D331 VA: 0x226D230
	|-ArrayTools.RemoveAt<object>
	*/

	// RVA: -1 Offset: -1
	public static void Remove<T>(ref T[] array, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D00B0 Offset: 0x21D01B1 VA: 0x21D00B0
	|-ArrayTools.Remove<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] Remove<T>(T[] array, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226D1E0 Offset: 0x226D2E1 VA: 0x226D1E0
	|-ArrayTools.Remove<object>
	*/

	// RVA: -1 Offset: -1
	public static void Add<T>(ref T[] array, int after, T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CFA70 Offset: 0x21CFB71 VA: 0x21CFA70
	|-ArrayTools.Add<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] Add<T>(T[] array, int after, T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226CDB0 Offset: 0x226CEB1 VA: 0x226CDB0
	|-ArrayTools.Add<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] Add<T>(T[] array, T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226CF50 Offset: 0x226D051 VA: 0x226CF50
	|-ArrayTools.Add<object>
	*/

	// RVA: -1 Offset: -1
	public static void Add<T>(ref T[] array, T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CFAB0 Offset: 0x21CFBB1 VA: 0x21CFAB0
	|-ArrayTools.Add<object>
	*/

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int newSize, T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0130 Offset: 0x21D0231 VA: 0x21D0130
	|-ArrayTools.Resize<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] Resize<T>(T[] array, int newSize, T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226D350 Offset: 0x226D451 VA: 0x226D350
	|-ArrayTools.Resize<object>
	*/

	// RVA: -1 Offset: -1
	public static void Append<T>(ref T[] array, T[] additional) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CFB10 Offset: 0x21CFC11 VA: 0x21CFB10
	|-ArrayTools.Append<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] Append<T>(T[] array, T[] additional) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226CF80 Offset: 0x226D081 VA: 0x226CF80
	|-ArrayTools.Append<object>
	*/

	// RVA: -1 Offset: -1
	public static void Switch<T>(T[] array, int num1, int num2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0170 Offset: 0x21D0271 VA: 0x21D0170
	|-ArrayTools.Switch<object>
	*/

	// RVA: -1 Offset: -1
	public static void Switch<T>(T[] array, T obj1, T obj2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D0220 Offset: 0x21D0321 VA: 0x21D0220
	|-ArrayTools.Switch<object>
	*/

	// RVA: 0x2AE2F10 Offset: 0x2AE3011 VA: 0x2AE2F10
	public static void QSort(float[] array) { }

	// RVA: 0x2AE2F30 Offset: 0x2AE3031 VA: 0x2AE2F30
	public static void QSort(float[] array, int l, int r) { }

	// RVA: -1 Offset: -1
	public static void QSort<T>(T[] array, float[] reference) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CFE00 Offset: 0x21CFF01 VA: 0x21CFE00
	|-ArrayTools.QSort<object>
	*/

	// RVA: -1 Offset: -1
	public static void QSort<T>(T[] array, float[] reference, int l, int r) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CFE30 Offset: 0x21CFF31 VA: 0x21CFE30
	|-ArrayTools.QSort<object>
	*/

	// RVA: -1 Offset: -1
	public static void QSort<T>(List<T> list, float[] reference) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CFB50 Offset: 0x21CFC51 VA: 0x21CFB50
	|-ArrayTools.QSort<object>
	*/

	// RVA: -1 Offset: -1
	public static void QSort<T>(List<T> list, float[] reference, int l, int r) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21CFB80 Offset: 0x21CFC81 VA: 0x21CFB80
	|-ArrayTools.QSort<object>
	*/

	// RVA: 0x2AE3050 Offset: 0x2AE3151 VA: 0x2AE3050
	public static int[] Order(int[] array, int[] order, int max = 0, int steps = 1000000, int[] stepsArray) { }

	// RVA: -1 Offset: -1
	public static T[] Convert<T, Y>(Y[] src) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226D0B0 Offset: 0x226D1B1 VA: 0x226D0B0
	|-ArrayTools.Convert<object, object>
	*/
}

