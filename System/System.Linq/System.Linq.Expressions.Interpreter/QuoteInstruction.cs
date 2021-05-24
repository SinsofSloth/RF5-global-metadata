internal sealed class QuoteInstruction : Instruction // TypeDefIndex: 2707
{
	// Fields
	private readonly Expression _operand; // 0x10
	private readonly Dictionary<ParameterExpression, LocalVariable> _hoistedVariables; // 0x18

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x191BC10 Offset: 0x191BD11 VA: 0x191BC10
	public void .ctor(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables) { }

	// RVA: 0x191BC60 Offset: 0x191BD61 VA: 0x191BC60 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x191BC70 Offset: 0x191BD71 VA: 0x191BC70 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x191BCC0 Offset: 0x191BDC1 VA: 0x191BCC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

