private sealed class LightCompiler.QuoteVisitor : ExpressionVisitor // TypeDefIndex: 2534
{
	// Fields
	private readonly Dictionary<ParameterExpression, int> _definedParameters; // 0x10
	public readonly HashSet<ParameterExpression> _hoistedParameters; // 0x18

	// Methods

	// RVA: 0x190C5B0 Offset: 0x190C6B1 VA: 0x190C5B0 Slot: 21
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x190C640 Offset: 0x190C741 VA: 0x190C640 Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x190CD00 Offset: 0x190CE01 VA: 0x190CD00 Slot: 22
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F510 Offset: 0x255F611 VA: 0x255F510
	|-LightCompiler.QuoteVisitor.VisitLambda<object>
	*/

	// RVA: 0x190C6B0 Offset: 0x190C7B1 VA: 0x190C6B0
	private void PushParameters(IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x190C9E0 Offset: 0x190CAE1 VA: 0x190C9E0
	private void PopParameters(IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x190CE60 Offset: 0x190CF61 VA: 0x190CE60
	public void .ctor() { }
}

