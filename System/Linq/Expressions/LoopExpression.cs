[DebuggerTypeProxyAttribute] // RVA: 0xBE860 Offset: 0xBE961 VA: 0xBE860
public sealed class LoopExpression : Expression // TypeDefIndex: 2286
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF4D0 Offset: 0xBF5D1 VA: 0xBF4D0
	private readonly Expression <Body>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF4E0 Offset: 0xBF5E1 VA: 0xBF4E0
	private readonly LabelTarget <BreakLabel>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF4F0 Offset: 0xBF5F1 VA: 0xBF4F0
	private readonly LabelTarget <ContinueLabel>k__BackingField; // 0x20

	// Properties
	public Expression Body { get; }
	public LabelTarget BreakLabel { get; }
	public LabelTarget ContinueLabel { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xC0A70 Offset: 0xC0B71 VA: 0xC0A70
	// RVA: 0x1921D40 Offset: 0x1921E41 VA: 0x1921D40
	public Expression get_Body() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0A80 Offset: 0xC0B81 VA: 0xC0A80
	// RVA: 0x1921D50 Offset: 0x1921E51 VA: 0x1921D50
	public LabelTarget get_BreakLabel() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0A90 Offset: 0xC0B91 VA: 0xC0A90
	// RVA: 0x1921D60 Offset: 0x1921E61 VA: 0x1921D60
	public LabelTarget get_ContinueLabel() { }
}

