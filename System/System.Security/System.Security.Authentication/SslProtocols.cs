[FlagsAttribute] // RVA: 0xBC000 Offset: 0xBC101 VA: 0xBC000
public enum SslProtocols // TypeDefIndex: 1823
{
	// Fields
	public int value__; // 0x0
	public const SslProtocols None = 0;
	public const SslProtocols Ssl2 = 12;
	public const SslProtocols Ssl3 = 48;
	public const SslProtocols Tls = 192;
	[MonoTODOAttribute] // RVA: 0xBCE80 Offset: 0xBCF81 VA: 0xBCE80
	public const SslProtocols Tls11 = 768;
	[MonoTODOAttribute] // RVA: 0xBCEC0 Offset: 0xBCFC1 VA: 0xBCEC0
	public const SslProtocols Tls12 = 3072;
	public const SslProtocols Default = 240;
}

