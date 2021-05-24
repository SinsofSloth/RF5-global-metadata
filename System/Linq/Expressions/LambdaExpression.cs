[DebuggerTypeProxyAttribute] // RVA: 0xBE780 Offset: 0xBE881 VA: 0xBE780
public abstract class LambdaExpression : Expression, IParameterProvider // TypeDefIndex: 2276
{
	// Fields
	private readonly Expression _body; // 0x10

	// Properties
	public sealed override Type Type { get; }
	internal abstract Type TypeCore { get; }
	internal abstract Type PublicType { get; }
	public sealed override ExpressionType NodeType { get; }
	public string Name { get; }
	internal virtual string NameCore { get; }
	public Expression Body { get; }
	public Type ReturnType { get; }
	public bool TailCall { get; }
	internal virtual bool TailCallCore { get; }
	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC1540 Offset: 0xC1641 VA: 0xC1540
	private int System.Linq.Expressions.IParameterProvider.ParameterCount { get; }
	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC1550 Offset: 0xC1651 VA: 0xC1550
	internal virtual int ParameterCount { get; }

	// Methods

	// RVA: 0x19219C0 Offset: 0x1921AC1 VA: 0x19219C0
	internal void .ctor(Expression body) { }

	// RVA: 0x1921A50 Offset: 0x1921B51 VA: 0x1921A50 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Type get_TypeCore() { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract Type get_PublicType() { }

	// RVA: 0x1921A60 Offset: 0x1921B61 VA: 0x1921A60 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x1921A70 Offset: 0x1921B71 VA: 0x1921A70
	public string get_Name() { }

	// RVA: 0x1921A80 Offset: 0x1921B81 VA: 0x1921A80 Slot: 14
	internal virtual string get_NameCore() { }

	// RVA: 0x1921A90 Offset: 0x1921B91 VA: 0x1921A90
	public Expression get_Body() { }

	// RVA: 0x1921AA0 Offset: 0x1921BA1 VA: 0x1921AA0
	public Type get_ReturnType() { }

	// RVA: 0x1921AE0 Offset: 0x1921BE1 VA: 0x1921AE0
	public bool get_TailCall() { }

	// RVA: 0x1921AF0 Offset: 0x1921BF1 VA: 0x1921AF0 Slot: 15
	internal virtual bool get_TailCallCore() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC0A00 Offset: 0xC0B01 VA: 0xC0A00
	// RVA: 0x1921B00 Offset: 0x1921C01 VA: 0x1921B00 Slot: 10
	private ParameterExpression System.Linq.Expressions.IParameterProvider.GetParameter(int index) { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0xC0A10 Offset: 0xC0B11 VA: 0xC0A10
	// RVA: 0x1921B10 Offset: 0x1921C11 VA: 0x1921B10 Slot: 16
	internal virtual ParameterExpression GetParameter(int index) { }

	// RVA: 0x1921B60 Offset: 0x1921C61 VA: 0x1921B60 Slot: 11
	private int System.Linq.Expressions.IParameterProvider.get_ParameterCount() { }

	// RVA: 0x1921B70 Offset: 0x1921C71 VA: 0x1921B70 Slot: 17
	internal virtual int get_ParameterCount() { }

	// RVA: 0x1921BC0 Offset: 0x1921CC1 VA: 0x1921BC0
	public Delegate Compile() { }

	// RVA: 0x1921BD0 Offset: 0x1921CD1 VA: 0x1921BD0
	public Delegate Compile(bool preferInterpretation) { }

	// RVA: 0x1921C50 Offset: 0x1921D51 VA: 0x1921C50
	public Delegate Compile(DebugInfoGenerator debugInfoGenerator) { }
}

