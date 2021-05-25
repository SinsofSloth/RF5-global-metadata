public struct RenderTextureDescriptor // TypeDefIndex: 2949
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0xC9FB0 Offset: 0xCA0B1 VA: 0xC9FB0
	[CompilerGeneratedAttribute] // RVA: 0xC9FB0 Offset: 0xCA0B1 VA: 0xC9FB0
	private int <width>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xC9FF0 Offset: 0xCA0F1 VA: 0xC9FF0
	[DebuggerBrowsableAttribute] // RVA: 0xC9FF0 Offset: 0xCA0F1 VA: 0xC9FF0
	private int <height>k__BackingField; // 0x4
	[DebuggerBrowsableAttribute] // RVA: 0xCA030 Offset: 0xCA131 VA: 0xCA030
	[CompilerGeneratedAttribute] // RVA: 0xCA030 Offset: 0xCA131 VA: 0xCA030
	private int <msaaSamples>k__BackingField; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0xCA070 Offset: 0xCA171 VA: 0xCA070
	[CompilerGeneratedAttribute] // RVA: 0xCA070 Offset: 0xCA171 VA: 0xCA070
	private int <volumeDepth>k__BackingField; // 0xC
	[CompilerGeneratedAttribute] // RVA: 0xCA0B0 Offset: 0xCA1B1 VA: 0xCA0B0
	[DebuggerBrowsableAttribute] // RVA: 0xCA0B0 Offset: 0xCA1B1 VA: 0xCA0B0
	private int <mipCount>k__BackingField; // 0x10
	private GraphicsFormat _graphicsFormat; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0xCA0F0 Offset: 0xCA1F1 VA: 0xCA0F0
	[DebuggerBrowsableAttribute] // RVA: 0xCA0F0 Offset: 0xCA1F1 VA: 0xCA0F0
	private GraphicsFormat <stencilFormat>k__BackingField; // 0x18
	private int _depthBufferBits; // 0x1C
	private static int[] depthFormatBits; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0xCA130 Offset: 0xCA231 VA: 0xCA130
	[CompilerGeneratedAttribute] // RVA: 0xCA130 Offset: 0xCA231 VA: 0xCA130
	private TextureDimension <dimension>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xCA170 Offset: 0xCA271 VA: 0xCA170
	[DebuggerBrowsableAttribute] // RVA: 0xCA170 Offset: 0xCA271 VA: 0xCA170
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0xCA1B0 Offset: 0xCA2B1 VA: 0xCA1B0
	[DebuggerBrowsableAttribute] // RVA: 0xCA1B0 Offset: 0xCA2B1 VA: 0xCA1B0
	private VRTextureUsage <vrUsage>k__BackingField; // 0x28
	private RenderTextureCreationFlags _flags; // 0x2C
	[DebuggerBrowsableAttribute] // RVA: 0xCA1F0 Offset: 0xCA2F1 VA: 0xCA1F0
	[CompilerGeneratedAttribute] // RVA: 0xCA1F0 Offset: 0xCA2F1 VA: 0xCA1F0
	private RenderTextureMemoryless <memoryless>k__BackingField; // 0x30

	// Properties
	public int width { get; set; }
	public int height { get; set; }
	public int msaaSamples { get; set; }
	public int volumeDepth { get; set; }
	public int mipCount { set; }
	public GraphicsFormat graphicsFormat { get; set; }
	public RenderTextureFormat colorFormat { get; }
	public bool sRGB { set; }
	public int depthBufferBits { get; set; }
	public TextureDimension dimension { set; }
	public ShadowSamplingMode shadowSamplingMode { set; }
	public VRTextureUsage vrUsage { set; }
	public RenderTextureMemoryless memoryless { set; }
	public bool useMipMap { set; }
	public bool autoGenerateMips { set; }
	internal bool createdFromScript { set; }
	public bool useDynamicScale { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xD49C0 Offset: 0xD4AC1 VA: 0xD49C0
	// RVA: 0x382A30 Offset: 0x382B31 VA: 0x382A30
	public int get_width() { }

	[CompilerGeneratedAttribute] // RVA: 0xD49D0 Offset: 0xD4AD1 VA: 0xD49D0
	// RVA: 0x382A40 Offset: 0x382B41 VA: 0x382A40
	public void set_width(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD49E0 Offset: 0xD4AE1 VA: 0xD49E0
	// RVA: 0x382A50 Offset: 0x382B51 VA: 0x382A50
	public int get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0xD49F0 Offset: 0xD4AF1 VA: 0xD49F0
	// RVA: 0x382A60 Offset: 0x382B61 VA: 0x382A60
	public void set_height(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD4A00 Offset: 0xD4B01 VA: 0xD4A00
	// RVA: 0x382A70 Offset: 0x382B71 VA: 0x382A70
	public int get_msaaSamples() { }

	[CompilerGeneratedAttribute] // RVA: 0xD4A10 Offset: 0xD4B11 VA: 0xD4A10
	// RVA: 0x382A80 Offset: 0x382B81 VA: 0x382A80
	public void set_msaaSamples(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD4A20 Offset: 0xD4B21 VA: 0xD4A20
	// RVA: 0x382A90 Offset: 0x382B91 VA: 0x382A90
	public int get_volumeDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0xD4A30 Offset: 0xD4B31 VA: 0xD4A30
	// RVA: 0x382AA0 Offset: 0x382BA1 VA: 0x382AA0
	public void set_volumeDepth(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD4A40 Offset: 0xD4B41 VA: 0xD4A40
	// RVA: 0x382AB0 Offset: 0x382BB1 VA: 0x382AB0
	public void set_mipCount(int value) { }

	// RVA: 0x382AC0 Offset: 0x382BC1 VA: 0x382AC0
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x382AD0 Offset: 0x382BD1 VA: 0x382AD0
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x382B20 Offset: 0x382C21 VA: 0x382B20
	public RenderTextureFormat get_colorFormat() { }

	// RVA: 0x382B30 Offset: 0x382C31 VA: 0x382B30
	public void set_sRGB(bool value) { }

	// RVA: 0x382B90 Offset: 0x382C91 VA: 0x382B90
	public int get_depthBufferBits() { }

	// RVA: 0x382C30 Offset: 0x382D31 VA: 0x382C30
	public void set_depthBufferBits(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD4A50 Offset: 0xD4B51 VA: 0xD4A50
	// RVA: 0x382C60 Offset: 0x382D61 VA: 0x382C60
	public void set_dimension(TextureDimension value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD4A60 Offset: 0xD4B61 VA: 0xD4A60
	// RVA: 0x382C70 Offset: 0x382D71 VA: 0x382C70
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD4A70 Offset: 0xD4B71 VA: 0xD4A70
	// RVA: 0x382C80 Offset: 0x382D81 VA: 0x382C80
	public void set_vrUsage(VRTextureUsage value) { }

	[CompilerGeneratedAttribute] // RVA: 0xD4A80 Offset: 0xD4B81 VA: 0xD4A80
	// RVA: 0x382C90 Offset: 0x382D91 VA: 0x382C90
	public void set_memoryless(RenderTextureMemoryless value) { }

	// RVA: 0x382CA0 Offset: 0x382DA1 VA: 0x382CA0
	public void .ctor(int width, int height, RenderTextureFormat colorFormat) { }

	// RVA: 0x382CB0 Offset: 0x382DB1 VA: 0x382CB0
	public void .ctor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits) { }

	// RVA: 0x382CC0 Offset: 0x382DC1 VA: 0x382CC0
	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits) { }

	// RVA: 0x382DD0 Offset: 0x382ED1 VA: 0x382DD0
	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount) { }

	// RVA: 0x382E80 Offset: 0x382F81 VA: 0x382E80
	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

	// RVA: 0x382EA0 Offset: 0x382FA1 VA: 0x382EA0
	public void set_useMipMap(bool value) { }

	// RVA: 0x382EC0 Offset: 0x382FC1 VA: 0x382EC0
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x382EE0 Offset: 0x382FE1 VA: 0x382EE0
	internal void set_createdFromScript(bool value) { }

	// RVA: 0x382F00 Offset: 0x383001 VA: 0x382F00
	public void set_useDynamicScale(bool value) { }

	// RVA: 0x2B808D0 Offset: 0x2B809D1 VA: 0x2B808D0
	private static void .cctor() { }
}

