private class MessagePackSecurity.ObjectFallbackEqualityComparer : IEqualityComparer<object>, IEqualityComparer // TypeDefIndex: 5138
{
	// Fields
	private static readonly MethodInfo GetHashCollisionResistantEqualityComparerOpenGenericMethod; // 0x0
	private readonly MessagePackSecurity security; // 0x10
	private readonly ThreadsafeTypeKeyHashTable<IEqualityComparer> equalityComparerCache; // 0x18

	// Methods

	// RVA: 0x1691790 Offset: 0x1691891 VA: 0x1691790
	internal void .ctor(MessagePackSecurity security) { }

	// RVA: 0x1692770 Offset: 0x1692871 VA: 0x1692770 Slot: 4
	private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	// RVA: 0x16927F0 Offset: 0x16928F1 VA: 0x16927F0 Slot: 6
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

	// RVA: 0x16928D0 Offset: 0x16929D1 VA: 0x16928D0 Slot: 7
	public int GetHashCode(object value) { }

	// RVA: 0x1692CF0 Offset: 0x1692DF1 VA: 0x1692CF0
	private static void .cctor() { }
}

