[HelpURLAttribute] // RVA: 0x148B50 Offset: 0x148C51 VA: 0x148B50
[AddComponentMenu] // RVA: 0x148B50 Offset: 0x148C51 VA: 0x148B50
public class InteractionSystem : MonoBehaviour // TypeDefIndex: 9516
{
	// Fields
	[TooltipAttribute] // RVA: 0x17B930 Offset: 0x17BA31 VA: 0x17B930
	public string targetTag; // 0x18
	[TooltipAttribute] // RVA: 0x17B970 Offset: 0x17BA71 VA: 0x17B970
	public float fadeInTime; // 0x20
	[TooltipAttribute] // RVA: 0x17B9B0 Offset: 0x17BAB1 VA: 0x17B9B0
	public float speed; // 0x24
	[TooltipAttribute] // RVA: 0x17B9F0 Offset: 0x17BAF1 VA: 0x17B9F0
	public float resetToDefaultsSpeed; // 0x28
	[HeaderAttribute] // RVA: 0x17BA30 Offset: 0x17BB31 VA: 0x17BA30
	[TooltipAttribute] // RVA: 0x17BA30 Offset: 0x17BB31 VA: 0x17BA30
	[FormerlySerializedAsAttribute] // RVA: 0x17BA30 Offset: 0x17BB31 VA: 0x17BA30
	public Collider characterCollider; // 0x30
	[TooltipAttribute] // RVA: 0x17BAC0 Offset: 0x17BBC1 VA: 0x17BAC0
	[FormerlySerializedAsAttribute] // RVA: 0x17BAC0 Offset: 0x17BBC1 VA: 0x17BAC0
	public Transform FPSCamera; // 0x38
	[TooltipAttribute] // RVA: 0x17BB20 Offset: 0x17BC21 VA: 0x17BB20
	public LayerMask camRaycastLayers; // 0x40
	[TooltipAttribute] // RVA: 0x17BB60 Offset: 0x17BC61 VA: 0x17BB60
	public float camRaycastDistance; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x17BBA0 Offset: 0x17BCA1 VA: 0x17BBA0
	private List<InteractionTrigger> <triggersInRange>k__BackingField; // 0x48
	private List<InteractionTrigger> inContact; // 0x50
	private List<int> bestRangeIndexes; // 0x58
	public InteractionSystem.InteractionDelegate OnInteractionStart; // 0x60
	public InteractionSystem.InteractionDelegate OnInteractionPause; // 0x68
	public InteractionSystem.InteractionDelegate OnInteractionPickUp; // 0x70
	public InteractionSystem.InteractionDelegate OnInteractionResume; // 0x78
	public InteractionSystem.InteractionDelegate OnInteractionStop; // 0x80
	public InteractionSystem.InteractionEventDelegate OnInteractionEvent; // 0x88
	public RaycastHit raycastHit; // 0x90
	[SpaceAttribute] // RVA: 0x17BBB0 Offset: 0x17BCB1 VA: 0x17BBB0
	[TooltipAttribute] // RVA: 0x17BBB0 Offset: 0x17BCB1 VA: 0x17BBB0
	[SerializeField] // RVA: 0x17BBB0 Offset: 0x17BCB1 VA: 0x17BBB0
	private FullBodyBipedIK fullBody; // 0xC0
	[TooltipAttribute] // RVA: 0x17BC10 Offset: 0x17BD11 VA: 0x17BC10
	public InteractionLookAt lookAt; // 0xC8
	private InteractionEffector[] interactionEffectors; // 0xD0
	private bool initiated; // 0xD8
	private Collider lastCollider; // 0xE0
	private Collider c; // 0xE8

	// Properties
	public bool inInteraction { get; }
	public FullBodyBipedIK ik { get; set; }
	public List<InteractionTrigger> triggersInRange { get; set; }

	// Methods

	[ContextMenu] // RVA: 0x1AB770 Offset: 0x1AB871 VA: 0x1AB770
	// RVA: 0x2913BE0 Offset: 0x2913CE1 VA: 0x2913BE0
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x1AB7B0 Offset: 0x1AB8B1 VA: 0x1AB7B0
	// RVA: 0x2913C30 Offset: 0x2913D31 VA: 0x2913C30
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x1AB7F0 Offset: 0x1AB8F1 VA: 0x1AB7F0
	// RVA: 0x2913C80 Offset: 0x2913D81 VA: 0x2913C80
	private void OpenTutorial1() { }

