internal sealed class RegexParser // TypeDefIndex: 1789
{
	// Fields
	internal RegexNode _stack; // 0x10
	internal RegexNode _group; // 0x18
	internal RegexNode _alternation; // 0x20
	internal RegexNode _concatenation; // 0x28
	internal RegexNode _unit; // 0x30
	internal string _pattern; // 0x38
	internal int _currentPos; // 0x40
	internal CultureInfo _culture; // 0x48
	internal int _autocap; // 0x50
	internal int _capcount; // 0x54
	internal int _captop; // 0x58
	internal int _capsize; // 0x5C
	internal Hashtable _caps; // 0x60
	internal Hashtable _capnames; // 0x68
	internal int[] _capnumlist; // 0x70
	internal List<string> _capnamelist; // 0x78
	internal RegexOptions _options; // 0x80
	internal List<RegexOptions> _optionsStack; // 0x88
	internal bool _ignoreNextParen; // 0x90
	internal static readonly byte[] _category; // 0x0

	// Methods

	// RVA: 0x161D390 Offset: 0x161D491 VA: 0x161D390
	internal static RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x161E8C0 Offset: 0x161E9C1 VA: 0x161E8C0
	internal static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x161F030 Offset: 0x161F131 VA: 0x161F030
	internal static string Escape(string input) { }

	// RVA: 0x161D5E0 Offset: 0x161D6E1 VA: 0x161D5E0
	private void .ctor(CultureInfo culture) { }

	// RVA: 0x161D6B0 Offset: 0x161D7B1 VA: 0x161D6B0
	internal void SetPattern(string Re) { }

	// RVA: 0x161DC50 Offset: 0x161DD51 VA: 0x161DC50
	internal void Reset(RegexOptions topopts) { }

	// RVA: 0x161DCF0 Offset: 0x161DDF1 VA: 0x161DCF0
	internal RegexNode ScanRegex() { }

	// RVA: 0x161EAA0 Offset: 0x161EBA1 VA: 0x161EAA0
	internal RegexNode ScanReplacement() { }

	// RVA: 0x161FF60 Offset: 0x1620061 VA: 0x161FF60
	internal RegexCharClass ScanCharClass(bool caseInsensitive) { }

	// RVA: 0x1622370 Offset: 0x1622471 VA: 0x1622370
	internal RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x1620070 Offset: 0x1620171 VA: 0x1620070
	internal RegexNode ScanGroupOpen() { }

	// RVA: 0x161F400 Offset: 0x161F501 VA: 0x161F400
	internal void ScanBlank() { }

	// RVA: 0x1621530 Offset: 0x1621631 VA: 0x1621530
	internal RegexNode ScanBackslash() { }

	// RVA: 0x1623450 Offset: 0x1623551 VA: 0x1623450
	internal RegexNode ScanBasicBackslash() { }

	// RVA: 0x1621DA0 Offset: 0x1621EA1 VA: 0x1621DA0
	internal RegexNode ScanDollar() { }

	// RVA: 0x1622ED0 Offset: 0x1622FD1 VA: 0x1622ED0
	internal string ScanCapname() { }

	// RVA: 0x1623C10 Offset: 0x1623D11 VA: 0x1623C10
	internal char ScanOctal() { }

	// RVA: 0x1621C60 Offset: 0x1621D61 VA: 0x1621C60
	internal int ScanDecimal() { }

	// RVA: 0x1623CE0 Offset: 0x1623DE1 VA: 0x1623CE0
	internal char ScanHex(int c) { }

	// RVA: 0x1623E60 Offset: 0x1623F61 VA: 0x1623E60
	internal static int HexDigit(char ch) { }

	// RVA: 0x1623EA0 Offset: 0x1623FA1 VA: 0x1623EA0
	internal char ScanControl() { }

	// RVA: 0x1623F70 Offset: 0x1624071 VA: 0x1623F70
	internal bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x1623170 Offset: 0x1623271 VA: 0x1623170
	internal void ScanOptions() { }

	// RVA: 0x1622C50 Offset: 0x1622D51 VA: 0x1622C50
	internal char ScanCharEscape() { }

	// RVA: 0x1622AC0 Offset: 0x1622BC1 VA: 0x1622AC0
	internal string ParseProperty() { }

	// RVA: 0x16233B0 Offset: 0x16234B1 VA: 0x16233B0
	internal int TypeFromCode(char ch) { }

	// RVA: 0x1623FA0 Offset: 0x16240A1 VA: 0x1623FA0
	internal static RegexOptions OptionFromCode(char ch) { }

	// RVA: 0x161D730 Offset: 0x161D831 VA: 0x161D730
	internal void CountCaptures() { }

	// RVA: 0x1624000 Offset: 0x1624101 VA: 0x1624000
	internal void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x1624170 Offset: 0x1624271 VA: 0x1624170
	internal void NoteCaptureName(string name, int pos) { }

	// RVA: 0x161EA50 Offset: 0x161EB51 VA: 0x161EA50
	internal void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x16242B0 Offset: 0x16243B1 VA: 0x16242B0
	internal void AssignNameSlots() { }

	// RVA: 0x16230D0 Offset: 0x16231D1 VA: 0x16230D0
	internal int CaptureSlotFromName(string capname) { }

	// RVA: 0x1623000 Offset: 0x1623101 VA: 0x1623000
	internal bool IsCaptureSlot(int i) { }

	// RVA: 0x16230B0 Offset: 0x16231B1 VA: 0x16230B0
	internal bool IsCaptureName(string capname) { }

