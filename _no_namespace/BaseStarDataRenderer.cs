public abstract class BaseStarDataRenderer // TypeDefIndex: 8980
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1750D0 Offset: 0x1751D1 VA: 0x1750D0
	private BaseStarDataRenderer.StarDataProgress progressCallback; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x1750E0 Offset: 0x1751E1 VA: 0x1750E0
	private BaseStarDataRenderer.StarDataComplete completionCallback; // 0x18
	public float density; // 0x20
	public float imageSize; // 0x24
	public string layerId; // 0x28
	public float maxRadius; // 0x30
	protected float sphereRadius; // 0x34
	protected bool isCancelled; // 0x38

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A9460 Offset: 0x1A9561 VA: 0x1A9460
	// RVA: 0x215C800 Offset: 0x215C901 VA: 0x215C800
	public void add_progressCallback(BaseStarDataRenderer.StarDataProgress value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9470 Offset: 0x1A9571 VA: 0x1A9470
	// RVA: 0x215C8B0 Offset: 0x215C9B1 VA: 0x215C8B0
	public void remove_progressCallback(BaseStarDataRenderer.StarDataProgress value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9480 Offset: 0x1A9581 VA: 0x1A9480
	// RVA: 0x215C960 Offset: 0x215CA61 VA: 0x215C960
	public void add_completionCallback(BaseStarDataRenderer.StarDataComplete value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9490 Offset: 0x1A9591 VA: 0x1A9490
	// RVA: 0x215CA10 Offset: 0x215CB11 VA: 0x215CA10
	public void remove_completionCallback(BaseStarDataRenderer.StarDataComplete value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerator ComputeStarData() { }

	// RVA: 0x215CAC0 Offset: 0x215CBC1 VA: 0x215CAC0 Slot: 5
	public virtual void Cancel() { }

	// RVA: 0x215CB00 Offset: 0x215CC01 VA: 0x215CB00
	protected void SendProgress(float progress) { }

	// RVA: 0x215CF60 Offset: 0x215D061 VA: 0x215CF60
	protected void SendCompletion(Texture2D texture, bool success) { }

	// RVA: 0x215D3D0 Offset: 0x215D4D1 VA: 0x215D3D0
	protected void .ctor() { }
}

