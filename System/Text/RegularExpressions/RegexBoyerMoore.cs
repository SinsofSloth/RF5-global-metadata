internal sealed class RegexBoyerMoore // TypeDefIndex: 1770
{
	// Fields
	internal int[] _positive; // 0x10
	internal int[] _negativeASCII; // 0x18
	internal int[][] _negativeUnicode; // 0x20
	internal string _pattern; // 0x28
	internal int _lowASCII; // 0x30
	internal int _highASCII; // 0x34
	internal bool _rightToLeft; // 0x38
	internal bool _caseInsensitive; // 0x39
	internal CultureInfo _culture; // 0x40

	// Methods

	// RVA: 0x160E800 Offset: 0x160E901 VA: 0x160E800
	internal void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	// RVA: 0x160EE10 Offset: 0x160EF11 VA: 0x160EE10
	private bool MatchPattern(string text, int index) { }

	// RVA: 0x160EF50 Offset: 0x160F051 VA: 0x160EF50
	internal bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x160EFD0 Offset: 0x160F0D1 VA: 0x160EFD0
	internal int Scan(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x160F320 Offset: 0x160F421 VA: 0x160F320 Slot: 3
	public override string ToString() { }
}

