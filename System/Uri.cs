[TypeConverterAttribute] // RVA: 0xBBD70 Offset: 0xBBE71 VA: 0xBBD70
[Serializable]
public class Uri : ISerializable // TypeDefIndex: 1735
{
	// Fields
	public static readonly string UriSchemeFile; // 0x0
	public static readonly string UriSchemeFtp; // 0x8
	public static readonly string UriSchemeGopher; // 0x10
	public static readonly string UriSchemeHttp; // 0x18
	public static readonly string UriSchemeHttps; // 0x20
	internal static readonly string UriSchemeWs; // 0x28
	internal static readonly string UriSchemeWss; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	public static readonly string UriSchemeNetTcp; // 0x50
	public static readonly string UriSchemeNetPipe; // 0x58
	public static readonly string SchemeDelimiter; // 0x60
	private const int c_Max16BitUtf8SequenceLength = 12;
	internal const int c_MaxUriBufferSize = 65520;
	private const int c_MaxUriSchemeName = 1024;
	private string m_String; // 0x10
	private string m_originalUnicodeString; // 0x18
	private UriParser m_Syntax; // 0x20
	private string m_DnsSafeHost; // 0x28
	private Uri.Flags m_Flags; // 0x30
	private Uri.UriInfo m_Info; // 0x38
	private bool m_iriParsing; // 0x40
	private static bool s_ConfigInitialized; // 0x68
	private static bool s_ConfigInitializing; // 0x69
	private static UriIdnScope s_IdnScope; // 0x6C
	private static bool s_IriParsing; // 0x70
	private static bool useDotNetRelativeOrAbsolute; // 0x71
	private const UriKind DotNetRelativeOrAbsolute = 300;
	internal static readonly bool IsWindowsFileSystem; // 0x72
	private static object s_initLock; // 0x78
	private const UriFormat V1ToStringUnescape = 32767;
	internal const char c_DummyChar = '\xffff';
	internal const char c_EOL = '\xfffe';
	internal static readonly char[] HexLowerChars; // 0x80
	private static readonly char[] _WSchars; // 0x88

	// Properties
	private bool IsImplicitFile { get; }
	private bool IsUncOrDosPath { get; }
	private bool IsDosPath { get; }
	private bool IsUncPath { get; }
	private Uri.Flags HostType { get; }
	private UriParser Syntax { get; }
	private bool IsNotAbsoluteUri { get; }
	private bool AllowIdn { get; }
	internal bool UserDrivenParsing { get; }
	private ushort SecuredPathIndex { get; }
	public string AbsolutePath { get; }
	private string PrivateAbsolutePath { get; }
	public string AbsoluteUri { get; }
	public string LocalPath { get; }
	public string Authority { get; }
	public UriHostNameType HostNameType { get; }
	public bool IsDefaultPort { get; }
	public bool IsFile { get; }
	public bool IsLoopback { get; }
	public string PathAndQuery { get; }
	public bool IsUnc { get; }
	public string Host { get; }
	private static object InitializeLock { get; }
	public int Port { get; }
	public string Query { get; }
	public string Fragment { get; }
	public string Scheme { get; }
	private bool OriginalStringSwitched { get; }
	public string OriginalString { get; }
	public string DnsSafeHost { get; }
	public bool IsAbsoluteUri { get; }
	public bool UserEscaped { get; }
	public string UserInfo { get; }
	internal bool HasAuthority { get; }

	// Methods

	// RVA: 0x1628180 Offset: 0x1628281 VA: 0x1628180
	private bool get_IsImplicitFile() { }

	// RVA: 0x1628190 Offset: 0x1628291 VA: 0x1628190
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x16281A0 Offset: 0x16282A1 VA: 0x16281A0
	private bool get_IsDosPath() { }

	// RVA: 0x16281B0 Offset: 0x16282B1 VA: 0x16281B0
	private bool get_IsUncPath() { }

	// RVA: 0x16281C0 Offset: 0x16282C1 VA: 0x16281C0
	private Uri.Flags get_HostType() { }

	// RVA: 0x16281D0 Offset: 0x16282D1 VA: 0x16281D0
	private UriParser get_Syntax() { }

	// RVA: 0x16281E0 Offset: 0x16282E1 VA: 0x16281E0
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x16281F0 Offset: 0x16282F1 VA: 0x16281F0
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x16282B0 Offset: 0x16283B1 VA: 0x16282B0
	private bool get_AllowIdn() { }

	// RVA: 0x16283E0 Offset: 0x16284E1 VA: 0x16283E0
	private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags) { }

	// RVA: 0x1628520 Offset: 0x1628621 VA: 0x1628520
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x1628530 Offset: 0x1628631 VA: 0x1628530
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x1628540 Offset: 0x1628641 VA: 0x1628540
	private void SetUserDrivenParsing() { }

	// RVA: 0x1628560 Offset: 0x1628661 VA: 0x1628560
	private ushort get_SecuredPathIndex() { }

	// RVA: 0x16283D0 Offset: 0x16284D1 VA: 0x16283D0
	private bool NotAny(Uri.Flags flags) { }

	// RVA: 0x16285D0 Offset: 0x16286D1 VA: 0x16285D0
	private bool InFact(Uri.Flags flags) { }

	// RVA: 0x1628510 Offset: 0x1628611 VA: 0x1628510
	private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16285E0 Offset: 0x16286E1 VA: 0x16285E0
	private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16285F0 Offset: 0x16286F1 VA: 0x16285F0
	private Uri.UriInfo EnsureUriInfo() { }

	// RVA: 0x1628BC0 Offset: 0x1628CC1 VA: 0x1628BC0
	private void EnsureParseRemaining() { }

	// RVA: 0x1629A40 Offset: 0x1629B41 VA: 0x1629A40
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x1629EC0 Offset: 0x1629FC1 VA: 0x1629EC0
	public void .ctor(string uriString) { }

	// RVA: 0x162A140 Offset: 0x162A241 VA: 0x162A140
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x162A1F0 Offset: 0x162A2F1 VA: 0x162A1F0
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x162A2E0 Offset: 0x162A3E1 VA: 0x162A2E0
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x162AC20 Offset: 0x162AD21 VA: 0x162AC20
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x162AE40 Offset: 0x162AF41 VA: 0x162AE40
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	// RVA: 0x162BF40 Offset: 0x162C041 VA: 0x162BF40
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x162C060 Offset: 0x162C161 VA: 0x162C060
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C170 Offset: 0x162C271 VA: 0x162C170 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C180 Offset: 0x162C281 VA: 0x162C180
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C260 Offset: 0x162C361 VA: 0x162C260
	public string get_AbsolutePath() { }

	// RVA: 0x162C350 Offset: 0x162C451 VA: 0x162C350
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x162C440 Offset: 0x162C541 VA: 0x162C440
	public string get_AbsoluteUri() { }

	// RVA: 0x162C570 Offset: 0x162C671 VA: 0x162C570
	public string get_LocalPath() { }

	// RVA: 0x162CCE0 Offset: 0x162CDE1 VA: 0x162CCE0
	public string get_Authority() { }

	// RVA: 0x162CD80 Offset: 0x162CE81 VA: 0x162CD80
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x162CEF0 Offset: 0x162CFF1 VA: 0x162CEF0
	public bool get_IsDefaultPort() { }

	// RVA: 0x162CFE0 Offset: 0x162D0E1 VA: 0x162CFE0
	public bool get_IsFile() { }

	// RVA: 0x162D0B0 Offset: 0x162D1B1 VA: 0x162D0B0
	public bool get_IsLoopback() { }

	// RVA: 0x162D180 Offset: 0x162D281 VA: 0x162D180
	public string get_PathAndQuery() { }

	// RVA: 0x162D270 Offset: 0x162D371 VA: 0x162D270
	public bool get_IsUnc() { }

	// RVA: 0x162D310 Offset: 0x162D411 VA: 0x162D310
	public string get_Host() { }

	// RVA: 0x162D3B0 Offset: 0x162D4B1 VA: 0x162D3B0
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x162D3D0 Offset: 0x162D4D1 VA: 0x162D3D0
	private static object get_InitializeLock() { }

	// RVA: 0x162D4D0 Offset: 0x162D5D1 VA: 0x162D4D0
	private static void InitializeUriConfig() { }

	// RVA: 0x162C610 Offset: 0x162C711 VA: 0x162C610
	private string GetLocalPath() { }

	// RVA: 0x162DCF0 Offset: 0x162DDF1 VA: 0x162DCF0
	public int get_Port() { }

	// RVA: 0x162DE10 Offset: 0x162DF11 VA: 0x162DE10
	public string get_Query() { }

	// RVA: 0x162DF40 Offset: 0x162E041 VA: 0x162DF40
	public string get_Fragment() { }

	// RVA: 0x162E070 Offset: 0x162E171 VA: 0x162E070
	public string get_Scheme() { }

	// RVA: 0x162E110 Offset: 0x162E211 VA: 0x162E110
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x162B240 Offset: 0x162B341 VA: 0x162B240
	public string get_OriginalString() { }

	// RVA: 0x162E180 Offset: 0x162E281 VA: 0x162E180
	public string get_DnsSafeHost() { }

	// RVA: 0x162A2D0 Offset: 0x162A3D1 VA: 0x162A2D0
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x162E3F0 Offset: 0x162E4F1 VA: 0x162E3F0
	public bool get_UserEscaped() { }

	// RVA: 0x162E400 Offset: 0x162E501 VA: 0x162E400
	public string get_UserInfo() { }

	// RVA: 0x162E4A0 Offset: 0x162E5A1 VA: 0x162E4A0
	internal static bool IsGenDelim(char ch) { }

	// RVA: 0x162E4F0 Offset: 0x162E5F1 VA: 0x162E4F0
	public static bool CheckSchemeName(string schemeName) { }

	// RVA: 0x162E7A0 Offset: 0x162E8A1 VA: 0x162E7A0
	public static bool IsHexDigit(char character) { }

	// RVA: 0x162E7E0 Offset: 0x162E8E1 VA: 0x162E7E0
	public static int FromHex(char digit) { }

	// RVA: 0x162E8B0 Offset: 0x162E9B1 VA: 0x162E8B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x162EB40 Offset: 0x162EC41 VA: 0x162EB40 Slot: 3
	public override string ToString() { }

	// RVA: 0x162EEC0 Offset: 0x162EFC1 VA: 0x162EEC0
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x162AA50 Offset: 0x162AB51 VA: 0x162AA50
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x162EF00 Offset: 0x162F001 VA: 0x162EF00 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x162F660 Offset: 0x162F761 VA: 0x162F660
	public Uri MakeRelativeUri(Uri uri) { }

	// RVA: 0x162FCA0 Offset: 0x162FDA1 VA: 0x162FCA0
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x162FD60 Offset: 0x162FE61 VA: 0x162FD60
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x162FE50 Offset: 0x162FF51 VA: 0x162FE50
	private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x16304C0 Offset: 0x16305C1 VA: 0x16304C0
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x1630560 Offset: 0x1630661 VA: 0x1630560
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x1631D80 Offset: 0x1631E81 VA: 0x1631D80
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	// RVA: 0x1628620 Offset: 0x1628721 VA: 0x1628620
	private void CreateUriInfo(Uri.Flags cF) { }

	// RVA: 0x1629AA0 Offset: 0x1629BA1 VA: 0x1629AA0
	private void CreateHostString() { }

	// RVA: 0x16322E0 Offset: 0x16323E1 VA: 0x16322E0
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId) { }

	// RVA: 0x1631E80 Offset: 0x1631F81 VA: 0x1631E80
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x162C250 Offset: 0x162C351 VA: 0x162C250
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x1632C20 Offset: 0x1632D21 VA: 0x1632C20
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x162DBE0 Offset: 0x162DCE1 VA: 0x162DBE0
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x1633350 Offset: 0x1633451 VA: 0x1633350
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	// RVA: 0x1632D30 Offset: 0x1632E31 VA: 0x1632D30
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x1628BD0 Offset: 0x1628CD1 VA: 0x1628BD0
	private void ParseRemaining() { }

	// RVA: 0x162FF40 Offset: 0x1630041 VA: 0x162FF40
	private static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x1634950 Offset: 0x1634A51 VA: 0x1634950
	private static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) { }

	// RVA: 0x162B0D0 Offset: 0x162B1D1 VA: 0x162B0D0
	private static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) { }

	// RVA: 0x1630CC0 Offset: 0x1630DC1 VA: 0x1630CC0
	private ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost) { }

	// RVA: 0x16350E0 Offset: 0x16351E1 VA: 0x16350E0
	private void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	// RVA: 0x16354C0 Offset: 0x16355C1 VA: 0x16354C0
	private void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err) { }

	// RVA: 0x1634810 Offset: 0x1634911 VA: 0x1634810
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x1635A30 Offset: 0x1635B31 VA: 0x1635A30
	private void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16324F0 Offset: 0x16325F1 VA: 0x16324F0
	private Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16340F0 Offset: 0x16341F1 VA: 0x16340F0
	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) { }

	// RVA: 0x1635AF0 Offset: 0x1635BF1 VA: 0x1635AF0
	private static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

	// RVA: 0x162D6A0 Offset: 0x162D7A1 VA: 0x162D6A0
	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	// RVA: 0x162EA40 Offset: 0x162EB41 VA: 0x162EA40
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x162B2A0 Offset: 0x162B3A1 VA: 0x162B2A0
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x162F990 Offset: 0x162FA91 VA: 0x162F990
	private static string PathDifference(string path1, string path2, bool compareCase) { }

	// RVA: 0x1635D60 Offset: 0x1635E61 VA: 0x1635D60
	internal bool get_HasAuthority() { }

	// RVA: 0x1630C70 Offset: 0x1630D71 VA: 0x1630C70
	private static bool IsLWS(char ch) { }

	// RVA: 0x162E6D0 Offset: 0x162E7D1 VA: 0x162E6D0
	private static bool IsAsciiLetter(char character) { }

	// RVA: 0x162E700 Offset: 0x162E801 VA: 0x162E700
	internal static bool IsAsciiLetterOrDigit(char character) { }

	// RVA: 0x1635D70 Offset: 0x1635E71 VA: 0x1635D70
	internal static bool IsBidiControlCharacter(char ch) { }

	// RVA: 0x1635800 Offset: 0x1635901 VA: 0x1635800
	internal static string StripBidiControlCharacter(char* strToClean, int start, int length) { }

	// RVA: 0x1629F70 Offset: 0x162A071 VA: 0x1629F70
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x1635DC0 Offset: 0x1635EC1 VA: 0x1635DC0
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0x16365C0 Offset: 0x16366C1 VA: 0x16365C0
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x1636680 Offset: 0x1636781 VA: 0x1636680
	private bool CheckForUnicode(string data) { }

	// RVA: 0x16367B0 Offset: 0x16368B1 VA: 0x16367B0
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x162F570 Offset: 0x162F671 VA: 0x162F570
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0x1632A30 Offset: 0x1632B31 VA: 0x1632A30
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x1636E90 Offset: 0x1636F91 VA: 0x1636E90
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x16348F0 Offset: 0x16349F1 VA: 0x16348F0
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x1637040 Offset: 0x1637141 VA: 0x1637040
	private void .ctor(Uri.Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x16369B0 Offset: 0x1636AB1 VA: 0x16369B0
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0x162A480 Offset: 0x162A581 VA: 0x162A480
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	// RVA: 0x1636C70 Offset: 0x1636D71 VA: 0x1636C70
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x162EC50 Offset: 0x162ED51 VA: 0x162EC50
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x162AAA0 Offset: 0x162ABA1 VA: 0x162AAA0
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x16370A0 Offset: 0x16371A1 VA: 0x16370A0
	private static void .cctor() { }
}

