public static class GC // TypeDefIndex: 234
{
	// Fields
	internal static readonly object EPHEMERON_TOMBSTONE; // 0x0

	// Properties
	public static int MaxGeneration { get; }

	// Methods

	// RVA: 0x179FC90 Offset: 0x179FD91 VA: 0x179FC90
	private static int GetMaxGeneration() { }

	// RVA: 0x179FCA0 Offset: 0x179FDA1 VA: 0x179FCA0
	private static void InternalCollect(int generation) { }

	// RVA: 0x179FCB0 Offset: 0x179FDB1 VA: 0x179FCB0
	internal static void register_ephemeron_array(Ephemeron[] array) { }

	// RVA: 0x179FCC0 Offset: 0x179FDC1 VA: 0x179FCC0
	private static object get_ephemeron_tombstone() { }

	// RVA: 0x179FCD0 Offset: 0x179FDD1 VA: 0x179FCD0
	public static void Collect() { }

	[ReliabilityContractAttribute] // RVA: 0xB6A40 Offset: 0xB6B41 VA: 0xB6A40
	// RVA: 0x179FE00 Offset: 0x179FF01 VA: 0x179FE00
	public static void KeepAlive(object obj) { }

	// RVA: 0x179FD90 Offset: 0x179FE91 VA: 0x179FD90
	public static int get_MaxGeneration() { }

	[ReliabilityContractAttribute] // RVA: 0xB6A60 Offset: 0xB6B61 VA: 0xB6A60
	// RVA: 0x179FE10 Offset: 0x179FF11 VA: 0x179FE10
	private static void _SuppressFinalize(object o) { }

	[ReliabilityContractAttribute] // RVA: 0xB6A80 Offset: 0xB6B81 VA: 0xB6A80
	// RVA: 0x179FE20 Offset: 0x179FF21 VA: 0x179FE20
	public static void SuppressFinalize(object obj) { }

	// RVA: 0x179FEE0 Offset: 0x179FFE1 VA: 0x179FEE0
	private static void _ReRegisterForFinalize(object o) { }

	// RVA: 0x179FEF0 Offset: 0x179FFF1 VA: 0x179FEF0
	public static void ReRegisterForFinalize(object obj) { }

	// RVA: 0x179FFB0 Offset: 0x17A00B1 VA: 0x179FFB0
	public static long GetTotalMemory(bool forceFullCollection) { }

	// RVA: 0x179FFC0 Offset: 0x17A00C1 VA: 0x179FFC0
	private static void .cctor() { }
}

