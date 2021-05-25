internal sealed class RegexWriter // TypeDefIndex: 1794
{
	// Fields
	internal int[] _intStack; // 0x10
	internal int _depth; // 0x18
	internal int[] _emitted; // 0x20
	internal int _curpos; // 0x28
	internal Dictionary<string, int> _stringhash; // 0x30
	internal List<string> _stringtable; // 0x38
	internal bool _counting; // 0x40
	internal int _count; // 0x44
	internal int _trackcount; // 0x48
	internal Hashtable _caps; // 0x50

	// Methods

	// RVA: 0x1626340 Offset: 0x1626441 VA: 0x1626340
	internal static RegexCode Write(RegexTree t) { }

	// RVA: 0x16263B0 Offset: 0x16264B1 VA: 0x16263B0
	private void .ctor() { }

	// RVA: 0x16268E0 Offset: 0x16269E1 VA: 0x16268E0
	internal void PushInt(int I) { }

	// RVA: 0x16269E0 Offset: 0x1626AE1 VA: 0x16269E0
	internal bool EmptyStack() { }

	// RVA: 0x16269F0 Offset: 0x1626AF1 VA: 0x16269F0
	internal int PopInt() { }

	// RVA: 0x1626A40 Offset: 0x1626B41 VA: 0x1626A40
	internal int CurPos() { }

	// RVA: 0x1626A50 Offset: 0x1626B51 VA: 0x1626A50
	internal void PatchJump(int Offset, int jumpDest) { }

	// RVA: 0x1626A90 Offset: 0x1626B91 VA: 0x1626A90
	internal void Emit(int op) { }

	// RVA: 0x1626B30 Offset: 0x1626C31 VA: 0x1626B30
	internal void Emit(int op, int opd1) { }

	// RVA: 0x1626BF0 Offset: 0x1626CF1 VA: 0x1626BF0
	internal void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x1626CE0 Offset: 0x1626DE1 VA: 0x1626CE0
	internal int StringCode(string str) { }

	// RVA: 0x1626DF0 Offset: 0x1626EF1 VA: 0x1626DF0
	internal ArgumentException MakeException(string message) { }

	// RVA: 0x1626E60 Offset: 0x1626F61 VA: 0x1626E60
	internal int MapCapnum(int capnum) { }

	// RVA: 0x16264A0 Offset: 0x16265A1 VA: 0x16264A0
	internal RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x1626F20 Offset: 0x1627021 VA: 0x1626F20
	internal void EmitFragment(int nodetype, RegexNode node, int CurIndex) { }
}

