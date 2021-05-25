internal sealed class IndexMethodByRefUpdater : ByRefUpdater // TypeDefIndex: 2541
{
	// Fields
	private readonly MethodInfo _indexer; // 0x18
	private readonly Nullable<LocalDefinition> _obj; // 0x20
	private readonly LocalDefinition[] _args; // 0x38

	// Methods

	// RVA: 0x1984C90 Offset: 0x1984D91 VA: 0x1984C90
	public void .ctor(Nullable<LocalDefinition> obj, LocalDefinition[] args, MethodInfo indexer, int argumentIndex) { }

	// RVA: 0x1984D10 Offset: 0x1984E11 VA: 0x1984D10 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x1984F70 Offset: 0x1985071 VA: 0x1984F70 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

