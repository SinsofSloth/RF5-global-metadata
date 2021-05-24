[DefaultMemberAttribute] // RVA: 0xBC270 Offset: 0xBC371 VA: 0xBC270
public class SocketAddress // TypeDefIndex: 1896
{
	// Fields
	internal int m_Size; // 0x10
	internal byte[] m_Buffer; // 0x18
	private bool m_changed; // 0x20
	private int m_hash; // 0x24

	// Properties
	public AddressFamily Family { get; }
	public int Size { get; }
	public byte Item { get; }

	// Methods

	// RVA: 0x16D0520 Offset: 0x16D0621 VA: 0x16D0520
	public AddressFamily get_Family() { }

	// RVA: 0x16D0570 Offset: 0x16D0671 VA: 0x16D0570
	public int get_Size() { }

	// RVA: 0x16D0580 Offset: 0x16D0681 VA: 0x16D0580
	public byte get_Item(int offset) { }

	// RVA: 0x16D0640 Offset: 0x16D0741 VA: 0x16D0640
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x16D0780 Offset: 0x16D0881 VA: 0x16D0780
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x16D09E0 Offset: 0x16D0AE1 VA: 0x16D09E0
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x16D0A50 Offset: 0x16D0B51 VA: 0x16D0A50
	internal IPAddress GetIPAddress() { }

	// RVA: 0x16D0CD0 Offset: 0x16D0DD1 VA: 0x16D0CD0
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x16D0D90 Offset: 0x16D0E91 VA: 0x16D0D90 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x16D0EE0 Offset: 0x16D0FE1 VA: 0x16D0EE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16D1040 Offset: 0x16D1141 VA: 0x16D1040 Slot: 3
	public override string ToString() { }
}

