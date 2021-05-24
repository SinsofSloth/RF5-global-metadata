public class ILGenerator // TypeDefIndex: 620
{
	// Methods

	// RVA: 0x195FD50 Offset: 0x195FE51 VA: 0x195FD50 Slot: 4
	public virtual LocalBuilder DeclareLocal(Type localType) { }

	// RVA: 0x195FDB0 Offset: 0x195FEB1 VA: 0x195FDB0 Slot: 5
	public virtual Label DefineLabel() { }

	// RVA: 0x195FE10 Offset: 0x195FF11 VA: 0x195FE10 Slot: 6
	public virtual void Emit(OpCode opcode) { }

	// RVA: 0x195FE70 Offset: 0x195FF71 VA: 0x195FE70 Slot: 7
	public virtual void Emit(OpCode opcode, byte arg) { }

	// RVA: 0x195FED0 Offset: 0x195FFD1 VA: 0x195FED0 Slot: 8
	public virtual void Emit(OpCode opcode, short arg) { }

	// RVA: 0x195FF30 Offset: 0x1960031 VA: 0x195FF30 Slot: 9
	public virtual void Emit(OpCode opcode, int arg) { }

	// RVA: 0x195FF90 Offset: 0x1960091 VA: 0x195FF90 Slot: 10
	public virtual void Emit(OpCode opcode, long arg) { }

	// RVA: 0x195FFF0 Offset: 0x19600F1 VA: 0x195FFF0 Slot: 11
	public virtual void Emit(OpCode opcode, ConstructorInfo con) { }

	// RVA: 0x1960050 Offset: 0x1960151 VA: 0x1960050 Slot: 12
	public virtual void Emit(OpCode opcode, Label label) { }

	// RVA: 0x19600B0 Offset: 0x19601B1 VA: 0x19600B0 Slot: 13
	public virtual void Emit(OpCode opcode, Label[] labels) { }

	// RVA: 0x1960110 Offset: 0x1960211 VA: 0x1960110 Slot: 14
	public virtual void Emit(OpCode opcode, LocalBuilder local) { }

	// RVA: 0x1960170 Offset: 0x1960271 VA: 0x1960170 Slot: 15
	public virtual void Emit(OpCode opcode, FieldInfo field) { }

	// RVA: 0x19601D0 Offset: 0x19602D1 VA: 0x19601D0 Slot: 16
	public virtual void Emit(OpCode opcode, MethodInfo meth) { }

	[CLSCompliantAttribute] // RVA: 0xB8590 Offset: 0xB8691 VA: 0xB8590
	// RVA: 0x1960230 Offset: 0x1960331 VA: 0x1960230
	public void Emit(OpCode opcode, sbyte arg) { }

	// RVA: 0x1960290 Offset: 0x1960391 VA: 0x1960290 Slot: 17
	public virtual void Emit(OpCode opcode, string str) { }

	// RVA: 0x19602F0 Offset: 0x19603F1 VA: 0x19602F0 Slot: 18
	public virtual void Emit(OpCode opcode, Type cls) { }

	// RVA: 0x1960350 Offset: 0x1960451 VA: 0x1960350 Slot: 19
	public virtual void MarkLabel(Label loc) { }
}

