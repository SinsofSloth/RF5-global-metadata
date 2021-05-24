internal sealed class LabelInfo // TypeDefIndex: 2488
{
	// Fields
	private readonly LabelTarget _node; // 0x10
	private BranchLabel _label; // 0x18
	private object _definitions; // 0x20
	private readonly List<LabelScopeInfo> _references; // 0x28
	private bool _acrossBlockJump; // 0x30

	// Properties
	private bool HasDefinitions { get; }
	private bool HasMultipleDefinitions { get; }

	// Methods

	// RVA: 0x17BE050 Offset: 0x17BE151 VA: 0x17BE050
	internal void .ctor(LabelTarget node) { }

	// RVA: 0x17BE0F0 Offset: 0x17BE1F1 VA: 0x17BE0F0
	internal BranchLabel GetLabel(LightCompiler compiler) { }

	// RVA: 0x17BE1A0 Offset: 0x17BE2A1 VA: 0x17BE1A0
	internal void Reference(LabelScopeInfo block) { }

	// RVA: 0x17BE5E0 Offset: 0x17BE6E1 VA: 0x17BE5E0
	internal void Define(LabelScopeInfo block) { }

	// RVA: 0x17BE240 Offset: 0x17BE341 VA: 0x17BE240
	private void ValidateJump(LabelScopeInfo reference) { }

	// RVA: 0x17BEDF0 Offset: 0x17BEEF1 VA: 0x17BEDF0
	internal void ValidateFinish() { }

	// RVA: 0x17BE150 Offset: 0x17BE251 VA: 0x17BE150
	private void EnsureLabel(LightCompiler compiler) { }

	// RVA: 0x17BEB50 Offset: 0x17BEC51 VA: 0x17BEB50
	private bool DefinedIn(LabelScopeInfo scope) { }

	// RVA: 0x17BE230 Offset: 0x17BE331 VA: 0x17BE230
	private bool get_HasDefinitions() { }

	// RVA: 0x17BEC50 Offset: 0x17BED51 VA: 0x17BEC50
	private LabelScopeInfo FirstDefinition() { }

	// RVA: 0x17BE8D0 Offset: 0x17BE9D1 VA: 0x17BE8D0
	private void AddDefinition(LabelScopeInfo scope) { }

	// RVA: 0x17BEAB0 Offset: 0x17BEBB1 VA: 0x17BEAB0
	private bool get_HasMultipleDefinitions() { }

	// RVA: -1 Offset: -1
	internal static T CommonNode<T>(T first, T second, Func<T, T> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2263BE0 Offset: 0x2263CE1 VA: 0x2263BE0
	|-LabelInfo.CommonNode<LabelScopeInfo>
	|-LabelInfo.CommonNode<object>
	*/
}

