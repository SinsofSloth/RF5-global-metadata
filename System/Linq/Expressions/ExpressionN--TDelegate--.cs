internal class ExpressionN<TDelegate> : Expression<TDelegate> // TypeDefIndex: 2283
{
	// Fields
	private IReadOnlyList<ParameterExpression> _parameters; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, IReadOnlyList<ParameterExpression> parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A63C90 Offset: 0x2A63D91 VA: 0x2A63C90
	|-ExpressionN<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A63CE0 Offset: 0x2A63DE1 VA: 0x2A63CE0
	|-ExpressionN<object>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A63D90 Offset: 0x2A63E91 VA: 0x2A63D90
	|-ExpressionN<object>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A63E50 Offset: 0x2A63F51 VA: 0x2A63E50
	|-ExpressionN<object>.Rewrite
	*/
}

