[DebuggerTypeProxyAttribute] // RVA: 0xBECD0 Offset: 0xBEDD1 VA: 0xBECD0
public sealed class TryExpression : Expression // TypeDefIndex: 2325
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF660 Offset: 0xBF761 VA: 0xBF660
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF670 Offset: 0xBF771 VA: 0xBF670
	private readonly Expression <Body>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF680 Offset: 0xBF781 VA: 0xBF680
	private readonly ReadOnlyCollection<CatchBlock> <Handlers>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF690 Offset: 0xBF791 VA: 0xBF690
	private readonly Expression <Finally>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xBF6A0 Offset: 0xBF7A1 VA: 0xBF6A0
	private readonly Expression <Fault>k__BackingField; // 0x30

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public ReadOnlyCollection<CatchBlock> Handlers { get; }
	public Expression Finally { get; }
	public Expression Fault { get; }

	// Methods

	// RVA: 0x1B56B80 Offset: 0x1B56C81 VA: 0x1B56B80
	internal void .ctor(Type type, Expression body, Expression finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C30 Offset: 0xC0D31 VA: 0xC0C30
	// RVA: 0x1B56C70 Offset: 0x1B56D71 VA: 0x1B56C70 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1B56C80 Offset: 0x1B56D81 VA: 0x1B56C80 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C40 Offset: 0xC0D41 VA: 0xC0C40
	// RVA: 0x1B56C90 Offset: 0x1B56D91 VA: 0x1B56C90
	public Expression get_Body() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C50 Offset: 0xC0D51 VA: 0xC0C50
	// RVA: 0x1B56CA0 Offset: 0x1B56DA1 VA: 0x1B56CA0
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C60 Offset: 0xC0D61 VA: 0xC0C60
	// RVA: 0x1B56CB0 Offset: 0x1B56DB1 VA: 0x1B56CB0
	public Expression get_Finally() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C70 Offset: 0xC0D71 VA: 0xC0C70
	// RVA: 0x1B56CC0 Offset: 0x1B56DC1 VA: 0x1B56CC0
	public Expression get_Fault() { }

	// RVA: 0x1B56CD0 Offset: 0x1B56DD1 VA: 0x1B56CD0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1B56D00 Offset: 0x1B56E01 VA: 0x1B56D00
	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression finally, Expression fault) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xBECD0 Offset: 0xBEDD1 VA: 0xBECD0
public sealed class TryExpression : Expression // TypeDefIndex: 2325
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF660 Offset: 0xBF761 VA: 0xBF660
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF670 Offset: 0xBF771 VA: 0xBF670
	private readonly Expression <Body>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF680 Offset: 0xBF781 VA: 0xBF680
	private readonly ReadOnlyCollection<CatchBlock> <Handlers>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF690 Offset: 0xBF791 VA: 0xBF690
	private readonly Expression <Finally>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xBF6A0 Offset: 0xBF7A1 VA: 0xBF6A0
	private readonly Expression <Fault>k__BackingField; // 0x30

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public ReadOnlyCollection<CatchBlock> Handlers { get; }
	public Expression Finally { get; }
	public Expression Fault { get; }

	// Methods

	// RVA: 0x1B56B80 Offset: 0x1B56C81 VA: 0x1B56B80
	internal void .ctor(Type type, Expression body, Expression finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C30 Offset: 0xC0D31 VA: 0xC0C30
	// RVA: 0x1B56C70 Offset: 0x1B56D71 VA: 0x1B56C70 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1B56C80 Offset: 0x1B56D81 VA: 0x1B56C80 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C40 Offset: 0xC0D41 VA: 0xC0C40
	// RVA: 0x1B56C90 Offset: 0x1B56D91 VA: 0x1B56C90
	public Expression get_Body() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C50 Offset: 0xC0D51 VA: 0xC0C50
	// RVA: 0x1B56CA0 Offset: 0x1B56DA1 VA: 0x1B56CA0
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C60 Offset: 0xC0D61 VA: 0xC0C60
	// RVA: 0x1B56CB0 Offset: 0x1B56DB1 VA: 0x1B56CB0
	public Expression get_Finally() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C70 Offset: 0xC0D71 VA: 0xC0C70
	// RVA: 0x1B56CC0 Offset: 0x1B56DC1 VA: 0x1B56CC0
	public Expression get_Fault() { }

	// RVA: 0x1B56CD0 Offset: 0x1B56DD1 VA: 0x1B56CD0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1B56D00 Offset: 0x1B56E01 VA: 0x1B56D00
	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression finally, Expression fault) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xBECD0 Offset: 0xBEDD1 VA: 0xBECD0