[TypeConverterAttribute] // RVA: 0xBBD70 Offset: 0xBBE71 VA: 0xBBD70
[Serializable]
public class Uri : ISerializable // TypeDefIndex: 1735
{
	// Fields
	public static readonly string UriSchemeFile; // 0x0
	public static readonly string UriSchemeFtp; // 0x8
	public static readonly string UriSchemeGopher; // 0x10
	public static readonly string UriSchemeHttp; // 0x18
	public static readonly string UriSchemeHttps; // 0x20
	internal static readonly string UriSchemeWs; // 0x28
	internal static readonly string UriSchemeWss; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	public static readonly string UriSchemeNetTcp; // 0x50
	public static readonly string UriSchemeNetPipe; // 0x58
	public static readonly string SchemeDelimiter; // 0x60
	private const int c_Max16BitUtf8SequenceLength = 12;
	internal const int c_MaxUriBufferSize = 65520;
	private const int c_MaxUriSchemeName = 1024;
	private string m_String; // 0x10
	private string m_originalUnicodeString; // 0x18
	private UriParser m_Syntax; // 0x20
	private string m_DnsSafeHost; // 0x28
	private Uri.Flags m_Flags; // 0x30
	private Uri.UriInfo m_Info; // 0x38
	private bool m_iriParsing; // 0x40
	private static bool s_ConfigInitialized; // 0x68
	private static bool s_ConfigInitializing; // 0x69
	private static UriIdnScope s_IdnScope; // 0x6C
	private static bool s_IriParsing; // 0x70
	private static bool useDotNetRelativeOrAbsolute; // 0x71
	private const UriKind DotNetRelativeOrAbsolute = 300;
	internal static readonly bool IsWindowsFileSystem; // 0x72
	private static object s_initLock; // 0x78
	private const UriFormat V1ToStringUnescape = 32767;
	internal const char c_DummyChar = '\xffff';
	internal const char c_EOL = '\xfffe';
	internal static readonly char[] HexLowerChars; // 0x80
	private static readonly char[] _WSchars; // 0x88

	// Properties
	private bool IsImplicitFile { get; }
	private bool IsUncOrDosPath { get; }
	private bool IsDosPath { get; }
	private bool IsUncPath { get; }
	private Uri.Flags HostType { get; }
	private UriParser Syntax { get; }
	private bool IsNotAbsoluteUri { get; }
	private bool AllowIdn { get; }
	internal bool UserDrivenParsing { get; }
	private ushort SecuredPathIndex { get; }
	public string AbsolutePath { get; }
	private string PrivateAbsolutePath { get; }
	public string AbsoluteUri { get; }
	public string LocalPath { get; }
	public string Authority { get; }
	public UriHostNameType HostNameType { get; }
	public bool IsDefaultPort { get; }
	public bool IsFile { get; }
	public bool IsLoopback { get; }
	public string PathAndQuery { get; }
	public bool IsUnc { get; }
	public string Host { get; }
	private static object InitializeLock { get; }
	public int Port { get; }
	public string Query { get; }
	public string Fragment { get; }
	public string Scheme { get; }
	private bool OriginalStringSwitched { get; }
	public string OriginalString { get; }
	public string DnsSafeHost { get; }
	public bool IsAbsoluteUri { get; }
	public bool UserEscaped { get; }
	public string UserInfo { get; }
	internal bool HasAuthority { get; }

	// Methods

	// RVA: 0x1628180 Offset: 0x1628281 VA: 0x1628180
	private bool get_IsImplicitFile() { }

	// RVA: 0x1628190 Offset: 0x1628291 VA: 0x1628190
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x16281A0 Offset: 0x16282A1 VA: 0x16281A0
	private bool get_IsDosPath() { }

	// RVA: 0x16281B0 Offset: 0x16282B1 VA: 0x16281B0
	private bool get_IsUncPath() { }

	// RVA: 0x16281C0 Offset: 0x16282C1 VA: 0x16281C0
	private Uri.Flags get_HostType() { }

	// RVA: 0x16281D0 Offset: 0x16282D1 VA: 0x16281D0
	private UriParser get_Syntax() { }

	// RVA: 0x16281E0 Offset: 0x16282E1 VA: 0x16281E0
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x16281F0 Offset: 0x16282F1 VA: 0x16281F0
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x16282B0 Offset: 0x16283B1 VA: 0x16282B0
	private bool get_AllowIdn() { }

