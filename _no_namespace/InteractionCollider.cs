public class InteractionCollider : InteractionColliderBase // TypeDefIndex: 6687
{
	// Fields
	[SerializeField] // RVA: 0x15EC90 Offset: 0x15ED91 VA: 0x15EC90
	private float m_AllowAngle; // 0x38
	[SerializeField] // RVA: 0x15ECA0 Offset: 0x15EDA1 VA: 0x15ECA0
	private AnimationCurve m_AnglePriority; // 0x40
	[SerializeField] // RVA: 0x15ECB0 Offset: 0x15EDB1 VA: 0x15ECB0
	private UnityEvent OnChangeCurrentInteraction; // 0x48
	[SerializeField] // RVA: 0x15ECC0 Offset: 0x15EDC1 VA: 0x15ECC0
	private List<Collider> m_IgnoreList; // 0x50
	private FocusInterface _CurrentFocus; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x15ECD0 Offset: 0x15EDD1 VA: 0x15ECD0
	private Collider <CurrentFocusCollider>k__BackingField; // 0x60
	protected const int FocusBufferMaxSize = 128;
	[TupleElementNamesAttribute] // RVA: 0x15ECE0 Offset: 0x15EDE1 VA: 0x15ECE0
	private ValueTuple<Collider, FocusInterface, Vector3, float>[] m_WorkList; // 0x68
	protected Dictionary<Collider, FocusInterface> m_FocusList; // 0x70
	private static InteractionCollider.PriorityComparer m_PriorityComparer; // 0x0

	// Properties
	public FocusInterface CurrentFocus { get; set; }
	public Collider CurrentFocusCollider { get; set; }

	// Methods

	// RVA: 0x20CC3F0 Offset: 0x20CC4F1 VA: 0x20CC3F0
	public FocusInterface get_CurrentFocus() { }

	// RVA: 0x20CC400 Offset: 0x20CC501 VA: 0x20CC400
	private void set_CurrentFocus(FocusInterface value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C9E0 Offset: 0x19CAE1 VA: 0x19C9E0
	// RVA: 0x20CC680 Offset: 0x20CC781 VA: 0x20CC680
	public Collider get_CurrentFocusCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C9F0 Offset: 0x19CAF1 VA: 0x19C9F0
	// RVA: 0x20CC690 Offset: 0x20CC791 VA: 0x20CC690
	private void set_CurrentFocusCollider(Collider value) { }

	// RVA: 0x20CC6A0 Offset: 0x20CC7A1 VA: 0x20CC6A0
	private void OnDisable() { }

	// RVA: 0x20CC7D0 Offset: 0x20CC8D1 VA: 0x20CC7D0
	public void AddIgnore(Collider collider) { }

	// RVA: 0x20CC840 Offset: 0x20CC941 VA: 0x20CC840
	public void RemoveIgnore(Collider collider) { }

	// RVA: 0x20CC8B0 Offset: 0x20CC9B1 VA: 0x20CC8B0
	public void DoUpdate() { }

	// RVA: 0x20CD790 Offset: 0x20CD891 VA: 0x20CD790
	public InteractionInterface GetInteraction() { }

	// RVA: 0x20C5830 Offset: 0x20C5931 VA: 0x20C5830
	public ItemInteractionInterface GetItemInteraction() { }

	// RVA: 0x20CD900 Offset: 0x20CDA01 VA: 0x20CD900
	public SlashInteractionInterface GetSlashInteraction() { }

	// RVA: 0x20CDA70 Offset: 0x20CDB71 VA: 0x20CDA70
	public SmashInteractionInterface GetSmashInteraction() { }

	// RVA: 0x20CDBE0 Offset: 0x20CDCE1 VA: 0x20CDBE0
	public PlowInteractionInterface GetPlowInteraction() { }

	// RVA: 0x20CDD50 Offset: 0x20CDE51 VA: 0x20CDD50
	public SowInteractionInterface GetSowInteraction() { }

	// RVA: 0x20CDEC0 Offset: 0x20CDFC1 VA: 0x20CDEC0
	public PotInteractionInterface GetPotInteraction() { }

	// RVA: 0x20CE030 Offset: 0x20CE131 VA: 0x20CE030
	public ChopInteractionInterface GetChopInteraction() { }

	// RVA: 0x20CE1A0 Offset: 0x20CE2A1 VA: 0x20CE1A0
	public bool CanInteraction(HumanController humanController) { }

	// RVA: 0x20CE280 Offset: 0x20CE381 VA: 0x20CE280
	public bool CanInteraction(MonsterControllerBase monsterController) { }

	// RVA: 0x20CE360 Offset: 0x20CE461 VA: 0x20CE360
	public bool CanItemInteraction(HumanController humanController) { }

	// RVA: 0x20CE470 Offset: 0x20CE571 VA: 0x20CE470
	public bool CanRapidItemInteraction(HumanController humanController) { }

	// RVA: 0x20CE570 Offset: 0x20CE671 VA: 0x20CE570
	public bool CanSlashInteraction(HumanController humanController) { }

	// RVA: 0x20CE650 Offset: 0x20CE751 VA: 0x20CE650
	public bool CanSmashInteraction(HumanController humanController) { }

	// RVA: 0x20CE730 Offset: 0x20CE831 VA: 0x20CE730
	public bool CanBreakInteraction(HumanController humanController) { }

	// RVA: 0x20CE810 Offset: 0x20CE911 VA: 0x20CE810
	public bool CanPlowInteraction(HumanController humanController) { }

	// RVA: 0x20CE8F0 Offset: 0x20CE9F1 VA: 0x20CE8F0
	public bool CanChopInteraction(HumanController humanController) { }

	// RVA: 0x20CE9D0 Offset: 0x20CEAD1 VA: 0x20CE9D0
	public void .ctor() { }

	// RVA: 0x20CEBE0 Offset: 0x20CECE1 VA: 0x20CEBE0
	private static void .cctor() { }
}

