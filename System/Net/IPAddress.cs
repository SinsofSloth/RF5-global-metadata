[Serializable]
public class IPAddress // TypeDefIndex: 1884
{
	// Fields
	public static readonly IPAddress Any; // 0x0
	public static readonly IPAddress Loopback; // 0x8
	public static readonly IPAddress Broadcast; // 0x10
	public static readonly IPAddress None; // 0x18
	internal const long LoopbackMask = 255;
	internal long m_Address; // 0x10
	internal string m_ToString; // 0x18
	public static readonly IPAddress IPv6Any; // 0x20
	public static readonly IPAddress IPv6Loopback; // 0x28
	public static readonly IPAddress IPv6None; // 0x30
	private AddressFamily m_Family; // 0x20
	private ushort[] m_Numbers; // 0x28
	private long m_ScopeId; // 0x30
	private int m_HashCode; // 0x38
	internal const int IPv4AddressBytes = 4;
	internal const int IPv6AddressBytes = 16;
	internal const int NumberOfLabels = 8;

	// Properties
	public AddressFamily AddressFamily { get; }
	public long ScopeId { get; }

	// Methods

	// RVA: 0x17928F0 Offset: 0x17929F1 VA: 0x17928F0
	public void .ctor(long newAddress) { }

	// RVA: 0x17929C0 Offset: 0x1792AC1 VA: 0x17929C0
	public void .ctor(byte[] address, long scopeid) { }

	// RVA: 0x1792CF0 Offset: 0x1792DF1 VA: 0x1792CF0
	private void .ctor(ushort[] address, uint scopeid) { }

	// RVA: 0x1792DA0 Offset: 0x1792EA1 VA: 0x1792DA0
	internal void .ctor(int newAddress) { }

	// RVA: 0x177D5C0 Offset: 0x177D6C1 VA: 0x177D5C0
	public static bool TryParse(string ipString, out IPAddress address) { }

	// RVA: 0x177D210 Offset: 0x177D311 VA: 0x177D210
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x1792E30 Offset: 0x1792F31 VA: 0x1792E30
	private static IPAddress InternalParse(string ipString, bool tryParse) { }

	// RVA: 0x17881F0 Offset: 0x17882F1 VA: 0x17881F0
	public byte[] GetAddressBytes() { }

	// RVA: 0x1793260 Offset: 0x1793361 VA: 0x1793260
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x1793270 Offset: 0x1793371 VA: 0x1793270
	public long get_ScopeId() { }

	// RVA: 0x1793300 Offset: 0x1793401 VA: 0x1793300 Slot: 3
	public override string ToString() { }

	// RVA: 0x1793AF0 Offset: 0x1793BF1 VA: 0x1793AF0
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x1793C00 Offset: 0x1793D01 VA: 0x1793C00
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x1793EF0 Offset: 0x1793FF1 VA: 0x1793EF0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1793F00 Offset: 0x1794001 VA: 0x1793F00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1794020 Offset: 0x1794121 VA: 0x1794020
	public IPAddress MapToIPv6() { }

	// RVA: 0x1794180 Offset: 0x1794281 VA: 0x1794180
	private static void .cctor() { }
}

