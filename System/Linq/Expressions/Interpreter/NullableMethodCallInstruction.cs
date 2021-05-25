internal abstract class NullableMethodCallInstruction : Instruction // TypeDefIndex: 2692
{
	// Fields
	private static NullableMethodCallInstruction s_hasValue; // 0x0
	private static NullableMethodCallInstruction s_value; // 0x8
	private static NullableMethodCallInstruction s_equals; // 0x10
	private static NullableMethodCallInstruction s_getHashCode; // 0x18
	private static NullableMethodCallInstruction s_getValueOrDefault1; // 0x20
	private static NullableMethodCallInstruction s_toString; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19181D0 Offset: 0x19182D1 VA: 0x19181D0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19181E0 Offset: 0x19182E1 VA: 0x19181E0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19181F0 Offset: 0x19182F1 VA: 0x19181F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1918240 Offset: 0x1918341 VA: 0x1918240
	private void .ctor() { }

	// RVA: 0x1918250 Offset: 0x1918351 VA: 0x1918250
	public static Instruction Create(string method, int argCount, MethodInfo mi) { }

	// RVA: 0x1918600 Offset: 0x1918701 VA: 0x1918600
	public static Instruction CreateGetValue() { }
}

