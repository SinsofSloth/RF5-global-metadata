public abstract class UriParser // TypeDefIndex: 1750
{
	// Fields
	private const UriSyntaxFlags SchemeOnlyFlags = 16;
	private static readonly Dictionary<string, UriParser> m_Table; // 0x0
	private static Dictionary<string, UriParser> m_TempTable; // 0x8
	private UriSyntaxFlags m_Flags; // 0x10
	private UriSyntaxFlags m_UpdatableFlags; // 0x14
	private bool m_UpdatableFlagsUsed; // 0x18
	private const UriSyntaxFlags c_UpdatableFlags = 33554432;
	private int m_Port; // 0x1C
	private string m_Scheme; // 0x20
	internal const int NoDefaultPort = -1;
	private const int c_InitialTableSize = 25;
	internal static UriParser HttpUri; // 0x10
	internal static UriParser HttpsUri; // 0x18
	internal static UriParser WsUri; // 0x20
	internal static UriParser WssUri; // 0x28
	internal static UriParser FtpUri; // 0x30
	internal static UriParser FileUri; // 0x38
	internal static UriParser GopherUri; // 0x40
	internal static UriParser NntpUri; // 0x48
	internal static UriParser NewsUri; // 0x50
	internal static UriParser MailToUri; // 0x58
	internal static UriParser UuidUri; // 0x60
	internal static UriParser TelnetUri; // 0x68
	internal static UriParser LdapUri; // 0x70
	internal static UriParser NetTcpUri; // 0x78
	internal static UriParser NetPipeUri; // 0x80
	internal static UriParser VsMacrosUri; // 0x88
	private static readonly UriParser.UriQuirksVersion s_QuirksVersion; // 0x90
	private const int c_MaxCapacity = 512;
	private const UriSyntaxFlags UnknownV1SyntaxFlags = 351342590;
	private static readonly UriSyntaxFlags HttpSyntaxFlags; // 0x94
	private const UriSyntaxFlags FtpSyntaxFlags = 367005533;
	private static readonly UriSyntaxFlags FileSyntaxFlags; // 0x98
	private const UriSyntaxFlags VsmacrosSyntaxFlags = 399519697;
	private const UriSyntaxFlags GopherSyntaxFlags = 337645405;
	private const UriSyntaxFlags NewsSyntaxFlags = 268435536;
	private const UriSyntaxFlags NntpSyntaxFlags = 337645405;
	private const UriSyntaxFlags TelnetSyntaxFlags = 337645405;
	private const UriSyntaxFlags LdapSyntaxFlags = 337645565;
	private const UriSyntaxFlags MailtoSyntaxFlags = 335564796;
	private const UriSyntaxFlags NetPipeSyntaxFlags = 400559729;
	private const UriSyntaxFlags NetTcpSyntaxFlags = 400559737;

	// Properties
	internal string SchemeName { get; }
	internal int DefaultPort { get; }
	internal static bool ShouldUseLegacyV2Quirks { get; }
	internal UriSyntaxFlags Flags { get; }
	internal bool IsSimple { get; }

	// Methods

	// RVA: 0x1BB9F00 Offset: 0x1BBA001 VA: 0x1BB9F00
	internal string get_SchemeName() { }

	// RVA: 0x1BB9F10 Offset: 0x1BBA011 VA: 0x1BB9F10
	internal int get_DefaultPort() { }

	// RVA: 0x1BB9F20 Offset: 0x1BBA021 VA: 0x1BB9F20 Slot: 4
	protected virtual UriParser OnNewUri() { }

	// RVA: 0x1BB9F30 Offset: 0x1BBA031 VA: 0x1BB9F30 Slot: 5
	protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

	// RVA: 0x1BB9F70 Offset: 0x1BBA071 VA: 0x1BB9F70 Slot: 6
	protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

	// RVA: 0x1BBA170 Offset: 0x1BBA271 VA: 0x1BBA170 Slot: 7
	protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	// RVA: 0x1BB9D50 Offset: 0x1BB9E51 VA: 0x1BB9D50
	internal static bool get_ShouldUseLegacyV2Quirks() { }

	// RVA: 0x1BBA3A0 Offset: 0x1BBA4A1 VA: 0x1BBA3A0
	private static void .cctor() { }

	// RVA: 0x1BBACC0 Offset: 0x1BBADC1 VA: 0x1BBACC0
	internal UriSyntaxFlags get_Flags() { }

	// RVA: 0x1BB7B50 Offset: 0x1BB7C51 VA: 0x1BB7B50
	internal bool NotAny(UriSyntaxFlags flags) { }

	// RVA: 0x1BB7AF0 Offset: 0x1BB7BF1 VA: 0x1BB7AF0
	internal bool InFact(UriSyntaxFlags flags) { }

	// RVA: 0x1BBAD30 Offset: 0x1BBAE31 VA: 0x1BBAD30
	internal bool IsAllSet(UriSyntaxFlags flags) { }

	// RVA: 0x1BBACD0 Offset: 0x1BBADD1 VA: 0x1BBACD0
	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	// RVA: 0x1BBAD90 Offset: 0x1BBAE91 VA: 0x1BBAD90
	internal void .ctor(UriSyntaxFlags flags) { }

	// RVA: 0x1BBAE10 Offset: 0x1BBAF11 VA: 0x1BBAE10
	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	// RVA: 0x1BB7A00 Offset: 0x1BB7B01 VA: 0x1BB7A00
	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	// RVA: 0x1BBB0D0 Offset: 0x1BBB1D1 VA: 0x1BBB0D0
	internal bool get_IsSimple() { }

	// RVA: 0x1BBB0E0 Offset: 0x1BBB1E1 VA: 0x1BBB0E0
	internal UriParser InternalOnNewUri() { }

	// RVA: 0x1BBB150 Offset: 0x1BBB251 VA: 0x1BBB150
	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

	// RVA: 0x1BBB160 Offset: 0x1BBB261 VA: 0x1BBB160
	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

	// RVA: 0x1BBB170 Offset: 0x1BBB271 VA: 0x1BBB170
	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }
}

