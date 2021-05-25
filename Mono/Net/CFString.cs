internal class CFString : CFObject // TypeDefIndex: 1689
{
	// Fields
	private string str; // 0x18

	// Methods

	// RVA: 0x16EE4E0 Offset: 0x16EE5E1 VA: 0x16EE4E0
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x16EE580 Offset: 0x16EE681 VA: 0x16EE580
	private static extern IntPtr CFStringCreateWithCharacters(IntPtr alloc, IntPtr chars, IntPtr length) { }

	// RVA: 0x16EA5B0 Offset: 0x16EA6B1 VA: 0x16EA5B0
	public static CFString Create(string value) { }

	// RVA: 0x16EE620 Offset: 0x16EE721 VA: 0x16EE620
	private static extern IntPtr CFStringGetLength(IntPtr handle) { }

	// RVA: 0x16EE6A0 Offset: 0x16EE7A1 VA: 0x16EE6A0
	private static extern IntPtr CFStringGetCharactersPtr(IntPtr handle) { }

	// RVA: 0x16EE720 Offset: 0x16EE821 VA: 0x16EE720
	private static extern IntPtr CFStringGetCharacters(IntPtr handle, CFRange range, IntPtr buffer) { }

	// RVA: 0x16EDCA0 Offset: 0x16EDDA1 VA: 0x16EDCA0
	public static string AsString(IntPtr handle) { }

	// RVA: 0x16EE7D0 Offset: 0x16EE8D1 VA: 0x16EE7D0 Slot: 3
	public override string ToString() { }
}

