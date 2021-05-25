public class PreloadSceneHandle : PreloadHandle // TypeDefIndex: 7696
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x168AF0 Offset: 0x168BF1 VA: 0x168AF0
	private SceneInstance <SceneInstance>k__BackingField; // 0x28
	public UnityAction<PreloadSceneHandle> OnComplete; // 0x38

	// Properties
	public SceneInstance SceneInstance { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A27C0 Offset: 0x1A28C1 VA: 0x1A27C0
	// RVA: 0x1DE9330 Offset: 0x1DE9431 VA: 0x1DE9330
	public SceneInstance get_SceneInstance() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A27D0 Offset: 0x1A28D1 VA: 0x1A27D0
	// RVA: 0x1DE9340 Offset: 0x1DE9441 VA: 0x1DE9340
	private void set_SceneInstance(SceneInstance value) { }

	// RVA: 0x1DE9350 Offset: 0x1DE9451 VA: 0x1DE9350
	public void Entry(string key, UnityAction<PreloadSceneHandle> complete, int priority) { }

	// RVA: 0x1DE9410 Offset: 0x1DE9511 VA: 0x1DE9410 Slot: 4
	public override void Remove() { }

	// RVA: 0x1DE94B0 Offset: 0x1DE95B1 VA: 0x1DE94B0 Slot: 5
	public override bool LoadAsync(bool load = True) { }

	// RVA: 0x1DE9590 Offset: 0x1DE9691 VA: 0x1DE9590
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A27E0 Offset: 0x1A28E1 VA: 0x1A27E0
	// RVA: 0x1DE95A0 Offset: 0x1DE96A1 VA: 0x1DE95A0
	private void <LoadAsync>b__7_0(bool success, SceneInstance scene) { }
}