	[ContextMenu] // RVA: 0x1AB830 Offset: 0x1AB931 VA: 0x1AB830
	// RVA: 0x2913CD0 Offset: 0x2913DD1 VA: 0x2913CD0
	private void OpenTutorial2() { }

	[ContextMenu] // RVA: 0x1AB870 Offset: 0x1AB971 VA: 0x1AB870
	// RVA: 0x2913D20 Offset: 0x2913E21 VA: 0x2913D20
	private void OpenTutorial3() { }

	[ContextMenu] // RVA: 0x1AB8B0 Offset: 0x1AB9B1 VA: 0x1AB8B0
	// RVA: 0x2913D70 Offset: 0x2913E71 VA: 0x2913D70
	private void OpenTutorial4() { }

	[ContextMenu] // RVA: 0x1AB8F0 Offset: 0x1AB9F1 VA: 0x1AB8F0
	// RVA: 0x2913DC0 Offset: 0x2913EC1 VA: 0x2913DC0
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x1AB930 Offset: 0x1ABA31 VA: 0x1AB930
	// RVA: 0x2913E10 Offset: 0x2913F11 VA: 0x2913E10
	private void ASThread() { }

	// RVA: 0x2913E60 Offset: 0x2913F61 VA: 0x2913E60
	public bool get_inInteraction() { }

	// RVA: 0x2914000 Offset: 0x2914101 VA: 0x2914000
	public bool IsInInteraction(FullBodyBipedEffector effectorType) { }

	// RVA: 0x29140E0 Offset: 0x29141E1 VA: 0x29140E0
	public bool IsPaused(FullBodyBipedEffector effectorType) { }

	// RVA: 0x29141C0 Offset: 0x29142C1 VA: 0x29141C0
	public bool IsPaused() { }

	// RVA: 0x2914280 Offset: 0x2914381 VA: 0x2914280
	public bool IsInSync() { }

