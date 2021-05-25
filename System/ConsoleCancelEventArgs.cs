[Serializable]
public sealed class ConsoleCancelEventArgs : EventArgs // TypeDefIndex: 197
{
	// Fields
	private ConsoleSpecialKey _type; // 0x10
	private bool _cancel; // 0x14

	// Properties
	public bool Cancel { get; }

	// Methods

	// RVA: 0x29786F0 Offset: 0x29787F1 VA: 0x29786F0
	internal void .ctor(ConsoleSpecialKey type) { }

	// RVA: 0x29793A0 Offset: 0x29794A1 VA: 0x29793A0
	public bool get_Cancel() { }

	// RVA: 0x29793B0 Offset: 0x29794B1 VA: 0x29793B0
	internal void .ctor() { }
}

