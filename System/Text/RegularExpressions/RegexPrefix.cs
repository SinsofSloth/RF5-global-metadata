internal sealed class RegexPrefix // TypeDefIndex: 1779
{
	// Fields
	internal string _prefix; // 0x10
	internal bool _caseInsensitive; // 0x18
	internal static RegexPrefix _empty; // 0x0

	// Properties
	internal string Prefix { get; }
	internal bool CaseInsensitive { get; }
	internal static RegexPrefix Empty { get; }

	// Methods

	// RVA: 0x16172D0 Offset: 0x16173D1 VA: 0x16172D0
	internal void .ctor(string prefix, bool ci) { }

	// RVA: 0x1624A10 Offset: 0x1624B11 VA: 0x1624A10
	internal string get_Prefix() { }

	// RVA: 0x1624A20 Offset: 0x1624B21 VA: 0x1624A20
	internal bool get_CaseInsensitive() { }

	// RVA: 0x1624A30 Offset: 0x1624B31 VA: 0x1624A30
	internal static RegexPrefix get_Empty() { }

	// RVA: 0x1624AA0 Offset: 0x1624BA1 VA: 0x1624AA0
	private static void .cctor() { }
}

