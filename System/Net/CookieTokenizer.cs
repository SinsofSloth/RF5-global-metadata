internal class CookieTokenizer // TypeDefIndex: 1930
{
	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x1778D10 Offset: 0x1778E11 VA: 0x1778D10
	internal void .ctor(string tokenStream) { }

	// RVA: 0x1779770 Offset: 0x1779871 VA: 0x1779770
	internal bool get_EndOfCookie() { }

	// RVA: 0x1779780 Offset: 0x1779881 VA: 0x1779780
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x1779760 Offset: 0x1779861 VA: 0x1779760
	internal bool get_Eof() { }

	// RVA: 0x1779790 Offset: 0x1779891 VA: 0x1779790
	internal string get_Name() { }

	// RVA: 0x17797A0 Offset: 0x17798A1 VA: 0x17797A0
	internal void set_Name(string value) { }

	// RVA: 0x17797B0 Offset: 0x17798B1 VA: 0x17797B0
	internal bool get_Quoted() { }

	// RVA: 0x17797C0 Offset: 0x17798C1 VA: 0x17797C0
	internal void set_Quoted(bool value) { }

	// RVA: 0x17797D0 Offset: 0x17798D1 VA: 0x17797D0
	internal CookieToken get_Token() { }

	// RVA: 0x17797E0 Offset: 0x17798E1 VA: 0x17797E0
	internal void set_Token(CookieToken value) { }

	// RVA: 0x17797F0 Offset: 0x17798F1 VA: 0x17797F0
	internal string get_Value() { }

	// RVA: 0x1779800 Offset: 0x1779901 VA: 0x1779800
	internal void set_Value(string value) { }

	// RVA: 0x1779810 Offset: 0x1779911 VA: 0x1779810
	internal string Extract() { }

	// RVA: 0x17798B0 Offset: 0x17799B1 VA: 0x17798B0
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1779370 Offset: 0x1779471 VA: 0x1779370
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x1779C30 Offset: 0x1779D31 VA: 0x1779C30
	internal void Reset() { }

	// RVA: 0x1779CC0 Offset: 0x1779DC1 VA: 0x1779CC0
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1779F20 Offset: 0x177A021 VA: 0x1779F20
	private static void .cctor() { }
}

internal class CookieTokenizer // TypeDefIndex: 1930
{
	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x1778D10 Offset: 0x1778E11 VA: 0x1778D10
	internal void .ctor(string tokenStream) { }

	// RVA: 0x1779770 Offset: 0x1779871 VA: 0x1779770
	internal bool get_EndOfCookie() { }

	// RVA: 0x1779780 Offset: 0x1779881 VA: 0x1779780
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x1779760 Offset: 0x1779861 VA: 0x1779760
	internal bool get_Eof() { }

	// RVA: 0x1779790 Offset: 0x1779891 VA: 0x1779790
	internal string get_Name() { }

	// RVA: 0x17797A0 Offset: 0x17798A1 VA: 0x17797A0
	internal void set_Name(string value) { }

	// RVA: 0x17797B0 Offset: 0x17798B1 VA: 0x17797B0
	internal bool get_Quoted() { }

	// RVA: 0x17797C0 Offset: 0x17798C1 VA: 0x17797C0
	internal void set_Quoted(bool value) { }

	// RVA: 0x17797D0 Offset: 0x17798D1 VA: 0x17797D0
	internal CookieToken get_Token() { }

	// RVA: 0x17797E0 Offset: 0x17798E1 VA: 0x17797E0
	internal void set_Token(CookieToken value) { }

	// RVA: 0x17797F0 Offset: 0x17798F1 VA: 0x17797F0
	internal string get_Value() { }

	// RVA: 0x1779800 Offset: 0x1779901 VA: 0x1779800
	internal void set_Value(string value) { }

	// RVA: 0x1779810 Offset: 0x1779911 VA: 0x1779810
	internal string Extract() { }

	// RVA: 0x17798B0 Offset: 0x17799B1 VA: 0x17798B0
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1779370 Offset: 0x1779471 VA: 0x1779370
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x1779C30 Offset: 0x1779D31 VA: 0x1779C30
	internal void Reset() { }

	// RVA: 0x1779CC0 Offset: 0x1779DC1 VA: 0x1779CC0
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1779F20 Offset: 0x177A021 VA: 0x1779F20
	private static void .cctor() { }
}

internal class CookieTokenizer // TypeDefIndex: 1930
{
	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x1778D10 Offset: 0x1778E11 VA: 0x1778D10
	internal void .ctor(string tokenStream) { }

	// RVA: 0x1779770 Offset: 0x1779871 VA: 0x1779770
	internal bool get_EndOfCookie() { }

	// RVA: 0x1779780 Offset: 0x1779881 VA: 0x1779780
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x1779760 Offset: 0x1779861 VA: 0x1779760
	internal bool get_Eof() { }

	// RVA: 0x1779790 Offset: 0x1779891 VA: 0x1779790
	internal string get_Name() { }