	// RVA: 0x16283E0 Offset: 0x16284E1 VA: 0x16283E0
	private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags) { }

	// RVA: 0x1628520 Offset: 0x1628621 VA: 0x1628520
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x1628530 Offset: 0x1628631 VA: 0x1628530
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x1628540 Offset: 0x1628641 VA: 0x1628540
	private void SetUserDrivenParsing() { }

	// RVA: 0x1628560 Offset: 0x1628661 VA: 0x1628560
	private ushort get_SecuredPathIndex() { }

	// RVA: 0x16283D0 Offset: 0x16284D1 VA: 0x16283D0
	private bool NotAny(Uri.Flags flags) { }

	// RVA: 0x16285D0 Offset: 0x16286D1 VA: 0x16285D0
	private bool InFact(Uri.Flags flags) { }

	// RVA: 0x1628510 Offset: 0x1628611 VA: 0x1628510
	private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16285E0 Offset: 0x16286E1 VA: 0x16285E0
	private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16285F0 Offset: 0x16286F1 VA: 0x16285F0
	private Uri.UriInfo EnsureUriInfo() { }

	// RVA: 0x1628BC0 Offset: 0x1628CC1 VA: 0x1628BC0
	private void EnsureParseRemaining() { }

	// RVA: 0x1629A40 Offset: 0x1629B41 VA: 0x1629A40
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x1629EC0 Offset: 0x1629FC1 VA: 0x1629EC0
	public void .ctor(string uriString) { }

	// RVA: 0x162A140 Offset: 0x162A241 VA: 0x162A140
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x162A1F0 Offset: 0x162A2F1 VA: 0x162A1F0
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x162A2E0 Offset: 0x162A3E1 VA: 0x162A2E0
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x162AC20 Offset: 0x162AD21 VA: 0x162AC20
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x162AE40 Offset: 0x162AF41 VA: 0x162AE40
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	// RVA: 0x162BF40 Offset: 0x162C041 VA: 0x162BF40
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x162C060 Offset: 0x162C161 VA: 0x162C060
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C170 Offset: 0x162C271 VA: 0x162C170 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C180 Offset: 0x162C281 VA: 0x162C180
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C260 Offset: 0x162C361 VA: 0x162C260
	public string get_AbsolutePath() { }

	// RVA: 0x162C350 Offset: 0x162C451 VA: 0x162C350
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x162C440 Offset: 0x162C541 VA: 0x162C440
	public string get_AbsoluteUri() { }

	// RVA: 0x162C570 Offset: 0x162C671 VA: 0x162C570
	public string get_LocalPath() { }

	// RVA: 0x162CCE0 Offset: 0x162CDE1 VA: 0x162CCE0
	public string get_Authority() { }

	// RVA: 0x162CD80 Offset: 0x162CE81 VA: 0x162CD80
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x162CEF0 Offset: 0x162CFF1 VA: 0x162CEF0
	public bool get_IsDefaultPort() { }

	// RVA: 0x162CFE0 Offset: 0x162D0E1 VA: 0x162CFE0
	public bool get_IsFile() { }

	// RVA: 0x162D0B0 Offset: 0x162D1B1 VA: 0x162D0B0
	public bool get_IsLoopback() { }

	// RVA: 0x162D180 Offset: 0x162D281 VA: 0x162D180
	public string get_PathAndQuery() { }

	// RVA: 0x162D270 Offset: 0x162D371 VA: 0x162D270
	public bool get_IsUnc() { }

	// RVA: 0x162D310 Offset: 0x162D411 VA: 0x162D310
	public string get_Host() { }

	// RVA: 0x162D3B0 Offset: 0x162D4B1 VA: 0x162D3B0
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x162D3D0 Offset: 0x162D4D1 VA: 0x162D3D0
	private static object get_InitializeLock() { }

	// RVA: 0x162D4D0 Offset: 0x162D5D1 VA: 0x162D4D0
	private static void InitializeUriConfig() { }

	// RVA: 0x162C610 Offset: 0x162C711 VA: 0x162C610
	private string GetLocalPath() { }

	// RVA: 0x162DCF0 Offset: 0x162DDF1 VA: 0x162DCF0
	public int get_Port() { }

	// RVA: 0x162DE10 Offset: 0x162DF11 VA: 0x162DE10
	public string get_Query() { }

	// RVA: 0x162DF40 Offset: 0x162E041 VA: 0x162DF40
	public string get_Fragment() { }

	// RVA: 0x162E070 Offset: 0x162E171 VA: 0x162E070
	public string get_Scheme() { }

	// RVA: 0x162E110 Offset: 0x162E211 VA: 0x162E110
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x162B240 Offset: 0x162B341 VA: 0x162B240
	public string get_OriginalString() { }

	// RVA: 0x162E180 Offset: 0x162E281 VA: 0x162E180
	public string get_DnsSafeHost() { }

	// RVA: 0x162A2D0 Offset: 0x162A3D1 VA: 0x162A2D0
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x162E3F0 Offset: 0x162E4F1 VA: 0x162E3F0
	public bool get_UserEscaped() { }

	// RVA: 0x162E400 Offset: 0x162E501 VA: 0x162E400
	public string get_UserInfo() { }

	// RVA: 0x162E4A0 Offset: 0x162E5A1 VA: 0x162E4A0
	internal static bool IsGenDelim(char ch) { }

	// RVA: 0x162E4F0 Offset: 0x162E5F1 VA: 0x162E4F0
	public static bool CheckSchemeName(string schemeName) { }

	// RVA: 0x162E7A0 Offset: 0x162E8A1 VA: 0x162E7A0
	public static bool IsHexDigit(char character) { }

	// RVA: 0x162E7E0 Offset: 0x162E8E1 VA: 0x162E7E0
	public static int FromHex(char digit) { }

	// RVA: 0x162E8B0 Offset: 0x162E9B1 VA: 0x162E8B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x162EB40 Offset: 0x162EC41 VA: 0x162EB40 Slot: 3
	public override string ToString() { }

	// RVA: 0x162EEC0 Offset: 0x162EFC1 VA: 0x162EEC0
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x162AA50 Offset: 0x162AB51 VA: 0x162AA50
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x162EF00 Offset: 0x162F001 VA: 0x162EF00 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x162F660 Offset: 0x162F761 VA: 0x162F660
	public Uri MakeRelativeUri(Uri uri) { }

	// RVA: 0x162FCA0 Offset: 0x162FDA1 VA: 0x162FCA0
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x162FD60 Offset: 0x162FE61 VA: 0x162FD60
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x162FE50 Offset: 0x162FF51 VA: 0x162FE50
	private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x16304C0 Offset: 0x16305C1 VA: 0x16304C0
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x1630560 Offset: 0x1630661 VA: 0x1630560
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x1631D80 Offset: 0x1631E81 VA: 0x1631D80
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	// RVA: 0x1628620 Offset: 0x1628721 VA: 0x1628620
	private void CreateUriInfo(Uri.Flags cF) { }

	// RVA: 0x1629AA0 Offset: 0x1629BA1 VA: 0x1629AA0
	private void CreateHostString() { }

	// RVA: 0x16322E0 Offset: 0x16323E1 VA: 0x16322E0
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId) { }

	// RVA: 0x1631E80 Offset: 0x1631F81 VA: 0x1631E80
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x162C250 Offset: 0x162C351 VA: 0x162C250
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x1632C20 Offset: 0x1632D21 VA: 0x1632C20
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x162DBE0 Offset: 0x162DCE1 VA: 0x162DBE0
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x1633350 Offset: 0x1633451 VA: 0x1633350
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	// RVA: 0x1632D30 Offset: 0x1632E31 VA: 0x1632D30
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x1628BD0 Offset: 0x1628CD1 VA: 0x1628BD0
	private void ParseRemaining() { }

	// RVA: 0x162FF40 Offset: 0x1630041 VA: 0x162FF40
	private static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x1634950 Offset: 0x1634A51 VA: 0x1634950
	private static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) { }

	// RVA: 0x162B0D0 Offset: 0x162B1D1 VA: 0x162B0D0
	private static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) { }

	// RVA: 0x1630CC0 Offset: 0x1630DC1 VA: 0x1630CC0
	private ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost) { }

	// RVA: 0x16350E0 Offset: 0x16351E1 VA: 0x16350E0
	private void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	// RVA: 0x16354C0 Offset: 0x16355C1 VA: 0x16354C0
	private void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err) { }

	// RVA: 0x1634810 Offset: 0x1634911 VA: 0x1634810
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x1635A30 Offset: 0x1635B31 VA: 0x1635A30
	private void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16324F0 Offset: 0x16325F1 VA: 0x16324F0
	private Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16340F0 Offset: 0x16341F1 VA: 0x16340F0
	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) { }

	// RVA: 0x1635AF0 Offset: 0x1635BF1 VA: 0x1635AF0
	private static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

	// RVA: 0x162D6A0 Offset: 0x162D7A1 VA: 0x162D6A0
	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	// RVA: 0x162EA40 Offset: 0x162EB41 VA: 0x162EA40
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x162B2A0 Offset: 0x162B3A1 VA: 0x162B2A0
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x162F990 Offset: 0x162FA91 VA: 0x162F990
	private static string PathDifference(string path1, string path2, bool compareCase) { }

	// RVA: 0x1635D60 Offset: 0x1635E61 VA: 0x1635D60
	internal bool get_HasAuthority() { }

	// RVA: 0x1630C70 Offset: 0x1630D71 VA: 0x1630C70
	private static bool IsLWS(char ch) { }

	// RVA: 0x162E6D0 Offset: 0x162E7D1 VA: 0x162E6D0
	private static bool IsAsciiLetter(char character) { }

	// RVA: 0x162E700 Offset: 0x162E801 VA: 0x162E700
	internal static bool IsAsciiLetterOrDigit(char character) { }

	// RVA: 0x1635D70 Offset: 0x1635E71 VA: 0x1635D70
	internal static bool IsBidiControlCharacter(char ch) { }

	// RVA: 0x1635800 Offset: 0x1635901 VA: 0x1635800
	internal static string StripBidiControlCharacter(char* strToClean, int start, int length) { }

	// RVA: 0x1629F70 Offset: 0x162A071 VA: 0x1629F70
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x1635DC0 Offset: 0x1635EC1 VA: 0x1635DC0
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0x16365C0 Offset: 0x16366C1 VA: 0x16365C0
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x1636680 Offset: 0x1636781 VA: 0x1636680
	private bool CheckForUnicode(string data) { }

	// RVA: 0x16367B0 Offset: 0x16368B1 VA: 0x16367B0
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x162F570 Offset: 0x162F671 VA: 0x162F570
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0x1632A30 Offset: 0x1632B31 VA: 0x1632A30
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x1636E90 Offset: 0x1636F91 VA: 0x1636E90
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x16348F0 Offset: 0x16349F1 VA: 0x16348F0
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x1637040 Offset: 0x1637141 VA: 0x1637040
	private void .ctor(Uri.Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x16369B0 Offset: 0x1636AB1 VA: 0x16369B0
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0x162A480 Offset: 0x162A581 VA: 0x162A480
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	// RVA: 0x1636C70 Offset: 0x1636D71 VA: 0x1636C70
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x162EC50 Offset: 0x162ED51 VA: 0x162EC50
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x162AAA0 Offset: 0x162ABA1 VA: 0x162AAA0
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x16370A0 Offset: 0x16371A1 VA: 0x16370A0
	private static void .cctor() { }
}

[TypeConverterAttribute] // RVA: 0xBBD70 Offset: 0xBBE71 VA: 0xBBD70
[Serializable]
public class Uri : ISerializable // TypeDefIndex: 1735
{
	// Fields
	public static readonly string UriSchemeFile; // 0x0
	public static readonly string UriSchemeFtp; // 0x8
	public static readonly string UriSchemeGopher; // 0x10
	public static readonly string UriSchemeHttp; // 0x18
	public static readonly string UriSchemeHttps; // 0x20
	internal static readonly string UriSchemeWs; // 0x28
	internal static readonly string UriSchemeWss; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	public static readonly string UriSchemeNetTcp; // 0x50
	public static readonly string UriSchemeNetPipe; // 0x58
	public static readonly string SchemeDelimiter; // 0x60
	private const int c_Max16BitUtf8SequenceLength = 12;
	internal const int c_MaxUriBufferSize = 65520;
	private const int c_MaxUriSchemeName = 1024;
	private string m_String; // 0x10
	private string m_originalUnicodeString; // 0x18
	private UriParser m_Syntax; // 0x20
	private string m_DnsSafeHost; // 0x28
	private Uri.Flags m_Flags; // 0x30
	private Uri.UriInfo m_Info; // 0x38
	private bool m_iriParsing; // 0x40
	private static bool s_ConfigInitialized; // 0x68
	private static bool s_ConfigInitializing; // 0x69
	private static UriIdnScope s_IdnScope; // 0x6C
	private static bool s_IriParsing; // 0x70
	private static bool useDotNetRelativeOrAbsolute; // 0x71
	private const UriKind DotNetRelativeOrAbsolute = 300;
	internal static readonly bool IsWindowsFileSystem; // 0x72
	private static object s_initLock; // 0x78
	private const UriFormat V1ToStringUnescape = 32767;
	internal const char c_DummyChar = '\xffff';
	internal const char c_EOL = '\xfffe';
	internal static readonly char[] HexLowerChars; // 0x80
	private static readonly char[] _WSchars; // 0x88

	// Properties
	private bool IsImplicitFile { get; }
	private bool IsUncOrDosPath { get; }
	private bool IsDosPath { get; }
	private bool IsUncPath { get; }
	private Uri.Flags HostType { get; }
	private UriParser Syntax { get; }
	private bool IsNotAbsoluteUri { get; }
	private bool AllowIdn { get; }
	internal bool UserDrivenParsing { get; }
	private ushort SecuredPathIndex { get; }
	public string AbsolutePath { get; }
	private string PrivateAbsolutePath { get; }
	public string AbsoluteUri { get; }
	public string LocalPath { get; }
	public string Authority { get; }
	public UriHostNameType HostNameType { get; }
	public bool IsDefaultPort { get; }
	public bool IsFile { get; }
	public bool IsLoopback { get; }
	public string PathAndQuery { get; }
	public bool IsUnc { get; }
	public string Host { get; }
	private static object InitializeLock { get; }
	public int Port { get; }
	public string Query { get; }
	public string Fragment { get; }
	public string Scheme { get; }
	private bool OriginalStringSwitched { get; }
	public string OriginalString { get; }
	public string DnsSafeHost { get; }
	public bool IsAbsoluteUri { get; }
	public bool UserEscaped { get; }
	public string UserInfo { get; }
	internal bool HasAuthority { get; }

	// Methods

	// RVA: 0x1628180 Offset: 0x1628281 VA: 0x1628180
	private bool get_IsImplicitFile() { }

	// RVA: 0x1628190 Offset: 0x1628291 VA: 0x1628190
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x16281A0 Offset: 0x16282A1 VA: 0x16281A0
	private bool get_IsDosPath() { }

	// RVA: 0x16281B0 Offset: 0x16282B1 VA: 0x16281B0
	private bool get_IsUncPath() { }

	// RVA: 0x16281C0 Offset: 0x16282C1 VA: 0x16281C0
	private Uri.Flags get_HostType() { }

