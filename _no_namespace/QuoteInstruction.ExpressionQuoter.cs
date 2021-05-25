private sealed class QuoteInstruction.ExpressionQuoter : ExpressionVisitor // TypeDefIndex: 2708
{
	// Fields
	private readonly Dictionary<ParameterExpression, LocalVariable> _variables; // 0x10
	private readonly InterpretedFrame _frame; // 0x18
	private readonly Stack<HashSet<ParameterExpression>> _shadowedVars; // 0x20

	// Methods

	// RVA: 0x191BD70 Offset: 0x191BE71 VA: 0x191BD70
	internal void .ctor(Dictionary<ParameterExpression, LocalVariable> hoistedVariables, InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255F700 Offset: 0x255F801 VA: 0x255F700
	|-QuoteInstruction.ExpressionQuoter.VisitLambda<object>
	*/

	// RVA: 0x191BE20 Offset: 0x191BF21 VA: 0x191BE20 Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x191BF90 Offset: 0x191C091 VA: 0x191BF90 Slot: 22
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x191C100 Offset: 0x191C201 VA: 0x191C100 Slot: 21
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x191C1E0 Offset: 0x191C2E1 VA: 0x191C1E0
	private IStrongBox GetBox(ParameterExpression variable) { }
}

