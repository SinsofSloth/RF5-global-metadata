[DebuggerTypeProxyAttribute] // RVA: 0xBEE20 Offset: 0xBEF21 VA: 0xBEE20
internal struct InstructionArray // TypeDefIndex: 2481
{
	// Fields
	internal readonly int MaxStackDepth; // 0x0
	internal readonly int MaxContinuationDepth; // 0x4
	internal readonly Instruction[] Instructions; // 0x8
	internal readonly object[] Objects; // 0x10
	internal readonly RuntimeLabel[] Labels; // 0x18
	internal readonly List<KeyValuePair<int, object>> DebugCookies; // 0x20

	// Methods

	// RVA: 0xA0F0 Offset: 0xA1F1 VA: 0xA0F0
	internal void .ctor(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions, object[] objects, RuntimeLabel[] labels, List<KeyValuePair<int, object>> debugCookies) { }
}

