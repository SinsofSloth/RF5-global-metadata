public abstract class Task // TypeDefIndex: 4717
{
	// Fields
	protected GameObject gameObject; // 0x10
	protected Transform transform; // 0x18
	[SerializeField] // RVA: 0x12D870 Offset: 0x12D971 VA: 0x12D870
	private NodeData nodeData; // 0x20
	[SerializeField] // RVA: 0x12D880 Offset: 0x12D981 VA: 0x12D880
	private Behavior owner; // 0x28
	[SerializeField] // RVA: 0x12D890 Offset: 0x12D991 VA: 0x12D890
	private int id; // 0x30
	[SerializeField] // RVA: 0x12D8A0 Offset: 0x12D9A1 VA: 0x12D8A0
	private string friendlyName; // 0x38
	[SerializeField] // RVA: 0x12D8B0 Offset: 0x12D9B1 VA: 0x12D8B0
	private bool instant; // 0x40
	private int referenceID; // 0x44
	private bool disabled; // 0x48

	// Properties
	public GameObject GameObject { set; }
	public Transform Transform { set; }
	public NodeData NodeData { get; set; }
	public Behavior Owner { get; set; }
	public int ID { get; set; }
	public virtual string FriendlyName { get; set; }
	public bool IsInstant { get; set; }
	public int ReferenceID { get; set; }
	public bool Disabled { get; set; }

	// Methods

	// RVA: 0x1B23C00 Offset: 0x1B23D01 VA: 0x1B23C00
	protected void .ctor() { }

	// RVA: 0x1B244A0 Offset: 0x1B245A1 VA: 0x1B244A0 Slot: 4
	public virtual void OnAwake() { }

	// RVA: 0x1B244B0 Offset: 0x1B245B1 VA: 0x1B244B0 Slot: 5
	public virtual void OnStart() { }

	// RVA: 0x1B244C0 Offset: 0x1B245C1 VA: 0x1B244C0 Slot: 6
	public virtual TaskStatus OnUpdate() { }

	// RVA: 0x1B244D0 Offset: 0x1B245D1 VA: 0x1B244D0 Slot: 7
	public virtual void OnLateUpdate() { }

	// RVA: 0x1B244E0 Offset: 0x1B245E1 VA: 0x1B244E0 Slot: 8
	public virtual void OnFixedUpdate() { }

	// RVA: 0x1B244F0 Offset: 0x1B245F1 VA: 0x1B244F0 Slot: 9
	public virtual void OnEnd() { }

	// RVA: 0x1B24500 Offset: 0x1B24601 VA: 0x1B24500 Slot: 10
	public virtual void OnPause(bool paused) { }

	// RVA: 0x1B24510 Offset: 0x1B24611 VA: 0x1B24510 Slot: 11
	public virtual void OnConditionalAbort() { }

	// RVA: 0x1B24520 Offset: 0x1B24621 VA: 0x1B24520 Slot: 12
	public virtual float GetPriority() { }

	// RVA: 0x1B24530 Offset: 0x1B24631 VA: 0x1B24530 Slot: 13
	public virtual float GetUtility() { }

	// RVA: 0x1B24540 Offset: 0x1B24641 VA: 0x1B24540 Slot: 14
	public virtual void OnBehaviorRestart() { }

	// RVA: 0x1B24550 Offset: 0x1B24651 VA: 0x1B24550 Slot: 15
	public virtual void OnBehaviorComplete() { }

	// RVA: 0x1B24560 Offset: 0x1B24661 VA: 0x1B24560 Slot: 16
	public virtual void OnReset() { }

	// RVA: 0x1B24570 Offset: 0x1B24671 VA: 0x1B24570 Slot: 17
	public virtual void OnDrawGizmos() { }

	// RVA: 0x1B24580 Offset: 0x1B24681 VA: 0x1B24580
	protected Coroutine StartCoroutine(IEnumerator routine) { }

	// RVA: 0x1B245A0 Offset: 0x1B246A1 VA: 0x1B245A0 Slot: 18
	public virtual void OnCollisionEnter(Collision collision) { }

	// RVA: 0x1B245B0 Offset: 0x1B246B1 VA: 0x1B245B0 Slot: 19
	public virtual void OnCollisionExit(Collision collision) { }

	// RVA: 0x1B245C0 Offset: 0x1B246C1 VA: 0x1B245C0 Slot: 20
	public virtual void OnTriggerEnter(Collider other) { }

	// RVA: 0x1B245D0 Offset: 0x1B246D1 VA: 0x1B245D0 Slot: 21
	public virtual void OnTriggerExit(Collider other) { }

	// RVA: 0x1B245E0 Offset: 0x1B246E1 VA: 0x1B245E0 Slot: 22
	public virtual void OnCollisionEnter2D(Collision2D collision) { }

	// RVA: 0x1B245F0 Offset: 0x1B246F1 VA: 0x1B245F0 Slot: 23
	public virtual void OnCollisionExit2D(Collision2D collision) { }

	// RVA: 0x1B24600 Offset: 0x1B24701 VA: 0x1B24600 Slot: 24
	public virtual void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x1B24610 Offset: 0x1B24711 VA: 0x1B24610 Slot: 25
	public virtual void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x1B24620 Offset: 0x1B24721 VA: 0x1B24620 Slot: 26
	public virtual void OnControllerColliderHit(ControllerColliderHit hit) { }

	// RVA: 0x1B24630 Offset: 0x1B24731 VA: 0x1B24630 Slot: 27
	public virtual void OnAnimatorIK() { }

	// RVA: 0x1B24640 Offset: 0x1B24741 VA: 0x1B24640
	public void set_GameObject(GameObject value) { }

	// RVA: 0x1B24650 Offset: 0x1B24751 VA: 0x1B24650
	public void set_Transform(Transform value) { }

	// RVA: -1 Offset: -1
	protected T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BE660 Offset: 0x23BE761 VA: 0x23BE660
	|-Task.GetComponent<AIInput>
	|-Task.GetComponent<BossBehaviorController>
	|-Task.GetComponent<EnemyBehaviorController>
	|-Task.GetComponent<FarmMonsterBehaviorController>
	|-Task.GetComponent<MonsterBehaviorController>
	|-Task.GetComponent<MonsterControllerBase>
	|-Task.GetComponent<PartnerNPCBehaviorController>
	|-Task.GetComponent<Animator>
	|-Task.GetComponent<object>
	*/

	// RVA: 0x1B24660 Offset: 0x1B24761 VA: 0x1B24660
	protected GameObject GetDefaultGameObject(GameObject go) { }

	// RVA: 0x1B246F0 Offset: 0x1B247F1 VA: 0x1B246F0
	public NodeData get_NodeData() { }

	// RVA: 0x1B24700 Offset: 0x1B24801 VA: 0x1B24700
	public void set_NodeData(NodeData value) { }

	// RVA: 0x1B24710 Offset: 0x1B24811 VA: 0x1B24710
	public Behavior get_Owner() { }

	// RVA: 0x1B24720 Offset: 0x1B24821 VA: 0x1B24720
	public void set_Owner(Behavior value) { }

	// RVA: 0x1B24730 Offset: 0x1B24831 VA: 0x1B24730
	public int get_ID() { }

	// RVA: 0x1B24740 Offset: 0x1B24841 VA: 0x1B24740
	public void set_ID(int value) { }

	// RVA: 0x1B24750 Offset: 0x1B24851 VA: 0x1B24750 Slot: 28
	public virtual string get_FriendlyName() { }

	// RVA: 0x1B24760 Offset: 0x1B24861 VA: 0x1B24760 Slot: 29
	public virtual void set_FriendlyName(string value) { }

	// RVA: 0x1B24770 Offset: 0x1B24871 VA: 0x1B24770
	public bool get_IsInstant() { }

	// RVA: 0x1B24780 Offset: 0x1B24881 VA: 0x1B24780
	public void set_IsInstant(bool value) { }

	// RVA: 0x1B24790 Offset: 0x1B24891 VA: 0x1B24790
	public int get_ReferenceID() { }

	// RVA: 0x1B247A0 Offset: 0x1B248A1 VA: 0x1B247A0
	public void set_ReferenceID(int value) { }

	// RVA: 0x1B247B0 Offset: 0x1B248B1 VA: 0x1B247B0
	public bool get_Disabled() { }

	// RVA: 0x1B247C0 Offset: 0x1B248C1 VA: 0x1B247C0
	public void set_Disabled(bool value) { }
}

