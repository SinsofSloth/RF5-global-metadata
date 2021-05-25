internal sealed class LocalVariables // TypeDefIndex: 2569
{
	// Fields
	private readonly HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope> _variables; // 0x10
	private Dictionary<ParameterExpression, LocalVariable> _closureVariables; // 0x18
	private int _localCount; // 0x20
	private int _maxLocalCount; // 0x24

	// Properties
	public int LocalCount { get; }
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

	// Methods

	// RVA: 0x190FAB0 Offset: 0x190FBB1 VA: 0x190FAB0
	public LocalDefinition DefineLocal(ParameterExpression variable, int start) { }

	// RVA: 0x190FD60 Offset: 0x190FE61 VA: 0x190FD60
	public void UndefineLocal(LocalDefinition definition, int end) { }

	// RVA: 0x190FE30 Offset: 0x190FF31 VA: 0x190FE30
	internal void Box(ParameterExpression variable, InstructionList instructions) { }

	// RVA: 0x1910050 Offset: 0x1910151 VA: 0x1910050
	public int get_LocalCount() { }

	// RVA: 0x1910060 Offset: 0x1910161 VA: 0x1910060
	public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local) { }

	// RVA: 0x1910150 Offset: 0x1910251 VA: 0x1910150
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	// RVA: 0x1910160 Offset: 0x1910261 VA: 0x1910160
	internal LocalVariable AddClosureVariable(ParameterExpression variable) { }

	// RVA: 0x1910260 Offset: 0x1910361 VA: 0x1910260
	public void .ctor() { }
}

