[FlagsAttribute] // RVA: 0xBACE0 Offset: 0xBADE1 VA: 0xBACE0
public enum TlsProtocols // TypeDefIndex: 1588
{
	// Fields
	public int value__; // 0x0
	public const TlsProtocols Zero = 0;
	public const TlsProtocols Tls10Client = 128;
	public const TlsProtocols Tls10Server = 64;
	public const TlsProtocols Tls10 = 192;
	public const TlsProtocols Tls11Client = 512;
	public const TlsProtocols Tls11Server = 256;
	public const TlsProtocols Tls11 = 768;
	public const TlsProtocols Tls12Client = 2048;
	public const TlsProtocols Tls12Server = 1024;
	public const TlsProtocols Tls12 = 3072;
	public const TlsProtocols ClientMask = 2688;
	public const TlsProtocols ServerMask = 1344;
}

