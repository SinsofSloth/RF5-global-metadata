private sealed class LocalVariables.VariableScope // TypeDefIndex: 2570
{
	// Fields
	public readonly int Start; // 0x10
	public int Stop; // 0x14
	public readonly LocalVariable Variable; // 0x18
	public readonly LocalVariables.VariableScope Parent; // 0x20
	public List<LocalVariables.VariableScope> ChildScopes; // 0x28

	// Methods

	// RVA: 0x190FD00 Offset: 0x190FE01 VA: 0x190FD00
	public void .ctor(LocalVariable variable, int start, LocalVariables.VariableScope parent) { }
}

