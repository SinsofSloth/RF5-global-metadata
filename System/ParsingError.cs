internal enum ParsingError // TypeDefIndex: 1746
{
	// Fields
	public int value__; // 0x0
	public const ParsingError None = 0;
	public const ParsingError BadFormat = 1;
	public const ParsingError BadScheme = 2;
	public const ParsingError BadAuthority = 3;
	public const ParsingError EmptyUriString = 4;
	public const ParsingError LastRelativeUriOkErrIndex = 4;
	public const ParsingError SchemeLimit = 5;
	public const ParsingError SizeLimit = 6;
	public const ParsingError MustRootedPath = 7;
	public const ParsingError BadHostName = 8;
	public const ParsingError NonEmptyHost = 9;
	public const ParsingError BadPort = 10;
	public const ParsingError BadAuthorityTerminator = 11;
	public const ParsingError CannotCreateRelative = 12;
}