	// RVA: 0x17797A0 Offset: 0x17798A1 VA: 0x17797A0
	internal void set_Name(string value) { }

	// RVA: 0x17797B0 Offset: 0x17798B1 VA: 0x17797B0
	internal bool get_Quoted() { }

	// RVA: 0x17797C0 Offset: 0x17798C1 VA: 0x17797C0
	internal void set_Quoted(bool value) { }

	// RVA: 0x17797D0 Offset: 0x17798D1 VA: 0x17797D0
	internal CookieToken get_Token() { }

	// RVA: 0x17797E0 Offset: 0x17798E1 VA: 0x17797E0
	internal void set_Token(CookieToken value) { }

	// RVA: 0x17797F0 Offset: 0x17798F1 VA: 0x17797F0
	internal string get_Value() { }

	// RVA: 0x1779800 Offset: 0x1779901 VA: 0x1779800
	internal void set_Value(string value) { }

	// RVA: 0x1779810 Offset: 0x1779911 VA: 0x1779810
	internal string Extract() { }

	// RVA: 0x17798B0 Offset: 0x17799B1 VA: 0x17798B0
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1779370 Offset: 0x1779471 VA: 0x1779370
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x1779C30 Offset: 0x1779D31 VA: 0x1779C30
	internal void Reset() { }

	// RVA: 0x1779CC0 Offset: 0x1779DC1 VA: 0x1779CC0
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1779F20 Offset: 0x177A021 VA: 0x1779F20
	private static void .cctor() { }
}

internal class CookieTokenizer // TypeDefIndex: 1930
{
	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x1778D10 Offset: 0x1778E11 VA: 0x1778D10
	internal void .ctor(string tokenStream) { }

	// RVA: 0x1779770 Offset: 0x1779871 VA: 0x1779770
	internal bool get_EndOfCookie() { }

	// RVA: 0x1779780 Offset: 0x1779881 VA: 0x1779780
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x1779760 Offset: 0x1779861 VA: 0x1779760
	internal bool get_Eof() { }

	// RVA: 0x1779790 Offset: 0x1779891 VA: 0x1779790
	internal string get_Name() { }

	// RVA: 0x17797A0 Offset: 0x17798A1 VA: 0x17797A0
	internal void set_Name(string value) { }

	// RVA: 0x17797B0 Offset: 0x17798B1 VA: 0x17797B0
	internal bool get_Quoted() { }

	// RVA: 0x17797C0 Offset: 0x17798C1 VA: 0x17797C0
	internal void set_Quoted(bool value) { }

	// RVA: 0x17797D0 Offset: 0x17798D1 VA: 0x17797D0
	internal CookieToken get_Token() { }

	// RVA: 0x17797E0 Offset: 0x17798E1 VA: 0x17797E0
	internal void set_Token(CookieToken value) { }

	// RVA: 0x17797F0 Offset: 0x17798F1 VA: 0x17797F0
	internal string get_Value() { }

	// RVA: 0x1779800 Offset: 0x1779901 VA: 0x1779800
	internal void set_Value(string value) { }

	// RVA: 0x1779810 Offset: 0x1779911 VA: 0x1779810
	internal string Extract() { }

	// RVA: 0x17798B0 Offset: 0x17799B1 VA: 0x17798B0
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1779370 Offset: 0x1779471 VA: 0x1779370
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x1779C30 Offset: 0x1779D31 VA: 0x1779C30
	internal void Reset() { }

	// RVA: 0x1779CC0 Offset: 0x1779DC1 VA: 0x1779CC0
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1779F20 Offset: 0x177A021 VA: 0x1779F20
	private static void .cctor() { }
}

internal class CookieTokenizer // TypeDefIndex: 1930
{
	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x1778D10 Offset: 0x1778E11 VA: 0x1778D10
	internal void .ctor(string tokenStream) { }

	// RVA: 0x1779770 Offset: 0x1779871 VA: 0x1779770
	internal bool get_EndOfCookie() { }

	// RVA: 0x1779780 Offset: 0x1779881 VA: 0x1779780
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x1779760 Offset: 0x1779861 VA: 0x1779760
	internal bool get_Eof() { }

	// RVA: 0x1779790 Offset: 0x1779891 VA: 0x1779790
	internal string get_Name() { }

	// RVA: 0x17797A0 Offset: 0x17798A1 VA: 0x17797A0
	internal void set_Name(string value) { }

	// RVA: 0x17797B0 Offset: 0x17798B1 VA: 0x17797B0
	internal bool get_Quoted() { }

	// RVA: 0x17797C0 Offset: 0x17798C1 VA: 0x17797C0
	internal void set_Quoted(bool value) { }

	// RVA: 0x17797D0 Offset: 0x17798D1 VA: 0x17797D0
	internal CookieToken get_Token() { }

	// RVA: 0x17797E0 Offset: 0x17798E1 VA: 0x17797E0
	internal void set_Token(CookieToken value) { }

	// RVA: 0x17797F0 Offset: 0x17798F1 VA: 0x17797F0
	internal string get_Value() { }

