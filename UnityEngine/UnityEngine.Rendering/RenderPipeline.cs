public abstract class RenderPipeline // TypeDefIndex: 3326
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xCBAB0 Offset: 0xCBBB1 VA: 0xCBAB0
	[DebuggerBrowsableAttribute] // RVA: 0xCBAB0 Offset: 0xCBBB1 VA: 0xCBAB0
	private bool <disposed>k__BackingField; // 0x10

	// Properties
	public bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0x2A1FE10 Offset: 0x2A1FF11 VA: 0x2A1FE10
	internal void InternalRender(ScriptableRenderContext context, Camera[] cameras) { }

	[CompilerGeneratedAttribute] // RVA: 0xD9AB0 Offset: 0xD9BB1 VA: 0xD9AB0
	// RVA: 0x2A1FED0 Offset: 0x2A1FFD1 VA: 0x2A1FED0
	public bool get_disposed() { }

	[CompilerGeneratedAttribute] // RVA: 0xD9AC0 Offset: 0xD9BC1 VA: 0xD9AC0
	// RVA: 0x2A1FEE0 Offset: 0x2A1FFE1 VA: 0x2A1FEE0
	private void set_disposed(bool value) { }

	// RVA: 0x2A1FEF0 Offset: 0x2A1FFF1 VA: 0x2A1FEF0
	internal void Dispose() { }

	// RVA: 0x2A1FF80 Offset: 0x2A20081 VA: 0x2A1FF80 Slot: 5
	protected virtual void Dispose(bool disposing) { }
}