public sealed class TryExpression : Expression // TypeDefIndex: 2325
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF660 Offset: 0xBF761 VA: 0xBF660
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF670 Offset: 0xBF771 VA: 0xBF670
	private readonly Expression <Body>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF680 Offset: 0xBF781 VA: 0xBF680
	private readonly ReadOnlyCollection<CatchBlock> <Handlers>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF690 Offset: 0xBF791 VA: 0xBF690
	private readonly Expression <Finally>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xBF6A0 Offset: 0xBF7A1 VA: 0xBF6A0
	private readonly Expression <Fault>k__BackingField; // 0x30

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public ReadOnlyCollection<CatchBlock> Handlers { get; }
	public Expression Finally { get; }
	public Expression Fault { get; }

	// Methods

	// RVA: 0x1B56B80 Offset: 0x1B56C81 VA: 0x1B56B80
	internal void .ctor(Type type, Expression body, Expression finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C30 Offset: 0xC0D31 VA: 0xC0C30
	// RVA: 0x1B56C70 Offset: 0x1B56D71 VA: 0x1B56C70 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1B56C80 Offset: 0x1B56D81 VA: 0x1B56C80 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C40 Offset: 0xC0D41 VA: 0xC0C40
	// RVA: 0x1B56C90 Offset: 0x1B56D91 VA: 0x1B56C90
	public Expression get_Body() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C50 Offset: 0xC0D51 VA: 0xC0C50
	// RVA: 0x1B56CA0 Offset: 0x1B56DA1 VA: 0x1B56CA0
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C60 Offset: 0xC0D61 VA: 0xC0C60
	// RVA: 0x1B56CB0 Offset: 0x1B56DB1 VA: 0x1B56CB0
	public Expression get_Finally() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C70 Offset: 0xC0D71 VA: 0xC0C70
	// RVA: 0x1B56CC0 Offset: 0x1B56DC1 VA: 0x1B56CC0
	public Expression get_Fault() { }

	// RVA: 0x1B56CD0 Offset: 0x1B56DD1 VA: 0x1B56CD0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1B56D00 Offset: 0x1B56E01 VA: 0x1B56D00
	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression finally, Expression fault) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xBECD0 Offset: 0xBEDD1 VA: 0xBECD0
public sealed class TryExpression : Expression // TypeDefIndex: 2325
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF660 Offset: 0xBF761 VA: 0xBF660
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF670 Offset: 0xBF771 VA: 0xBF670
	private readonly Expression <Body>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF680 Offset: 0xBF781 VA: 0xBF680
	private readonly ReadOnlyCollection<CatchBlock> <Handlers>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF690 Offset: 0xBF791 VA: 0xBF690
	private readonly Expression <Finally>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xBF6A0 Offset: 0xBF7A1 VA: 0xBF6A0
	private readonly Expression <Fault>k__BackingField; // 0x30

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public ReadOnlyCollection<CatchBlock> Handlers { get; }
	public Expression Finally { get; }
	public Expression Fault { get; }

	// Methods

	// RVA: 0x1B56B80 Offset: 0x1B56C81 VA: 0x1B56B80
	internal void .ctor(Type type, Expression body, Expression finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C30 Offset: 0xC0D31 VA: 0xC0C30
	// RVA: 0x1B56C70 Offset: 0x1B56D71 VA: 0x1B56C70 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1B56C80 Offset: 0x1B56D81 VA: 0x1B56C80 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C40 Offset: 0xC0D41 VA: 0xC0C40
	// RVA: 0x1B56C90 Offset: 0x1B56D91 VA: 0x1B56C90
	public Expression get_Body() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C50 Offset: 0xC0D51 VA: 0xC0C50
	// RVA: 0x1B56CA0 Offset: 0x1B56DA1 VA: 0x1B56CA0
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C60 Offset: 0xC0D61 VA: 0xC0C60
	// RVA: 0x1B56CB0 Offset: 0x1B56DB1 VA: 0x1B56CB0
	public Expression get_Finally() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C70 Offset: 0xC0D71 VA: 0xC0C70
	// RVA: 0x1B56CC0 Offset: 0x1B56DC1 VA: 0x1B56CC0
	public Expression get_Fault() { }

	// RVA: 0x1B56CD0 Offset: 0x1B56DD1 VA: 0x1B56CD0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1B56D00 Offset: 0x1B56E01 VA: 0x1B56D00
	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression finally, Expression fault) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xBECD0 Offset: 0xBEDD1 VA: 0xBECD0
