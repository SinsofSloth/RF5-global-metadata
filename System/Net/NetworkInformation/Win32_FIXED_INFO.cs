internal struct Win32_FIXED_INFO // TypeDefIndex: 2047
{
	// Fields
	public string HostName; // 0x0
	public string DomainName; // 0x8
	public IntPtr CurrentDnsServer; // 0x10
	public Win32_IP_ADDR_STRING DnsServerList; // 0x18
	public NetBiosNodeType NodeType; // 0x38
	public string ScopeId; // 0x40
	public uint EnableRouting; // 0x48
	public uint EnableProxy; // 0x4C
	public uint EnableDns; // 0x50
}

