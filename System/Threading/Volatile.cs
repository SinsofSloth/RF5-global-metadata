public static class Volatile // TypeDefIndex: 836
{
	// Methods

	[ReliabilityContractAttribute] // RVA: 0xB9040 Offset: 0xB9141 VA: 0xB9040
	// RVA: 0x158EF70 Offset: 0x158F071 VA: 0x158EF70
	public static bool Read(ref bool location) { }

	[ReliabilityContractAttribute] // RVA: 0xB9060 Offset: 0xB9161 VA: 0xB9060
	// RVA: 0x158EFA0 Offset: 0x158F0A1 VA: 0x158EFA0
	public static int Read(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0xB9080 Offset: 0xB9181 VA: 0xB9080
	// RVA: -1 Offset: -1
	public static T Read<T>(ref T location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2264440 Offset: 0x2264541 VA: 0x2264440
	|-Volatile.Read<object>
	*/

	[ReliabilityContractAttribute] // RVA: 0xB90A0 Offset: 0xB91A1 VA: 0xB90A0
	// RVA: 0x158EFD0 Offset: 0x158F0D1 VA: 0x158EFD0
	public static void Write(ref int location, int value) { }

	[ReliabilityContractAttribute] // RVA: 0xB90C0 Offset: 0xB91C1 VA: 0xB90C0
	// RVA: -1 Offset: -1
	public static void Write<T>(ref T location, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E00B0 Offset: 0x23E01B1 VA: 0x23E00B0
	|-Volatile.Write<object>
	*/
}

