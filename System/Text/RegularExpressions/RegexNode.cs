internal sealed class RegexNode // TypeDefIndex: 1787
{
	// Fields
	internal int _type; // 0x10
	internal List<RegexNode> _children; // 0x18
	internal string _str; // 0x20
	internal char _ch; // 0x28
	internal int _m; // 0x2C
	internal int _n; // 0x30
	internal RegexOptions _options; // 0x34
	internal RegexNode _next; // 0x38

	// Methods

	// RVA: 0x161BFE0 Offset: 0x161C0E1 VA: 0x161BFE0
	internal void .ctor(int type, RegexOptions options) { }

	// RVA: 0x161C020 Offset: 0x161C121 VA: 0x161C020
	internal void .ctor(int type, RegexOptions options, char ch) { }

	// RVA: 0x161C070 Offset: 0x161C171 VA: 0x161C070
	internal void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x161C0C0 Offset: 0x161C1C1 VA: 0x161C0C0
	internal void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x161C110 Offset: 0x161C211 VA: 0x161C110
	internal void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x161C160 Offset: 0x161C261 VA: 0x161C160
	internal bool UseOptionR() { }

	// RVA: 0x161C170 Offset: 0x161C271 VA: 0x161C170
	internal RegexNode ReverseLeft() { }

	// RVA: 0x161C1F0 Offset: 0x161C2F1 VA: 0x161C1F0
	internal void MakeRep(int type, int min, int max) { }

	// RVA: 0x161C210 Offset: 0x161C311 VA: 0x161C210
	internal RegexNode Reduce() { }

	// RVA: 0x161D040 Offset: 0x161D141 VA: 0x161D040
	internal RegexNode StripEnation(int emptyType) { }

	// RVA: 0x161CDF0 Offset: 0x161CEF1 VA: 0x161CDF0
	internal RegexNode ReduceGroup() { }

	// RVA: 0x161CB20 Offset: 0x161CC21 VA: 0x161CB20
	internal RegexNode ReduceRep() { }

	// RVA: 0x161CE90 Offset: 0x161CF91 VA: 0x161CE90
	internal RegexNode ReduceSet() { }

	// RVA: 0x161C310 Offset: 0x161C411 VA: 0x161C310
	internal RegexNode ReduceAlternation() { }

	// RVA: 0x161C790 Offset: 0x161C891 VA: 0x161C790
	internal RegexNode ReduceConcatenation() { }

	// RVA: 0x161D160 Offset: 0x161D261 VA: 0x161D160
	internal RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x161D290 Offset: 0x161D391 VA: 0x161D290
	internal void AddChild(RegexNode newChild) { }

	// RVA: 0x1617690 Offset: 0x1617791 VA: 0x1617690
	internal RegexNode Child(int i) { }

	// RVA: 0x1617630 Offset: 0x1617731 VA: 0x1617630
	internal int ChildCount() { }

	// RVA: 0x161D380 Offset: 0x161D481 VA: 0x161D380
	internal int Type() { }
}

