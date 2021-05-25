[Serializable]
internal class CrossAppDomainData // TypeDefIndex: 1161
{
	// Fields
	private object _ContextID; // 0x10
	private int _DomainID; // 0x18
	private string _processGuid; // 0x20

	// Properties
	internal int DomainID { get; }
	internal string ProcessID { get; }

	// Methods

	// RVA: 0x1740380 Offset: 0x1740481 VA: 0x1740380
	internal void .ctor(int domainId) { }

	// RVA: 0x1740940 Offset: 0x1740A41 VA: 0x1740940
	internal int get_DomainID() { }

	// RVA: 0x1740950 Offset: 0x1740A51 VA: 0x1740950
	internal string get_ProcessID() { }
}

