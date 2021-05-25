internal class CFUrl : CFObject // TypeDefIndex: 1691
{
	// Methods

	// RVA: 0x16EE820 Offset: 0x16EE921 VA: 0x16EE820
	public void .ctor(IntPtr handle, bool own) { }

	// RVA: 0x16EE8C0 Offset: 0x16EE9C1 VA: 0x16EE8C0
	private static extern IntPtr CFURLCreateWithString(IntPtr allocator, IntPtr str, IntPtr baseURL) { }

	// RVA: 0x16E9FB0 Offset: 0x16EA0B1 VA: 0x16E9FB0
	public static CFUrl Create(string absolute) { }
}

