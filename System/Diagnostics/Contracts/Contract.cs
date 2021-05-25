public static class Contract // TypeDefIndex: 1478
{
	// Methods

	[ReliabilityContractAttribute] // RVA: 0xB9D40 Offset: 0xB9E41 VA: 0xB9D40
	// RVA: -1 Offset: -1
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22C87C0 Offset: 0x22C88C1 VA: 0x22C87C0
	|-Contract.ForAll<object>
	|-Contract.ForAll<Type>
	*/
}

