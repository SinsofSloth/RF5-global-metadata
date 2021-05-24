[FlagsAttribute] // RVA: 0x11DF10 Offset: 0x11E011 VA: 0x11DF10
internal enum VersionChangeType // TypeDefIndex: 4120
{
	// Fields
	public int value__; // 0x0
	public const VersionChangeType Bindings = 1;
	public const VersionChangeType ViewData = 2;
	public const VersionChangeType Hierarchy = 4;
	public const VersionChangeType Layout = 8;
	public const VersionChangeType StyleSheet = 16;
	public const VersionChangeType Styles = 32;
	public const VersionChangeType Overflow = 64;
	public const VersionChangeType BorderRadius = 128;
	public const VersionChangeType BorderWidth = 256;
	public const VersionChangeType Transform = 512;
	public const VersionChangeType Size = 1024;
	public const VersionChangeType Repaint = 2048;
	public const VersionChangeType Opacity = 4096;
}

