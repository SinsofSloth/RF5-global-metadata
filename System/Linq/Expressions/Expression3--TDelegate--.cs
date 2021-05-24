internal sealed class Expression3<TDelegate> : Expression<TDelegate> // TypeDefIndex: 2282
{
	// Fields
	private object _par0; // 0x0
	private readonly ParameterExpression _par1; // 0x0
	private readonly ParameterExpression _par2; // 0x0

	// Properties
	internal override int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A63520 Offset: 0x2A63621 VA: 0x2A63520
	|-Expression3<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	internal override int get_ParameterCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A635A0 Offset: 0x2A636A1 VA: 0x2A635A0
	|-Expression3<object>.get_ParameterCount
	*/

	// RVA: -1 Offset: -1 Slot: 16
	internal override ParameterExpression GetParameter(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A635B0 Offset: 0x2A636B1 VA: 0x2A635B0
	|-Expression3<object>.GetParameter
	*/

	// RVA: -1 Offset: -1 Slot: 18
	internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A63670 Offset: 0x2A63771 VA: 0x2A63670
	|-Expression3<object>.Rewrite
	*/
}

