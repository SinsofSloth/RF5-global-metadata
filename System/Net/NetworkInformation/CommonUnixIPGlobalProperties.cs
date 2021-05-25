internal abstract class CommonUnixIPGlobalProperties : IPGlobalProperties // TypeDefIndex: 2041
{
	// Properties
	public override string DomainName { get; }

	// Methods

	// RVA: 0x16C8DF0 Offset: 0x16C8EF1 VA: 0x16C8DF0
	private static extern int getdomainname(byte[] name, int len) { }

	// RVA: 0x16C8E90 Offset: 0x16C8F91 VA: 0x16C8E90 Slot: 4
	public override string get_DomainName() { }

	// RVA: 0x16C9190 Offset: 0x16C9291 VA: 0x16C9190
	protected void .ctor() { }
}

