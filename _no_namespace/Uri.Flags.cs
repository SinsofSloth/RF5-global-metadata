[FlagsAttribute] // RVA: 0xBBDE0 Offset: 0xBBEE1 VA: 0xBBDE0
private enum Uri.Flags // TypeDefIndex: 1736
{
	// Fields
	public ulong value__; // 0x0
	public const Uri.Flags Zero = 0;
	public const Uri.Flags SchemeNotCanonical = 1;
	public const Uri.Flags UserNotCanonical = 2;
	public const Uri.Flags HostNotCanonical = 4;
	public const Uri.Flags PortNotCanonical = 8;
	public const Uri.Flags PathNotCanonical = 16;
	public const Uri.Flags QueryNotCanonical = 32;
	public const Uri.Flags FragmentNotCanonical = 64;
	public const Uri.Flags CannotDisplayCanonical = 127;
	public const Uri.Flags E_UserNotCanonical = 128;
	public const Uri.Flags E_HostNotCanonical = 256;
	public const Uri.Flags E_PortNotCanonical = 512;
	public const Uri.Flags E_PathNotCanonical = 1024;
	public const Uri.Flags E_QueryNotCanonical = 2048;
	public const Uri.Flags E_FragmentNotCanonical = 4096;
	public const Uri.Flags E_CannotDisplayCanonical = 8064;
	public const Uri.Flags ShouldBeCompressed = 8192;
	public const Uri.Flags FirstSlashAbsent = 16384;
	public const Uri.Flags BackslashInPath = 32768;
	public const Uri.Flags IndexMask = 65535;
	public const Uri.Flags HostTypeMask = 458752;
	public const Uri.Flags HostNotParsed = 0;
	public const Uri.Flags IPv6HostType = 65536;
	public const Uri.Flags IPv4HostType = 131072;
	public const Uri.Flags DnsHostType = 196608;
	public const Uri.Flags UncHostType = 262144;
	public const Uri.Flags BasicHostType = 327680;
	public const Uri.Flags UnusedHostType = 393216;
	public const Uri.Flags UnknownHostType = 458752;
	public const Uri.Flags UserEscaped = 524288;
	public const Uri.Flags AuthorityFound = 1048576;
	public const Uri.Flags HasUserInfo = 2097152;
	public const Uri.Flags LoopbackHost = 4194304;
	public const Uri.Flags NotDefaultPort = 8388608;
	public const Uri.Flags UserDrivenParsing = 16777216;
	public const Uri.Flags CanonicalDnsHost = 33554432;
	public const Uri.Flags ErrorOrParsingRecursion = 67108864;
	public const Uri.Flags DosPath = 134217728;
	public const Uri.Flags UncPath = 268435456;
	public const Uri.Flags ImplicitFile = 536870912;
	public const Uri.Flags MinimalUriInfoSet = 1073741824;
	public const Uri.Flags AllUriInfoSet = 2147483648;
	public const Uri.Flags IdnHost = 4294967296;
	public const Uri.Flags HasUnicode = 8589934592;
	public const Uri.Flags HostUnicodeNormalized = 17179869184;
	public const Uri.Flags RestUnicodeNormalized = 34359738368;
	public const Uri.Flags UnicodeHost = 68719476736;
	public const Uri.Flags IntranetUri = 137438953472;
	public const Uri.Flags UseOrigUncdStrOffset = 274877906944;
	public const Uri.Flags UserIriCanonical = 549755813888;
	public const Uri.Flags PathIriCanonical = 1099511627776;
	public const Uri.Flags QueryIriCanonical = 2199023255552;
	public const Uri.Flags FragmentIriCanonical = 4398046511104;
	public const Uri.Flags IriCanonical = 8246337208320;
	public const Uri.Flags CompressedSlashes = 17592186044416;
}