public sealed class TryExpression : Expression // TypeDefIndex: 2325
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF660 Offset: 0xBF761 VA: 0xBF660
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF670 Offset: 0xBF771 VA: 0xBF670
	private readonly Expression <Body>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF680 Offset: 0xBF781 VA: 0xBF680
	private readonly ReadOnlyCollection<CatchBlock> <Handlers>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF690 Offset: 0xBF791 VA: 0xBF690
	private readonly Expression <Finally>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xBF6A0 Offset: 0xBF7A1 VA: 0xBF6A0
	private readonly Expression <Fault>k__BackingField; // 0x30

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public ReadOnlyCollection<CatchBlock> Handlers { get; }
	public Expression Finally { get; }
	public Expression Fault { get; }

	// Methods

	// RVA: 0x1B56B80 Offset: 0x1B56C81 VA: 0x1B56B80
	internal void .ctor(Type type, Expression body, Expression finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C30 Offset: 0xC0D31 VA: 0xC0C30
	// RVA: 0x1B56C70 Offset: 0x1B56D71 VA: 0x1B56C70 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1B56C80 Offset: 0x1B56D81 VA: 0x1B56C80 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C40 Offset: 0xC0D41 VA: 0xC0C40
	// RVA: 0x1B56C90 Offset: 0x1B56D91 VA: 0x1B56C90
	public Expression get_Body() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C50 Offset: 0xC0D51 VA: 0xC0C50
	// RVA: 0x1B56CA0 Offset: 0x1B56DA1 VA: 0x1B56CA0
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C60 Offset: 0xC0D61 VA: 0xC0C60
	// RVA: 0x1B56CB0 Offset: 0x1B56DB1 VA: 0x1B56CB0
	public Expression get_Finally() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C70 Offset: 0xC0D71 VA: 0xC0C70
	// RVA: 0x1B56CC0 Offset: 0x1B56DC1 VA: 0x1B56CC0
	public Expression get_Fault() { }

	// RVA: 0x1B56CD0 Offset: 0x1B56DD1 VA: 0x1B56CD0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1B56D00 Offset: 0x1B56E01 VA: 0x1B56D00
	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression finally, Expression fault) { }
}

[DebuggerTypeProxyAttribute] // RVA: 0xBECD0 Offset: 0xBEDD1 VA: 0xBECD0
public sealed class TryExpression : Expression // TypeDefIndex: 2325
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xBF660 Offset: 0xBF761 VA: 0xBF660
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xBF670 Offset: 0xBF771 VA: 0xBF670
	private readonly Expression <Body>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xBF680 Offset: 0xBF781 VA: 0xBF680
	private readonly ReadOnlyCollection<CatchBlock> <Handlers>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xBF690 Offset: 0xBF791 VA: 0xBF690
	private readonly Expression <Finally>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xBF6A0 Offset: 0xBF7A1 VA: 0xBF6A0
	private readonly Expression <Fault>k__BackingField; // 0x30

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public ReadOnlyCollection<CatchBlock> Handlers { get; }
	public Expression Finally { get; }
	public Expression Fault { get; }

	// Methods

	// RVA: 0x1B56B80 Offset: 0x1B56C81 VA: 0x1B56B80
	internal void .ctor(Type type, Expression body, Expression finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C30 Offset: 0xC0D31 VA: 0xC0C30
	// RVA: 0x1B56C70 Offset: 0x1B56D71 VA: 0x1B56C70 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x1B56C80 Offset: 0x1B56D81 VA: 0x1B56C80 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C40 Offset: 0xC0D41 VA: 0xC0C40
	// RVA: 0x1B56C90 Offset: 0x1B56D91 VA: 0x1B56C90
	public Expression get_Body() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C50 Offset: 0xC0D51 VA: 0xC0C50
	// RVA: 0x1B56CA0 Offset: 0x1B56DA1 VA: 0x1B56CA0
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C60 Offset: 0xC0D61 VA: 0xC0C60
	// RVA: 0x1B56CB0 Offset: 0x1B56DB1 VA: 0x1B56CB0
	public Expression get_Finally() { }

	[CompilerGeneratedAttribute] // RVA: 0xC0C70 Offset: 0xC0D71 VA: 0xC0C70
	// RVA: 0x1B56CC0 Offset: 0x1B56DC1 VA: 0x1B56CC0
	public Expression get_Fault() { }

	// RVA: 0x1B56CD0 Offset: 0x1B56DD1 VA: 0x1B56CD0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x1B56D00 Offset: 0x1B56E01 VA: 0x1B56D00
	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression finally, Expression fault) { }
}

