[NativeHeaderAttribute] // RVA: 0xC5BC0 Offset: 0xC5CC1 VA: 0xC5BC0
internal class UnityLogWriter : TextWriter // TypeDefIndex: 2957
{
	// Methods

	[ThreadAndSerializationSafeAttribute] // RVA: 0xD4BE0 Offset: 0xD4CE1 VA: 0xD4BE0
	// RVA: 0x1B79680 Offset: 0x1B79781 VA: 0x1B79680
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunctionAttribute] // RVA: 0xD4BF0 Offset: 0xD4CF1 VA: 0xD4BF0
	// RVA: 0x1B796E0 Offset: 0x1B797E1 VA: 0x1B796E0
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x1B79730 Offset: 0x1B79831 VA: 0x1B79730
	public static void Init() { }

	// RVA: 0x1B79870 Offset: 0x1B79971 VA: 0x1B79870 Slot: 11
	public override void Write(char value) { }

	// RVA: 0x1B798D0 Offset: 0x1B799D1 VA: 0x1B798D0 Slot: 15
	public override void Write(string s) { }

	// RVA: 0x1B79930 Offset: 0x1B79A31 VA: 0x1B79930 Slot: 13
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1B79800 Offset: 0x1B79901 VA: 0x1B79800
	public void .ctor() { }
}