	// RVA: 0x16281D0 Offset: 0x16282D1 VA: 0x16281D0
	private UriParser get_Syntax() { }

	// RVA: 0x16281E0 Offset: 0x16282E1 VA: 0x16281E0
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x16281F0 Offset: 0x16282F1 VA: 0x16281F0
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x16282B0 Offset: 0x16283B1 VA: 0x16282B0
	private bool get_AllowIdn() { }

	// RVA: 0x16283E0 Offset: 0x16284E1 VA: 0x16283E0
	private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags) { }

	// RVA: 0x1628520 Offset: 0x1628621 VA: 0x1628520
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x1628530 Offset: 0x1628631 VA: 0x1628530
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x1628540 Offset: 0x1628641 VA: 0x1628540
	private void SetUserDrivenParsing() { }

	// RVA: 0x1628560 Offset: 0x1628661 VA: 0x1628560
	private ushort get_SecuredPathIndex() { }

	// RVA: 0x16283D0 Offset: 0x16284D1 VA: 0x16283D0
	private bool NotAny(Uri.Flags flags) { }

	// RVA: 0x16285D0 Offset: 0x16286D1 VA: 0x16285D0
	private bool InFact(Uri.Flags flags) { }

	// RVA: 0x1628510 Offset: 0x1628611 VA: 0x1628510
	private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16285E0 Offset: 0x16286E1 VA: 0x16285E0
	private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16285F0 Offset: 0x16286F1 VA: 0x16285F0
	private Uri.UriInfo EnsureUriInfo() { }

	// RVA: 0x1628BC0 Offset: 0x1628CC1 VA: 0x1628BC0
	private void EnsureParseRemaining() { }

	// RVA: 0x1629A40 Offset: 0x1629B41 VA: 0x1629A40
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x1629EC0 Offset: 0x1629FC1 VA: 0x1629EC0
	public void .ctor(string uriString) { }

	// RVA: 0x162A140 Offset: 0x162A241 VA: 0x162A140
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x162A1F0 Offset: 0x162A2F1 VA: 0x162A1F0
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x162A2E0 Offset: 0x162A3E1 VA: 0x162A2E0
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x162AC20 Offset: 0x162AD21 VA: 0x162AC20
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x162AE40 Offset: 0x162AF41 VA: 0x162AE40
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	// RVA: 0x162BF40 Offset: 0x162C041 VA: 0x162BF40
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x162C060 Offset: 0x162C161 VA: 0x162C060
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C170 Offset: 0x162C271 VA: 0x162C170 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C180 Offset: 0x162C281 VA: 0x162C180
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C260 Offset: 0x162C361 VA: 0x162C260
	public string get_AbsolutePath() { }

	// RVA: 0x162C350 Offset: 0x162C451 VA: 0x162C350
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x162C440 Offset: 0x162C541 VA: 0x162C440
	public string get_AbsoluteUri() { }

	// RVA: 0x162C570 Offset: 0x162C671 VA: 0x162C570
	public string get_LocalPath() { }

	// RVA: 0x162CCE0 Offset: 0x162CDE1 VA: 0x162CCE0
	public string get_Authority() { }

	// RVA: 0x162CD80 Offset: 0x162CE81 VA: 0x162CD80
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x162CEF0 Offset: 0x162CFF1 VA: 0x162CEF0
	public bool get_IsDefaultPort() { }

	// RVA: 0x162CFE0 Offset: 0x162D0E1 VA: 0x162CFE0
	public bool get_IsFile() { }

	// RVA: 0x162D0B0 Offset: 0x162D1B1 VA: 0x162D0B0
	public bool get_IsLoopback() { }

	// RVA: 0x162D180 Offset: 0x162D281 VA: 0x162D180
	public string get_PathAndQuery() { }

	// RVA: 0x162D270 Offset: 0x162D371 VA: 0x162D270
	public bool get_IsUnc() { }

	// RVA: 0x162D310 Offset: 0x162D411 VA: 0x162D310
	public string get_Host() { }

	// RVA: 0x162D3B0 Offset: 0x162D4B1 VA: 0x162D3B0
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x162D3D0 Offset: 0x162D4D1 VA: 0x162D3D0
	private static object get_InitializeLock() { }

	// RVA: 0x162D4D0 Offset: 0x162D5D1 VA: 0x162D4D0
	private static void InitializeUriConfig() { }

	// RVA: 0x162C610 Offset: 0x162C711 VA: 0x162C610
	private string GetLocalPath() { }

	// RVA: 0x162DCF0 Offset: 0x162DDF1 VA: 0x162DCF0
	public int get_Port() { }

	// RVA: 0x162DE10 Offset: 0x162DF11 VA: 0x162DE10
	public string get_Query() { }

	// RVA: 0x162DF40 Offset: 0x162E041 VA: 0x162DF40
	public string get_Fragment() { }

	// RVA: 0x162E070 Offset: 0x162E171 VA: 0x162E070
	public string get_Scheme() { }

	// RVA: 0x162E110 Offset: 0x162E211 VA: 0x162E110
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x162B240 Offset: 0x162B341 VA: 0x162B240
	public string get_OriginalString() { }

	// RVA: 0x162E180 Offset: 0x162E281 VA: 0x162E180
	public string get_DnsSafeHost() { }

	// RVA: 0x162A2D0 Offset: 0x162A3D1 VA: 0x162A2D0
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x162E3F0 Offset: 0x162E4F1 VA: 0x162E3F0
	public bool get_UserEscaped() { }

	// RVA: 0x162E400 Offset: 0x162E501 VA: 0x162E400
	public string get_UserInfo() { }

	// RVA: 0x162E4A0 Offset: 0x162E5A1 VA: 0x162E4A0
	internal static bool IsGenDelim(char ch) { }

	// RVA: 0x162E4F0 Offset: 0x162E5F1 VA: 0x162E4F0
	public static bool CheckSchemeName(string schemeName) { }

	// RVA: 0x162E7A0 Offset: 0x162E8A1 VA: 0x162E7A0
	public static bool IsHexDigit(char character) { }

	// RVA: 0x162E7E0 Offset: 0x162E8E1 VA: 0x162E7E0
	public static int FromHex(char digit) { }

	// RVA: 0x162E8B0 Offset: 0x162E9B1 VA: 0x162E8B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x162EB40 Offset: 0x162EC41 VA: 0x162EB40 Slot: 3
	public override string ToString() { }

	// RVA: 0x162EEC0 Offset: 0x162EFC1 VA: 0x162EEC0
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x162AA50 Offset: 0x162AB51 VA: 0x162AA50
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x162EF00 Offset: 0x162F001 VA: 0x162EF00 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x162F660 Offset: 0x162F761 VA: 0x162F660
	public Uri MakeRelativeUri(Uri uri) { }

	// RVA: 0x162FCA0 Offset: 0x162FDA1 VA: 0x162FCA0
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x162FD60 Offset: 0x162FE61 VA: 0x162FD60
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x162FE50 Offset: 0x162FF51 VA: 0x162FE50
	private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x16304C0 Offset: 0x16305C1 VA: 0x16304C0
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x1630560 Offset: 0x1630661 VA: 0x1630560
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x1631D80 Offset: 0x1631E81 VA: 0x1631D80
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	// RVA: 0x1628620 Offset: 0x1628721 VA: 0x1628620
	private void CreateUriInfo(Uri.Flags cF) { }

	// RVA: 0x1629AA0 Offset: 0x1629BA1 VA: 0x1629AA0
	private void CreateHostString() { }

	// RVA: 0x16322E0 Offset: 0x16323E1 VA: 0x16322E0
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId) { }

	// RVA: 0x1631E80 Offset: 0x1631F81 VA: 0x1631E80
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x162C250 Offset: 0x162C351 VA: 0x162C250
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x1632C20 Offset: 0x1632D21 VA: 0x1632C20
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x162DBE0 Offset: 0x162DCE1 VA: 0x162DBE0
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x1633350 Offset: 0x1633451 VA: 0x1633350
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	// RVA: 0x1632D30 Offset: 0x1632E31 VA: 0x1632D30
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x1628BD0 Offset: 0x1628CD1 VA: 0x1628BD0
	private void ParseRemaining() { }

	// RVA: 0x162FF40 Offset: 0x1630041 VA: 0x162FF40
	private static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x1634950 Offset: 0x1634A51 VA: 0x1634950
	private static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) { }

	// RVA: 0x162B0D0 Offset: 0x162B1D1 VA: 0x162B0D0
	private static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) { }

	// RVA: 0x1630CC0 Offset: 0x1630DC1 VA: 0x1630CC0
	private ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost) { }

	// RVA: 0x16350E0 Offset: 0x16351E1 VA: 0x16350E0
	private void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	// RVA: 0x16354C0 Offset: 0x16355C1 VA: 0x16354C0
	private void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err) { }

	// RVA: 0x1634810 Offset: 0x1634911 VA: 0x1634810
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x1635A30 Offset: 0x1635B31 VA: 0x1635A30
	private void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16324F0 Offset: 0x16325F1 VA: 0x16324F0
	private Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16340F0 Offset: 0x16341F1 VA: 0x16340F0
	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) { }

	// RVA: 0x1635AF0 Offset: 0x1635BF1 VA: 0x1635AF0
	private static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

	// RVA: 0x162D6A0 Offset: 0x162D7A1 VA: 0x162D6A0
	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	// RVA: 0x162EA40 Offset: 0x162EB41 VA: 0x162EA40
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x162B2A0 Offset: 0x162B3A1 VA: 0x162B2A0
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x162F990 Offset: 0x162FA91 VA: 0x162F990
	private static string PathDifference(string path1, string path2, bool compareCase) { }

	// RVA: 0x1635D60 Offset: 0x1635E61 VA: 0x1635D60
	internal bool get_HasAuthority() { }

	// RVA: 0x1630C70 Offset: 0x1630D71 VA: 0x1630C70
	private static bool IsLWS(char ch) { }

	// RVA: 0x162E6D0 Offset: 0x162E7D1 VA: 0x162E6D0
	private static bool IsAsciiLetter(char character) { }

	// RVA: 0x162E700 Offset: 0x162E801 VA: 0x162E700
	internal static bool IsAsciiLetterOrDigit(char character) { }

	// RVA: 0x1635D70 Offset: 0x1635E71 VA: 0x1635D70
	internal static bool IsBidiControlCharacter(char ch) { }

	// RVA: 0x1635800 Offset: 0x1635901 VA: 0x1635800
	internal static string StripBidiControlCharacter(char* strToClean, int start, int length) { }

	// RVA: 0x1629F70 Offset: 0x162A071 VA: 0x1629F70
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x1635DC0 Offset: 0x1635EC1 VA: 0x1635DC0
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0x16365C0 Offset: 0x16366C1 VA: 0x16365C0
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x1636680 Offset: 0x1636781 VA: 0x1636680
	private bool CheckForUnicode(string data) { }

	// RVA: 0x16367B0 Offset: 0x16368B1 VA: 0x16367B0
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x162F570 Offset: 0x162F671 VA: 0x162F570
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0x1632A30 Offset: 0x1632B31 VA: 0x1632A30
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x1636E90 Offset: 0x1636F91 VA: 0x1636E90
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x16348F0 Offset: 0x16349F1 VA: 0x16348F0
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x1637040 Offset: 0x1637141 VA: 0x1637040
	private void .ctor(Uri.Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x16369B0 Offset: 0x1636AB1 VA: 0x16369B0
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0x162A480 Offset: 0x162A581 VA: 0x162A480
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	// RVA: 0x1636C70 Offset: 0x1636D71 VA: 0x1636C70
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x162EC50 Offset: 0x162ED51 VA: 0x162EC50
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x162AAA0 Offset: 0x162ABA1 VA: 0x162AAA0
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x16370A0 Offset: 0x16371A1 VA: 0x16370A0
	private static void .cctor() { }
}

