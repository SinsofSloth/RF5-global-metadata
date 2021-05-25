internal sealed class LabelScopeInfo // TypeDefIndex: 2491
{
	// Fields
	private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels; // 0x10
	internal readonly LabelScopeKind Kind; // 0x18
	internal readonly LabelScopeInfo Parent; // 0x20

	// Properties
	internal bool CanJumpInto { get; }

	// Methods

	// RVA: 0x17BEF20 Offset: 0x17BF021 VA: 0x17BEF20
	internal void .ctor(LabelScopeInfo parent, LabelScopeKind kind) { }

	// RVA: 0x17BEDE0 Offset: 0x17BEEE1 VA: 0x17BEDE0
	internal bool get_CanJumpInto() { }

	// RVA: 0x17BE850 Offset: 0x17BE951 VA: 0x17BE850
	internal bool ContainsTarget(LabelTarget target) { }

	// RVA: 0x17BEF70 Offset: 0x17BF071 VA: 0x17BEF70
	internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info) { }

	// RVA: 0x17BEA00 Offset: 0x17BEB01 VA: 0x17BEA00
	internal void AddLabelInfo(LabelTarget target, LabelInfo info) { }
}