	// RVA: 0x1779800 Offset: 0x1779901 VA: 0x1779800
	internal void set_Value(string value) { }

	// RVA: 0x1779810 Offset: 0x1779911 VA: 0x1779810
	internal string Extract() { }

	// RVA: 0x17798B0 Offset: 0x17799B1 VA: 0x17798B0
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1779370 Offset: 0x1779471 VA: 0x1779370
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x1779C30 Offset: 0x1779D31 VA: 0x1779C30
	internal void Reset() { }

	// RVA: 0x1779CC0 Offset: 0x1779DC1 VA: 0x1779CC0
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1779F20 Offset: 0x177A021 VA: 0x1779F20
	private static void .cctor() { }
}

internal class CookieTokenizer // TypeDefIndex: 1930
{
	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x1778D10 Offset: 0x1778E11 VA: 0x1778D10
	internal void .ctor(string tokenStream) { }

	// RVA: 0x1779770 Offset: 0x1779871 VA: 0x1779770
	internal bool get_EndOfCookie() { }

	// RVA: 0x1779780 Offset: 0x1779881 VA: 0x1779780
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x1779760 Offset: 0x1779861 VA: 0x1779760
	internal bool get_Eof() { }

	// RVA: 0x1779790 Offset: 0x1779891 VA: 0x1779790
	internal string get_Name() { }

	// RVA: 0x17797A0 Offset: 0x17798A1 VA: 0x17797A0
	internal void set_Name(string value) { }

	// RVA: 0x17797B0 Offset: 0x17798B1 VA: 0x17797B0
	internal bool get_Quoted() { }

	// RVA: 0x17797C0 Offset: 0x17798C1 VA: 0x17797C0
	internal void set_Quoted(bool value) { }

	// RVA: 0x17797D0 Offset: 0x17798D1 VA: 0x17797D0
	internal CookieToken get_Token() { }

	// RVA: 0x17797E0 Offset: 0x17798E1 VA: 0x17797E0
	internal void set_Token(CookieToken value) { }

	// RVA: 0x17797F0 Offset: 0x17798F1 VA: 0x17797F0
	internal string get_Value() { }

	// RVA: 0x1779800 Offset: 0x1779901 VA: 0x1779800
	internal void set_Value(string value) { }

	// RVA: 0x1779810 Offset: 0x1779911 VA: 0x1779810
	internal string Extract() { }

	// RVA: 0x17798B0 Offset: 0x17799B1 VA: 0x17798B0
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1779370 Offset: 0x1779471 VA: 0x1779370
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x1779C30 Offset: 0x1779D31 VA: 0x1779C30
	internal void Reset() { }

	// RVA: 0x1779CC0 Offset: 0x1779DC1 VA: 0x1779CC0
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1779F20 Offset: 0x177A021 VA: 0x1779F20
	private static void .cctor() { }
}

internal class CookieTokenizer // TypeDefIndex: 1930
{
	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x1778D10 Offset: 0x1778E11 VA: 0x1778D10
	internal void .ctor(string tokenStream) { }

	// RVA: 0x1779770 Offset: 0x1779871 VA: 0x1779770
	internal bool get_EndOfCookie() { }

	// RVA: 0x1779780 Offset: 0x1779881 VA: 0x1779780
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x1779760 Offset: 0x1779861 VA: 0x1779760
	internal bool get_Eof() { }

	// RVA: 0x1779790 Offset: 0x1779891 VA: 0x1779790
	internal string get_Name() { }

	// RVA: 0x17797A0 Offset: 0x17798A1 VA: 0x17797A0
	internal void set_Name(string value) { }

	// RVA: 0x17797B0 Offset: 0x17798B1 VA: 0x17797B0
	internal bool get_Quoted() { }

	// RVA: 0x17797C0 Offset: 0x17798C1 VA: 0x17797C0
	internal void set_Quoted(bool value) { }

	// RVA: 0x17797D0 Offset: 0x17798D1 VA: 0x17797D0
	internal CookieToken get_Token() { }

	// RVA: 0x17797E0 Offset: 0x17798E1 VA: 0x17797E0
	internal void set_Token(CookieToken value) { }

	// RVA: 0x17797F0 Offset: 0x17798F1 VA: 0x17797F0
	internal string get_Value() { }

	// RVA: 0x1779800 Offset: 0x1779901 VA: 0x1779800
	internal void set_Value(string value) { }

	// RVA: 0x1779810 Offset: 0x1779911 VA: 0x1779810
	internal string Extract() { }

	// RVA: 0x17798B0 Offset: 0x17799B1 VA: 0x17798B0
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1779370 Offset: 0x1779471 VA: 0x1779370
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x1779C30 Offset: 0x1779D31 VA: 0x1779C30
	internal void Reset() { }

	// RVA: 0x1779CC0 Offset: 0x1779DC1 VA: 0x1779CC0
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1779F20 Offset: 0x177A021 VA: 0x1779F20
	private static void .cctor() { }
}

