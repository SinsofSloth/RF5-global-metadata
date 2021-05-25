[Serializable]
public abstract class EndPoint // TypeDefIndex: 1875
{
	// Properties
	public virtual AddressFamily AddressFamily { get; }

	// Methods

	// RVA: 0x177D870 Offset: 0x177D971 VA: 0x177D870 Slot: 4
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x177D940 Offset: 0x177DA41 VA: 0x177D940 Slot: 5
	public virtual SocketAddress Serialize() { }

	// RVA: 0x177DA10 Offset: 0x177DB11 VA: 0x177DA10 Slot: 6
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x177DA60 Offset: 0x177DB61 VA: 0x177DA60
	protected void .ctor() { }
}

