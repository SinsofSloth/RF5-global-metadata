public class RestaurantTimelineManager : MonoBehaviour // TypeDefIndex: 7310
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x165610 Offset: 0x165711 VA: 0x165610
	private static RestaurantTimelineManager <Instance>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x165620 Offset: 0x165721 VA: 0x165620
	private Action <CallBack>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x165630 Offset: 0x165731 VA: 0x165630
	private ActorID <SubActor>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x165640 Offset: 0x165741 VA: 0x165640
	private ItemID <ItemID>k__BackingField; // 0x24
	private bool IsSwitchSPCBase; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x165650 Offset: 0x165751 VA: 0x165650
	private RestaurantTimelineLinker <RestaurantTimelineLinker>k__BackingField; // 0x30

	// Properties
	public static RestaurantTimelineManager Instance { get; set; }
	private Action CallBack { get; set; }
	private ActorID SubActor { get; set; }
	private ItemID ItemID { get; set; }
	private RestaurantTimelineLinker RestaurantTimelineLinker { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19FC30 Offset: 0x19FD31 VA: 0x19FC30
	// RVA: 0x2329960 Offset: 0x2329A61 VA: 0x2329960
	public static RestaurantTimelineManager get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FC40 Offset: 0x19FD41 VA: 0x19FC40
	// RVA: 0x23299B0 Offset: 0x2329AB1 VA: 0x23299B0
	private static void set_Instance(RestaurantTimelineManager value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19FC50 Offset: 0x19FD51 VA: 0x19FC50
	// RVA: 0x2329A10 Offset: 0x2329B11 VA: 0x2329A10
	private Action get_CallBack() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FC60 Offset: 0x19FD61 VA: 0x19FC60
	// RVA: 0x2329A20 Offset: 0x2329B21 VA: 0x2329A20
	private void set_CallBack(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19FC70 Offset: 0x19FD71 VA: 0x19FC70
	// RVA: 0x2329A30 Offset: 0x2329B31 VA: 0x2329A30
	private ActorID get_SubActor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FC80 Offset: 0x19FD81 VA: 0x19FC80
	// RVA: 0x2329A40 Offset: 0x2329B41 VA: 0x2329A40
	private void set_SubActor(ActorID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19FC90 Offset: 0x19FD91 VA: 0x19FC90
	// RVA: 0x2329A50 Offset: 0x2329B51 VA: 0x2329A50
	private ItemID get_ItemID() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FCA0 Offset: 0x19FDA1 VA: 0x19FCA0
	// RVA: 0x2329A60 Offset: 0x2329B61 VA: 0x2329A60
	private void set_ItemID(ItemID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19FCB0 Offset: 0x19FDB1 VA: 0x19FCB0
	// RVA: 0x2329A70 Offset: 0x2329B71 VA: 0x2329A70
	private RestaurantTimelineLinker get_RestaurantTimelineLinker() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FCC0 Offset: 0x19FDC1 VA: 0x19FCC0
	// RVA: 0x2329A80 Offset: 0x2329B81 VA: 0x2329A80
	private void set_RestaurantTimelineLinker(RestaurantTimelineLinker value) { }

	// RVA: 0x2329A90 Offset: 0x2329B91 VA: 0x2329A90
	private void Start() { }

	// RVA: 0x2329AF0 Offset: 0x2329BF1 VA: 0x2329AF0
	private void OnDestroy() { }

	// RVA: 0x2329BF0 Offset: 0x2329CF1 VA: 0x2329BF0
	public static void Play(ActorID subActor, ItemID itemid, Action callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x19FCD0 Offset: 0x19FDD1 VA: 0x19FCD0
	// RVA: 0x2329D30 Offset: 0x2329E31 VA: 0x2329D30
	private IEnumerator Load() { }

	// RVA: 0x2329DE0 Offset: 0x2329EE1 VA: 0x2329DE0
	private void PlayTimeline() { }

	// RVA: 0x232A340 Offset: 0x232A441 VA: 0x232A340
	private void TimeLineEnd() { }

	// RVA: 0x232A7A0 Offset: 0x232A8A1 VA: 0x232A7A0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FD40 Offset: 0x19FE41 VA: 0x19FD40
	// RVA: 0x232A7B0 Offset: 0x232A8B1 VA: 0x232A7B0
	private void <PlayTimeline>b__25_1(PlayableDirector director) { }
}

