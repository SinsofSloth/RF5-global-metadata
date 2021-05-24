internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 491
{
	// Fields
	internal static readonly FastResourceComparer Default; // 0x0

	// Methods

	// RVA: 0x17F3E90 Offset: 0x17F3F91 VA: 0x17F3E90 Slot: 6
	public int GetHashCode(object key) { }

	// RVA: 0x17F3FF0 Offset: 0x17F40F1 VA: 0x17F3FF0 Slot: 9
	public int GetHashCode(string key) { }

	// RVA: 0x17F3F70 Offset: 0x17F4071 VA: 0x17F3F70
	internal static int HashFunction(string key) { }

	// RVA: 0x17F40B0 Offset: 0x17F41B1 VA: 0x17F40B0 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0x17F4160 Offset: 0x17F4261 VA: 0x17F4160 Slot: 7
	public int Compare(string a, string b) { }

	// RVA: 0x17F4170 Offset: 0x17F4271 VA: 0x17F4170 Slot: 8
	public bool Equals(string a, string b) { }

	// RVA: 0x17F4180 Offset: 0x17F4281 VA: 0x17F4180 Slot: 5
	public bool Equals(object a, object b) { }

	// RVA: 0x17F4230 Offset: 0x17F4331 VA: 0x17F4230
	public static int CompareOrdinal(string a, byte[] bytes, int bCharLength) { }

	// RVA: 0x17F4300 Offset: 0x17F4401 VA: 0x17F4300
	public static int CompareOrdinal(byte[] bytes, int aCharLength, string b) { }

	// RVA: 0x17F4410 Offset: 0x17F4511 VA: 0x17F4410
	internal static int CompareOrdinal(byte* a, int byteLen, string b) { }

	// RVA: 0x17F44B0 Offset: 0x17F45B1 VA: 0x17F44B0
	public void .ctor() { }

	// RVA: 0x17F44C0 Offset: 0x17F45C1 VA: 0x17F44C0
	private static void .cctor() { }
}

