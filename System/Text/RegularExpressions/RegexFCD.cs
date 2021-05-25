internal sealed class RegexFCD // TypeDefIndex: 1777
{
	// Fields
	private int[] _intStack; // 0x10
	private int _intDepth; // 0x18
	private RegexFC[] _fcStack; // 0x20
	private int _fcDepth; // 0x28
	private bool _skipAllChildren; // 0x2C
	private bool _skipchild; // 0x2D
	private bool _failed; // 0x2E

	// Methods

	// RVA: 0x1616EB0 Offset: 0x1616FB1 VA: 0x1616EB0
	internal static RegexPrefix FirstChars(RegexTree t) { }

	// RVA: 0x1617320 Offset: 0x1617421 VA: 0x1617320
	internal static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x1617710 Offset: 0x1617811 VA: 0x1617710
	internal static int Anchors(RegexTree tree) { }

	// RVA: 0x1617900 Offset: 0x1617A01 VA: 0x1617900
	private static int AnchorFromType(int type) { }

	// RVA: 0x1617070 Offset: 0x1617171 VA: 0x1617070
	private void .ctor() { }

	// RVA: 0x1617970 Offset: 0x1617A71 VA: 0x1617970
	private void PushInt(int I) { }

	// RVA: 0x1617A70 Offset: 0x1617B71 VA: 0x1617A70
	private bool IntIsEmpty() { }

	// RVA: 0x1617A80 Offset: 0x1617B81 VA: 0x1617A80
	private int PopInt() { }

	// RVA: 0x1617AD0 Offset: 0x1617BD1 VA: 0x1617AD0
	private void PushFC(RegexFC fc) { }

	// RVA: 0x1617C00 Offset: 0x1617D01 VA: 0x1617C00
	private bool FCIsEmpty() { }

	// RVA: 0x1617C10 Offset: 0x1617D11 VA: 0x1617C10
	private RegexFC PopFC() { }

	// RVA: 0x1617C60 Offset: 0x1617D61 VA: 0x1617C60
	private RegexFC TopFC() { }

	// RVA: 0x1617100 Offset: 0x1617201 VA: 0x1617100
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0x1618360 Offset: 0x1618461 VA: 0x1618360
	private void SkipChild() { }

	// RVA: 0x1617CB0 Offset: 0x1617DB1 VA: 0x1617CB0
	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }
}

