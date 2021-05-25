public class SpringBoneBehavior : PlayableBehaviour // TypeDefIndex: 8363
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16F220 Offset: 0x16F321 VA: 0x16F220
	private GameObject <BindTarget>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x16F230 Offset: 0x16F331 VA: 0x16F230
	private HumanModel <HumanModel>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16F240 Offset: 0x16F341 VA: 0x16F240
	private SpringManager <SpringManager>k__BackingField; // 0x20
	private bool StartEnable; // 0x28
	private bool EndEnable; // 0x29

	// Properties
	public GameObject BindTarget { get; set; }
	public HumanModel HumanModel { get; set; }
	public SpringManager SpringManager { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7240 Offset: 0x1A7341 VA: 0x1A7240
	// RVA: 0x2247C30 Offset: 0x2247D31 VA: 0x2247C30
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7250 Offset: 0x1A7351 VA: 0x1A7250
	// RVA: 0x2247C40 Offset: 0x2247D41 VA: 0x2247C40
	public void set_BindTarget(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7260 Offset: 0x1A7361 VA: 0x1A7260
	// RVA: 0x2247C50 Offset: 0x2247D51 VA: 0x2247C50
	public HumanModel get_HumanModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7270 Offset: 0x1A7371 VA: 0x1A7270
	// RVA: 0x2247C60 Offset: 0x2247D61 VA: 0x2247C60
	public void set_HumanModel(HumanModel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7280 Offset: 0x1A7381 VA: 0x1A7280
	// RVA: 0x2247C70 Offset: 0x2247D71 VA: 0x2247C70
	public SpringManager get_SpringManager() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7290 Offset: 0x1A7391 VA: 0x1A7290
	// RVA: 0x2247C80 Offset: 0x2247D81 VA: 0x2247C80
	public void set_SpringManager(SpringManager value) { }

	// RVA: 0x2247C90 Offset: 0x2247D91 VA: 0x2247C90
	public void Initialize(GameObject bindTarget, bool start, bool end) { }

	// RVA: 0x2247CE0 Offset: 0x2247DE1 VA: 0x2247CE0 Slot: 13
	public override void OnGraphStart(Playable playable) { }

	// RVA: 0x2247E30 Offset: 0x2247F31 VA: 0x2247E30 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x2247F10 Offset: 0x2248011 VA: 0x2247F10 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x2247FF0 Offset: 0x22480F1 VA: 0x2247FF0
	public void .ctor() { }
}

