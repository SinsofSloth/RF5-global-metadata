[DebuggerStepThroughAttribute] // RVA: 0xC93A0 Offset: 0xC94A1 VA: 0xC93A0
public static class Assert // TypeDefIndex: 3393
{
	// Fields
	[ObsoleteAttribute] // RVA: 0xCC150 Offset: 0xCC251 VA: 0xCC150
	public static bool raiseExceptions; // 0x0

	// Methods

	// RVA: 0x2AF6E10 Offset: 0x2AF6F11 VA: 0x2AF6E10
	private static void Fail(string message, string userMessage) { }

	[ConditionalAttribute] // RVA: 0xDB450 Offset: 0xDB551 VA: 0xDB450
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E3230 Offset: 0x23E3331 VA: 0x23E3230
	|-Assert.AreEqual<int>
	|
	|-RVA: 0x23E3590 Offset: 0x23E3691 VA: 0x23E3590
	|-Assert.AreEqual<object>
	*/

	[ConditionalAttribute] // RVA: 0xDB490 Offset: 0xDB591 VA: 0xDB490
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E32E0 Offset: 0x23E33E1 VA: 0x23E32E0
	|-Assert.AreEqual<int>
	|
	|-RVA: 0x23E3640 Offset: 0x23E3741 VA: 0x23E3640
	|-Assert.AreEqual<object>
	*/

	[ConditionalAttribute] // RVA: 0xDB4D0 Offset: 0xDB5D1 VA: 0xDB4D0
	// RVA: 0x2AF70F0 Offset: 0x2AF71F1 VA: 0x2AF70F0
	public static void AreEqual(Object expected, Object actual, string message) { }

	[ConditionalAttribute] // RVA: 0xDB510 Offset: 0xDB611 VA: 0xDB510
	// RVA: 0x2AF73B0 Offset: 0x2AF74B1 VA: 0x2AF73B0
	public static void AreEqual(int expected, int actual) { }

	// RVA: 0x2AF7450 Offset: 0x2AF7551 VA: 0x2AF7450
	private static void .cctor() { }
}