[TypeConverterAttribute] // RVA: 0xBBD70 Offset: 0xBBE71 VA: 0xBBD70
[Serializable]
public class Uri : ISerializable // TypeDefIndex: 1735
{
	// Fields
	public static readonly string UriSchemeFile; // 0x0
	public static readonly string UriSchemeFtp; // 0x8
	public static readonly string UriSchemeGopher; // 0x10
	public static readonly string UriSchemeHttp; // 0x18
	public static readonly string UriSchemeHttps; // 0x20
	internal static readonly string UriSchemeWs; // 0x28
	internal static readonly string UriSchemeWss; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	public static readonly string UriSchemeNetTcp; // 0x50
	public static readonly string UriSchemeNetPipe; // 0x58
	public static readonly string SchemeDelimiter; // 0x60
	private const int c_Max16BitUtf8SequenceLength = 12;
	internal const int c_MaxUriBufferSize = 65520;
	private const int c_MaxUriSchemeName = 1024;
	private string m_String; // 0x10
	private string m_originalUnicodeString; // 0x18
	private UriParser m_Syntax; // 0x20
	private string m_DnsSafeHost; // 0x28
	private Uri.Flags m_Flags; // 0x30
	private Uri.UriInfo m_Info; // 0x38
	private bool m_iriParsing; // 0x40
	private static bool s_ConfigInitialized; // 0x68
	private static bool s_ConfigInitializing; // 0x69
	private static UriIdnScope s_IdnScope; // 0x6C
	private static bool s_IriParsing; // 0x70
	private static bool useDotNetRelativeOrAbsolute; // 0x71
	private const UriKind DotNetRelativeOrAbsolute = 300;
	internal static readonly bool IsWindowsFileSystem; // 0x72
	private static object s_initLock; // 0x78
	private const UriFormat V1ToStringUnescape = 32767;
	internal const char c_DummyChar = '\xffff';
	internal const char c_EOL = '\xfffe';
	internal static readonly char[] HexLowerChars; // 0x80
	private static readonly char[] _WSchars; // 0x88

	// Properties
	private bool IsImplicitFile { get; }
	private bool IsUncOrDosPath { get; }
	private bool IsDosPath { get; }
	private bool IsUncPath { get; }
	private Uri.Flags HostType { get; }
	private UriParser Syntax { get; }
	private bool IsNotAbsoluteUri { get; }
	private bool AllowIdn { get; }
	internal bool UserDrivenParsing { get; }
	private ushort SecuredPathIndex { get; }
	public string AbsolutePath { get; }
	private string PrivateAbsolutePath { get; }
	public string AbsoluteUri { get; }
	public string LocalPath { get; }
	public string Authority { get; }
	public UriHostNameType HostNameType { get; }
	public bool IsDefaultPort { get; }
	public bool IsFile { get; }
	public bool IsLoopback { get; }
	public string PathAndQuery { get; }
	public bool IsUnc { get; }
	public string Host { get; }
	private static object InitializeLock { get; }
	public int Port { get; }
	public string Query { get; }
	public string Fragment { get; }
	public string Scheme { get; }
	private bool OriginalStringSwitched { get; }
	public string OriginalString { get; }
	public string DnsSafeHost { get; }
	public bool IsAbsoluteUri { get; }
	public bool UserEscaped { get; }
	public string UserInfo { get; }
	internal bool HasAuthority { get; }

	// Methods

	// RVA: 0x1628180 Offset: 0x1628281 VA: 0x1628180
	private bool get_IsImplicitFile() { }

	// RVA: 0x1628190 Offset: 0x1628291 VA: 0x1628190
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x16281A0 Offset: 0x16282A1 VA: 0x16281A0
	private bool get_IsDosPath() { }

	// RVA: 0x16281B0 Offset: 0x16282B1 VA: 0x16281B0
	private bool get_IsUncPath() { }

	// RVA: 0x16281C0 Offset: 0x16282C1 VA: 0x16281C0
	private Uri.Flags get_HostType() { }

	// RVA: 0x16281D0 Offset: 0x16282D1 VA: 0x16281D0
	private UriParser get_Syntax() { }

	// RVA: 0x16281E0 Offset: 0x16282E1 VA: 0x16281E0
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x16281F0 Offset: 0x16282F1 VA: 0x16281F0
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x16282B0 Offset: 0x16283B1 VA: 0x16282B0
	private bool get_AllowIdn() { }

	// RVA: 0x16283E0 Offset: 0x16284E1 VA: 0x16283E0
	private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags) { }

	// RVA: 0x1628520 Offset: 0x1628621 VA: 0x1628520
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x1628530 Offset: 0x1628631 VA: 0x1628530
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x1628540 Offset: 0x1628641 VA: 0x1628540
	private void SetUserDrivenParsing() { }

	// RVA: 0x1628560 Offset: 0x1628661 VA: 0x1628560
	private ushort get_SecuredPathIndex() { }

	// RVA: 0x16283D0 Offset: 0x16284D1 VA: 0x16283D0
	private bool NotAny(Uri.Flags flags) { }

	// RVA: 0x16285D0 Offset: 0x16286D1 VA: 0x16285D0
	private bool InFact(Uri.Flags flags) { }

	// RVA: 0x1628510 Offset: 0x1628611 VA: 0x1628510
	private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16285E0 Offset: 0x16286E1 VA: 0x16285E0
	private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16285F0 Offset: 0x16286F1 VA: 0x16285F0
	private Uri.UriInfo EnsureUriInfo() { }

	// RVA: 0x1628BC0 Offset: 0x1628CC1 VA: 0x1628BC0
	private void EnsureParseRemaining() { }

	// RVA: 0x1629A40 Offset: 0x1629B41 VA: 0x1629A40
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x1629EC0 Offset: 0x1629FC1 VA: 0x1629EC0
	public void .ctor(string uriString) { }

	// RVA: 0x162A140 Offset: 0x162A241 VA: 0x162A140
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x162A1F0 Offset: 0x162A2F1 VA: 0x162A1F0
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x162A2E0 Offset: 0x162A3E1 VA: 0x162A2E0
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x162AC20 Offset: 0x162AD21 VA: 0x162AC20
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x162AE40 Offset: 0x162AF41 VA: 0x162AE40
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	// RVA: 0x162BF40 Offset: 0x162C041 VA: 0x162BF40
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x162C060 Offset: 0x162C161 VA: 0x162C060
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C170 Offset: 0x162C271 VA: 0x162C170 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C180 Offset: 0x162C281 VA: 0x162C180
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C260 Offset: 0x162C361 VA: 0x162C260
	public string get_AbsolutePath() { }

	// RVA: 0x162C350 Offset: 0x162C451 VA: 0x162C350
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x162C440 Offset: 0x162C541 VA: 0x162C440
	public string get_AbsoluteUri() { }

	// RVA: 0x162C570 Offset: 0x162C671 VA: 0x162C570
	public string get_LocalPath() { }

	// RVA: 0x162CCE0 Offset: 0x162CDE1 VA: 0x162CCE0
	public string get_Authority() { }

	// RVA: 0x162CD80 Offset: 0x162CE81 VA: 0x162CD80
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x162CEF0 Offset: 0x162CFF1 VA: 0x162CEF0
	public bool get_IsDefaultPort() { }

	// RVA: 0x162CFE0 Offset: 0x162D0E1 VA: 0x162CFE0
	public bool get_IsFile() { }

	// RVA: 0x162D0B0 Offset: 0x162D1B1 VA: 0x162D0B0
	public bool get_IsLoopback() { }

	// RVA: 0x162D180 Offset: 0x162D281 VA: 0x162D180
	public string get_PathAndQuery() { }

	// RVA: 0x162D270 Offset: 0x162D371 VA: 0x162D270
	public bool get_IsUnc() { }

	// RVA: 0x162D310 Offset: 0x162D411 VA: 0x162D310
	public string get_Host() { }

	// RVA: 0x162D3B0 Offset: 0x162D4B1 VA: 0x162D3B0
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x162D3D0 Offset: 0x162D4D1 VA: 0x162D3D0
	private static object get_InitializeLock() { }

	// RVA: 0x162D4D0 Offset: 0x162D5D1 VA: 0x162D4D0
	private static void InitializeUriConfig() { }

	// RVA: 0x162C610 Offset: 0x162C711 VA: 0x162C610
	private string GetLocalPath() { }

	// RVA: 0x162DCF0 Offset: 0x162DDF1 VA: 0x162DCF0
	public int get_Port() { }

	// RVA: 0x162DE10 Offset: 0x162DF11 VA: 0x162DE10
	public string get_Query() { }

	// RVA: 0x162DF40 Offset: 0x162E041 VA: 0x162DF40
	public string get_Fragment() { }

	// RVA: 0x162E070 Offset: 0x162E171 VA: 0x162E070
	public string get_Scheme() { }

	// RVA: 0x162E110 Offset: 0x162E211 VA: 0x162E110
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x162B240 Offset: 0x162B341 VA: 0x162B240
	public string get_OriginalString() { }

	// RVA: 0x162E180 Offset: 0x162E281 VA: 0x162E180
	public string get_DnsSafeHost() { }

	// RVA: 0x162A2D0 Offset: 0x162A3D1 VA: 0x162A2D0
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x162E3F0 Offset: 0x162E4F1 VA: 0x162E3F0
	public bool get_UserEscaped() { }

	// RVA: 0x162E400 Offset: 0x162E501 VA: 0x162E400
	public string get_UserInfo() { }

	// RVA: 0x162E4A0 Offset: 0x162E5A1 VA: 0x162E4A0
	internal static bool IsGenDelim(char ch) { }

	// RVA: 0x162E4F0 Offset: 0x162E5F1 VA: 0x162E4F0
	public static bool CheckSchemeName(string schemeName) { }

	// RVA: 0x162E7A0 Offset: 0x162E8A1 VA: 0x162E7A0
	public static bool IsHexDigit(char character) { }

	// RVA: 0x162E7E0 Offset: 0x162E8E1 VA: 0x162E7E0
	public static int FromHex(char digit) { }

	// RVA: 0x162E8B0 Offset: 0x162E9B1 VA: 0x162E8B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x162EB40 Offset: 0x162EC41 VA: 0x162EB40 Slot: 3
	public override string ToString() { }

	// RVA: 0x162EEC0 Offset: 0x162EFC1 VA: 0x162EEC0
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x162AA50 Offset: 0x162AB51 VA: 0x162AA50
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x162EF00 Offset: 0x162F001 VA: 0x162EF00 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x162F660 Offset: 0x162F761 VA: 0x162F660
	public Uri MakeRelativeUri(Uri uri) { }

	// RVA: 0x162FCA0 Offset: 0x162FDA1 VA: 0x162FCA0
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x162FD60 Offset: 0x162FE61 VA: 0x162FD60
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x162FE50 Offset: 0x162FF51 VA: 0x162FE50
	private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x16304C0 Offset: 0x16305C1 VA: 0x16304C0
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x1630560 Offset: 0x1630661 VA: 0x1630560
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x1631D80 Offset: 0x1631E81 VA: 0x1631D80
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	// RVA: 0x1628620 Offset: 0x1628721 VA: 0x1628620
	private void CreateUriInfo(Uri.Flags cF) { }

	// RVA: 0x1629AA0 Offset: 0x1629BA1 VA: 0x1629AA0
	private void CreateHostString() { }

	// RVA: 0x16322E0 Offset: 0x16323E1 VA: 0x16322E0
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId) { }

	// RVA: 0x1631E80 Offset: 0x1631F81 VA: 0x1631E80
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x162C250 Offset: 0x162C351 VA: 0x162C250
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x1632C20 Offset: 0x1632D21 VA: 0x1632C20
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x162DBE0 Offset: 0x162DCE1 VA: 0x162DBE0
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x1633350 Offset: 0x1633451 VA: 0x1633350
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	// RVA: 0x1632D30 Offset: 0x1632E31 VA: 0x1632D30
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x1628BD0 Offset: 0x1628CD1 VA: 0x1628BD0
	private void ParseRemaining() { }

	// RVA: 0x162FF40 Offset: 0x1630041 VA: 0x162FF40
	private static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x1634950 Offset: 0x1634A51 VA: 0x1634950
	private static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) { }

	// RVA: 0x162B0D0 Offset: 0x162B1D1 VA: 0x162B0D0
	private static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) { }

	// RVA: 0x1630CC0 Offset: 0x1630DC1 VA: 0x1630CC0
	private ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost) { }

	// RVA: 0x16350E0 Offset: 0x16351E1 VA: 0x16350E0
	private void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	// RVA: 0x16354C0 Offset: 0x16355C1 VA: 0x16354C0
	private void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err) { }

	// RVA: 0x1634810 Offset: 0x1634911 VA: 0x1634810
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x1635A30 Offset: 0x1635B31 VA: 0x1635A30
	private void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16324F0 Offset: 0x16325F1 VA: 0x16324F0
	private Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16340F0 Offset: 0x16341F1 VA: 0x16340F0
	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) { }

	// RVA: 0x1635AF0 Offset: 0x1635BF1 VA: 0x1635AF0
	private static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

	// RVA: 0x162D6A0 Offset: 0x162D7A1 VA: 0x162D6A0
	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	// RVA: 0x162EA40 Offset: 0x162EB41 VA: 0x162EA40
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x162B2A0 Offset: 0x162B3A1 VA: 0x162B2A0
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x162F990 Offset: 0x162FA91 VA: 0x162F990
	private static string PathDifference(string path1, string path2, bool compareCase) { }

	// RVA: 0x1635D60 Offset: 0x1635E61 VA: 0x1635D60
	internal bool get_HasAuthority() { }

	// RVA: 0x1630C70 Offset: 0x1630D71 VA: 0x1630C70
	private static bool IsLWS(char ch) { }

	// RVA: 0x162E6D0 Offset: 0x162E7D1 VA: 0x162E6D0
	private static bool IsAsciiLetter(char character) { }

	// RVA: 0x162E700 Offset: 0x162E801 VA: 0x162E700
	internal static bool IsAsciiLetterOrDigit(char character) { }

	// RVA: 0x1635D70 Offset: 0x1635E71 VA: 0x1635D70
	internal static bool IsBidiControlCharacter(char ch) { }

	// RVA: 0x1635800 Offset: 0x1635901 VA: 0x1635800
	internal static string StripBidiControlCharacter(char* strToClean, int start, int length) { }

	// RVA: 0x1629F70 Offset: 0x162A071 VA: 0x1629F70
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x1635DC0 Offset: 0x1635EC1 VA: 0x1635DC0
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0x16365C0 Offset: 0x16366C1 VA: 0x16365C0
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x1636680 Offset: 0x1636781 VA: 0x1636680
	private bool CheckForUnicode(string data) { }

	// RVA: 0x16367B0 Offset: 0x16368B1 VA: 0x16367B0
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x162F570 Offset: 0x162F671 VA: 0x162F570
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0x1632A30 Offset: 0x1632B31 VA: 0x1632A30
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x1636E90 Offset: 0x1636F91 VA: 0x1636E90
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x16348F0 Offset: 0x16349F1 VA: 0x16348F0
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x1637040 Offset: 0x1637141 VA: 0x1637040
	private void .ctor(Uri.Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x16369B0 Offset: 0x1636AB1 VA: 0x16369B0
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0x162A480 Offset: 0x162A581 VA: 0x162A480
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	// RVA: 0x1636C70 Offset: 0x1636D71 VA: 0x1636C70
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x162EC50 Offset: 0x162ED51 VA: 0x162EC50
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x162AAA0 Offset: 0x162ABA1 VA: 0x162AAA0
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x16370A0 Offset: 0x16371A1 VA: 0x16370A0
	private static void .cctor() { }
}

