internal class CADMethodReturnMessage : CADMessageBase // TypeDefIndex: 1202
{
	// Fields
	private object _returnValue; // 0x38
	private CADArgHolder _exception; // 0x40
	private Type[] _sig; // 0x48

	// Properties
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x174FDA0 Offset: 0x174FEA1 VA: 0x174FDA0
	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	// RVA: 0x174FE30 Offset: 0x174FF31 VA: 0x174FE30
	internal void .ctor(IMethodReturnMessage retMsg) { }

	// RVA: 0x1750270 Offset: 0x1750371 VA: 0x1750270
	internal ArrayList GetArguments() { }

	// RVA: 0x1750360 Offset: 0x1750461 VA: 0x1750360
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x1750370 Offset: 0x1750471 VA: 0x1750370
	internal object GetReturnValue(ArrayList args) { }

	// RVA: 0x1750380 Offset: 0x1750481 VA: 0x1750380
	internal Exception GetException(ArrayList args) { }

	// RVA: 0x1750450 Offset: 0x1750551 VA: 0x1750450
	internal int get_PropertiesCount() { }
}

