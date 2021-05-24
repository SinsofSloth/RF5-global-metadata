internal class ScopeExpression : BlockExpression // TypeDefIndex: 2245
{
	// Fields
	private IReadOnlyList<ParameterExpression> _variables; // 0x10

	// Properties
	protected IReadOnlyList<ParameterExpression> VariablesList { get; }

	// Methods

	// RVA: 0x1B53580 Offset: 0x1B53681 VA: 0x1B53580
	internal void .ctor(IReadOnlyList<ParameterExpression> variables) { }

	// RVA: 0x1B538B0 Offset: 0x1B539B1 VA: 0x1B538B0 Slot: 13
	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	// RVA: 0x1B53900 Offset: 0x1B53A01 VA: 0x1B53900
	protected IReadOnlyList<ParameterExpression> get_VariablesList() { }

	// RVA: 0x1B53810 Offset: 0x1B53911 VA: 0x1B53810
	internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables) { }
}

