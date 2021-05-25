internal class Tokenizer.StreamTokenReader : Tokenizer.ITokenReader // TypeDefIndex: 905
{
	// Fields
	internal StreamReader _in; // 0x10
	internal int _numCharRead; // 0x18

	// Properties
	internal int NumCharEncountered { get; }

	// Methods

	// RVA: 0x26452F0 Offset: 0x26453F1 VA: 0x26452F0
	internal void .ctor(StreamReader input) { }

	// RVA: 0x2645A80 Offset: 0x2645B81 VA: 0x2645A80 Slot: 5
	public virtual int Read() { }

	// RVA: 0x2645AD0 Offset: 0x2645BD1 VA: 0x2645AD0
	internal int get_NumCharEncountered() { }
}