[TypeConverterAttribute] // RVA: 0xBBD70 Offset: 0xBBE71 VA: 0xBBD70
[Serializable]
public class Uri : ISerializable // TypeDefIndex: 1735
{
	// Fields
	public static readonly string UriSchemeFile; // 0x0
	public static readonly string UriSchemeFtp; // 0x8
	public static readonly string UriSchemeGopher; // 0x10
	public static readonly string UriSchemeHttp; // 0x18
	public static readonly string UriSchemeHttps; // 0x20
	internal static readonly string UriSchemeWs; // 0x28
	internal static readonly string UriSchemeWss; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	public static readonly string UriSchemeNetTcp; // 0x50
	public static readonly string UriSchemeNetPipe; // 0x58
	public static readonly string SchemeDelimiter; // 0x60
	private const int c_Max16BitUtf8SequenceLength = 12;
	internal const int c_MaxUriBufferSize = 65520;
	private const int c_MaxUriSchemeName = 1024;
	private string m_String; // 0x10
	private string m_originalUnicodeString; // 0x18
	private UriParser m_Syntax; // 0x20
	private string m_DnsSafeHost; // 0x28
	private Uri.Flags m_Flags; // 0x30
	private Uri.UriInfo m_Info; // 0x38
	private bool m_iriParsing; // 0x40
	private static bool s_ConfigInitialized; // 0x68
	private static bool s_ConfigInitializing; // 0x69
	private static UriIdnScope s_IdnScope; // 0x6C
	private static bool s_IriParsing; // 0x70
	private static bool useDotNetRelativeOrAbsolute; // 0x71
	private const UriKind DotNetRelativeOrAbsolute = 300;
	internal static readonly bool IsWindowsFileSystem; // 0x72
	private static object s_initLock; // 0x78
	private const UriFormat V1ToStringUnescape = 32767;
	internal const char c_DummyChar = '\xffff';
	internal const char c_EOL = '\xfffe';
	internal static readonly char[] HexLowerChars; // 0x80
	private static readonly char[] _WSchars; // 0x88

	// Properties
	private bool IsImplicitFile { get; }
	private bool IsUncOrDosPath { get; }
	private bool IsDosPath { get; }
	private bool IsUncPath { get; }
	private Uri.Flags HostType { get; }
	private UriParser Syntax { get; }
	private bool IsNotAbsoluteUri { get; }
	private bool AllowIdn { get; }
	internal bool UserDrivenParsing { get; }
	private ushort SecuredPathIndex { get; }
	public string AbsolutePath { get; }
	private string PrivateAbsolutePath { get; }
	public string AbsoluteUri { get; }
	public string LocalPath { get; }
	public string Authority { get; }
	public UriHostNameType HostNameType { get; }
	public bool IsDefaultPort { get; }
	public bool IsFile { get; }
	public bool IsLoopback { get; }
	public string PathAndQuery { get; }
	public bool IsUnc { get; }
	public string Host { get; }
	private static object InitializeLock { get; }
	public int Port { get; }
	public string Query { get; }
	public string Fragment { get; }
	public string Scheme { get; }
	private bool OriginalStringSwitched { get; }
	public string OriginalString { get; }
	public string DnsSafeHost { get; }
	public bool IsAbsoluteUri { get; }
	public bool UserEscaped { get; }
	public string UserInfo { get; }
	internal bool HasAuthority { get; }

	// Methods

	// RVA: 0x1628180 Offset: 0x1628281 VA: 0x1628180
	private bool get_IsImplicitFile() { }

	// RVA: 0x1628190 Offset: 0x1628291 VA: 0x1628190
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x16281A0 Offset: 0x16282A1 VA: 0x16281A0
	private bool get_IsDosPath() { }

	// RVA: 0x16281B0 Offset: 0x16282B1 VA: 0x16281B0
	private bool get_IsUncPath() { }

	// RVA: 0x16281C0 Offset: 0x16282C1 VA: 0x16281C0
	private Uri.Flags get_HostType() { }

	// RVA: 0x16281D0 Offset: 0x16282D1 VA: 0x16281D0
	private UriParser get_Syntax() { }

	// RVA: 0x16281E0 Offset: 0x16282E1 VA: 0x16281E0
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x16281F0 Offset: 0x16282F1 VA: 0x16281F0
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x16282B0 Offset: 0x16283B1 VA: 0x16282B0
	private bool get_AllowIdn() { }

