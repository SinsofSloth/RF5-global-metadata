private class ServicePointManager.SPKey // TypeDefIndex: 1989
{
	// Fields
	private Uri uri; // 0x10
	private Uri proxy; // 0x18
	private bool use_connect; // 0x20

	// Properties
	public bool UsesProxy { get; }

	// Methods

	// RVA: 0x16CEFB0 Offset: 0x16CF0B1 VA: 0x16CEFB0
	public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	// RVA: 0x16CF010 Offset: 0x16CF111 VA: 0x16CF010
	public bool get_UsesProxy() { }

	// RVA: 0x16CF080 Offset: 0x16CF181 VA: 0x16CF080 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16CF160 Offset: 0x16CF261 VA: 0x16CF160 Slot: 0
	public override bool Equals(object obj) { }
}

