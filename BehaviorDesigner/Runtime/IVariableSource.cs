public interface IVariableSource // TypeDefIndex: 4673
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SharedVariable GetVariable(string name) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetVariable(string name, SharedVariable sharedVariable) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetAllVariables(List<SharedVariable> variables) { }
}

