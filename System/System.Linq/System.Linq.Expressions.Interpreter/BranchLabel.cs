internal sealed class BranchLabel // TypeDefIndex: 2363
{
	// Fields
	private int _targetIndex; // 0x10
	private int _stackDepth; // 0x14
	private int _continuationStackDepth; // 0x18
	private List<int> _forwardBranchFixups; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF710 Offset: 0xBF811 VA: 0xBF710
	private int <LabelIndex>k__BackingField; // 0x28

	// Properties
	internal int LabelIndex { get; set; }
	internal bool HasRuntimeLabel { get; }
	internal int TargetIndex { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xC0CE0 Offset: 0xC0DE1 VA: 0xC0CE0
	// RVA: 0x1976D30 Offset: 0x1976E31 VA: 0x1976D30
	internal int get_LabelIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0CF0 Offset: 0xC0DF1 VA: 0xC0CF0
	// RVA: 0x1976D40 Offset: 0x1976E41 VA: 0x1976D40
	internal void set_LabelIndex(int value) { }

	// RVA: 0x1976D50 Offset: 0x1976E51 VA: 0x1976D50
	internal bool get_HasRuntimeLabel() { }

	// RVA: 0x1976D70 Offset: 0x1976E71 VA: 0x1976D70
	internal int get_TargetIndex() { }

	// RVA: 0x1976D80 Offset: 0x1976E81 VA: 0x1976D80
	internal RuntimeLabel ToRuntimeLabel() { }

	// RVA: 0x1976DC0 Offset: 0x1976EC1 VA: 0x1976DC0
	internal void Mark(InstructionList instructions) { }

	// RVA: 0x1976F50 Offset: 0x1977051 VA: 0x1976F50
	internal void AddBranch(InstructionList instructions, int branchIndex) { }

	// RVA: 0x1976F20 Offset: 0x1977021 VA: 0x1976F20
	internal void FixupBranch(InstructionList instructions, int branchIndex) { }

	// RVA: 0x1977030 Offset: 0x1977131 VA: 0x1977030
	public void .ctor() { }
}