	// RVA: 0x16283E0 Offset: 0x16284E1 VA: 0x16283E0
	private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags) { }

	// RVA: 0x1628520 Offset: 0x1628621 VA: 0x1628520
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x1628530 Offset: 0x1628631 VA: 0x1628530
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x1628540 Offset: 0x1628641 VA: 0x1628540
	private void SetUserDrivenParsing() { }

	// RVA: 0x1628560 Offset: 0x1628661 VA: 0x1628560
	private ushort get_SecuredPathIndex() { }

	// RVA: 0x16283D0 Offset: 0x16284D1 VA: 0x16283D0
	private bool NotAny(Uri.Flags flags) { }

	// RVA: 0x16285D0 Offset: 0x16286D1 VA: 0x16285D0
	private bool InFact(Uri.Flags flags) { }

	// RVA: 0x1628510 Offset: 0x1628611 VA: 0x1628510
	private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16285E0 Offset: 0x16286E1 VA: 0x16285E0
	private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16285F0 Offset: 0x16286F1 VA: 0x16285F0
	private Uri.UriInfo EnsureUriInfo() { }

	// RVA: 0x1628BC0 Offset: 0x1628CC1 VA: 0x1628BC0
	private void EnsureParseRemaining() { }

	// RVA: 0x1629A40 Offset: 0x1629B41 VA: 0x1629A40
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x1629EC0 Offset: 0x1629FC1 VA: 0x1629EC0
	public void .ctor(string uriString) { }

	// RVA: 0x162A140 Offset: 0x162A241 VA: 0x162A140
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x162A1F0 Offset: 0x162A2F1 VA: 0x162A1F0
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x162A2E0 Offset: 0x162A3E1 VA: 0x162A2E0
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x162AC20 Offset: 0x162AD21 VA: 0x162AC20
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x162AE40 Offset: 0x162AF41 VA: 0x162AE40
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	// RVA: 0x162BF40 Offset: 0x162C041 VA: 0x162BF40
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x162C060 Offset: 0x162C161 VA: 0x162C060
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C170 Offset: 0x162C271 VA: 0x162C170 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C180 Offset: 0x162C281 VA: 0x162C180
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C260 Offset: 0x162C361 VA: 0x162C260
	public string get_AbsolutePath() { }

	// RVA: 0x162C350 Offset: 0x162C451 VA: 0x162C350
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x162C440 Offset: 0x162C541 VA: 0x162C440
	public string get_AbsoluteUri() { }

	// RVA: 0x162C570 Offset: 0x162C671 VA: 0x162C570
	public string get_LocalPath() { }

	// RVA: 0x162CCE0 Offset: 0x162CDE1 VA: 0x162CCE0
	public string get_Authority() { }

	// RVA: 0x162CD80 Offset: 0x162CE81 VA: 0x162CD80
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x162CEF0 Offset: 0x162CFF1 VA: 0x162CEF0
	public bool get_IsDefaultPort() { }

	// RVA: 0x162CFE0 Offset: 0x162D0E1 VA: 0x162CFE0
	public bool get_IsFile() { }

	// RVA: 0x162D0B0 Offset: 0x162D1B1 VA: 0x162D0B0
	public bool get_IsLoopback() { }

	// RVA: 0x162D180 Offset: 0x162D281 VA: 0x162D180
	public string get_PathAndQuery() { }

	// RVA: 0x162D270 Offset: 0x162D371 VA: 0x162D270
	public bool get_IsUnc() { }

	// RVA: 0x162D310 Offset: 0x162D411 VA: 0x162D310
	public string get_Host() { }

	// RVA: 0x162D3B0 Offset: 0x162D4B1 VA: 0x162D3B0
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x162D3D0 Offset: 0x162D4D1 VA: 0x162D3D0
	private static object get_InitializeLock() { }

	// RVA: 0x162D4D0 Offset: 0x162D5D1 VA: 0x162D4D0
	private static void InitializeUriConfig() { }

	// RVA: 0x162C610 Offset: 0x162C711 VA: 0x162C610
	private string GetLocalPath() { }

	// RVA: 0x162DCF0 Offset: 0x162DDF1 VA: 0x162DCF0
	public int get_Port() { }

	// RVA: 0x162DE10 Offset: 0x162DF11 VA: 0x162DE10
	public string get_Query() { }

	// RVA: 0x162DF40 Offset: 0x162E041 VA: 0x162DF40
	public string get_Fragment() { }

	// RVA: 0x162E070 Offset: 0x162E171 VA: 0x162E070
	public string get_Scheme() { }

	// RVA: 0x162E110 Offset: 0x162E211 VA: 0x162E110
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x162B240 Offset: 0x162B341 VA: 0x162B240
	public string get_OriginalString() { }

	// RVA: 0x162E180 Offset: 0x162E281 VA: 0x162E180
	public string get_DnsSafeHost() { }

	// RVA: 0x162A2D0 Offset: 0x162A3D1 VA: 0x162A2D0
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x162E3F0 Offset: 0x162E4F1 VA: 0x162E3F0
	public bool get_UserEscaped() { }

	// RVA: 0x162E400 Offset: 0x162E501 VA: 0x162E400
	public string get_UserInfo() { }

	// RVA: 0x162E4A0 Offset: 0x162E5A1 VA: 0x162E4A0
	internal static bool IsGenDelim(char ch) { }

	// RVA: 0x162E4F0 Offset: 0x162E5F1 VA: 0x162E4F0
	public static bool CheckSchemeName(string schemeName) { }

	// RVA: 0x162E7A0 Offset: 0x162E8A1 VA: 0x162E7A0
	public static bool IsHexDigit(char character) { }

	// RVA: 0x162E7E0 Offset: 0x162E8E1 VA: 0x162E7E0
	public static int FromHex(char digit) { }

	// RVA: 0x162E8B0 Offset: 0x162E9B1 VA: 0x162E8B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x162EB40 Offset: 0x162EC41 VA: 0x162EB40 Slot: 3
	public override string ToString() { }

	// RVA: 0x162EEC0 Offset: 0x162EFC1 VA: 0x162EEC0
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x162AA50 Offset: 0x162AB51 VA: 0x162AA50
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x162EF00 Offset: 0x162F001 VA: 0x162EF00 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x162F660 Offset: 0x162F761 VA: 0x162F660
	public Uri MakeRelativeUri(Uri uri) { }

	// RVA: 0x162FCA0 Offset: 0x162FDA1 VA: 0x162FCA0
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x162FD60 Offset: 0x162FE61 VA: 0x162FD60
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x162FE50 Offset: 0x162FF51 VA: 0x162FE50
	private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x16304C0 Offset: 0x16305C1 VA: 0x16304C0
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x1630560 Offset: 0x1630661 VA: 0x1630560
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x1631D80 Offset: 0x1631E81 VA: 0x1631D80
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	// RVA: 0x1628620 Offset: 0x1628721 VA: 0x1628620
	private void CreateUriInfo(Uri.Flags cF) { }

	// RVA: 0x1629AA0 Offset: 0x1629BA1 VA: 0x1629AA0
	private void CreateHostString() { }

	// RVA: 0x16322E0 Offset: 0x16323E1 VA: 0x16322E0
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId) { }

	// RVA: 0x1631E80 Offset: 0x1631F81 VA: 0x1631E80
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x162C250 Offset: 0x162C351 VA: 0x162C250
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x1632C20 Offset: 0x1632D21 VA: 0x1632C20
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x162DBE0 Offset: 0x162DCE1 VA: 0x162DBE0
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x1633350 Offset: 0x1633451 VA: 0x1633350
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	// RVA: 0x1632D30 Offset: 0x1632E31 VA: 0x1632D30
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x1628BD0 Offset: 0x1628CD1 VA: 0x1628BD0
	private void ParseRemaining() { }

	// RVA: 0x162FF40 Offset: 0x1630041 VA: 0x162FF40
	private static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x1634950 Offset: 0x1634A51 VA: 0x1634950
	private static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) { }

	// RVA: 0x162B0D0 Offset: 0x162B1D1 VA: 0x162B0D0
	private static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) { }

	// RVA: 0x1630CC0 Offset: 0x1630DC1 VA: 0x1630CC0
	private ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost) { }

	// RVA: 0x16350E0 Offset: 0x16351E1 VA: 0x16350E0
	private void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	// RVA: 0x16354C0 Offset: 0x16355C1 VA: 0x16354C0
	private void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err) { }

	// RVA: 0x1634810 Offset: 0x1634911 VA: 0x1634810
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x1635A30 Offset: 0x1635B31 VA: 0x1635A30
	private void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16324F0 Offset: 0x16325F1 VA: 0x16324F0
	private Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16340F0 Offset: 0x16341F1 VA: 0x16340F0
	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) { }

	// RVA: 0x1635AF0 Offset: 0x1635BF1 VA: 0x1635AF0
	private static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

	// RVA: 0x162D6A0 Offset: 0x162D7A1 VA: 0x162D6A0
	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	// RVA: 0x162EA40 Offset: 0x162EB41 VA: 0x162EA40
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x162B2A0 Offset: 0x162B3A1 VA: 0x162B2A0
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x162F990 Offset: 0x162FA91 VA: 0x162F990
	private static string PathDifference(string path1, string path2, bool compareCase) { }

	// RVA: 0x1635D60 Offset: 0x1635E61 VA: 0x1635D60
	internal bool get_HasAuthority() { }

	// RVA: 0x1630C70 Offset: 0x1630D71 VA: 0x1630C70
	private static bool IsLWS(char ch) { }

	// RVA: 0x162E6D0 Offset: 0x162E7D1 VA: 0x162E6D0
	private static bool IsAsciiLetter(char character) { }

	// RVA: 0x162E700 Offset: 0x162E801 VA: 0x162E700
	internal static bool IsAsciiLetterOrDigit(char character) { }

	// RVA: 0x1635D70 Offset: 0x1635E71 VA: 0x1635D70
	internal static bool IsBidiControlCharacter(char ch) { }

	// RVA: 0x1635800 Offset: 0x1635901 VA: 0x1635800
	internal static string StripBidiControlCharacter(char* strToClean, int start, int length) { }

	// RVA: 0x1629F70 Offset: 0x162A071 VA: 0x1629F70
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x1635DC0 Offset: 0x1635EC1 VA: 0x1635DC0
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0x16365C0 Offset: 0x16366C1 VA: 0x16365C0
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x1636680 Offset: 0x1636781 VA: 0x1636680
	private bool CheckForUnicode(string data) { }

	// RVA: 0x16367B0 Offset: 0x16368B1 VA: 0x16367B0
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x162F570 Offset: 0x162F671 VA: 0x162F570
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0x1632A30 Offset: 0x1632B31 VA: 0x1632A30
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x1636E90 Offset: 0x1636F91 VA: 0x1636E90
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x16348F0 Offset: 0x16349F1 VA: 0x16348F0
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x1637040 Offset: 0x1637141 VA: 0x1637040
	private void .ctor(Uri.Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x16369B0 Offset: 0x1636AB1 VA: 0x16369B0
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0x162A480 Offset: 0x162A581 VA: 0x162A480
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	// RVA: 0x1636C70 Offset: 0x1636D71 VA: 0x1636C70
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x162EC50 Offset: 0x162ED51 VA: 0x162EC50
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x162AAA0 Offset: 0x162ABA1 VA: 0x162AAA0
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x16370A0 Offset: 0x16371A1 VA: 0x16370A0
	private static void .cctor() { }
}

[TypeConverterAttribute] // RVA: 0xBBD70 Offset: 0xBBE71 VA: 0xBBD70
[Serializable]
public class Uri : ISerializable // TypeDefIndex: 1735
{
	// Fields
	public static readonly string UriSchemeFile; // 0x0
	public static readonly string UriSchemeFtp; // 0x8
	public static readonly string UriSchemeGopher; // 0x10
	public static readonly string UriSchemeHttp; // 0x18
	public static readonly string UriSchemeHttps; // 0x20
	internal static readonly string UriSchemeWs; // 0x28
	internal static readonly string UriSchemeWss; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	public static readonly string UriSchemeNetTcp; // 0x50
	public static readonly string UriSchemeNetPipe; // 0x58
	public static readonly string SchemeDelimiter; // 0x60
	private const int c_Max16BitUtf8SequenceLength = 12;
	internal const int c_MaxUriBufferSize = 65520;
	private const int c_MaxUriSchemeName = 1024;
	private string m_String; // 0x10
	private string m_originalUnicodeString; // 0x18
	private UriParser m_Syntax; // 0x20
	private string m_DnsSafeHost; // 0x28
	private Uri.Flags m_Flags; // 0x30
	private Uri.UriInfo m_Info; // 0x38
	private bool m_iriParsing; // 0x40
	private static bool s_ConfigInitialized; // 0x68
	private static bool s_ConfigInitializing; // 0x69
	private static UriIdnScope s_IdnScope; // 0x6C
	private static bool s_IriParsing; // 0x70
	private static bool useDotNetRelativeOrAbsolute; // 0x71
	private const UriKind DotNetRelativeOrAbsolute = 300;
	internal static readonly bool IsWindowsFileSystem; // 0x72
	private static object s_initLock; // 0x78
	private const UriFormat V1ToStringUnescape = 32767;
	internal const char c_DummyChar = '\xffff';
	internal const char c_EOL = '\xfffe';
	internal static readonly char[] HexLowerChars; // 0x80
	private static readonly char[] _WSchars; // 0x88

	// Properties
	private bool IsImplicitFile { get; }
	private bool IsUncOrDosPath { get; }
	private bool IsDosPath { get; }
	private bool IsUncPath { get; }
	private Uri.Flags HostType { get; }
	private UriParser Syntax { get; }
	private bool IsNotAbsoluteUri { get; }
	private bool AllowIdn { get; }
	internal bool UserDrivenParsing { get; }
	private ushort SecuredPathIndex { get; }
	public string AbsolutePath { get; }
	private string PrivateAbsolutePath { get; }
	public string AbsoluteUri { get; }
	public string LocalPath { get; }
	public string Authority { get; }
	public UriHostNameType HostNameType { get; }
	public bool IsDefaultPort { get; }
	public bool IsFile { get; }
	public bool IsLoopback { get; }
	public string PathAndQuery { get; }
	public bool IsUnc { get; }
	public string Host { get; }
	private static object InitializeLock { get; }
	public int Port { get; }
	public string Query { get; }
	public string Fragment { get; }
	public string Scheme { get; }
	private bool OriginalStringSwitched { get; }
	public string OriginalString { get; }
	public string DnsSafeHost { get; }
	public bool IsAbsoluteUri { get; }
	public bool UserEscaped { get; }
	public string UserInfo { get; }
	internal bool HasAuthority { get; }

	// Methods

	// RVA: 0x1628180 Offset: 0x1628281 VA: 0x1628180
	private bool get_IsImplicitFile() { }

	// RVA: 0x1628190 Offset: 0x1628291 VA: 0x1628190
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x16281A0 Offset: 0x16282A1 VA: 0x16281A0
	private bool get_IsDosPath() { }

	// RVA: 0x16281B0 Offset: 0x16282B1 VA: 0x16281B0
	private bool get_IsUncPath() { }

	// RVA: 0x16281C0 Offset: 0x16282C1 VA: 0x16281C0
	private Uri.Flags get_HostType() { }

