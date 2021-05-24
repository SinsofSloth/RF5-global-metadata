internal interface IParameterProvider // TypeDefIndex: 2270
{
	// Properties
	public abstract int ParameterCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ParameterExpression GetParameter(int index) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ParameterCount() { }
}