	// RVA: 0x1622FF0 Offset: 0x16230F1 VA: 0x1622FF0
	internal bool UseOptionN() { }

	// RVA: 0x161FF50 Offset: 0x1620051 VA: 0x161FF50
	internal bool UseOptionI() { }

	// RVA: 0x1621A70 Offset: 0x1621B71 VA: 0x1621A70
	internal bool UseOptionM() { }

	// RVA: 0x1621B00 Offset: 0x1621C01 VA: 0x1621B00
	internal bool UseOptionS() { }

	// RVA: 0x161F740 Offset: 0x161F841 VA: 0x161F740
	internal bool UseOptionX() { }

	// RVA: 0x1622AB0 Offset: 0x1622BB1 VA: 0x1622AB0
	internal bool UseOptionE() { }

	// RVA: 0x161FA50 Offset: 0x161FB51 VA: 0x161FA50
	internal static bool IsSpecial(char ch) { }

	// RVA: 0x161F7C0 Offset: 0x161F8C1 VA: 0x161F7C0
	internal static bool IsStopperX(char ch) { }

	// RVA: 0x161FB10 Offset: 0x161FC11 VA: 0x161FB10
	internal static bool IsQuantifier(char ch) { }

	// RVA: 0x161F880 Offset: 0x161F981 VA: 0x161F880
	internal bool IsTrueQuantifier() { }

	// RVA: 0x16232F0 Offset: 0x16233F1 VA: 0x16232F0
	internal static bool IsSpace(char ch) { }

	// RVA: 0x161F270 Offset: 0x161F371 VA: 0x161F270
	internal static bool IsMetachar(char ch) { }

	// RVA: 0x161FBD0 Offset: 0x161FCD1 VA: 0x161FBD0
	internal void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x1620DE0 Offset: 0x1620EE1 VA: 0x1620DE0
	internal void PushGroup() { }

	// RVA: 0x1621330 Offset: 0x1621431 VA: 0x1621330
	internal void PopGroup() { }

	// RVA: 0x1620FD0 Offset: 0x16210D1 VA: 0x1620FD0
	internal bool EmptyStack() { }

	// RVA: 0x161F330 Offset: 0x161F431 VA: 0x161F330
	internal void StartGroup(RegexNode openGroup) { }

	// RVA: 0x1620E50 Offset: 0x1620F51 VA: 0x1620E50
	internal void AddAlternate() { }

	// RVA: 0x1621BF0 Offset: 0x1621CF1 VA: 0x1621BF0
	internal void AddConcatenate() { }

	// RVA: 0x1621D50 Offset: 0x1621E51 VA: 0x1621D50
	internal void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x1624950 Offset: 0x1624A51 VA: 0x1624950
	internal RegexNode Unit() { }

	// RVA: 0x161FE80 Offset: 0x161FF81 VA: 0x161FE80
	internal void AddUnitOne(char ch) { }

	// RVA: 0x1621B10 Offset: 0x1621C11 VA: 0x1621B10
	internal void AddUnitNotone(char ch) { }

	// RVA: 0x161FF70 Offset: 0x1620071 VA: 0x161FF70
	internal void AddUnitSet(string cc) { }

	// RVA: 0x1624960 Offset: 0x1624A61 VA: 0x1624960
	internal void AddUnitNode(RegexNode node) { }

	// RVA: 0x1621A80 Offset: 0x1621B81 VA: 0x1621A80
	internal void AddUnitType(int type) { }

	// RVA: 0x1621110 Offset: 0x1621211 VA: 0x1621110
	internal void AddGroup() { }

	// RVA: 0x1620010 Offset: 0x1620111 VA: 0x1620010
	internal void PushOptions() { }

	// RVA: 0x1621490 Offset: 0x1621591 VA: 0x1621490
	internal void PopOptions() { }

	// RVA: 0x1624110 Offset: 0x1624211 VA: 0x1624110
	internal bool EmptyOptionsStack() { }

	// RVA: 0x1620D80 Offset: 0x1620E81 VA: 0x1620D80
	internal void PopKeepOptions() { }

	// RVA: 0x1620FE0 Offset: 0x16210E1 VA: 0x1620FE0
	internal ArgumentException MakeException(string message) { }

	// RVA: 0x1624970 Offset: 0x1624A71 VA: 0x1624970
	internal int Textpos() { }

	// RVA: 0x1624980 Offset: 0x1624A81 VA: 0x1624980
	internal void Textto(int pos) { }

	// RVA: 0x1621C30 Offset: 0x1621D31 VA: 0x1621C30
	internal char MoveRightGetChar() { }

	// RVA: 0x161F750 Offset: 0x161F851 VA: 0x161F750
	internal void MoveRight() { }

	// RVA: 0x1622FE0 Offset: 0x16230E1 VA: 0x1622FE0
	internal void MoveRight(int i) { }

	// RVA: 0x1621BE0 Offset: 0x1621CE1 VA: 0x1621BE0
	internal void MoveLeft() { }

	// RVA: 0x161FE60 Offset: 0x161FF61 VA: 0x161FE60
	internal char CharAt(int i) { }

	// RVA: 0x161F790 Offset: 0x161F891 VA: 0x161F790
	internal char RightChar() { }

	// RVA: 0x1622FB0 Offset: 0x16230B1 VA: 0x1622FB0
	internal char RightChar(int i) { }

	// RVA: 0x161F760 Offset: 0x161F861 VA: 0x161F760
	internal int CharsRight() { }

	// RVA: 0x1624990 Offset: 0x1624A91 VA: 0x1624990
	private static void .cctor() { }
}