	// RVA: 0x16281D0 Offset: 0x16282D1 VA: 0x16281D0
	private UriParser get_Syntax() { }

	// RVA: 0x16281E0 Offset: 0x16282E1 VA: 0x16281E0
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x16281F0 Offset: 0x16282F1 VA: 0x16281F0
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x16282B0 Offset: 0x16283B1 VA: 0x16282B0
	private bool get_AllowIdn() { }

	// RVA: 0x16283E0 Offset: 0x16284E1 VA: 0x16283E0
	private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags) { }

	// RVA: 0x1628520 Offset: 0x1628621 VA: 0x1628520
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x1628530 Offset: 0x1628631 VA: 0x1628530
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x1628540 Offset: 0x1628641 VA: 0x1628540
	private void SetUserDrivenParsing() { }

	// RVA: 0x1628560 Offset: 0x1628661 VA: 0x1628560
	private ushort get_SecuredPathIndex() { }

	// RVA: 0x16283D0 Offset: 0x16284D1 VA: 0x16283D0
	private bool NotAny(Uri.Flags flags) { }

	// RVA: 0x16285D0 Offset: 0x16286D1 VA: 0x16285D0
	private bool InFact(Uri.Flags flags) { }

	// RVA: 0x1628510 Offset: 0x1628611 VA: 0x1628510
	private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16285E0 Offset: 0x16286E1 VA: 0x16285E0
	private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x16285F0 Offset: 0x16286F1 VA: 0x16285F0
	private Uri.UriInfo EnsureUriInfo() { }

	// RVA: 0x1628BC0 Offset: 0x1628CC1 VA: 0x1628BC0
	private void EnsureParseRemaining() { }

	// RVA: 0x1629A40 Offset: 0x1629B41 VA: 0x1629A40
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x1629EC0 Offset: 0x1629FC1 VA: 0x1629EC0
	public void .ctor(string uriString) { }

	// RVA: 0x162A140 Offset: 0x162A241 VA: 0x162A140
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x162A1F0 Offset: 0x162A2F1 VA: 0x162A1F0
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x162A2E0 Offset: 0x162A3E1 VA: 0x162A2E0
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x162AC20 Offset: 0x162AD21 VA: 0x162AC20
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x162AE40 Offset: 0x162AF41 VA: 0x162AE40
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	// RVA: 0x162BF40 Offset: 0x162C041 VA: 0x162BF40
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x162C060 Offset: 0x162C161 VA: 0x162C060
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C170 Offset: 0x162C271 VA: 0x162C170 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C180 Offset: 0x162C281 VA: 0x162C180
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x162C260 Offset: 0x162C361 VA: 0x162C260
	public string get_AbsolutePath() { }

	// RVA: 0x162C350 Offset: 0x162C451 VA: 0x162C350
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x162C440 Offset: 0x162C541 VA: 0x162C440
	public string get_AbsoluteUri() { }

	// RVA: 0x162C570 Offset: 0x162C671 VA: 0x162C570
	public string get_LocalPath() { }

	// RVA: 0x162CCE0 Offset: 0x162CDE1 VA: 0x162CCE0
	public string get_Authority() { }

	// RVA: 0x162CD80 Offset: 0x162CE81 VA: 0x162CD80
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x162CEF0 Offset: 0x162CFF1 VA: 0x162CEF0
	public bool get_IsDefaultPort() { }

	// RVA: 0x162CFE0 Offset: 0x162D0E1 VA: 0x162CFE0
	public bool get_IsFile() { }

	// RVA: 0x162D0B0 Offset: 0x162D1B1 VA: 0x162D0B0
	public bool get_IsLoopback() { }

	// RVA: 0x162D180 Offset: 0x162D281 VA: 0x162D180
	public string get_PathAndQuery() { }

	// RVA: 0x162D270 Offset: 0x162D371 VA: 0x162D270
	public bool get_IsUnc() { }

	// RVA: 0x162D310 Offset: 0x162D411 VA: 0x162D310
	public string get_Host() { }

	// RVA: 0x162D3B0 Offset: 0x162D4B1 VA: 0x162D3B0
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x162D3D0 Offset: 0x162D4D1 VA: 0x162D3D0
	private static object get_InitializeLock() { }

	// RVA: 0x162D4D0 Offset: 0x162D5D1 VA: 0x162D4D0
	private static void InitializeUriConfig() { }

	// RVA: 0x162C610 Offset: 0x162C711 VA: 0x162C610
	private string GetLocalPath() { }

	// RVA: 0x162DCF0 Offset: 0x162DDF1 VA: 0x162DCF0
	public int get_Port() { }

	// RVA: 0x162DE10 Offset: 0x162DF11 VA: 0x162DE10
	public string get_Query() { }

	// RVA: 0x162DF40 Offset: 0x162E041 VA: 0x162DF40
	public string get_Fragment() { }

	// RVA: 0x162E070 Offset: 0x162E171 VA: 0x162E070
	public string get_Scheme() { }

	// RVA: 0x162E110 Offset: 0x162E211 VA: 0x162E110
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x162B240 Offset: 0x162B341 VA: 0x162B240
	public string get_OriginalString() { }

	// RVA: 0x162E180 Offset: 0x162E281 VA: 0x162E180
	public string get_DnsSafeHost() { }

	// RVA: 0x162A2D0 Offset: 0x162A3D1 VA: 0x162A2D0
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x162E3F0 Offset: 0x162E4F1 VA: 0x162E3F0
	public bool get_UserEscaped() { }

	// RVA: 0x162E400 Offset: 0x162E501 VA: 0x162E400
	public string get_UserInfo() { }

	// RVA: 0x162E4A0 Offset: 0x162E5A1 VA: 0x162E4A0
	internal static bool IsGenDelim(char ch) { }

	// RVA: 0x162E4F0 Offset: 0x162E5F1 VA: 0x162E4F0
	public static bool CheckSchemeName(string schemeName) { }

	// RVA: 0x162E7A0 Offset: 0x162E8A1 VA: 0x162E7A0
	public static bool IsHexDigit(char character) { }

	// RVA: 0x162E7E0 Offset: 0x162E8E1 VA: 0x162E7E0
	public static int FromHex(char digit) { }

	// RVA: 0x162E8B0 Offset: 0x162E9B1 VA: 0x162E8B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x162EB40 Offset: 0x162EC41 VA: 0x162EB40 Slot: 3
	public override string ToString() { }

	// RVA: 0x162EEC0 Offset: 0x162EFC1 VA: 0x162EEC0
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x162AA50 Offset: 0x162AB51 VA: 0x162AA50
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x162EF00 Offset: 0x162F001 VA: 0x162EF00 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x162F660 Offset: 0x162F761 VA: 0x162F660
	public Uri MakeRelativeUri(Uri uri) { }

	// RVA: 0x162FCA0 Offset: 0x162FDA1 VA: 0x162FCA0
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x162FD60 Offset: 0x162FE61 VA: 0x162FD60
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x162FE50 Offset: 0x162FF51 VA: 0x162FE50
	private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x16304C0 Offset: 0x16305C1 VA: 0x16304C0
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x1630560 Offset: 0x1630661 VA: 0x1630560
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x1631D80 Offset: 0x1631E81 VA: 0x1631D80
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	// RVA: 0x1628620 Offset: 0x1628721 VA: 0x1628620
	private void CreateUriInfo(Uri.Flags cF) { }

	// RVA: 0x1629AA0 Offset: 0x1629BA1 VA: 0x1629AA0
	private void CreateHostString() { }

	// RVA: 0x16322E0 Offset: 0x16323E1 VA: 0x16322E0
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId) { }

	// RVA: 0x1631E80 Offset: 0x1631F81 VA: 0x1631E80
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x162C250 Offset: 0x162C351 VA: 0x162C250
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x1632C20 Offset: 0x1632D21 VA: 0x1632C20
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x162DBE0 Offset: 0x162DCE1 VA: 0x162DBE0
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x1633350 Offset: 0x1633451 VA: 0x1633350
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	// RVA: 0x1632D30 Offset: 0x1632E31 VA: 0x1632D30
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x1628BD0 Offset: 0x1628CD1 VA: 0x1628BD0
	private void ParseRemaining() { }

	// RVA: 0x162FF40 Offset: 0x1630041 VA: 0x162FF40
	private static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x1634950 Offset: 0x1634A51 VA: 0x1634950
	private static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) { }

	// RVA: 0x162B0D0 Offset: 0x162B1D1 VA: 0x162B0D0
	private static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) { }

	// RVA: 0x1630CC0 Offset: 0x1630DC1 VA: 0x1630CC0
	private ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost) { }

	// RVA: 0x16350E0 Offset: 0x16351E1 VA: 0x16350E0
	private void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	// RVA: 0x16354C0 Offset: 0x16355C1 VA: 0x16354C0
	private void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err) { }

	// RVA: 0x1634810 Offset: 0x1634911 VA: 0x1634810
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x1635A30 Offset: 0x1635B31 VA: 0x1635A30
	private void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16324F0 Offset: 0x16325F1 VA: 0x16324F0
	private Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x16340F0 Offset: 0x16341F1 VA: 0x16340F0
	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) { }

	// RVA: 0x1635AF0 Offset: 0x1635BF1 VA: 0x1635AF0
	private static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

	// RVA: 0x162D6A0 Offset: 0x162D7A1 VA: 0x162D6A0
	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	// RVA: 0x162EA40 Offset: 0x162EB41 VA: 0x162EA40
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x162B2A0 Offset: 0x162B3A1 VA: 0x162B2A0
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x162F990 Offset: 0x162FA91 VA: 0x162F990
	private static string PathDifference(string path1, string path2, bool compareCase) { }

	// RVA: 0x1635D60 Offset: 0x1635E61 VA: 0x1635D60
	internal bool get_HasAuthority() { }

	// RVA: 0x1630C70 Offset: 0x1630D71 VA: 0x1630C70
	private static bool IsLWS(char ch) { }

	// RVA: 0x162E6D0 Offset: 0x162E7D1 VA: 0x162E6D0
	private static bool IsAsciiLetter(char character) { }

	// RVA: 0x162E700 Offset: 0x162E801 VA: 0x162E700
	internal static bool IsAsciiLetterOrDigit(char character) { }

	// RVA: 0x1635D70 Offset: 0x1635E71 VA: 0x1635D70
	internal static bool IsBidiControlCharacter(char ch) { }

	// RVA: 0x1635800 Offset: 0x1635901 VA: 0x1635800
	internal static string StripBidiControlCharacter(char* strToClean, int start, int length) { }

	// RVA: 0x1629F70 Offset: 0x162A071 VA: 0x1629F70
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x1635DC0 Offset: 0x1635EC1 VA: 0x1635DC0
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0x16365C0 Offset: 0x16366C1 VA: 0x16365C0
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x1636680 Offset: 0x1636781 VA: 0x1636680
	private bool CheckForUnicode(string data) { }

	// RVA: 0x16367B0 Offset: 0x16368B1 VA: 0x16367B0
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x162F570 Offset: 0x162F671 VA: 0x162F570
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0x1632A30 Offset: 0x1632B31 VA: 0x1632A30
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x1636E90 Offset: 0x1636F91 VA: 0x1636E90
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x16348F0 Offset: 0x16349F1 VA: 0x16348F0
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x1637040 Offset: 0x1637141 VA: 0x1637040
	private void .ctor(Uri.Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x16369B0 Offset: 0x1636AB1 VA: 0x16369B0
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0x162A480 Offset: 0x162A581 VA: 0x162A480
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	// RVA: 0x1636C70 Offset: 0x1636D71 VA: 0x1636C70
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x162EC50 Offset: 0x162ED51 VA: 0x162EC50
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x162AAA0 Offset: 0x162ABA1 VA: 0x162AAA0
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x16370A0 Offset: 0x16371A1 VA: 0x16370A0
	private static void .cctor() { }
}