	// RVA: 0x29143A0 Offset: 0x29144A1 VA: 0x29143A0
	public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt) { }

	// RVA: 0x29144C0 Offset: 0x29145C1 VA: 0x29144C0
	public bool PauseInteraction(FullBodyBipedEffector effectorType) { }

	// RVA: 0x2914560 Offset: 0x2914661 VA: 0x2914560
	public bool ResumeInteraction(FullBodyBipedEffector effectorType) { }

	// RVA: 0x2914600 Offset: 0x2914701 VA: 0x2914600
	public bool StopInteraction(FullBodyBipedEffector effectorType) { }

	// RVA: 0x29146A0 Offset: 0x29147A1 VA: 0x29146A0
	public void PauseAll() { }

	// RVA: 0x2914720 Offset: 0x2914821 VA: 0x2914720
	public void ResumeAll() { }

	// RVA: 0x29147A0 Offset: 0x29148A1 VA: 0x29147A0
	public void StopAll() { }

	// RVA: 0x2914810 Offset: 0x2914911 VA: 0x2914810
	public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType) { }

	// RVA: 0x29148B0 Offset: 0x29149B1 VA: 0x29148B0
	public float GetProgress(FullBodyBipedEffector effectorType) { }

	// RVA: 0x2914950 Offset: 0x2914A51 VA: 0x2914950
	public float GetMinActiveProgress() { }

	// RVA: 0x2914A20 Offset: 0x2914B21 VA: 0x2914A20
	public bool TriggerInteraction(int index, bool interrupt) { }

	// RVA: 0x2914CD0 Offset: 0x2914DD1 VA: 0x2914CD0
	public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject) { }

	// RVA: 0x2914EC0 Offset: 0x2914FC1 VA: 0x2914EC0
	public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget) { }

	// RVA: 0x2915150 Offset: 0x2915251 VA: 0x2915150
	public InteractionTrigger.Range GetClosestInteractionRange() { }

	// RVA: 0x2915480 Offset: 0x2915581 VA: 0x2915480
	public InteractionObject GetClosestInteractionObjectInRange() { }

	// RVA: 0x29154D0 Offset: 0x29155D1 VA: 0x29154D0
	public InteractionTarget GetClosestInteractionTargetInRange() { }

	// RVA: 0x2915550 Offset: 0x2915651 VA: 0x2915550
	public InteractionObject[] GetClosestInteractionObjectsInRange() { }

	// RVA: 0x29156A0 Offset: 0x29157A1 VA: 0x29156A0
	public InteractionTarget[] GetClosestInteractionTargetsInRange() { }

	// RVA: 0x2915850 Offset: 0x2915951 VA: 0x2915850
	public bool TriggerEffectorsReady(int index) { }

	// RVA: 0x2915B00 Offset: 0x2915C01 VA: 0x2915B00
	public InteractionTrigger.Range GetTriggerRange(int index) { }

	// RVA: 0x2915280 Offset: 0x2915381 VA: 0x2915280
	public int GetClosestTriggerIndex() { }

	// RVA: 0x2915C50 Offset: 0x2915D51 VA: 0x2915C50
	public FullBodyBipedIK get_ik() { }

	// RVA: 0x2915C60 Offset: 0x2915D61 VA: 0x2915C60
	public void set_ik(FullBodyBipedIK value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB970 Offset: 0x1ABA71 VA: 0x1AB970
	// RVA: 0x2915C70 Offset: 0x2915D71 VA: 0x2915C70
	public List<InteractionTrigger> get_triggersInRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB980 Offset: 0x1ABA81 VA: 0x1AB980
	// RVA: 0x2915C80 Offset: 0x2915D81 VA: 0x2915C80
	private void set_triggersInRange(List<InteractionTrigger> value) { }

	// RVA: 0x2915C90 Offset: 0x2915D91 VA: 0x2915C90
	public void Start() { }

	// RVA: 0x2916450 Offset: 0x2916551 VA: 0x2916450
	private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	// RVA: 0x2916470 Offset: 0x2916571 VA: 0x2916470
	private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	// RVA: 0x2916490 Offset: 0x2916591 VA: 0x2916490
	private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	// RVA: 0x29164B0 Offset: 0x29165B1 VA: 0x29164B0
	private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject) { }

	// RVA: 0x2916520 Offset: 0x2916621 VA: 0x2916520
	public void OnTriggerEnter(Collider c) { }

	// RVA: 0x2916640 Offset: 0x2916741 VA: 0x2916640
	public void OnTriggerExit(Collider c) { }

	// RVA: 0x2916740 Offset: 0x2916841 VA: 0x2916740
	private bool ContactIsInRange(int index, out int bestRangeIndex) { }

	// RVA: 0x2916AF0 Offset: 0x2916BF1 VA: 0x2916AF0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x2916C10 Offset: 0x2916D11 VA: 0x2916C10
	public void Update() { }

	// RVA: 0x2916E60 Offset: 0x2916F61 VA: 0x2916E60
	private void Raycasting() { }

	// RVA: 0x29161B0 Offset: 0x29162B1 VA: 0x29161B0
	private void UpdateTriggerEventBroadcasting() { }

	// RVA: 0x2916FA0 Offset: 0x29170A1 VA: 0x2916FA0
	private void UpdateEffectors() { }

	// RVA: 0x29170E0 Offset: 0x29171E1 VA: 0x29170E0
	private void OnPreFBBIK() { }

	// RVA: 0x2917180 Offset: 0x2917281 VA: 0x2917180
	private void OnPostFBBIK() { }

	// RVA: 0x2917260 Offset: 0x2917361 VA: 0x2917260
	private void OnFixTransforms() { }

	// RVA: 0x2917280 Offset: 0x2917381 VA: 0x2917280
	private void OnDestroy() { }

	// RVA: 0x2913F20 Offset: 0x2914021 VA: 0x2913F20
	private bool IsValid(bool log) { }

	// RVA: 0x2914BC0 Offset: 0x2914CC1 VA: 0x2914BC0
	private bool TriggerIndexIsValid(int index) { }

	// RVA: 0x2917650 Offset: 0x2917751 VA: 0x2917650
	public void .ctor() { }
}

